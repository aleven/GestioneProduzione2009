Public Class frmSceltaGruppo
    Inherits System.Windows.Forms.Form

    Private mstrFiltro As String
    Private mintIDGruppo As Integer
    Private mstrCodGruppo As String
    Private mstrDescrizioneGruppo As String
    Private DataViewGruppi As DataView

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
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblFiltri As System.Windows.Forms.Label
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents objdsListaGruppi As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents dav03_gruppi As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSceltaGruppo))
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.dav03_gruppi = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.lblFiltri = New System.Windows.Forms.Label
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.objdsListaGruppi = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'dav03_gruppi
        '
        Me.dav03_gruppi.InsertCommand = Me.SqlInsertCommand1
        Me.dav03_gruppi.SelectCommand = Me.SqlSelectCommand1
        Me.dav03_gruppi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "v03_gruppi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
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
        Me.btnChiudi.TabIndex = 5
        Me.btnChiudi.TabStop = False
        Me.btnChiudi.Text = "Chiudi"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowNavigation = False
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = "v03_gruppi"
        Me.DataGrid1.DataSource = Me.objdsListaGruppi
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(684, 384)
        Me.DataGrid1.TabIndex = 3
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'objdsListaGruppi
        '
        Me.objdsListaGruppi.DataSetName = "dsGruppi2"
        Me.objdsListaGruppi.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsListaGruppi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "v03_gruppi"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "ID Gruppo"
        Me.DataGridTextBoxColumn1.MappingName = "t20_id_articolo"
        Me.DataGridTextBoxColumn1.NullText = "0"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Codice Gruppo"
        Me.DataGridTextBoxColumn2.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Descrizione Gruppo"
        Me.DataGridTextBoxColumn3.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 400
        '
        'frmSceltaGruppo
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
        Me.Name = "frmSceltaGruppo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Gruppi"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsListaGruppi, System.ComponentModel.ISupportInitialize).EndInit()
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

    Public Property IDGruppo() As Integer
        Get
            Return mintIDGruppo
        End Get
        Set(ByVal Value As Integer)
            mintIDGruppo = Value
        End Set
    End Property

    Public Property CodGruppo() As String
        Get
            Return mstrCodGruppo
        End Get
        Set(ByVal Value As String)
            mstrCodGruppo = Value
        End Set
    End Property

    Public Property DescrizioneGruppo() As String
        Get
            Return mstrDescrizioneGruppo
        End Get
        Set(ByVal Value As String)
            mstrDescrizioneGruppo = Value
        End Set
    End Property

    Private Sub frmSceltaGruppo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        mintIDGruppo = -1
        dav03_gruppi.Fill(objdsListaGruppi)

        DataViewGruppi = objdsListaGruppi.v03_gruppi.DefaultView
        DataViewGruppi.Sort = "t20_cod_articolo"
        DataGrid1.DataSource = DataViewGruppi

    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        mintIDGruppo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), Integer)
        mstrCodGruppo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1), String)
        mstrDescrizioneGruppo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2), String)

        Me.Close()
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
        DataViewGruppi.RowFilter = strFiltro
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub
End Class
