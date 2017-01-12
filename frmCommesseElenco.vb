Imports Microsoft.ApplicationBlocks.Data.SqlHelper
Imports GestioneProduzione2014GinuxImport

Public Class frmCommesseElenco
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
    Friend WithEvents chkInProduzione As System.Windows.Forms.CheckBox
    Friend WithEvents chkChiuse As System.Windows.Forms.CheckBox
    Friend WithEvents chkSospese As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnnullate As System.Windows.Forms.CheckBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Private WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataGridElencoIstanze As System.Windows.Forms.DataGrid
    Friend WithEvents DataViewElencoIstanze As System.Data.DataView
    Friend WithEvents objdsElencoIstanzeSemplice As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataConsegna As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrIstanza As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CodMacchina As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrMacchina As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Quantita As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StatoIstanza As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuChiudi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSospendi As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAnnulla As System.Windows.Forms.MenuItem
    Friend WithEvents IDIstanza As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents IDStato As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents mnuInProduzione As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuElimina As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuStampa As System.Windows.Forms.MenuItem
    Friend WithEvents cmbAnno As System.Windows.Forms.ComboBox
    Friend WithEvents daviewElencoIstanzeSemplice As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataCreazione As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDMacchina As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommesseElenco))
        Me.chkInProduzione = New System.Windows.Forms.CheckBox
        Me.chkChiuse = New System.Windows.Forms.CheckBox
        Me.chkSospese = New System.Windows.Forms.CheckBox
        Me.chkAnnullate = New System.Windows.Forms.CheckBox
        Me.DataGridElencoIstanze = New System.Windows.Forms.DataGrid
        Me.DataViewElencoIstanze = New System.Data.DataView
        Me.objdsElencoIstanzeSemplice = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.IDIstanza = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataCreazione = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataConsegna = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrIstanza = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CodMacchina = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrMacchina = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Quantita = New System.Windows.Forms.DataGridTextBoxColumn
        Me.StatoIstanza = New System.Windows.Forms.DataGridTextBoxColumn
        Me.IDStato = New System.Windows.Forms.DataGridTextBoxColumn
        Me.IDMacchina = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.daviewElencoIstanzeSemplice = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuInProduzione = New System.Windows.Forms.MenuItem
        Me.mnuChiudi = New System.Windows.Forms.MenuItem
        Me.mnuSospendi = New System.Windows.Forms.MenuItem
        Me.mnuAnnulla = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuElimina = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mnuStampa = New System.Windows.Forms.MenuItem
        Me.cmbAnno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridElencoIstanze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataViewElencoIstanze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsElencoIstanzeSemplice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkInProduzione
        '
        Me.chkInProduzione.Checked = True
        Me.chkInProduzione.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkInProduzione.Location = New System.Drawing.Point(12, 10)
        Me.chkInProduzione.Name = "chkInProduzione"
        Me.chkInProduzione.Size = New System.Drawing.Size(120, 24)
        Me.chkInProduzione.TabIndex = 0
        Me.chkInProduzione.Text = "IN PRODUZIONE"
        '
        'chkChiuse
        '
        Me.chkChiuse.Location = New System.Drawing.Point(138, 10)
        Me.chkChiuse.Name = "chkChiuse"
        Me.chkChiuse.Size = New System.Drawing.Size(72, 24)
        Me.chkChiuse.TabIndex = 1
        Me.chkChiuse.Text = "CHIUSE"
        '
        'chkSospese
        '
        Me.chkSospese.Location = New System.Drawing.Point(216, 10)
        Me.chkSospese.Name = "chkSospese"
        Me.chkSospese.Size = New System.Drawing.Size(80, 24)
        Me.chkSospese.TabIndex = 2
        Me.chkSospese.Text = "SIMULATE"
        '
        'chkAnnullate
        '
        Me.chkAnnullate.Location = New System.Drawing.Point(302, 10)
        Me.chkAnnullate.Name = "chkAnnullate"
        Me.chkAnnullate.Size = New System.Drawing.Size(96, 24)
        Me.chkAnnullate.TabIndex = 3
        Me.chkAnnullate.Text = "SOSPENDI"
        '
        'DataGridElencoIstanze
        '
        Me.DataGridElencoIstanze.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridElencoIstanze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridElencoIstanze.CaptionVisible = False
        Me.DataGridElencoIstanze.DataMember = ""
        Me.DataGridElencoIstanze.DataSource = Me.DataViewElencoIstanze
        Me.DataGridElencoIstanze.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridElencoIstanze.Location = New System.Drawing.Point(8, 40)
        Me.DataGridElencoIstanze.Name = "DataGridElencoIstanze"
        Me.DataGridElencoIstanze.ReadOnly = True
        Me.DataGridElencoIstanze.Size = New System.Drawing.Size(888, 347)
        Me.DataGridElencoIstanze.TabIndex = 4
        Me.DataGridElencoIstanze.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataViewElencoIstanze
        '
        Me.DataViewElencoIstanze.AllowDelete = False
        Me.DataViewElencoIstanze.AllowEdit = False
        Me.DataViewElencoIstanze.AllowNew = False
        Me.DataViewElencoIstanze.Table = Me.objdsElencoIstanzeSemplice.viewElencoIstanzeSemplice
        '
        'objdsElencoIstanzeSemplice
        '
        Me.objdsElencoIstanzeSemplice.DataSetName = "dsElencoIstanzeSemplice"
        Me.objdsElencoIstanzeSemplice.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsElencoIstanzeSemplice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridElencoIstanze
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.IDIstanza, Me.DataCreazione, Me.DataConsegna, Me.DescrIstanza, Me.CodMacchina, Me.DescrMacchina, Me.Quantita, Me.StatoIstanza, Me.IDStato, Me.IDMacchina})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "viewElencoIstanzeSemplice"
        '
        'IDIstanza
        '
        Me.IDIstanza.Format = ""
        Me.IDIstanza.FormatInfo = Nothing
        Me.IDIstanza.HeaderText = "ID"
        Me.IDIstanza.MappingName = "t06_id_istanza_macchina"
        Me.IDIstanza.NullText = "0"
        Me.IDIstanza.Width = 0
        '
        'DataCreazione
        '
        Me.DataCreazione.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataCreazione.Format = "dd/MM/yyyy"
        Me.DataCreazione.FormatInfo = Nothing
        Me.DataCreazione.HeaderText = "Creazione"
        Me.DataCreazione.MappingName = "t06_dt_creazione"
        Me.DataCreazione.NullText = "  /  /    "
        Me.DataCreazione.Width = 90
        '
        'DataConsegna
        '
        Me.DataConsegna.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataConsegna.Format = "dd/MM/yyyy"
        Me.DataConsegna.FormatInfo = Nothing
        Me.DataConsegna.HeaderText = "Consegna"
        Me.DataConsegna.MappingName = "t06_dt_consegna"
        Me.DataConsegna.NullText = "  /  /    "
        Me.DataConsegna.Width = 90
        '
        'DescrIstanza
        '
        Me.DescrIstanza.Format = ""
        Me.DescrIstanza.FormatInfo = Nothing
        Me.DescrIstanza.HeaderText = "Descrizione"
        Me.DescrIstanza.MappingName = "t06_descrizione"
        Me.DescrIstanza.NullText = ""
        Me.DescrIstanza.Width = 200
        '
        'CodMacchina
        '
        Me.CodMacchina.Format = ""
        Me.CodMacchina.FormatInfo = Nothing
        Me.CodMacchina.HeaderText = "Codice Macchina"
        Me.CodMacchina.MappingName = "t05_cod_macchina"
        Me.CodMacchina.NullText = ""
        Me.CodMacchina.Width = 150
        '
        'DescrMacchina
        '
        Me.DescrMacchina.Format = ""
        Me.DescrMacchina.FormatInfo = Nothing
        Me.DescrMacchina.HeaderText = "Descrizione Macchina"
        Me.DescrMacchina.MappingName = "t05_descrizione"
        Me.DescrMacchina.NullText = ""
        Me.DescrMacchina.Width = 200
        '
        'Quantita
        '
        Me.Quantita.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.Quantita.Format = ""
        Me.Quantita.FormatInfo = Nothing
        Me.Quantita.HeaderText = "Quantità"
        Me.Quantita.MappingName = "t06_quantita"
        Me.Quantita.NullText = "0"
        Me.Quantita.Width = 60
        '
        'StatoIstanza
        '
        Me.StatoIstanza.Format = ""
        Me.StatoIstanza.FormatInfo = Nothing
        Me.StatoIstanza.HeaderText = "Stato"
        Me.StatoIstanza.MappingName = "t07_descrizione"
        Me.StatoIstanza.NullText = ""
        Me.StatoIstanza.Width = 150
        '
        'IDStato
        '
        Me.IDStato.Format = ""
        Me.IDStato.FormatInfo = Nothing
        Me.IDStato.HeaderText = "ID Stato"
        Me.IDStato.MappingName = "t06_id_stato_istanza_t07"
        Me.IDStato.Width = 0
        '
        'IDMacchina
        '
        Me.IDMacchina.Format = ""
        Me.IDMacchina.FormatInfo = Nothing
        Me.IDMacchina.HeaderText = "ID Macchina"
        Me.IDMacchina.MappingName = "t05_id_macchina"
        Me.IDMacchina.Width = 0
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(800, 395)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 5
        Me.btnChiudi.Text = "&Chiudi"
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'daviewElencoIstanzeSemplice
        '
        Me.daviewElencoIstanzeSemplice.InsertCommand = Me.SqlInsertCommand1
        Me.daviewElencoIstanzeSemplice.SelectCommand = Me.SqlSelectCommand1
        Me.daviewElencoIstanzeSemplice.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "viewElencoIstanzeSemplice", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t06_id_istanza_macchina", "t06_id_istanza_macchina"), New System.Data.Common.DataColumnMapping("t06_descrizione", "t06_descrizione"), New System.Data.Common.DataColumnMapping("t06_dt_consegna", "t06_dt_consegna"), New System.Data.Common.DataColumnMapping("t06_id_macchina_t05", "t06_id_macchina_t05"), New System.Data.Common.DataColumnMapping("t06_quantita", "t06_quantita"), New System.Data.Common.DataColumnMapping("t06_id_stato_istanza_t07", "t06_id_stato_istanza_t07"), New System.Data.Common.DataColumnMapping("t06_dt_creazione", "t06_dt_creazione"), New System.Data.Common.DataColumnMapping("t06_dt_modifica", "t06_dt_modifica"), New System.Data.Common.DataColumnMapping("t06_dt_cancellazione", "t06_dt_cancellazione"), New System.Data.Common.DataColumnMapping("ANNO", "ANNO"), New System.Data.Common.DataColumnMapping("t07_id_stato_istanza", "t07_id_stato_istanza"), New System.Data.Common.DataColumnMapping("t07_descrizione", "t07_descrizione"), New System.Data.Common.DataColumnMapping("t07_posizione", "t07_posizione"), New System.Data.Common.DataColumnMapping("t07_dt_creazione", "t07_dt_creazione"), New System.Data.Common.DataColumnMapping("t07_dt_modifica", "t07_dt_modifica"), New System.Data.Common.DataColumnMapping("t07_dt_cancellazione", "t07_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t05_id_macchina", "t05_id_macchina"), New System.Data.Common.DataColumnMapping("t05_cod_macchina", "t05_cod_macchina"), New System.Data.Common.DataColumnMapping("t05_descrizione", "t05_descrizione"), New System.Data.Common.DataColumnMapping("t05_dt_creazione", "t05_dt_creazione"), New System.Data.Common.DataColumnMapping("t05_dt_modifica", "t05_dt_modifica"), New System.Data.Common.DataColumnMapping("t05_dt_cancellazione", "t05_dt_cancellazione")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.conn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t06_id_istanza_macchina", System.Data.SqlDbType.Int, 4, "t06_id_istanza_macchina"), New System.Data.SqlClient.SqlParameter("@t06_descrizione", System.Data.SqlDbType.VarChar, 255, "t06_descrizione"), New System.Data.SqlClient.SqlParameter("@t06_dt_consegna", System.Data.SqlDbType.DateTime, 8, "t06_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t06_id_macchina_t05", System.Data.SqlDbType.Int, 4, "t06_id_macchina_t05"), New System.Data.SqlClient.SqlParameter("@t06_quantita", System.Data.SqlDbType.SmallInt, 2, "t06_quantita"), New System.Data.SqlClient.SqlParameter("@t06_id_stato_istanza_t07", System.Data.SqlDbType.VarChar, 1, "t06_id_stato_istanza_t07"), New System.Data.SqlClient.SqlParameter("@t06_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t06_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t06_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t06_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t06_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t06_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@ANNO", System.Data.SqlDbType.Int, 4, "ANNO"), New System.Data.SqlClient.SqlParameter("@t07_id_stato_istanza", System.Data.SqlDbType.VarChar, 1, "t07_id_stato_istanza"), New System.Data.SqlClient.SqlParameter("@t07_descrizione", System.Data.SqlDbType.VarChar, 64, "t07_descrizione"), New System.Data.SqlClient.SqlParameter("@t07_posizione", System.Data.SqlDbType.TinyInt, 1, "t07_posizione"), New System.Data.SqlClient.SqlParameter("@t07_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t07_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t07_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t07_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t07_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t07_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@t05_id_macchina", System.Data.SqlDbType.Int, 4, "t05_id_macchina"), New System.Data.SqlClient.SqlParameter("@t05_cod_macchina", System.Data.SqlDbType.VarChar, 20, "t05_cod_macchina"), New System.Data.SqlClient.SqlParameter("@t05_descrizione", System.Data.SqlDbType.VarChar, 255, "t05_descrizione"), New System.Data.SqlClient.SqlParameter("@t05_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t05_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t05_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t05_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t05_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t05_dt_cancellazione")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuInProduzione, Me.mnuChiudi, Me.mnuSospendi, Me.mnuAnnulla, Me.MenuItem1, Me.mnuElimina, Me.MenuItem2, Me.mnuStampa})
        '
        'mnuInProduzione
        '
        Me.mnuInProduzione.Index = 0
        Me.mnuInProduzione.Text = "Metti In Produzione Commessa"
        '
        'mnuChiudi
        '
        Me.mnuChiudi.Index = 1
        Me.mnuChiudi.Text = "Chiudi Commessa"
        '
        'mnuSospendi
        '
        Me.mnuSospendi.Index = 2
        Me.mnuSospendi.Text = "Simula Commessa"
        '
        'mnuAnnulla
        '
        Me.mnuAnnulla.Index = 3
        Me.mnuAnnulla.Text = "Sospendi Commessa"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "-"
        '
        'mnuElimina
        '
        Me.mnuElimina.Index = 5
        Me.mnuElimina.Text = "Elimina Commessa"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.Text = "-"
        '
        'mnuStampa
        '
        Me.mnuStampa.Index = 7
        Me.mnuStampa.Text = "Stampa Commessa"
        '
        'cmbAnno
        '
        Me.cmbAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbAnno.Location = New System.Drawing.Point(771, 10)
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnno.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(733, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Anno"
        '
        'frmCommesseElenco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(904, 433)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.DataGridElencoIstanze)
        Me.Controls.Add(Me.chkAnnullate)
        Me.Controls.Add(Me.chkSospese)
        Me.Controls.Add(Me.chkChiuse)
        Me.Controls.Add(Me.chkInProduzione)
        Me.Controls.Add(Me.cmbAnno)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommesseElenco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco Commesse"
        CType(Me.DataGridElencoIstanze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataViewElencoIstanze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsElencoIstanzeSemplice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private m_SQL As String
    Private m_EventCanFire As Boolean = False
    Private CliccatoSuFiltri As Boolean = False

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub frmElencoIstanze_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)

        ' Caricamento elenco ANNO
        m_SQL = "SELECT DISTINCT(YEAR(t06_dt_creazione)) AS ANNO FROM t06_istanze_macchine ORDER BY 1 DESC"
        Dim ds As DataSet = ExecuteDataset(conn1.ConnectionString, CommandType.Text, m_SQL)
        cmbAnno.DataSource = ds.Tables(0)
        cmbAnno.DisplayMember = "ANNO"
        cmbAnno.ValueMember = "ANNO"

        m_EventCanFire = True
        cmbAnno.SelectedValue = DateTime.Now.Year.ToString

        Call ApplicaFiltri()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ApplicaFiltri()
        Dim strFiltro As String = ""

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If chkInProduzione.Checked Then
            strFiltro = "t06_id_stato_istanza_t07 = 'P'"
        End If
        If chkChiuse.Checked Then
            If strFiltro.Trim <> "" Then
                strFiltro = strFiltro & " OR "
            End If
            strFiltro = "(" & strFiltro & "t06_id_stato_istanza_t07 = 'C'" & ")"
        End If

        If chkSospese.Checked Then
            If strFiltro.Trim <> "" Then
                strFiltro = strFiltro & " OR "
            End If
            strFiltro = "(" & strFiltro & "t06_id_stato_istanza_t07 = 'S'" & ")"
        End If

        If chkAnnullate.Checked Then
            If strFiltro.Trim <> "" Then
                strFiltro = strFiltro & " OR "
            End If
            strFiltro = "(" & strFiltro & "t06_id_stato_istanza_t07 = 'A'" & ")"
        End If

        'Se il filtro è nullo significa che non c'è nessun spunto!
        'Perciò viene impostato un filtro "IMPOSSIBILE" fittizio al
        'fine di non visualizzare nessun dato sul datagrid
        If strFiltro.Trim = "" Then
            strFiltro = "t06_id_stato_istanza_t07 = 'P' AND t06_id_stato_istanza_t07 = 'C'"
        End If

        If CliccatoSuFiltri Then
            If cmbAnno.SelectedIndex <> -1 Then
                Dim rowView As DataRowView = CType(cmbAnno.SelectedItem, DataRowView)
                Dim value As String = CType(rowView.Row(cmbAnno.DisplayMember), String)
                If strFiltro.Trim <> "" Then
                    strFiltro = strFiltro & " AND "
                End If
                strFiltro = strFiltro & " ANNO = " + value
            End If
        End If

        DataViewElencoIstanze.RowFilter = strFiltro

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub On_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInProduzione.CheckedChanged, chkChiuse.CheckedChanged, chkSospese.CheckedChanged, chkAnnullate.CheckedChanged
        Call ApplicaFiltri()
    End Sub

#Region "Menù di contesto per azioni su istanze"

    Private Sub mnuChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChiudi.Click

        Dim strIDIstanza As String
        Dim strMsg As String
        Dim m_SQL_Articoli As String
        Dim sngQtDisponibile As Single
        Dim blnNonChiudere As Boolean

        strIDIstanza = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0).ToString()

        'MsgBox("Procedura da Aggiornare")
        'Exit Sub
        Dim dm As New DataModel()
        dm.Fill()
        dm.PreparaDati(Nothing)
        dm.ChiudiMacchina(Integer.Parse(strIDIstanza))

        'strMsg = "Confermi la chiusura della commessa ? " & vbCrLf & vbCrLf & "ATTENZIONE! "
        'strMsg += "Con la chiusura verranno aggiornate tutte le quantità a "
        'strMsg += "magazzino degli articoli che compongono la macchina!"

        'If MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

        '    'clessidra
        '    Cursor.Current = Cursors.WaitCursor

        '    'AGGIORNAMENTO QUANTITA' ARTICOLI
        '    'NOTA: MESSO PRIMA DEL CAMBIO STATO IN QUANTO ESSO DETERMINA SE VISUALIZZARE
        '    'O MENO I RECORDS NELLE VISTE UTILIZZATE DALLA FUNZIONE SQL ufn_GetSubtree()

        '    'SE ALMENO UN ARTICOLO CON LA CHIUSURA ANDRA' SOTTOSCORTA LA CHIUSURA VIENE IMPEDITA
        '    Dim DRConsumiArticoli As SqlClient.SqlDataReader

        '    ' PRENDO TUTTI GLI ARTICOLI DELLA MACCHINA (NON I GRUPPI) e CHE NON SIANO FIGLI DI UN ARTICOLO
        '    'm_SQL_Articoli = "SELECT t02_id_articolo_t01, SUM(consumo_calcolato) AS consumo_totale FROM "
        '    'm_SQL_Articoli += "ufn_GetSubtree() WHERE t02_id_articolo_t01 IS NOT NULL AND "
        '    'm_SQL_Articoli += "t06_id_istanza_macchina = " & strIDIstanza.Trim & " "
        '    'm_SQL_Articoli += "GROUP BY t02_id_articolo_t01"
        '    m_SQL_Articoli = "SELECT t22_id_articolo_t20, SUM(consumo_calcolato) AS consumo_totale FROM "
        '    m_SQL_Articoli += "ufn_GetSubtree2() WHERE (t20_is_gruppo IS NOT NULL AND t20_is_gruppo = 0) AND (t20_is_gruppo_padre = 1) AND "
        '    m_SQL_Articoli += "t06_id_istanza_macchina = " & strIDIstanza.Trim & " "
        '    m_SQL_Articoli += "GROUP BY t22_id_articolo_t20"

        '    blnNonChiudere = False

        '    DRConsumiArticoli = ExecuteReader(conn.ConnectionString, CommandType.Text, m_SQL_Articoli)
        '    If DRConsumiArticoli.HasRows Then

        '        While DRConsumiArticoli.Read

        '            'per ogni articolo vado a verificare se togliendogli la quantità da
        '            'scalare andrò sottoscorta. Se sì, devo bloccare la chiusura
        '            'm_SQL = "SELECT t01_qt_disponibile FROM t01_articoli WHERE "
        '            'm_SQL += "t01_id_articolo = " & DRConsumiArticoli("t02_id_articolo_t01").ToString
        '            m_SQL = "SELECT t20_qt_disponibile FROM t20_articoli WHERE "
        '            m_SQL += "t20_id_articolo = " & DRConsumiArticoli("t22_id_articolo_t20").ToString

        '            Dim DRQtDisponibile As SqlClient.SqlDataReader
        '            DRQtDisponibile = ExecuteReader(conn.ConnectionString, CommandType.Text, m_SQL)
        '            If DRQtDisponibile.HasRows Then
        '                DRQtDisponibile.Read()
        '                sngQtDisponibile = CType(DRQtDisponibile("t20_qt_disponibile"), Single)
        '                sngQtDisponibile = sngQtDisponibile - CType(DRConsumiArticoli("consumo_totale"), Single)
        '                If sngQtDisponibile < 0 Then
        '                    blnNonChiudere = True
        '                    'almeno 1 sottoscorta.. esco ed impedisco la chiusura!!
        '                    MessageBox.Show("Impossibile chiudere la commesssa, almeno un articolo andrebbe a giacenza negativa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                    Exit Sub
        '                End If
        '            End If
        '            DRQtDisponibile.Close()

        '        End While
        '    End If
        '    DRConsumiArticoli.Close()


        '    DRConsumiArticoli = ExecuteReader(conn.ConnectionString, CommandType.Text, m_SQL_Articoli)
        '    If DRConsumiArticoli.HasRows Then
        '        While DRConsumiArticoli.Read
        '            'per ogni articolo vado ad aggiornare la quantità a magazzino
        '            'm_SQL = "UPDATE t01_articoli SET "
        '            'm_SQL += "t01_qt_disponibile = t01_qt_disponibile - "
        '            'm_SQL += Replace(DRConsumiArticoli("consumo_totale").ToString, ",", ".") & " WHERE "
        '            'm_SQL += "t01_id_articolo = " & DRConsumiArticoli("t02_id_articolo_t01").ToString
        '            m_SQL = "UPDATE t20_articoli SET "
        '            m_SQL += "t20_qt_disponibile = t20_qt_disponibile - "
        '            m_SQL += Replace(DRConsumiArticoli("consumo_totale").ToString, ",", ".") & " WHERE "
        '            m_SQL += "t20_id_articolo = " & DRConsumiArticoli("t22_id_articolo_t20").ToString

        '            ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)
        '        End While
        '    End If
        '    'FINE AGGIORNAMENTO QUANTITA' ARTICOLI

        '    'Effettua UPDATE dello stato
        '    m_SQL = "UPDATE t06_istanze_macchine SET t06_id_stato_istanza_t07 = 'C', t06_dt_modifica = GetDate() WHERE "
        '    m_SQL = m_SQL & "t06_id_istanza_macchina = " & strIDIstanza.Trim
        '    ExecuteNonQuery(conn.ConnectionString, CommandType.Text, m_SQL)

        'RIPOPOLA IL DATASET E APPLICA I FILTRI
        objdsElencoIstanzeSemplice.Clear()
        daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
        Call ApplicaFiltri()

        'default
        Cursor.Current = Cursors.Default

        'End If

    End Sub

    Private Sub mnuSospendi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSospendi.Click

        Dim strIDIstanza As String

        strIDIstanza = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0).ToString()

        If MessageBox.Show("Confermi la simulazione della commessa?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'Effettua UPDATE dello stato
            m_SQL = "UPDATE t06_istanze_macchine SET t06_id_stato_istanza_t07 = 'S', t06_dt_modifica = GetDate() WHERE "
            m_SQL = m_SQL & "t06_id_istanza_macchina = " & strIDIstanza.Trim
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            'RIPOPOLA IL DATASET E APPLICA I FILTRI
            objdsElencoIstanzeSemplice.Clear()
            daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
            Call ApplicaFiltri()

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub mnuAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnulla.Click

        Dim strIDIstanza As String

        strIDIstanza = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0).ToString()

        If MessageBox.Show("Confermi la sospensione della commessa?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'Effettua UPDATE dello stato
            m_SQL = "UPDATE t06_istanze_macchine SET t06_id_stato_istanza_t07 = 'A', t06_dt_modifica = GetDate() WHERE "
            m_SQL = m_SQL & "t06_id_istanza_macchina = " & strIDIstanza.Trim
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            'RIPOPOLA IL DATASET E APPLICA I FILTRI
            objdsElencoIstanzeSemplice.Clear()
            daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
            Call ApplicaFiltri()

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub mnuInProduzione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInProduzione.Click

        Dim strIDIstanza As String

        strIDIstanza = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0).ToString()

        If MessageBox.Show("Confermi la messa in produzione della commessa?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'Effettua UPDATE dello stato
            m_SQL = "UPDATE t06_istanze_macchine SET t06_id_stato_istanza_t07 = 'P', t06_dt_modifica = GetDate() WHERE "
            m_SQL = m_SQL & "t06_id_istanza_macchina = " & strIDIstanza.Trim
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            'RIPOPOLA IL DATASET E APPLICA I FILTRI
            objdsElencoIstanzeSemplice.Clear()
            daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
            Call ApplicaFiltri()

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub mnuElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuElimina.Click

        Dim strIDIstanza As String

        strIDIstanza = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0).ToString()

        If MessageBox.Show("Confermi l'eliminazione definitiva della commessa?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            'clessidra
            Cursor.Current = Cursors.WaitCursor

            'Effettua UPDATE della data cancellazione
            m_SQL = "UPDATE t06_istanze_macchine SET t06_dt_cancellazione = GetDate() WHERE "
            m_SQL = m_SQL & "t06_id_istanza_macchina = " & strIDIstanza.Trim
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            'RIPOPOLA IL DATASET E APPLICA I FILTRI
            objdsElencoIstanzeSemplice.Clear()
            daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
            Call ApplicaFiltri()

            'default
            Cursor.Current = Cursors.Default

        End If

    End Sub

    Private Sub mnuStampa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStampa.Click
        'NOTE: Se la macchina risulta SOSPESA o IN PRODUZIONE bisogna aprire il
        'report della struttura attuale, altrimenti (CHIUSA O ANNULLATA) bisogna
        'aprire il PDF memorizzato al momento della CHIUSURA o ANNULLAMENTO istanza

        Dim strIDStato As String
        strIDStato = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 8).ToString()

        Dim intIDIstanza As Integer
        intIDIstanza = CType(DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0), Integer)

        Dim intIDMacchina As Integer
        intIDMacchina = CType(DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 9), Integer)

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If strIDStato = "P" Or strIDStato = "S" Then

            Dim FormReport As New frmReport
            FormReport.MdiParent = Me.MdiParent

            FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-ConfigurazioneMacchine.rpt"))
            FormReport.reportDocumentSource.RecordSelectionFormula = "{viewTreeMacchine.t05_id_macchina} = " & intIDMacchina
            FormReport.Show()

        Else

            ' MsgBox("Report PDF su database")

        End If

    End Sub

