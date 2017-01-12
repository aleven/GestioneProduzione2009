Imports Microsoft.ApplicationBlocks.Data.SqlHelper
Imports GestioneProduzione2014GinuxImport

Public Class frmConfiguratoreMacchine
    Inherits System.Windows.Forms.Form

    Private mintIDMacchina As Integer 'IDMacchina correttemente editato
    Private mintIDGruppo As Integer 'IDGruppo per spostamento su macchina
    Private mstrSQL As String
    Private objdsGruppiMacchine As DataSet
    Private mstrMsg As String
    Private DataViewGruppi As DataView
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Private blnFormLoaded As Boolean = False

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btnSpostaSu As System.Windows.Forms.Button
    Friend WithEvents btnSpostaGiu As System.Windows.Forms.Button
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents lblRicercaCodice As System.Windows.Forms.Label
    Friend WithEvents lblRicercaDescrizione As System.Windows.Forms.Label
    Friend WithEvents lblCodMacchina As System.Windows.Forms.Label
    Friend WithEvents btnSceltaMacchina As System.Windows.Forms.Button
    Friend WithEvents txtCodMacchina As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrizioneMacchina As System.Windows.Forms.TextBox
    Friend WithEvents DataGridGruppiMacchine As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridGruppi As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle_Gruppi_Disponibili As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn_IDGruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_CodGruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_Descrizione_Gruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnAddGruppo As System.Windows.Forms.Button
    Friend WithEvents btnRemoveGruppo As System.Windows.Forms.Button
    Friend WithEvents DataGridComposizioneGruppo As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnModificaMacchina As System.Windows.Forms.Button
    Friend WithEvents btnEliminaMacchina As System.Windows.Forms.Button
    Friend WithEvents btnNuovaMacchina As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaGruppi As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents btnStampa As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguratoreMacchine))
        Me.lblCodMacchina = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSceltaMacchina = New System.Windows.Forms.Button
        Me.txtCodMacchina = New System.Windows.Forms.TextBox
        Me.txtDescrizioneMacchina = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.DataGridGruppiMacchine = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnAddGruppo = New System.Windows.Forms.Button
        Me.btnRemoveGruppo = New System.Windows.Forms.Button
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.lblRicercaCodice = New System.Windows.Forms.Label
        Me.lblRicercaDescrizione = New System.Windows.Forms.Label
        Me.DataGridGruppi = New System.Windows.Forms.DataGrid
        Me.objdsListaGruppi = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle_Gruppi_Disponibili = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn_IDGruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_CodGruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_Descrizione_Gruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridComposizioneGruppo = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnModificaMacchina = New System.Windows.Forms.Button
        Me.btnEliminaMacchina = New System.Windows.Forms.Button
        Me.btnNuovaMacchina = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnStampa = New System.Windows.Forms.Button
        Me.btnChiudi = New System.Windows.Forms.Button
        CType(Me.DataGridGruppiMacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridComposizioneGruppo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodMacchina
        '
        Me.lblCodMacchina.Location = New System.Drawing.Point(8, 16)
        Me.lblCodMacchina.Name = "lblCodMacchina"
        Me.lblCodMacchina.Size = New System.Drawing.Size(104, 16)
        Me.lblCodMacchina.TabIndex = 0
        Me.lblCodMacchina.Text = "Codice Macchina :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descrizione Macchina :"
        '
        'btnSceltaMacchina
        '
        Me.btnSceltaMacchina.Image = CType(resources.GetObject("btnSceltaMacchina.Image"), System.Drawing.Image)
        Me.btnSceltaMacchina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSceltaMacchina.Location = New System.Drawing.Point(320, 8)
        Me.btnSceltaMacchina.Name = "btnSceltaMacchina"
        Me.btnSceltaMacchina.Size = New System.Drawing.Size(96, 32)
        Me.btnSceltaMacchina.TabIndex = 2
        Me.btnSceltaMacchina.Text = "Seleziona"
        Me.ToolTip1.SetToolTip(Me.btnSceltaMacchina, "Ricerca e selezione macchina")
        '
        'txtCodMacchina
        '
        Me.txtCodMacchina.Location = New System.Drawing.Point(128, 16)
        Me.txtCodMacchina.Name = "txtCodMacchina"
        Me.txtCodMacchina.ReadOnly = True
        Me.txtCodMacchina.Size = New System.Drawing.Size(184, 20)
        Me.txtCodMacchina.TabIndex = 1
        Me.txtCodMacchina.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtCodMacchina, "Codice Macchina (F9=Ricerca, F10=Nuova)")
        '
        'txtDescrizioneMacchina
        '
        Me.txtDescrizioneMacchina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizioneMacchina.Location = New System.Drawing.Point(128, 48)
        Me.txtDescrizioneMacchina.Multiline = True
        Me.txtDescrizioneMacchina.Name = "txtDescrizioneMacchina"
        Me.txtDescrizioneMacchina.ReadOnly = True
        Me.txtDescrizioneMacchina.Size = New System.Drawing.Size(744, 48)
        Me.txtDescrizioneMacchina.TabIndex = 7
        Me.txtDescrizioneMacchina.TabStop = False
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'DataGridGruppiMacchine
        '
        Me.DataGridGruppiMacchine.AllowSorting = False
        Me.DataGridGruppiMacchine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridGruppiMacchine.CaptionText = "Gruppi Appartenenti Alla Macchina"
        Me.DataGridGruppiMacchine.DataMember = ""
        Me.DataGridGruppiMacchine.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridGruppiMacchine.Location = New System.Drawing.Point(304, 176)
        Me.DataGridGruppiMacchine.Name = "DataGridGruppiMacchine"
        Me.DataGridGruppiMacchine.ReadOnly = True
        Me.DataGridGruppiMacchine.Size = New System.Drawing.Size(528, 240)
        Me.DataGridGruppiMacchine.TabIndex = 15
        Me.DataGridGruppiMacchine.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle2.DataGrid = Me.DataGridGruppiMacchine
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "t21_id_articolo_t20"
        Me.DataGridTextBoxColumn7.NullText = "0"
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Codice"
        Me.DataGridTextBoxColumn4.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn5.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "#####0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Consumo"
        Me.DataGridTextBoxColumn6.MappingName = "t21_consumo"
        Me.DataGridTextBoxColumn6.NullText = "1"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'btnAddGruppo
        '
        Me.btnAddGruppo.Image = CType(resources.GetObject("btnAddGruppo.Image"), System.Drawing.Image)
        Me.btnAddGruppo.Location = New System.Drawing.Point(264, 267)
        Me.btnAddGruppo.Name = "btnAddGruppo"
        Me.btnAddGruppo.Size = New System.Drawing.Size(32, 32)
        Me.btnAddGruppo.TabIndex = 13
        Me.btnAddGruppo.TabStop = False
        '
        'btnRemoveGruppo
        '
        Me.btnRemoveGruppo.Image = CType(resources.GetObject("btnRemoveGruppo.Image"), System.Drawing.Image)
        Me.btnRemoveGruppo.Location = New System.Drawing.Point(264, 323)
        Me.btnRemoveGruppo.Name = "btnRemoveGruppo"
        Me.btnRemoveGruppo.Size = New System.Drawing.Size(32, 32)
        Me.btnRemoveGruppo.TabIndex = 14
        Me.btnRemoveGruppo.TabStop = False
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v03_gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.conn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT t20_id_articolo, t20_cod_articolo, t20_descrizione, t20_prezzo, t20_qt_dis" & _
            "ponibile, t20_lotto_riordino, t20_is_gruppo, t20_dt_creazione, t20_dt_modifica, " & _
            "t20_dt_cancellazione FROM v03_gruppi"
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'btnSpostaSu
        '
        Me.btnSpostaSu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSpostaSu.Image = CType(resources.GetObject("btnSpostaSu.Image"), System.Drawing.Image)
        Me.btnSpostaSu.Location = New System.Drawing.Point(840, 267)
        Me.btnSpostaSu.Name = "btnSpostaSu"
        Me.btnSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaSu.TabIndex = 16
        Me.btnSpostaSu.TabStop = False
        '
        'btnSpostaGiu
        '
        Me.btnSpostaGiu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSpostaGiu.Image = CType(resources.GetObject("btnSpostaGiu.Image"), System.Drawing.Image)
        Me.btnSpostaGiu.Location = New System.Drawing.Point(840, 323)
        Me.btnSpostaGiu.Name = "btnSpostaGiu"
        Me.btnSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaGiu.TabIndex = 17
        Me.btnSpostaGiu.TabStop = False
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(88, 120)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(168, 20)
        Me.txtRicercaCodice.TabIndex = 9
        Me.txtRicercaCodice.TabStop = False
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(88, 144)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(168, 20)
        Me.txtRicercaDescrizione.TabIndex = 11
        Me.txtRicercaDescrizione.TabStop = False
        '
        'lblRicercaCodice
        '
        Me.lblRicercaCodice.Location = New System.Drawing.Point(8, 120)
        Me.lblRicercaCodice.Name = "lblRicercaCodice"
        Me.lblRicercaCodice.Size = New System.Drawing.Size(48, 16)
        Me.lblRicercaCodice.TabIndex = 8
        Me.lblRicercaCodice.Text = "Codice :"
        '
        'lblRicercaDescrizione
        '
        Me.lblRicercaDescrizione.Location = New System.Drawing.Point(8, 144)
        Me.lblRicercaDescrizione.Name = "lblRicercaDescrizione"
        Me.lblRicercaDescrizione.Size = New System.Drawing.Size(72, 16)
        Me.lblRicercaDescrizione.TabIndex = 10
        Me.lblRicercaDescrizione.Text = "Descrizione :"
        '
        'DataGridGruppi
        '
        Me.DataGridGruppi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridGruppi.CaptionText = "Gruppi Disponibili"
        Me.DataGridGruppi.DataMember = "v03_gruppi"
        Me.DataGridGruppi.DataSource = Me.objdsListaGruppi
        Me.DataGridGruppi.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridGruppi.Location = New System.Drawing.Point(8, 176)
        Me.DataGridGruppi.Name = "DataGridGruppi"
        Me.DataGridGruppi.ReadOnly = True
        Me.DataGridGruppi.Size = New System.Drawing.Size(248, 384)
        Me.DataGridGruppi.TabIndex = 12
        Me.DataGridGruppi.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle_Gruppi_Disponibili})
        '
        'objdsListaGruppi
        '
        Me.objdsListaGruppi.DataSetName = "dsGruppi2"
        Me.objdsListaGruppi.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaGruppi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle_Gruppi_Disponibili
        '
        Me.DataGridTableStyle_Gruppi_Disponibili.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle_Gruppi_Disponibili.DataGrid = Me.DataGridGruppi
        Me.DataGridTableStyle_Gruppi_Disponibili.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn_IDGruppo, Me.DataGridTextBoxColumn_CodGruppo, Me.DataGridTextBoxColumn_Descrizione_Gruppo})
        Me.DataGridTableStyle_Gruppi_Disponibili.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle_Gruppi_Disponibili.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle_Gruppi_Disponibili.MappingName = "v03_gruppi"
        '
        'DataGridTextBoxColumn_IDGruppo
        '
        Me.DataGridTextBoxColumn_IDGruppo.Format = ""
        Me.DataGridTextBoxColumn_IDGruppo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_IDGruppo.HeaderText = "ID Gruppo"
        Me.DataGridTextBoxColumn_IDGruppo.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn_IDGruppo.NullText = "0"
        Me.DataGridTextBoxColumn_IDGruppo.Width = 0
        '
        'DataGridTextBoxColumn_CodGruppo
        '
        Me.DataGridTextBoxColumn_CodGruppo.Format = ""
        Me.DataGridTextBoxColumn_CodGruppo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_CodGruppo.HeaderText = "Codice"
        Me.DataGridTextBoxColumn_CodGruppo.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn_CodGruppo.NullText = ""
        Me.DataGridTextBoxColumn_CodGruppo.Width = 75
        '
        'DataGridTextBoxColumn_Descrizione_Gruppo
        '
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.Format = ""
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.NullText = ""
        Me.DataGridTextBoxColumn_Descrizione_Gruppo.Width = 200
        '
        'DataGridComposizioneGruppo
        '
        Me.DataGridComposizioneGruppo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridComposizioneGruppo.CaptionText = "Composizione Gruppo Sopra-Selezionato"
        Me.DataGridComposizioneGruppo.DataMember = ""
        Me.DataGridComposizioneGruppo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridComposizioneGruppo.Location = New System.Drawing.Point(304, 424)
        Me.DataGridComposizioneGruppo.Name = "DataGridComposizioneGruppo"
        Me.DataGridComposizioneGruppo.ReadOnly = True
        Me.DataGridComposizioneGruppo.Size = New System.Drawing.Size(528, 136)
        Me.DataGridComposizioneGruppo.TabIndex = 18
        Me.DataGridComposizioneGruppo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridComposizioneGruppo
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Codice"
        Me.DataGridTextBoxColumn1.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn2.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = "#####0.00"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Consumo"
        Me.DataGridTextBoxColumn3.MappingName = "t22_consumo"
        Me.DataGridTextBoxColumn3.NullText = "1"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'btnModificaMacchina
        '
        Me.btnModificaMacchina.Image = CType(resources.GetObject("btnModificaMacchina.Image"), System.Drawing.Image)
        Me.btnModificaMacchina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificaMacchina.Location = New System.Drawing.Point(528, 8)
        Me.btnModificaMacchina.Name = "btnModificaMacchina"
        Me.btnModificaMacchina.Size = New System.Drawing.Size(96, 32)
        Me.btnModificaMacchina.TabIndex = 4
        Me.btnModificaMacchina.Text = "Modifica"
        Me.ToolTip1.SetToolTip(Me.btnModificaMacchina, "Modifica macchina")
        '
        'btnEliminaMacchina
        '
        Me.btnEliminaMacchina.Image = CType(resources.GetObject("btnEliminaMacchina.Image"), System.Drawing.Image)
        Me.btnEliminaMacchina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminaMacchina.Location = New System.Drawing.Point(632, 8)
        Me.btnEliminaMacchina.Name = "btnEliminaMacchina"
        Me.btnEliminaMacchina.Size = New System.Drawing.Size(96, 32)
        Me.btnEliminaMacchina.TabIndex = 5
        Me.btnEliminaMacchina.Text = "Elimina"
        Me.ToolTip1.SetToolTip(Me.btnEliminaMacchina, "Elimina macchina")
        '
        'btnNuovaMacchina
        '
        Me.btnNuovaMacchina.Image = CType(resources.GetObject("btnNuovaMacchina.Image"), System.Drawing.Image)
        Me.btnNuovaMacchina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovaMacchina.Location = New System.Drawing.Point(424, 8)
        Me.btnNuovaMacchina.Name = "btnNuovaMacchina"
        Me.btnNuovaMacchina.Size = New System.Drawing.Size(96, 32)
        Me.btnNuovaMacchina.TabIndex = 3
        Me.btnNuovaMacchina.Text = "Nuova"
        Me.ToolTip1.SetToolTip(Me.btnNuovaMacchina, "Nuova macchina")
        '
        'btnStampa
        '
        Me.btnStampa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStampa.Image = CType(resources.GetObject("btnStampa.Image"), System.Drawing.Image)
        Me.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStampa.Location = New System.Drawing.Point(736, 8)
        Me.btnStampa.Name = "btnStampa"
        Me.btnStampa.Size = New System.Drawing.Size(96, 32)
        Me.btnStampa.TabIndex = 20
        Me.btnStampa.Text = "Stampa"
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(744, 585)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(88, 32)
        Me.btnChiudi.TabIndex = 21
        Me.btnChiudi.Text = "&Chiudi"
        '
        'frmConfiguratoreMacchine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(880, 629)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.btnStampa)
        Me.Controls.Add(Me.btnModificaMacchina)
        Me.Controls.Add(Me.btnEliminaMacchina)
        Me.Controls.Add(Me.btnNuovaMacchina)
        Me.Controls.Add(Me.DataGridComposizioneGruppo)
        Me.Controls.Add(Me.DataGridGruppi)
        Me.Controls.Add(Me.lblRicercaDescrizione)
        Me.Controls.Add(Me.lblRicercaCodice)
        Me.Controls.Add(Me.txtRicercaCodice)
        Me.Controls.Add(Me.txtRicercaDescrizione)
        Me.Controls.Add(Me.txtDescrizioneMacchina)
        Me.Controls.Add(Me.txtCodMacchina)
        Me.Controls.Add(Me.btnSpostaGiu)
        Me.Controls.Add(Me.btnSpostaSu)
        Me.Controls.Add(Me.btnRemoveGruppo)
        Me.Controls.Add(Me.btnAddGruppo)
        Me.Controls.Add(Me.DataGridGruppiMacchine)
        Me.Controls.Add(Me.btnSceltaMacchina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCodMacchina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguratoreMacchine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuratore Macchine"
        CType(Me.DataGridGruppiMacchine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridComposizioneGruppo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSceltaMacchina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaMacchina.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormSceltaMacchina As New frmSceltaMacchina
        FormSceltaMacchina.ShowDialog()

        If FormSceltaMacchina.IDMacchina <> -1 Then

            mintIDMacchina = FormSceltaMacchina.IDMacchina()
            Me.txtCodMacchina.Text = FormSceltaMacchina.CodMacchina
            Me.txtDescrizioneMacchina.Text = FormSceltaMacchina.DescrizioneMacchina

            Call CaricaDatiMacchina()
            Call RicalcolaPosizioniMacchina()

        Else

            'Non viene fatto nulla

        End If

    End Sub

    Private Sub frmMacchine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        SqlDataAdapter2.Fill(objdsListaGruppi)
        Call InitMacchina()

        DataViewGruppi = objdsListaGruppi.v03_gruppi.DefaultView
        DataGridGruppi.DataSource = DataViewGruppi

        blnFormLoaded = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InitMacchina()

        mintIDMacchina = -1
        mintIDGruppo = -1

        Me.txtCodMacchina.Text = ""
        Me.txtDescrizioneMacchina.Text = ""

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'dati inesistenti
        'mstrSQL = "SELECT * FROM t03_gruppi INNER JOIN t04_gruppi_macchine "
        'mstrSQL = mstrSQL & "ON t03_id_gruppo = t04_id_gruppo_t03 WHERE "
        'mstrSQL = mstrSQL & "t04_id_macchina_t05 = -9999 "
        'mstrSQL = mstrSQL & "ORDER BY t04_posizione"
        mstrSQL = "SELECT * FROM v03_gruppi INNER JOIN t21_articoli_macchine "
        mstrSQL = mstrSQL & "ON t20_id_articolo = t21_id_articolo_t20 WHERE "
        mstrSQL = mstrSQL & "t21_id_macchina_t05 = -9999 "
        mstrSQL = mstrSQL & "ORDER BY t21_posizione"

        objdsGruppiMacchine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsGruppiMacchine.Tables(0).TableName = "t21_articoli_macchine" 't04_gruppi_macchine

        Me.DataGridGruppiMacchine.DataSource = objdsGruppiMacchine

        Me.DataGridGruppiMacchine.DataMember = "t21_articoli_macchine" 't04_gruppi_macchine
        Me.DataGridGruppiMacchine.TableStyles(0).MappingName = "t21_articoli_macchine" 't04_gruppi_macchine

        'mstrSQL = ""
        'mstrSQL = mstrSQL & "SELECT * FROM (t01_articoli RIGHT JOIN t02_articoli_gruppi "
        'mstrSQL = mstrSQL & "ON t01_id_articolo = t02_id_articolo_t01) LEFT JOIN t03_gruppi "
        'mstrSQL = mstrSQL & "ON t02_id_gruppo_figlio_t03 = t03_id_gruppo  WHERE "
        'mstrSQL = mstrSQL & "t02_id_gruppo_t03 = -9999 "
        'mstrSQL = mstrSQL & "ORDER BY t02_posizione"
        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT * FROM (t20_articoli as FIGLI RIGHT JOIN t22_articoli_articoli "
        mstrSQL = mstrSQL & "ON FIGLI.t20_id_articolo = t22_id_articolo_t20) LEFT JOIN v03_gruppi "
        mstrSQL = mstrSQL & "ON FIGLI.t20_id_articolo = v03_gruppi.t20_id_articolo  WHERE "
        mstrSQL = mstrSQL & "t22_id_articolo_t20 = -9999 "
        mstrSQL = mstrSQL & "ORDER BY t22_posizione"

        Dim objdsComposizioneGruppo As DataSet = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)
        objdsComposizioneGruppo.Tables(0).TableName = "Composizione_Gruppo"
        Me.DataGridComposizioneGruppo.DataSource = objdsComposizioneGruppo
        Me.DataGridComposizioneGruppo.DataMember = "Composizione_Gruppo"
        Me.DataGridComposizioneGruppo.TableStyles(0).MappingName = "Composizione_Gruppo"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnAddGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddGruppo.Click, DataGridGruppi.DoubleClick
        Call AggiungiGruppi()
    End Sub

    Private Sub AggiungiGruppi()

        Dim intIDGruppoUpdate As Integer
        Dim intContatore As Integer = 0

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intRowCount As Integer
        Dim strCodGruppo() As String
        Dim intContatoreGruppiGiaPresenti As Integer = -1

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If DataViewGruppi.Count > 0 Then

            For intRowCount = 0 To DataViewGruppi.Count - 1

                'solo se gruppo sezionato tenta l'aggiunta
                If DataGridGruppi.IsSelected(intRowCount) Then
                    mintIDGruppo = CType(DataGridGruppi.Item(intRowCount, 0), Integer)

                    'controllo presenza gruppo nella macchina
                    If GruppoGiaPresente(mintIDGruppo, mintIDMacchina) Then

                        intContatoreGruppiGiaPresenti = intContatoreGruppiGiaPresenti + 1
                        ReDim Preserve strCodGruppo(intContatoreGruppiGiaPresenti)
                        strCodGruppo(intContatoreGruppiGiaPresenti) = DataGridGruppi.Item(intRowCount, 1)

                    Else

                        'per ogni riga aggiorna la posizione
                        intContatore = 0
                        For Each dr As DataRow In objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows 't04_gruppi_macchine
                            intContatore = intContatore + 1
                            intIDGruppoUpdate = dr("t21_id_articolo_t20") 't04_id_gruppo_t03

                            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = " & intContatore.ToString & " "
                            'mstrSQL = mstrSQL & "WHERE t04_id_gruppo_t03 = " & intIDGruppoUpdate.ToString & " AND "
                            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
                            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = " & intContatore.ToString & " "
                            mstrSQL = mstrSQL & "WHERE t21_id_articolo_t20 = " & intIDGruppoUpdate.ToString & " AND "
                            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString

                            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        Next

                        intContatore = intContatore + 1

                        'mstrSQL = "INSERT INTO t04_gruppi_macchine (t04_id_gruppo_t03, t04_id_macchina_t05, t04_posizione) VALUES ("
                        mstrSQL = "INSERT INTO t21_articoli_macchine (t21_id_articolo_t20, t21_id_macchina_t05, t21_posizione) VALUES ("
                        mstrSQL = mstrSQL & mintIDGruppo.ToString & ", " & mintIDMacchina.ToString & ", " & intContatore.ToString & ")"
                        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                        Call CaricaDatiMacchina()

                    End If

                End If
            Next
        End If

        'default
        Cursor.Current = Cursors.Default

        'eventuale messaggio di notifica
        If Not (strCodGruppo Is Nothing) Then
            mstrMsg = "I seguenti gruppi :" & vbCrLf & vbCrLf
            For intContatore = 0 To strCodGruppo.Length - 1
                mstrMsg = mstrMsg & strCodGruppo(intContatore) & vbCrLf
            Next
            mstrMsg = mstrMsg & vbCrLf & "sono già presenti nella macchina! Eventualmente modificarne il consumo!"
            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function GruppoGiaPresente(ByVal intIDGruppo As Integer, ByVal intIDMacchina As Integer) As Boolean

        'mstrSQL = "SELECT * FROM t04_gruppi_macchine WHERE "
        'mstrSQL = mstrSQL & "t04_id_gruppo_t03 = " & intIDGruppo.ToString & " AND "
        'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & intIDMacchina.ToString & " AND "
        'mstrSQL = mstrSQL & "t04_dt_cancellazione IS NULL"
        mstrSQL = "SELECT * FROM t21_articoli_macchine WHERE "
        mstrSQL = mstrSQL & "t21_id_articolo_t20 = " & intIDGruppo.ToString & " AND "
        mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & intIDMacchina.ToString & " AND "
        mstrSQL = mstrSQL & "t21_dt_cancellazione IS NULL"

        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub CaricaDatiMacchina()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'mstrSQL = "SELECT * FROM t03_gruppi INNER JOIN t04_gruppi_macchine "
        'mstrSQL = mstrSQL & "ON t03_id_gruppo = t04_id_gruppo_t03 WHERE "
        'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString & " "
        'mstrSQL = mstrSQL & "ORDER BY t04_posizione"
        mstrSQL = "SELECT * FROM v03_gruppi INNER JOIN t21_articoli_macchine "
        mstrSQL = mstrSQL & "ON t20_id_articolo = t21_id_articolo_t20 WHERE "
        mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString & " "
        mstrSQL = mstrSQL & "ORDER BY t21_posizione"

        objdsGruppiMacchine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsGruppiMacchine.Tables(0).TableName = "t21_articoli_macchine" 't04_gruppi_macchine

        Me.DataGridGruppiMacchine.DataSource = objdsGruppiMacchine

        Me.DataGridGruppiMacchine.DataMember = "t21_articoli_macchine" 't04_gruppi_macchine
        Me.DataGridGruppiMacchine.TableStyles(0).MappingName = "t21_articoli_macchine" 't04_gruppi_macchine

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count > 0 Then 't04_gruppi_macchine
            Call VisualizzaComposizioneGruppo()
        End If

        'CONTROLLO SE LA MACCHINA CHE STO RICHIAMANDO E' ISTANZIATA ED
        'E' IN PRODUZIONE O SOSPESA
        mstrSQL = "SELECT * FROM t06_istanze_macchine WHERE "
        mstrSQL += "t06_dt_cancellazione IS NULL AND "
        mstrSQL += "t06_id_macchina_t05 = " & mintIDMacchina.ToString & " AND ("
        mstrSQL += "t06_id_stato_istanza_t07 = 'P' OR t06_id_stato_istanza_t07 = 'S')"

        Dim DRIstanze As SqlClient.SqlDataReader
        DRIstanze = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)
        If DRIstanze.HasRows Then
            MessageBox.Show("ATTENZIONE! La macchina che si sta richiamando appartiene ad una commessa in produzione o sospesa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnRemoveGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveGruppo.Click
        Call RimuoviGruppi()
    End Sub

    Private Sub RimuoviGruppi()

        If MessageBox.Show("Confermi rimozione gruppi dalla macchina?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intIDGruppiUpdate As Integer
        Dim intContatore As Integer = 0
        Dim intContatoreGruppiDaRimuovere As Integer = -1
        Dim intRowCount As Integer

        'vettore IDGruppi da rimuovere dalla macchina
        Dim intIDGruppiDaRimuovere() As Integer

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count > 0 Then 't04_gruppi_macchine

            For intRowCount = 0 To objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count - 1 't04_gruppi_macchine

                'determina ID da eliminare
                If DataGridGruppiMacchine.IsSelected(intRowCount) Then
                    intContatoreGruppiDaRimuovere = intContatoreGruppiDaRimuovere + 1
                    ReDim Preserve intIDGruppiDaRimuovere(intContatoreGruppiDaRimuovere)
                    intIDGruppiDaRimuovere(intContatoreGruppiDaRimuovere) = CType(DataGridGruppiMacchine.Item(intRowCount, 0), Integer)
                End If

            Next

            If Not (intIDGruppiDaRimuovere Is Nothing) Then
                For intContatore = 0 To intIDGruppiDaRimuovere.Length - 1
                    'effettua cancellazione
                    'mstrSQL = "DELETE FROM t04_gruppi_macchine WHERE t04_id_gruppo_t03 = "
                    'mstrSQL = mstrSQL & intIDGruppiDaRimuovere(intContatore).ToString & " AND "
                    'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
                    mstrSQL = "DELETE FROM t21_articoli_macchine WHERE t21_id_articolo_t20 = "
                    mstrSQL = mstrSQL & intIDGruppiDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
                Next
            End If

            Call CaricaDatiMacchina()

            'rinumera posizioni per record rimasti nella macchina
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows 't04_gruppi_macchine
                intContatore = intContatore + 1

                intIDGruppiUpdate = dr("t21_id_articolo_t20") 't04_id_gruppo_t03

                'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = " & intContatore.ToString & " "
                'mstrSQL = mstrSQL & "WHERE t04_id_gruppo_t03 = " & intIDGruppiUpdate.ToString & " AND "
                'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
                mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t21_id_articolo_t20 = " & intIDGruppiUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Next

            Call CaricaDatiMacchina()

        End If

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count > 0 Then 't04_gruppi_macchine
            DataGridGruppiMacchine.CurrentRowIndex = 0 'seleziona prima riga
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub RicalcolaPosizioniMacchina()
        'Questa sub ricalcola il campo t04_posizione per evitare
        'problemi nello spostamento dei gruppi
        Dim intContatore As Integer
        Dim intIDGruppoUpdate As Integer

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count > 0 Then 't04_gruppi_macchine
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows
                intContatore = intContatore + 1
                intIDGruppoUpdate = dr("t21_id_articolo_t20") 't04_id_gruppo_t03

                'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = " & intContatore.ToString & " "
                'mstrSQL = mstrSQL & "WHERE t04_id_gruppo_t03 = " & intIDGruppoUpdate.ToString & " AND "
                'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
                mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = " & intContatore.ToString & " "
                mstrSQL = mstrSQL & "WHERE t21_id_articolo_t20 = " & intIDGruppoUpdate.ToString & " AND "
                mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
            Next

        End If
    End Sub

    Private Sub btnSpostaSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaSu.Click

        Dim intPosizione As Integer

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count <= 0 Then
            MessageBox.Show("Nessun gruppo memorizzato all'interno della macchina!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridGruppiMacchine.CurrentRowIndex + 1
        DataGridGruppiMacchine.Select(DataGridGruppiMacchine.CurrentRowIndex)

        If intPosizione > 1 Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = 999999 WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = " & (intPosizione - 1).ToString & " AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t21_posizione = " & (intPosizione - 1).ToString & " AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = t04_posizione - 1 WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = " & intPosizione.ToString & " AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = t21_posizione - 1 WHERE "
            mstrSQL = mstrSQL & "t21_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = " & intPosizione.ToString & " WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = 999999 AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t21_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiMacchina()
            Call RicalcolaPosizioniMacchina()
            DataGridGruppiMacchine.CurrentRowIndex = intPosizione - 2
            DataGridGruppiMacchine.Select(intPosizione - 2)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub ApplicaFiltri(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged, txtRicercaDescrizione.TextChanged
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = Me.txtRicercaCodice.Text
        strFiltroDescrizione = Me.txtRicercaDescrizione.Text

        If strFiltroCodice.Trim <> "" Then
            strFiltro = "t20_cod_articolo LIKE '*" & strFiltroCodice & "*' " 't03_cod_gruppo
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = strFiltro & "AND "
                strFiltro = strFiltro & "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'" 't03_descrizione
            End If
        Else
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'" 't03_descrizione
            End If
        End If
        DataViewGruppi.RowFilter = strFiltro

    End Sub

    Private Sub btnSpostaGiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaGiu.Click

        Dim intPosizione As Integer

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count <= 0 Then
            MessageBox.Show("Nessun gruppo memorizzato all'interno della macchina!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridGruppiMacchine.CurrentRowIndex + 1
        DataGridGruppiMacchine.Select(DataGridGruppiMacchine.CurrentRowIndex)

        If intPosizione < objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count Then 't04_gruppi_macchine
            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = 999999 WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = " & (intPosizione + 1).ToString & " AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t21_posizione = " & (intPosizione + 1).ToString & " AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = t04_posizione + 1 WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = " & intPosizione.ToString & " AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = t21_posizione + 1 WHERE "
            mstrSQL = mstrSQL & "t21_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_posizione = " & intPosizione.ToString & " WHERE "
            'mstrSQL = mstrSQL & "t04_posizione = 999999 AND "
            'mstrSQL = mstrSQL & "t04_id_macchina_t05 = " & mintIDMacchina.ToString
            'ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t21_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t21_id_macchina_t05 = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiMacchina()
            Call RicalcolaPosizioniMacchina()
            DataGridGruppiMacchine.CurrentRowIndex = intPosizione
            DataGridGruppiMacchine.Select(intPosizione)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub DataGridGruppiMacchine_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridGruppiMacchine.DoubleClick
        Dim intPosizione As Integer

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows.Count > 0 Then 't04_gruppi_macchine
            DataGridGruppiMacchine.Select(DataGridGruppiMacchine.CurrentRowIndex)
            Dim strConsumo, strConsumoDefault As String
            strConsumoDefault = DataGridGruppiMacchine.Item(DataGridGruppiMacchine.CurrentRowIndex, 3)
            intPosizione = DataGridGruppiMacchine.CurrentRowIndex

            strConsumo = InputBox("Inserire il consumo per il gruppo selezionato :", Me.Text, strConsumoDefault)
            strConsumo = Replace(strConsumo, ",", ".")
            If strConsumo Is Nothing Then strConsumo = ""
            If strConsumo.Trim <> "" Then
                If Not IsNumeric(strConsumo.Trim) Then
                    MessageBox.Show("E' necessario indicare un valore numerico!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    If CType(strConsumo.Trim, Integer) = 0 Then
                        MessageBox.Show("Impossibile inserire un consumo nullo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    'clessidra
                    Cursor.Current = Cursors.WaitCursor

                    'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_consumo = " & strConsumo.Trim & ", "
                    'mstrSQL = mstrSQL & "t04_dt_modifica = GetDate() "
                    'mstrSQL = mstrSQL & "WHERE t04_id_macchina_t05 = " & mintIDMacchina.ToString & " AND "
                    'mstrSQL = mstrSQL & "t04_id_gruppo_t03 = " & objdsGruppiMacchine.Tables("t04_gruppi_macchine").Rows(DataGridGruppiMacchine.CurrentRowIndex).Item("t04_id_gruppo_t03").ToString
                    mstrSQL = "UPDATE t21_articoli_macchine SET t21_consumo = " & strConsumo.Trim & ", "
                    mstrSQL = mstrSQL & "t21_dt_modifica = GetDate() "
                    mstrSQL = mstrSQL & "WHERE t21_id_macchina_t05 = " & mintIDMacchina.ToString & " AND "
                    mstrSQL = mstrSQL & "t21_id_articolo_t20 = " & objdsGruppiMacchine.Tables("t21_articoli_macchine").Rows(DataGridGruppiMacchine.CurrentRowIndex).Item("t21_id_articolo_t20").ToString

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                    Call CaricaDatiMacchina()
                    DataGridGruppiMacchine.CurrentRowIndex = intPosizione
                    DataGridGruppiMacchine.Select(intPosizione)

                    'default
                    Cursor.Current = Cursors.Default

                End If
            End If
        End If

    End Sub

    Private Sub DataGridGruppiMacchine_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridGruppiMacchine.CurrentCellChanged
        Call VisualizzaComposizioneGruppo()
    End Sub

    Private Sub VisualizzaComposizioneGruppo()

        If mintIDMacchina = -1 Then
            Exit Sub
        End If

        'IDGruppo da visualizzare
        Dim tmpintIDGruppo As Integer

        tmpintIDGruppo = DataGridGruppiMacchine.Item(DataGridGruppiMacchine.CurrentRowIndex, 0)

        'Clessidra
        Cursor.Current = Cursors.WaitCursor

        'mstrSQL = ""
        'mstrSQL = mstrSQL & "SELECT 't01_cod_articolo' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "		WHEN t02_id_gruppo_figlio_t03 IS NULL THEN t01_cod_articolo"
        'mstrSQL = mstrSQL & "       ELSE t03_cod_gruppo"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "'t01_descrizione' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "       WHEN t02_id_gruppo_figlio_t03 IS NULL THEN t01_descrizione"
        'mstrSQL = mstrSQL & "       ELSE t03_descrizione"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "t02_consumo "
        'mstrSQL = mstrSQL & "   FROM ("
        'mstrSQL = mstrSQL & "SELECT * FROM (t01_articoli RIGHT JOIN t02_articoli_gruppi "
        'mstrSQL = mstrSQL & "ON t01_id_articolo = t02_id_articolo_t01) LEFT JOIN t03_gruppi "
        'mstrSQL = mstrSQL & "ON t02_id_gruppo_figlio_t03 = t03_id_gruppo  WHERE "
        'mstrSQL = mstrSQL & "t02_id_gruppo_t03 = " & tmpintIDGruppo.ToString & " "
        'mstrSQL = mstrSQL & ") AS TAB1 "
        'mstrSQL = mstrSQL & "   ORDER BY t02_posizione"
        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT t22_id_articolo_t20, "
        mstrSQL = mstrSQL & "t20_cod_articolo, "
        mstrSQL = mstrSQL & "t20_descrizione, "
        mstrSQL = mstrSQL & "t20_is_gruppo, "
        mstrSQL = mstrSQL & "t22_consumo "
        mstrSQL = mstrSQL & " FROM ("
        mstrSQL = mstrSQL & "SELECT * FROM t20_articoli RIGHT JOIN t22_articoli_articoli "
        mstrSQL = mstrSQL & "ON t20_id_articolo = t22_id_articolo_t20 WHERE "
        mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & tmpintIDGruppo.ToString & " "
        mstrSQL = mstrSQL & ") AS TAB1 "
        mstrSQL = mstrSQL & "ORDER BY t22_posizione"

        Dim objdsComposizioneGruppo As DataSet = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)
        objdsComposizioneGruppo.Tables(0).TableName = "Composizione_Gruppo"
        Me.DataGridComposizioneGruppo.DataSource = objdsComposizioneGruppo
        Me.DataGridComposizioneGruppo.DataMember = "Composizione_Gruppo"
        Me.DataGridComposizioneGruppo.TableStyles(0).MappingName = "Composizione_Gruppo"

        'Default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnNuovaMacchina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovaMacchina.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormInsMacchina As New frmInsGruppoMacchina
        FormInsMacchina.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Macchina
        FormInsMacchina.TipoInserimento = frmInsGruppoMacchina.TInserimento.Nuovo
        FormInsMacchina.ConnectionString = conn1.ConnectionString

        FormInsMacchina.ShowDialog()
    End Sub

    Private Sub btnModificaMacchina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaMacchina.Click

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormInsMacchina As New frmInsGruppoMacchina
        FormInsMacchina.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Macchina
        FormInsMacchina.TipoInserimento = frmInsGruppoMacchina.TInserimento.Variazione
        FormInsMacchina.ID = mintIDMacchina
        FormInsMacchina.ConnectionString = conn1.ConnectionString

        FormInsMacchina.ShowDialog()

        Me.txtCodMacchina.Text = FormInsMacchina.Codice
        Me.txtDescrizioneMacchina.Text = FormInsMacchina.Descrizione

    End Sub

    Private Sub btnEliminaMacchina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaMacchina.Click

        If mintIDMacchina = -1 Then
            MessageBox.Show("Scegliere prima una macchina valida!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi eliminazione macchina?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim DRControlloIstanze As SqlClient.SqlDataReader

            'un gruppo non è eliminabile se fa parte di un'istanza non eliminata
            mstrSQL = ""
            mstrSQL += "SELECT * FROM t06_istanze_macchine WHERE t06_dt_cancellazione IS NULL AND "
            mstrSQL += "t06_id_macchina_t05 = " & mintIDMacchina.ToString

            DRControlloIstanze = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)
            If DRControlloIstanze.HasRows Then
                MessageBox.Show("Impossibile eliminare la macchina perchè appartiene almeno ad una commessa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            mstrSQL = "UPDATE t05_macchine SET t05_dt_cancellazione = GetDate() WHERE t05_id_macchina = " & mintIDMacchina.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'A catena "elimina" gli eventuali record presenti sulla t04_gruppi_macchine
            'mstrSQL = "UPDATE t04_gruppi_macchine SET t04_dt_cancellazione = GetDate() WHERE "
            'mstrSQL += "t04_id_macchina_t05 = " & mintIDMacchina.ToString & " AND "
            'mstrSQL += "t04_dt_cancellazione IS NULL"
            mstrSQL = "UPDATE t21_articoli_macchine SET t21_dt_cancellazione = GetDate() WHERE "
            mstrSQL += "t21_id_macchina_t05 = " & mintIDMacchina.ToString & " AND "
            mstrSQL += "t21_dt_cancellazione IS NULL"
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call InitMacchina()
        End If

    End Sub

    Private Sub txtCodMacchina_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodMacchina.KeyDown
        If e.KeyValue = Keys.F9 Then
            Call btnSceltaMacchina_Click(txtCodMacchina, Nothing)
        ElseIf e.KeyValue = Keys.F10 Then
            Call btnNuovaMacchina_Click(txtCodMacchina, Nothing)
        End If
    End Sub

    Private Sub btnStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStampa.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        'FormReport.reportDocumentSource.Load("TEMAC-OrdiniFor.rpt") ' = New OrdiniFor
        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-StrutturaMacchina.rpt")) ' = New OrdiniFor

        If mintIDMacchina <> -1 Then
            FormReport.reportDocumentSource.RecordSelectionFormula = "{viewStrutturaMacchina.t21_id_macchina_t05} = " & mintIDMacchina
        End If

        FormReport.Show()
    End Sub


End Class
