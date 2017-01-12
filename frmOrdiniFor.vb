Imports Microsoft.ApplicationBlocks.Data.SqlHelper
Imports GestioneProduzione2014Data
Imports GestioneProduzione2014GinuxImport

Public Class frmOrdiniFor
    Inherits System.Windows.Forms.Form

    Public IDOrdine As Integer          'IDOrdine correttemente editato
    Private mintIDArticolo As Integer   'IDArticolo per spostamento su gruppo
    Private mstrSQL As String
    Private objdsRigheOrdine As DataSet
    Private mstrMsg As String
    Private DataViewArticoli As DataView
    Private DataViewFornitori As DataView
    Private DataViewCausali As DataView
    Private DataViewGruppi As DataView
    Private blnFormLoaded As Boolean = False
    Friend WithEvents btnWord As System.Windows.Forms.Button
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsArticoli21 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents objdsListaGruppi As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Tab_Articoli As System.Windows.Forms.TabPage
    Friend WithEvents DataGridArticoli As System.Windows.Forms.DataGrid
    Friend WithEvents Tab_Gruppi As System.Windows.Forms.TabPage
    Friend WithEvents DataGridGruppi As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnEvadi As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private blnVariazione As Boolean

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
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents txtDescrizioneOrdine As System.Windows.Forms.TextBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTextBoxColumn_IDArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_CodArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_Descrizione_Articolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblRicercaDescrizione As System.Windows.Forms.Label
    Friend WithEvents lblRicercaCodice As System.Windows.Forms.Label
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents btnSpostaGiu As System.Windows.Forms.Button
    Friend WithEvents btnSpostaSu As System.Windows.Forms.Button
    Friend WithEvents btnRemoveArticolo As System.Windows.Forms.Button
    Friend WithEvents btnAddArticolo As System.Windows.Forms.Button
    Friend WithEvents DataGridArticoliOrdine As System.Windows.Forms.DataGrid
    Friend WithEvents pnlArticoliOrdine As System.Windows.Forms.Panel
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CodArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtaOrdinata As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblDescrizioneOrdine As System.Windows.Forms.Label
    Friend WithEvents btnNuovoOrdine As System.Windows.Forms.Button
    Friend WithEvents QtaEvasa As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StatoRiga As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PrezzoUni As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodiceOrdine As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents objListaFornitori As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtOrdine As System.Windows.Forms.DateTimePicker
    Friend WithEvents objdsListaArticoli As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents dtConsegna As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dav01_articoli As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents dat11_fornitori As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dat15_causali_ordini_for As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaCausali As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents btnStampa As System.Windows.Forms.Button
    Friend WithEvents DataConsegna As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtTipoOrdine As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdiniFor))
        Me.lblDescrizioneOrdine = New System.Windows.Forms.Label
        Me.txtDescrizioneOrdine = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.dav01_articoli = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnEvadi = New System.Windows.Forms.Button
        Me.btnWord = New System.Windows.Forms.Button
        Me.btnStampa = New System.Windows.Forms.Button
        Me.btnNuovoOrdine = New System.Windows.Forms.Button
        Me.pnlArticoliOrdine = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_Articoli = New System.Windows.Forms.TabPage
        Me.DataGridArticoli = New System.Windows.Forms.DataGrid
        Me.objdsListaArticoli = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tab_Gruppi = New System.Windows.Forms.TabPage
        Me.DataGridGruppi = New System.Windows.Forms.DataGrid
        Me.objdsListaGruppi = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lblRicercaDescrizione = New System.Windows.Forms.Label
        Me.lblRicercaCodice = New System.Windows.Forms.Label
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.btnRemoveArticolo = New System.Windows.Forms.Button
        Me.btnAddArticolo = New System.Windows.Forms.Button
        Me.DataGridArticoliOrdine = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CodArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtaOrdinata = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtaEvasa = New System.Windows.Forms.DataGridTextBoxColumn
        Me.PrezzoUni = New System.Windows.Forms.DataGridTextBoxColumn
        Me.StatoRiga = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataConsegna = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_IDArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_CodArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_Descrizione_Articolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodiceOrdine = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbFornitore = New System.Windows.Forms.ComboBox
        Me.dat11_fornitori = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtOrdine = New System.Windows.Forms.DateTimePicker
        Me.dtConsegna = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbCausale = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dat15_causali_ordini_for = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.txtTipoOrdine = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.objListaFornitori = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.objdsListaCausali = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DsArticoli21 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.pnlArticoliOrdine.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Articoli.SuspendLayout()
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Gruppi.SuspendLayout()
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridArticoliOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objListaFornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticoli21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescrizioneOrdine
        '
        Me.lblDescrizioneOrdine.Location = New System.Drawing.Point(8, 40)
        Me.lblDescrizioneOrdine.Name = "lblDescrizioneOrdine"
        Me.lblDescrizioneOrdine.Size = New System.Drawing.Size(112, 16)
        Me.lblDescrizioneOrdine.TabIndex = 0
        Me.lblDescrizioneOrdine.Text = "Descrizione Ordine :"
        '
        'txtDescrizioneOrdine
        '
        Me.txtDescrizioneOrdine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizioneOrdine.Location = New System.Drawing.Point(128, 40)
        Me.txtDescrizioneOrdine.Multiline = True
        Me.txtDescrizioneOrdine.Name = "txtDescrizioneOrdine"
        Me.txtDescrizioneOrdine.Size = New System.Drawing.Size(736, 48)
        Me.txtDescrizioneOrdine.TabIndex = 1
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'dav01_articoli
        '
        Me.dav01_articoli.SelectCommand = Me.SqlSelectCommand1
        Me.dav01_articoli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v01_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT t20_id_articolo, t20_cod_articolo, t20_descrizione, t20_prezzo, t20_qt_dis" & _
            "ponibile, t20_lotto_riordino, t20_is_gruppo, t20_dt_creazione, t20_dt_modifica, " & _
            "t20_dt_cancellazione FROM v01_articoli"
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.GestioneProduzione.My.Resources.Resources.export_pdf
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(930, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 40)
        Me.Button1.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Button1, "Esporta in PDF")
        '
        'btnEvadi
        '
        Me.btnEvadi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvadi.Image = Global.GestioneProduzione.My.Resources.Resources.apply
        Me.btnEvadi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEvadi.Location = New System.Drawing.Point(880, 128)
        Me.btnEvadi.Name = "btnEvadi"
        Me.btnEvadi.Size = New System.Drawing.Size(96, 32)
        Me.btnEvadi.TabIndex = 19
        Me.btnEvadi.Text = "Evadi"
        Me.ToolTip1.SetToolTip(Me.btnEvadi, "Evadi Righe per questo ordine")
        '
        'btnWord
        '
        Me.btnWord.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWord.Image = Global.GestioneProduzione.My.Resources.Resources.export_word
        Me.btnWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWord.Location = New System.Drawing.Point(880, 86)
        Me.btnWord.Name = "btnWord"
        Me.btnWord.Size = New System.Drawing.Size(44, 40)
        Me.btnWord.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.btnWord, "Esporta in Word")
        '
        'btnStampa
        '
        Me.btnStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampa.Image = CType(resources.GetObject("btnStampa.Image"), System.Drawing.Image)
        Me.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStampa.Location = New System.Drawing.Point(880, 48)
        Me.btnStampa.Name = "btnStampa"
        Me.btnStampa.Size = New System.Drawing.Size(96, 32)
        Me.btnStampa.TabIndex = 15
        Me.btnStampa.Text = "Stampa"
        Me.ToolTip1.SetToolTip(Me.btnStampa, "Anteprima di Stampa")
        '
        'btnNuovoOrdine
        '
        Me.btnNuovoOrdine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuovoOrdine.Image = CType(resources.GetObject("btnNuovoOrdine.Image"), System.Drawing.Image)
        Me.btnNuovoOrdine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovoOrdine.Location = New System.Drawing.Point(880, 8)
        Me.btnNuovoOrdine.Name = "btnNuovoOrdine"
        Me.btnNuovoOrdine.Size = New System.Drawing.Size(96, 32)
        Me.btnNuovoOrdine.TabIndex = 2
        Me.btnNuovoOrdine.Text = "&Nuovo"
        Me.ToolTip1.SetToolTip(Me.btnNuovoOrdine, "Salva/Nuovo Ordine")
        '
        'pnlArticoliOrdine
        '
        Me.pnlArticoliOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlArticoliOrdine.Controls.Add(Me.TabControl1)
        Me.pnlArticoliOrdine.Controls.Add(Me.lblRicercaDescrizione)
        Me.pnlArticoliOrdine.Controls.Add(Me.lblRicercaCodice)
        Me.pnlArticoliOrdine.Controls.Add(Me.txtRicercaCodice)
        Me.pnlArticoliOrdine.Controls.Add(Me.txtRicercaDescrizione)
        Me.pnlArticoliOrdine.Controls.Add(Me.btnSpostaGiu)
        Me.pnlArticoliOrdine.Controls.Add(Me.btnSpostaSu)
        Me.pnlArticoliOrdine.Controls.Add(Me.btnRemoveArticolo)
        Me.pnlArticoliOrdine.Controls.Add(Me.btnAddArticolo)
        Me.pnlArticoliOrdine.Controls.Add(Me.DataGridArticoliOrdine)
        Me.pnlArticoliOrdine.Enabled = False
        Me.pnlArticoliOrdine.Location = New System.Drawing.Point(0, 176)
        Me.pnlArticoliOrdine.Name = "pnlArticoliOrdine"
        Me.pnlArticoliOrdine.Size = New System.Drawing.Size(984, 368)
        Me.pnlArticoliOrdine.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab_Articoli)
        Me.TabControl1.Controls.Add(Me.Tab_Gruppi)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(18, 66)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(256, 299)
        Me.TabControl1.TabIndex = 13
        '
        'Tab_Articoli
        '
        Me.Tab_Articoli.Controls.Add(Me.DataGridArticoli)
        Me.Tab_Articoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Articoli.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Articoli.Name = "Tab_Articoli"
        Me.Tab_Articoli.Size = New System.Drawing.Size(248, 273)
        Me.Tab_Articoli.TabIndex = 0
        Me.Tab_Articoli.Text = "Articoli Disponibili"
        '
        'DataGridArticoli
        '
        Me.DataGridArticoli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridArticoli.CaptionText = "Articoli Disponibili"
        Me.DataGridArticoli.CaptionVisible = False
        Me.DataGridArticoli.DataMember = "v01_articoli"
        Me.DataGridArticoli.DataSource = Me.objdsListaArticoli
        Me.DataGridArticoli.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridArticoli.Location = New System.Drawing.Point(0, 0)
        Me.DataGridArticoli.Name = "DataGridArticoli"
        Me.DataGridArticoli.ReadOnly = True
        Me.DataGridArticoli.Size = New System.Drawing.Size(248, 270)
        Me.DataGridArticoli.TabIndex = 0
        Me.DataGridArticoli.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'objdsListaArticoli
        '
        Me.objdsListaArticoli.DataSetName = "dsArticoli2"
        Me.objdsListaArticoli.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaArticoli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DataGridArticoli
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "v01_articoli"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "ID Articolo"
        Me.DataGridTextBoxColumn3.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codice"
        Me.DataGridTextBoxColumn1.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn2.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'Tab_Gruppi
        '
        Me.Tab_Gruppi.Controls.Add(Me.DataGridGruppi)
        Me.Tab_Gruppi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Gruppi.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Gruppi.Name = "Tab_Gruppi"
        Me.Tab_Gruppi.Size = New System.Drawing.Size(248, 273)
        Me.Tab_Gruppi.TabIndex = 1
        Me.Tab_Gruppi.Text = "Gruppi Disponibili"
        '
        'DataGridGruppi
        '
        Me.DataGridGruppi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridGruppi.CaptionText = "Gruppi Disponibili"
        Me.DataGridGruppi.CaptionVisible = False
        Me.DataGridGruppi.DataMember = "v03_gruppi"
        Me.DataGridGruppi.DataSource = Me.objdsListaGruppi
        Me.DataGridGruppi.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridGruppi.Location = New System.Drawing.Point(0, 0)
        Me.DataGridGruppi.Name = "DataGridGruppi"
        Me.DataGridGruppi.ReadOnly = True
        Me.DataGridGruppi.Size = New System.Drawing.Size(248, 270)
        Me.DataGridGruppi.TabIndex = 7
        Me.DataGridGruppi.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'objdsListaGruppi
        '
        Me.objdsListaGruppi.DataSetName = "dsGruppi2"
        Me.objdsListaGruppi.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaGruppi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DataGridGruppi
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "v03_gruppi"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "ID Articolo"
        Me.DataGridTextBoxColumn4.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Codice"
        Me.DataGridTextBoxColumn5.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn6.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'lblRicercaDescrizione
        '
        Me.lblRicercaDescrizione.Location = New System.Drawing.Point(8, 40)
        Me.lblRicercaDescrizione.Name = "lblRicercaDescrizione"
        Me.lblRicercaDescrizione.Size = New System.Drawing.Size(72, 16)
        Me.lblRicercaDescrizione.TabIndex = 2
        Me.lblRicercaDescrizione.Text = "Descrizione :"
        '
        'lblRicercaCodice
        '
        Me.lblRicercaCodice.Location = New System.Drawing.Point(8, 16)
        Me.lblRicercaCodice.Name = "lblRicercaCodice"
        Me.lblRicercaCodice.Size = New System.Drawing.Size(48, 16)
        Me.lblRicercaCodice.TabIndex = 0
        Me.lblRicercaCodice.Text = "Codice :"
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(88, 16)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(184, 20)
        Me.txtRicercaCodice.TabIndex = 0
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(88, 40)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(184, 20)
        Me.txtRicercaDescrizione.TabIndex = 1
        '
        'btnSpostaGiu
        '
        Me.btnSpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaGiu.Image = CType(resources.GetObject("btnSpostaGiu.Image"), System.Drawing.Image)
        Me.btnSpostaGiu.Location = New System.Drawing.Point(944, 160)
        Me.btnSpostaGiu.Name = "btnSpostaGiu"
        Me.btnSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaGiu.TabIndex = 9
        '
        'btnSpostaSu
        '
        Me.btnSpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpostaSu.Image = CType(resources.GetObject("btnSpostaSu.Image"), System.Drawing.Image)
        Me.btnSpostaSu.Location = New System.Drawing.Point(944, 104)
        Me.btnSpostaSu.Name = "btnSpostaSu"
        Me.btnSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaSu.TabIndex = 8
        '
        'btnRemoveArticolo
        '
        Me.btnRemoveArticolo.Image = CType(resources.GetObject("btnRemoveArticolo.Image"), System.Drawing.Image)
        Me.btnRemoveArticolo.Location = New System.Drawing.Point(280, 160)
        Me.btnRemoveArticolo.Name = "btnRemoveArticolo"
        Me.btnRemoveArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnRemoveArticolo.TabIndex = 6
        '
        'btnAddArticolo
        '
        Me.btnAddArticolo.Image = CType(resources.GetObject("btnAddArticolo.Image"), System.Drawing.Image)
        Me.btnAddArticolo.Location = New System.Drawing.Point(280, 104)
        Me.btnAddArticolo.Name = "btnAddArticolo"
        Me.btnAddArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnAddArticolo.TabIndex = 3
        '
        'DataGridArticoliOrdine
        '
        Me.DataGridArticoliOrdine.AllowSorting = False
        Me.DataGridArticoliOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridArticoliOrdine.CaptionText = "Articoli Appartenenti all' Ordine"
        Me.DataGridArticoliOrdine.DataMember = ""
        Me.DataGridArticoliOrdine.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridArticoliOrdine.Location = New System.Drawing.Point(320, 72)
        Me.DataGridArticoliOrdine.Name = "DataGridArticoliOrdine"
        Me.DataGridArticoliOrdine.ReadOnly = True
        Me.DataGridArticoliOrdine.Size = New System.Drawing.Size(616, 288)
        Me.DataGridArticoliOrdine.TabIndex = 7
        Me.DataGridArticoliOrdine.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridArticoliOrdine
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CodArticolo, Me.DescrArticolo, Me.QtaOrdinata, Me.QtaEvasa, Me.PrezzoUni, Me.StatoRiga, Me.DataConsegna})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'CodArticolo
        '
        Me.CodArticolo.Format = ""
        Me.CodArticolo.FormatInfo = Nothing
        Me.CodArticolo.HeaderText = "Codice Articolo"
        Me.CodArticolo.MappingName = "t20_cod_articolo"
        Me.CodArticolo.NullText = ""
        Me.CodArticolo.Width = 90
        '
        'DescrArticolo
        '
        Me.DescrArticolo.Format = ""
        Me.DescrArticolo.FormatInfo = Nothing
        Me.DescrArticolo.HeaderText = "Descrizione Articolo"
        Me.DescrArticolo.MappingName = "t20_descrizione"
        Me.DescrArticolo.NullText = ""
        Me.DescrArticolo.Width = 250
        '
        'QtaOrdinata
        '
        Me.QtaOrdinata.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtaOrdinata.Format = "#####0.00"
        Me.QtaOrdinata.FormatInfo = Nothing
        Me.QtaOrdinata.HeaderText = "Q.tà Ordinata"
        Me.QtaOrdinata.MappingName = "t09_qt_ordinata"
        Me.QtaOrdinata.NullText = "0"
        Me.QtaOrdinata.Width = 90
        '
        'QtaEvasa
        '
        Me.QtaEvasa.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtaEvasa.Format = "#####0.00"
        Me.QtaEvasa.FormatInfo = Nothing
        Me.QtaEvasa.HeaderText = "Q.tà Evasa"
        Me.QtaEvasa.MappingName = "t09_qt_evasa"
        Me.QtaEvasa.NullText = "0"
        Me.QtaEvasa.Width = 90
        '
        'PrezzoUni
        '
        Me.PrezzoUni.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrezzoUni.Format = "#####0.00"
        Me.PrezzoUni.FormatInfo = Nothing
        Me.PrezzoUni.HeaderText = "Prezzo Uni."
        Me.PrezzoUni.MappingName = "t09_prezzo_uni"
        Me.PrezzoUni.NullText = "0"
        Me.PrezzoUni.Width = 75
        '
        'StatoRiga
        '
        Me.StatoRiga.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatoRiga.Format = ""
        Me.StatoRiga.FormatInfo = Nothing
        Me.StatoRiga.HeaderText = "Stato"
        Me.StatoRiga.MappingName = "t09_id_stato_riga_ordine_t10"
        Me.StatoRiga.NullText = ""
        Me.StatoRiga.Width = 50
        '
        'DataConsegna
        '
        Me.DataConsegna.Format = "dd/MM/yyyy"
        Me.DataConsegna.FormatInfo = Nothing
        Me.DataConsegna.HeaderText = "Data Consegna"
        Me.DataConsegna.MappingName = "t09_dt_consegna"
        Me.DataConsegna.NullText = "  /  /    "
        Me.DataConsegna.Width = 75
        '
        'DataGridTextBoxColumn_IDArticolo
        '
        Me.DataGridTextBoxColumn_IDArticolo.Format = ""
        Me.DataGridTextBoxColumn_IDArticolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_IDArticolo.HeaderText = "ID Articolo"
        Me.DataGridTextBoxColumn_IDArticolo.MappingName = "t01_id_articolo"
        Me.DataGridTextBoxColumn_IDArticolo.NullText = "0"
        Me.DataGridTextBoxColumn_IDArticolo.Width = 0
        '
        'DataGridTextBoxColumn_CodArticolo
        '
        Me.DataGridTextBoxColumn_CodArticolo.Format = ""
        Me.DataGridTextBoxColumn_CodArticolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_CodArticolo.HeaderText = "Codice"
        Me.DataGridTextBoxColumn_CodArticolo.MappingName = "t01_cod_articolo"
        Me.DataGridTextBoxColumn_CodArticolo.NullText = ""
        Me.DataGridTextBoxColumn_CodArticolo.Width = 75
        '
        'DataGridTextBoxColumn_Descrizione_Articolo
        '
        Me.DataGridTextBoxColumn_Descrizione_Articolo.Format = ""
        Me.DataGridTextBoxColumn_Descrizione_Articolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_Descrizione_Articolo.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Articolo.MappingName = "t01_descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Articolo.NullText = ""
        Me.DataGridTextBoxColumn_Descrizione_Articolo.Width = 200
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numero Ordine :"
        '
        'txtCodiceOrdine
        '
        Me.txtCodiceOrdine.Location = New System.Drawing.Point(128, 16)
        Me.txtCodiceOrdine.Name = "txtCodiceOrdine"
        Me.txtCodiceOrdine.Size = New System.Drawing.Size(240, 20)
        Me.txtCodiceOrdine.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fornitore :"
        '
        'cmbFornitore
        '
        Me.cmbFornitore.Location = New System.Drawing.Point(128, 96)
        Me.cmbFornitore.Name = "cmbFornitore"
        Me.cmbFornitore.Size = New System.Drawing.Size(240, 21)
        Me.cmbFornitore.TabIndex = 2
        '
        'dat11_fornitori
        '
        Me.dat11_fornitori.DeleteCommand = Me.SqlDeleteCommand1
        Me.dat11_fornitori.InsertCommand = Me.SqlInsertCommand2
        Me.dat11_fornitori.SelectCommand = Me.SqlSelectCommand2
        Me.dat11_fornitori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t11_fornitori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t11_id_fornitore", "t11_id_fornitore"), New System.Data.Common.DataColumnMapping("t11_cod_fornitore", "t11_cod_fornitore"), New System.Data.Common.DataColumnMapping("t11_descrizione", "t11_descrizione"), New System.Data.Common.DataColumnMapping("t11_telefono", "t11_telefono"), New System.Data.Common.DataColumnMapping("t11_note", "t11_note"), New System.Data.Common.DataColumnMapping("t11_dt_creazione", "t11_dt_creazione"), New System.Data.Common.DataColumnMapping("t11_dt_modifica", "t11_dt_modifica"), New System.Data.Common.DataColumnMapping("t11_dt_cancellazione", "t11_dt_cancellazione")})})
        Me.dat11_fornitori.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.conn1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t11_id_fornitore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_id_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_cod_fornitore", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.conn1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t11_cod_fornitore", System.Data.SqlDbType.VarChar, 20, "t11_cod_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_descrizione", System.Data.SqlDbType.VarChar, 255, "t11_descrizione"), New System.Data.SqlClient.SqlParameter("@t11_telefono", System.Data.SqlDbType.VarChar, 20, "t11_telefono"), New System.Data.SqlClient.SqlParameter("@t11_note", System.Data.SqlDbType.VarChar, 2147483647, "t11_note"), New System.Data.SqlClient.SqlParameter("@t11_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t11_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t11_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_cancellazione")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT t11_id_fornitore, t11_cod_fornitore, t11_descrizione, t11_telefono, t11_no" & _
            "te, t11_dt_creazione, t11_dt_modifica, t11_dt_cancellazione FROM t11_fornitori O" & _
            "RDER BY t11_descrizione"
        Me.SqlSelectCommand2.Connection = Me.conn1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.conn1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t11_cod_fornitore", System.Data.SqlDbType.VarChar, 20, "t11_cod_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_descrizione", System.Data.SqlDbType.VarChar, 255, "t11_descrizione"), New System.Data.SqlClient.SqlParameter("@t11_telefono", System.Data.SqlDbType.VarChar, 20, "t11_telefono"), New System.Data.SqlClient.SqlParameter("@t11_note", System.Data.SqlDbType.VarChar, 2147483647, "t11_note"), New System.Data.SqlClient.SqlParameter("@t11_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t11_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t11_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t11_id_fornitore", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_id_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_cod_fornitore", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t11_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t11_id_fornitore", System.Data.SqlDbType.Int, 4, "t11_id_fornitore")})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Data Ordine :"
        '
        'dtOrdine
        '
        Me.dtOrdine.Checked = False
        Me.dtOrdine.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtOrdine.Location = New System.Drawing.Point(128, 120)
        Me.dtOrdine.Name = "dtOrdine"
        Me.dtOrdine.Size = New System.Drawing.Size(104, 20)
        Me.dtOrdine.TabIndex = 10
        '
        'dtConsegna
        '
        Me.dtConsegna.Checked = False
        Me.dtConsegna.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtConsegna.Location = New System.Drawing.Point(128, 144)
        Me.dtConsegna.Name = "dtConsegna"
        Me.dtConsegna.ShowCheckBox = True
        Me.dtConsegna.Size = New System.Drawing.Size(104, 20)
        Me.dtConsegna.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Data Consegna :"
        '
        'cmbCausale
        '
        Me.cmbCausale.Location = New System.Drawing.Point(504, 96)
        Me.cmbCausale.Name = "cmbCausale"
        Me.cmbCausale.Size = New System.Drawing.Size(240, 21)
        Me.cmbCausale.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(384, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Causale :"
        '
        'dat15_causali_ordini_for
        '
        Me.dat15_causali_ordini_for.DeleteCommand = Me.SqlDeleteCommand2
        Me.dat15_causali_ordini_for.InsertCommand = Me.SqlInsertCommand3
        Me.dat15_causali_ordini_for.SelectCommand = Me.SqlSelectCommand3
        Me.dat15_causali_ordini_for.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t15_causali_ordini_for", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t15_id_causale_ordine_for", "t15_id_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_cod_causale_ordine_for", "t15_cod_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_descrizione", "t15_descrizione"), New System.Data.Common.DataColumnMapping("t15_tipo_azione", "t15_tipo_azione"), New System.Data.Common.DataColumnMapping("t15_dt_creazione", "t15_dt_creazione"), New System.Data.Common.DataColumnMapping("t15_dt_modifica", "t15_dt_modifica"), New System.Data.Common.DataColumnMapping("t15_dt_cancellazione", "t15_dt_cancellazione")})})
        Me.dat15_causali_ordini_for.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.conn1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_id_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_cod_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_tipo_azione", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.conn1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, "t15_cod_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_descrizione", System.Data.SqlDbType.VarChar, 50, "t15_descrizione"), New System.Data.SqlClient.SqlParameter("@t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, "t15_tipo_azione"), New System.Data.SqlClient.SqlParameter("@t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t15_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_cancellazione")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.conn1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.conn1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, "t15_cod_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_descrizione", System.Data.SqlDbType.VarChar, 50, "t15_descrizione"), New System.Data.SqlClient.SqlParameter("@t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, "t15_tipo_azione"), New System.Data.SqlClient.SqlParameter("@t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t15_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_id_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_cod_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_tipo_azione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, "t15_id_causale_ordine_for")})
        '
        'txtTipoOrdine
        '
        Me.txtTipoOrdine.Location = New System.Drawing.Point(496, 16)
        Me.txtTipoOrdine.Name = "txtTipoOrdine"
        Me.txtTipoOrdine.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoOrdine.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(384, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Commessa :"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v01_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t20_id_fornitore_t11", "t20_id_fornitore_t11"), New System.Data.Common.DataColumnMapping("t20_prezzo_forzato", "t20_prezzo_forzato"), New System.Data.Common.DataColumnMapping("t20_is_ricambio", "t20_is_ricambio"), New System.Data.Common.DataColumnMapping("t20_timestamp", "t20_timestamp")})})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = "SELECT       *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            v01_articoli" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ORDER BY t20_cod_articolo"
        Me.SqlCommand2.Connection = Me.conn1
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.conn1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.SelectCommand = Me.SqlCommand4
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v03_gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t20_id_fornitore_t11", "t20_id_fornitore_t11"), New System.Data.Common.DataColumnMapping("t20_prezzo_forzato", "t20_prezzo_forzato"), New System.Data.Common.DataColumnMapping("t20_is_ricambio", "t20_is_ricambio"), New System.Data.Common.DataColumnMapping("t20_timestamp", "t20_timestamp")})})
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.conn1
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        Me.SqlCommand3.Connection = Me.conn1
        Me.SqlCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = CType(resources.GetObject("btnChiudi.Image"), System.Drawing.Image)
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(840, 544)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 4
        Me.btnChiudi.Text = "&Chiudi"
        '
        'objListaFornitori
        '
        Me.objListaFornitori.DataSetName = "dsListaFornitori"
        Me.objListaFornitori.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objListaFornitori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'objdsListaCausali
        '
        Me.objdsListaCausali.DataSetName = "dsListaCausali"
        Me.objdsListaCausali.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaCausali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsArticoli21
        '
        Me.DsArticoli21.DataSetName = "dsArticoli2"
        Me.DsArticoli21.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.DsArticoli21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmOrdiniFor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 590)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEvadi)
        Me.Controls.Add(Me.btnWord)
        Me.Controls.Add(Me.txtTipoOrdine)
        Me.Controls.Add(Me.btnStampa)
        Me.Controls.Add(Me.cmbCausale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtConsegna)
        Me.Controls.Add(Me.dtOrdine)
        Me.Controls.Add(Me.txtCodiceOrdine)
        Me.Controls.Add(Me.txtDescrizioneOrdine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbFornitore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuovoOrdine)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.lblDescrizioneOrdine)
        Me.Controls.Add(Me.pnlArticoliOrdine)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdiniFor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordini Acquisto"
        Me.pnlArticoliOrdine.ResumeLayout(False)
        Me.pnlArticoliOrdine.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Articoli.ResumeLayout(False)
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Gruppi.ResumeLayout(False)
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridArticoliOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objListaFornitori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticoli21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmOrdiniFor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        ' Caricamento elenco Articoli
        'dav01_articoli.Fill(objdsListaArticoli)
        'DataViewArticoli = objdsListaArticoli.v01_articoli.DefaultView
        'DataGridArticoli.DataSource = DataViewArticoli

        SqlDataAdapter1.Fill(objdsListaArticoli)
        SqlDataAdapter2.Fill(objdsListaGruppi)
        DataViewArticoli = objdsListaArticoli.v01_articoli.DefaultView
        DataGridArticoli.DataSource = DataViewArticoli

        DataViewGruppi = objdsListaGruppi.v03_gruppi.DefaultView
        DataGridGruppi.DataSource = DataViewGruppi


        ' Caricamento elenco Fornitori
        dat11_fornitori.Fill(objListaFornitori)
        DataViewFornitori = objListaFornitori.t11_fornitori.DefaultView()
        DataViewFornitori.Sort = "t11_descrizione asc"
        cmbFornitore.DataSource = DataViewFornitori
        cmbFornitore.ValueMember = "t11_id_fornitore"
        cmbFornitore.DisplayMember = "t11_descrizione"

        ' Caricamento elenco Causali
        dat15_causali_ordini_for.Fill(objdsListaCausali)
        DataViewCausali = objdsListaCausali.t15_causali_ordini_for.DefaultView()
        DataViewCausali.Sort = "t15_descrizione asc"
        cmbCausale.DataSource = DataViewCausali
        cmbCausale.ValueMember = "t15_id_causale_ordine_for"
        cmbCausale.DisplayMember = "t15_descrizione"

        CheckInsertOrEdit()

        blnFormLoaded = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CheckInsertOrEdit()
        ' Controllo se sono in modifica od inserimento
        If IDOrdine > 0 Then
            pnlArticoliOrdine.Enabled = True
            CaricaTestataOrdine()
            CaricaDatiOrdine()
            Me.Text = "Modifica Ordine di Acquisto " & txtCodiceOrdine.Text ' Nr. " & IDOrdine.ToString
            Me.btnNuovoOrdine.Text = "&Salva"
            blnVariazione = True
        Else
            Me.Text = "Nuovo Ordine di Acquisto " ' Nr. " & IDOrdine.ToString
            Me.btnNuovoOrdine.Text = "&Nuovo"
            blnVariazione = False
        End If
    End Sub

    Private Sub InitArticoliOrdine()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Me.txtDescrizioneOrdine.Text = ""
        Me.txtCodiceOrdine.Text = ""

        'dati inesistenti
        mstrSQL = "SELECT * FROM t09_righe_ordine_for INNER JOIN t08_testate_ordini_for "
        mstrSQL = mstrSQL & "ON t09_id_testata_ordine_for_t08 = t08_id_testata_ordine_for WHERE "
        mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = -9999 "
        mstrSQL = mstrSQL & " AND t09_dt_cancellazione IS NULL "
        mstrSQL = mstrSQL & "ORDER BY t09_posizione"

        objdsRigheOrdine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsRigheOrdine.Tables(0).TableName = "t09_righe_ordine_for"

        Me.DataGridArticoliOrdine.DataSource = objdsRigheOrdine
        Me.DataGridArticoliOrdine.DataMember = "t09_righe_ordine_for"
        Me.DataGridArticoliOrdine.TableStyles(0).MappingName = "t09_righe_ordine_for"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub AggiungiArticoli()

        Dim intIDRigoUpdate As Integer
        Dim intContatore As Integer = 0

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intRowCount As Integer
        Dim strCodArticolo() As String
        Dim intContatoreArticoliGiaPresenti As Integer = -1
        Dim strCodiceArticolo As String
        Dim strDescrizioneArticolo As String

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If DataViewArticoli.Count > 0 Then

            For intRowCount = 0 To DataViewArticoli.Count - 1

                'per ogni riga del datatable solo se articolo sezionato tenta l'aggiunta
                If DataGridArticoli.IsSelected(intRowCount) Then

                    'ID dell'articolo da aggiungere
                    mintIDArticolo = CType(DataGridArticoli.Item(intRowCount, 0), Integer)

                    'dati articolo
                    strCodiceArticolo = CType(DataGridArticoli.Item(intRowCount, 1), String)
                    strDescrizioneArticolo = CType(DataGridArticoli.Item(intRowCount, 2), String)

                    'controllo presenza articolo nell' ordine
                    If ArticoloGiaPresente(mintIDArticolo, IDOrdine) Then

                        intContatoreArticoliGiaPresenti = intContatoreArticoliGiaPresenti + 1
                        ReDim Preserve strCodArticolo(intContatoreArticoliGiaPresenti)
                        strCodArticolo(intContatoreArticoliGiaPresenti) = DataGridArticoli.Item(intRowCount, 1)

                    Else

                        'per ogni riga aggiorna la posizione
                        intContatore = 0
                        For Each dr As DataRow In objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows

                            intContatore = intContatore + 1
                            intIDRigoUpdate = dr("t09_id_riga_ordine_for")

                            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intContatore.ToString & " "
                            mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigoUpdate.ToString & " AND "
                            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString

                            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        Next

                        intContatore = intContatore + 1

                        ' Chiedi la QUANTITA ordinata
                        mstrMsg = "Inserire la quantità ordinata per l'articolo " & strCodiceArticolo.Trim & " - "
                        mstrMsg = mstrMsg & strDescrizioneArticolo.Trim & " :"
                        Dim strQtOrdinata As String = InputBox(mstrMsg, Me.Text, "0")

                        strQtOrdinata = Replace(strQtOrdinata, ",", ".")

                        'se non è numerico forza 0
                        If Not IsNumeric(strQtOrdinata) Then
                            strQtOrdinata = "0"
                        End If

                        '' Chiedi il PREZZO di ACQUISTO
                        'mstrMsg = "Inserire il prezzo d'acquisto unitario per l'articolo " & strCodiceArticolo.Trim & " - "
                        'mstrMsg = mstrMsg & strDescrizioneArticolo.Trim & " :"
                        Dim strPrezzoOrdinato As String = "0" 'InputBox(mstrMsg, Me.Text, "0")
                        'strPrezzoOrdinato = Replace(strPrezzoOrdinato, ",", ".")
                        'se non è numerico forza 0
                        If Not IsNumeric(strPrezzoOrdinato) Then
                            strPrezzoOrdinato = "0"
                        End If

                        ' Chiedi la DATA CONSEGNA
                        Dim dtDataConsegna As DateTime
                        'Dim FormCalendario As New frmCalendario
                        'FormCalendario.Messaggio = "Selezionare la data di consegna"
                        'FormCalendario.ShowDialog()
                        dtDataConsegna = dtConsegna.Value  'FormCalendario.Data


                        'Aggiunge una riga aperta
                        mstrSQL = "INSERT INTO t09_righe_ordine_for (t09_id_articolo_t20, t09_id_testata_ordine_for_t08, t09_posizione, t09_qt_ordinata, t09_prezzo_uni, t09_id_stato_riga_ordine_t10, t09_dt_consegna) VALUES ("
                        mstrSQL = mstrSQL & mintIDArticolo.ToString & ", " & IDOrdine.ToString & ", " & intContatore.ToString & ", " & strQtOrdinata & ", " & strPrezzoOrdinato & ",'A', '" & Format(dtDataConsegna, "yyyyMMdd") & "')"
                        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        'Tolgo tutti la quantità ordinata agli articoli figli
                        ' TODO: Verificare scaricamento corretto
                        ' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
                        mstrSQL = ""
                        mstrSQL += "UPDATE t20_articoli SET "
                        mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile - (" & strQtOrdinata & " * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
                        mstrSQL += "t20_dt_modifica = GetDate() WHERE "
                        mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " )"
                        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        Call CaricaDatiOrdine()

                    End If

                End If
            Next
        End If

        'default
        Cursor.Current = Cursors.Default

        'eventuale messaggio di notifica
        If Not (strCodArticolo Is Nothing) Then
            mstrMsg = "I seguenti articoli :" & vbCrLf & vbCrLf
            For intContatore = 0 To strCodArticolo.Length - 1
                mstrMsg = mstrMsg & strCodArticolo(intContatore) & vbCrLf
            Next
            mstrMsg = mstrMsg & vbCrLf & "sono già presenti nell'ordine! Eventualmente modificarne la quantità ordinata!"
            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub AggiungiGruppi()

        Dim intIDRigoUpdate As Integer
        Dim intContatore As Integer = 0

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intRowCount As Integer
        Dim strCodArticolo() As String
        Dim intContatoreArticoliGiaPresenti As Integer = -1
        Dim strCodiceArticolo As String
        Dim strDescrizioneArticolo As String

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If DataViewGruppi.Count > 0 Then

            For intRowCount = 0 To DataViewGruppi.Count - 1

                'per ogni riga del datatable solo se articolo sezionato tenta l'aggiunta
                If DataGridGruppi.IsSelected(intRowCount) Then

                    'ID dell'articolo da aggiungere
                    mintIDArticolo = CType(DataGridGruppi.Item(intRowCount, 0), Integer)

                    'dati articolo
                    strCodiceArticolo = CType(DataGridGruppi.Item(intRowCount, 1), String)
                    strDescrizioneArticolo = CType(DataGridGruppi.Item(intRowCount, 2), String)

                    'controllo presenza articolo nell' ordine
                    If ArticoloGiaPresente(mintIDArticolo, IDOrdine) Then

                        intContatoreArticoliGiaPresenti = intContatoreArticoliGiaPresenti + 1
                        ReDim Preserve strCodArticolo(intContatoreArticoliGiaPresenti)
                        strCodArticolo(intContatoreArticoliGiaPresenti) = DataGridGruppi.Item(intRowCount, 1)

                    Else

                        'per ogni riga aggiorna la posizione
                        intContatore = 0
                        For Each dr As DataRow In objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows

                            intContatore = intContatore + 1
                            intIDRigoUpdate = dr("t09_id_riga_ordine_for")

                            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intContatore.ToString & " "
                            mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigoUpdate.ToString & " AND "
                            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString

                            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        Next

                        intContatore = intContatore + 1

                        ' Chiedi la QUANTITA ordinata
                        mstrMsg = "Inserire la quantità ordinata per l'articolo " & strCodiceArticolo.Trim & " - "
                        mstrMsg = mstrMsg & strDescrizioneArticolo.Trim & " :"
                        Dim strQtOrdinata As String = InputBox(mstrMsg, Me.Text, "0")

                        strQtOrdinata = Replace(strQtOrdinata, ",", ".")

                        'se non è numerico forza 0
                        If Not IsNumeric(strQtOrdinata) Then
                            strQtOrdinata = "0"
                        End If

                        '' Chiedi il PREZZO di ACQUISTO
                        'mstrMsg = "Inserire il prezzo d'acquisto unitario per l'articolo " & strCodiceArticolo.Trim & " - "
                        'mstrMsg = mstrMsg & strDescrizioneArticolo.Trim & " :"
                        Dim strPrezzoOrdinato As String = "0" 'InputBox(mstrMsg, Me.Text, "0")
                        'strPrezzoOrdinato = Replace(strPrezzoOrdinato, ",", ".")
                        'se non è numerico forza 0
                        If Not IsNumeric(strPrezzoOrdinato) Then
                            strPrezzoOrdinato = "0"
                        End If

                        ' Chiedi la DATA CONSEGNA
                        Dim dtDataConsegna As DateTime
                        'Dim FormCalendario As New frmCalendario
                        'FormCalendario.Messaggio = "Selezionare la data di consegna"
                        'FormCalendario.ShowDialog()
                        dtDataConsegna = dtConsegna.Value  'FormCalendario.Data


                        'Aggiunge una riga aperta
                        mstrSQL = "INSERT INTO t09_righe_ordine_for (t09_id_articolo_t20, t09_id_testata_ordine_for_t08, t09_posizione, t09_qt_ordinata, t09_prezzo_uni, t09_id_stato_riga_ordine_t10, t09_dt_consegna) VALUES ("
                        mstrSQL = mstrSQL & mintIDArticolo.ToString & ", " & IDOrdine.ToString & ", " & intContatore.ToString & ", " & strQtOrdinata & ", " & strPrezzoOrdinato & ",'A', '" & Format(dtDataConsegna, "yyyyMMdd") & "')"
                        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        'Voglio costruire un GRUPPO quindi:
                        'scarico dal magazzino tutti gli articoli che compongo il gruppo
                        'e per ogni sotto-gruppo che compone il gruppo se il 
                        'sotto-gruppo è a magazzino lo scarico, altrimenti scarico gli
                        'articoli che compongono il sotto gruppo
                        ScaricaArticolieGruppiFigli(mintIDArticolo, CType(strQtOrdinata, Decimal))

                        Call CaricaDatiOrdine()

                    End If

                End If
            Next
        End If

        'default
        Cursor.Current = Cursors.Default

        'eventuale messaggio di notifica
        If Not (strCodArticolo Is Nothing) Then
            mstrMsg = "I seguenti articoli :" & vbCrLf & vbCrLf
            For intContatore = 0 To strCodArticolo.Length - 1
                mstrMsg = mstrMsg & strCodArticolo(intContatore) & vbCrLf
            Next
            mstrMsg = mstrMsg & vbCrLf & "sono già presenti nell'ordine! Eventualmente modificarne la quantità ordinata!"
            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ScaricaArticolieGruppiFigli(ByVal idArticolo As Integer, ByVal daordinare As Decimal)
        Dim ds As New GestioneProduzione2009DataSet
        Dim ta20 As New GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Dim ta22 As New GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
        ta20.Fill(ds.t20_articoli)
        ta22.Fill(ds.t22_articoli_articoli)

        RicorsioneScaricaArticolieGruppiFigli(idArticolo, daordinare, ds)

        ta20.Update(ds.t20_articoli)
    End Sub

    Private Sub RicorsioneScaricaArticolieGruppiFigli(ByVal idArticolo As Integer, ByVal daordinare As Decimal, ByRef ds As GestioneProduzione2009DataSet)
        'Dim daordinare As Decimal = CType(strQtOrdinata, Decimal)
        Dim amagazzino As Decimal = 0
        Dim impegnata As Decimal = 0

        If daordinare > 0 Then


            For Each padreFiglio As GestioneProduzione2009DataSet.t22_articoli_articoliRow In ds.t22_articoli_articoli.Rows
                If padreFiglio.t22_id_articolo_padre_t20 = idArticolo Then
                    Dim consumo As Decimal
                    consumo = padreFiglio.t22_consumo
                    Dim articoloFiglio As GestioneProduzione2009DataSet.t20_articoliRow
                    articoloFiglio = ds.t20_articoli.FindByt20_id_articolo(padreFiglio.t22_id_articolo_t20)

                    If articoloFiglio.t20_is_gruppo Then
                        daordinare = daordinare * consumo
                        amagazzino = articoloFiglio.t20_qt_disponibile

                        If amagazzino > 0 Then
                            'Ho disponibile a Magazzino questo gruppo
                            'e scarico la quantità disponibile a magazzino

                            If amagazzino >= daordinare Then
                                impegnata = daordinare
                                amagazzino = amagazzino - impegnata
                                daordinare = 0
                            Else
                                impegnata = amagazzino
                                amagazzino = 0
                                daordinare = daordinare - impegnata
                            End If

                            articoloFiglio.t20_qt_disponibile = amagazzino

                        End If

                        RicorsioneScaricaArticolieGruppiFigli(articoloFiglio.t20_id_articolo, daordinare, ds)
                    Else
                        articoloFiglio.t20_qt_disponibile = articoloFiglio.t20_qt_disponibile - (daordinare * consumo)
                    End If
                End If
            Next

        End If
    End Sub

    Private Function ArticoloGiaPresente(ByVal intIDArticolo As Integer, ByVal intIDOrdine As Integer) As Boolean

        mstrSQL = "SELECT * FROM t09_righe_ordine_for WHERE "
        mstrSQL = mstrSQL & "t09_id_articolo_t20 = " & intIDArticolo.ToString & " AND "
        mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & intIDOrdine.ToString & " AND "
        mstrSQL = mstrSQL & "t09_dt_cancellazione IS NULL"

        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub CaricaDatiOrdine()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'mstrSQL = ""
        'mstrSQL = mstrSQL & "SELECT * FROM t09_righe_ordine_for INNER JOIN t01_articoli "
        'mstrSQL = mstrSQL & " ON t09_id_articolo_t01 = t01_id_articolo "
        'mstrSQL = mstrSQL & " WHERE "
        'mstrSQL = mstrSQL & " t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " "
        'mstrSQL = mstrSQL & " AND t09_dt_cancellazione IS NULL "
        'mstrSQL = mstrSQL & " ORDER BY t09_posizione"
        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT * FROM t09_righe_ordine_for INNER JOIN t20_articoli "
        mstrSQL = mstrSQL & " ON t09_id_articolo_t20 = t20_id_articolo "
        mstrSQL = mstrSQL & " WHERE "
        mstrSQL = mstrSQL & " t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " "
        mstrSQL = mstrSQL & " AND t09_dt_cancellazione IS NULL "
        mstrSQL = mstrSQL & " ORDER BY t09_posizione"

        objdsRigheOrdine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsRigheOrdine.Tables(0).TableName = "t09_righe_ordine_for"

        Me.DataGridArticoliOrdine.DataSource = objdsRigheOrdine

        Me.DataGridArticoliOrdine.DataMember = "t09_righe_ordine_for"
        Me.DataGridArticoliOrdine.TableStyles(0).MappingName = "t09_righe_ordine_for"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub CaricaTestataOrdine()
        Dim dsTmp As DataSet

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT * FROM t08_testate_ordini_for "
        mstrSQL = mstrSQL & " WHERE "
        mstrSQL = mstrSQL & " t08_id_testata_ordine_for = " & IDOrdine.ToString & " "
        mstrSQL = mstrSQL & " AND t08_dt_cancellazione IS NULL "

        dsTmp = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        txtDescrizioneOrdine.Text = dsTmp.Tables(0).Rows(0)("t08_descrizione").ToString()
        txtCodiceOrdine.Text = dsTmp.Tables(0).Rows(0)("t08_cod_testata_ordine_for").ToString()
        txtTipoOrdine.Text = dsTmp.Tables(0).Rows(0)("t08_tipo_ordine").ToString()
        cmbFornitore.SelectedValue = dsTmp.Tables(0).Rows(0)("t08_id_fornitore_t11").ToString()
        cmbCausale.SelectedValue = dsTmp.Tables(0).Rows(0)("t08_id_causale_ordine_for_t15").ToString()
        If (dsTmp.Tables(0).Rows(0)("t08_dt_ordine").ToString() <> "") Then
            dtOrdine.Value = dsTmp.Tables(0).Rows(0)("t08_dt_ordine")
        Else
            dtOrdine.Checked = False
        End If
        If (dsTmp.Tables(0).Rows(0)("t08_dt_consegna").ToString() <> "") Then
            dtConsegna.Value = dsTmp.Tables(0).Rows(0)("t08_dt_consegna")
        Else
            dtConsegna.Checked = False
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnRemoveArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveArticolo.Click
        'Un articolo si può rimuovere da un ordine se e solo se il suo
        'stato è Aperto e la quantità evasa è pari a 0
        Call RimuoviArticoli()
    End Sub

    Private Sub RimuoviArticoli()

        'Un articolo si può rimuovere da un ordine se e solo se il suo
        'stato è Aperto e la quantità evasa è pari a 0
        If MessageBox.Show("Confermi rimozione articoli dall'ordine ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intIDRigoUpdate As Integer
        Dim intIDGruppoUpdate As Integer
        Dim intContatore As Integer = 0
        Dim intContatoreRigheDaRimuovere As Integer = -1
        Dim intRowCount As Integer
        Dim blnRimuovi As Boolean

        'vettore IDRiga da rimuovere dall'ordine
        Dim intIDRigheDaRimuovere() As Integer

        'vettore CodiciArticoli non cancellabili perchè evasi parzialmente o totalmente
        Dim strCodiciArticolo() As String
        Dim intContatoreCodiciArticolo As Integer = -1

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count > 0 Then

            For intRowCount = 0 To objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count - 1

                'determina ID da eliminare
                If DataGridArticoliOrdine.IsSelected(intRowCount) Then

                    If CType(objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(intRowCount)("t09_id_stato_riga_ordine_t10"), String) = "A" And CType(objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(intRowCount)("t09_qt_evasa"), Integer) = 0 Then
                        blnRimuovi = True
                    Else
                        blnRimuovi = False
                    End If

                    If blnRimuovi Then
                        intContatoreRigheDaRimuovere = intContatoreRigheDaRimuovere + 1
                        ReDim Preserve intIDRigheDaRimuovere(intContatoreRigheDaRimuovere)
                        intIDRigheDaRimuovere(intContatoreRigheDaRimuovere) = CType(objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(intRowCount)("t09_id_riga_ordine_for"), Integer)
                    Else
                        intContatoreCodiciArticolo = intContatoreCodiciArticolo + 1
                        ReDim Preserve strCodiciArticolo(intContatoreCodiciArticolo)
                        strCodiciArticolo(intContatoreCodiciArticolo) = CType(objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(intRowCount)("t20_cod_articolo"), String)
                    End If

                End If

            Next

            If Not (intIDRigheDaRimuovere Is Nothing) Then
                For intContatore = 0 To intIDRigheDaRimuovere.Length - 1

                    mstrSQL = ""
                    mstrSQL = "SELECT t09_qt_ordinata FROM t09_righe_ordine_for "
                    mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigheDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
                    Dim strQtOrdinata As String = ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL).ToString
                    strQtOrdinata = Replace(strQtOrdinata, ",", ".")

                    Dim intIDArticolo As Integer
                    'id dell'articolo da stornare
                    mstrSQL = ""
                    mstrSQL = "SELECT t09_id_articolo_t20 FROM t09_righe_ordine_for "
                    mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigheDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
                    intIDArticolo = Integer.Parse(ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL))

                    ' Storno
                    StornoQuantitaOrdinataAiFigliArticolo2(intIDArticolo, 0 - CType(strQtOrdinata.Replace(".", ","), Decimal))

                    'effettua cancellazione
                    mstrSQL = ""
                    mstrSQL = "DELETE FROM t09_righe_ordine_for "
                    mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigheDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                Next
            End If

            Call CaricaDatiOrdine()

            'rinumera posizioni per record rimasti nel gruppo
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows
                intContatore = intContatore + 1

                intIDRigoUpdate = dr("t09_id_riga_ordine_for")

                mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigoUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Next

            Call CaricaDatiOrdine()

            'eventuale messaggio di notifica
            If Not (strCodiciArticolo Is Nothing) Then
                mstrMsg = "I seguenti articoli :" & vbCrLf & vbCrLf
                For intContatore = 0 To strCodiciArticolo.Length - 1
                    mstrMsg = mstrMsg & strCodiciArticolo(intContatore) & vbCrLf
                Next
                mstrMsg = mstrMsg & vbCrLf & "non si possono rimuovere dall'ordine in quanto risultano parzialmente o totalmente evasi!"
                MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count > 0 Then
            DataGridArticoliOrdine.CurrentRowIndex = 0 'seleziona prima riga
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    'Private Sub StornoQuantitaOrdinataAiFigliArticolo(ByVal QtOrdinata As String, ByVal IDArticolo As Integer)
    '    'Storno la quantità ordinata agli articoli figli
    '    ' TODO: Verificare scaricamento corretto
    '    ' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
    '    Dim mstrSQL As String = ""
    '    mstrSQL += "UPDATE t20_articoli SET "
    '    mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile + (" & QtOrdinata & " * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & IDArticolo.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
    '    mstrSQL += "t20_dt_modifica = GetDate() WHERE "
    '    mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & IDArticolo.ToString & " )"
    '    ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)
    'End Sub

    Private Sub StornoQuantitaOrdinataAiFigliArticolo2(ByVal idArticolo As Integer, ByVal dastornare As Decimal)
        Dim ds As New GestioneProduzione2009DataSet
        Dim ta20 As New GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Dim ta22 As New GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
        ta20.Fill(ds.t20_articoli)
        ta22.Fill(ds.t22_articoli_articoli)

        RicorsioneStornoQuantitaOrdinataAiFigliArticolo2(idArticolo, dastornare, ds)

        ta20.Update(ds.t20_articoli)
    End Sub

    Private Sub RicorsioneStornoQuantitaOrdinataAiFigliArticolo2(ByVal idArticolo As Integer, ByVal dastornare As Decimal, ByRef ds As GestioneProduzione2009DataSet)
        'Dim daordinare As Decimal = CType(strQtOrdinata, Decimal)
        Dim amagazzino As Decimal = 0
        Dim impegnata As Decimal = 0

        If dastornare < 0 Then

            For Each padreFiglio As GestioneProduzione2009DataSet.t22_articoli_articoliRow In ds.t22_articoli_articoli.Rows
                If padreFiglio.t22_id_articolo_padre_t20 = idArticolo Then
                    Dim consumo As Decimal
                    consumo = padreFiglio.t22_consumo
                    Dim articoloFiglio As GestioneProduzione2009DataSet.t20_articoliRow
                    articoloFiglio = ds.t20_articoli.FindByt20_id_articolo(padreFiglio.t22_id_articolo_t20)

                    If articoloFiglio.t20_is_gruppo Then
                        dastornare = dastornare * consumo
                        'amagazzino = articoloFiglio.t20_qt_disponibile

                        'If amagazzino > 0 Then
                        '    'Ho disponibile a Magazzino questo gruppo
                        '    'e scarico la quantità disponibile a magazzino

                        '    If amagazzino >= QtOrdinata Then
                        '        impegnata = QtOrdinata
                        '        amagazzino = amagazzino - impegnata
                        '        QtOrdinata = 0
                        '    Else
                        '        impegnata = amagazzino
                        '        amagazzino = 0
                        '        QtOrdinata = QtOrdinata - impegnata
                        '    End If

                        '    articoloFiglio.t20_qt_disponibile = amagazzino
                        '    articoloFiglio.t20_dt_modifica = Date.Now

                        'End If

                        RicorsioneStornoQuantitaOrdinataAiFigliArticolo2(articoloFiglio.t20_id_articolo, dastornare, ds)
                    Else
                        articoloFiglio.t20_qt_disponibile = articoloFiglio.t20_qt_disponibile - (dastornare * consumo)
                        'articoloFiglio.t20_dt_modifica = Date.Now
                    End If
                End If
            Next

        End If
    End Sub



    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub RicalcolaPosizioniRigheOrdine()

        'Questa sub ricalcola il campo t09_posizione per evitare
        'problemi nello spostamento delle righe ordine
        Dim intContatore As Integer
        Dim intIDRigoUpdate As Integer

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count > 0 Then

            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows
                intContatore = intContatore + 1
                intIDRigoUpdate = dr("t09_id_riga_ordine_for")

                mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & intIDRigoUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
            Next

        End If
    End Sub

    Private Sub btnSpostaSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaSu.Click

        Dim intPosizione As Integer

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count <= 0 Then
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliOrdine.CurrentRowIndex + 1
        DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)

        If intPosizione > 1 Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t09_posizione = " & (intPosizione - 1).ToString & " AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = t09_posizione - 1 WHERE "
            mstrSQL = mstrSQL & "t09_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t09_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiOrdine()
            Call RicalcolaPosizioniRigheOrdine()
            DataGridArticoliOrdine.CurrentRowIndex = intPosizione - 2
            DataGridArticoliOrdine.Select(intPosizione - 2)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub btnSpostaGiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaGiu.Click

        Dim intPosizione As Integer

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count <= 0 Then
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliOrdine.CurrentRowIndex + 1
        DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)

        If intPosizione < objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count Then
            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t09_posizione = " & (intPosizione + 1).ToString & " AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = t09_posizione + 1 WHERE "
            mstrSQL = mstrSQL & "t09_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t09_righe_ordine_for SET t09_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t09_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiOrdine()
            Call RicalcolaPosizioniRigheOrdine()
            DataGridArticoliOrdine.CurrentRowIndex = intPosizione
            DataGridArticoliOrdine.Select(intPosizione)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub DataGridArticoliOrdine_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridArticoliOrdine.DoubleClick

        Dim intPosizione As Integer

        If IDOrdine = 0 Then
            MessageBox.Show("Scegliere prima un ordine valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows.Count > 0 Then

            DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)
            Dim strQuantitaOrdinata, strQuantitaOrdinataDefault, strPrezzoUnitario, strPrezzoUnitarioDefault As String
            strQuantitaOrdinataDefault = DataGridArticoliOrdine.Item(DataGridArticoliOrdine.CurrentRowIndex, 2)
            strPrezzoUnitarioDefault = DataGridArticoliOrdine.Item(DataGridArticoliOrdine.CurrentRowIndex, 4)
            intPosizione = DataGridArticoliOrdine.CurrentRowIndex

            'Se la riga risulta evasa è impossibile variarne la quantità ordinata!
            'Negli altri casi (totalmente aperto o parzialmente evaso) è possibile variarla
            If CType(objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(intPosizione)("t09_id_stato_riga_ordine_t10"), String) = "E" Then
                MessageBox.Show("Impossibile variare la quantità ordinata ad una riga ordine già evasa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            ' Modifica QUANTITA Articolo
            strQuantitaOrdinata = InputBox("Inserire la quantità ordinata per l'articolo selezionato :", Me.Text, strQuantitaOrdinataDefault)
            strQuantitaOrdinata = Replace(strQuantitaOrdinata, ",", ".")

            If strQuantitaOrdinata Is Nothing Then strQuantitaOrdinata = ""

            If strQuantitaOrdinata.Trim <> "" Then
                If Not IsNumeric(strQuantitaOrdinata.Trim) Then
                    MessageBox.Show("E' necessario indicare un valore numerico!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If CType(strQuantitaOrdinata.Trim, Integer) = 0 Then
                        MessageBox.Show("Impossibile inserire una quantità nulla!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    'clessidra
                    Cursor.Current = Cursors.WaitCursor

                    mstrSQL = ""
                    mstrSQL = "SELECT t09_qt_ordinata FROM t09_righe_ordine_for "
                    mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_riga_ordine_for").ToString & " AND "
                    mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
                    Dim strQtOrdinataOLD As String = ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL).ToString
                    strQtOrdinataOLD = Replace(strQtOrdinataOLD, ",", ".")


                    mstrSQL = "UPDATE t09_righe_ordine_for SET t09_qt_ordinata = " & strQuantitaOrdinata.Trim & ", "
                    mstrSQL = mstrSQL & "t09_dt_modifica = GetDate() "
                    mstrSQL = mstrSQL & "WHERE t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " AND "
                    mstrSQL = mstrSQL & "t09_id_riga_ordine_for = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_riga_ordine_for").ToString

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                    'Tolgo tutti la quantità ordinata agli articoli figli (QTANUOVA - QTAVECCHIA)
                    ' TODO: Verificare scaricamento corretto
                    ' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
                    Dim idArticoloRiga As Integer = objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_articolo_t20")
                    mstrSQL = ""
                    mstrSQL += "UPDATE t20_articoli SET "
                    mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile - ( (" & strQuantitaOrdinata & "-" & strQtOrdinataOLD & ") * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & idArticoloRiga.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
                    mstrSQL += "t20_dt_modifica = GetDate() WHERE "
                    mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_articolo_t20").ToString & " )"
                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)


                    Call CaricaDatiOrdine()
                    DataGridArticoliOrdine.CurrentRowIndex = intPosizione
                    DataGridArticoliOrdine.Select(intPosizione)

                    'default
                    Cursor.Current = Cursors.Default

                End If
            End If

            ' Modifica Data Consegna
            Dim dtDataConsegna As DateTime
            Dim FormCalendario As New frmCalendario

            ' Carico la data consegna del record prima della modifica
            mstrSQL = ""
            mstrSQL = "SELECT t09_dt_consegna FROM t09_righe_ordine_for "
            mstrSQL = mstrSQL & "WHERE t09_id_riga_ordine_for = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_riga_ordine_for").ToString & " AND "
            mstrSQL = mstrSQL & "t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString
            dtDataConsegna = Convert.ToDateTime(ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL).ToString())

            FormCalendario.Data = dtDataConsegna ' Visualizzo la data precedentemente selezionata
            FormCalendario.Messaggio = "Data di consegna"
            FormCalendario.ShowDialog()
            dtDataConsegna = FormCalendario.Data

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'mstrSQL = "SET DATEFORMAT ymd"
            mstrSQL = ""
            mstrSQL += "UPDATE t09_righe_ordine_for SET t09_dt_consegna = '" & Format(dtDataConsegna, "yyyyMMdd") & "', "
            mstrSQL += "t09_dt_modifica = GetDate() "
            mstrSQL += "WHERE t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " AND "
            mstrSQL += "t09_id_riga_ordine_for = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_riga_ordine_for").ToString

            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'default
            Cursor.Current = Cursors.Default



            '' Modifica PREZZO Articolo
            'strPrezzoUnitario = InputBox("Inserire il prezzo unitario per l'articolo selezionato :", Me.Text, strPrezzoUnitarioDefault)
            'strPrezzoUnitario = Replace(strPrezzoUnitario, ",", ".")

            'If strPrezzoUnitario Is Nothing Then strPrezzoUnitario = ""

            'If strPrezzoUnitario.Trim <> "" Then
            '    If Not IsNumeric(strPrezzoUnitario.Trim) Then
            '        MessageBox.Show("E' necessario indicare un valore numerico!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Else
            '        'If CType(strPrezzoUnitario.Trim, Integer) = 0 Then
            '        '    MessageBox.Show("Impossibile inserire una prezzo nulla!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '        '    Exit Sub
            '        'End If

            '        'clessidra
            '        Cursor.Current = Cursors.WaitCursor

            '        mstrSQL = "UPDATE t09_righe_ordine_for SET t09_prezzo_uni = " & strPrezzoUnitario.Trim & ", "
            '        mstrSQL = mstrSQL & "t09_dt_modifica = GetDate() "
            '        mstrSQL = mstrSQL & "WHERE t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " AND "
            '        mstrSQL = mstrSQL & "t09_id_riga_ordine_for = " & objdsRigheOrdine.Tables("t09_righe_ordine_for").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t09_id_riga_ordine_for").ToString

            '        ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)

            '        Call CaricaDatiOrdine()
            '        DataGridArticoliOrdine.CurrentRowIndex = intPosizione
            '        DataGridArticoliOrdine.Select(intPosizione)

            '        'default
            '        Cursor.Current = Cursors.Default

            '    End If
            'End If
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Call CaricaDatiOrdine()
        DataGridArticoliOrdine.CurrentRowIndex = intPosizione
        DataGridArticoliOrdine.Select(intPosizione)

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnNuovoOrdine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoOrdine.Click

        If blnVariazione = False Then   'Inserimento Ordini

            Dim strSQL As String
            Dim res As Integer
            Dim strMsg As String

            '' Controllo che sia stata inserita una descrizione per l'ordine
            'If txtDescrizioneOrdine.Text = String.Empty Then
            '    MessageBox.Show("Inserire una descrizione per l'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'strMsg = "Confermi creazione nuovo ordine avente la descrizione sottostante?" & vbCrLf & vbCrLf
            'strMsg += txtDescrizioneOrdine.Text()
            'If MessageBox.Show(strMsg, "Ordini Fornitore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
            '    Exit Sub
            'End If

            strMsg = "Confermi creazione del nuovo ordine avente il seguente numero ?" & vbCrLf & vbCrLf
            strMsg += txtCodiceOrdine.Text()
            If MessageBox.Show(strMsg, "Ordini Fornitore", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Exit Sub
            End If

            Dim intFornitore As Integer
            If Not IsNothing(cmbFornitore.SelectedValue) Then
                intFornitore = cmbFornitore.SelectedValue
            Else
                intFornitore = 1
            End If

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            strSQL = "SET DATEFORMAT ymd "
            strSQL += "INSERT INTO t08_testate_ordini_for"
            strSQL += " (t08_descrizione, t08_cod_testata_ordine_for, t08_id_fornitore_t11, t08_dt_ordine, t08_dt_consegna, t08_id_causale_ordine_for_t15, t08_tipo_ordine) "
            strSQL += String.Format("VALUES ('{0}','{1}',{2},{3},{4},{5}, '{6}')", txtDescrizioneOrdine.Text.Replace("'", "''"), txtCodiceOrdine.Text.Replace("'", "''"), intFornitore, "'" + Format(dtOrdine.Value, "yyyyMMdd") + "'", IIf(dtConsegna.Checked, "'" + Format(dtConsegna.Value, "yyyyMMdd") + "'", "NULL"), cmbCausale.SelectedValue, txtTipoOrdine.Text.Replace("'", "''"))
            strSQL += " SELECT @@IDENTITY"

            ' Inserisco la nuova Testata d' Ordine
            Try
                res = Integer.Parse(ExecuteScalar(conn1.ConnectionString, CommandType.Text, strSQL))
            Catch ex As Exception
                'default
                Cursor.Current = Cursors.Default
                MessageBox.Show("Errore: Impossibile creare l'ordine!" & vbCrLf & ex.Message)
                Exit Sub
            End Try

            ' Carico l'elenco dei righi d'ordine (evidentemente vuoto ma escono le intestazioni di colonna)
            IDOrdine = res
            pnlArticoliOrdine.Enabled = True
            Me.Text = "Inserimento Ordine Fornitore Nr. " & txtCodiceOrdine.Text 'IDOrdine.ToString

            CheckInsertOrEdit()

            CaricaDatiOrdine()

        Else    'Variazione di un ordine esistente

            'If Me.txtDescrizioneOrdine.Text.Trim = String.Empty Then
            '    MessageBox.Show("Inserire una descrizione per l'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'salva la descrizione dell'ordine e chiude la form
            mstrSQL = "SET DATEFORMAT ymd "
            mstrSQL += "UPDATE t08_testate_ordini_for SET "
            mstrSQL += "t08_descrizione = "
            mstrSQL += String.Format("'{0}'", txtDescrizioneOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t08_cod_testata_ordine_for = "
            mstrSQL += String.Format("'{0}'", txtCodiceOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t08_tipo_ordine = "
            mstrSQL += String.Format("'{0}'", txtTipoOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t08_id_fornitore_t11 = "
            mstrSQL += String.Format("'{0}'", cmbFornitore.SelectedValue)
            mstrSQL += ", t08_dt_ordine = "
            mstrSQL += String.Format("{0}", "'" + Format(dtOrdine.Value, "yyyyMMdd") + "'")
            mstrSQL += ", t08_dt_consegna = "
            mstrSQL += String.Format("{0}", IIf(dtConsegna.Checked, "'" + Format(dtConsegna.Value, "yyyyMMdd") + "'", "NULL"))
            mstrSQL += ", t08_id_causale_ordine_for_t15 = "
            mstrSQL += String.Format("'{0}'", cmbCausale.SelectedValue)
            mstrSQL += ", t08_dt_modifica = GetDate() WHERE t08_id_testata_ordine_for = " & IDOrdine.ToString

            Cursor.Current = Cursors.WaitCursor
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
            Cursor.Current = Cursors.Default
            Me.Close()

        End If

    End Sub

    Private Sub ApplicaFiltri(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged, txtRicercaDescrizione.TextChanged
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = Me.txtRicercaCodice.Text
        strFiltroDescrizione = Me.txtRicercaDescrizione.Text

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
        DataViewArticoli.RowFilter = strFiltro
        DataViewGruppi.RowFilter = strFiltro

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStampa.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-OrdineAcquisto.rpt")) ' = New OrdiniFor
        FormReport.reportDocumentSource.RecordSelectionFormula = "{viewTestateOrdiniConStato.t08_id_testata_ordine_for} = " & IDOrdine

        FormReport.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWord.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-OrdineAcquisto.rpt")) ' = New OrdiniFor
        FormReport.reportDocumentSource.RecordSelectionFormula = "{viewTestateOrdiniConStato.t08_id_testata_ordine_for} = " & IDOrdine

        Dim file As String
        file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Temp, "REDA-Ordine-" & txtCodiceOrdine.Text & ".doc")

        If FormReport.EsportaInWord(file, True) Then Process.Start(file)

    End Sub

    Private Sub pnlArticoliOrdine_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlArticoliOrdine.Paint

    End Sub

    Private Sub btnAddArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArticolo.Click
        ' Call AggiungiArticoli()

        ' Metodo un po' barbaro per verificare che i gruppi vengano aggiunti 
        ' soli ai conto lavorazione
        If (cmbCausale.SelectedIndex = 0) And TabControl1.SelectedIndex = 1 Then
            MessageBox.Show("E' possibile aggiungere gruppi solo agli ordini C/LAVORAZIONE!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.TabControl1.SelectedIndex = 0 Then
                Call AggiungiArticoli()
            Else
                Call AggiungiGruppi()
            End If
        End If
    End Sub

    Private Sub cmbCausale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausale.SelectedIndexChanged

        'Non posso selezionare C/LAVORAZIONE se ci sono Gruppi nell'Ordine
        If blnFormLoaded Then

            mstrSQL = ""
            mstrSQL += "SELECT COUNT(*) AS NUM "
            mstrSQL += "FROM t20_articoli "
            mstrSQL += "WHERE t20_id_articolo IN (SELECT t09_id_articolo_t20 FROM t09_righe_ordine_for WHERE t09_id_testata_ordine_for_t08 = " & IDOrdine.ToString & " ) "
            mstrSQL += "AND t20_is_gruppo = 1 "

            Dim res As Integer = ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL)

            If res > 0 Then
                MessageBox.Show("L'ordine contiene dei Gruppi, può essere solo di tipo C/LAVORAZIONE!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbCausale.SelectedIndex = 1
            End If

        End If
    End Sub

    Private Sub btnEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvadi.Click
        Cursor.Current = Cursors.WaitCursor

        'If elencoForm(frmEvasioneOrdini.GetType.Name) Is Nothing Then
        Dim FormEvasione As New frmEvasioneOrdini
        'FormEvasione.MdiParent = Me.Parent.Parent
        FormEvasione.m_IDOrdine = IDOrdine
        FormEvasione.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-OrdineAcquisto.rpt")) ' = New OrdiniFor
        FormReport.reportDocumentSource.RecordSelectionFormula = "{viewTestateOrdiniConStato.t08_id_testata_ordine_for} = " & IDOrdine

        Dim file As String
        file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Temp, "REDA-Ordine-" & txtCodiceOrdine.Text & ".pdf")

        If FormReport.EsportaInPDF(file, True) Then Process.Start(file)

    End Sub
End Class
