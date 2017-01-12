<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListinoRicambi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListinoRicambi))
        Me.pnlFiltri = New System.Windows.Forms.Panel
        Me.btnPreview = New System.Windows.Forms.Button
        Me.btnPdf = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFiltroMatricola = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ListinoRicambiDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ListinoRicambiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ListinoRicambiTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.ListinoRicambiTableAdapter
        Me.T26_formule_prezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T26_formule_prezziTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
        Me.pnlFiltri.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ListinoRicambiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListinoRicambiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFiltri
        '
        Me.pnlFiltri.Controls.Add(Me.btnPreview)
        Me.pnlFiltri.Controls.Add(Me.btnPdf)
        Me.pnlFiltri.Controls.Add(Me.btnExcel)
        Me.pnlFiltri.Controls.Add(Me.Label1)
        Me.pnlFiltri.Controls.Add(Me.txtFiltroMatricola)
        Me.pnlFiltri.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltri.Location = New System.Drawing.Point(0, 0)
        Me.pnlFiltri.Name = "pnlFiltri"
        Me.pnlFiltri.Size = New System.Drawing.Size(497, 50)
        Me.pnlFiltri.TabIndex = 2
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreview.Image = Global.GestioneProduzione.My.Resources.Resources.Printers2
        Me.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreview.Location = New System.Drawing.Point(441, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(44, 40)
        Me.btnPreview.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnPreview, "Anteprima di Stampa")
        '
        'btnPdf
        '
        Me.btnPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPdf.Image = Global.GestioneProduzione.My.Resources.Resources.export_pdf
        Me.btnPdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPdf.Location = New System.Drawing.Point(391, 4)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(44, 40)
        Me.btnPdf.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnPdf, "Esporta in PDF")
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.GestioneProduzione.My.Resources.Resources.export_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(344, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(44, 40)
        Me.btnExcel.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnExcel, "Esporta in Excel")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Matricola"
        '
        'txtFiltroMatricola
        '
        Me.txtFiltroMatricola.Location = New System.Drawing.Point(35, 24)
        Me.txtFiltroMatricola.Name = "txtFiltroMatricola"
        Me.txtFiltroMatricola.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroMatricola.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtFiltroMatricola, "Inserisci un testo da ricercare, pui usare il carattere * all'inizio o alla fine " & _
                "come carattere jolly")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListinoRicambiDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 253)
        Me.Panel1.TabIndex = 3
        '
        'ListinoRicambiDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.ListinoRicambiDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ListinoRicambiDataGridView.AutoGenerateColumns = False
        Me.ListinoRicambiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListinoRicambiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.ListinoRicambiDataGridView.DataSource = Me.ListinoRicambiBindingSource
        Me.ListinoRicambiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListinoRicambiDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ListinoRicambiDataGridView.Name = "ListinoRicambiDataGridView"
        Me.ListinoRicambiDataGridView.Size = New System.Drawing.Size(497, 253)
        Me.ListinoRicambiDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "t25_cod_matricola"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Matricola"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "t20_id_articolo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "t20_id_articolo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "t20_cod_articolo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codice"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "t20_descrizione"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "t20_prezzo"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "t20_prezzo_forzato"
        Me.DataGridViewTextBoxColumn5.HeaderText = "t20_prezzo_forzato"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "t20_dt_cancellazione"
        Me.DataGridViewTextBoxColumn6.HeaderText = "t20_dt_cancellazione"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "t20_is_ricambio"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "t20_is_ricambio"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'ListinoRicambiBindingSource
        '
        Me.ListinoRicambiBindingSource.DataMember = "ListinoRicambi"
        Me.ListinoRicambiBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListinoRicambiTableAdapter
        '
        Me.ListinoRicambiTableAdapter.ClearBeforeFill = True
        '
        'T26_formule_prezziBindingSource
        '
        Me.T26_formule_prezziBindingSource.DataMember = "t26_formule_prezzi"
        Me.T26_formule_prezziBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'T26_formule_prezziTableAdapter
        '
        Me.T26_formule_prezziTableAdapter.ClearBeforeFill = True
        '
        'frmListinoRicambi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 303)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlFiltri)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListinoRicambi"
        Me.Text = "Listino Ricambi"
        Me.pnlFiltri.ResumeLayout(False)
        Me.pnlFiltri.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ListinoRicambiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListinoRicambiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents ListinoRicambiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListinoRicambiTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.ListinoRicambiTableAdapter
    Friend WithEvents pnlFiltri As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroMatricola As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListinoRicambiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents T26_formule_prezziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T26_formule_prezziTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPdf As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
