Imports Microsoft.ApplicationBlocks.Data.SqlHelper
Imports VS2005Commons
Imports System.Text
Imports System.IO
Imports System.Transactions
Imports GestioneProduzione2014Data

Public Class frmEvasioneOrdiniRicambi
    Inherits System.Windows.Forms.Form
    Private _IDOrdine As Integer
    Private m_SQL As String

    Private fileMovimenti As StringBuilder = New StringBuilder()

    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T28_testate_ordini_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
    Friend WithEvents RigheOrdineRicambiTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.RigheOrdiniRicambiTableAdapter
    Friend WithEvents dgvRigheOrdine As System.Windows.Forms.DataGridView
    Friend WithEvents RigheOrdineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T29_righe_ordine_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
    Friend WithEvents T20_articoliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EvadiRigaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents T29idDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28idDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28codDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28commessaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28commessadelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28consegnaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28clienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28cliente2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28telefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28rifredaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28venditaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28riparazioneDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28completamentofornituraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28aspettoesterioreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28misureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28pesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28rifordineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28noteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28spedizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28portoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28dtcreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28dtmodificaDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents T28dtcancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28statotestataordineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28dataevasioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29idtestatat28DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29matricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29codDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29idarticolot20DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29qtordinataDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29prezzouniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29prezzototaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29dtcreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29dtmodificaDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents T29dtcancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29statorigaordineDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29qtevasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29dataevasioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29posizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20prezzoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20qtdisponibileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20lottoriordinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20isgruppoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T20dtcreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20dtmodificaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20dtcancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20idfornitoret11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20prezzoforzatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20isricambioDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T20timestampDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents btnEvadiOrdine As System.Windows.Forms.Button
    Friend WithEvents T22_articoli_articoliTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
    Friend WithEvents EvadiRigaCompletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblNrOrdine As System.Windows.Forms.Label
    Friend WithEvents txtNrOrdine As System.Windows.Forms.TextBox
    Friend WithEvents btnSceltaOrdine As System.Windows.Forms.Button
    Friend WithEvents txtDescrOrdine As System.Windows.Forms.TextBox
    Friend WithEvents lblDataOrdine As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerOrdine As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvasioneOrdiniRicambi))
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.txtDescrOrdine = New System.Windows.Forms.TextBox
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.lblNrOrdine = New System.Windows.Forms.Label
        Me.txtNrOrdine = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnSceltaOrdine = New System.Windows.Forms.Button
        Me.DateTimePickerOrdine = New System.Windows.Forms.DateTimePicker
        Me.lblDataOrdine = New System.Windows.Forms.Label
        Me.dgvRigheOrdine = New System.Windows.Forms.DataGridView
        Me.T29idDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28idDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28codDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28commessaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28commessadelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28consegnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28clienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28cliente2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28telefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28rifredaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28venditaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28riparazioneDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28completamentofornituraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28aspettoesterioreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28misureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28pesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28rifordineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28noteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28spedizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28portoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28dtcreazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28dtmodificaDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.T28dtcancellazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28statotestataordineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28dataevasioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29idtestatat28DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29matricolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29codDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29idarticolot20DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29qtordinataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29prezzouniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29prezzototaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29dtcreazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29dtmodificaDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.T29dtcancellazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29statorigaordineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29qtevasaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29dataevasioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29posizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20prezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20qtdisponibileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20lottoriordinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20isgruppoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T20dtcreazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20dtmodificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20dtcancellazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20idfornitoret11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20prezzoforzatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20isricambioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T20timestampDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn
        Me.RigheOrdineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EvadiRigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EvadiRigaCompletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.T28_testate_ordini_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
        Me.RigheOrdineRicambiTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.RigheOrdiniRicambiTableAdapter
        Me.T29_righe_ordine_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
        Me.T20_articoliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.T22_articoli_articoliTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.btnEvadiOrdine = New System.Windows.Forms.Button
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRigheOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RigheOrdineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 48)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(112, 23)
        Me.lblDescrizione.TabIndex = 3
        Me.lblDescrizione.Text = "Cliente :"
        '
        'txtDescrOrdine
        '
        Me.txtDescrOrdine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrOrdine.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestioneProduzione2009DataSet, "t28_testate_ordini_cli.t28_cliente", True))
        Me.txtDescrOrdine.Location = New System.Drawing.Point(95, 48)
        Me.txtDescrOrdine.MaxLength = 255
        Me.txtDescrOrdine.Multiline = True
        Me.txtDescrOrdine.Name = "txtDescrOrdine"
        Me.txtDescrOrdine.ReadOnly = True
        Me.txtDescrOrdine.Size = New System.Drawing.Size(693, 23)
        Me.txtDescrOrdine.TabIndex = 4
        Me.txtDescrOrdine.TabStop = False
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblNrOrdine
        '
        Me.lblNrOrdine.Location = New System.Drawing.Point(8, 16)
        Me.lblNrOrdine.Name = "lblNrOrdine"
        Me.lblNrOrdine.Size = New System.Drawing.Size(100, 23)
        Me.lblNrOrdine.TabIndex = 0
        Me.lblNrOrdine.Text = "Commessa :"
        '
        'txtNrOrdine
        '
        Me.txtNrOrdine.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestioneProduzione2009DataSet, "t28_testate_ordini_cli.t28_commessa", True))
        Me.txtNrOrdine.Location = New System.Drawing.Point(95, 16)
        Me.txtNrOrdine.MaxLength = 20
        Me.txtNrOrdine.Name = "txtNrOrdine"
        Me.txtNrOrdine.ReadOnly = True
        Me.txtNrOrdine.Size = New System.Drawing.Size(88, 20)
        Me.txtNrOrdine.TabIndex = 1
        Me.txtNrOrdine.TabStop = False
        Me.txtNrOrdine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtNrOrdine, "Codice Articolo (F9=Ricerca)")
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestioneProduzione2009DataSet, "t28_testate_ordini_cli.t28_note", True))
        Me.TextBox2.Location = New System.Drawing.Point(56, 358)
        Me.TextBox2.MaxLength = 20
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(500, 20)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.TabStop = False
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBox2, "Codice Articolo (F9=Ricerca)")
        '
        'btnSceltaOrdine
        '
        Me.btnSceltaOrdine.Image = Global.GestioneProduzione.My.Resources.Resources.cerca
        Me.btnSceltaOrdine.Location = New System.Drawing.Point(189, 9)
        Me.btnSceltaOrdine.Name = "btnSceltaOrdine"
        Me.btnSceltaOrdine.Size = New System.Drawing.Size(32, 32)
        Me.btnSceltaOrdine.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSceltaOrdine, "Ricerca e selezione ordine")
        '
        'DateTimePickerOrdine
        '
        Me.DateTimePickerOrdine.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerOrdine.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GestioneProduzione2009DataSet, "t28_testate_ordini_cli.t28_commessa_del", True))
        Me.DateTimePickerOrdine.Enabled = False
        Me.DateTimePickerOrdine.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOrdine.Location = New System.Drawing.Point(95, 104)
        Me.DateTimePickerOrdine.Name = "DateTimePickerOrdine"
        Me.DateTimePickerOrdine.ShowCheckBox = True
        Me.DateTimePickerOrdine.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePickerOrdine.TabIndex = 10
        '
        'lblDataOrdine
        '
        Me.lblDataOrdine.Location = New System.Drawing.Point(8, 104)
        Me.lblDataOrdine.Name = "lblDataOrdine"
        Me.lblDataOrdine.Size = New System.Drawing.Size(96, 23)
        Me.lblDataOrdine.TabIndex = 9
        Me.lblDataOrdine.Text = "Commessa del :"
        '
        'dgvRigheOrdine
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvRigheOrdine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRigheOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRigheOrdine.AutoGenerateColumns = False
        Me.dgvRigheOrdine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRigheOrdine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T29idDataGridViewTextBoxColumn, Me.T28idDataGridViewTextBoxColumn, Me.T28codDataGridViewTextBoxColumn, Me.T28descrizioneDataGridViewTextBoxColumn, Me.T28commessaDataGridViewTextBoxColumn, Me.T28commessadelDataGridViewTextBoxColumn, Me.T28consegnaDataGridViewTextBoxColumn, Me.T28clienteDataGridViewTextBoxColumn, Me.T28cliente2DataGridViewTextBoxColumn, Me.T28telefonoDataGridViewTextBoxColumn, Me.T28rifredaDataGridViewTextBoxColumn, Me.T28venditaDataGridViewCheckBoxColumn, Me.T28riparazioneDataGridViewCheckBoxColumn, Me.T28completamentofornituraDataGridViewCheckBoxColumn, Me.T28aspettoesterioreDataGridViewTextBoxColumn, Me.T28misureDataGridViewTextBoxColumn, Me.T28pesoDataGridViewTextBoxColumn, Me.T28rifordineDataGridViewTextBoxColumn, Me.T28noteDataGridViewTextBoxColumn, Me.T28spedizioneDataGridViewTextBoxColumn, Me.T28portoDataGridViewTextBoxColumn, Me.T28dtcreazioneDataGridViewTextBoxColumn, Me.T28dtmodificaDataGridViewImageColumn, Me.T28dtcancellazioneDataGridViewTextBoxColumn, Me.T28statotestataordineDataGridViewTextBoxColumn, Me.T28dataevasioneDataGridViewTextBoxColumn, Me.T29idtestatat28DataGridViewTextBoxColumn, Me.T29matricolaDataGridViewTextBoxColumn, Me.T29codDataGridViewTextBoxColumn, Me.T29descrizioneDataGridViewTextBoxColumn, Me.T29idarticolot20DataGridViewTextBoxColumn, Me.T29qtordinataDataGridViewTextBoxColumn, Me.T29prezzouniDataGridViewTextBoxColumn, Me.T29prezzototaDataGridViewTextBoxColumn, Me.T29dtcreazioneDataGridViewTextBoxColumn, Me.T29dtmodificaDataGridViewImageColumn, Me.T29dtcancellazioneDataGridViewTextBoxColumn, Me.T29statorigaordineDataGridViewTextBoxColumn, Me.T29qtevasaDataGridViewTextBoxColumn, Me.T29dataevasioneDataGridViewTextBoxColumn, Me.T29posizioneDataGridViewTextBoxColumn, Me.T20idarticoloDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn, Me.T20prezzoDataGridViewTextBoxColumn, Me.T20qtdisponibileDataGridViewTextBoxColumn, Me.T20lottoriordinoDataGridViewTextBoxColumn, Me.T20isgruppoDataGridViewCheckBoxColumn, Me.T20dtcreazioneDataGridViewTextBoxColumn, Me.T20dtmodificaDataGridViewTextBoxColumn, Me.T20dtcancellazioneDataGridViewTextBoxColumn, Me.T20idfornitoret11DataGridViewTextBoxColumn, Me.T20prezzoforzatoDataGridViewTextBoxColumn, Me.T20isricambioDataGridViewCheckBoxColumn, Me.T20timestampDataGridViewImageColumn})
        Me.dgvRigheOrdine.DataSource = Me.RigheOrdineBindingSource
        Me.dgvRigheOrdine.Location = New System.Drawing.Point(11, 130)
        Me.dgvRigheOrdine.MultiSelect = False
        Me.dgvRigheOrdine.Name = "dgvRigheOrdine"
        Me.dgvRigheOrdine.Size = New System.Drawing.Size(777, 209)
        Me.dgvRigheOrdine.TabIndex = 11
        '
        'T29idDataGridViewTextBoxColumn
        '
        Me.T29idDataGridViewTextBoxColumn.DataPropertyName = "t29_id"
        Me.T29idDataGridViewTextBoxColumn.HeaderText = "t29_id"
        Me.T29idDataGridViewTextBoxColumn.Name = "T29idDataGridViewTextBoxColumn"
        Me.T29idDataGridViewTextBoxColumn.ReadOnly = True
        Me.T29idDataGridViewTextBoxColumn.Visible = False
        '
        'T28idDataGridViewTextBoxColumn
        '
        Me.T28idDataGridViewTextBoxColumn.DataPropertyName = "t28_id"
        Me.T28idDataGridViewTextBoxColumn.HeaderText = "t28_id"
        Me.T28idDataGridViewTextBoxColumn.Name = "T28idDataGridViewTextBoxColumn"
        Me.T28idDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28idDataGridViewTextBoxColumn.Visible = False
        '
        'T28codDataGridViewTextBoxColumn
        '
        Me.T28codDataGridViewTextBoxColumn.DataPropertyName = "t28_cod"
        Me.T28codDataGridViewTextBoxColumn.HeaderText = "t28_cod"
        Me.T28codDataGridViewTextBoxColumn.Name = "T28codDataGridViewTextBoxColumn"
        Me.T28codDataGridViewTextBoxColumn.Visible = False
        '
        'T28descrizioneDataGridViewTextBoxColumn
        '
        Me.T28descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t28_descrizione"
        Me.T28descrizioneDataGridViewTextBoxColumn.HeaderText = "t28_descrizione"
        Me.T28descrizioneDataGridViewTextBoxColumn.Name = "T28descrizioneDataGridViewTextBoxColumn"
        Me.T28descrizioneDataGridViewTextBoxColumn.Visible = False
        '
        'T28commessaDataGridViewTextBoxColumn
        '
        Me.T28commessaDataGridViewTextBoxColumn.DataPropertyName = "t28_commessa"
        Me.T28commessaDataGridViewTextBoxColumn.HeaderText = "t28_commessa"
        Me.T28commessaDataGridViewTextBoxColumn.Name = "T28commessaDataGridViewTextBoxColumn"
        Me.T28commessaDataGridViewTextBoxColumn.Visible = False
        '
        'T28commessadelDataGridViewTextBoxColumn
        '
        Me.T28commessadelDataGridViewTextBoxColumn.DataPropertyName = "t28_commessa_del"
        Me.T28commessadelDataGridViewTextBoxColumn.HeaderText = "t28_commessa_del"
        Me.T28commessadelDataGridViewTextBoxColumn.Name = "T28commessadelDataGridViewTextBoxColumn"
        Me.T28commessadelDataGridViewTextBoxColumn.Visible = False
        '
        'T28consegnaDataGridViewTextBoxColumn
        '
        Me.T28consegnaDataGridViewTextBoxColumn.DataPropertyName = "t28_consegna"
        Me.T28consegnaDataGridViewTextBoxColumn.HeaderText = "t28_consegna"
        Me.T28consegnaDataGridViewTextBoxColumn.Name = "T28consegnaDataGridViewTextBoxColumn"
        Me.T28consegnaDataGridViewTextBoxColumn.Visible = False
        '
        'T28clienteDataGridViewTextBoxColumn
        '
        Me.T28clienteDataGridViewTextBoxColumn.DataPropertyName = "t28_cliente"
        Me.T28clienteDataGridViewTextBoxColumn.HeaderText = "t28_cliente"
        Me.T28clienteDataGridViewTextBoxColumn.Name = "T28clienteDataGridViewTextBoxColumn"
        Me.T28clienteDataGridViewTextBoxColumn.Visible = False
        '
        'T28cliente2DataGridViewTextBoxColumn
        '
        Me.T28cliente2DataGridViewTextBoxColumn.DataPropertyName = "t28_cliente2"
        Me.T28cliente2DataGridViewTextBoxColumn.HeaderText = "t28_cliente2"
        Me.T28cliente2DataGridViewTextBoxColumn.Name = "T28cliente2DataGridViewTextBoxColumn"
        Me.T28cliente2DataGridViewTextBoxColumn.Visible = False
        '
        'T28telefonoDataGridViewTextBoxColumn
        '
        Me.T28telefonoDataGridViewTextBoxColumn.DataPropertyName = "t28_telefono"
        Me.T28telefonoDataGridViewTextBoxColumn.HeaderText = "t28_telefono"
        Me.T28telefonoDataGridViewTextBoxColumn.Name = "T28telefonoDataGridViewTextBoxColumn"
        Me.T28telefonoDataGridViewTextBoxColumn.Visible = False
        '
        'T28rifredaDataGridViewTextBoxColumn
        '
        Me.T28rifredaDataGridViewTextBoxColumn.DataPropertyName = "t28_rif_reda"
        Me.T28rifredaDataGridViewTextBoxColumn.HeaderText = "t28_rif_reda"
        Me.T28rifredaDataGridViewTextBoxColumn.Name = "T28rifredaDataGridViewTextBoxColumn"
        Me.T28rifredaDataGridViewTextBoxColumn.Visible = False
        '
        'T28venditaDataGridViewCheckBoxColumn
        '
        Me.T28venditaDataGridViewCheckBoxColumn.DataPropertyName = "t28_vendita"
        Me.T28venditaDataGridViewCheckBoxColumn.HeaderText = "t28_vendita"
        Me.T28venditaDataGridViewCheckBoxColumn.Name = "T28venditaDataGridViewCheckBoxColumn"
        Me.T28venditaDataGridViewCheckBoxColumn.Visible = False
        '
        'T28riparazioneDataGridViewCheckBoxColumn
        '
        Me.T28riparazioneDataGridViewCheckBoxColumn.DataPropertyName = "t28_riparazione"
        Me.T28riparazioneDataGridViewCheckBoxColumn.HeaderText = "t28_riparazione"
        Me.T28riparazioneDataGridViewCheckBoxColumn.Name = "T28riparazioneDataGridViewCheckBoxColumn"
        Me.T28riparazioneDataGridViewCheckBoxColumn.Visible = False
        '
        'T28completamentofornituraDataGridViewCheckBoxColumn
        '
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.DataPropertyName = "t28_completamento_fornitura"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.HeaderText = "t28_completamento_fornitura"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.Name = "T28completamentofornituraDataGridViewCheckBoxColumn"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.Visible = False
        '
        'T28aspettoesterioreDataGridViewTextBoxColumn
        '
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.DataPropertyName = "t28_aspetto_esteriore"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.HeaderText = "t28_aspetto_esteriore"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.Name = "T28aspettoesterioreDataGridViewTextBoxColumn"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.Visible = False
        '
        'T28misureDataGridViewTextBoxColumn
        '
        Me.T28misureDataGridViewTextBoxColumn.DataPropertyName = "t28_misure"
        Me.T28misureDataGridViewTextBoxColumn.HeaderText = "t28_misure"
        Me.T28misureDataGridViewTextBoxColumn.Name = "T28misureDataGridViewTextBoxColumn"
        Me.T28misureDataGridViewTextBoxColumn.Visible = False
        '
        'T28pesoDataGridViewTextBoxColumn
        '
        Me.T28pesoDataGridViewTextBoxColumn.DataPropertyName = "t28_peso"
        Me.T28pesoDataGridViewTextBoxColumn.HeaderText = "t28_peso"
        Me.T28pesoDataGridViewTextBoxColumn.Name = "T28pesoDataGridViewTextBoxColumn"
        Me.T28pesoDataGridViewTextBoxColumn.Visible = False
        '
        'T28rifordineDataGridViewTextBoxColumn
        '
        Me.T28rifordineDataGridViewTextBoxColumn.DataPropertyName = "t28_rif_ordine"
        Me.T28rifordineDataGridViewTextBoxColumn.HeaderText = "t28_rif_ordine"
        Me.T28rifordineDataGridViewTextBoxColumn.Name = "T28rifordineDataGridViewTextBoxColumn"
        Me.T28rifordineDataGridViewTextBoxColumn.Visible = False
        '
        'T28noteDataGridViewTextBoxColumn
        '
        Me.T28noteDataGridViewTextBoxColumn.DataPropertyName = "t28_note"
        Me.T28noteDataGridViewTextBoxColumn.HeaderText = "t28_note"
        Me.T28noteDataGridViewTextBoxColumn.Name = "T28noteDataGridViewTextBoxColumn"
        Me.T28noteDataGridViewTextBoxColumn.Visible = False
        '
        'T28spedizioneDataGridViewTextBoxColumn
        '
        Me.T28spedizioneDataGridViewTextBoxColumn.DataPropertyName = "t28_spedizione"
        Me.T28spedizioneDataGridViewTextBoxColumn.HeaderText = "t28_spedizione"
        Me.T28spedizioneDataGridViewTextBoxColumn.Name = "T28spedizioneDataGridViewTextBoxColumn"
        Me.T28spedizioneDataGridViewTextBoxColumn.Visible = False
        '
        'T28portoDataGridViewTextBoxColumn
        '
        Me.T28portoDataGridViewTextBoxColumn.DataPropertyName = "t28_porto"
        Me.T28portoDataGridViewTextBoxColumn.HeaderText = "t28_porto"
        Me.T28portoDataGridViewTextBoxColumn.Name = "T28portoDataGridViewTextBoxColumn"
        Me.T28portoDataGridViewTextBoxColumn.Visible = False
        '
        'T28dtcreazioneDataGridViewTextBoxColumn
        '
        Me.T28dtcreazioneDataGridViewTextBoxColumn.DataPropertyName = "t28_dt_creazione"
        Me.T28dtcreazioneDataGridViewTextBoxColumn.HeaderText = "t28_dt_creazione"
        Me.T28dtcreazioneDataGridViewTextBoxColumn.Name = "T28dtcreazioneDataGridViewTextBoxColumn"
        Me.T28dtcreazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T28dtmodificaDataGridViewImageColumn
        '
        Me.T28dtmodificaDataGridViewImageColumn.DataPropertyName = "t28_dt_modifica"
        Me.T28dtmodificaDataGridViewImageColumn.HeaderText = "t28_dt_modifica"
        Me.T28dtmodificaDataGridViewImageColumn.Name = "T28dtmodificaDataGridViewImageColumn"
        Me.T28dtmodificaDataGridViewImageColumn.ReadOnly = True
        Me.T28dtmodificaDataGridViewImageColumn.Visible = False
        '
        'T28dtcancellazioneDataGridViewTextBoxColumn
        '
        Me.T28dtcancellazioneDataGridViewTextBoxColumn.DataPropertyName = "t28_dt_cancellazione"
        Me.T28dtcancellazioneDataGridViewTextBoxColumn.HeaderText = "t28_dt_cancellazione"
        Me.T28dtcancellazioneDataGridViewTextBoxColumn.Name = "T28dtcancellazioneDataGridViewTextBoxColumn"
        Me.T28dtcancellazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T28statotestataordineDataGridViewTextBoxColumn
        '
        Me.T28statotestataordineDataGridViewTextBoxColumn.DataPropertyName = "t28_stato_testata_ordine"
        Me.T28statotestataordineDataGridViewTextBoxColumn.HeaderText = "t28_stato_testata_ordine"
        Me.T28statotestataordineDataGridViewTextBoxColumn.Name = "T28statotestataordineDataGridViewTextBoxColumn"
        Me.T28statotestataordineDataGridViewTextBoxColumn.Visible = False
        '
        'T28dataevasioneDataGridViewTextBoxColumn
        '
        Me.T28dataevasioneDataGridViewTextBoxColumn.DataPropertyName = "t28_data_evasione"
        Me.T28dataevasioneDataGridViewTextBoxColumn.HeaderText = "t28_data_evasione"
        Me.T28dataevasioneDataGridViewTextBoxColumn.Name = "T28dataevasioneDataGridViewTextBoxColumn"
        Me.T28dataevasioneDataGridViewTextBoxColumn.Visible = False
        '
        'T29idtestatat28DataGridViewTextBoxColumn
        '
        Me.T29idtestatat28DataGridViewTextBoxColumn.DataPropertyName = "t29_id_testata_t28"
        Me.T29idtestatat28DataGridViewTextBoxColumn.HeaderText = "t29_id_testata_t28"
        Me.T29idtestatat28DataGridViewTextBoxColumn.Name = "T29idtestatat28DataGridViewTextBoxColumn"
        Me.T29idtestatat28DataGridViewTextBoxColumn.Visible = False
        '
        'T29matricolaDataGridViewTextBoxColumn
        '
        Me.T29matricolaDataGridViewTextBoxColumn.DataPropertyName = "t29_matricola"
        Me.T29matricolaDataGridViewTextBoxColumn.HeaderText = "Matricola"
        Me.T29matricolaDataGridViewTextBoxColumn.Name = "T29matricolaDataGridViewTextBoxColumn"
        '
        'T29codDataGridViewTextBoxColumn
        '
        Me.T29codDataGridViewTextBoxColumn.DataPropertyName = "t29_cod"
        Me.T29codDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.T29codDataGridViewTextBoxColumn.Name = "T29codDataGridViewTextBoxColumn"
        '
        'T29descrizioneDataGridViewTextBoxColumn
        '
        Me.T29descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t29_descrizione"
        Me.T29descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.T29descrizioneDataGridViewTextBoxColumn.Name = "T29descrizioneDataGridViewTextBoxColumn"
        '
        'T29idarticolot20DataGridViewTextBoxColumn
        '
        Me.T29idarticolot20DataGridViewTextBoxColumn.DataPropertyName = "t29_id_articolo_t20"
        Me.T29idarticolot20DataGridViewTextBoxColumn.HeaderText = "t29_id_articolo_t20"
        Me.T29idarticolot20DataGridViewTextBoxColumn.Name = "T29idarticolot20DataGridViewTextBoxColumn"
        Me.T29idarticolot20DataGridViewTextBoxColumn.Visible = False
        '
        'T29qtordinataDataGridViewTextBoxColumn
        '
        Me.T29qtordinataDataGridViewTextBoxColumn.DataPropertyName = "t29_qt_ordinata"
        Me.T29qtordinataDataGridViewTextBoxColumn.HeaderText = "Qt.Ordinata"
        Me.T29qtordinataDataGridViewTextBoxColumn.Name = "T29qtordinataDataGridViewTextBoxColumn"
        '
        'T29prezzouniDataGridViewTextBoxColumn
        '
        Me.T29prezzouniDataGridViewTextBoxColumn.DataPropertyName = "t29_prezzo_uni"
        Me.T29prezzouniDataGridViewTextBoxColumn.HeaderText = "t29_prezzo_uni"
        Me.T29prezzouniDataGridViewTextBoxColumn.Name = "T29prezzouniDataGridViewTextBoxColumn"
        Me.T29prezzouniDataGridViewTextBoxColumn.Visible = False
        '
        'T29prezzototaDataGridViewTextBoxColumn
        '
        Me.T29prezzototaDataGridViewTextBoxColumn.DataPropertyName = "t29_prezzo_tota"
        Me.T29prezzototaDataGridViewTextBoxColumn.HeaderText = "t29_prezzo_tota"
        Me.T29prezzototaDataGridViewTextBoxColumn.Name = "T29prezzototaDataGridViewTextBoxColumn"
        Me.T29prezzototaDataGridViewTextBoxColumn.Visible = False
        '
        'T29dtcreazioneDataGridViewTextBoxColumn
        '
        Me.T29dtcreazioneDataGridViewTextBoxColumn.DataPropertyName = "t29_dt_creazione"
        Me.T29dtcreazioneDataGridViewTextBoxColumn.HeaderText = "t29_dt_creazione"
        Me.T29dtcreazioneDataGridViewTextBoxColumn.Name = "T29dtcreazioneDataGridViewTextBoxColumn"
        Me.T29dtcreazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T29dtmodificaDataGridViewImageColumn
        '
        Me.T29dtmodificaDataGridViewImageColumn.DataPropertyName = "t29_dt_modifica"
        Me.T29dtmodificaDataGridViewImageColumn.HeaderText = "t29_dt_modifica"
        Me.T29dtmodificaDataGridViewImageColumn.Name = "T29dtmodificaDataGridViewImageColumn"
        Me.T29dtmodificaDataGridViewImageColumn.ReadOnly = True
        Me.T29dtmodificaDataGridViewImageColumn.Visible = False
        '
        'T29dtcancellazioneDataGridViewTextBoxColumn
        '
        Me.T29dtcancellazioneDataGridViewTextBoxColumn.DataPropertyName = "t29_dt_cancellazione"
        Me.T29dtcancellazioneDataGridViewTextBoxColumn.HeaderText = "t29_dt_cancellazione"
        Me.T29dtcancellazioneDataGridViewTextBoxColumn.Name = "T29dtcancellazioneDataGridViewTextBoxColumn"
        Me.T29dtcancellazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T29statorigaordineDataGridViewTextBoxColumn
        '
        Me.T29statorigaordineDataGridViewTextBoxColumn.DataPropertyName = "t29_stato_riga_ordine"
        Me.T29statorigaordineDataGridViewTextBoxColumn.HeaderText = "t29_stato_riga_ordine"
        Me.T29statorigaordineDataGridViewTextBoxColumn.Name = "T29statorigaordineDataGridViewTextBoxColumn"
        Me.T29statorigaordineDataGridViewTextBoxColumn.Visible = False
        '
        'T29qtevasaDataGridViewTextBoxColumn
        '
        Me.T29qtevasaDataGridViewTextBoxColumn.DataPropertyName = "t29_qt_evasa"
        Me.T29qtevasaDataGridViewTextBoxColumn.HeaderText = "Qt.Evasa"
        Me.T29qtevasaDataGridViewTextBoxColumn.Name = "T29qtevasaDataGridViewTextBoxColumn"
        '
        'T29dataevasioneDataGridViewTextBoxColumn
        '
        Me.T29dataevasioneDataGridViewTextBoxColumn.DataPropertyName = "t29_data_evasione"
        Me.T29dataevasioneDataGridViewTextBoxColumn.HeaderText = "Data Evasione"
        Me.T29dataevasioneDataGridViewTextBoxColumn.Name = "T29dataevasioneDataGridViewTextBoxColumn"
        '
        'T29posizioneDataGridViewTextBoxColumn
        '
        Me.T29posizioneDataGridViewTextBoxColumn.DataPropertyName = "t29_posizione"
        Me.T29posizioneDataGridViewTextBoxColumn.HeaderText = "t29_posizione"
        Me.T29posizioneDataGridViewTextBoxColumn.Name = "T29posizioneDataGridViewTextBoxColumn"
        Me.T29posizioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20idarticoloDataGridViewTextBoxColumn
        '
        Me.T20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.Name = "T20idarticoloDataGridViewTextBoxColumn"
        Me.T20idarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20idarticoloDataGridViewTextBoxColumn.Visible = False
        '
        'T20codarticoloDataGridViewTextBoxColumn
        '
        Me.T20codarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_cod_articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "t20_cod_articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.Visible = False
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20prezzoDataGridViewTextBoxColumn
        '
        Me.T20prezzoDataGridViewTextBoxColumn.DataPropertyName = "t20_prezzo"
        Me.T20prezzoDataGridViewTextBoxColumn.HeaderText = "t20_prezzo"
        Me.T20prezzoDataGridViewTextBoxColumn.Name = "T20prezzoDataGridViewTextBoxColumn"
        Me.T20prezzoDataGridViewTextBoxColumn.Visible = False
        '
        'T20qtdisponibileDataGridViewTextBoxColumn
        '
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DataPropertyName = "t20_qt_disponibile"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.HeaderText = "t20_qt_disponibile"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Name = "T20qtdisponibileDataGridViewTextBoxColumn"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Visible = False
        '
        'T20lottoriordinoDataGridViewTextBoxColumn
        '
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DataPropertyName = "t20_lotto_riordino"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.HeaderText = "t20_lotto_riordino"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.Name = "T20lottoriordinoDataGridViewTextBoxColumn"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.Visible = False
        '
        'T20isgruppoDataGridViewCheckBoxColumn
        '
        Me.T20isgruppoDataGridViewCheckBoxColumn.DataPropertyName = "t20_is_gruppo"
        Me.T20isgruppoDataGridViewCheckBoxColumn.HeaderText = "t20_is_gruppo"
        Me.T20isgruppoDataGridViewCheckBoxColumn.Name = "T20isgruppoDataGridViewCheckBoxColumn"
        Me.T20isgruppoDataGridViewCheckBoxColumn.Visible = False
        '
        'T20dtcreazioneDataGridViewTextBoxColumn
        '
        Me.T20dtcreazioneDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_creazione"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.HeaderText = "t20_dt_creazione"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.Name = "T20dtcreazioneDataGridViewTextBoxColumn"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20dtmodificaDataGridViewTextBoxColumn
        '
        Me.T20dtmodificaDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_modifica"
        Me.T20dtmodificaDataGridViewTextBoxColumn.HeaderText = "t20_dt_modifica"
        Me.T20dtmodificaDataGridViewTextBoxColumn.Name = "T20dtmodificaDataGridViewTextBoxColumn"
        Me.T20dtmodificaDataGridViewTextBoxColumn.Visible = False
        '
        'T20dtcancellazioneDataGridViewTextBoxColumn
        '
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_cancellazione"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.HeaderText = "t20_dt_cancellazione"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.Name = "T20dtcancellazioneDataGridViewTextBoxColumn"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20idfornitoret11DataGridViewTextBoxColumn
        '
        Me.T20idfornitoret11DataGridViewTextBoxColumn.DataPropertyName = "t20_id_fornitore_t11"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.HeaderText = "t20_id_fornitore_t11"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.Name = "T20idfornitoret11DataGridViewTextBoxColumn"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.Visible = False
        '
        'T20prezzoforzatoDataGridViewTextBoxColumn
        '
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.DataPropertyName = "t20_prezzo_forzato"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.HeaderText = "t20_prezzo_forzato"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.Name = "T20prezzoforzatoDataGridViewTextBoxColumn"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.Visible = False
        '
        'T20isricambioDataGridViewCheckBoxColumn
        '
        Me.T20isricambioDataGridViewCheckBoxColumn.DataPropertyName = "t20_is_ricambio"
        Me.T20isricambioDataGridViewCheckBoxColumn.HeaderText = "t20_is_ricambio"
        Me.T20isricambioDataGridViewCheckBoxColumn.Name = "T20isricambioDataGridViewCheckBoxColumn"
        Me.T20isricambioDataGridViewCheckBoxColumn.Visible = False
        '
        'T20timestampDataGridViewImageColumn
        '
        Me.T20timestampDataGridViewImageColumn.DataPropertyName = "t20_timestamp"
        Me.T20timestampDataGridViewImageColumn.HeaderText = "t20_timestamp"
        Me.T20timestampDataGridViewImageColumn.Name = "T20timestampDataGridViewImageColumn"
        Me.T20timestampDataGridViewImageColumn.ReadOnly = True
        Me.T20timestampDataGridViewImageColumn.Visible = False
        '
        'RigheOrdineBindingSource
        '
        Me.RigheOrdineBindingSource.DataMember = "RigheOrdiniRicambi"
        Me.RigheOrdineBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EvadiRigaToolStripMenuItem, Me.EvadiRigaCompletaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(184, 48)
        '
        'EvadiRigaToolStripMenuItem
        '
        Me.EvadiRigaToolStripMenuItem.Name = "EvadiRigaToolStripMenuItem"
        Me.EvadiRigaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EvadiRigaToolStripMenuItem.Text = "Evadi Riga"
        '
        'EvadiRigaCompletaToolStripMenuItem
        '
        Me.EvadiRigaCompletaToolStripMenuItem.Name = "EvadiRigaCompletaToolStripMenuItem"
        Me.EvadiRigaCompletaToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.EvadiRigaCompletaToolStripMenuItem.Text = "Evadi Riga Completa"
        '
        'T28_testate_ordini_cliTableAdapter
        '
        Me.T28_testate_ordini_cliTableAdapter.ClearBeforeFill = True
        '
        'RigheOrdineRicambiTableAdapter
        '
        Me.RigheOrdineRicambiTableAdapter.ClearBeforeFill = True
        '
        'T29_righe_ordine_cliTableAdapter
        '
        Me.T29_righe_ordine_cliTableAdapter.ClearBeforeFill = True
        '
        'T20_articoliTableAdapter
        '
        Me.T20_articoliTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GestioneProduzione2009DataSet, "t28_testate_ordini_cli.t28_cliente2", True))
        Me.TextBox1.Location = New System.Drawing.Point(95, 74)
        Me.TextBox1.MaxLength = 255
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(693, 23)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Note :"
        '
        'T22_articoli_articoliTableAdapter1
        '
        Me.T22_articoli_articoliTableAdapter1.ClearBeforeFill = True
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(692, 351)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 16
        Me.btnChiudi.Text = "&Chiudi"
        '
        'btnEvadiOrdine
        '
        Me.btnEvadiOrdine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvadiOrdine.Image = Global.GestioneProduzione.My.Resources.Resources.apply
        Me.btnEvadiOrdine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEvadiOrdine.Location = New System.Drawing.Point(562, 351)
        Me.btnEvadiOrdine.Name = "btnEvadiOrdine"
        Me.btnEvadiOrdine.Size = New System.Drawing.Size(124, 32)
        Me.btnEvadiOrdine.TabIndex = 17
        Me.btnEvadiOrdine.Text = "&Evadi Ordine"
        '
        'frmEvasioneOrdiniRicambi
        '
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(800, 391)
        Me.Controls.Add(Me.btnEvadiOrdine)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgvRigheOrdine)
        Me.Controls.Add(Me.DateTimePickerOrdine)
        Me.Controls.Add(Me.lblDataOrdine)
        Me.Controls.Add(Me.txtNrOrdine)
        Me.Controls.Add(Me.txtDescrOrdine)
        Me.Controls.Add(Me.btnSceltaOrdine)
        Me.Controls.Add(Me.lblNrOrdine)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvasioneOrdiniRicambi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evasione Commessa Ricambi"
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRigheOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RigheOrdineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property IDOrdine() As Integer
        Get
            Return _IDOrdine
        End Get
        Set(ByVal Value As Integer)
            _IDOrdine = Value
        End Set
    End Property



    Private Sub frmEvasioneOrdiniCli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridHelper.Configure(dgvRigheOrdine)

        Me.DateTimePickerOrdine.Value = Date.Today

        If _IDOrdine > 0 Then 'Chiamata con parametro
            Call CaricaDatiOrdine()
            VerificaOrdineERighe()
        End If

    End Sub

    Private Sub btnSceltaOrdine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaOrdine.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'Dim FormElencoOrdiniCli As New frmElencoOrdiniCli
        'FormElencoOrdiniCli.Ricerca = True
        'FormElencoOrdiniCli.ShowDialog()
        Dim form As New frmOrdiniRicambiElenco()
        form.ModoSelezione = True
        If form.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If form.IdSelezionato <> -1 Then
                _IDOrdine = form.IdSelezionato
                Call CaricaDatiOrdine()
                VerificaOrdineERighe()
            End If
        End If

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub CaricaDatiOrdine()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'Dim DROrdine As SqlClient.SqlDataReader
        'm_SQL = "SELECT * FROM t28_testate_ordini_cli WHERE t28_id = " & m_IDOrdine.ToString
        'DROrdine = ExecuteReader(conn.ConnectionString, CommandType.Text, m_SQL)
        T28_testate_ordini_cliTableAdapter.ClearBeforeFill = True
        T28_testate_ordini_cliTableAdapter.FillById(GestioneProduzione2009DataSet.t28_testate_ordini_cli, IDOrdine)

        If ADONetUtils.hasRows(GestioneProduzione2009DataSet.t28_testate_ordini_cli) Then

            ' Carico le Righe
            RigheOrdineRicambiTableAdapter.ClearBeforeFill = True
            RigheOrdineRicambiTableAdapter.Fill(Me.GestioneProduzione2009DataSet.RigheOrdiniRicambi, frmOrdiniRicambiNuovo.STATO_APERTO, IDOrdine)

            'DROrdine.Read()

            'If DROrdine("t28_id").GetType Is Type.GetType("System.DBNull") Then
            '    Me.txtNrOrdine.Text = ""
            'Else
            '    Me.txtNrOrdine.Text = DROrdine("t28_id")
            'End If

            'If DROrdine("t28_cod").GetType Is Type.GetType("System.DBNull") Then
            '    Me.txtNrOrdine.Text = ""
            'Else
            '    Me.txtNrOrdine.Text = DROrdine("t28_cod")
            'End If

            'If DROrdine("t28_descrizione").GetType Is Type.GetType("System.DBNull") Then
            '    Me.txtDescrOrdine.Text = ""
            'Else
            '    Me.txtDescrOrdine.Text = DROrdine("t28_descrizione")
            'End If

            'If DROrdine("t28_commessa_del").GetType Is Type.GetType("System.DBNull") Then
            '    Me.DateTimePickerOrdine.Value = Date.Today
            'Else
            '    Me.DateTimePickerOrdine.Value = DROrdine("t28_commessa_del")
            'End If

        End If

        'm_SQL = ""
        'm_SQL += "SELECT * FROM t28_testate_ordini_cli INNER JOIN t29_righe_ordine_cli "
        'm_SQL += "ON t28_id = t29_id_testata_t28 "
        'm_SQL += "INNER JOIN t20_articoli ON t29_id_articolo_t20 = t20_id_articolo "
        'm_SQL += "WHERE t28_dt_cancellazione IS NULL AND t29_dt_cancellazione IS NULL AND "
        'm_SQL += "t29_stato_riga_ordine = 'A' AND t28_id = " & m_IDOrdine.ToString & " "
        'm_SQL += "ORDER BY t28_id, t29_posizione"

        'objdsRigheOrdine = ExecuteDataset(conn.ConnectionString, CommandType.Text, m_SQL)
        'objdsRigheOrdine.Tables(0).TableName = "RigheOrdine"



        'DataGridRigheOrdine.DataSource = objdsRigheOrdine
        'DataGridRigheOrdine.DataMember = "RigheOrdine"
        'dgvRigheOrdine.DataSource = GestioneProduzione2009DataSet
        'dgvRigheOrdine.DataMember = GestioneProduzione2009DataSet.RigheOrdiniRicambi.TableName

        'default
        Cursor.Current = Cursors.Default

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="idRiga"></param>
    ''' <param name="qtDaEvadere">Passare -1 se su vuole evadere completamente la riga</param>
    ''' <remarks></remarks>
    Private Sub EvadiRiga(ByVal riga As GestioneProduzione2009DataSet.RigheOrdiniRicambiRow, ByVal idRiga As Integer, ByVal qtDaEvadere As Double, ByVal userConfirm As Boolean)
        'Dim iDRiga As Integer
        Dim idArticolo As Integer
        Dim blnAggiornaStato As Boolean = False

        'iDRiga = DataGridHelper.IDSelezionato(dgvRigheOrdine, 0) 'objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t13_id_riga_ordine_cli")

        Dim rigaDaEvadere As GestioneProduzione2014Data.GestioneProduzione2009DataSet.t29_righe_ordine_cliRow
        Dim articoloDaAggiornare As GestioneProduzione2014Data.GestioneProduzione2009DataSet.t20_articoliRow

        ' Carico i dati della riga
        T29_righe_ordine_cliTableAdapter.ClearBeforeFill = True
        T29_righe_ordine_cliTableAdapter.FillById(GestioneProduzione2009DataSet.t29_righe_ordine_cli, idRiga)
        If (GestioneProduzione2009DataSet.t29_righe_ordine_cli.Rows.Count > 0) Then
            rigaDaEvadere = GestioneProduzione2009DataSet.t29_righe_ordine_cli.Rows(0)
            idArticolo = rigaDaEvadere.t29_id_articolo_t20

            T20_articoliTableAdapter.ClearBeforeFill = True
            T20_articoliTableAdapter.FillById(GestioneProduzione2009DataSet.t20_articoli, idArticolo)
            If (GestioneProduzione2009DataSet.t20_articoli.Rows.Count > 0) Then
                articoloDaAggiornare = GestioneProduzione2009DataSet.t20_articoli.Rows(0)

                'memorizzo i valori precedenti per eventuali controlli
                Dim qtOrdinata As Decimal
                Dim qtEvasaPrecedente As Decimal

                Try
                    qtOrdinata = rigaDaEvadere.t29_qt_ordinata
                Catch ex As Exception
                    qtOrdinata = 0
                End Try

                Try
                    qtEvasaPrecedente = rigaDaEvadere.t29_qt_evasa
                Catch ex As Exception
                    qtEvasaPrecedente = 0
                End Try

                ' Gestione evasione COMPLETA con -1
                If qtDaEvadere = -1 Then
                    qtDaEvadere = qtOrdinata - qtEvasaPrecedente
                    ' Nel caso in cui evado era evasa una quantità maggiore non devo evadere più nulla
                    If qtDaEvadere < 0 Then
                        qtDaEvadere = 0
                    End If
                End If

                ''Richiesta quantità da evadere
                'Dim strQtDaEvadere As String
                'Dim sngQtDaEvadere As Single
                'strQtDaEvadere = InputBox("Inserire la quantità da evadere :", Me.Text, "0")
                'If strQtDaEvadere Is Nothing Then strQtDaEvadere = "0"
                'strQtDaEvadere = Replace(strQtDaEvadere, ",", ".")

                'If Not IsNumeric(strQtDaEvadere) Then
                '    MessageBox.Show("Non è stato inserito un valore numerico! Operazione annullata!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If

                'sngQtDaEvadere = CType(Replace(strQtDaEvadere, ".", ","), Single)

                'If sngQtDaEvadere = 0 Then Exit Sub

                If qtOrdinata < 0 Then

                    'la quantità evasa dopo questa evasione non deve essere inferiore alla quantità ordinata
                    If (qtDaEvadere + qtEvasaPrecedente) < qtOrdinata Then
                        MessageBox.Show("Impossibile evadere quantità negative inferiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    'la quantità evasa dopo questa evasione non deve essere maggiore di 0
                    If (qtDaEvadere + qtEvasaPrecedente) > 0 Then
                        MessageBox.Show("Impossibile evadere quantità negative inferiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                Else

                    ''la quantità evasa dopo questa evasione non deve essere maggiore alla quantità ordinata
                    'If (qtDaEvadere + qtEvasaPrecedente) > qtOrdinata Then
                    '    MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    '    Exit Sub
                    'End If

                    'la quantità evasa dopo questa evasione non deve essere inferiore a 0
                    If (qtDaEvadere + qtEvasaPrecedente) < 0 Then
                        MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                End If

                'se la quantità evasa dopo questa evasione è pari alla
                'quantità ordinata chiede conferma di evasione completa
                '(cambio stato riga)
                If qtDaEvadere + qtEvasaPrecedente = qtOrdinata Then
                    If userConfirm AndAlso MessageBox.Show("Dopo questa evasione la quantità evasa sarà pari quella ordinata. Evadere definitivamente la riga d'ordine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        blnAggiornaStato = True
                    End If
                End If

                Cursor.Current = Cursors.WaitCursor

                ''Vengono aggiornate le quantità evase del rigo
                ''ed aumentata la quantità disponibili a livello di
                ''magazzino (anagrafica articolo)
                'm_SQL = ""
                'm_SQL += "UPDATE t29_righe_ordine_cli SET "
                'm_SQL += "t13_qt_evasa = t13_qt_evasa + " & strQtDaEvadere & ", "
                'If blnAggiornaStato Then m_SQL += "t13_id_stato_riga_ordine_t10 = 'E', "
                'm_SQL += "t13_dt_modifica = GetDate() WHERE "
                'm_SQL += "t29_id_testata_t28 = " & _IDOrdine.ToString & " AND "
                'm_SQL += "t13_id_riga_ordine_cli = " & idRiga.ToString
                'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)
                rigaDaEvadere.t29_qt_evasa = qtEvasaPrecedente + qtDaEvadere
                rigaDaEvadere.t29_data_evasione = DateTime.Now()

                If (rigaDaEvadere.t29_qt_evasa >= rigaDaEvadere.t29_qt_ordinata) Then
                    rigaDaEvadere.t29_stato_riga_ordine = frmOrdiniRicambiNuovo.STATO_EVASO

                    If (rigaDaEvadere.t29_qt_evasa > rigaDaEvadere.t29_qt_ordinata) Then
                        ' Evasione qt. maggiore
                    End If
                End If

                T29_righe_ordine_cliTableAdapter.Update(rigaDaEvadere)

                'm_SQL = ""
                'm_SQL += "UPDATE t01_articoli SET "
                'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + " & strQtDaEvadere & ", "
                'm_SQL += "t01_dt_modifica = GetDate() WHERE "
                'm_SQL += "t01_id_articolo = " & intIDArticolo.ToString
                'm_SQL = ""
                'm_SQL += "UPDATE t20_articoli SET "
                'm_SQL += "t20_qt_disponibile = t20_qt_disponibile - " & strQtDaEvadere & ", "
                'm_SQL += "t20_dt_modifica = GetDate() WHERE "
                'm_SQL += "t20_id_articolo = " & idArticolo.ToString
                'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)

                ' PROCEDURA DI MAGGIO 2014
                ' nel caso dei gruppi, scarico gruppi finché ce ne sono, altrimenti scarico gli articoli che compongono i gruppi
                ' nel caso degli articoli invece non ho il problema perche' per questi posso andare in negativo, dice simone.
                ' non serve neppure gestire l'impegnato perche' di fatto sono "commesse veloci" dice simone, o ce ne sono o non ce ne sono
                If Not articoloDaAggiornare.t20_is_gruppo Then
                    ' e' un articolo
                    articoloDaAggiornare.t20_qt_disponibile = articoloDaAggiornare.t20_qt_disponibile - rigaDaEvadere.t29_qt_evasa
                    articoloDaAggiornare.t20_dt_modifica = DateTime.Now
                    aggiungiRigaMovimento(riga, rigaDaEvadere, articoloDaAggiornare, rigaDaEvadere.t29_qt_evasa)
                    T20_articoliTableAdapter.Update(articoloDaAggiornare)
                Else
                    ' e' un gruppo
                    If articoloDaAggiornare.t20_qt_disponibile >= rigaDaEvadere.t29_qt_evasa Then
                        ' scarico le quantita del gruppo
                        articoloDaAggiornare.t20_qt_disponibile = articoloDaAggiornare.t20_qt_disponibile - rigaDaEvadere.t29_qt_evasa
                        articoloDaAggiornare.t20_dt_modifica = DateTime.Now
                        aggiungiRigaMovimento(riga, rigaDaEvadere, articoloDaAggiornare, rigaDaEvadere.t29_qt_evasa)
                        T20_articoliTableAdapter.Update(articoloDaAggiornare)
                    Else
                        ' scarico tutto il gruppo ed per il rimanente scarico gli articoli 
                        Dim residua As Double = rigaDaEvadere.t29_qt_evasa - articoloDaAggiornare.t20_qt_disponibile
                        articoloDaAggiornare.t20_qt_disponibile = articoloDaAggiornare.t20_qt_disponibile - articoloDaAggiornare.t20_qt_disponibile
                        articoloDaAggiornare.t20_dt_modifica = DateTime.Now
                        aggiungiRigaMovimento(riga, rigaDaEvadere, articoloDaAggiornare, articoloDaAggiornare.t20_qt_disponibile)
                        T20_articoliTableAdapter.Update(articoloDaAggiornare)

                        ' carico gli articoli figli del gruppo
                        ' carico t22_articoli_articoli dato id padre che sarebbe questo gruppo
                        ' dopo di che carico t20_articoli con ogni id articolo
                        Dim idArticoloPadre = articoloDaAggiornare.t20_id_articolo
                        T22_articoli_articoliTableAdapter1.ClearBeforeFill = True
                        T22_articoli_articoliTableAdapter1.FillByIdPadre(Me.GestioneProduzione2009DataSet.t22_articoli_articoli, idArticoloPadre)
                        If (Me.GestioneProduzione2009DataSet.t22_articoli_articoli.Rows.Count > 0) Then
                            For Each rigaArticoloFiglioDaAggiornare As GestioneProduzione2009DataSet.t22_articoli_articoliRow In GestioneProduzione2009DataSet.t22_articoli_articoli.Rows
                                'Dim rigaArticoloFiglioDaAggiornare As GestioneProduzione2014Data.GestioneProduzione2009DataSet.t22_articoli_articoliRow
                                'rigaArticoloFiglioDaAggiornare = GestioneProduzione2009DataSet.t22_articoli_articoli.Rows(index)
                                Dim idArticoloFiglioDaAggiornare = rigaArticoloFiglioDaAggiornare.t22_id_articolo_t20

                                T20_articoliTableAdapter.ClearBeforeFill = True
                                T20_articoliTableAdapter.FillById(GestioneProduzione2009DataSet.t20_articoli, idArticoloFiglioDaAggiornare)
                                If (GestioneProduzione2009DataSet.t20_articoli.Rows.Count > 0) Then
                                    articoloDaAggiornare = GestioneProduzione2009DataSet.t20_articoli.Rows(0)
                                    articoloDaAggiornare.t20_qt_disponibile = articoloDaAggiornare.t20_qt_disponibile - (residua * rigaArticoloFiglioDaAggiornare.t22_consumo)
                                    articoloDaAggiornare.t20_dt_modifica = DateTime.Now
                                    aggiungiRigaMovimento(riga, rigaDaEvadere, articoloDaAggiornare, residua * rigaArticoloFiglioDaAggiornare.t22_consumo)
                                    T20_articoliTableAdapter.Update(articoloDaAggiornare)
                                End If

                            Next
                        End If


                    End If
                End If
                Cursor.Current = Cursors.Default

            Else
                ' Articolo specificato nella riga non e' stato trovato
                MessageBox.Show("Articolo specificato nella riga non e' stato trovato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub DataGridOrdiniArticolo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    'Private Sub mnuEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEvadiFull.Click

    '    If VerificaOrdineERighe() Then

    '        If MessageBox.Show("Confermi evasione definitiva riga ordine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

    '        Dim intIDRiga As Integer
    '        Dim intIDArticolo As Integer

    '        intIDRiga = objdsRigheOrdine.Tables("RigheOrdine").Rows(dgvRigheOrdine.CurrentRow.Index)("t13_id_riga_ordine_cli")
    '        intIDArticolo = objdsRigheOrdine.Tables("RigheOrdine").Rows(dgvRigheOrdine.CurrentRow.Index)("t29_id_articolo_t20")

    '        Cursor.Current = Cursors.WaitCursor

    '        m_SQL = ""
    '        m_SQL += "UPDATE t29_righe_ordine_cli SET "
    '        m_SQL += "t13_id_stato_riga_ordine_t10 = 'E', "
    '        m_SQL += "t13_dt_modifica = GetDate() WHERE "
    '        m_SQL += "t29_id_testata_t28 = " & _IDOrdine.ToString & " AND "
    '        m_SQL += "t13_id_riga_ordine_cli = " & intIDRiga.ToString
    '        ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)

    '        '----
    '        ' Aggiunto da Mirco per Aggiornare la t01_qt_disponibile quando viene evaso definitivamente un RIGO
    '        'm_SQL = ""
    '        'm_SQL += "UPDATE t01_articoli SET "
    '        'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + "
    '        'm_SQL += "      ( "
    '        'm_SQL += "      SELECT t13_qt_ordinata - t13_qt_evasa FROM t29_righe_ordine_cli WHERE "
    '        'm_SQL += "      t29_id_testata_t28 = " & m_IDOrdine.ToString & " AND "
    '        'm_SQL += "      t13_id_riga_ordine_cli = " & intIDRiga.ToString
    '        'm_SQL += "      ), "
    '        'm_SQL += "t01_dt_modifica = GetDate() WHERE "
    '        'm_SQL += "t01_id_articolo = "
    '        'm_SQL += "      ( "
    '        'm_SQL += "      SELECT t29_id_articolo_t20 FROM t29_righe_ordine_cli WHERE "
    '        'm_SQL += "      t29_id_testata_t28 = " & m_IDOrdine.ToString & " AND "
    '        'm_SQL += "      t13_id_riga_ordine_cli = " & intIDRiga.ToString
    '        'm_SQL += "      ) "
    '        m_SQL = ""
    '        m_SQL += "UPDATE t20_articoli SET "
    '        m_SQL += "t20_qt_disponibile = t20_qt_disponibile - "
    '        m_SQL += "      ( "
    '        m_SQL += "      SELECT t13_qt_ordinata - t13_qt_evasa FROM t29_righe_ordine_cli WHERE "
    '        m_SQL += "      t29_id_testata_t28 = " & _IDOrdine.ToString & " AND "
    '        m_SQL += "      t13_id_riga_ordine_cli = " & intIDRiga.ToString
    '        m_SQL += "      ), "
    '        m_SQL += "t20_dt_modifica = GetDate() WHERE "
    '        m_SQL += "t20_id_articolo = " & intIDArticolo.ToString
    '        'm_SQL += "      ( "
    '        'm_SQL += "      SELECT t29_id_articolo_t20 FROM t29_righe_ordine_cli WHERE "
    '        'm_SQL += "      t29_id_testata_t28 = " & m_IDOrdine.ToString & " AND "
    '        'm_SQL += "      t13_id_riga_ordine_cli = " & intIDRiga.ToString
    '        'm_SQL += "      ) "
    '        ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)
    '        '----

    '        Call CaricaDatiOrdine()

    '        Cursor.Current = Cursors.Default
    '    End If
    'End Sub

    'Private Sub DataGridOrdiniArticolo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    '    'Visualizza il menù di contesto solo nel RowHeader
    '    Dim pt As System.Drawing.Point = New Point(e.X, e.Y)
    '    Dim hti As DataGrid.HitTestInfo = DataGridRigheOrdine.HitTest(pt)

    '    If hti.Type = DataGrid.HitTestType.RowHeader Then
    '        If e.Button = MouseButtons.Right Then
    '            DataGridRigheOrdine.CurrentCell = New DataGridCell(hti.Row, hti.Column)
    '            ContextMenu1.Show(DataGridRigheOrdine, pt)
    '        End If
    '    End If

    'End Sub

    Private Sub dgvRigheOrdine_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRigheOrdine.DoubleClick

        ' ProceduraEvadiRiga()

    End Sub

    Private Function VerificaOrdineERighe() As Boolean
        Dim res As Boolean = True

        If _IDOrdine = 0 Then
            MessageBox.Show("Scegliere un ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            res = False
        End If

        'If GestioneProduzione2009DataSet.RigheOrdiniRicambi.Rows.Count <= 0 Then
        '    MessageBox.Show("Impossibile evadere la riga! L'ordine attualmente non ha righe aperte!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    res = False
        'End If

        If Not ADONetUtils.hasRows(GestioneProduzione2009DataSet.RigheOrdiniRicambi) Then
            MessageBox.Show("L'ordine attualmente non ha righe aperte!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        VerificaOrdineERighe = res
    End Function

    Private Sub EvadiRigaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvadiRigaToolStripMenuItem.Click
        ProceduraEvadiRiga()
    End Sub

    Private Sub EvadiRigaCompletaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvadiRigaCompletaToolStripMenuItem.Click
        ProceduraEvadiRigaCompleta()
    End Sub

    Private Sub ProceduraEvadiRiga()
        If VerificaOrdineERighe() Then
            Dim qtDaEvadere As Integer = FormsHelper.InputNumeric("Inserire la quantità da evadere :", Me.Text)
            If (qtDaEvadere > 0) Then
                EvadiRiga(Nothing, DataGridHelper.IDSelezionato(dgvRigheOrdine, 0), qtDaEvadere, True)
            End If

            Call CaricaDatiOrdine()

            ProceduraChiudiOrdine()
        End If
    End Sub

    Sub ProceduraEvadiRigaCompleta()
        If VerificaOrdineERighe() Then
            EvadiRiga(Nothing, DataGridHelper.IDSelezionato(dgvRigheOrdine, 0), -1, True)

            Call CaricaDatiOrdine()

            ProceduraChiudiOrdine()
        End If
    End Sub

    Sub ProceduraEvadiTutteRighe()
        If VerificaOrdineERighe() Then
            ' inizializzazione righe movimenti per file
            fileMovimenti = New StringBuilder()

            'Using ts As New TransactionScope()

            For Each riga As GestioneProduzione2009DataSet.RigheOrdiniRicambiRow In GestioneProduzione2009DataSet.RigheOrdiniRicambi.Rows
                EvadiRiga(riga, riga.t29_id, -1, False)
            Next

            Call CaricaDatiOrdine()

            ProceduraChiudiOrdine()

            '    ts.Complete()
            'End Using


            ' la procedua evadi riga prepara le righe da scrivere
            ProceduraGeneraFileMovimenti()
        End If
    End Sub

    Private Sub btnEvadiOrdine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvadiOrdine.Click
        ProceduraEvadiTutteRighe()
    End Sub

    Private Sub ProceduraChiudiOrdine()
        ' Verifica se ho evaso tutte le righe chiudo anche l'ordine
        If Not ADONetUtils.hasRows(GestioneProduzione2009DataSet.RigheOrdiniRicambi) Then

            Dim ordineCorrente As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow
            T28_testate_ordini_cliTableAdapter.FillById(GestioneProduzione2009DataSet.t28_testate_ordini_cli, IDOrdine)
            If (ADONetUtils.hasRows(GestioneProduzione2009DataSet.t28_testate_ordini_cli)) Then
                ordineCorrente = GestioneProduzione2009DataSet.t28_testate_ordini_cli.Rows(0)

                ordineCorrente.t28_stato_testata_ordine = frmOrdiniRicambiNuovo.STATO_EVASO
                ordineCorrente.t28_data_evasione = DateTime.Now
                ordineCorrente.t28_utente_evasione = frmMain.Profilo.nome

                T28_testate_ordini_cliTableAdapter.Update(ordineCorrente)
            End If
        End If
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub ProceduraGeneraFileMovimenti()

        'If fileMovimenti.Length > 0 AndAlso FormsHelper.Confirm("Generare il File di Movimenti per Ginux?", Me.Text) Then
        If fileMovimenti.Length > 0 Then
            Dim file As String
            file = Path.Combine(My.Settings.GinuxPath, "MOVIMENTI.txt")

            'For Each riga As GestioneProduzione2009DataSet.RigheOrdiniRicambiRow In GestioneProduzione2009DataSet.RigheOrdiniRicambi.Rows
            'Dim quantita As String = IIf(IsDBNull(riga.t29_qt_evasa), "0", riga.t29_qt_evasa)
            'Dim data As String = Date.Now.ToString("yyyy-MM-dd")
            'Dim descrizione As String = String.IsNullOrEmpty(riga.t28_rif_ordine)
            'Dim line As String = String.Format("{0};{1};{2};{3}", riga.t20_cod_articolo.PadRight(10), riga.t29_matricola.PadRight(10), quantita, data, descrizione)
            'fileMovimenti.AppendLine(line)
            'Next
            If (Directory.Exists(file)) Then
                FileUtils.ScriviFileDiTesto(file, fileMovimenti.ToString, True)
                'Process.Start(file)
            Else
                FormsHelper.Warn("Impossibile Crare il file di Movimenti in " & vbNewLine & file, Me.Text)
            End If
        End If

    End Sub

    Private Sub aggiungiRigaMovimento(ByVal riga As GestioneProduzione2009DataSet.RigheOrdiniRicambiRow, ByVal rigaDaEvadere As GestioneProduzione2014Data.GestioneProduzione2009DataSet.t29_righe_ordine_cliRow, ByVal articoloDaAggiornare As GestioneProduzione2014Data.GestioneProduzione2009DataSet.t20_articoliRow, ByVal quantitaEvasa As Double)
        ' nel caso di evasione completa viene passata la riga su cui viene fatto il ciclo, mentre su evasione parziale questa non viene passata
        If Not riga Is Nothing Then
            Dim quantita As String = IIf(IsDBNull(quantitaEvasa), "00000,00", quantitaEvasa.ToString("###.00##"))
            Dim data As String = Date.Now.ToString("yyyy-MM-dd")

            Dim rifOrd As String = ""
            If Not riga.Ist28_commessaNull() Then
                rifOrd = rifOrd + riga.t28_commessa
            End If
            If Not riga.Ist28_rif_redaNull() Then
                rifOrd = rifOrd + "," + riga.t28_rif_reda
            End If
            Dim line As String = String.Format("{0}{1}{2}{3}{4}", articoloDaAggiornare.t20_cod_articolo.PadRight(20).Substring(0, 20), rigaDaEvadere.t29_matricola.PadRight(10).Substring(0, 10), quantita.PadLeft(8, "0"), data.PadRight(10).Substring(0, 10), rifOrd.PadRight(50).Substring(0, 50))
            fileMovimenti.AppendLine(line)
        End If
    End Sub

End Class
