<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdiniRicambiNuovo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdiniRicambiNuovo))
        Me.txtCommessaNum = New System.Windows.Forms.TextBox
        Me.T28_testate_ordini_cliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCommessaDel = New System.Windows.Forms.MaskedTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCommessaCliente1 = New System.Windows.Forms.TextBox
        Me.txtCommessaCliente2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRifOrd = New System.Windows.Forms.TextBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.txtAspetto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMisure = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPeso = New System.Windows.Forms.TextBox
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
        Me.txtConsegna = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnExcel = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnCancella = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbCausale = New System.Windows.Forms.ComboBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbLingua = New System.Windows.Forms.ComboBox
        Me.txtTotale = New System.Windows.Forms.TextBox
        Me.btnStampeEtichette = New System.Windows.Forms.Button
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.btnStampaComVend = New System.Windows.Forms.Button
        Me.btnStampaComMag = New System.Windows.Forms.Button
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.btnSalva = New System.Windows.Forms.Button
        Me.btnEvadi = New System.Windows.Forms.Button
        Me.T29_righe_ordine_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
        Me.T28_testate_ordini_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
        Me.ListinoRicambiTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.ListinoRicambiTableAdapter
        Me.T26_formule_prezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T26_formule_prezziTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
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
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCommessaNum
        '
        Me.txtCommessaNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_commessa", True))
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
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COMM."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DEL"
        '
        'txtCommessaDel
        '
        Me.txtCommessaDel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_commessa_del", True))
        Me.txtCommessaDel.Location = New System.Drawing.Point(210, 19)
        Me.txtCommessaDel.Mask = "99/99/9999"
        Me.txtCommessaDel.Name = "txtCommessaDel"
        Me.txtCommessaDel.Size = New System.Drawing.Size(100, 20)
        Me.txtCommessaDel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(313, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CONSEGNA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLIENTE"
        '
        'txtCommessaCliente1
        '
        Me.txtCommessaCliente1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommessaCliente1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_cliente", True))
        Me.txtCommessaCliente1.Location = New System.Drawing.Point(77, 45)
        Me.txtCommessaCliente1.Name = "txtCommessaCliente1"
        Me.txtCommessaCliente1.Size = New System.Drawing.Size(503, 20)
        Me.txtCommessaCliente1.TabIndex = 7
        '
        'txtCommessaCliente2
        '
        Me.txtCommessaCliente2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCommessaCliente2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_cliente2", True))
        Me.txtCommessaCliente2.Location = New System.Drawing.Point(77, 70)
        Me.txtCommessaCliente2.Name = "txtCommessaCliente2"
        Me.txtCommessaCliente2.Size = New System.Drawing.Size(503, 20)
        Me.txtCommessaCliente2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "RIF. ORDINE"
        '
        'txtRifOrd
        '
        Me.txtRifOrd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_rif_reda", True))
        Me.txtRifOrd.Location = New System.Drawing.Point(77, 97)
        Me.txtRifOrd.Name = "txtRifOrd"
        Me.txtRifOrd.Size = New System.Drawing.Size(195, 20)
        Me.txtRifOrd.TabIndex = 11
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.T28_testate_ordini_cliBindingSource, "t28_vendita", True))
        Me.CheckBox1.Location = New System.Drawing.Point(586, 47)
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
        Me.CheckBox2.Location = New System.Drawing.Point(586, 73)
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
        Me.CheckBox3.Location = New System.Drawing.Point(586, 99)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox3.TabIndex = 14
        Me.CheckBox3.Text = "Completamento Fornitura"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'txtAspetto
        '
        Me.txtAspetto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAspetto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_aspetto_esteriore", True))
        Me.txtAspetto.Location = New System.Drawing.Point(736, 41)
        Me.txtAspetto.Name = "txtAspetto"
        Me.txtAspetto.Size = New System.Drawing.Size(141, 20)
        Me.txtAspetto.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(733, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Aspetto Esteriore"
        '
        'txtMisure
        '
        Me.txtMisure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMisure.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_misure", True))
        Me.txtMisure.Location = New System.Drawing.Point(800, 70)
        Me.txtMisure.Name = "txtMisure"
        Me.txtMisure.Size = New System.Drawing.Size(77, 20)
        Me.txtMisure.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(733, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Misure: cm."
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(742, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Peso: kg."
        '
        'txtPeso
        '
        Me.txtPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPeso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_peso", True))
        Me.txtPeso.Location = New System.Drawing.Point(800, 96)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(77, 20)
        Me.txtPeso.TabIndex = 19
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
        Me.dgvRighe.Location = New System.Drawing.Point(3, 38)
        Me.dgvRighe.Name = "dgvRighe"
        Me.dgvRighe.Size = New System.Drawing.Size(679, 225)
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
        Me.dgvRicambi.Size = New System.Drawing.Size(220, 281)
        Me.dgvRicambi.TabIndex = 22
        '
        'T20idarticoloDataGridViewTextBoxColumn
        '
        Me.T20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.Name = "T20idarticoloDataGridViewTextBoxColumn"
        Me.T20idarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20idarticoloDataGridViewTextBoxColumn.Visible = False
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
        Me.txtFiltroArticoli.Size = New System.Drawing.Size(124, 20)
        Me.txtFiltroArticoli.TabIndex = 23
        '
        'txtConsegna
        '
        Me.txtConsegna.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_consegna", True))
        Me.txtConsegna.Location = New System.Drawing.Point(386, 18)
        Me.txtConsegna.Name = "txtConsegna"
        Me.txtConsegna.Size = New System.Drawing.Size(96, 20)
        Me.txtConsegna.TabIndex = 25
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
        Me.btnRemove.Location = New System.Drawing.Point(229, 157)
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
        Me.btnAdd.Location = New System.Drawing.Point(229, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.btnAdd, "Aggiungi il ricambio selezionato")
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.GestioneProduzione.My.Resources.Resources.export_excel
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(688, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 23)
        Me.Button1.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.Button1, "Esporta in Excel")
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.GestioneProduzione.My.Resources.Resources.export_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(455, 34)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(30, 23)
        Me.btnExcel.TabIndex = 42
        Me.ToolTip1.SetToolTip(Me.btnExcel, "Esporta in Excel")
        Me.btnExcel.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_note", True))
        Me.TextBox6.Location = New System.Drawing.Point(46, 295)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(636, 20)
        Me.TextBox6.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "NOTE"
        '
        'btnCancella
        '
        Me.btnCancella.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancella.Location = New System.Drawing.Point(907, 93)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(96, 23)
        Me.btnCancella.TabIndex = 28
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmbCausale)
        Me.GroupBox1.Controls.Add(Me.txtCommessaNum)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCommessaDel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCommessaCliente1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCommessaCliente2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRifOrd)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.txtAspetto)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtConsegna)
        Me.GroupBox1.Controls.Add(Me.txtMisure)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 157)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Intestazione"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(535, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Causale"
        '
        'cmbCausale
        '
        Me.cmbCausale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCausale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_causale", True))
        Me.cmbCausale.FormattingEnabled = True
        Me.cmbCausale.Items.AddRange(New Object() {"", "Riparazione", "Ass. Tecnica"})
        Me.cmbCausale.Location = New System.Drawing.Point(586, 122)
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
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 182)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbLingua)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtTotale)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStampeEtichette)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvRighe)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExcel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSpostaGiu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSpostaSu)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStampaComVend)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnStampaComMag)
        Me.SplitContainer1.Size = New System.Drawing.Size(991, 323)
        Me.SplitContainer1.SplitterDistance = 264
        Me.SplitContainer1.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(538, 272)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Tot: "
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(262, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "stampa descrizioni in"
        '
        'cmbLingua
        '
        Me.cmbLingua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLingua.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T28_testate_ordini_cliBindingSource, "t28_offerta_lingua", True))
        Me.cmbLingua.FormattingEnabled = True
        Me.cmbLingua.Items.AddRange(New Object() {"Italiano", "Inglese", "Spagnolo", "Francese"})
        Me.cmbLingua.Location = New System.Drawing.Point(372, 11)
        Me.cmbLingua.Name = "cmbLingua"
        Me.cmbLingua.Size = New System.Drawing.Size(77, 21)
        Me.cmbLingua.TabIndex = 27
        Me.cmbLingua.Text = "Italiano"
        '
        'txtTotale
        '
        Me.txtTotale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotale.Enabled = False
        Me.txtTotale.Location = New System.Drawing.Point(573, 269)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(109, 20)
        Me.txtTotale.TabIndex = 45
        '
        'btnStampeEtichette
        '
        Me.btnStampeEtichette.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampeEtichette.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.btnStampeEtichette.Location = New System.Drawing.Point(92, 8)
        Me.btnStampeEtichette.Name = "btnStampeEtichette"
        Me.btnStampeEtichette.Size = New System.Drawing.Size(160, 23)
        Me.btnStampeEtichette.TabIndex = 44
        Me.btnStampeEtichette.Text = "Stampa Etichette"
        Me.btnStampeEtichette.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStampeEtichette.UseVisualStyleBackColor = True
        '
        'btnSpostaGiu
        '
        Me.btnSpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaGiu.Image = CType(resources.GetObject("btnSpostaGiu.Image"), System.Drawing.Image)
        Me.btnSpostaGiu.Location = New System.Drawing.Point(688, 157)
        Me.btnSpostaGiu.Name = "btnSpostaGiu"
        Me.btnSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaGiu.TabIndex = 34
        '
        'btnSpostaSu
        '
        Me.btnSpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaSu.Image = CType(resources.GetObject("btnSpostaSu.Image"), System.Drawing.Image)
        Me.btnSpostaSu.Location = New System.Drawing.Point(688, 101)
        Me.btnSpostaSu.Name = "btnSpostaSu"
        Me.btnSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaSu.TabIndex = 33
        '
        'btnStampaComVend
        '
        Me.btnStampaComVend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampaComVend.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.btnStampaComVend.Location = New System.Drawing.Point(491, 35)
        Me.btnStampaComVend.Name = "btnStampaComVend"
        Me.btnStampaComVend.Size = New System.Drawing.Size(191, 23)
        Me.btnStampaComVend.TabIndex = 36
        Me.btnStampaComVend.Text = "Stampa Commessa Vendita"
        Me.btnStampaComVend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStampaComVend.UseVisualStyleBackColor = True
        Me.btnStampaComVend.Visible = False
        '
        'btnStampaComMag
        '
        Me.btnStampaComMag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampaComMag.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.btnStampaComMag.Location = New System.Drawing.Point(491, 8)
        Me.btnStampaComMag.Name = "btnStampaComMag"
        Me.btnStampaComMag.Size = New System.Drawing.Size(191, 23)
        Me.btnStampaComMag.TabIndex = 37
        Me.btnStampaComMag.Text = "Stampa Commessa Magazzino"
        Me.btnStampaComMag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStampaComMag.UseVisualStyleBackColor = True
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(907, 55)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 44
        Me.btnChiudi.Text = "&Chiudi"
        '
        'btnSalva
        '
        Me.btnSalva.AllowDrop = True
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalva.Location = New System.Drawing.Point(907, 20)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(96, 32)
        Me.btnSalva.TabIndex = 40
        Me.btnSalva.Text = "&Salva"
        '
        'btnEvadi
        '
        Me.btnEvadi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvadi.Image = Global.GestioneProduzione.My.Resources.Resources.apply
        Me.btnEvadi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEvadi.Location = New System.Drawing.Point(907, 122)
        Me.btnEvadi.Name = "btnEvadi"
        Me.btnEvadi.Size = New System.Drawing.Size(96, 31)
        Me.btnEvadi.TabIndex = 35
        Me.btnEvadi.Text = "Evadi"
        Me.btnEvadi.UseVisualStyleBackColor = True
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
        'frmOrdiniRicambiNuovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(1015, 517)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnEvadi)
        Me.Controls.Add(Me.btnCancella)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdiniRicambiNuovo"
        Me.Text = "Nuova Commessa Ricambi"
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
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCommessaNum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCommessaDel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCommessaCliente1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCommessaCliente2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRifOrd As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtAspetto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMisure As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents dgvRighe As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet1 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T29_righe_ordine_cliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T29_righe_ordine_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter
    Friend WithEvents T28_testate_ordini_cliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T28_testate_ordini_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
    Friend WithEvents dgvRicambi As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltroArticoli As System.Windows.Forms.TextBox
    Friend WithEvents txtConsegna As System.Windows.Forms.TextBox
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
    Friend WithEvents btnEvadi As System.Windows.Forms.Button
    Friend WithEvents btnStampaComVend As System.Windows.Forms.Button
    Friend WithEvents btnStampaComMag As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnCancella As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnStampeEtichette As System.Windows.Forms.Button
    Friend WithEvents txtTotale As System.Windows.Forms.TextBox
    Friend WithEvents cmbLingua As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label15 As System.Windows.Forms.Label
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

End Class
