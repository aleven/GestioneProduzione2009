Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReport
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents reportDocumentSource As CrystalDecisions.CrystalReports.Engine.ReportDocument

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.reportDocumentSource = New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(648, 209)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(552, 215)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 17
        Me.btnChiudi.Text = "&Chiudi"
        '
        'frmReport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(648, 249)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReport"
        Me.Text = "Anteprima Di Stampa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ImpostaParametriServer()

        If Not IsNothing(reportDocumentSource) Then
            CrystalReportViewer1.ReportSource = reportDocumentSource
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ImpostaParametriServer()
        Dim ConfigAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
        Dim crInfo As ConnectionInfo

        crInfo = New ConnectionInfo
        'crInfo.ServerName = CType(ConfigAppSettings.GetValue("Report.ServerName", GetType(System.String)), String)
        crInfo.ServerName = ConnectionStringUtil.GetServer()
        'crInfo.DatabaseName = CType(ConfigAppSettings.GetValue("Report.DatabaseName", GetType(System.String)), String)
        crInfo.DatabaseName = ConnectionStringUtil.GetDataBase()
        'crInfo.UserID = CType(ConfigAppSettings.GetValue("Report.UserID", GetType(System.String)), String)
        crInfo.UserID = ConnectionStringUtil.GetUserName()
        'crInfo.Password = CType(ConfigAppSettings.GetValue("Report.Password", GetType(System.String)), String)
        crInfo.Password = ConnectionStringUtil.GetPassword()

        ApplyLogon(Me.reportDocumentSource, crInfo, True)
    End Sub

    ' Helper method that iterates through all tables in a report document 
    Private Function ApplyLogon(ByVal cr As ReportDocument, ByVal ci As ConnectionInfo, ByVal EnableSubReports As Boolean) As Boolean
        Dim li As TableLogOnInfo

        For Each tbl As Table In cr.Database.Tables

            li = tbl.LogOnInfo
            li.ConnectionInfo = ci
            tbl.ApplyLogOnInfo(li)

            If (tbl.TestConnectivity()) Then
                If (tbl.Location.IndexOf(".") > 0) Then
                    tbl.Location = tbl.Location.Substring(tbl.Location.LastIndexOf(".") + 1)
                Else
                    tbl.Location = tbl.Location
                End If
            Else
                Return (False)
            End If

        Next

        If EnableSubReports Then

            'GESTIONE SUBREPORTS
            Dim crSections As Sections
            crSections = cr.ReportDefinition.Sections
            For Each crSection As Section In crSections
                Dim crReportObjects As ReportObjects = crSection.ReportObjects

                For Each crReportObject As ReportObject In crReportObjects
                    If crReportObject.Kind = ReportObjectKind.SubreportObject Then

                        Dim crSubreportObject As SubreportObject = CType(crReportObject, SubreportObject)

                        Dim subReportDoc As ReportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
                        ApplyLogon(subReportDoc, ci, EnableSubReports)

                    End If
                Next

            Next
        End If

        Return (True)

    End Function

    Public Function EsportaInWord(ByRef fileWord As String, ByVal askPosition As Boolean)
        Dim res As Boolean = False

        Dim crExportOptions As New CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions

        If (askPosition) Then
            'Declare a SaveFileDialog object
            Dim objSaveFileDialog As New SaveFileDialog

            'Set the Save dialog properties
            With objSaveFileDialog
                .DefaultExt = "doc"
                .FileName = fileWord
                .Filter = "Word files (*.doc)|*.doc|All files (*.*)|*.*"
                .FilterIndex = 1
                .OverwritePrompt = True
                .Title = "Esporta in Word"
            End With

            If objSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileWord = objSaveFileDialog.FileName
            Else
                Return res
            End If
        End If

        Me.reportDocumentSource.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        crDiskFileDestinationOptions.DiskFileName = fileWord

        crExportOptions = Me.reportDocumentSource.ExportOptions
        crExportOptions.DestinationOptions = crDiskFileDestinationOptions
        crExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        crExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows

        ImpostaParametriServer()

        Me.reportDocumentSource.Export()
        res = True

        Return res
    End Function

    Public Function EsportaInExcel(ByRef fileExcel As String, ByVal askPosition As Boolean)
        Dim res As Boolean = False

        Dim crExportOptions As New CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions

        If (askPosition) Then
            'Declare a SaveFileDialog object
            Dim objSaveFileDialog As New SaveFileDialog

            'Set the Save dialog properties
            With objSaveFileDialog
                .DefaultExt = "xls"
                .FileName = fileExcel
                .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
                .FilterIndex = 1
                .OverwritePrompt = True
                .Title = "Esporta in Excel"
            End With

            If objSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                fileExcel = objSaveFileDialog.FileName
            Else
                Return res
            End If
        End If

        Me.reportDocumentSource.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        crDiskFileDestinationOptions.DiskFileName = fileExcel

        crExportOptions = Me.reportDocumentSource.ExportOptions
        crExportOptions.DestinationOptions = crDiskFileDestinationOptions
        crExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        crExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.Excel

        ImpostaParametriServer()

        Me.reportDocumentSource.Export()
        res = True

        Return res
    End Function

    Public Function EsportaInPDF(ByRef filePDF As String, ByVal askPosition As Boolean)
        Dim res As Boolean = False

        Dim crExportOptions As New CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions

        If (askPosition) Then
            'Declare a SaveFileDialog object
            Dim objSaveFileDialog As New SaveFileDialog

            'Set the Save dialog properties
            With objSaveFileDialog
                .DefaultExt = "pdf"
                .FileName = filePDF
                .Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
                .FilterIndex = 1
                .OverwritePrompt = True
                .Title = "Esporta in PDF"
            End With

            If objSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                filePDF = objSaveFileDialog.FileName
            Else
                Return res
            End If
        End If

        Me.reportDocumentSource.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4

        crDiskFileDestinationOptions.DiskFileName = filePDF

        crExportOptions = Me.reportDocumentSource.ExportOptions
        crExportOptions.DestinationOptions = crDiskFileDestinationOptions
        crExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
        crExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat

        ImpostaParametriServer()

        Me.reportDocumentSource.Export()
        res = True

        Return res
    End Function

    Private Sub frmReport_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.reportDocumentSource.Close()
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub CrystalReportViewer1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CrystalReportViewer1.KeyPress
        ManageEsc(e)
    End Sub

    Private Sub frmReport_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        ManageEsc(e)
    End Sub

    Private Sub ManageEsc(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub btnChiudi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub
End Class