#End Region

    Private Sub DataGridElencoIstanze_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridElencoIstanze.MouseDown
        'Visualizza il menù di contesto solo nel RowHeader
        Dim pt As System.Drawing.Point = New Point(e.X, e.Y)
        Dim hti As DataGrid.HitTestInfo = DataGridElencoIstanze.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.RowHeader Then
            If e.Button = MouseButtons.Right Then
                DataGridElencoIstanze.CurrentCell = New DataGridCell(hti.Row, hti.Column)

                'Vengono disabilitate le voci di menù che non hanno senso
                Dim strIDStato As String
                'L'id stato istanza è sulla colonna 8
                strIDStato = DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 8).ToString()

                ContextMenu1.MenuItems(0).Enabled = True    'In Produzione
                ContextMenu1.MenuItems(1).Enabled = True    'Chiudi
                ContextMenu1.MenuItems(2).Enabled = True    'Sospendi
                ContextMenu1.MenuItems(3).Enabled = True    'Annulla
                ContextMenu1.MenuItems(5).Enabled = True    'Elimina definitivamente
                ContextMenu1.MenuItems(7).Enabled = True    'Stampa

                'Se l'istanza è in produzione si può solo Chiudere, Sospendere, Annullare, Eliminare
                If strIDStato.Trim = "P" Then
                    ContextMenu1.MenuItems(0).Enabled = False
                End If

                'Se l'istanza è chiusa non si può fare niente
                If strIDStato.Trim = "C" Then
                    ContextMenu1.MenuItems(0).Enabled = False
                    ContextMenu1.MenuItems(1).Enabled = False
                    ContextMenu1.MenuItems(2).Enabled = False
                    ContextMenu1.MenuItems(3).Enabled = False
                    ContextMenu1.MenuItems(5).Enabled = False
                End If

                'Se l'istanza è sospesa si può solo Mettere In Produzione, Annullare ed Eliminare
                'Per chiuderla, ad esempio, è necessario prima metterla in Produzione
                If strIDStato.Trim = "S" Then
                    ContextMenu1.MenuItems(1).Enabled = False
                    ContextMenu1.MenuItems(2).Enabled = False
                End If

                'Se l'istanza è annullata si può solo Eliminare?
                If strIDStato.Trim = "A" Then
                    ContextMenu1.MenuItems(0).Enabled = False
                    ContextMenu1.MenuItems(1).Enabled = False
                    ContextMenu1.MenuItems(2).Enabled = False
                    ContextMenu1.MenuItems(3).Enabled = False
                End If

                ContextMenu1.Show(DataGridElencoIstanze, pt)
            End If
        End If
    End Sub

    Private Sub DataGridElencoIstanze_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridElencoIstanze.DoubleClick
        Dim intIDIstanza As Integer

        intIDIstanza = CType(DataGridElencoIstanze.Item(DataGridElencoIstanze.CurrentRowIndex, 0), Integer)

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormIstanzeMacchine As New frmCommesseNuova
        FormIstanzeMacchine.Variazione = True
        FormIstanzeMacchine.IDIstanza = intIDIstanza
        FormIstanzeMacchine.ShowDialog()

        'RIPOPOLA IL DATASET, APPLICA I FILTRI E RIPOSIZIONE PUNTATORE
        objdsElencoIstanzeSemplice.Clear()
        daviewElencoIstanzeSemplice.Fill(objdsElencoIstanzeSemplice)
        Call ApplicaFiltri()

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub cmbAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnno.SelectedIndexChanged
        If m_EventCanFire Then Call ApplicaFiltri()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbAnno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnno.Click
        CliccatoSuFiltri = True
    End Sub
End Class
