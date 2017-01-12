<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffertaNuova
    Inherits frmOffertaRicambiBase

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffertaNuova))
        Me.txtCommessaNum = New System.Windows.Forms.TextBox
        Me.T28_testate_ordini_cliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCommessaDel = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCommessaCliente1 = New System.Windows.Forms.TextBox
        Me.txtCodCliente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRifOrd = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.dgvRighe = New System.Windows.Forms.DataGridView
        Me.T29idDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t29_stato_riga_ordine = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29idtestatat28DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaMatricola = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29codDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaIdArticolo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaQuantita = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaPrezzoUni = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaPrezzoTot = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaPosizione = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaPrezzoOriginale = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T29_righe_ordine_cliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvRicambi = New System.Windows.Forms.DataGridView
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T25codmatricolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListinoRicambiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFiltroArticoli = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPartitaIva = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbLingua = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbCausale = New System.Windows.Forms.ComboBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTotale = New System.Windows.Forms.TextBox
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnSalva = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnEliminaOfferta = New System.Windows.Forms.ToolStripButton
        Me.btnDuplica = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btnExcel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnCommessa = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkListinoRivenditore = New System.Windows.Forms.CheckBox
        Me.chkListinoCliente = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSconto = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.T29_righe_ordine_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
        Me.T28_testate_ordini_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
        Me.ListinoRicambiTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.ListinoRicambiTableAdapter
        Me.T26_formule_prezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T26_formule_prezziTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
        Me.T31_configurazioneTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t31_configurazioneTableAdapter
        CType(Me.T28_testate_ordini_cliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRighe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T29_righe_ordine_cliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRicambi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListinoRicambiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCommessaNum
        '
        Me.txtCommessaNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_num", True))
        Me.txtCommessaNum.Location = New System.Drawing.Point(77, 19)
        Me.txtCommessaNum.Name = "txtCommessaNum"
        Me.txtCommessaNum.Size = New System.Drawing.Size(93, 20)
        Me.txtCommessaNum.TabIndex = 0
        '
        'T28_testate_ordini_cliBindingSource
        '
        Me.T28_testate_ordini_cliBindingSource.DataMember = "t28_testate_ordini_cli"
        Me.T28_testate_ordini_cliBindingSource.DataSource = Me.GestioneProduzione2009DataSet1
        '
        'GestioneProduzione2009DataSet1
        '
        Me.GestioneProduzione2009DataSet1.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Offerta n."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "del"
        '
        'txtCommessaDel
        '
        Me.txtCommessaDel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_del", True))
        Me.txtCommessaDel.Location = New System.Drawing.Point(210, 19)
        Me.txtCommessaDel.Mask = "99/99/9999"
        Me.txtCommessaDel.Name = "txtCommessaDel"
        Me.txtCommessaDel.Size = New System.Drawing.Size(100, 20)
        Me.txtCommessaDel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Cliente"
        '
        'txtCommessaCliente1
        '
        Me.txtCommessaCliente1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_cliente", True))
        Me.txtCommessaCliente1.Location = New System.Drawing.Point(77, 45)
        Me.txtCommessaCliente1.Multiline = True
        Me.txtCommessaCliente1.Name = "txtCommessaCliente1"
        Me.txtCommessaCliente1.Size = New System.Drawing.Size(233, 72)
        Me.txtCommessaCliente1.TabIndex = 7
        '
        'txtCodCliente
        '
        Me.txtCodCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_cliente_cod", True))
        Me.txtCodCliente.Location = New System.Drawing.Point(408, 48)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(195, 20)
        Me.txtCodCliente.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(327, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Tipo Offerta"
        '
        'txtRifOrd
        '
        Me.txtRifOrd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_tipo", True))
        Me.txtRifOrd.Location = New System.Drawing.Point(408, 97)
        Me.txtRifOrd.Name = "txtRifOrd"
        Me.txtRifOrd.Size = New System.Drawing.Size(195, 20)
        Me.txtRifOrd.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_vendita", True))
        Me.CheckBox1.Location = New System.Drawing.Point(718, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 12
        Me.CheckBox1.Text = "Vendita"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_riparazione", True))
        Me.CheckBox2.Location = New System.Drawing.Point(718, 45)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Garanzia"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_completamento_fornitura", True))
        Me.CheckBox3.Location = New System.Drawing.Point(718, 71)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Completamento Fornitura"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'dgvRighe
        '
        Me.dgvRighe.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRighe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRighe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRighe.AutoGenerateColumns = False
        Me.dgvRighe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRighe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRighe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T29idDataGridViewTextBoxColumn, Me.t29_stato_riga_ordine, Me.T29idtestatat28DataGridViewTextBoxColumn, Me.colonnaMatricola, Me.T29codDataGridViewTextBoxColumn, Me.colonnaDescrizione, Me.colonnaIdArticolo, Me.colonnaQuantita, Me.colonnaPrezzoUni, Me.colonnaPrezzoTot, Me.colonnaPosizione, Me.colonnaPrezzoOriginale})
        Me.dgvRighe.DataSource = Me.T29_righe_ordine_cliBindingSource
        Me.dgvRighe.Location = New System.Drawing.Point(3, 3)
        Me.dgvRighe.Name = "dgvRighe"
        Me.dgvRighe.Size = New System.Drawing.Size(693, 279)
        Me.dgvRighe.TabIndex = 21
        '
        'T29idDataGridViewTextBoxColumn
        '
        Me.T29idDataGridViewTextBoxColumn.DataPropertyName = "t29_id"
        Me.T29idDataGridViewTextBoxColumn.HeaderText = "t29_id"
        Me.T29idDataGridViewTextBoxColumn.Name = "T29idDataGridViewTextBoxColumn"
        Me.T29idDataGridViewTextBoxColumn.ReadOnly = True
        Me.T29idDataGridViewTextBoxColumn.Visible = False
        '
        't29_stato_riga_ordine
        '
        Me.t29_stato_riga_ordine.DataPropertyName = "t29_stato_riga_ordine"
        Me.t29_stato_riga_ordine.HeaderText = "t29_stato_riga_ordine"
        Me.t29_stato_riga_ordine.Name = "t29_stato_riga_ordine"
        Me.t29_stato_riga_ordine.Visible = False
        '
        'T29idtestatat28DataGridViewTextBoxColumn
        '
        Me.T29idtestatat28DataGridViewTextBoxColumn.DataPropertyName = "t29_id_testata_t28"
        Me.T29idtestatat28DataGridViewTextBoxColumn.HeaderText = "t29_id_testata_t28"
        Me.T29idtestatat28DataGridViewTextBoxColumn.Name = "T29idtestatat28DataGridViewTextBoxColumn"
        Me.T29idtestatat28DataGridViewTextBoxColumn.ReadOnly = True
        Me.T29idtestatat28DataGridViewTextBoxColumn.Visible = False
        '
        'colonnaMatricola
        '
        Me.colonnaMatricola.DataPropertyName = "t29_matricola"
        Me.colonnaMatricola.HeaderText = "Matricola"
        Me.colonnaMatricola.Name = "colonnaMatricola"
        '
        'T29codDataGridViewTextBoxColumn
        '
        Me.T29codDataGridViewTextBoxColumn.DataPropertyName = "t29_cod"
        Me.T29codDataGridViewTextBoxColumn.HeaderText = "t29_cod"
        Me.T29codDataGridViewTextBoxColumn.Name = "T29codDataGridViewTextBoxColumn"
        Me.T29codDataGridViewTextBoxColumn.Visible = False
        '
        'colonnaDescrizione
        '
        Me.colonnaDescrizione.DataPropertyName = "t29_descrizione"
        Me.colonnaDescrizione.HeaderText = "Descrizione"
        Me.colonnaDescrizione.Name = "colonnaDescrizione"
        '
        'colonnaIdArticolo
        '
        Me.colonnaIdArticolo.DataPropertyName = "t29_id_articolo_t20"
        Me.colonnaIdArticolo.HeaderText = "t29_id_articolo_t20"
        Me.colonnaIdArticolo.Name = "colonnaIdArticolo"
        Me.colonnaIdArticolo.Visible = False
        '
        'colonnaQuantita
        '
        Me.colonnaQuantita.DataPropertyName = "t29_qt_ordinata"
        Me.colonnaQuantita.HeaderText = "Q.ta'"
        Me.colonnaQuantita.Name = "colonnaQuantita"
        '
        'colonnaPrezzoUni
        '
        Me.colonnaPrezzoUni.DataPropertyName = "t29_prezzo_uni"
        Me.colonnaPrezzoUni.HeaderText = "Prezzo unitario"
        Me.colonnaPrezzoUni.Name = "colonnaPrezzoUni"
        Me.colonnaPrezzoUni.ReadOnly = True
        '
        'colonnaPrezzoTot
        '
        Me.colonnaPrezzoTot.DataPropertyName = "t29_prezzo_tota"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colonnaPrezzoTot.DefaultCellStyle = DataGridViewCellStyle2
        Me.colonnaPrezzoTot.HeaderText = "Prezzo totale"
        Me.colonnaPrezzoTot.Name = "colonnaPrezzoTot"
        Me.colonnaPrezzoTot.ReadOnly = True
        '
        'colonnaPosizione
        '
        Me.colonnaPosizione.DataPropertyName = "t29_posizione"
        Me.colonnaPosizione.HeaderText = "t29_posizione"
        Me.colonnaPosizione.Name = "colonnaPosizione"
        Me.colonnaPosizione.Visible = False
        '
        'colonnaPrezzoOriginale
        '
        Me.colonnaPrezzoOriginale.DataPropertyName = "t29_prezzo_originale"
        Me.colonnaPrezzoOriginale.HeaderText = "t29_prezzo_originale"
        Me.colonnaPrezzoOriginale.Name = "colonnaPrezzoOriginale"
        Me.colonnaPrezzoOriginale.Visible = False
        '
        'T29_righe_ordine_cliBindingSource
        '
        Me.T29_righe_ordine_cliBindingSource.DataMember = "t29_righe_ordine_cli"
        Me.T29_righe_ordine_cliBindingSource.DataSource = Me.GestioneProduzione2009DataSet1
        Me.T29_righe_ordine_cliBindingSource.Sort = ""
        '
        'dgvRicambi
        '
        Me.dgvRicambi.AllowUserToAddRows = False
        Me.dgvRicambi.AllowUserToDeleteRows = False
        Me.dgvRicambi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRicambi.AutoGenerateColumns = False
        Me.dgvRicambi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvRicambi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRicambi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T20idarticoloDataGridViewTextBoxColumn, Me.T25codmatricolaDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn})
        Me.dgvRicambi.DataSource = Me.ListinoRicambiBindingSource
        Me.dgvRicambi.Location = New System.Drawing.Point(3, 34)
        Me.dgvRicambi.MultiSelect = False
        Me.dgvRicambi.Name = "dgvRicambi"
        Me.dgvRicambi.ReadOnly = True
        Me.dgvRicambi.RowHeadersVisible = False
        Me.dgvRicambi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRicambi.Size = New System.Drawing.Size(206, 300)
        Me.dgvRicambi.TabIndex = 22
        '
        'T20idarticoloDataGridViewTextBoxColumn
        '
        Me.T20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.Name = "T20idarticoloDataGridViewTextBoxColumn"
        Me.T20idarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20idarticoloDataGridViewTextBoxColumn.Visible = False
        Me.T20idarticoloDataGridViewTextBoxColumn.Width = 82
        '
        'T25codmatricolaDataGridViewTextBoxColumn
        '
        Me.T25codmatricolaDataGridViewTextBoxColumn.DataPropertyName = "t25_cod_matricola"
        Me.T25codmatricolaDataGridViewTextBoxColumn.HeaderText = "Matricola"
        Me.T25codmatricolaDataGridViewTextBoxColumn.Name = "T25codmatricolaDataGridViewTextBoxColumn"
        Me.T25codmatricolaDataGridViewTextBoxColumn.ReadOnly = True
        Me.T25codmatricolaDataGridViewTextBoxColumn.Width = 75
        '
        'T20codarticoloDataGridViewTextBoxColumn
        '
        Me.T20codarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_cod_articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20codarticoloDataGridViewTextBoxColumn.Width = 65
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20descrizioneDataGridViewTextBoxColumn.Width = 87
        '
        'ListinoRicambiBindingSource
        '
        Me.ListinoRicambiBindingSource.DataMember = "ListinoRicambi"
        Me.ListinoRicambiBindingSource.DataSource = Me.GestioneProduzione2009DataSet1
        '
        'txtFiltroArticoli
        '
        Me.txtFiltroArticoli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltroArticoli.Location = New System.Drawing.Point(99, 8)
        Me.txtFiltroArticoli.Name = "txtFiltroArticoli"
        Me.txtFiltroArticoli.Size = New System.Drawing.Size(110, 20)
        Me.txtFiltroArticoli.TabIndex = 23
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_id", True))
        Me.txtID.Location = New System.Drawing.Point(529, 17)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(39, 20)
        Me.txtID.TabIndex = 26
        Me.txtID.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Ricerca ricambio"
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Image)
        Me.btnRemove.Location = New System.Drawing.Point(215, 157)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(32, 32)
        Me.btnRemove.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.btnRemove, "Rimuovi il ricambio selezionato oppure cancella la riga")
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(215, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Aggiungi il ricambio selezionato")
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_note", True))
        Me.TextBox6.Location = New System.Drawing.Point(46, 314)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(650, 20)
        Me.TextBox6.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "NOTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtPartitaIva)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbLingua)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cmbCausale)
        Me.GroupBox1.Controls.Add(Me.txtCommessaNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCommessaDel)
        Me.GroupBox1.Controls.Add(Me.txtCommessaCliente1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRifOrd)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 129)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intestazione"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(327, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Partita Iva"
        '
        'txtPartitaIva
        '
        Me.txtPartitaIva.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_cliente_pi", True))
        Me.txtPartitaIva.Location = New System.Drawing.Point(408, 71)
        Me.txtPartitaIva.Name = "txtPartitaIva"
        Me.txtPartitaIva.Size = New System.Drawing.Size(195, 20)
        Me.txtPartitaIva.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(327, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Codice Cliente"
        '
        'cmbLingua
        '
        Me.cmbLingua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_lingua", True))
        Me.cmbLingua.FormattingEnabled = True
        Me.cmbLingua.Items.AddRange(New Object() {"Italiano", "Inglese", "Spagnolo", "Francese"})
        Me.cmbLingua.Location = New System.Drawing.Point(357, 20)
        Me.cmbLingua.Name = "cmbLingua"
        Me.cmbLingua.Size = New System.Drawing.Size(77, 21)
        Me.cmbLingua.TabIndex = 30
        Me.cmbLingua.Text = "Italiano"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "lingua"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(667, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Causale"
        '
        'cmbCausale
        '
        Me.cmbCausale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCausale.FormattingEnabled = True
        Me.cmbCausale.Items.AddRange(New Object() {"", "Riparazione", "Ass. Tecnica"})
        Me.cmbCausale.Location = New System.Drawing.Point(718, 94)
        Me.cmbCausale.Name = "cmbCausale"
        Me.cmbCausale.Size = New System.Drawing.Size(143, 21)
        Me.cmbCausale.TabIndex = 27
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 163)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvRicambi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtFiltroArticoli)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRemove)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAdd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTotale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvRighe)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSpostaGiu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSpostaSu)
        Me.SplitContainer1.Size = New System.Drawing.Size(991, 342)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(553, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Tot: "
        '
        'txtTotale
        '
        Me.txtTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotale.Enabled = False
        Me.txtTotale.Location = New System.Drawing.Point(587, 288)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(109, 20)
        Me.txtTotale.TabIndex = 45
        '
        'btnSpostaGiu
        '
        Me.btnSpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaGiu.Image = CType(resources.GetObject("btnSpostaGiu.Image"), System.Drawing.Image)
        Me.btnSpostaGiu.Location = New System.Drawing.Point(702, 157)
        Me.btnSpostaGiu.Name = "btnSpostaGiu"
        Me.btnSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaGiu.TabIndex = 34
        '
        'btnSpostaSu
        '
        Me.btnSpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaSu.Image = CType(resources.GetObject("btnSpostaSu.Image"), System.Drawing.Image)
        Me.btnSpostaSu.Location = New System.Drawing.Point(702, 101)
        Me.btnSpostaSu.Name = "btnSpostaSu"
        Me.btnSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaSu.TabIndex = 33
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSalva, Me.ToolStripSeparator3, Me.btnEliminaOfferta, Me.btnDuplica, Me.ToolStripSeparator2, Me.btnExcel, Me.ToolStripSeparator1, Me.btnCommessa})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1015, 25)
        Me.ToolStrip1.TabIndex = 46
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSalva
        '
        Me.btnSalva.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(92, 22)
        Me.btnSalva.Text = "Salva Offerta"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btnEliminaOfferta
        '
        Me.btnEliminaOfferta.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnEliminaOfferta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminaOfferta.Name = "btnEliminaOfferta"
        Me.btnEliminaOfferta.Size = New System.Drawing.Size(98, 22)
        Me.btnEliminaOfferta.Text = "Elimina Offerta"
        '
        'btnDuplica
        '
        Me.btnDuplica.Image = Global.GestioneProduzione.My.Resources.Resources.editcopy_22
        Me.btnDuplica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDuplica.Name = "btnDuplica"
        Me.btnDuplica.Size = New System.Drawing.Size(93, 22)
        Me.btnDuplica.Text = "Copia Offerta"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.GestioneProduzione.My.Resources.Resources.export_excel
        Me.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(142, 22)
        Me.btnExcel.Text = "Compila Offerta in Excel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnCommessa
        '
        Me.btnCommessa.Image = Global.GestioneProduzione.My.Resources.Resources.apply
        Me.btnCommessa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCommessa.Name = "btnCommessa"
        Me.btnCommessa.Size = New System.Drawing.Size(143, 22)
        Me.btnCommessa.Text = "Crea Commessa Ricambi"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.chkListinoRivenditore)
        Me.GroupBox2.Controls.Add(Me.chkListinoCliente)
        Me.GroupBox2.Location = New System.Drawing.Point(885, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 66)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listino"
        '
        'chkListinoRivenditore
        '
        Me.chkListinoRivenditore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkListinoRivenditore.AutoSize = True
        Me.chkListinoRivenditore.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_sconto_riventorore", True))
        Me.chkListinoRivenditore.Location = New System.Drawing.Point(26, 23)
        Me.chkListinoRivenditore.Name = "chkListinoRivenditore"
        Me.chkListinoRivenditore.Size = New System.Drawing.Size(77, 17)
        Me.chkListinoRivenditore.TabIndex = 15
        Me.chkListinoRivenditore.Text = "Riventitore"
        Me.chkListinoRivenditore.UseVisualStyleBackColor = True
        '
        'chkListinoCliente
        '
        Me.chkListinoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkListinoCliente.AutoSize = True
        Me.chkListinoCliente.Checked = True
        Me.chkListinoCliente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkListinoCliente.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_sconto_cliente", True))
        Me.chkListinoCliente.Location = New System.Drawing.Point(26, 45)
        Me.chkListinoCliente.Name = "chkListinoCliente"
        Me.chkListinoCliente.Size = New System.Drawing.Size(58, 17)
        Me.chkListinoCliente.TabIndex = 16
        Me.chkListinoCliente.Text = "Cliente"
        Me.chkListinoCliente.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "%"
        '
        'txtSconto
        '
        Me.txtSconto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSconto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_sconto", True))
        Me.txtSconto.Location = New System.Drawing.Point(21, 26)
        Me.txtSconto.Name = "txtSconto"
        Me.txtSconto.Size = New System.Drawing.Size(56, 20)
        Me.txtSconto.TabIndex = 54
        Me.txtSconto.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtSconto)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(885, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(118, 58)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sconto"
        '
        'T29_righe_ordine_cliTableAdapter
        '
        Me.T29_righe_ordine_cliTableAdapter.ClearBeforeFill = True
        '
        'T28_testate_ordini_cliTableAdapter
        '
        Me.T28_testate_ordini_cliTableAdapter.ClearBeforeFill = True
        '
        'ListinoRicambiTableAdapter
        '
        Me.ListinoRicambiTableAdapter.ClearBeforeFill = True
        '
        'T26_formule_prezziBindingSource
        '
        Me.T26_formule_prezziBindingSource.DataMember = "t26_formule_prezzi"
        Me.T26_formule_prezziBindingSource.DataSource = Me.GestioneProduzione2009DataSet1
        '
        'T26_formule_prezziTableAdapter
        '
        Me.T26_formule_prezziTableAdapter.ClearBeforeFill = True
        '
        'T31_configurazioneTableAdapter1
        '
        Me.T31_configurazioneTableAdapter1.ClearBeforeFill = True
        '
        'frmOffertaNuova
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 517)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOffertaNuova"
        Me.Text = "Offerta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.T28_testate_ordini_cliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRighe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T29_righe_ordine_cliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRicambi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListinoRicambiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCommessaNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCommessaDel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCommessaCliente1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRifOrd As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents dgvRighe As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet1 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T29_righe_ordine_cliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T29_righe_ordine_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
    Friend WithEvents T28_testate_ordini_cliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T28_testate_ordini_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
    Friend WithEvents dgvRicambi As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltroArticoli As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents T29posizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29qtevasaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29dataconsegnaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29statoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29datacreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29datamodificaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29datacancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListinoRicambiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListinoRicambiTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.ListinoRicambiTableAdapter
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25codmatricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSpostaGiu As System.Windows.Forms.Button
    Friend WithEvents btnSpostaSu As System.Windows.Forms.Button
    Friend WithEvents T26_formule_prezziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T26_formule_prezziTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtTotale As System.Windows.Forms.TextBox
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSalva As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCommessa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSconto As System.Windows.Forms.TextBox
    Friend WithEvents chkListinoRivenditore As System.Windows.Forms.CheckBox
    Friend WithEvents chkListinoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T29idDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t29_stato_riga_ordine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29idtestatat28DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaMatricola As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T29codDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaDescrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaIdArticolo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaQuantita As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaPrezzoUni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaPrezzoTot As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaPosizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaPrezzoOriginale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbLingua As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPartitaIva As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnEliminaOfferta As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDuplica As System.Windows.Forms.ToolStripButton
    Friend WithEvents T31_configurazioneTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t31_configurazioneTableAdapter

End Class
