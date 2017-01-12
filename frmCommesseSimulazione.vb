Imports VS2005Commons
Imports GestioneProduzione2014Data

Public Class frmCommesseSimulazione
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblFiltri As System.Windows.Forms.Label
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents plBody As System.Windows.Forms.Panel
    Friend WithEvents pnlDetail As System.Windows.Forms.Panel
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents pnlTree As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txtQtDisponibile As System.Windows.Forms.TextBox
    Friend WithEvents txtQtOrdinata As System.Windows.Forms.TextBox
    Friend WithEvents txtSituazione As System.Windows.Forms.TextBox
    Friend WithEvents lblDisponibile As System.Windows.Forms.Label
    Friend WithEvents lblOrdinata As System.Windows.Forms.Label
    Friend WithEvents lblSituazione As System.Windows.Forms.Label
    Friend WithEvents pnlLeft As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblDescrizioneArticolo As System.Windows.Forms.Label
    Friend WithEvents lblCodiceArticolo As System.Windows.Forms.Label
    Friend WithEvents txtLotto As System.Windows.Forms.TextBox
    Friend WithEvents lblLotto As System.Windows.Forms.Label
    Friend WithEvents btnAggiorna As System.Windows.Forms.Button
    Friend WithEvents pnTreeLegend As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ChiudiCommessaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RiepilogoArticoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsSituazioneArticoli As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20qtdisponibileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtordinataarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumototaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20lottoriordinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MatricoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzocalcolatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrezzoforzatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20isgruppoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FornitoreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents imlTreeIcons16 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommesseSimulazione))
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.btnAggiorna = New System.Windows.Forms.Button
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.lblFiltri = New System.Windows.Forms.Label
        Me.plBody = New System.Windows.Forms.Panel
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20qtdisponibileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtordinataarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConsumototaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SituazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20lottoriordinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MatricoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrezzocalcolatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrezzoforzatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20isgruppoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.FornitoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RiepilogoArticoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSituazioneArticoli = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.pnlLeft = New System.Windows.Forms.Panel
        Me.pnlTree = New System.Windows.Forms.Panel
        Me.pnTreeLegend = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.imlTreeIcons16 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlDetail = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblDescrizioneArticolo = New System.Windows.Forms.Label
        Me.lblCodiceArticolo = New System.Windows.Forms.Label
        Me.txtLotto = New System.Windows.Forms.TextBox
        Me.lblLotto = New System.Windows.Forms.Label
        Me.txtSituazione = New System.Windows.Forms.TextBox
        Me.lblSituazione = New System.Windows.Forms.Label
        Me.txtQtOrdinata = New System.Windows.Forms.TextBox
        Me.lblOrdinata = New System.Windows.Forms.Label
        Me.txtQtDisponibile = New System.Windows.Forms.TextBox
        Me.lblDisponibile = New System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ChiudiCommessaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pnlHeader.SuspendLayout()
        Me.plBody.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiepilogoArticoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSituazioneArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeft.SuspendLayout()
        Me.pnlTree.SuspendLayout()
        Me.pnTreeLegend.SuspendLayout()
        Me.pnlDetail.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnAggiorna)
        Me.pnlHeader.Controls.Add(Me.txtRicercaDescrizione)
        Me.pnlHeader.Controls.Add(Me.txtRicercaCodice)
        Me.pnlHeader.Controls.Add(Me.lblFiltri)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(888, 40)
        Me.pnlHeader.TabIndex = 9
        '
        'btnAggiorna
        '
        Me.btnAggiorna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggiorna.Image = Global.GestioneProduzione.My.Resources.Resources.reload
        Me.btnAggiorna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAggiorna.Location = New System.Drawing.Point(768, 5)
        Me.btnAggiorna.Name = "btnAggiorna"
        Me.btnAggiorna.Size = New System.Drawing.Size(117, 29)
        Me.btnAggiorna.TabIndex = 10
        Me.btnAggiorna.Text = "Aggiorna"
        Me.btnAggiorna.UseVisualStyleBackColor = True
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(250, 7)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(400, 20)
        Me.txtRicercaDescrizione.TabIndex = 9
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(92, 7)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(152, 20)
        Me.txtRicercaCodice.TabIndex = 8
        '
        'lblFiltri
        '
        Me.lblFiltri.Location = New System.Drawing.Point(12, 10)
        Me.lblFiltri.Name = "lblFiltri"
        Me.lblFiltri.Size = New System.Drawing.Size(100, 16)
        Me.lblFiltri.TabIndex = 7
        Me.lblFiltri.Text = "Filtri di ricerca :"
        '
        'plBody
        '
        Me.plBody.Controls.Add(Me.pnlGrid)
        Me.plBody.Controls.Add(Me.Splitter2)
        Me.plBody.Controls.Add(Me.pnlLeft)
        Me.plBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.plBody.Location = New System.Drawing.Point(0, 40)
        Me.plBody.Name = "plBody"
        Me.plBody.Size = New System.Drawing.Size(888, 422)
        Me.plBody.TabIndex = 10
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.Label16)
        Me.pnlGrid.Controls.Add(Me.DataGridView1)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(275, 0)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(613, 422)
        Me.pnlGrid.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(74, 83)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "RiepilogoArticoli"
        Me.Label16.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T20idarticoloDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn, Me.T20qtdisponibileDataGridViewTextBoxColumn, Me.QtordinataarticoloDataGridViewTextBoxColumn, Me.ConsumototaleDataGridViewTextBoxColumn, Me.SituazioneDataGridViewTextBoxColumn, Me.T20lottoriordinoDataGridViewTextBoxColumn, Me.MatricoleDataGridViewTextBoxColumn, Me.CostoDataGridViewTextBoxColumn, Me.PrezzocalcolatoDataGridViewTextBoxColumn, Me.PrezzoforzatoDataGridViewTextBoxColumn, Me.T20isgruppoDataGridViewCheckBoxColumn, Me.FornitoreDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RiepilogoArticoliBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(613, 422)
        Me.DataGridView1.TabIndex = 0
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
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "Cod.Articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "Desc.Articolo"
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20descrizioneDataGridViewTextBoxColumn.Width = 150
        '
        'T20qtdisponibileDataGridViewTextBoxColumn
        '
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DataPropertyName = "t20_qt_disponibile"
        DataGridViewCellStyle2.Format = "N0"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.T20qtdisponibileDataGridViewTextBoxColumn.HeaderText = "Qt.Disp."
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Name = "T20qtdisponibileDataGridViewTextBoxColumn"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Width = 50
        '
        'QtordinataarticoloDataGridViewTextBoxColumn
        '
        Me.QtordinataarticoloDataGridViewTextBoxColumn.DataPropertyName = "qt_ordinata_articolo"
        DataGridViewCellStyle3.Format = "N0"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.QtordinataarticoloDataGridViewTextBoxColumn.HeaderText = "Qt.Ordinata"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.Name = "QtordinataarticoloDataGridViewTextBoxColumn"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.QtordinataarticoloDataGridViewTextBoxColumn.Width = 50
        '
        'ConsumototaleDataGridViewTextBoxColumn
        '
        Me.ConsumototaleDataGridViewTextBoxColumn.DataPropertyName = "consumo_totale"
        DataGridViewCellStyle4.Format = "N0"
        Me.ConsumototaleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.ConsumototaleDataGridViewTextBoxColumn.HeaderText = "Consumo"
        Me.ConsumototaleDataGridViewTextBoxColumn.Name = "ConsumototaleDataGridViewTextBoxColumn"
        Me.ConsumototaleDataGridViewTextBoxColumn.ReadOnly = True
        Me.ConsumototaleDataGridViewTextBoxColumn.Width = 50
        '
        'SituazioneDataGridViewTextBoxColumn
        '
        Me.SituazioneDataGridViewTextBoxColumn.DataPropertyName = "situazione"
        DataGridViewCellStyle5.Format = "N0"
        Me.SituazioneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.SituazioneDataGridViewTextBoxColumn.HeaderText = "Situazione"
        Me.SituazioneDataGridViewTextBoxColumn.Name = "SituazioneDataGridViewTextBoxColumn"
        Me.SituazioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20lottoriordinoDataGridViewTextBoxColumn
        '
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DataPropertyName = "t20_lotto_riordino"
        DataGridViewCellStyle6.Format = "N0"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.T20lottoriordinoDataGridViewTextBoxColumn.HeaderText = "Scorta minima"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.Name = "T20lottoriordinoDataGridViewTextBoxColumn"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MatricoleDataGridViewTextBoxColumn
        '
        Me.MatricoleDataGridViewTextBoxColumn.DataPropertyName = "matricole"
        Me.MatricoleDataGridViewTextBoxColumn.HeaderText = "Matricole"
        Me.MatricoleDataGridViewTextBoxColumn.Name = "MatricoleDataGridViewTextBoxColumn"
        Me.MatricoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        Me.CostoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzocalcolatoDataGridViewTextBoxColumn
        '
        Me.PrezzocalcolatoDataGridViewTextBoxColumn.DataPropertyName = "prezzo_calcolato"
        Me.PrezzocalcolatoDataGridViewTextBoxColumn.HeaderText = "Prezzo Calcolato"
        Me.PrezzocalcolatoDataGridViewTextBoxColumn.Name = "PrezzocalcolatoDataGridViewTextBoxColumn"
        Me.PrezzocalcolatoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzoforzatoDataGridViewTextBoxColumn
        '
        Me.PrezzoforzatoDataGridViewTextBoxColumn.DataPropertyName = "prezzo_forzato"
        Me.PrezzoforzatoDataGridViewTextBoxColumn.HeaderText = "Prezzo Forz."
        Me.PrezzoforzatoDataGridViewTextBoxColumn.Name = "PrezzoforzatoDataGridViewTextBoxColumn"
        Me.PrezzoforzatoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20isgruppoDataGridViewCheckBoxColumn
        '
        Me.T20isgruppoDataGridViewCheckBoxColumn.DataPropertyName = "t20_is_gruppo"
        Me.T20isgruppoDataGridViewCheckBoxColumn.HeaderText = "Gruppo Si/No"
        Me.T20isgruppoDataGridViewCheckBoxColumn.Name = "T20isgruppoDataGridViewCheckBoxColumn"
        Me.T20isgruppoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'FornitoreDataGridViewTextBoxColumn
        '
        Me.FornitoreDataGridViewTextBoxColumn.DataPropertyName = "fornitore"
        Me.FornitoreDataGridViewTextBoxColumn.HeaderText = "Fornitore"
        Me.FornitoreDataGridViewTextBoxColumn.Name = "FornitoreDataGridViewTextBoxColumn"
        Me.FornitoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RiepilogoArticoliBindingSource
        '
        Me.RiepilogoArticoliBindingSource.DataMember = "RiepilogoArticoli"
        Me.RiepilogoArticoliBindingSource.DataSource = Me.DsSituazioneArticoli
        '
        'DsSituazioneArticoli
        '
        Me.DsSituazioneArticoli.DataSetName = "dsSituazioneArticoli"
        Me.DsSituazioneArticoli.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DsSituazioneArticoli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(272, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 422)
        Me.Splitter2.TabIndex = 12
        Me.Splitter2.TabStop = False
        '
        'pnlLeft
        '
        Me.pnlLeft.Controls.Add(Me.pnlTree)
        Me.pnlLeft.Controls.Add(Me.Splitter1)
        Me.pnlLeft.Controls.Add(Me.pnlDetail)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(272, 422)
        Me.pnlLeft.TabIndex = 11
        '
        'pnlTree
        '
        Me.pnlTree.Controls.Add(Me.pnTreeLegend)
        Me.pnlTree.Controls.Add(Me.TreeView1)
        Me.pnlTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTree.Location = New System.Drawing.Point(0, 0)
        Me.pnlTree.Name = "pnlTree"
        Me.pnlTree.Size = New System.Drawing.Size(272, 259)
        Me.pnlTree.TabIndex = 14
        '
        'pnTreeLegend
        '
        Me.pnTreeLegend.Controls.Add(Me.Label3)
        Me.pnTreeLegend.Controls.Add(Me.Label2)
        Me.pnTreeLegend.Controls.Add(Me.Label1)
        Me.pnTreeLegend.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnTreeLegend.Location = New System.Drawing.Point(0, 229)
        Me.pnTreeLegend.Name = "pnTreeLegend"
        Me.pnTreeLegend.Size = New System.Drawing.Size(272, 30)
        Me.pnTreeLegend.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.ImageIndex = 2
        Me.Label3.ImageList = Me.imlTreeIcons16
        Me.Label3.Location = New System.Drawing.Point(149, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "      Articolo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imlTreeIcons16
        '
        Me.imlTreeIcons16.ImageStream = CType(resources.GetObject("imlTreeIcons16.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlTreeIcons16.TransparentColor = System.Drawing.Color.Transparent
        Me.imlTreeIcons16.Images.SetKeyName(0, "ledpurple.png")
        Me.imlTreeIcons16.Images.SetKeyName(1, "ledorange.png")
        Me.imlTreeIcons16.Images.SetKeyName(2, "ledyellow.png")
        '
        'Label2
        '
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.ImageIndex = 1
        Me.Label2.ImageList = Me.imlTreeIcons16
        Me.Label2.Location = New System.Drawing.Point(83, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "      Gruppo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImageIndex = 0
        Me.Label1.ImageList = Me.imlTreeIcons16
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "      Macchina"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.imlTreeIcons16
        Me.TreeView1.Indent = 27
        Me.TreeView1.ItemHeight = 16
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(272, 259)
        Me.TreeView1.TabIndex = 11
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 259)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(272, 3)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'pnlDetail
        '
        Me.pnlDetail.Controls.Add(Me.GroupBox1)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetail.Location = New System.Drawing.Point(0, 262)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(272, 160)
        Me.pnlDetail.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblDescrizioneArticolo)
        Me.GroupBox1.Controls.Add(Me.lblCodiceArticolo)
        Me.GroupBox1.Controls.Add(Me.txtLotto)
        Me.GroupBox1.Controls.Add(Me.lblLotto)
        Me.GroupBox1.Controls.Add(Me.txtSituazione)
        Me.GroupBox1.Controls.Add(Me.lblSituazione)
        Me.GroupBox1.Controls.Add(Me.txtQtOrdinata)
        Me.GroupBox1.Controls.Add(Me.lblOrdinata)
        Me.GroupBox1.Controls.Add(Me.txtQtDisponibile)
        Me.GroupBox1.Controls.Add(Me.lblDisponibile)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Situazione Articolo"
        '
        'lblDescrizioneArticolo
        '
        Me.lblDescrizioneArticolo.AutoSize = True
        Me.lblDescrizioneArticolo.Location = New System.Drawing.Point(13, 33)
        Me.lblDescrizioneArticolo.Name = "lblDescrizioneArticolo"
        Me.lblDescrizioneArticolo.Size = New System.Drawing.Size(57, 13)
        Me.lblDescrizioneArticolo.TabIndex = 9
        Me.lblDescrizioneArticolo.Text = "Decrizione"
        '
        'lblCodiceArticolo
        '
        Me.lblCodiceArticolo.AutoSize = True
        Me.lblCodiceArticolo.Location = New System.Drawing.Point(13, 16)
        Me.lblCodiceArticolo.Name = "lblCodiceArticolo"
        Me.lblCodiceArticolo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodiceArticolo.TabIndex = 8
        Me.lblCodiceArticolo.Text = "Codice"
        '
        'txtLotto
        '
        Me.txtLotto.Location = New System.Drawing.Point(136, 75)
        Me.txtLotto.Name = "txtLotto"
        Me.txtLotto.Size = New System.Drawing.Size(100, 20)
        Me.txtLotto.TabIndex = 6
        '
        'lblLotto
        '
        Me.lblLotto.Location = New System.Drawing.Point(136, 56)
        Me.lblLotto.Name = "lblLotto"
        Me.lblLotto.Size = New System.Drawing.Size(100, 24)
        Me.lblLotto.TabIndex = 7
        Me.lblLotto.Text = "Riordino"
        '
        'txtSituazione
        '
        Me.txtSituazione.Location = New System.Drawing.Point(136, 112)
        Me.txtSituazione.Name = "txtSituazione"
        Me.txtSituazione.Size = New System.Drawing.Size(100, 20)
        Me.txtSituazione.TabIndex = 2
        '
        'lblSituazione
        '
        Me.lblSituazione.Location = New System.Drawing.Point(136, 96)
        Me.lblSituazione.Name = "lblSituazione"
        Me.lblSituazione.Size = New System.Drawing.Size(100, 24)
        Me.lblSituazione.TabIndex = 5
        Me.lblSituazione.Text = "Situazione"
        '
        'txtQtOrdinata
        '
        Me.txtQtOrdinata.Location = New System.Drawing.Point(16, 112)
        Me.txtQtOrdinata.Name = "txtQtOrdinata"
        Me.txtQtOrdinata.Size = New System.Drawing.Size(100, 20)
        Me.txtQtOrdinata.TabIndex = 1
        '
        'lblOrdinata
        '
        Me.lblOrdinata.Location = New System.Drawing.Point(16, 96)
        Me.lblOrdinata.Name = "lblOrdinata"
        Me.lblOrdinata.Size = New System.Drawing.Size(100, 24)
        Me.lblOrdinata.TabIndex = 4
        Me.lblOrdinata.Text = "Qt. Ordinata"
        '
        'txtQtDisponibile
        '
        Me.txtQtDisponibile.Location = New System.Drawing.Point(16, 72)
        Me.txtQtDisponibile.Name = "txtQtDisponibile"
        Me.txtQtDisponibile.Size = New System.Drawing.Size(100, 20)
        Me.txtQtDisponibile.TabIndex = 0
        '
        'lblDisponibile
        '
        Me.lblDisponibile.Location = New System.Drawing.Point(16, 56)
        Me.lblDisponibile.Name = "lblDisponibile"
        Me.lblDisponibile.Size = New System.Drawing.Size(100, 23)
        Me.lblDisponibile.TabIndex = 3
        Me.lblDisponibile.Text = "Qt. Disponibile"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChiudiCommessaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(169, 26)
        '
        'ChiudiCommessaToolStripMenuItem
        '
        Me.ChiudiCommessaToolStripMenuItem.Name = "ChiudiCommessaToolStripMenuItem"
        Me.ChiudiCommessaToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChiudiCommessaToolStripMenuItem.Text = "Chiudi Commessa"
        '
        'frmCommesseSimulazione
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 462)
        Me.Controls.Add(Me.plBody)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommesseSimulazione"
        Me.Text = "Simulazione Commesse"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.plBody.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlGrid.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiepilogoArticoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSituazioneArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlTree.ResumeLayout(False)
        Me.pnTreeLegend.ResumeLayout(False)
        Me.pnlDetail.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dataModel As New DataModel()

    Private Sub frmElencoArticoli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AggiornaDati()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

        Dim data As Integer

        ' Se il tag è valorizzato allora è un articolo
        'If Not IsNothing(e.Node.Tag) Then
        ' Se ha padri allora è un gruppo o articolo
        If Not e.Node.Parent Is Nothing Then
            'E' un articolo o un gruppo
            data = CType(e.Node.Tag, Integer)

            dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.Sort = "t20_id_articolo"
            Dim riepilogo As GestioneProduzione2009DataSet.RiepilogoArticoliRow

            Dim filtroImpostato As String = dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.RowFilter
            Me.dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.RowFilter = ""

            ' Verifico se ci sono righe di riepilogo per questo articolo (ad esempio i gruppi non ci sono)
            If (Me.dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.FindRows(data).Length > 0) Then
                riepilogo = CType(dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.FindRows(data)(0).Row, GestioneProduzione2009DataSet.RiepilogoArticoliRow)

                'Visualizziamo un riepilogo dell'articolo
                lblCodiceArticolo.Text = riepilogo.t20_cod_articolo
                lblDescrizioneArticolo.Text = riepilogo.t20_descrizione
                txtQtDisponibile.Text = riepilogo.t20_qt_disponibile
                txtQtOrdinata.Text = riepilogo.qt_ordinata_articolo
                txtSituazione.Text = riepilogo.consumo_totale
                txtLotto.Text = riepilogo.t20_lotto_riordino
            End If

            'Me.dataModel.dsSituazioneArticoli.RiepilogoArticoli.DefaultView.RowFilter = "t20_id_articolo = " & data
            RiepilogoArticoliBindingSource.Filter = "t20_id_articolo = " & data
        Else
            'E' una macchina
            'Me.dataModel.dsSituazioneArticoli.RiepilogoArticoli.DefaultView.RowFilter = ""
            RiepilogoArticoliBindingSource.Filter = ""
        End If

        ''Controllo se ho selezionato un nodo macchina
        ''Se ho un nodo macchina cambio la sorgente dati della griglia
        'If e.Node.Parent Is Nothing Then
        '    Me.DataGridView1.DataSource = Me.dataModel.dsSituazioneArticoli.Impegnati
        'End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting

        Dim rowIndex As Integer = e.RowIndex
        Dim theRow As DataGridViewRow = DataGridView1.Rows(rowIndex)

        Dim qt_ordinata_articolo As Decimal = CType(theRow.Cells(QtordinataarticoloDataGridViewTextBoxColumn.Name).Value, Decimal)
        Dim consumo_totale As Decimal = CType(theRow.Cells(ConsumototaleDataGridViewTextBoxColumn.Name).Value, Decimal)
        Dim situazione As Decimal = CType(theRow.Cells(SituazioneDataGridViewTextBoxColumn.Name).Value, Decimal)
        Dim lotto_riordino As Decimal = CType(theRow.Cells(T20lottoriordinoDataGridViewTextBoxColumn.Name).Value, Decimal)

        If situazione > 0 And situazione < lotto_riordino Then
            theRow.DefaultCellStyle.BackColor = Color.Khaki
        ElseIf situazione < 0 Then
            theRow.DefaultCellStyle.BackColor = Color.LightSalmon
        End If

    End Sub

    Private Sub txtRicercaCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged
        Filtra()
    End Sub

    Private Sub txtRicercaDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaDescrizione.TextChanged
        Filtra()
    End Sub

    Private Sub Filtra()
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = QueryUtils.encodeString(Me.txtRicercaCodice.Text)
        strFiltroDescrizione = QueryUtils.encodeString(Me.txtRicercaDescrizione.Text)

        If strFiltroCodice.Trim <> "" Then
            strFiltro = "t20_cod_articolo LIKE '*" & strFiltroCodice & "*' "
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = strFiltro & "AND "
                strFiltro = strFiltro & "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        Else
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        End If

        'dataModel.dsSituazioneArticoli.RiepilogoArticoli.DefaultView.RowFilter = strFiltro
        RiepilogoArticoliBindingSource.Filter = strFiltro
    End Sub

    Private Sub btnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiorna.Click
        AggiornaDati()
    End Sub

    Private Sub AggiornaDati()
        TreeView1.SuspendLayout()
        TreeView1.Nodes.Clear()

        dataModel.Fill()
        dataModel.PreparaDati(TreeView1)

        'DataGridView1.DataSource = dataModel.dsSituazioneArticoli.RiepilogoArticoli
        Me.DsSituazioneArticoli = dataModel.GestioneProduzione2009DataSet1
        RiepilogoArticoliBindingSource.DataSource = dataModel.GestioneProduzione2009DataSet1
        RiepilogoArticoliBindingSource.DataMember = dataModel.GestioneProduzione2009DataSet1.RiepilogoArticoli.TableName

        RiepilogoArticoliBindingSource.Sort = "t20_cod_articolo"

        TreeView1.ResumeLayout()
    End Sub

    Private Sub ChiudiCommessaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiudiCommessaToolStripMenuItem.Click
        Dim idMacchina As Integer
        'Verifico che sia un nodo macchina
        If TreeView1.SelectedNode.Parent Is Nothing Then
            idMacchina = CType(TreeView1.SelectedNode.Tag, Integer)
            Me.dataModel.ChiudiMacchina(idMacchina)
        End If
    End Sub

    Private Sub frmIstanzeSimula_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.RiepilogoArticoliBindingSource.Sort = ""
    End Sub
End Class
