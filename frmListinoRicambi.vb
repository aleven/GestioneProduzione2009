Imports VS2005Commons

Public Class frmListinoRicambi

    Private Sub frmListinoRicambi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        DataGridHelper.Configure(Me.ListinoRicambiDataGridView)

        CaricaDatiAccessori()
        CaricaDati()

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub CaricaDatiAccessori()
        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t26_formule_prezzi' table. You can move, or remove it, as needed.
        Me.T26_formule_prezziTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t26_formule_prezzi)
    End Sub

    Private Sub CaricaDati()
        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.ListinoRicambi' table. You can move, or remove it, as needed.
        Me.ListinoRicambiTableAdapter.Fill(Me.GestioneProduzione2009DataSet.ListinoRicambi)
        Me.GestioneProduzione2009DataSet.AggiornaPrezziListinoRicambi()
        Me.Refresh()

        Me.ListinoRicambiBindingSource.Sort = GestioneProduzione2009DataSet.ListinoRicambi.t25_cod_matricolaColumn.ColumnName

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FiltraDati()

        Me.ListinoRicambiBindingSource.Filter = VS2005Commons.QueryUtils.likeCondition(GestioneProduzione2009DataSet.ListinoRicambi.t25_cod_matricolaColumn.ColumnName, txtFiltroMatricola.Text, True)

    End Sub

    Private Sub txtFiltroMatricola_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroMatricola.TextChanged
        FiltraDati()
    End Sub

    Private Sub pnlFiltri_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlFiltri.Paint

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-Listino.rpt")) ' = New OrdiniFor
        'Applico lo stesso filtro della finestra
        If (Not StringUtils.isNullOrEmpty(Me.ListinoRicambiBindingSource.Filter)) Then
            FormReport.reportDocumentSource.RecordSelectionFormula = Me.ListinoRicambiBindingSource.Filter.Replace(GestioneProduzione2009DataSet.ListinoRicambi.t25_cod_matricolaColumn.ColumnName, "{ListinoRicambi.t25_cod_matricola}")
        End If
        FormReport.reportDocumentSource.SetDataSource(Me.GestioneProduzione2009DataSet)

        FormReport.Show()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-Listino.rpt")) ' = New OrdiniFor
        'Applico lo stesso filtro della finestra
        If (Not StringUtils.isNullOrEmpty(Me.ListinoRicambiBindingSource.Filter)) Then
            FormReport.reportDocumentSource.RecordSelectionFormula = Me.ListinoRicambiBindingSource.Filter.Replace(GestioneProduzione2009DataSet.ListinoRicambi.t25_cod_matricolaColumn.ColumnName, "{ListinoRicambi.t25_cod_matricola}")
        End If
        FormReport.reportDocumentSource.SetDataSource(Me.GestioneProduzione2009DataSet)

        Dim file As String
        file = "REDA-ListinoRicambi"
        file += IIf(StringUtils.isNotEmpty(txtFiltroMatricola.Text), "-" & FileUtils.encodeFileName(txtFiltroMatricola.Text), "")
        file += "-" & DateTime.Now.ToString(DateUtils.FORMAT_IT_MINUS)
        file += ".xls"

        file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Desktop, file)

        If FormReport.EsportaInExcel(file, True) Then Process.Start(file)

    End Sub

    Private Sub btnPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPdf.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-Listino.rpt")) ' = New OrdiniFor
        'Applico lo stesso filtro della finestra
        If (Not StringUtils.isNullOrEmpty(Me.ListinoRicambiBindingSource.Filter)) Then
            FormReport.reportDocumentSource.RecordSelectionFormula = Me.ListinoRicambiBindingSource.Filter.Replace(GestioneProduzione2009DataSet.ListinoRicambi.t25_cod_matricolaColumn.ColumnName, "{ListinoRicambi.t25_cod_matricola}")
        End If
        FormReport.reportDocumentSource.SetDataSource(Me.GestioneProduzione2009DataSet)

        Dim file As String
        file = "REDA-ListinoRicambi"
        file += IIf(StringUtils.isNotEmpty(txtFiltroMatricola.Text), "-" & FileUtils.encodeFileName(txtFiltroMatricola.Text), "")
        file += "-" & DateTime.Now.ToString(DateUtils.FORMAT_IT_MINUS)
        file += ".pdf"
        file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Desktop, file)

        If FormReport.EsportaInPDF(file, True) Then Process.Start(file)

    End Sub
End Class