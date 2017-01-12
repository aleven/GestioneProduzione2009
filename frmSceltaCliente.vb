Public Class frmSceltaCliente
    Inherits System.Windows.Forms.Form

    Private mstrFiltro As String
    Private mintIDFornitore As Integer
    Private mstrCodFornitore As String
    Private mstrDescrizioneFornitore As String
    Private DataViewFornitori As DataView

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblFiltri As System.Windows.Forms.Label
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents objdsListaClienti As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSceltaCliente))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.lblFiltri = New System.Windows.Forms.Label
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.objdsListaClienti = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaClienti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowNavigation = False
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(684, 384)
        Me.DataGrid1.TabIndex = 3
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "t14_clienti"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID Fornitore"
        Me.DataGridTextBoxColumn1.MappingName = "t14_id_cliente"
        Me.DataGridTextBoxColumn1.NullText = "0"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Codice Cliente"
        Me.DataGridTextBoxColumn2.MappingName = "t14_cod_cliente"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Descrizione Cliente"
        Me.DataGridTextBoxColumn3.MappingName = "t14_descrizione"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 400
        '
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(112, 8)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(152, 20)
        Me.txtRicercaCodice.TabIndex = 1
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(264, 8)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(400, 20)
        Me.txtRicercaDescrizione.TabIndex = 2
        '
        'lblFiltri
        '
        Me.lblFiltri.Location = New System.Drawing.Point(8, 8)
        Me.lblFiltri.Name = "lblFiltri"
        Me.lblFiltri.Size = New System.Drawing.Size(100, 16)
        Me.lblFiltri.TabIndex = 0
        Me.lblFiltri.Text = "Filtri di ricerca :"
        '
        'btnChiudi
        '
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Location = New System.Drawing.Point(24, 64)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(64, 24)
        Me.btnChiudi.TabIndex = 4
        Me.btnChiudi.TabStop = False
        Me.btnChiudi.Text = "Chiudi"
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t14_clienti", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t14_id_cliente", "t14_id_cliente"), New System.Data.Common.DataColumnMapping("t14_cod_cliente", "t14_cod_cliente"), New System.Data.Common.DataColumnMapping("t14_descrizione", "t14_descrizione"), New System.Data.Common.DataColumnMapping("t14_telefono", "t14_telefono"), New System.Data.Common.DataColumnMapping("t14_note", "t14_note"), New System.Data.Common.DataColumnMapping("t14_dt_creazione", "t14_dt_creazione"), New System.Data.Common.DataColumnMapping("t14_dt_modifica", "t14_dt_modifica"), New System.Data.Common.DataColumnMapping("t14_dt_cancellazione", "t14_dt_cancellazione")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
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
            "t14_dt_creazione, t14_dt_modifica, t14_dt_cancellazione FROM t14_clienti WHERE (" & _
            "t14_dt_cancellazione IS NULL)"
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.conn1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, "t14_cod_cliente"), New System.Data.SqlClient.SqlParameter("@t14_descrizione", System.Data.SqlDbType.VarChar, 255, "t14_descrizione"), New System.Data.SqlClient.SqlParameter("@t14_telefono", System.Data.SqlDbType.VarChar, 20, "t14_telefono"), New System.Data.SqlClient.SqlParameter("@t14_note", System.Data.SqlDbType.VarChar, 2147483647, "t14_note"), New System.Data.SqlClient.SqlParameter("@t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t14_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t14_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t14_id_cliente", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_id_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_cod_cliente", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_cod_cliente", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t14_telefono", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t14_telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t14_id_cliente", System.Data.SqlDbType.Int, 4, "t14_id_cliente")})
        '
        'objdsListaClienti
        '
        Me.objdsListaClienti.DataSetName = "dsClienti"
        Me.objdsListaClienti.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaClienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmSceltaCliente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(680, 430)
        Me.Controls.Add(Me.lblFiltri)
        Me.Controls.Add(Me.txtRicercaDescrizione)
        Me.Controls.Add(Me.txtRicercaCodice)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnChiudi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSceltaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Clienti"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaClienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'per gestione eventuale filtro dati
    Public Property Filtro() As String
        Get
            Return mstrFiltro
        End Get
        Set(ByVal Value As String)
            mstrFiltro = Value
        End Set
    End Property

    Public Property IDFornitore() As Integer
        Get
            Return mintIDFornitore
        End Get
        Set(ByVal Value As Integer)
            mintIDFornitore = Value
        End Set
    End Property

    Public Property CodFornitore() As String
        Get
            Return mstrCodFornitore
        End Get
        Set(ByVal Value As String)
            mstrCodFornitore = Value
        End Set
    End Property

    Public Property DescrizioneFornitore() As String
        Get
            Return mstrDescrizioneFornitore
        End Get
        Set(ByVal Value As String)
            mstrDescrizioneFornitore = Value
        End Set
    End Property

    Private Sub frmSceltaCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        mintIDFornitore = -1
        SqlDataAdapter1.Fill(objdsListaClienti)

        DataViewFornitori = objdsListaClienti.t14_clienti.DefaultView()
        DataGrid1.DataSource = DataViewFornitori

    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        mintIDFornitore = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), Integer)
        mstrCodFornitore = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1), String)
        mstrDescrizioneFornitore = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2), String)

        Me.Close()
    End Sub

    Private Sub ApplicaFiltri(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged, txtRicercaDescrizione.TextChanged
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = Me.txtRicercaCodice.Text
        strFiltroDescrizione = Me.txtRicercaDescrizione.Text

        If strFiltroCodice.Trim <> "" Then
            strFiltro = "t14_cod_cliente LIKE '*" & strFiltroCodice & "*' "
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = strFiltro & "AND "
                strFiltro = strFiltro & "t14_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        Else
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = "t14_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        End If
        DataViewFornitori.RowFilter = strFiltro
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

End Class
