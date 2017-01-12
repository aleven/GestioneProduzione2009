<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticoliSituazione
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticoliSituazione))
        Me.pnlHeader = New System.Windows.Forms.Panel
        Me.btnExcel = New System.Windows.Forms.Button
        Me.chbRicambi = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbFornitore = New System.Windows.Forms.ComboBox
        Me.T11fornitoriBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdbVisualizzaGruppi = New System.Windows.Forms.RadioButton
        Me.rdbVisualizzaArticoli = New System.Windows.Forms.RadioButton
        Me.btnAggiorna = New System.Windows.Forms.Button
        Me.chbRicercaDaOrdinare = New System.Windows.Forms.CheckBox
        Me.txtRicercaMatricola = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.T11fornitoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlDetail = New System.Windows.Forms.Panel
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.pnlStatoArticolo = New System.Windows.Forms.Panel
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnAnnullaArticolo = New System.Windows.Forms.Button
        Me.btnSalvaArticolo = New System.Windows.Forms.Button
        Me.btnModificaArticolo = New System.Windows.Forms.Button
        Me.txtPrezzoForzatoArticolo = New System.Windows.Forms.TextBox
        Me.t20_articoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsSituazioneArticoli = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.txtPrezzoCalcolatoArticolo = New System.Windows.Forms.TextBox
        Me.riepilogoArticoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCostoArticolo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSituazioneArticolo = New System.Windows.Forms.TextBox
        Me.txtQtOrdinataArticolo = New System.Windows.Forms.TextBox
        Me.txtLottoRiordinoArticolo = New System.Windows.Forms.TextBox
        Me.txtQtDisponibileArticolo = New System.Windows.Forms.TextBox
        Me.chbRicambioArticolo = New System.Windows.Forms.CheckBox
        Me.cmbFornitoreArticolo = New System.Windows.Forms.ComboBox
        Me.txtDescrizioneArticolo = New System.Windows.Forms.TextBox
        Me.txtCodiceArticolo = New System.Windows.Forms.TextBox
        Me.dgMatricoleArticolo = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FKt25matricolet20articoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T20articolit25matricoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.t25matricoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlBody = New System.Windows.Forms.Panel
        Me.lblLoading = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.dgArticoliRiepilogo = New System.Windows.Forms.DataGridView
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20qtdisponibileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.qt_disponibile_in_gruppi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20lottoriordinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QtordinataarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ConsumototaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SituazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prezzo_calcolato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prezzo_forzato = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.matricole = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fornitore = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t20_is_ricambio = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T11_fornitoriTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t11_fornitoriTableAdapter
        Me.cmnuGruppi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ScomponiGruppoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.T25_matricoleTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
        Me.pnlHeader.SuspendLayout()
        CType(Me.T11fornitoriBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.T11fornitoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetail.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.t20_articoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsSituazioneArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riepilogoArticoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMatricoleArticolo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKt25matricolet20articoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T20articolit25matricoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t25matricoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody.SuspendLayout()
        CType(Me.dgArticoliRiepilogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuGruppi.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnExcel)
        Me.pnlHeader.Controls.Add(Me.chbRicambi)
        Me.pnlHeader.Controls.Add(Me.Label15)
        Me.pnlHeader.Controls.Add(Me.cmbFornitore)
        Me.pnlHeader.Controls.Add(Me.GroupBox2)
        Me.pnlHeader.Controls.Add(Me.btnAggiorna)
        Me.pnlHeader.Controls.Add(Me.chbRicercaDaOrdinare)
        Me.pnlHeader.Controls.Add(Me.txtRicercaMatricola)
        Me.pnlHeader.Controls.Add(Me.txtRicercaDescrizione)
        Me.pnlHeader.Controls.Add(Me.txtRicercaCodice)
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1159, 53)
        Me.pnlHeader.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.GestioneProduzione.My.Resources.Resources.export_excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(1000, 7)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(44, 40)
        Me.btnExcel.TabIndex = 27
        Me.btnExcel.Visible = False
        '
        'chbRicambi
        '
        Me.chbRicambi.AutoSize = True
        Me.chbRicambi.Location = New System.Drawing.Point(900, 27)
        Me.chbRicambi.Name = "chbRicambi"
        Me.chbRicambi.Size = New System.Drawing.Size(64, 17)
        Me.chbRicambi.TabIndex = 7
        Me.chbRicambi.Text = "Ricambi"
        Me.chbRicambi.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(674, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Cerca per Fornitore:"
        '
        'cmbFornitore
        '
        Me.cmbFornitore.DataSource = Me.T11fornitoriBindingSource2
        Me.cmbFornitore.DisplayMember = "t11_descrizione"
        Me.cmbFornitore.FormattingEnabled = True
        Me.cmbFornitore.Location = New System.Drawing.Point(674, 25)
        Me.cmbFornitore.Name = "cmbFornitore"
        Me.cmbFornitore.Size = New System.Drawing.Size(220, 21)
        Me.cmbFornitore.TabIndex = 25
        Me.cmbFornitore.ValueMember = "t11_descrizione"
        '
        'T11fornitoriBindingSource2
        '
        Me.T11fornitoriBindingSource2.DataMember = "t11_fornitori"
        Me.T11fornitoriBindingSource2.DataSource = Me.GestioneProduzione2009DataSet
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbVisualizzaGruppi)
        Me.GroupBox2.Controls.Add(Me.rdbVisualizzaArticoli)
        Me.GroupBox2.Location = New System.Drawing.Point(538, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 38)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Visualizza"
        '
        'rdbVisualizzaGruppi
        '
        Me.rdbVisualizzaGruppi.AutoSize = True
        Me.rdbVisualizzaGruppi.Location = New System.Drawing.Point(68, 17)
        Me.rdbVisualizzaGruppi.Name = "rdbVisualizzaGruppi"
        Me.rdbVisualizzaGruppi.Size = New System.Drawing.Size(56, 17)
        Me.rdbVisualizzaGruppi.TabIndex = 1
        Me.rdbVisualizzaGruppi.Text = "Gruppi"
        Me.rdbVisualizzaGruppi.UseVisualStyleBackColor = True
        '
        'rdbVisualizzaArticoli
        '
        Me.rdbVisualizzaArticoli.AutoSize = True
        Me.rdbVisualizzaArticoli.Checked = True
        Me.rdbVisualizzaArticoli.Location = New System.Drawing.Point(6, 17)
        Me.rdbVisualizzaArticoli.Name = "rdbVisualizzaArticoli"
        Me.rdbVisualizzaArticoli.Size = New System.Drawing.Size(56, 17)
        Me.rdbVisualizzaArticoli.TabIndex = 0
        Me.rdbVisualizzaArticoli.TabStop = True
        Me.rdbVisualizzaArticoli.Text = "Articoli"
        Me.rdbVisualizzaArticoli.UseVisualStyleBackColor = True
        '
        'btnAggiorna
        '
        Me.btnAggiorna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggiorna.Image = Global.GestioneProduzione.My.Resources.Resources.reload
        Me.btnAggiorna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAggiorna.Location = New System.Drawing.Point(1050, 12)
        Me.btnAggiorna.Name = "btnAggiorna"
        Me.btnAggiorna.Size = New System.Drawing.Size(100, 30)
        Me.btnAggiorna.TabIndex = 23
        Me.btnAggiorna.Text = "Aggiorna"
        Me.btnAggiorna.UseVisualStyleBackColor = True
        '
        'chbRicercaDaOrdinare
        '
        Me.chbRicercaDaOrdinare.AutoSize = True
        Me.chbRicercaDaOrdinare.Location = New System.Drawing.Point(449, 27)
        Me.chbRicercaDaOrdinare.Name = "chbRicercaDaOrdinare"
        Me.chbRicercaDaOrdinare.Size = New System.Drawing.Size(83, 17)
        Me.chbRicercaDaOrdinare.TabIndex = 6
        Me.chbRicercaDaOrdinare.Text = "Da Ordinare"
        Me.chbRicercaDaOrdinare.UseVisualStyleBackColor = True
        '
        'txtRicercaMatricola
        '
        Me.txtRicercaMatricola.Location = New System.Drawing.Point(343, 25)
        Me.txtRicercaMatricola.Name = "txtRicercaMatricola"
        Me.txtRicercaMatricola.Size = New System.Drawing.Size(100, 20)
        Me.txtRicercaMatricola.TabIndex = 4
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(118, 25)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(219, 20)
        Me.txtRicercaDescrizione.TabIndex = 2
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(12, 25)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(100, 20)
        Me.txtRicercaCodice.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(343, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cerca per Matricola:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cerca per Descrizione:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cerca per Codice:"
        '
        'T11fornitoriBindingSource
        '
        Me.T11fornitoriBindingSource.DataMember = "t11_fornitori"
        Me.T11fornitoriBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'pnlDetail
        '
        Me.pnlDetail.Controls.Add(Me.btnChiudi)
        Me.pnlDetail.Controls.Add(Me.GroupBox1)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetail.Location = New System.Drawing.Point(0, 200)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(1159, 279)
        Me.pnlDetail.TabIndex = 1
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(1050, 237)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(97, 30)
        Me.btnChiudi.TabIndex = 27
        Me.btnChiudi.Text = "&Chiudi"
        Me.btnChiudi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.pnlStatoArticolo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btnAnnullaArticolo)
        Me.GroupBox1.Controls.Add(Me.btnSalvaArticolo)
        Me.GroupBox1.Controls.Add(Me.btnModificaArticolo)
        Me.GroupBox1.Controls.Add(Me.txtPrezzoForzatoArticolo)
        Me.GroupBox1.Controls.Add(Me.txtPrezzoCalcolatoArticolo)
        Me.GroupBox1.Controls.Add(Me.txtCostoArticolo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSituazioneArticolo)
        Me.GroupBox1.Controls.Add(Me.txtQtOrdinataArticolo)
        Me.GroupBox1.Controls.Add(Me.txtLottoRiordinoArticolo)
        Me.GroupBox1.Controls.Add(Me.txtQtDisponibileArticolo)
        Me.GroupBox1.Controls.Add(Me.chbRicambioArticolo)
        Me.GroupBox1.Controls.Add(Me.cmbFornitoreArticolo)
        Me.GroupBox1.Controls.Add(Me.txtDescrizioneArticolo)
        Me.GroupBox1.Controls.Add(Me.txtCodiceArticolo)
        Me.GroupBox1.Controls.Add(Me.dgMatricoleArticolo)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dettagli Articolo :"
        '
        'pnlStatoArticolo
        '
        Me.pnlStatoArticolo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStatoArticolo.Location = New System.Drawing.Point(446, 199)
        Me.pnlStatoArticolo.Name = "pnlStatoArticolo"
        Me.pnlStatoArticolo.Size = New System.Drawing.Size(70, 20)
        Me.pnlStatoArticolo.TabIndex = 26
        Me.pnlStatoArticolo.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(519, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Matricole:"
        '
        'btnAnnullaArticolo
        '
        Me.btnAnnullaArticolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAnnullaArticolo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnullaArticolo.Enabled = False
        Me.btnAnnullaArticolo.Image = Global.GestioneProduzione.My.Resources.Resources.undo
        Me.btnAnnullaArticolo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnullaArticolo.Location = New System.Drawing.Point(400, 231)
        Me.btnAnnullaArticolo.Name = "btnAnnullaArticolo"
        Me.btnAnnullaArticolo.Size = New System.Drawing.Size(100, 30)
        Me.btnAnnullaArticolo.TabIndex = 24
        Me.btnAnnullaArticolo.Text = "Annulla"
        Me.btnAnnullaArticolo.UseVisualStyleBackColor = True
        '
        'btnSalvaArticolo
        '
        Me.btnSalvaArticolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalvaArticolo.Enabled = False
        Me.btnSalvaArticolo.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalvaArticolo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvaArticolo.Location = New System.Drawing.Point(506, 231)
        Me.btnSalvaArticolo.Name = "btnSalvaArticolo"
        Me.btnSalvaArticolo.Size = New System.Drawing.Size(100, 30)
        Me.btnSalvaArticolo.TabIndex = 23
        Me.btnSalvaArticolo.Text = "Salva"
        Me.btnSalvaArticolo.UseVisualStyleBackColor = True
        '
        'btnModificaArticolo
        '
        Me.btnModificaArticolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificaArticolo.Image = Global.GestioneProduzione.My.Resources.Resources.edit
        Me.btnModificaArticolo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificaArticolo.Location = New System.Drawing.Point(612, 231)
        Me.btnModificaArticolo.Name = "btnModificaArticolo"
        Me.btnModificaArticolo.Size = New System.Drawing.Size(100, 30)
        Me.btnModificaArticolo.TabIndex = 22
        Me.btnModificaArticolo.Text = "Modifica"
        Me.btnModificaArticolo.UseVisualStyleBackColor = True
        '
        'txtPrezzoForzatoArticolo
        '
        Me.txtPrezzoForzatoArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_prezzo_forzato", True))
        Me.txtPrezzoForzatoArticolo.Location = New System.Drawing.Point(340, 147)
        Me.txtPrezzoForzatoArticolo.Name = "txtPrezzoForzatoArticolo"
        Me.txtPrezzoForzatoArticolo.ReadOnly = True
        Me.txtPrezzoForzatoArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrezzoForzatoArticolo.TabIndex = 6
        '
        't20_articoliBindingSource
        '
        Me.t20_articoliBindingSource.DataMember = "t20_articoli"
        Me.t20_articoliBindingSource.DataSource = Me.dsSituazioneArticoli
        '
        'dsSituazioneArticoli
        '
        Me.dsSituazioneArticoli.DataSetName = "dsSituazioneArticoli"
        Me.dsSituazioneArticoli.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dsSituazioneArticoli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPrezzoCalcolatoArticolo
        '
        Me.txtPrezzoCalcolatoArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.riepilogoArticoliBindingSource, "prezzo_calcolato", True))
        Me.txtPrezzoCalcolatoArticolo.Location = New System.Drawing.Point(237, 147)
        Me.txtPrezzoCalcolatoArticolo.Name = "txtPrezzoCalcolatoArticolo"
        Me.txtPrezzoCalcolatoArticolo.ReadOnly = True
        Me.txtPrezzoCalcolatoArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtPrezzoCalcolatoArticolo.TabIndex = 5
        '
        'riepilogoArticoliBindingSource
        '
        Me.riepilogoArticoliBindingSource.DataMember = "RiepilogoArticoli"
        Me.riepilogoArticoliBindingSource.DataSource = Me.dsSituazioneArticoli
        '
        'txtCostoArticolo
        '
        Me.txtCostoArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_prezzo", True))
        Me.txtCostoArticolo.Location = New System.Drawing.Point(131, 147)
        Me.txtCostoArticolo.Name = "txtCostoArticolo"
        Me.txtCostoArticolo.ReadOnly = True
        Me.txtCostoArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtCostoArticolo.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Q.tà Ordinata :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(272, 202)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Situazione :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(258, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Scorta minima:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Q.tà Disponibile :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(340, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Prezzo Forzato"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Prezzo Calcolato"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Fornitore"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Costo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Descrizione"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Codice"
        '
        'txtSituazioneArticolo
        '
        Me.txtSituazioneArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.riepilogoArticoliBindingSource, "situazione", True))
        Me.txtSituazioneArticolo.Location = New System.Drawing.Point(340, 199)
        Me.txtSituazioneArticolo.Name = "txtSituazioneArticolo"
        Me.txtSituazioneArticolo.ReadOnly = True
        Me.txtSituazioneArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtSituazioneArticolo.TabIndex = 11
        '
        'txtQtOrdinataArticolo
        '
        Me.txtQtOrdinataArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.riepilogoArticoliBindingSource, "qt_ordinata_articolo", True))
        Me.txtQtOrdinataArticolo.Location = New System.Drawing.Point(131, 199)
        Me.txtQtOrdinataArticolo.Name = "txtQtOrdinataArticolo"
        Me.txtQtOrdinataArticolo.ReadOnly = True
        Me.txtQtOrdinataArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtQtOrdinataArticolo.TabIndex = 10
        '
        'txtLottoRiordinoArticolo
        '
        Me.txtLottoRiordinoArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_lotto_riordino", True))
        Me.txtLottoRiordinoArticolo.Location = New System.Drawing.Point(340, 173)
        Me.txtLottoRiordinoArticolo.Name = "txtLottoRiordinoArticolo"
        Me.txtLottoRiordinoArticolo.ReadOnly = True
        Me.txtLottoRiordinoArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtLottoRiordinoArticolo.TabIndex = 9
        '
        'txtQtDisponibileArticolo
        '
        Me.txtQtDisponibileArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_qt_disponibile", True))
        Me.txtQtDisponibileArticolo.Location = New System.Drawing.Point(131, 173)
        Me.txtQtDisponibileArticolo.Name = "txtQtDisponibileArticolo"
        Me.txtQtDisponibileArticolo.ReadOnly = True
        Me.txtQtDisponibileArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtQtDisponibileArticolo.TabIndex = 8
        '
        'chbRicambioArticolo
        '
        Me.chbRicambioArticolo.AutoSize = True
        Me.chbRicambioArticolo.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.t20_articoliBindingSource, "t20_is_ricambio", True))
        Me.chbRicambioArticolo.Enabled = False
        Me.chbRicambioArticolo.Location = New System.Drawing.Point(446, 149)
        Me.chbRicambioArticolo.Name = "chbRicambioArticolo"
        Me.chbRicambioArticolo.Size = New System.Drawing.Size(70, 17)
        Me.chbRicambioArticolo.TabIndex = 7
        Me.chbRicambioArticolo.Text = "Ricambio"
        Me.chbRicambioArticolo.UseVisualStyleBackColor = True
        '
        'cmbFornitoreArticolo
        '
        Me.cmbFornitoreArticolo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.t20_articoliBindingSource, "t20_id_fornitore_t11", True))
        Me.cmbFornitoreArticolo.DataSource = Me.T11fornitoriBindingSource
        Me.cmbFornitoreArticolo.DisplayMember = "t11_descrizione"
        Me.cmbFornitoreArticolo.Enabled = False
        Me.cmbFornitoreArticolo.FormattingEnabled = True
        Me.cmbFornitoreArticolo.Location = New System.Drawing.Point(131, 107)
        Me.cmbFornitoreArticolo.Name = "cmbFornitoreArticolo"
        Me.cmbFornitoreArticolo.Size = New System.Drawing.Size(344, 21)
        Me.cmbFornitoreArticolo.TabIndex = 3
        Me.cmbFornitoreArticolo.ValueMember = "t11_id_fornitore"
        '
        'txtDescrizioneArticolo
        '
        Me.txtDescrizioneArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_descrizione", True))
        Me.txtDescrizioneArticolo.Location = New System.Drawing.Point(131, 59)
        Me.txtDescrizioneArticolo.MaxLength = 4000
        Me.txtDescrizioneArticolo.Multiline = True
        Me.txtDescrizioneArticolo.Name = "txtDescrizioneArticolo"
        Me.txtDescrizioneArticolo.ReadOnly = True
        Me.txtDescrizioneArticolo.Size = New System.Drawing.Size(344, 42)
        Me.txtDescrizioneArticolo.TabIndex = 2
        '
        'txtCodiceArticolo
        '
        Me.txtCodiceArticolo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.t20_articoliBindingSource, "t20_cod_articolo", True))
        Me.txtCodiceArticolo.Location = New System.Drawing.Point(131, 33)
        Me.txtCodiceArticolo.Name = "txtCodiceArticolo"
        Me.txtCodiceArticolo.ReadOnly = True
        Me.txtCodiceArticolo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodiceArticolo.TabIndex = 1
        '
        'dgMatricoleArticolo
        '
        Me.dgMatricoleArticolo.AllowUserToAddRows = False
        Me.dgMatricoleArticolo.AllowUserToDeleteRows = False
        Me.dgMatricoleArticolo.AutoGenerateColumns = False
        Me.dgMatricoleArticolo.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgMatricoleArticolo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatricoleArticolo.ColumnHeadersVisible = False
        Me.dgMatricoleArticolo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgMatricoleArticolo.DataSource = Me.FKt25matricolet20articoliBindingSource
        Me.dgMatricoleArticolo.Location = New System.Drawing.Point(522, 59)
        Me.dgMatricoleArticolo.Name = "dgMatricoleArticolo"
        Me.dgMatricoleArticolo.ReadOnly = True
        Me.dgMatricoleArticolo.RowHeadersVisible = False
        Me.dgMatricoleArticolo.Size = New System.Drawing.Size(190, 134)
        Me.dgMatricoleArticolo.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "t25_id_matricola"
        Me.DataGridViewTextBoxColumn1.HeaderText = "t25_id_matricola"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "t25_id_articolo_t20"
        Me.DataGridViewTextBoxColumn2.HeaderText = "t25_id_articolo_t20"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "t25_cod_matricola"
        Me.DataGridViewTextBoxColumn3.HeaderText = "t25_cod_matricola"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "t25_descrizione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "t25_descrizione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "t25_dt_creazione"
        Me.DataGridViewTextBoxColumn5.HeaderText = "t25_dt_creazione"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "t25_dt_cancellazione"
        Me.DataGridViewTextBoxColumn6.HeaderText = "t25_dt_cancellazione"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'FKt25matricolet20articoliBindingSource
        '
        Me.FKt25matricolet20articoliBindingSource.DataMember = "FK_t25_matricole_t20_articoli"
        Me.FKt25matricolet20articoliBindingSource.DataSource = Me.T20articolit25matricoleBindingSource
        '
        'T20articolit25matricoleBindingSource
        '
        Me.T20articolit25matricoleBindingSource.DataSource = Me.t20_articoliBindingSource
        '
        't25matricoleBindingSource
        '
        Me.t25matricoleBindingSource.DataMember = "t25_matricole"
        Me.t25matricoleBindingSource.DataSource = Me.dsSituazioneArticoli
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.lblLoading)
        Me.pnlBody.Controls.Add(Me.Label16)
        Me.pnlBody.Controls.Add(Me.dgArticoliRiepilogo)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 53)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1159, 147)
        Me.pnlBody.TabIndex = 2
        '
        'lblLoading
        '
        Me.lblLoading.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLoading.AutoSize = True
        Me.lblLoading.BackColor = System.Drawing.Color.Tomato
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(993, 131)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(163, 13)
        Me.lblLoading.TabIndex = 2
        Me.lblLoading.Text = "Caricamento in corso attendere..."
        Me.lblLoading.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(180, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "RiepilogoArticoli"
        Me.Label16.Visible = False
        '
        'dgArticoliRiepilogo
        '
        Me.dgArticoliRiepilogo.AllowUserToAddRows = False
        Me.dgArticoliRiepilogo.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgArticoliRiepilogo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgArticoliRiepilogo.AutoGenerateColumns = False
        Me.dgArticoliRiepilogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgArticoliRiepilogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgArticoliRiepilogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T20idarticoloDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn, Me.T20qtdisponibileDataGridViewTextBoxColumn, Me.qt_disponibile_in_gruppi, Me.T20lottoriordinoDataGridViewTextBoxColumn, Me.QtordinataarticoloDataGridViewTextBoxColumn, Me.ConsumototaleDataGridViewTextBoxColumn, Me.SituazioneDataGridViewTextBoxColumn, Me.costo, Me.prezzo_calcolato, Me.prezzo_forzato, Me.matricole, Me.fornitore, Me.t20_is_ricambio})
        Me.dgArticoliRiepilogo.DataSource = Me.riepilogoArticoliBindingSource
        Me.dgArticoliRiepilogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticoliRiepilogo.Location = New System.Drawing.Point(0, 0)
        Me.dgArticoliRiepilogo.Name = "dgArticoliRiepilogo"
        Me.dgArticoliRiepilogo.ReadOnly = True
        Me.dgArticoliRiepilogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgArticoliRiepilogo.Size = New System.Drawing.Size(1159, 147)
        Me.dgArticoliRiepilogo.TabIndex = 0
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
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20qtdisponibileDataGridViewTextBoxColumn
        '
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DataPropertyName = "t20_qt_disponibile"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.T20qtdisponibileDataGridViewTextBoxColumn.HeaderText = "Qt.Disp."
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Name = "T20qtdisponibileDataGridViewTextBoxColumn"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'qt_disponibile_in_gruppi
        '
        Me.qt_disponibile_in_gruppi.DataPropertyName = "qt_disponibile_in_gruppi"
        DataGridViewCellStyle3.Format = "N0"
        Me.qt_disponibile_in_gruppi.DefaultCellStyle = DataGridViewCellStyle3
        Me.qt_disponibile_in_gruppi.HeaderText = "Qt.Disp.in Gruppi"
        Me.qt_disponibile_in_gruppi.Name = "qt_disponibile_in_gruppi"
        Me.qt_disponibile_in_gruppi.ReadOnly = True
        Me.qt_disponibile_in_gruppi.Visible = False
        '
        'T20lottoriordinoDataGridViewTextBoxColumn
        '
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DataPropertyName = "t20_lotto_riordino"
        DataGridViewCellStyle4.Format = "N0"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.T20lottoriordinoDataGridViewTextBoxColumn.HeaderText = "Scorta minima"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.Name = "T20lottoriordinoDataGridViewTextBoxColumn"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QtordinataarticoloDataGridViewTextBoxColumn
        '
        Me.QtordinataarticoloDataGridViewTextBoxColumn.DataPropertyName = "qt_ordinata_articolo"
        DataGridViewCellStyle5.Format = "N0"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.QtordinataarticoloDataGridViewTextBoxColumn.HeaderText = "Qt.in Ordine"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.Name = "QtordinataarticoloDataGridViewTextBoxColumn"
        Me.QtordinataarticoloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConsumototaleDataGridViewTextBoxColumn
        '
        Me.ConsumototaleDataGridViewTextBoxColumn.DataPropertyName = "consumo_totale"
        DataGridViewCellStyle6.Format = "N0"
        Me.ConsumototaleDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.ConsumototaleDataGridViewTextBoxColumn.HeaderText = "Consumo"
        Me.ConsumototaleDataGridViewTextBoxColumn.Name = "ConsumototaleDataGridViewTextBoxColumn"
        Me.ConsumototaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SituazioneDataGridViewTextBoxColumn
        '
        Me.SituazioneDataGridViewTextBoxColumn.DataPropertyName = "situazione"
        DataGridViewCellStyle7.Format = "N0"
        Me.SituazioneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.SituazioneDataGridViewTextBoxColumn.HeaderText = "Situazione"
        Me.SituazioneDataGridViewTextBoxColumn.Name = "SituazioneDataGridViewTextBoxColumn"
        Me.SituazioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'costo
        '
        Me.costo.DataPropertyName = "costo"
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.costo.DefaultCellStyle = DataGridViewCellStyle8
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        Me.costo.ReadOnly = True
        '
        'prezzo_calcolato
        '
        Me.prezzo_calcolato.DataPropertyName = "prezzo_calcolato"
        DataGridViewCellStyle9.Format = "C2"
        Me.prezzo_calcolato.DefaultCellStyle = DataGridViewCellStyle9
        Me.prezzo_calcolato.HeaderText = "Prezzo Calcolato"
        Me.prezzo_calcolato.Name = "prezzo_calcolato"
        Me.prezzo_calcolato.ReadOnly = True
        '
        'prezzo_forzato
        '
        Me.prezzo_forzato.DataPropertyName = "prezzo_forzato"
        DataGridViewCellStyle10.Format = "C2"
        Me.prezzo_forzato.DefaultCellStyle = DataGridViewCellStyle10
        Me.prezzo_forzato.HeaderText = "Prezzo Forzato"
        Me.prezzo_forzato.Name = "prezzo_forzato"
        Me.prezzo_forzato.ReadOnly = True
        '
        'matricole
        '
        Me.matricole.DataPropertyName = "matricole"
        Me.matricole.HeaderText = "Matricole"
        Me.matricole.Name = "matricole"
        Me.matricole.ReadOnly = True
        '
        'fornitore
        '
        Me.fornitore.DataPropertyName = "fornitore"
        Me.fornitore.HeaderText = "Fornitore"
        Me.fornitore.Name = "fornitore"
        Me.fornitore.ReadOnly = True
        '
        't20_is_ricambio
        '
        Me.t20_is_ricambio.DataPropertyName = "t20_is_ricambio"
        Me.t20_is_ricambio.HeaderText = "Ricambio"
        Me.t20_is_ricambio.Name = "t20_is_ricambio"
        Me.t20_is_ricambio.ReadOnly = True
        '
        'T11_fornitoriTableAdapter
        '
        Me.T11_fornitoriTableAdapter.ClearBeforeFill = True
        '
        'cmnuGruppi
        '
        Me.cmnuGruppi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScomponiGruppoToolStripMenuItem})
        Me.cmnuGruppi.Name = "cmnuGruppi"
        Me.cmnuGruppi.Size = New System.Drawing.Size(169, 26)
        '
        'ScomponiGruppoToolStripMenuItem
        '
        Me.ScomponiGruppoToolStripMenuItem.Name = "ScomponiGruppoToolStripMenuItem"
        Me.ScomponiGruppoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ScomponiGruppoToolStripMenuItem.Text = "Scomponi Gruppo"
        '
        'T25_matricoleTableAdapter
        '
        Me.T25_matricoleTableAdapter.ClearBeforeFill = True
        '
        'frmArticoliSituazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(1159, 479)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlDetail)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticoliSituazione"
        Me.Text = "Elenco e Situazione Articoli e Gruppi"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.T11fornitoriBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.T11fornitoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetail.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.t20_articoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsSituazioneArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riepilogoArticoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMatricoleArticolo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKt25matricolet20articoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T20articolit25matricoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t25matricoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        CType(Me.dgArticoliRiepilogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuGruppi.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlDetail As System.Windows.Forms.Panel
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents dgArticoliRiepilogo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRicercaMatricola As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents riepilogoArticoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsSituazioneArticoli As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents dgMatricoleArticolo As System.Windows.Forms.DataGridView
    Friend WithEvents t25matricoleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtCodiceArticolo As System.Windows.Forms.TextBox
    Friend WithEvents t20_articoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtDescrizioneArticolo As System.Windows.Forms.TextBox
    Friend WithEvents T20articolit25matricoleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chbRicercaDaOrdinare As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSituazioneArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtQtOrdinataArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtLottoRiordinoArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtQtDisponibileArticolo As System.Windows.Forms.TextBox
    Friend WithEvents chbRicambioArticolo As System.Windows.Forms.CheckBox
    Friend WithEvents txtPrezzoForzatoArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtPrezzoCalcolatoArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoArticolo As System.Windows.Forms.TextBox
    Friend WithEvents cmbFornitoreArticolo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T11fornitoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T11_fornitoriTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t11_fornitoriTableAdapter
    Friend WithEvents btnModificaArticolo As System.Windows.Forms.Button
    Friend WithEvents btnAnnullaArticolo As System.Windows.Forms.Button
    Friend WithEvents btnSalvaArticolo As System.Windows.Forms.Button
    Friend WithEvents btnAggiorna As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents T25idmatricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25idarticolot20DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25codmatricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25dtcreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T25dtcancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbVisualizzaGruppi As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVisualizzaArticoli As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents T11fornitoriBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents cmnuGruppi As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ScomponiGruppoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlStatoArticolo As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents chbRicambi As System.Windows.Forms.CheckBox
    Friend WithEvents lblLoading As System.Windows.Forms.Label
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20qtdisponibileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qt_disponibile_in_gruppi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20lottoriordinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtordinataarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConsumototaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzo_calcolato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prezzo_forzato As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents matricole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fornitore As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t20_is_ricambio As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents FKt25matricolet20articoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T25_matricoleTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
