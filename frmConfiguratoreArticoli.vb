Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmConfiguratoreArticoli
    Inherits System.Windows.Forms.Form

    Private mintIDArticoloCorrente As Integer 'IDGruppo correttemente editato 'mintIDGruppo
    Private mintIDGruppoDaAggiungere As Integer
    Private mintIDArticoloDaAggiungere As Integer 'IDArticolo per spostamento su gruppo
    Private mstrSQL As String
    Private objdsArticoliGruppi As DataSet
    Private mstrMsg As String
    Private DataViewArticoli As DataView
    Private DataViewGruppi As DataView
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
    Friend WithEvents lblCodGruppo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSceltaGruppo As System.Windows.Forms.Button
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents btnAddArticolo As System.Windows.Forms.Button
    Friend WithEvents btnRemoveArticolo As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents DataGridArticoli As System.Windows.Forms.DataGrid
    Friend WithEvents Tab_Articoli As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Gruppi As System.Windows.Forms.TabPage
    Friend WithEvents DataGridGruppi As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle_Articoli_Disponibili As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn_IDArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_CodArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle_Gruppi_Disponibili As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn_Descrizione_Articolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_IDGruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_CodGruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn_Descrizione_Gruppo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridArticoliGruppi As System.Windows.Forms.DataGrid
    Friend WithEvents btnSpostaSu As System.Windows.Forms.Button
    Friend WithEvents btnSpostaGiu As System.Windows.Forms.Button
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents lblRicercaCodice As System.Windows.Forms.Label
    Friend WithEvents lblRicercaDescrizione As System.Windows.Forms.Label
    Friend WithEvents btnNuovoGruppo As System.Windows.Forms.Button
    Friend WithEvents btnEliminaGruppo As System.Windows.Forms.Button
    Friend WithEvents btnModificaGruppo As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtCodArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrizioneArticolo As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaGruppi As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaArticoli As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguratoreArticoli))
        Me.lblCodGruppo = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnSceltaGruppo = New System.Windows.Forms.Button
        Me.txtCodArticolo = New System.Windows.Forms.TextBox
        Me.txtDescrizioneArticolo = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataGridArticoliGruppi = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnAddArticolo = New System.Windows.Forms.Button
        Me.btnRemoveArticolo = New System.Windows.Forms.Button
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.Tab_Articoli = New System.Windows.Forms.TabPage
        Me.DataGridArticoli = New System.Windows.Forms.DataGrid
        Me.objdsListaArticoli = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle_Articoli_Disponibili = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn_IDArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_CodArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_Descrizione_Articolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Tab_Gruppi = New System.Windows.Forms.TabPage
        Me.DataGridGruppi = New System.Windows.Forms.DataGrid
        Me.objdsListaGruppi = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle_Gruppi_Disponibili = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn_IDGruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_CodGruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn_Descrizione_Gruppo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnSpostaSu = New System.Windows.Forms.Button
        Me.btnSpostaGiu = New System.Windows.Forms.Button
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.lblRicercaCodice = New System.Windows.Forms.Label
        Me.lblRicercaDescrizione = New System.Windows.Forms.Label
        Me.btnNuovoGruppo = New System.Windows.Forms.Button
        Me.btnEliminaGruppo = New System.Windows.Forms.Button
        Me.btnModificaGruppo = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridArticoliGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Tab_Articoli.SuspendLayout()
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_Gruppi.SuspendLayout()
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodGruppo
        '
        Me.lblCodGruppo.Location = New System.Drawing.Point(8, 16)
        Me.lblCodGruppo.Name = "lblCodGruppo"
        Me.lblCodGruppo.Size = New System.Drawing.Size(88, 16)
        Me.lblCodGruppo.TabIndex = 0
        Me.lblCodGruppo.Text = "Codice Articolo :"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Descrizione Articolo :"
        '
        'btnSceltaGruppo
        '
        Me.btnSceltaGruppo.Image = CType(resources.GetObject("btnSceltaGruppo.Image"), System.Drawing.Image)
        Me.btnSceltaGruppo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSceltaGruppo.Location = New System.Drawing.Point(320, 8)
        Me.btnSceltaGruppo.Name = "btnSceltaGruppo"
        Me.btnSceltaGruppo.Size = New System.Drawing.Size(104, 32)
        Me.btnSceltaGruppo.TabIndex = 2
        Me.btnSceltaGruppo.Text = "Seleziona"
        Me.ToolTip1.SetToolTip(Me.btnSceltaGruppo, "Ricerca e selezione articolo")
        '
        'txtCodArticolo
        '
        Me.txtCodArticolo.Location = New System.Drawing.Point(128, 16)
        Me.txtCodArticolo.Name = "txtCodArticolo"
        Me.txtCodArticolo.ReadOnly = True
        Me.txtCodArticolo.Size = New System.Drawing.Size(184, 20)
        Me.txtCodArticolo.TabIndex = 1
        Me.txtCodArticolo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtCodArticolo, "Codice Gruppo (F9=Ricerca, F10=Nuovo)")
        '
        'txtDescrizioneArticolo
        '
        Me.txtDescrizioneArticolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizioneArticolo.Location = New System.Drawing.Point(128, 48)
        Me.txtDescrizioneArticolo.Multiline = True
        Me.txtDescrizioneArticolo.Name = "txtDescrizioneArticolo"
        Me.txtDescrizioneArticolo.ReadOnly = True
        Me.txtDescrizioneArticolo.Size = New System.Drawing.Size(744, 48)
        Me.txtDescrizioneArticolo.TabIndex = 7
        Me.txtDescrizioneArticolo.TabStop = False
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v01_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.conn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'DataGridArticoliGruppi
        '
        Me.DataGridArticoliGruppi.AllowSorting = False
        Me.DataGridArticoliGruppi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridArticoliGruppi.CaptionText = "Articoli/Gruppi appartenenti all'Articolo"
        Me.DataGridArticoliGruppi.DataMember = ""
        Me.DataGridArticoliGruppi.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridArticoliGruppi.Location = New System.Drawing.Point(304, 176)
        Me.DataGridArticoliGruppi.Name = "DataGridArticoliGruppi"
        Me.DataGridArticoliGruppi.ReadOnly = True
        Me.DataGridArticoliGruppi.Size = New System.Drawing.Size(528, 312)
        Me.DataGridArticoliGruppi.TabIndex = 15
        Me.DataGridArticoliGruppi.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle2.DataGrid = Me.DataGridArticoliGruppi
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "t22_articoli_articoli"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "t22_id_articolo_t20"
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
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = "#####0.00"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Consumo "
        Me.DataGridTextBoxColumn6.MappingName = "t22_consumo"
        Me.DataGridTextBoxColumn6.NullText = "1"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'btnAddArticolo
        '
        Me.btnAddArticolo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAddArticolo.Image = CType(resources.GetObject("btnAddArticolo.Image"), System.Drawing.Image)
        Me.btnAddArticolo.Location = New System.Drawing.Point(264, 224)
        Me.btnAddArticolo.Name = "btnAddArticolo"
        Me.btnAddArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnAddArticolo.TabIndex = 13
        '
        'btnRemoveArticolo
        '
        Me.btnRemoveArticolo.Image = CType(resources.GetObject("btnRemoveArticolo.Image"), System.Drawing.Image)
        Me.btnRemoveArticolo.Location = New System.Drawing.Point(264, 280)
        Me.btnRemoveArticolo.Name = "btnRemoveArticolo"
        Me.btnRemoveArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnRemoveArticolo.TabIndex = 14
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(736, 496)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 18
        Me.btnChiudi.Text = "&Chiudi"
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v03_gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.conn1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.conn1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Tab_Articoli)
        Me.TabControl1.Controls.Add(Me.Tab_Gruppi)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 176)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(256, 320)
        Me.TabControl1.TabIndex = 12
        '
        'Tab_Articoli
        '
        Me.Tab_Articoli.Controls.Add(Me.DataGridArticoli)
        Me.Tab_Articoli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Articoli.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Articoli.Name = "Tab_Articoli"
        Me.Tab_Articoli.Size = New System.Drawing.Size(248, 294)
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
        Me.DataGridArticoli.Size = New System.Drawing.Size(248, 291)
        Me.DataGridArticoli.TabIndex = 0
        Me.DataGridArticoli.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle_Articoli_Disponibili})
        '
        'objdsListaArticoli
        '
        Me.objdsListaArticoli.DataSetName = "dsArticoli2"
        Me.objdsListaArticoli.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaArticoli.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle_Articoli_Disponibili
        '
        Me.DataGridTableStyle_Articoli_Disponibili.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle_Articoli_Disponibili.DataGrid = Me.DataGridArticoli
        Me.DataGridTableStyle_Articoli_Disponibili.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn_IDArticolo, Me.DataGridTextBoxColumn_CodArticolo, Me.DataGridTextBoxColumn_Descrizione_Articolo})
        Me.DataGridTableStyle_Articoli_Disponibili.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle_Articoli_Disponibili.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle_Articoli_Disponibili.MappingName = "v01_articoli"
        '
        'DataGridTextBoxColumn_IDArticolo
        '
        Me.DataGridTextBoxColumn_IDArticolo.Format = ""
        Me.DataGridTextBoxColumn_IDArticolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_IDArticolo.HeaderText = "ID Articolo"
        Me.DataGridTextBoxColumn_IDArticolo.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn_IDArticolo.NullText = "0"
        Me.DataGridTextBoxColumn_IDArticolo.Width = 0
        '
        'DataGridTextBoxColumn_CodArticolo
        '
        Me.DataGridTextBoxColumn_CodArticolo.Format = ""
        Me.DataGridTextBoxColumn_CodArticolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_CodArticolo.HeaderText = "Codice"
        Me.DataGridTextBoxColumn_CodArticolo.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn_CodArticolo.NullText = ""
        Me.DataGridTextBoxColumn_CodArticolo.Width = 75
        '
        'DataGridTextBoxColumn_Descrizione_Articolo
        '
        Me.DataGridTextBoxColumn_Descrizione_Articolo.Format = ""
        Me.DataGridTextBoxColumn_Descrizione_Articolo.FormatInfo = Nothing
        Me.DataGridTextBoxColumn_Descrizione_Articolo.HeaderText = "Descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Articolo.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn_Descrizione_Articolo.NullText = ""
        Me.DataGridTextBoxColumn_Descrizione_Articolo.Width = 200
        '
        'Tab_Gruppi
        '
        Me.Tab_Gruppi.Controls.Add(Me.DataGridGruppi)
        Me.Tab_Gruppi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Gruppi.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Gruppi.Name = "Tab_Gruppi"
        Me.Tab_Gruppi.Size = New System.Drawing.Size(248, 294)
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
        Me.DataGridGruppi.Size = New System.Drawing.Size(248, 291)
        Me.DataGridGruppi.TabIndex = 7
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
        'btnSpostaSu
        '
        Me.btnSpostaSu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSpostaSu.Image = CType(resources.GetObject("btnSpostaSu.Image"), System.Drawing.Image)
        Me.btnSpostaSu.Location = New System.Drawing.Point(840, 224)
        Me.btnSpostaSu.Name = "btnSpostaSu"
        Me.btnSpostaSu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaSu.TabIndex = 16
        '
        'btnSpostaGiu
        '
        Me.btnSpostaGiu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnSpostaGiu.Image = CType(resources.GetObject("btnSpostaGiu.Image"), System.Drawing.Image)
        Me.btnSpostaGiu.Location = New System.Drawing.Point(840, 280)
        Me.btnSpostaGiu.Name = "btnSpostaGiu"
        Me.btnSpostaGiu.Size = New System.Drawing.Size(32, 32)
        Me.btnSpostaGiu.TabIndex = 17
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRicercaCodice.Location = New System.Drawing.Point(88, 120)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(168, 20)
        Me.txtRicercaCodice.TabIndex = 9
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(88, 144)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(168, 20)
        Me.txtRicercaDescrizione.TabIndex = 11
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
        'btnNuovoGruppo
        '
        Me.btnNuovoGruppo.Image = CType(resources.GetObject("btnNuovoGruppo.Image"), System.Drawing.Image)
        Me.btnNuovoGruppo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuovoGruppo.Location = New System.Drawing.Point(432, 8)
        Me.btnNuovoGruppo.Name = "btnNuovoGruppo"
        Me.btnNuovoGruppo.Size = New System.Drawing.Size(96, 31)
        Me.btnNuovoGruppo.TabIndex = 3
        Me.btnNuovoGruppo.Text = "Nuovo"
        Me.ToolTip1.SetToolTip(Me.btnNuovoGruppo, "Nuovo articolo")
        '
        'btnEliminaGruppo
        '
        Me.btnEliminaGruppo.Image = CType(resources.GetObject("btnEliminaGruppo.Image"), System.Drawing.Image)
        Me.btnEliminaGruppo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminaGruppo.Location = New System.Drawing.Point(640, 8)
        Me.btnEliminaGruppo.Name = "btnEliminaGruppo"
        Me.btnEliminaGruppo.Size = New System.Drawing.Size(96, 31)
        Me.btnEliminaGruppo.TabIndex = 5
        Me.btnEliminaGruppo.Text = "Elimina"
        Me.ToolTip1.SetToolTip(Me.btnEliminaGruppo, "Elimina articolo")
        '
        'btnModificaGruppo
        '
        Me.btnModificaGruppo.Image = CType(resources.GetObject("btnModificaGruppo.Image"), System.Drawing.Image)
        Me.btnModificaGruppo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificaGruppo.Location = New System.Drawing.Point(536, 8)
        Me.btnModificaGruppo.Name = "btnModificaGruppo"
        Me.btnModificaGruppo.Size = New System.Drawing.Size(96, 31)
        Me.btnModificaGruppo.TabIndex = 4
        Me.btnModificaGruppo.Text = "Modifica"
        Me.ToolTip1.SetToolTip(Me.btnModificaGruppo, "Modifica articolo")
        '
        'frmConfiguratoreArticoli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(880, 542)
        Me.Controls.Add(Me.btnModificaGruppo)
        Me.Controls.Add(Me.btnEliminaGruppo)
        Me.Controls.Add(Me.btnNuovoGruppo)
        Me.Controls.Add(Me.lblRicercaDescrizione)
        Me.Controls.Add(Me.lblRicercaCodice)
        Me.Controls.Add(Me.txtRicercaCodice)
        Me.Controls.Add(Me.txtRicercaDescrizione)
        Me.Controls.Add(Me.txtDescrizioneArticolo)
        Me.Controls.Add(Me.txtCodArticolo)
        Me.Controls.Add(Me.btnSpostaGiu)
        Me.Controls.Add(Me.btnSpostaSu)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.btnRemoveArticolo)
        Me.Controls.Add(Me.btnAddArticolo)
        Me.Controls.Add(Me.DataGridArticoliGruppi)
        Me.Controls.Add(Me.btnSceltaGruppo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCodGruppo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguratoreArticoli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuratore Articoli"
        CType(Me.DataGridArticoliGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Tab_Articoli.ResumeLayout(False)
        CType(Me.DataGridArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_Gruppi.ResumeLayout(False)
        CType(Me.DataGridGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnSceltaGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaGruppo.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormSceltaArticolo As New frmSceltaArticolo
        FormSceltaArticolo.ModoSelezione = frmSceltaArticolo.TModoSelezione.SELEZIONA
        FormSceltaArticolo.ShowDialog()

        If FormSceltaArticolo.IDArticolo <> -1 Then

            mintIDArticoloCorrente = FormSceltaArticolo.IDArticolo()
            Me.txtCodArticolo.Text = FormSceltaArticolo.CodArticolo
            Me.txtDescrizioneArticolo.Text = FormSceltaArticolo.DescrizioneArticolo

            Call CaricaDatiArticolo()
            Call RicalcolaPosizioniArticolo()

        Else

            'Non viene fatto nulla

        End If

    End Sub

    Private Sub RefreshData()
        SqlDataAdapter1.Fill(objdsListaArticoli)
        SqlDataAdapter2.Fill(objdsListaGruppi)
    End Sub

    Private Sub frmGruppi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        RefreshData()

        Call InitGruppo()

        DataViewArticoli = objdsListaArticoli.v01_articoli.DefaultView
        DataGridArticoli.DataSource = DataViewArticoli

        DataViewGruppi = objdsListaGruppi.v03_gruppi.DefaultView
        DataGridGruppi.DataSource = DataViewGruppi

        blnFormLoaded = True

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InitGruppo()

        mintIDArticoloCorrente = -1
        mintIDArticoloDaAggiungere = -1

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Me.txtCodArticolo.Text = ""
        Me.txtDescrizioneArticolo.Text = ""

        'dati inesistenti
        'mstrSQL = "SELECT * FROM t01_articoli INNER JOIN t02_articoli_gruppi "
        'mstrSQL = mstrSQL & "ON t01_id_articolo = t02_id_articolo_t01 WHERE "
        'mstrSQL = mstrSQL & "t02_id_gruppo_t03 = -9999 "
        'mstrSQL = mstrSQL & "ORDER BY t02_posizione"
        mstrSQL = "SELECT * FROM t20_articoli INNER JOIN t22_articoli_articoli "
        mstrSQL = mstrSQL & "ON t20_id_articolo = t22_id_articolo_t20 WHERE "
        mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = -9999 "
        mstrSQL = mstrSQL & "ORDER BY t22_posizione"

        objdsArticoliGruppi = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsArticoliGruppi.Tables(0).TableName = "t22_articoli_articoli"

        Me.DataGridArticoliGruppi.DataSource = objdsArticoliGruppi

        Me.DataGridArticoliGruppi.DataMember = "t22_articoli_articoli"

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnAddArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddArticolo.Click, DataGridArticoli.DoubleClick, DataGridGruppi.DoubleClick
        If Me.TabControl1.SelectedIndex = 0 Then
            Call AggiungiArticoli()
        Else
            Call AggiungiGruppi()
        End If
    End Sub

    Private Sub AggiungiArticoli()

        Dim intIDArticoloUpdate As Integer
        Dim intContatore As Integer = 0

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un articolo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intRowCount As Integer
        Dim strCodArticolo() As String
        Dim intContatoreArticoliGiaPresenti As Integer = -1

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If DataViewArticoli.Count > 0 Then

            For intRowCount = 0 To DataViewArticoli.Count - 1

                'solo se articolo sezionato tenta l'aggiunta
                If DataGridArticoli.IsSelected(intRowCount) Then
                    mintIDArticoloDaAggiungere = CType(DataGridArticoli.Item(intRowCount, 0), Integer)

                    If mintIDArticoloDaAggiungere = mintIDArticoloCorrente Then

                        mstrMsg = "Impossibile inserire un articolo come sottoarticolo di se stesso!"
                        MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        'controllo presenza articolo nell'articolo
                        If ArticoloGiaPresente(mintIDArticoloDaAggiungere, mintIDArticoloCorrente) Then

                            intContatoreArticoliGiaPresenti = intContatoreArticoliGiaPresenti + 1
                            ReDim Preserve strCodArticolo(intContatoreArticoliGiaPresenti)
                            strCodArticolo(intContatoreArticoliGiaPresenti) = DataGridArticoli.Item(intRowCount, 1)

                        ElseIf ArticoloConFigli(mintIDArticoloDaAggiungere, mintIDArticoloCorrente) Then

                            'Al fine di evitare un LOOP infinito non permetto l'aggiunta di
                            'un gruppo il quale abbia almeno un gruppo figlio (di qualsiasi livello)
                            'uguale al gruppo che si sta configurando

                            mstrMsg = "Impossibile inserire l'articolo in quanto esso ha almeno un articolo 'figlio' uguale all'articolo che si sta configurando!"
                            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else
                            'per ogni riga aggiorna la posizione
                            intContatore = 0
                            For Each dr As DataRow In objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows 't02_articoli_gruppi
                                intContatore = intContatore + 1
                                intIDArticoloUpdate = dr("t22_id_articolo_t20") 't02_id_articolo_t01

                                mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intContatore.ToString & " " 'UPDATE t02_articoli_gruppi SET t02_posizione = 
                                mstrSQL = mstrSQL & "WHERE t22_id_articolo_t20 = " & intIDArticoloUpdate.ToString & " AND " 'WHERE t02_id_articolo_t01 = 
                                mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03 = 

                                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                            Next

                            intContatore = intContatore + 1

                            mstrSQL = "INSERT INTO t22_articoli_articoli (t22_id_articolo_t20, t22_id_articolo_padre_t20, t22_posizione) VALUES (" 'INSERT INTO t02_articoli_gruppi (t02_id_articolo_t01, t02_id_gruppo_t03, t02_posizione) VALUES (
                            mstrSQL = mstrSQL & mintIDArticoloDaAggiungere.ToString & ", " & mintIDArticoloCorrente.ToString & ", " & intContatore.ToString & ")"
                            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                            Call CaricaDatiArticolo()

                        End If
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
            mstrMsg = mstrMsg & vbCrLf & "sono già presenti nel gruppo! Eventualmente modificarne il consumo!"
            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function ArticoloGiaPresente(ByVal intIDArticolo As Integer, ByVal intIDArticoloPadre As Integer) As Boolean

        mstrSQL = "SELECT * FROM t22_articoli_articoli WHERE " 'SELECT * FROM t02_articoli_gruppi WHERE 
        mstrSQL = mstrSQL & "t22_id_articolo_t20 = " & intIDArticolo.ToString & " AND " 't02_id_articolo_t01 = 
        mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & intIDArticoloPadre.ToString & " AND " 't02_id_gruppo_t03
        mstrSQL = mstrSQL & "t22_dt_cancellazione IS NULL" 't02_dt_cancellazione IS NULL

        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub AggiungiGruppi()

        Dim intIDArticoloUpdate As Integer
        Dim intContatore As Integer = 0

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un articolo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intRowCount As Integer
        Dim strCodGruppo() As String
        Dim intContatoreGruppiGiaPresenti As Integer = -1
        Dim blnIsGruppo As Boolean

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If objdsListaGruppi.v03_gruppi.Rows.Count > 0 Then

            For intRowCount = 0 To objdsListaGruppi.v03_gruppi.Rows.Count - 1

                'solo se gruppo sezionato tenta l'aggiunta
                If DataGridGruppi.IsSelected(intRowCount) Then
                    mintIDGruppoDaAggiungere = CType(DataGridGruppi.Item(intRowCount, 0), Integer)

                    If mintIDGruppoDaAggiungere = mintIDArticoloCorrente Then

                        mstrMsg = "Impossibile inserire un gruppo come sottogruppo di se stesso!"
                        MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else

                        'controllo presenza gruppo nel gruppo
                        If GruppoGiaPresente(mintIDGruppoDaAggiungere, mintIDArticoloCorrente) Then

                            intContatoreGruppiGiaPresenti = intContatoreGruppiGiaPresenti + 1
                            ReDim Preserve strCodGruppo(intContatoreGruppiGiaPresenti)
                            strCodGruppo(intContatoreGruppiGiaPresenti) = DataGridGruppi.Item(intRowCount, 1)

                        ElseIf GruppoConFigli(mintIDGruppoDaAggiungere, mintIDArticoloCorrente) Then

                            'Al fine di evitare un LOOP infinito non permetto l'aggiunta di
                            'un gruppo il quale abbia almeno un gruppo figlio (di qualsiasi livello)
                            'uguale al gruppo che si sta configurando

                            mstrMsg = "Impossibile inserire il gruppo in quanto esso ha almeno un articolo 'figlio' uguale all'articolo che si sta configurando!"
                            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

                        Else

                            'per ogni riga aggiorna la posizione
                            intContatore = 0
                            For Each dr As DataRow In objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows 't02_articoli_gruppi

                                'If dr("t02_is_gruppo") = 1 Then 'sottogruppo
                                '    blnIsGruppo = True
                                'Else    'articolo
                                '    blnIsGruppo = False
                                'End If
                                intContatore = intContatore + 1
                                intIDArticoloUpdate = dr("t22_id_articolo_t20") 't02_id_articolo_t01

                                mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intContatore.ToString & " " 'UPDATE t02_articoli_gruppi SET t02_posizione = 
                                'If blnIsGruppo Then
                                '    mstrSQL = mstrSQL & "WHERE t02_id_gruppo_figlio_t03 = " & intIDArticoloUpdate.ToString & " AND " 'WHERE t02_id_gruppo_figlio_t03 = 
                                'Else
                                mstrSQL = mstrSQL & "WHERE t22_id_articolo_t20 = " & intIDArticoloUpdate.ToString & " AND " 'WHERE t02_id_articolo_t01 = 
                                'End If
                                mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03 = 

                                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                            Next

                            intContatore = intContatore + 1

                            mstrSQL = "INSERT INTO t22_articoli_articoli (t22_id_articolo_t20, t22_id_articolo_padre_t20, t22_posizione) VALUES (" 'INSERT INTO t02_articoli_gruppi (t02_id_gruppo_figlio_t03, t02_id_gruppo_t03, t02_posizione) VALUES (
                            mstrSQL = mstrSQL & mintIDGruppoDaAggiungere.ToString & ", " & mintIDArticoloCorrente.ToString & ", " & intContatore.ToString & ")"
                            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                            Call CaricaDatiArticolo()

                        End If

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
            mstrMsg = mstrMsg & vbCrLf & "sono già presenti nell'articolo! Eventualmente modificarne il consumo!"
            MessageBox.Show(mstrMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function GruppoGiaPresente(ByVal intIDGruppoFiglio As Integer, ByVal intIDGruppo As Integer) As Boolean

        mstrSQL = "SELECT * FROM t02_articoli_gruppi WHERE "
        mstrSQL = mstrSQL & "t02_id_gruppo_figlio_t03 = " & intIDGruppoFiglio.ToString & " AND "
        mstrSQL = mstrSQL & "t02_id_gruppo_t03 = " & intIDGruppo.ToString & " AND "
        mstrSQL = mstrSQL & "t02_dt_cancellazione IS NULL"

        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function ArticoloConFigli(ByVal intIDArticoloPadre As Integer, ByVal intIDArticolo As Integer) As Boolean
        'Controlla se esiste almeno un articolo figlio di intIDArticoloPadre (di qualsiasi livello) uguale
        'all'articolo da configurare intIDArticolo
        Dim blnReturnValue As Boolean

        mstrSQL = "SELECT * FROM ufn_GetElencoSottoArticoli2(" & intIDArticoloPadre.ToString & ")"
        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            blnReturnValue = False
            While tmpDataReader.Read()
                If tmpDataReader("t22_id_articolo_t20") = intIDArticolo Then 't02_id_gruppo_figlio_t03
                    blnReturnValue = True
                    Exit While
                End If
            End While
            Return blnReturnValue
        Else
            'non ha gruppi "figlio"
            Return False
        End If

    End Function

    Private Function GruppoConFigli(ByVal intIDGruppoPadre As Integer, ByVal intIDGruppo As Integer) As Boolean
        'Controlla se esiste almeno un gruppo figlio di intIDGruppoPadre (di qualsiasi livello) uguale
        'al gruppo da configurare intIDGruppo
        Dim blnReturnValue As Boolean

        mstrSQL = "SELECT * FROM ufn_GetElencoSottoGruppi2(" & intIDGruppoPadre.ToString & ")"
        Dim tmpDataReader As System.Data.SqlClient.SqlDataReader = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)

        If tmpDataReader.HasRows Then
            blnReturnValue = False
            While tmpDataReader.Read()
                If tmpDataReader("t22_id_articolo_t20") = intIDGruppo Then 't02_id_gruppo_figlio_t03
                    blnReturnValue = True
                    Exit While
                End If
            End While
            Return blnReturnValue
        Else
            'non ha gruppi "figlio"
            Return False
        End If

    End Function

    Private Sub CaricaDatiArticolo()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'mstrSQL = ""
        'mstrSQL = mstrSQL & "SELECT 't02_id_articolo_t01' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "       WHEN t02_id_gruppo_figlio_t03 IS NULL THEN t02_id_articolo_t01"
        'mstrSQL = mstrSQL & "       ELSE t02_id_gruppo_figlio_t03"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "'t01_cod_articolo' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "		WHEN t02_id_gruppo_figlio_t03 IS NULL THEN t01_cod_articolo"
        'mstrSQL = mstrSQL & "       ELSE t03_cod_gruppo"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "'t01_descrizione' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "       WHEN t02_id_gruppo_figlio_t03 IS NULL THEN t01_descrizione"
        'mstrSQL = mstrSQL & "       ELSE t03_descrizione"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "'t02_is_gruppo' = "
        'mstrSQL = mstrSQL & "   CASE "
        'mstrSQL = mstrSQL & "       WHEN t02_id_gruppo_figlio_t03 IS NULL THEN 0"
        'mstrSQL = mstrSQL & "       ELSE 1"
        'mstrSQL = mstrSQL & "   END,"
        'mstrSQL = mstrSQL & "t02_consumo "
        'mstrSQL = mstrSQL & "   FROM ("
        'mstrSQL = mstrSQL & "SELECT * FROM (t01_articoli RIGHT JOIN t02_articoli_gruppi "
        'mstrSQL = mstrSQL & "ON t01_id_articolo = t02_id_articolo_t01) LEFT JOIN t03_gruppi "
        'mstrSQL = mstrSQL & "ON t02_id_gruppo_figlio_t03 = t03_id_gruppo  WHERE "
        'mstrSQL = mstrSQL & "t02_id_gruppo_t03 = " & mintIDArticoloCorrente.ToString & " "
        'mstrSQL = mstrSQL & ") AS TAB1 "
        'mstrSQL = mstrSQL & "ORDER BY t02_posizione"
        mstrSQL = ""
        mstrSQL = mstrSQL & "SELECT t22_id_articolo_t20, "
        mstrSQL = mstrSQL & "t20_cod_articolo, "
        mstrSQL = mstrSQL & "t20_descrizione, "
        mstrSQL = mstrSQL & "t20_is_gruppo, "
        mstrSQL = mstrSQL & "t22_consumo "
        mstrSQL = mstrSQL & " FROM ("
        mstrSQL = mstrSQL & "SELECT * FROM t20_articoli RIGHT JOIN t22_articoli_articoli "
        mstrSQL = mstrSQL & "ON t20_id_articolo = t22_id_articolo_t20 WHERE "
        mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString & " "
        mstrSQL = mstrSQL & ") AS TAB1 "
        mstrSQL = mstrSQL & "ORDER BY t22_posizione"

        objdsArticoliGruppi = ExecuteDataset(conn1.ConnectionString, CommandType.Text, mstrSQL)

        'rinomina la DataTable
        objdsArticoliGruppi.Tables(0).TableName = "t22_articoli_articoli" '"t02_articoli_gruppi"

        Me.DataGridArticoliGruppi.DataSource = objdsArticoliGruppi

        Me.DataGridArticoliGruppi.DataMember = "t22_articoli_articoli" '"t02_articoli_gruppi"
        Me.DataGridArticoliGruppi.TableStyles(0).MappingName = "t22_articoli_articoli" '"t02_articoli_gruppi"

        'TODO: Controllare ufn_GetSubtreeInProduzioneSospese
        ''CONTROLLO SE L'ARTICOLO APPARTIENE AD UNA MACCHINA 
        ''ISTANZIATA IN PRODUZIONE O SOSPESA
        'mstrSQL = "SELECT * FROM ufn_GetSubtreeInProduzioneSospese() WHERE "
        ''mstrSQL += "t02_id_gruppo_figlio_t03 = " & mintIDArticoloCorrente.ToString & " OR "
        ''mstrSQL += "t02_id_gruppo_t03 = " & mintIDArticoloCorrente.ToString
        mstrSQL = "SELECT * FROM ufn_GetSubtree2() WHERE "
        mstrSQL += "( t22_id_articolo_t20 = " & mintIDArticoloCorrente.ToString & " OR "
        mstrSQL += "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString & " )"
        mstrSQL += " AND (t06_id_stato_istanza_t07 = 'P' OR t06_id_stato_istanza_t07 = 'S')"

        Dim DRIstanze As SqlClient.SqlDataReader
        DRIstanze = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)
        If DRIstanze.HasRows Then
            MessageBox.Show("ATTENZIONE! L'articolo che si sta richiamando appartiene ad una macchina istanziata in produzione o sospesa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnRemoveArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveArticolo.Click
        Call RimuoviArticoli()
    End Sub

    Private Sub RimuoviArticoli()

        If MessageBox.Show("Confermi rimozione articoli/gruppi dal gruppo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un gruppo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intIDArticoloUpdate As Integer
        Dim intIDGruppoUpdate As Integer
        Dim intContatore As Integer = 0
        Dim intContatoreArticoliDaRimuovere As Integer = -1
        Dim intContatoreGruppiDaRimuovere As Integer = -1
        Dim intRowCount As Integer
        Dim blnIsGruppo As Boolean

        'vettore IDArticoli da rimuovere dal gruppo
        Dim intIDArticoliDaRimuovere() As Integer

        'vettore IDGruppi da rimuovere dal gruppo
        Dim intIDGruppiDaRimuovere() As Integer

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count > 0 Then 't02_articoli_gruppi

            For intRowCount = 0 To objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count - 1 't02_articoli_gruppi

                'determina ID da eliminare
                If DataGridArticoliGruppi.IsSelected(intRowCount) Then
                    'If objdsArticoliGruppi.Tables("t02_articoli_gruppi").Rows(intRowCount).Item("t02_is_gruppo") = 1 Then
                    '    blnIsGruppo = True
                    'Else
                    '    blnIsGruppo = False
                    'End If
                    'If blnIsGruppo Then 'sottogruppo
                    '    intContatoreGruppiDaRimuovere = intContatoreGruppiDaRimuovere + 1
                    '    ReDim Preserve intIDGruppiDaRimuovere(intContatoreGruppiDaRimuovere)
                    '    intIDGruppiDaRimuovere(intContatoreGruppiDaRimuovere) = CType(DataGridArticoliGruppi.Item(intRowCount, 0), Integer)
                    'Else    'articolo
                    intContatoreArticoliDaRimuovere = intContatoreArticoliDaRimuovere + 1
                    ReDim Preserve intIDArticoliDaRimuovere(intContatoreArticoliDaRimuovere)
                    intIDArticoliDaRimuovere(intContatoreArticoliDaRimuovere) = CType(DataGridArticoliGruppi.Item(intRowCount, 0), Integer)
                    'End If
                End If

            Next

            If Not (intIDArticoliDaRimuovere Is Nothing) Then
                For intContatore = 0 To intIDArticoliDaRimuovere.Length - 1
                    'effettua cancellazione
                    mstrSQL = "DELETE FROM t22_articoli_articoli WHERE t22_id_articolo_t20 = " 'DELETE FROM t02_articoli_gruppi WHERE t02_id_articolo_t01 = 
                    mstrSQL = mstrSQL & intIDArticoliDaRimuovere(intContatore).ToString & " AND "
                    mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
                Next
            End If

            'If Not (intIDGruppiDaRimuovere Is Nothing) Then
            '    For intContatore = 0 To intIDGruppiDaRimuovere.Length - 1
            '        'effettua cancellazione
            '        mstrSQL = "DELETE FROM t02_articoli_gruppi WHERE t02_id_gruppo_figlio_t03 = "
            '        mstrSQL = mstrSQL & intIDGruppiDaRimuovere(intContatore).ToString & " AND "
            '        mstrSQL = mstrSQL & "t02_id_gruppo_t03 = " & mintIDArticoloCorrente.ToString

            '        ExecuteNonQuery(conn.ConnectionString, CommandType.Text, mstrSQL)
            '    Next
            'End If

            Call CaricaDatiArticolo()

            'rinumera posizioni per record rimasti nel gruppo
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows 't02_articoli_gruppi
                'If dr("t02_is_gruppo") = 1 Then
                '    blnIsGruppo = True
                'Else
                '    blnIsGruppo = False
                'End If
                intContatore = intContatore + 1

                intIDArticoloUpdate = dr("t22_id_articolo_t20")

                mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intContatore.ToString & " " 'UPDATE t02_articoli_gruppi SET t02_posizione = 
                'If blnIsGruppo Then 'sottogruppo
                '    mstrSQL = mstrSQL & "WHERE t02_id_gruppo_figlio_t03 = " & intIDArticoloUpdate.ToString & " AND "
                'Else    'articolo
                mstrSQL = mstrSQL & "WHERE t22_id_articolo_t20 = " & intIDArticoloUpdate.ToString & " AND " 'WHERE t02_id_articolo_t01 = 
                'End If
                mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03 = 

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Next

            Call CaricaDatiArticolo()

        End If

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count > 0 Then 't02_articoli_gruppi
            DataGridArticoliGruppi.CurrentRowIndex = 0 'seleziona prima riga
        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub RicalcolaPosizioniArticolo()
        'Questa sub ricalcola il campo t02_posizione per evitare
        'problemi nello spostamento degli articoli (e degli eventuali gruppi)
        Dim intContatore As Integer
        Dim intIDArticoloUpdate As Integer
        Dim blnIsGruppo As Boolean

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count > 0 Then 't02_articoli_gruppi
            'per ogni riga aggiorna la posizione
            intContatore = 0
            For Each dr As DataRow In objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows 't02_articoli_gruppi
                'If dr("t02_is_gruppo") = 1 Then
                '    blnIsGruppo = True
                'Else
                '    blnIsGruppo = False
                'End If
                intContatore = intContatore + 1
                intIDArticoloUpdate = dr("t22_id_articolo_t20") 't02_id_articolo_t01

                mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intContatore.ToString & " " 'UPDATE t02_articoli_gruppi SET t02_posizione
                'If blnIsGruppo Then 'sottogruppo
                '    mstrSQL = mstrSQL & "WHERE t02_id_gruppo_figlio_t03 = " & intIDArticoloUpdate.ToString & " AND "
                'Else    'articolo
                mstrSQL = mstrSQL & "WHERE t22_id_articolo_t20 = " & intIDArticoloUpdate.ToString & " AND " 'WHERE t02_id_articolo_t01 = 
                'End If
                mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03

                ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)
            Next

        End If
    End Sub

    Private Sub btnSpostaSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaSu.Click

        Dim intPosizione As Integer

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un gruppo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count <= 0 Then 't02_articoli_gruppi
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'articolo selezionato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliGruppi.CurrentRowIndex + 1
        DataGridArticoliGruppi.Select(DataGridArticoliGruppi.CurrentRowIndex)

        If intPosizione > 1 Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = 999999 WHERE " 'UPDATE t02_articoli_gruppi SET t02_posizione = 999999 WHERE 
            mstrSQL = mstrSQL & "t22_posizione = " & (intPosizione - 1).ToString & " AND " 't02_posizione = 
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03 = 
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = t22_posizione - 1 WHERE " 'UPDATE t02_articoli_gruppi SET t02_posizione = t02_posizione - 1 WHERE 
            mstrSQL = mstrSQL & "t22_posizione = " & intPosizione.ToString & " AND " 't02_posizione
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intPosizione.ToString & " WHERE " 'UPDATE t02_articoli_gruppi SET t02_posizione = 
            mstrSQL = mstrSQL & "t22_posizione = 999999 AND " 't02_posizione = 999999 AND 
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString 't02_id_gruppo_t03
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiArticolo()
            Call RicalcolaPosizioniArticolo()
            DataGridArticoliGruppi.CurrentRowIndex = intPosizione - 2
            DataGridArticoliGruppi.Select(intPosizione - 2)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

        'Azzera sempre filtri
        Me.txtRicercaCodice.Text = ""
        Me.txtRicercaDescrizione.Text = ""

        If blnFormLoaded Then
            DataViewArticoli.RowFilter = ""
            DataViewGruppi.RowFilter = ""
        End If

    End Sub

    Private Sub ApplicaFiltri(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged, txtRicercaDescrizione.TextChanged
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = Me.txtRicercaCodice.Text
        strFiltroDescrizione = Me.txtRicercaDescrizione.Text

        If TabControl1.SelectedIndex = 0 Then
            If strFiltroCodice.Trim <> "" Then
                strFiltro = "t20_cod_articolo LIKE '*" & strFiltroCodice & "*' " 't01_cod_articolo
                If strFiltroDescrizione.Trim <> "" Then
                    strFiltro = strFiltro & "AND "
                    strFiltro = strFiltro & "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'" 't01_descrizione
                End If
            Else
                If strFiltroDescrizione.Trim <> "" Then
                    strFiltro = "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'" 't01_descrizione
                End If
            End If
            DataViewArticoli.RowFilter = strFiltro
        Else
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
        End If

    End Sub

    Private Sub btnSpostaGiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaGiu.Click

        Dim intPosizione As Integer

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un gruppo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count <= 0 Then
            MessageBox.Show("Nessun articolo memorizzato all'interno dell'articolo selezionato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        intPosizione = DataGridArticoliGruppi.CurrentRowIndex + 1
        DataGridArticoliGruppi.Select(DataGridArticoliGruppi.CurrentRowIndex)

        If intPosizione < objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count Then
            'clessidra
            Cursor.Current = Cursors.WaitCursor

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = 999999 WHERE "
            mstrSQL = mstrSQL & "t22_posizione = " & (intPosizione + 1).ToString & " AND "
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = t22_posizione + 1 WHERE "
            mstrSQL = mstrSQL & "t22_posizione = " & intPosizione.ToString & " AND "
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            mstrSQL = "UPDATE t22_articoli_articoli SET t22_posizione = " & intPosizione.ToString & " WHERE "
            mstrSQL = mstrSQL & "t22_posizione = 999999 AND "
            mstrSQL = mstrSQL & "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call CaricaDatiArticolo()
            Call RicalcolaPosizioniArticolo()
            DataGridArticoliGruppi.CurrentRowIndex = intPosizione
            DataGridArticoliGruppi.Select(intPosizione)

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub DataGridArticoliGruppi_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridArticoliGruppi.DoubleClick
        Dim blnIsGruppo As Boolean
        Dim intPosizione As Integer

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un gruppo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows.Count > 0 Then 't02_articoli_gruppi
            DataGridArticoliGruppi.Select(DataGridArticoliGruppi.CurrentRowIndex)
            Dim strConsumo, strConsumoDefault As String
            strConsumoDefault = DataGridArticoliGruppi.Item(DataGridArticoliGruppi.CurrentRowIndex, 3)
            intPosizione = DataGridArticoliGruppi.CurrentRowIndex

            strConsumo = InputBox("Inserire il consumo per l'articolo/gruppo selezionato :", Me.Text, strConsumoDefault)
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

                    'If objdsArticoliGruppi.Tables("t02_articoli_gruppi").Rows(DataGridArticoliGruppi.CurrentRowIndex).Item("t02_is_gruppo") = 1 Then
                    '    blnIsGruppo = True
                    'Else
                    '    blnIsGruppo = False
                    'End If

                    'If blnIsGruppo Then
                    mstrSQL = "UPDATE t22_articoli_articoli SET t22_consumo = " & strConsumo.Trim & ", " 'UPDATE t02_articoli_gruppi SET t02_consumo = 
                    mstrSQL = mstrSQL & "t22_dt_modifica = GetDate() " 't02_dt_modifica = GetDate() 
                    mstrSQL = mstrSQL & "WHERE t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString & " AND " 'WHERE t02_id_gruppo_t03 = 
                    mstrSQL = mstrSQL & "t22_id_articolo_t20 = " & objdsArticoliGruppi.Tables("t22_articoli_articoli").Rows(DataGridArticoliGruppi.CurrentRowIndex).Item("t22_id_articolo_t20").ToString 't02_id_gruppo_figlio_t03 =  't02_articoli_gruppi t02_id_articolo_t01
                    'Else
                    '    mstrSQL = "UPDATE t02_articoli_gruppi SET t02_consumo = " & strConsumo.Trim & ", "
                    '    mstrSQL = mstrSQL & "t02_dt_modifica = GetDate() "
                    '    mstrSQL = mstrSQL & "WHERE t02_id_gruppo_t03 = " & mintIDArticoloCorrente.ToString & " AND "
                    '    mstrSQL = mstrSQL & "t02_id_articolo_t01 = " & objdsArticoliGruppi.Tables("t02_articoli_gruppi").Rows(DataGridArticoliGruppi.CurrentRowIndex).Item("t02_id_articolo_t01").ToString
                    'End If

                    ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

                    Call CaricaDatiArticolo()
                    DataGridArticoliGruppi.CurrentRowIndex = intPosizione
                    DataGridArticoliGruppi.Select(intPosizione)

                    'default
                    Cursor.Current = Cursors.Default

                End If
            End If
        End If
    End Sub

    Private Sub btnNuovoGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoGruppo.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'Dim FormInsGruppo As New frmInsGruppoMacchina
        'FormInsGruppo.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Gruppo
        'FormInsGruppo.TipoInserimento = frmInsGruppoMacchina.TInserimento.Nuovo
        'FormInsGruppo.ConnectionString = conn.ConnectionString
        'FormInsGruppo.ShowDialog()

        Dim FormInsArticolo As New frmAnagraficaArticoli
        'FormInsArticolo.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Gruppo
        'FormInsArticolo.TipoInserimento = frmInsGruppoMacchina.TInserimento.Nuovo
        'FormInsArticolo.ConnectionString = conn.ConnectionString
        FormInsArticolo.ShowDialog()

        RefreshData()
    End Sub

    Private Sub btnModificaGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaGruppo.Click

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un articolo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'Dim FormInsGruppo As New frmInsGruppoMacchina
        'FormInsGruppo.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Gruppo
        'FormInsGruppo.TipoInserimento = frmInsGruppoMacchina.TInserimento.Variazione
        'FormInsGruppo.ID = mintIDArticoloCorrente
        'FormInsGruppo.ConnectionString = conn.ConnectionString
        'FormInsGruppo.ShowDialog()

        Dim FormInsArticolo As New frmAnagraficaArticoli
        'FormInsArticolo.TipoAnagrafica = frmInsGruppoMacchina.TAnagrafica.Gruppo
        'FormInsArticolo.TipoInserimento = frmInsGruppoMacchina.TInserimento.Nuovo
        'FormInsArticolo.ConnectionString = conn.ConnectionString
        FormInsArticolo.IDArticolo = mintIDArticoloCorrente
        FormInsArticolo.ShowDialog()

        'TODO: caricare i dati dopo modifica
        'Me.txtCodArticolo.Text = FormInsArticolo.Codice
        'Me.txtDescrizioneArticolo.Text = FormInsArticolo.Descrizione

        RefreshData()
    End Sub

    Private Sub btnEliminaGruppo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaGruppo.Click

        If mintIDArticoloCorrente = -1 Then
            MessageBox.Show("Scegliere prima un articolo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi eliminazione articolo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim DRControlloMacchine As SqlClient.SqlDataReader
            Dim DRControlloGruppi As SqlClient.SqlDataReader

            'un gruppo non è eliminabile se fa parte di una macchina non eliminata
            'oppure di un altro gruppo non eliminato

            'CONTROLLO SU MACCHINE
            'mstrSQL = ""
            'mstrSQL += "SELECT * FROM t03_gruppi INNER JOIN t04_gruppi_macchine ON "
            'mstrSQL += "t03_id_gruppo = t04_id_gruppo_t03 INNER JOIN t05_macchine ON "
            'mstrSQL += "t04_id_macchina_t05 = t05_id_macchina WHERE t05_dt_cancellazione IS NULL AND "
            'mstrSQL += "t04_dt_cancellazione IS NULL AND "
            'mstrSQL += "t03_id_gruppo = " & mintIDArticoloCorrente.ToString
            mstrSQL = ""
            mstrSQL += "SELECT * FROM t20_articoli INNER JOIN t21_articoli_macchine ON "
            mstrSQL += "t20_id_articolo = t21_id_articolo_t20 INNER JOIN t05_macchine ON "
            mstrSQL += "t21_id_macchina_t05 = t05_id_macchina WHERE t05_dt_cancellazione IS NULL AND "
            mstrSQL += "t21_dt_cancellazione IS NULL AND "
            mstrSQL += "t20_id_articolo = " & mintIDArticoloCorrente.ToString

            DRControlloMacchine = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)
            If DRControlloMacchine.HasRows Then
                MessageBox.Show("Impossibile eliminare il gruppo perchè appartiene almeno ad una macchina!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'CONTROLLO SU GRUPPI (EVENTUALI PADRI)
            'IL GRUPPO E' FIGLIO DI QUALCUNO?
            'mstrSQL = ""
            'mstrSQL += "SELECT * FROM t02_articoli_gruppi "
            'mstrSQL += "WHERE t02_dt_cancellazione IS NULL AND "
            'mstrSQL += "t02_id_gruppo_figlio_t03 = " & mintIDArticoloCorrente.ToString
            mstrSQL = ""
            mstrSQL += "SELECT * FROM t22_articoli_articoli "
            mstrSQL += "WHERE t22_dt_cancellazione IS NULL AND "
            mstrSQL += "t22_id_articolo_t20 = " & mintIDArticoloCorrente.ToString

            DRControlloGruppi = ExecuteReader(conn1.ConnectionString, CommandType.Text, mstrSQL)
            If DRControlloGruppi.HasRows Then
                MessageBox.Show("Impossibile eliminare l'articolo perchè appartiene almeno ad un altro gruppo o articolo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'mstrSQL = "UPDATE t03_gruppi SET t03_dt_cancellazione = GetDate() WHERE t03_id_gruppo = " & mintIDArticoloCorrente.ToString
            mstrSQL = "UPDATE t20_articoli SET t20_dt_cancellazione = GetDate() WHERE t20_id_articolo = " & mintIDArticoloCorrente.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            'A catena "elimina" gli eventuali record presenti sulla t02_articoli_gruppi
            'mstrSQL = "UPDATE t02_articoli_gruppi SET t02_dt_cancellazione = GetDate() WHERE "
            'mstrSQL += "t02_id_gruppo_t03 = " & mintIDArticoloCorrente.ToString & " AND "
            'mstrSQL += "t02_dt_cancellazione IS NULL"
            mstrSQL = "UPDATE t22_articoli_articoli SET t22_dt_cancellazione = GetDate() WHERE "
            mstrSQL += "t22_id_articolo_padre_t20 = " & mintIDArticoloCorrente.ToString & " AND "
            mstrSQL += "t22_dt_cancellazione IS NULL"
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, mstrSQL)

            Call InitGruppo()

            RefreshData()
        End If

    End Sub

    Private Sub txtCodGruppo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArticolo.KeyDown
        If e.KeyValue = Keys.F9 Then
            Call btnSceltaGruppo_Click(txtCodArticolo, Nothing)
        ElseIf e.KeyValue = Keys.F10 Then
            Call btnNuovoGruppo_Click(txtCodArticolo, Nothing)
        End If
    End Sub

End Class
