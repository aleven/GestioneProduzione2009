Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmOrdiniCli
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
    Friend WithEvents DataGridArticoli As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PrezzoUni As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodiceOrdine As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtOrdine As System.Windows.Forms.DateTimePicker
    Friend WithEvents objdsListaArticoli As GestioneProduzione.GestioneProduzione2009DataSet
    Friend WithEvents dtConsegna As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dav01_articoli As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents dat15_causali_ordini_for As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents objdsListaCausali As GestioneProduzione.GestioneProduzione2009DataSet
    Friend WithEvents btnStampa As System.Windows.Forms.Button
    Friend WithEvents DataConsegna As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtTipoOrdine As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dat14_clienti As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaClienti As GestioneProduzione.GestioneProduzione2009DataSet
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdiniCli))
        Me.lblDescrizioneOrdine = New System.Windows.Forms.Label
        Me.txtDescrizioneOrdine = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.dav01_articoli = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlArticoliOrdine = New System.Windows.Forms.Panel
        Me.lblRicercaDescrizione = New System.Windows.Forms.Label
        Me.lblRicercaCodice = New System.Windows.Forms.Label
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
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
        Me.cmbCliente = New System.Windows.Forms.ComboBox
        Me.dat14_clienti = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
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
        Me.btnStampa = New System.Windows.Forms.Button
        Me.btnNuovoOrdine = New System.Windows.Forms.Button
        Me.DataGridArticoli = New System.Windows.Forms.DataGrid
        Me.objdsListaArticoli = New GestioneProduzione.GestioneProduzione2009DataSet
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.btnRemoveArticolo = New System.Windows.Forms.Button
        Me.btnAddArticolo = New System.Windows.Forms.Button
        Me.objdsListaCausali = New GestioneProduzione.GestioneProduzione2009DataSet
        Me.objdsListaClienti = New GestioneProduzione.GestioneProduzione2009DataSet
        Me.pnlArticoliOrdine.SuspendLayout()
        CType(Me.DataGridArticoliOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaClienti, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dav01_articoli.InsertCommand = Me.SqlInsertCommand2
        Me.dav01_articoli.SelectCommand = Me.SqlSelectCommand2
        Me.dav01_articoli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v01_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.conn1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT t20_id_articolo, t20_cod_articolo, t20_descrizione, t20_prezzo, t20_qt_dis" & _
            "ponibile, t20_lotto_riordino, t20_is_gruppo, t20_dt_creazione, t20_dt_modifica, " & _
            "t20_dt_cancellazione FROM v01_articoli"
        Me.SqlSelectCommand2.Connection = Me.conn1
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(840, 544)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 4
        Me.btnChiudi.Text = "&Chiudi"
        '
        'pnlArticoliOrdine
        '
        Me.pnlArticoliOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlArticoliOrdine.Controls.Add(Me.DataGridArticoli)
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
        Me.QtaOrdinata.MappingName = "t13_qt_ordinata"
        Me.QtaOrdinata.NullText = "0"
        Me.QtaOrdinata.Width = 90
        '
        'QtaEvasa
        '
        Me.QtaEvasa.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtaEvasa.Format = "#####0.00"
        Me.QtaEvasa.FormatInfo = Nothing
        Me.QtaEvasa.HeaderText = "Q.tà Evasa"
        Me.QtaEvasa.MappingName = "t13_qt_evasa"
        Me.QtaEvasa.NullText = "0"
        Me.QtaEvasa.Width = 90
        '
        'PrezzoUni
        '
        Me.PrezzoUni.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrezzoUni.Format = "#####0.00"
        Me.PrezzoUni.FormatInfo = Nothing
        Me.PrezzoUni.HeaderText = "Prezzo Uni."
        Me.PrezzoUni.MappingName = "t13_prezzo_uni"
        Me.PrezzoUni.NullText = "0"
        Me.PrezzoUni.Width = 75
        '
        'StatoRiga
        '
        Me.StatoRiga.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.StatoRiga.Format = ""
        Me.StatoRiga.FormatInfo = Nothing
        Me.StatoRiga.HeaderText = "Stato"
        Me.StatoRiga.MappingName = "t13_id_stato_riga_ordine_t10"
        Me.StatoRiga.NullText = ""
        Me.StatoRiga.Width = 50
        '
        'DataConsegna
        '
        Me.DataConsegna.Format = "dd/MM/yyyy"
        Me.DataConsegna.FormatInfo = Nothing
        Me.DataConsegna.HeaderText = "Data Consegna"
        Me.DataConsegna.MappingName = "t13_dt_consegna"
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
        Me.Label2.Text = "Cliente :"
        '
        'cmbCliente
        '
        Me.cmbCliente.Location = New System.Drawing.Point(128, 96)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(240, 21)
        Me.cmbCliente.TabIndex = 2
        '
        'dat14_clienti
        '
        Me.dat14_clienti.DeleteCommand = Me.SqlDeleteCommand1
        Me.dat14_clienti.InsertCommand = Me.SqlInsertCommand1
        Me.dat14_clienti.SelectCommand = Me.SqlSelectCommand1
        Me.dat14_clienti.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t14_clienti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t14_id_cliente", "t14_id_cliente"), New System.Data.Common.DataColumnMapping("t14_cod_cliente", "t14_cod_cliente"), New System.Data.Common.DataColumnMapping("t14_descrizione", "t14_descrizione"), New System.Data.Common.DataColumnMapping("t14_telefono", "t14_telefono"), New System.Data.Common.DataColumnMapping("t14_note", "t14_note"), New System.Data.Common.DataColumnMapping("t14_dt_creazione", "t14_dt_creazione"), New System.Data.Common.DataColumnMapping("t14_dt_modifica", "t14_dt_modifica"), New System.Data.Common.DataColumnMapping("t14_dt_cancellazione", "t14_dt_cancellazione")})})
        Me.dat14_clienti.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.conn1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t14_id_cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_id_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_cod_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_telefono", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.conn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, "t14_cod_cliente"), New System.Data.SqlClient.SqlParameter("@t14_descrizione", System.Data.SqlDbType.VarChar, 255, "t14_descrizione"), New System.Data.SqlClient.SqlParameter("@t14_telefono", System.Data.SqlDbType.VarChar, 20, "t14_telefono"), New System.Data.SqlClient.SqlParameter("@t14_note", System.Data.SqlDbType.VarChar, 2147483647, "t14_note"), New System.Data.SqlClient.SqlParameter("@t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t14_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_cancellazione")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT t14_id_cliente, t14_cod_cliente, t14_descrizione, t14_telefono, t14_note, " & _
            "t14_dt_creazione, t14_dt_modifica, t14_dt_cancellazione FROM t14_clienti"
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.conn1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, "t14_cod_cliente"), New System.Data.SqlClient.SqlParameter("@t14_descrizione", System.Data.SqlDbType.VarChar, 255, "t14_descrizione"), New System.Data.SqlClient.SqlParameter("@t14_telefono", System.Data.SqlDbType.VarChar, 20, "t14_telefono"), New System.Data.SqlClient.SqlParameter("@t14_note", System.Data.SqlDbType.VarChar, 2147483647, "t14_note"), New System.Data.SqlClient.SqlParameter("@t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t14_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t14_id_cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_id_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_cod_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t14_id_cliente", System.Data.SqlDbType.Int, 4, "t14_id_cliente")})
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
        Me.cmbCausale.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(384, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Causale :"
        Me.Label5.Visible = False
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
        Me.SqlSelectCommand3.CommandText = "SELECT t15_id_causale_ordine_for, t15_cod_causale_ordine_for, t15_descrizione, t1" & _
            "5_tipo_azione, t15_dt_creazione, t15_dt_modifica, t15_dt_cancellazione FROM t15_" & _
            "causali_ordini_for"
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
        Me.ToolTip1.SetToolTip(Me.btnNuovoOrdine, "Nuovo gruppo")
        '
        'DataGridArticoli
        '
        Me.DataGridArticoli.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridArticoli.CaptionText = "Ricambi Disponibili"
        Me.DataGridArticoli.DataMember = "v01_articoli"
        Me.DataGridArticoli.DataSource = Me.objdsListaArticoli
        Me.DataGridArticoli.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridArticoli.Location = New System.Drawing.Point(8, 72)
        Me.DataGridArticoli.Name = "DataGridArticoli"
        Me.DataGridArticoli.ReadOnly = True
        Me.DataGridArticoli.Size = New System.Drawing.Size(264, 288)
        Me.DataGridArticoli.TabIndex = 2
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
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle2.DataGrid = Me.DataGridArticoli
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "v01_articoli"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID Articolo"
        Me.DataGridTextBoxColumn1.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn1.NullText = "0"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Codice"
        Me.DataGridTextBoxColumn2.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn3.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 200
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
        Me.btnAddArticolo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddArticolo.Image = CType(resources.GetObject("btnAddArticolo.Image"), System.Drawing.Image)
        Me.btnAddArticolo.Location = New System.Drawing.Point(280, 104)
        Me.btnAddArticolo.Name = "btnAddArticolo"
        Me.btnAddArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnAddArticolo.TabIndex = 3
        '
        'objdsListaCausali
        '
        Me.objdsListaCausali.DataSetName = "dsListaCausali"
        Me.objdsListaCausali.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaCausali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'objdsListaClienti
        '
        Me.objdsListaClienti.DataSetName = "dsClienti"
        Me.objdsListaClienti.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaClienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmOrdiniCli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(984, 590)
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
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuovoOrdine)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.lblDescrizioneOrdine)
        Me.Controls.Add(Me.pnlArticoliOrdine)
        Me.Controls.Add(Me.Label6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOrdiniCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordini Vendita"
        Me.pnlArticoliOrdine.ResumeLayout(False)
        Me.pnlArticoliOrdine.PerformLayout()
        CType(Me.DataGridArticoliOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaClienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmOrdiniCli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        ' Caricamento elenco Articoli
        dav01_articoli.Fill(objdsListaArticoli)
        DataViewArticoli = objdsListaArticoli.v01_articoli.DefaultView
        DataGridArticoli.DataSource = DataViewArticoli

        ' Caricamento elenco Fornitori
        dat14_clienti.Fill(objdsListaClienti)
        DataViewFornitori = objdsListaClienti.t14_clienti.DefaultView()
        DataViewFornitori.Sort = "t14_descrizione asc"
        cmbCliente.DataSource = DataViewFornitori
        cmbCliente.ValueMember = "t14_id_cliente"
        cmbCliente.DisplayMember = "t14_descrizione"

        '' Caricamento elenco Causali
        'dat15_causali_ordini_for.Fill(objdsListaCausali)
        'DataViewCausali = objdsListaCausali.t15_causali_ordini_for.DefaultView()
        'DataViewCausali.Sort = "t15_descrizione asc"
        'cmbCausale.DataSource = DataViewCausali
        'cmbCausale.ValueMember = "t15_id_causale_ordine_cli"
        'cmbCausale.DisplayMember = "t15_descrizione"

        ' Controllo se sono in modifica od inserimento
        If IDOrdine > 0 Then
            pnlArticoliOrdine.Enabled = True
            CaricaTestataOrdine()
            CaricaDatiOrdine()
            Me.Text = "Modifica Ordine di Vendita " & txtCodiceOrdine.Text ' Nr. " & IDOrdine.ToString
            Me.btnNuovoOrdine.Text = "&Salva"
            blnVariazione = True
        Else
            Me.Text = "Nuovo Ordine di Vendita " ' Nr. " & IDOrdine.ToString
            Me.btnNuovoOrdine.Text = "&Nuovo"
            blnVariazione = False
        End If

        blnFormLoaded = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InitArticoliOrdine()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Me.txtDescrizioneOrdine.Text = ""
        Me.txtCodiceOrdine.Text = ""

        'dati inesistenti
        mstrSQL = "SELECT * FROM t13_righe_ordine_cli INNER JOIN t12_testate_ordini_cli "
        mstrSQL = mstrSQL & "ON t13_id_testata_ordine_cli_t12 = t12_id_testata_ordine_cli WHERE "
        mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = -9999 "
        mstrSQL = mstrSQL & " AND t13_dt_cancellazione IS NULL "
        mstrSQL = mstrSQL & "ORDER BY t13_posizione"

        objdsRigheOrdine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsRigheOrdine.Tables(0).TableName = "t13_righe_ordine_cli"

        Me.DataGridArticoliOrdine.DataSource = objdsRigheOrdine
        Me.DataGridArticoliOrdine.DataMember = "t13_righe_ordine_cli"
        Me.DataGridArticoliOrdine.TableStyles(0).MappingName = "t13_righe_ordine_cli"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnAddArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArticolo.Click, DataGridArticoli.DoubleClick
        Call AggiungiArticoli()
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
                        For Each dr As DataRow In objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows

                            intContatore = intContatore + 1
                            intIDRigoUpdate = dr("t13_id_riga_ordine_cli")

                            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = " & intContatore.ToString & " "
                            mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & intIDRigoUpdate.ToString & " AND "
                            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString

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
                        mstrSQL = "INSERT INTO t13_righe_ordine_cli (t13_id_articolo_t20, t13_id_testata_ordine_cli_t12, t13_posizione, t13_qt_ordinata, t13_prezzo_uni, t13_id_stato_riga_ordine_t10, t13_dt_consegna) VALUES ("
                        mstrSQL = mstrSQL & mintIDArticolo.ToString & ", " & IDOrdine.ToString & ", " & intContatore.ToString & ", " & strQtOrdinata & ", " & strPrezzoOrdinato & ",'A', '" & Format(dtDataConsegna, "yyyyMMdd") & "')"
                        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        ''Tolgo tutti la quantità ordinata agli articoli figli
                        '' TODO: Verificare scaricamento corretto
                        '' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
                        'mstrSQL = ""
                        'mstrSQL += "UPDATE t20_articoli SET "
                        'mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile - (" & strQtOrdinata & " * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
                        'mstrSQL += "t20_dt_modifica = GetDate() WHERE "
                        'mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " )"
                        'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)

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

    Private Function ArticoloGiaPresente(ByVal intIDArticolo As Integer, ByVal intIDOrdine As Integer) As Boolean

        mstrSQL = "SELECT * FROM t13_righe_ordine_cli WHERE "
        mstrSQL = mstrSQL & "t13_id_articolo_t20 = " & intIDArticolo.ToString & " AND "
        mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & intIDOrdine.ToString & " AND "
        mstrSQL = mstrSQL & "t13_dt_cancellazione IS NULL"

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
        'mstrSQL = mstrSQL & "SELECT * FROM t13_righe_ordine_cli INNER JOIN t01_articoli "
        'mstrSQL = mstrSQL & " ON t13_id_articolo_t01 = t01_id_articolo "
        'mstrSQL = mstrSQL & " WHERE "
        'mstrSQL = mstrSQL & " t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString & " "
        'mstrSQL = mstrSQL & " AND t13_dt_cancellazione IS NULL "
        'mstrSQL = mstrSQL & " ORDER BY t13_posizione"
        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT * FROM t13_righe_ordine_cli INNER JOIN t20_articoli "
        mstrSQL = mstrSQL & " ON t13_id_articolo_t20 = t20_id_articolo "
        mstrSQL = mstrSQL & " WHERE "
        mstrSQL = mstrSQL & " t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString & " "
        mstrSQL = mstrSQL & " AND t13_dt_cancellazione IS NULL "
        mstrSQL = mstrSQL & " ORDER BY t13_posizione"

        objdsRigheOrdine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsRigheOrdine.Tables(0).TableName = "t13_righe_ordine_cli"

        Me.DataGridArticoliOrdine.DataSource = objdsRigheOrdine

        Me.DataGridArticoliOrdine.DataMember = "t13_righe_ordine_cli"
        Me.DataGridArticoliOrdine.TableStyles(0).MappingName = "t13_righe_ordine_cli"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub CaricaTestataOrdine()
        Dim dsTmp As DataSet

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT * FROM t12_testate_ordini_cli "
        mstrSQL = mstrSQL & " WHERE "
        mstrSQL = mstrSQL & " t12_id_testata_ordine_cli = " & IDOrdine.ToString & " "
        mstrSQL = mstrSQL & " AND t12_dt_cancellazione IS NULL "

        dsTmp = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        txtDescrizioneOrdine.Text = dsTmp.Tables(0).Rows(0)("t12_descrizione").ToString()
        txtCodiceOrdine.Text = dsTmp.Tables(0).Rows(0)("t12_cod_testata_ordine_cli").ToString()
        txtTipoOrdine.Text = dsTmp.Tables(0).Rows(0)("t12_tipo_ordine").ToString()
        cmbCliente.SelectedValue = dsTmp.Tables(0).Rows(0)("t12_id_cliente_t14").ToString()
        If (dsTmp.Tables(0).Rows(0)("t12_dt_ordine").ToString() <> "") Then
            dtOrdine.Value = dsTmp.Tables(0).Rows(0)("t12_dt_ordine")
        Else
            dtOrdine.Checked = False
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

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count > 0 Then

            For intRowCount = 0 To objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count - 1

                'determina ID da eliminare
                If DataGridArticoliOrdine.IsSelected(intRowCount) Then

                    If CType(objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(intRowCount)("t13_id_stato_riga_ordine_t10"), String) = "A" And CType(objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(intRowCount)("t13_qt_evasa"), Integer) = 0 Then
                        blnRimuovi = True
                    Else
                        blnRimuovi = False
                    End If

                    If blnRimuovi Then
                        intContatoreRigheDaRimuovere = intContatoreRigheDaRimuovere + 1
                        ReDim Preserve intIDRigheDaRimuovere(intContatoreRigheDaRimuovere)
                        intIDRigheDaRimuovere(intContatoreRigheDaRimuovere) = CType(objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(intRowCount)("t13_id_riga_ordine_cli"), Integer)
                    Else
                        intContatoreCodiciArticolo = intContatoreCodiciArticolo + 1
                        ReDim Preserve strCodiciArticolo(intContatoreCodiciArticolo)
                        strCodiciArticolo(intContatoreCodiciArticolo) = CType(objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(intRowCount)("t20_cod_articolo"), String)
                    End If

                End If

            Next

            If Not (intIDRigheDaRimuovere Is Nothing) Then
                For intContatore = 0 To intIDRigheDaRimuovere.Length - 1

                    mstrSQL = ""
                    mstrSQL = "SELECT t13_qt_ordinata FROM t13_righe_ordine_cli "
                    mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & intIDRigheDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
                    Dim strQtOrdinata As String = ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL).ToString
                    strQtOrdinata = Replace(strQtOrdinata, ",", ".")

                    'effettua cancellazione
                    mstrSQL = ""
                    mstrSQL = "DELETE FROM t13_righe_ordine_cli "
                    mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & intIDRigheDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                    ' Storno
                    StornoQuantitaOrdinataAiFigliArticolo(strQtOrdinata, mintIDArticolo)

                Next
            End If

            Call CaricaDatiOrdine()

            'rinumera posizioni per record rimasti nel gruppo
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows
                intContatore = intContatore + 1

                intIDRigoUpdate = dr("t13_id_riga_ordine_cli")

                mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & intIDRigoUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString

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

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count > 0 Then
            DataGridArticoliOrdine.CurrentRowIndex = 0 'seleziona prima riga
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub StornoQuantitaOrdinataAiFigliArticolo(ByVal QtOrdinata As String, ByVal IDArticolo As Integer)
        'Storno la quantità ordinata agli articoli figli
        ' TODO: Verificare scaricamento corretto
        ' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
        Dim mstrSQL As String = ""
        mstrSQL += "UPDATE t20_articoli SET "
        mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile + (" & QtOrdinata & " * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
        mstrSQL += "t20_dt_modifica = GetDate() WHERE "
        mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & IDArticolo.ToString & " )"
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
    End Sub


    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub RicalcolaPosizioniRigheOrdine()

        'Questa sub ricalcola il campo t13_posizione per evitare
        'problemi nello spostamento delle righe ordine
        Dim intContatore As Integer
        Dim intIDRigoUpdate As Integer

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count > 0 Then

            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows
                intContatore = intContatore + 1
                intIDRigoUpdate = dr("t13_id_riga_ordine_cli")

                mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & intIDRigoUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString

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

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count <= 0 Then
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliOrdine.CurrentRowIndex + 1
        DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)

        If intPosizione > 1 Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t13_posizione = " & (intPosizione - 1).ToString & " AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = t13_posizione - 1 WHERE "
            mstrSQL = mstrSQL & "t13_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t13_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
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

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count <= 0 Then
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliOrdine.CurrentRowIndex + 1
        DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)

        If intPosizione < objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count Then
            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t13_posizione = " & (intPosizione + 1).ToString & " AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = t13_posizione + 1 WHERE "
            mstrSQL = mstrSQL & "t13_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t13_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
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

        If objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows.Count > 0 Then

            DataGridArticoliOrdine.Select(DataGridArticoliOrdine.CurrentRowIndex)
            Dim strQuantitaOrdinata, strQuantitaOrdinataDefault, strPrezzoUnitario, strPrezzoUnitarioDefault As String
            strQuantitaOrdinataDefault = DataGridArticoliOrdine.Item(DataGridArticoliOrdine.CurrentRowIndex, 2)
            strPrezzoUnitarioDefault = DataGridArticoliOrdine.Item(DataGridArticoliOrdine.CurrentRowIndex, 4)
            intPosizione = DataGridArticoliOrdine.CurrentRowIndex

            'Se la riga risulta evasa è impossibile variarne la quantità ordinata!
            'Negli altri casi (totalmente aperto o parzialmente evaso) è possibile variarla
            If CType(objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(intPosizione)("t13_id_stato_riga_ordine_t10"), String) = "E" Then
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
                    mstrSQL = "SELECT t13_qt_ordinata FROM t13_righe_ordine_cli "
                    mstrSQL = mstrSQL & "WHERE t13_id_riga_ordine_cli = " & objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t13_id_riga_ordine_cli").ToString & " AND "
                    mstrSQL = mstrSQL & "t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString
                    Dim strQtOrdinataOLD As String = ExecuteScalar(conn1.ConnectionString, CommandType.Text, mstrSQL).ToString
                    strQtOrdinataOLD = Replace(strQtOrdinataOLD, ",", ".")


                    mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_qt_ordinata = " & strQuantitaOrdinata.Trim & ", "
                    mstrSQL = mstrSQL & "t13_dt_modifica = GetDate() "
                    mstrSQL = mstrSQL & "WHERE t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString & " AND "
                    mstrSQL = mstrSQL & "t13_id_riga_ordine_cli = " & objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t13_id_riga_ordine_cli").ToString

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                    'Tolgo tutti la quantità ordinata agli articoli figli (QTANUOVA - QTAVECCHIA)
                    ' TODO: Verificare scaricamento corretto
                    ' Aggiunta da Mirco per gestire gli Articoli in ContoLavorazione (sottraggo dai figli la quantità ordinata * il consumo)
                    mstrSQL = ""
                    mstrSQL += "UPDATE t20_articoli SET "
                    mstrSQL += "t20_articoli.t20_qt_disponibile = t20_articoli.t20_qt_disponibile - ( (" & strQuantitaOrdinata & "-" & strQtOrdinataOLD & ") * (SELECT t22_consumo FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & mintIDArticolo.ToString & " AND t22_id_articolo_t20 = t20_id_articolo) ), "
                    mstrSQL += "t20_dt_modifica = GetDate() WHERE "
                    mstrSQL += "t20_id_articolo IN ( SELECT t22_id_articolo_t20 FROM t22_articoli_articoli WHERE t22_id_articolo_padre_t20 = " & objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t13_id_articolo_t20").ToString & " )"
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
            FormCalendario.Messaggio = "Data di consegna"
            FormCalendario.ShowDialog()

            dtDataConsegna = FormCalendario.Data

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'mstrSQL = "SET DATEFORMAT ymd"
            mstrSQL = ""
            mstrSQL += "UPDATE t13_righe_ordine_cli SET t13_dt_consegna = '" & Format(dtDataConsegna, "yyyyMMdd") & "', "
            mstrSQL += "t13_dt_modifica = GetDate() "
            mstrSQL += "WHERE t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString & " AND "
            mstrSQL += "t13_id_riga_ordine_cli = " & objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t13_id_riga_ordine_cli").ToString

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

            '        mstrSQL = "UPDATE t13_righe_ordine_cli SET t13_prezzo_uni = " & strPrezzoUnitario.Trim & ", "
            '        mstrSQL = mstrSQL & "t13_dt_modifica = GetDate() "
            '        mstrSQL = mstrSQL & "WHERE t13_id_testata_ordine_cli_t12 = " & IDOrdine.ToString & " AND "
            '        mstrSQL = mstrSQL & "t13_id_riga_ordine_cli = " & objdsRigheOrdine.Tables("t13_righe_ordine_cli").Rows(DataGridArticoliOrdine.CurrentRowIndex).Item("t13_id_riga_ordine_cli").ToString

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

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            strSQL = "SET DATEFORMAT ymd "
            strSQL += "INSERT INTO t12_testate_ordini_cli"
            strSQL += " (t12_descrizione, t12_cod_testata_ordine_cli, t12_id_cliente_t14, t12_dt_ordine, t12_dt_consegna, t12_tipo_ordine) "
            strSQL += String.Format("VALUES ('{0}','{1}',{2},{3},{4},'{5}')", txtDescrizioneOrdine.Text.Replace("'", "''"), txtCodiceOrdine.Text.Replace("'", "''"), cmbCliente.SelectedValue, "'" + Format(dtOrdine.Value, "yyyyMMdd") + "'", IIf(dtConsegna.Checked, "'" + Format(dtConsegna.Value, "yyyyMMdd") + "'", "NULL"), txtTipoOrdine.Text.Replace("'", "''"))
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
            Me.Text = "Inserimento Ordine Cliente Nr. " & txtCodiceOrdine.Text 'IDOrdine.ToString
            CaricaDatiOrdine()

        Else    'Variazione di un ordine esistente

            'If Me.txtDescrizioneOrdine.Text.Trim = String.Empty Then
            '    MessageBox.Show("Inserire una descrizione per l'ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If

            'salva la descrizione dell'ordine e chiude la form
            mstrSQL = "SET DATEFORMAT ymd "
            mstrSQL += "UPDATE t12_testate_ordini_cli SET "
            mstrSQL += "t12_descrizione = "
            mstrSQL += String.Format("'{0}'", txtDescrizioneOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t12_cod_testata_ordine_cli = "
            mstrSQL += String.Format("'{0}'", txtCodiceOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t12_tipo_ordine = "
            mstrSQL += String.Format("'{0}'", txtTipoOrdine.Text.Replace("'", "''"))
            mstrSQL += ", t12_id_cliente_t14 = "
            mstrSQL += String.Format("'{0}'", cmbCliente.SelectedValue)
            mstrSQL += ", t12_dt_ordine = "
            mstrSQL += String.Format("{0}", "'" + Format(dtOrdine.Value, "yyyyMMdd") + "'")
            mstrSQL += ", t12_dt_consegna = "
            mstrSQL += String.Format("{0}", "'" + Format(dtConsegna.Value, "yyyyMMdd") + "'")
            mstrSQL += ", t12_dt_modifica = GetDate() WHERE t12_id_testata_ordine_cli = " & IDOrdine.ToString

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

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStampa.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        'FormReport.reportDocumentSource.Load("TEMAC-OrdiniFor.rpt") ' = New OrdiniFor
        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-OrdineVendita.rpt"))
        FormReport.reportDocumentSource.RecordSelectionFormula = "{viewTestateOrdiniConStato.t12_id_testata_ordine_cli} = " & IDOrdine

        FormReport.Show()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
