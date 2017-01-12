Imports GestioneProduzione2014Data

Public Class frmSceltaArticolo
    Inherits System.Windows.Forms.Form

    Private mstrFiltro As String
    Private mintIDArticolo As Integer
    Private mstrCodArticolo As String
    Private mstrDescrizioneArticolo As String
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn

    Private mstrModoSelezione As TModoSelezione

    Public Enum TModoSelezione As Short
        MODIFICA = 0
        SELEZIONA = 1
    End Enum

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
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents t20_articoli As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents objdsArticoli2 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents DataViewArticoli As System.Data.DataView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSceltaArticolo))
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.lblFiltri = New System.Windows.Forms.Label
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.btnModifica = New System.Windows.Forms.Button
        Me.t20_articoli = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataViewArticoli = New System.Data.DataView
        Me.btnSalva = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.objdsArticoli2 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        CType(Me.DataViewArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objdsArticoli2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_TEST;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
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
        'btnModifica
        '
        Me.btnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifica.Location = New System.Drawing.Point(797, 386)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(96, 32)
        Me.btnModifica.TabIndex = 5
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.Visible = False
        '
        't20_articoli
        '
        Me.t20_articoli.DeleteCommand = Me.SqlDeleteCommand1
        Me.t20_articoli.InsertCommand = Me.SqlInsertCommand1
        Me.t20_articoli.SelectCommand = Me.SqlSelectCommand1
        Me.t20_articoli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t20_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione")})})
        Me.t20_articoli.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.conn1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t20_id_articolo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_is_gruppo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, Nothing)})
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
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.conn1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 255, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 1, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, "t20_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t20_id_articolo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_cod_articolo", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_descrizione", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_creazione", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_modifica", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_is_gruppo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t20_id_articolo", System.Data.SqlDbType.Int, 4, "t20_id_articolo")})
        '
        'DataViewArticoli
        '
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Image = CType(resources.GetObject("btnSalva.Image"), System.Drawing.Image)
        Me.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalva.Location = New System.Drawing.Point(685, 386)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(104, 32)
        Me.btnSalva.TabIndex = 6
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowNavigation = False
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = "t20_articoli"
        Me.DataGrid1.DataSource = Me.objdsArticoli2
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 32)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsVisible = False
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(909, 386)
        Me.DataGrid1.TabIndex = 3
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'objdsArticoli2
        '
        Me.objdsArticoli2.DataSetName = "dsArticoli2"
        Me.objdsArticoli2.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsArticoli2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "t20_articoli"
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
        Me.DataGridTextBoxColumn2.HeaderText = "Codice Articolo"
        Me.DataGridTextBoxColumn2.MappingName = "t20_cod_articolo"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Descrizione Articolo"
        Me.DataGridTextBoxColumn3.MappingName = "t20_descrizione"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 400
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "D"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Qt.a Disp."
        Me.DataGridTextBoxColumn4.MappingName = "t20_qt_disponibile"
        Me.DataGridTextBoxColumn4.NullText = "0"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Scorta minima"
        Me.DataGridTextBoxColumn5.MappingName = "t20_lotto_riordino"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Costo"
        Me.DataGridTextBoxColumn6.MappingName = "t20_prezzo"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.HeaderText = "Ricambio"
        Me.DataGridBoolColumn1.MappingName = "t20_is_ricambio"
        Me.DataGridBoolColumn1.Width = 75
        '
        'frmSceltaArticolo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(905, 430)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.lblFiltri)
        Me.Controls.Add(Me.txtRicercaDescrizione)
        Me.Controls.Add(Me.txtRicercaCodice)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnChiudi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSceltaArticolo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Articoli"
        CType(Me.DataViewArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objdsArticoli2, System.ComponentModel.ISupportInitialize).EndInit()
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

    Public Property IDArticolo() As Integer
        Get
            Return mintIDArticolo
        End Get
        Set(ByVal Value As Integer)
            mintIDArticolo = Value
        End Set
    End Property

    Public Property CodArticolo() As String
        Get
            Return mstrCodArticolo
        End Get
        Set(ByVal Value As String)
            mstrCodArticolo = Value
        End Set
    End Property

    Public Property DescrizioneArticolo() As String
        Get
            Return mstrDescrizioneArticolo
        End Get
        Set(ByVal Value As String)
            mstrDescrizioneArticolo = Value
        End Set
    End Property

    Public Property ModoSelezione() As TModoSelezione
        Get
            Return mstrModoSelezione
        End Get
        Set(ByVal Value As TModoSelezione)
            mstrModoSelezione = Value
        End Set
    End Property

    Private Sub frmSceltaArticolo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        mintIDArticolo = -1

        LoadDataSet()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick

        mintIDArticolo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 0), Integer)
        mstrCodArticolo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 1), String)
        mstrDescrizioneArticolo = CType(DataGrid1.Item(DataGrid1.CurrentRowIndex, 2), String)

        If mstrModoSelezione = TModoSelezione.MODIFICA Then
            Dim FormInsArticolo As New frmAnagraficaArticoli
            FormInsArticolo.IDArticolo = mintIDArticolo
            FormInsArticolo.ShowDialog()
        Else
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

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        ChangeEditMode()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        ChangeEditMode()

        'Imposto i valori di default per un record articolo
        Dim i As Integer
        Dim row As GestioneProduzione2009DataSet.t20_articoliRow
        For i = 0 To objdsArticoli2.t20_articoli.Rows.Count - 1
            row = objdsArticoli2.t20_articoli.Rows(i)
            If row.RowState = DataRowState.Added Then
                row.RejectChanges()
            End If
            If row.RowState = DataRowState.Modified Then
                If (row.Ist20_qt_disponibileNull) Then
                    row.t20_qt_disponibile = 0
                End If

            End If
        Next

        t20_articoli.Update(objdsArticoli2.t20_articoli)
    End Sub

    Private Sub ChangeEditMode()

        DataGrid1.ReadOnly = Not DataGrid1.ReadOnly
        btnSalva.Visible = Not DataGrid1.ReadOnly
        If DataGrid1.ReadOnly Then
            btnModifica.Text = "Modifica"
        Else
            LoadDataSet()
            btnModifica.Text = "Annulla"
        End If

    End Sub

    Private Sub LoadDataSet()

        objdsArticoli2.Clear()

        t20_articoli.Fill(objdsArticoli2) 'SqlDataAdapter1.Fill(objdsListaArticoli)

        DataViewArticoli = objdsArticoli2.t20_articoli.DefaultView 'objdsListaArticoli.t01_articoli.DefaultView
        DataViewArticoli.Sort = "t20_cod_articolo"
        DataGrid1.DataSource = DataViewArticoli
        DataGrid1.Refresh()
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub DataViewArticoli_ListChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles DataViewArticoli.ListChanged

    End Sub
End Class
