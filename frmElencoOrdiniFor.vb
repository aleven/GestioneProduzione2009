Imports Microsoft.ApplicationBlocks.Data

Public Class frmElencoOrdiniFor
    Inherits Form

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
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents chkEvasi As System.Windows.Forms.CheckBox
    Friend WithEvents chkAperti As System.Windows.Forms.CheckBox
    Friend WithEvents IDOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StatoOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridElencoOrdini As System.Windows.Forms.DataGrid
    Friend WithEvents DescrFornitore As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CodiceOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataConsegna As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dat15_causali_ordini_for As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaCausali As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents DataViewCausali As System.Data.DataView
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAnno As System.Windows.Forms.ComboBox
    Friend WithEvents daviewTestateOrdiniConStato As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents objdsElencoOrdiniConStato As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents dvviewTestateOrdiniConStato As System.Data.DataView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CausaleOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElencoOrdiniFor))
        Me.DataGridElencoOrdini = New System.Windows.Forms.DataGrid
        Me.dvviewTestateOrdiniConStato = New System.Data.DataView
        Me.objdsElencoOrdiniConStato = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.IDOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataConsegna = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CodiceOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrFornitore = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.StatoOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CausaleOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.chkEvasi = New System.Windows.Forms.CheckBox
        Me.chkAperti = New System.Windows.Forms.CheckBox
        Me.daviewTestateOrdiniConStato = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbCausale = New System.Windows.Forms.ComboBox
        Me.DataViewCausali = New System.Data.DataView
        Me.objdsListaCausali = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.Label2 = New System.Windows.Forms.Label
        Me.dat15_causali_ordini_for = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.cmbAnno = New System.Windows.Forms.ComboBox
        CType(Me.DataGridElencoOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvviewTestateOrdiniConStato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsElencoOrdiniConStato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridElencoOrdini
        '
        Me.DataGridElencoOrdini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridElencoOrdini.BackColor = System.Drawing.Color.Lavender
        Me.DataGridElencoOrdini.CaptionVisible = False
        Me.DataGridElencoOrdini.DataMember = ""
        Me.DataGridElencoOrdini.DataSource = Me.dvviewTestateOrdiniConStato
        Me.DataGridElencoOrdini.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridElencoOrdini.Location = New System.Drawing.Point(8, 40)
        Me.DataGridElencoOrdini.Name = "DataGridElencoOrdini"
        Me.DataGridElencoOrdini.ReadOnly = True
        Me.DataGridElencoOrdini.Size = New System.Drawing.Size(888, 368)
        Me.DataGridElencoOrdini.TabIndex = 4
        Me.DataGridElencoOrdini.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'dvviewTestateOrdiniConStato
        '
        Me.dvviewTestateOrdiniConStato.AllowDelete = False
        Me.dvviewTestateOrdiniConStato.AllowEdit = False
        Me.dvviewTestateOrdiniConStato.AllowNew = False
        Me.dvviewTestateOrdiniConStato.Table = Me.objdsElencoOrdiniConStato.viewTestateOrdiniConStato
        '
        'objdsElencoOrdiniConStato
        '
        Me.objdsElencoOrdiniConStato.DataSetName = "dsElencoOrdiniConStato"
        Me.objdsElencoOrdiniConStato.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsElencoOrdiniConStato.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridElencoOrdini
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.IDOrdine, Me.DataOrdine, Me.DataConsegna, Me.CodiceOrdine, Me.DescrFornitore, Me.DescrOrdine, Me.StatoOrdine, Me.CausaleOrdine})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "viewTestateOrdiniConStato"
        '
        'IDOrdine
        '
        Me.IDOrdine.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.IDOrdine.Format = ""
        Me.IDOrdine.FormatInfo = Nothing
        Me.IDOrdine.HeaderText = "Nr. Ordine"
        Me.IDOrdine.MappingName = "t08_id_testata_ordine_for"
        Me.IDOrdine.NullText = "0"
        Me.IDOrdine.Width = 0
        '
        'DataOrdine
        '
        Me.DataOrdine.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataOrdine.Format = "dd/MM/yyyy"
        Me.DataOrdine.FormatInfo = Nothing
        Me.DataOrdine.HeaderText = "Data Ordine"
        Me.DataOrdine.MappingName = "t08_dt_ordine"
        Me.DataOrdine.NullText = "  /  /    "
        Me.DataOrdine.Width = 75
        '
        'DataConsegna
        '
        Me.DataConsegna.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataConsegna.Format = "dd/MM/yyyy"
        Me.DataConsegna.FormatInfo = Nothing
        Me.DataConsegna.HeaderText = "Data Consegna"
        Me.DataConsegna.MappingName = "t08_dt_consegna"
        Me.DataConsegna.NullText = "  /  /    "
        Me.DataConsegna.Width = 75
        '
        'CodiceOrdine
        '
        Me.CodiceOrdine.Format = ""
        Me.CodiceOrdine.FormatInfo = Nothing
        Me.CodiceOrdine.HeaderText = "Numero"
        Me.CodiceOrdine.MappingName = "t08_cod_testata_ordine_for"
        Me.CodiceOrdine.Width = 75
        '
        'DescrFornitore
        '
        Me.DescrFornitore.Format = ""
        Me.DescrFornitore.FormatInfo = Nothing
        Me.DescrFornitore.HeaderText = "Fornitore"
        Me.DescrFornitore.MappingName = "t11_descrizione"
        Me.DescrFornitore.NullText = ""
        Me.DescrFornitore.Width = 200
        '
        'DescrOrdine
        '
        Me.DescrOrdine.Format = ""
        Me.DescrOrdine.FormatInfo = Nothing
        Me.DescrOrdine.HeaderText = "Descrizione"
        Me.DescrOrdine.MappingName = "t08_descrizione"
        Me.DescrOrdine.NullText = ""
        Me.DescrOrdine.Width = 300
        '
        'StatoOrdine
        '
        Me.StatoOrdine.Format = ""
        Me.StatoOrdine.FormatInfo = Nothing
        Me.StatoOrdine.HeaderText = "Stato"
        Me.StatoOrdine.MappingName = "t08_stato_testata_ordine_for"
        Me.StatoOrdine.NullText = ""
        Me.StatoOrdine.Width = 75
        '
        'CausaleOrdine
        '
        Me.CausaleOrdine.Format = ""
        Me.CausaleOrdine.FormatInfo = Nothing
        Me.CausaleOrdine.HeaderText = "Causale"
        Me.CausaleOrdine.MappingName = "t15_descrizione"
        Me.CausaleOrdine.Width = 75
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(800, 416)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 5
        Me.btnChiudi.Text = "&Chiudi"
        '
        'chkEvasi
        '
        Me.chkEvasi.Location = New System.Drawing.Point(88, 10)
        Me.chkEvasi.Name = "chkEvasi"
        Me.chkEvasi.Size = New System.Drawing.Size(81, 24)
        Me.chkEvasi.TabIndex = 8
        Me.chkEvasi.Text = "EVASI"
        '
        'chkAperti
        '
        Me.chkAperti.Checked = True
        Me.chkAperti.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAperti.Location = New System.Drawing.Point(18, 10)
        Me.chkAperti.Name = "chkAperti"
        Me.chkAperti.Size = New System.Drawing.Size(78, 24)
        Me.chkAperti.TabIndex = 6
        Me.chkAperti.Text = "APERTI"
        '
        'daviewTestateOrdiniConStato
        '
        Me.daviewTestateOrdiniConStato.InsertCommand = Me.SqlInsertCommand1
        Me.daviewTestateOrdiniConStato.SelectCommand = Me.SqlSelectCommand1
        Me.daviewTestateOrdiniConStato.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "viewTestateOrdiniConStato", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t08_id_testata_ordine_for", "t08_id_testata_ordine_for"), New System.Data.Common.DataColumnMapping("t08_cod_testata_ordine_for", "t08_cod_testata_ordine_for"), New System.Data.Common.DataColumnMapping("t08_descrizione", "t08_descrizione"), New System.Data.Common.DataColumnMapping("t08_id_fornitore_t11", "t08_id_fornitore_t11"), New System.Data.Common.DataColumnMapping("t08_dt_ordine", "t08_dt_ordine"), New System.Data.Common.DataColumnMapping("t08_dt_consegna", "t08_dt_consegna"), New System.Data.Common.DataColumnMapping("t08_tipo_ordine", "t08_tipo_ordine"), New System.Data.Common.DataColumnMapping("t08_id_causale_ordine_for_t15", "t08_id_causale_ordine_for_t15"), New System.Data.Common.DataColumnMapping("t08_dt_creazione", "t08_dt_creazione"), New System.Data.Common.DataColumnMapping("t08_dt_modifica", "t08_dt_modifica"), New System.Data.Common.DataColumnMapping("t08_dt_cancellazione", "t08_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t15_id_causale_ordine_for", "t15_id_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_cod_causale_ordine_for", "t15_cod_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_descrizione", "t15_descrizione"), New System.Data.Common.DataColumnMapping("t15_tipo_azione", "t15_tipo_azione"), New System.Data.Common.DataColumnMapping("t15_dt_creazione", "t15_dt_creazione"), New System.Data.Common.DataColumnMapping("t15_dt_modifica", "t15_dt_modifica"), New System.Data.Common.DataColumnMapping("t15_dt_cancellazione", "t15_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t11_id_fornitore", "t11_id_fornitore"), New System.Data.Common.DataColumnMapping("t11_cod_fornitore", "t11_cod_fornitore"), New System.Data.Common.DataColumnMapping("t11_descrizione", "t11_descrizione"), New System.Data.Common.DataColumnMapping("t11_telefono", "t11_telefono"), New System.Data.Common.DataColumnMapping("t11_note", "t11_note"), New System.Data.Common.DataColumnMapping("t11_dt_creazione", "t11_dt_creazione"), New System.Data.Common.DataColumnMapping("t11_dt_modifica", "t11_dt_modifica"), New System.Data.Common.DataColumnMapping("t11_dt_cancellazione", "t11_dt_cancellazione"), New System.Data.Common.DataColumnMapping("ANNO", "ANNO"), New System.Data.Common.DataColumnMapping("t08_stato_testata_ordine_for", "t08_stato_testata_ordine_for")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t08_id_testata_ordine_for", System.Data.SqlDbType.Int, 4, "t08_id_testata_ordine_for"), New System.Data.SqlClient.SqlParameter("@t08_cod_testata_ordine_for", System.Data.SqlDbType.VarChar, 20, "t08_cod_testata_ordine_for"), New System.Data.SqlClient.SqlParameter("@t08_descrizione", System.Data.SqlDbType.VarChar, 255, "t08_descrizione"), New System.Data.SqlClient.SqlParameter("@t08_id_fornitore_t11", System.Data.SqlDbType.Int, 4, "t08_id_fornitore_t11"), New System.Data.SqlClient.SqlParameter("@t08_dt_ordine", System.Data.SqlDbType.DateTime, 8, "t08_dt_ordine"), New System.Data.SqlClient.SqlParameter("@t08_dt_consegna", System.Data.SqlDbType.DateTime, 8, "t08_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t08_tipo_ordine", System.Data.SqlDbType.VarChar, 20, "t08_tipo_ordine"), New System.Data.SqlClient.SqlParameter("@t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 4, "t08_id_causale_ordine_for_t15"), New System.Data.SqlClient.SqlParameter("@t08_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t08_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t08_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t08_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t08_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t08_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, "t15_id_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, "t15_cod_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_descrizione", System.Data.SqlDbType.VarChar, 50, "t15_descrizione"), New System.Data.SqlClient.SqlParameter("@t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, "t15_tipo_azione"), New System.Data.SqlClient.SqlParameter("@t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t15_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@t11_id_fornitore", System.Data.SqlDbType.Int, 4, "t11_id_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_cod_fornitore", System.Data.SqlDbType.VarChar, 20, "t11_cod_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_descrizione", System.Data.SqlDbType.VarChar, 255, "t11_descrizione"), New System.Data.SqlClient.SqlParameter("@t11_telefono", System.Data.SqlDbType.VarChar, 20, "t11_telefono"), New System.Data.SqlClient.SqlParameter("@t11_note", System.Data.SqlDbType.VarChar, 2147483647, "t11_note"), New System.Data.SqlClient.SqlParameter("@t11_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t11_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t11_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t11_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@ANNO", System.Data.SqlDbType.Int, 4, "ANNO"), New System.Data.SqlClient.SqlParameter("@t08_stato_testata_ordine_for", System.Data.SqlDbType.VarChar, 6, "t08_stato_testata_ordine_for")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(736, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Anno"
        '
        'cmbCausale
        '
        Me.cmbCausale.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCausale.DataSource = Me.DataViewCausali
        Me.cmbCausale.DisplayMember = "t15_descrizione"
        Me.cmbCausale.Location = New System.Drawing.Point(490, 8)
        Me.cmbCausale.Name = "cmbCausale"
        Me.cmbCausale.Size = New System.Drawing.Size(240, 21)
        Me.cmbCausale.TabIndex = 12
        Me.cmbCausale.ValueMember = "t15_id_causale_ordine_for"
        '
        'DataViewCausali
        '
        Me.DataViewCausali.Table = Me.objdsListaCausali.t15_causali_ordini_for
        '
        'objdsListaCausali
        '
        Me.objdsListaCausali.DataSetName = "dsListaCausali"
        Me.objdsListaCausali.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaCausali.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(442, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Causale"
        '
        'dat15_causali_ordini_for
        '
        Me.dat15_causali_ordini_for.DeleteCommand = Me.SqlDeleteCommand1
        Me.dat15_causali_ordini_for.InsertCommand = Me.SqlInsertCommand2
        Me.dat15_causali_ordini_for.SelectCommand = Me.SqlSelectCommand2
        Me.dat15_causali_ordini_for.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t15_causali_ordini_for", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t15_id_causale_ordine_for", "t15_id_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_cod_causale_ordine_for", "t15_cod_causale_ordine_for"), New System.Data.Common.DataColumnMapping("t15_descrizione", "t15_descrizione"), New System.Data.Common.DataColumnMapping("t15_tipo_azione", "t15_tipo_azione"), New System.Data.Common.DataColumnMapping("t15_dt_creazione", "t15_dt_creazione"), New System.Data.Common.DataColumnMapping("t15_dt_modifica", "t15_dt_modifica"), New System.Data.Common.DataColumnMapping("t15_dt_cancellazione", "t15_dt_cancellazione")})})
        Me.dat15_causali_ordini_for.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_id_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_cod_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_tipo_azione", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, "t15_cod_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_descrizione", System.Data.SqlDbType.VarChar, 50, "t15_descrizione"), New System.Data.SqlClient.SqlParameter("@t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, "t15_tipo_azione"), New System.Data.SqlClient.SqlParameter("@t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t15_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_cancellazione")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.conn1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, "t15_cod_causale_ordine_for"), New System.Data.SqlClient.SqlParameter("@t15_descrizione", System.Data.SqlDbType.VarChar, 50, "t15_descrizione"), New System.Data.SqlClient.SqlParameter("@t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, "t15_tipo_azione"), New System.Data.SqlClient.SqlParameter("@t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t15_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t15_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_id_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_cod_causale_ordine_for", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_cod_causale_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_descrizione", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t15_tipo_azione", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t15_tipo_azione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t15_id_causale_ordine_for", System.Data.SqlDbType.Int, 4, "t15_id_causale_ordine_for")})
        '
        'cmbAnno
        '
        Me.cmbAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnno.Location = New System.Drawing.Point(771, 8)
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnno.TabIndex = 13
        '
        'frmElencoOrdiniFor
        '
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(904, 454)
        Me.Controls.Add(Me.chkEvasi)
        Me.Controls.Add(Me.chkAperti)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.DataGridElencoOrdini)
        Me.Controls.Add(Me.cmbAnno)
        Me.Controls.Add(Me.cmbCausale)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmElencoOrdiniFor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco Ordini di Acquisto"
        CType(Me.DataGridElencoOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvviewTestateOrdiniConStato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsElencoOrdiniConStato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewCausali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaCausali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_Ricerca As Boolean
    Private m_SQL As String
    Private m_IDOrdine_Cercato As Integer

    Private m_EventCanFire As Boolean = False
    Private CliccatoSuFiltri As Boolean = False

    Public Property Ricerca() As Boolean
        Get
            Return m_Ricerca
        End Get
        Set(ByVal Value As Boolean)
            m_Ricerca = Value
        End Set
    End Property

    Public Property IDOrdine_Cercato() As Integer
        Get
            Return m_IDOrdine_Cercato
        End Get
        Set(ByVal Value As Integer)
            m_IDOrdine_Cercato = Value
        End Set
    End Property

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub frmElencoOrdini_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        daviewTestateOrdiniConStato.Fill(objdsElencoOrdiniConStato)

        ' Caricamento elenco Causali
        dat15_causali_ordini_for.Fill(objdsListaCausali)
        'DataViewCausali = objdsListaCausali.t15_causali_ordini_for.DefaultView()
        'DataViewCausali.Sort = "t15_descrizione asc"
        'Me.cmbCausale.DataSource = DataViewCausali
        'Me.cmbCausale.DisplayMember = "t15_descrizione"
        'Me.cmbCausale.ValueMember = "t15_id_causale_ordine_for"

        ' Caricamento elenco ANNO
        m_SQL = "SELECT DISTINCT(YEAR(t08_dt_ordine)) AS Anno FROM t08_testate_ordini_for ORDER BY 1"
        Dim ds As DataSet
        ds = SqlHelper.ExecuteDataset(conn1.ConnectionString, CommandType.Text, m_SQL)
        cmbAnno.DataSource = ds.Tables(0)
        cmbAnno.DisplayMember = "Anno"
        cmbAnno.ValueMember = "Anno"

        m_EventCanFire = True
        cmbAnno.SelectedValue = DateTime.Now.Year.ToString

        'Se si tratta di una ricerca vengono visualizzati solo gli ordini ancora aperti
        'Infatti la ricerca è richiamabile solo per l'evasione ordini
        If m_Ricerca Then
            Me.chkEvasi.Enabled = False
            m_IDOrdine_Cercato = -1
        End If

        Call ApplicaFiltri()

    End Sub

    Private Sub ApplicaFiltri()
        Dim strFiltro As String = ""

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If chkAperti.Checked Then
            strFiltro = "t08_stato_testata_ordine_for = 'APERTO'"
        End If
        If chkEvasi.Checked Then
            If strFiltro.Trim <> "" Then
                strFiltro = strFiltro & " OR "
            End If
            strFiltro = "(" & strFiltro & "t08_stato_testata_ordine_for = 'EVASO'" & ")"
        End If

        'Se il filtro è nullo significa che non c'è nessun spunto!
        'Perciò viene impostato un filtro "IMPOSSIBILE" fittizio al
        'fine di non visualizzare nessun dato sul datagrid
        If strFiltro.Trim = "" Then
            strFiltro = "t08_stato_testata_ordine_for = '@@@@@@'"
        End If

        If CliccatoSuFiltri Then
            If cmbCausale.SelectedIndex <> -1 Then
                Dim rowView As DataRowView = CType(cmbCausale.SelectedItem, DataRowView)
                Dim value As String = CType(rowView.Row(cmbCausale.ValueMember), String)
                If strFiltro.Trim <> "" Then
                    strFiltro = strFiltro & " AND "
                End If
                strFiltro = strFiltro & " t08_id_causale_ordine_for_t15 = '" + value + "'"
            End If
        End If

        If cmbAnno.SelectedIndex <> -1 Then
            Dim rowView As DataRowView = CType(cmbAnno.SelectedItem, DataRowView)
            Dim value As String = CType(rowView.Row(cmbAnno.ValueMember), String)
            If strFiltro.Trim <> "" Then
                strFiltro = strFiltro & " AND "
            End If
            strFiltro = strFiltro & " ANNO = " + value
        End If

        dvviewTestateOrdiniConStato.RowFilter = strFiltro

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub DataGridElencoOrdini_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridElencoOrdini.DoubleClick
        Dim intIDOrdine As Integer

        intIDOrdine = CType(DataGridElencoOrdini.Item(DataGridElencoOrdini.CurrentRowIndex, 0), Integer)

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If m_Ricerca Then

            m_IDOrdine_Cercato = intIDOrdine
            Me.Close()

        Else

            Dim FormOrdiniFor As New frmOrdiniFor
            FormOrdiniFor.IDOrdine = intIDOrdine
            FormOrdiniFor.ShowDialog()

            'RIPOPOLA IL DATASET, APPLICA I FILTRI E RIPOSIZIONE PUNTATORE
            objdsElencoOrdiniConStato.Clear()
            daviewTestateOrdiniConStato.Fill(objdsElencoOrdiniConStato)
            Call ApplicaFiltri()

        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub On_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAperti.CheckedChanged, chkEvasi.CheckedChanged
        Call ApplicaFiltri()
    End Sub

    Private Sub cmbCausale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausale.SelectedIndexChanged
        If m_EventCanFire Then Call ApplicaFiltri()
    End Sub

    Private Sub cmbAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnno.SelectedIndexChanged
        If m_EventCanFire Then Call ApplicaFiltri()
    End Sub

    Private Sub cmbCausale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausale.Click
        CliccatoSuFiltri = True
    End Sub

    Private Sub cmbAnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnno.Click
        CliccatoSuFiltri = True
    End Sub
End Class
