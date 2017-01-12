' Questa classe è stata progettata su VS2003 come modello dati 
' per avere tutto a disposizione
' 
' Per aggiungere dataset uso VS2003 in quanto non si possono aggiungere in design-time
' Poi il codice scritto a mano continuo a modificarlo con VS2005

Imports System.Collections.Generic
Imports GestioneProduzione2014Data

Public Class DataModel
    Inherits System.ComponentModel.Component

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    'Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    'Public WithEvents conn As System.Data.SqlClient.SqlConnection
    'Public WithEvents dat20_articoli As System.Data.SqlClient.SqlDataAdapter
    'Public WithEvents dat21_articoli_macchine As System.Data.SqlClient.SqlDataAdapter
    'Public WithEvents dat22_articoli_articoli As System.Data.SqlClient.SqlDataAdapter
    'Public WithEvents dat05_macchine As System.Data.SqlClient.SqlDataAdapter
    'Public WithEvents dat06_istanze_macchine As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents dat08_testate_ordini_for As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents dat09_righe_ordine_for As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents dat25_matricole As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents dat26_formule_prezzi As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    'Friend WithEvents dat07_stati_istanza As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents SqlDeleteCommand As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlInsertCommand As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlSelectCommand As System.Data.SqlClient.SqlCommand
    'Friend WithEvents SqlUpdateCommand As System.Data.SqlClient.SqlCommand
    Friend WithEvents GestioneProduzione2009DataSet1 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T11_fornitoriTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t11_fornitoriTableAdapter
    Friend WithEvents T20_articoliTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
    Friend WithEvents T21_articoli_macchineTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t21_articoli_macchineTableAdapter
    Friend WithEvents T22_articoli_articoliTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
    Friend WithEvents T07_stati_istanzaTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t07_stati_istanzaTableAdapter
    Friend WithEvents T06_istanze_macchineTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t06_istanze_macchineTableAdapter
    Friend WithEvents T05_macchineTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t05_macchineTableAdapter
    Friend WithEvents T25_matricoleTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
    Friend WithEvents T08_testate_ordini_forTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t08_testate_ordini_forTableAdapter
    Friend WithEvents T09_righe_ordine_forTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t09_righe_ordine_forTableAdapter
    Friend WithEvents T26_formule_prezziTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
    'Friend WithEvents dat11_fornitori As System.Data.SqlClient.SqlDataAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataModel))
        'Me.conn = New System.Data.SqlClient.SqlConnection
        'Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        'Me.dat20_articoli = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        'Me.dat21_articoli_macchine = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        'Me.dat22_articoli_articoli = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        'Me.dat05_macchine = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        'Me.dat06_istanze_macchine = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        'Me.dat08_testate_ordini_for = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        'Me.dat09_righe_ordine_for = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        'Me.dat25_matricole = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        'Me.dat26_formule_prezzi = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        'Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        'Me.dat11_fornitori = New System.Data.SqlClient.SqlDataAdapter
        'Me.dat07_stati_istanza = New System.Data.SqlClient.SqlDataAdapter
        'Me.SqlDeleteCommand = New System.Data.SqlClient.SqlCommand
        'Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand
        'Me.SqlSelectCommand = New System.Data.SqlClient.SqlCommand
        'Me.SqlUpdateCommand = New System.Data.SqlClient.SqlCommand
        Me.GestioneProduzione2009DataSet1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.T11_fornitoriTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t11_fornitoriTableAdapter
        Me.T20_articoliTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Me.T21_articoli_macchineTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t21_articoli_macchineTableAdapter
        Me.T22_articoli_articoliTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t22_articoli_articoliTableAdapter
        Me.T07_stati_istanzaTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t07_stati_istanzaTableAdapter
        Me.T06_istanze_macchineTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t06_istanze_macchineTableAdapter
        Me.T05_macchineTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t05_macchineTableAdapter
        Me.T25_matricoleTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
        Me.T08_testate_ordini_forTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t08_testate_ordini_forTableAdapter
        Me.T09_righe_ordine_forTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t09_righe_ordine_forTableAdapter
        Me.T26_formule_prezziTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        ''
        ''conn
        ''
        'Me.conn.ConnectionString = Global.GestioneProduzione.My.MySettings.Default.GestioneProduzione2009ConnectionString.ToString()
        'Me.conn.FireInfoMessageEventOnUserErrors = False
        ''
        ''SqlSelectCommand1
        ''
        'Me.SqlSelectCommand1.CommandText = "SELECT     t20_articoli.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t20_articoli"
        'Me.SqlSelectCommand1.Connection = Me.conn
        ''
        ''SqlInsertCommand1
        ''
        'Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        'Me.SqlInsertCommand1.Connection = Me.conn
        'Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 0, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 0, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 0, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t20_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, "t20_id_fornitore_t11"), New System.Data.SqlClient.SqlParameter("@t20_prezzo_forzato", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_ricambio", System.Data.SqlDbType.Bit, 0, "t20_is_ricambio")})
        ''
        ''SqlUpdateCommand1
        ''
        'Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        'Me.SqlUpdateCommand1.Connection = Me.conn
        'Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t20_cod_articolo", System.Data.SqlDbType.VarChar, 0, "t20_cod_articolo"), New System.Data.SqlClient.SqlParameter("@t20_descrizione", System.Data.SqlDbType.VarChar, 0, "t20_descrizione"), New System.Data.SqlClient.SqlParameter("@t20_prezzo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_gruppo", System.Data.SqlDbType.Bit, 0, "t20_is_gruppo"), New System.Data.SqlClient.SqlParameter("@t20_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t20_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t20_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t20_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t20_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, "t20_id_fornitore_t11"), New System.Data.SqlClient.SqlParameter("@t20_prezzo_forzato", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t20_is_ricambio", System.Data.SqlDbType.Bit, 0, "t20_is_ricambio"), New System.Data.SqlClient.SqlParameter("@Original_t20_id_articolo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_cod_articolo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_cod_articolo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_prezzo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_qt_disponibile", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_lotto_riordino", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_is_gruppo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_is_gruppo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_id_fornitore_t11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_fornitore_t11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_prezzo_forzato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo_forzato", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_is_ricambio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_is_ricambio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_is_ricambio", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_ricambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t20_id_articolo", System.Data.SqlDbType.Int, 4, "t20_id_articolo")})
        ''
        ''SqlDeleteCommand1
        ''
        'Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        'Me.SqlDeleteCommand1.Connection = Me.conn
        'Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t20_id_articolo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_cod_articolo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_cod_articolo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_cod_articolo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_prezzo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_qt_disponibile", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_qt_disponibile", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_qt_disponibile", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_lotto_riordino", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_lotto_riordino", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t20_lotto_riordino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_is_gruppo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_is_gruppo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_gruppo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_id_fornitore_t11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_id_fornitore_t11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_prezzo_forzato", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_prezzo_forzato", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(4, Byte), "t20_prezzo_forzato", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t20_is_ricambio", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t20_is_ricambio", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t20_is_ricambio", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t20_is_ricambio", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat20_articoli
        ''
        'Me.dat20_articoli.DeleteCommand = Me.SqlDeleteCommand1
        'Me.dat20_articoli.InsertCommand = Me.SqlInsertCommand1
        'Me.dat20_articoli.SelectCommand = Me.SqlSelectCommand1
        'Me.dat20_articoli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t20_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t20_id_articolo", "t20_id_articolo"), New System.Data.Common.DataColumnMapping("t20_cod_articolo", "t20_cod_articolo"), New System.Data.Common.DataColumnMapping("t20_descrizione", "t20_descrizione"), New System.Data.Common.DataColumnMapping("t20_prezzo", "t20_prezzo"), New System.Data.Common.DataColumnMapping("t20_qt_disponibile", "t20_qt_disponibile"), New System.Data.Common.DataColumnMapping("t20_lotto_riordino", "t20_lotto_riordino"), New System.Data.Common.DataColumnMapping("t20_is_gruppo", "t20_is_gruppo"), New System.Data.Common.DataColumnMapping("t20_dt_creazione", "t20_dt_creazione"), New System.Data.Common.DataColumnMapping("t20_dt_modifica", "t20_dt_modifica"), New System.Data.Common.DataColumnMapping("t20_dt_cancellazione", "t20_dt_cancellazione"), New System.Data.Common.DataColumnMapping("t20_id_fornitore_t11", "t20_id_fornitore_t11"), New System.Data.Common.DataColumnMapping("t20_prezzo_forzato", "t20_prezzo_forzato"), New System.Data.Common.DataColumnMapping("t20_is_ricambio", "t20_is_ricambio")})})
        'Me.dat20_articoli.UpdateCommand = Me.SqlUpdateCommand1
        ''
        ''SqlSelectCommand2
        ''
        'Me.SqlSelectCommand2.CommandText = "SELECT     t21_id_articolo_t20, t21_id_macchina_t05, t21_consumo, t21_posizione, " & _
        '    "t21_dt_creazione, t21_dt_modifica, t21_dt_cancellazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t21_artico" & _
        '    "li_macchine"
        'Me.SqlSelectCommand2.Connection = Me.conn
        ''
        ''SqlInsertCommand2
        ''
        'Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        'Me.SqlInsertCommand2.Connection = Me.conn
        'Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t21_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t21_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t21_id_macchina_t05", System.Data.SqlDbType.Int, 0, "t21_id_macchina_t05"), New System.Data.SqlClient.SqlParameter("@t21_consumo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t21_consumo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t21_posizione", System.Data.SqlDbType.Int, 0, "t21_posizione"), New System.Data.SqlClient.SqlParameter("@t21_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t21_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t21_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t21_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t21_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t21_dt_cancellazione")})
        ''
        ''SqlUpdateCommand2
        ''
        'Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        'Me.SqlUpdateCommand2.Connection = Me.conn
        'Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t21_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t21_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t21_id_macchina_t05", System.Data.SqlDbType.Int, 0, "t21_id_macchina_t05"), New System.Data.SqlClient.SqlParameter("@t21_consumo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t21_consumo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t21_posizione", System.Data.SqlDbType.Int, 0, "t21_posizione"), New System.Data.SqlClient.SqlParameter("@t21_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t21_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t21_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t21_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t21_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t21_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t21_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t21_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_id_macchina_t05", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_consumo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_consumo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_consumo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t21_consumo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''SqlDeleteCommand2
        ''
        'Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        'Me.SqlDeleteCommand2.Connection = Me.conn
        'Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t21_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t21_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_id_macchina_t05", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_consumo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_consumo", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_consumo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t21_consumo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t21_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t21_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t21_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t21_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat21_articoli_macchine
        ''
        'Me.dat21_articoli_macchine.DeleteCommand = Me.SqlDeleteCommand2
        'Me.dat21_articoli_macchine.InsertCommand = Me.SqlInsertCommand2
        'Me.dat21_articoli_macchine.SelectCommand = Me.SqlSelectCommand2
        'Me.dat21_articoli_macchine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t21_articoli_macchine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t21_id_articolo_t20", "t21_id_articolo_t20"), New System.Data.Common.DataColumnMapping("t21_id_macchina_t05", "t21_id_macchina_t05"), New System.Data.Common.DataColumnMapping("t21_consumo", "t21_consumo"), New System.Data.Common.DataColumnMapping("t21_posizione", "t21_posizione"), New System.Data.Common.DataColumnMapping("t21_dt_creazione", "t21_dt_creazione"), New System.Data.Common.DataColumnMapping("t21_dt_modifica", "t21_dt_modifica"), New System.Data.Common.DataColumnMapping("t21_dt_cancellazione", "t21_dt_cancellazione")})})
        'Me.dat21_articoli_macchine.UpdateCommand = Me.SqlUpdateCommand2
        ''
        ''SqlSelectCommand3
        ''
        'Me.SqlSelectCommand3.CommandText = "SELECT     t22_id_articolo_t20, t22_id_articolo_padre_t20, t22_consumo, t22_posiz" & _
        '    "ione, t22_dt_creazione, t22_dt_modifica, t22_dt_cancellazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t22_" & _
        '    "articoli_articoli"
        'Me.SqlSelectCommand3.Connection = Me.conn
        ''
        ''SqlInsertCommand3
        ''
        'Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        'Me.SqlInsertCommand3.Connection = Me.conn
        'Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t22_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t22_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t22_id_articolo_padre_t20", System.Data.SqlDbType.Int, 0, "t22_id_articolo_padre_t20"), New System.Data.SqlClient.SqlParameter("@t22_consumo", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t22_consumo", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t22_posizione", System.Data.SqlDbType.Int, 0, "t22_posizione"), New System.Data.SqlClient.SqlParameter("@t22_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t22_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t22_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t22_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t22_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t22_dt_cancellazione")})
        ''
        ''dat22_articoli_articoli
        ''
        'Me.dat22_articoli_articoli.InsertCommand = Me.SqlInsertCommand3
        'Me.dat22_articoli_articoli.SelectCommand = Me.SqlSelectCommand3
        'Me.dat22_articoli_articoli.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t22_articoli_articoli", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t22_id_articolo_t20", "t22_id_articolo_t20"), New System.Data.Common.DataColumnMapping("t22_id_articolo_padre_t20", "t22_id_articolo_padre_t20"), New System.Data.Common.DataColumnMapping("t22_consumo", "t22_consumo"), New System.Data.Common.DataColumnMapping("t22_posizione", "t22_posizione"), New System.Data.Common.DataColumnMapping("t22_dt_creazione", "t22_dt_creazione"), New System.Data.Common.DataColumnMapping("t22_dt_modifica", "t22_dt_modifica"), New System.Data.Common.DataColumnMapping("t22_dt_cancellazione", "t22_dt_cancellazione")})})
        ''
        ''SqlSelectCommand4
        ''
        'Me.SqlSelectCommand4.CommandText = "SELECT     t05_id_macchina, t05_cod_macchina, t05_descrizione, t05_dt_creazione, " & _
        '    "t05_dt_modifica, t05_dt_cancellazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t05_macchine"
        'Me.SqlSelectCommand4.Connection = Me.conn
        ''
        ''SqlInsertCommand4
        ''
        'Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        'Me.SqlInsertCommand4.Connection = Me.conn
        'Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t05_cod_macchina", System.Data.SqlDbType.VarChar, 0, "t05_cod_macchina"), New System.Data.SqlClient.SqlParameter("@t05_descrizione", System.Data.SqlDbType.VarChar, 0, "t05_descrizione"), New System.Data.SqlClient.SqlParameter("@t05_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t05_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t05_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t05_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t05_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t05_dt_cancellazione")})
        ''
        ''SqlUpdateCommand3
        ''
        'Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        'Me.SqlUpdateCommand3.Connection = Me.conn
        'Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t05_cod_macchina", System.Data.SqlDbType.VarChar, 0, "t05_cod_macchina"), New System.Data.SqlClient.SqlParameter("@t05_descrizione", System.Data.SqlDbType.VarChar, 0, "t05_descrizione"), New System.Data.SqlClient.SqlParameter("@t05_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t05_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t05_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t05_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t05_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t05_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t05_id_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_id_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_cod_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_cod_macchina", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_cod_macchina", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_cod_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t05_id_macchina", System.Data.SqlDbType.Int, 4, "t05_id_macchina")})
        ''
        ''SqlDeleteCommand3
        ''
        'Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        'Me.SqlDeleteCommand3.Connection = Me.conn
        'Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t05_id_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_id_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_cod_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_cod_macchina", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_cod_macchina", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_cod_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t05_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t05_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t05_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t05_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat05_macchine
        ''
        'Me.dat05_macchine.DeleteCommand = Me.SqlDeleteCommand3
        'Me.dat05_macchine.InsertCommand = Me.SqlInsertCommand4
        'Me.dat05_macchine.SelectCommand = Me.SqlSelectCommand4
        'Me.dat05_macchine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t05_macchine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t05_id_macchina", "t05_id_macchina"), New System.Data.Common.DataColumnMapping("t05_cod_macchina", "t05_cod_macchina"), New System.Data.Common.DataColumnMapping("t05_descrizione", "t05_descrizione"), New System.Data.Common.DataColumnMapping("t05_dt_creazione", "t05_dt_creazione"), New System.Data.Common.DataColumnMapping("t05_dt_modifica", "t05_dt_modifica"), New System.Data.Common.DataColumnMapping("t05_dt_cancellazione", "t05_dt_cancellazione")})})
        'Me.dat05_macchine.UpdateCommand = Me.SqlUpdateCommand3
        ''
        ''SqlSelectCommand5
        ''
        'Me.SqlSelectCommand5.CommandText = "SELECT    *" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t06_istanze_macchine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        'Me.SqlSelectCommand5.Connection = Me.conn
        ''
        ''SqlInsertCommand5
        ''
        'Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        'Me.SqlInsertCommand5.Connection = Me.conn
        'Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t06_descrizione", System.Data.SqlDbType.VarChar, 0, "t06_descrizione"), New System.Data.SqlClient.SqlParameter("@t06_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t06_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, "t06_id_macchina_t05"), New System.Data.SqlClient.SqlParameter("@t06_quantita", System.Data.SqlDbType.SmallInt, 0, "t06_quantita"), New System.Data.SqlClient.SqlParameter("@t06_id_stato_istanza_t07", System.Data.SqlDbType.[Char], 0, "t06_id_stato_istanza_t07"), New System.Data.SqlClient.SqlParameter("@t06_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t06_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t06_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t06_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t06_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t06_dt_cancellazione")})
        ''
        ''SqlUpdateCommand4
        ''
        'Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        'Me.SqlUpdateCommand4.Connection = Me.conn
        'Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t06_descrizione", System.Data.SqlDbType.VarChar, 0, "t06_descrizione"), New System.Data.SqlClient.SqlParameter("@t06_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t06_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, "t06_id_macchina_t05"), New System.Data.SqlClient.SqlParameter("@t06_quantita", System.Data.SqlDbType.SmallInt, 0, "t06_quantita"), New System.Data.SqlClient.SqlParameter("@t06_id_stato_istanza_t07", System.Data.SqlDbType.[Char], 0, "t06_id_stato_istanza_t07"), New System.Data.SqlClient.SqlParameter("@t06_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t06_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t06_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t06_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t06_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t06_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t06_id_istanza_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_istanza_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_id_macchina_t05", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_macchina_t05", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_quantita", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_quantita", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_quantita", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_quantita", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t06_id_stato_istanza_t07", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_stato_istanza_t07", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t06_id_istanza_macchina", System.Data.SqlDbType.Int, 4, "t06_id_istanza_macchina")})
        ''
        ''SqlDeleteCommand4
        ''
        'Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        'Me.SqlDeleteCommand4.Connection = Me.conn
        'Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t06_id_istanza_macchina", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_istanza_macchina", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_id_macchina_t05", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_id_macchina_t05", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_macchina_t05", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_quantita", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_quantita", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_quantita", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_quantita", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_t06_id_stato_istanza_t07", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_id_stato_istanza_t07", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t06_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t06_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t06_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t06_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat06_istanze_macchine
        ''
        'Me.dat06_istanze_macchine.DeleteCommand = Me.SqlDeleteCommand4
        'Me.dat06_istanze_macchine.InsertCommand = Me.SqlInsertCommand5
        'Me.dat06_istanze_macchine.SelectCommand = Me.SqlSelectCommand5
        'Me.dat06_istanze_macchine.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t06_istanze_macchine", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t06_id_istanza_macchina", "t06_id_istanza_macchina"), New System.Data.Common.DataColumnMapping("t06_descrizione", "t06_descrizione"), New System.Data.Common.DataColumnMapping("t06_dt_consegna", "t06_dt_consegna"), New System.Data.Common.DataColumnMapping("t06_id_macchina_t05", "t06_id_macchina_t05"), New System.Data.Common.DataColumnMapping("t06_quantita", "t06_quantita"), New System.Data.Common.DataColumnMapping("t06_id_stato_istanza_t07", "t06_id_stato_istanza_t07"), New System.Data.Common.DataColumnMapping("t06_dt_creazione", "t06_dt_creazione"), New System.Data.Common.DataColumnMapping("t06_dt_modifica", "t06_dt_modifica"), New System.Data.Common.DataColumnMapping("t06_dt_cancellazione", "t06_dt_cancellazione")})})
        'Me.dat06_istanze_macchine.UpdateCommand = Me.SqlUpdateCommand4
        ''
        ''SqlSelectCommand6
        ''
        'Me.SqlSelectCommand6.CommandText = "SELECT     t08_testate_ordini_for.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t08_testate_ordini_for"
        'Me.SqlSelectCommand6.Connection = Me.conn
        ''
        ''SqlInsertCommand6
        ''
        'Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        'Me.SqlInsertCommand6.Connection = Me.conn
        'Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t08_cod_testata_ordine_for", System.Data.SqlDbType.VarChar, 0, "t08_cod_testata_ordine_for"), New System.Data.SqlClient.SqlParameter("@t08_descrizione", System.Data.SqlDbType.VarChar, 0, "t08_descrizione"), New System.Data.SqlClient.SqlParameter("@t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, "t08_id_fornitore_t11"), New System.Data.SqlClient.SqlParameter("@t08_dt_ordine", System.Data.SqlDbType.DateTime, 0, "t08_dt_ordine"), New System.Data.SqlClient.SqlParameter("@t08_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t08_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t08_tipo_ordine", System.Data.SqlDbType.VarChar, 0, "t08_tipo_ordine"), New System.Data.SqlClient.SqlParameter("@t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, "t08_id_causale_ordine_for_t15"), New System.Data.SqlClient.SqlParameter("@t08_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t08_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t08_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t08_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t08_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t08_dt_cancellazione")})
        ''
        ''SqlUpdateCommand5
        ''
        'Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        'Me.SqlUpdateCommand5.Connection = Me.conn
        'Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t08_cod_testata_ordine_for", System.Data.SqlDbType.VarChar, 0, "t08_cod_testata_ordine_for"), New System.Data.SqlClient.SqlParameter("@t08_descrizione", System.Data.SqlDbType.VarChar, 0, "t08_descrizione"), New System.Data.SqlClient.SqlParameter("@t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, "t08_id_fornitore_t11"), New System.Data.SqlClient.SqlParameter("@t08_dt_ordine", System.Data.SqlDbType.DateTime, 0, "t08_dt_ordine"), New System.Data.SqlClient.SqlParameter("@t08_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t08_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t08_tipo_ordine", System.Data.SqlDbType.VarChar, 0, "t08_tipo_ordine"), New System.Data.SqlClient.SqlParameter("@t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, "t08_id_causale_ordine_for_t15"), New System.Data.SqlClient.SqlParameter("@t08_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t08_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t08_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t08_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t08_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t08_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t08_id_testata_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_testata_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_cod_testata_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_cod_testata_ordine_for", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_cod_testata_ordine_for", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_cod_testata_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_id_fornitore_t11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_fornitore_t11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_ordine", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_ordine", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_ordine", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_ordine", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_tipo_ordine", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_tipo_ordine", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_tipo_ordine", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_tipo_ordine", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_id_causale_ordine_for_t15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_causale_ordine_for_t15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t08_id_testata_ordine_for", System.Data.SqlDbType.Int, 4, "t08_id_testata_ordine_for")})
        ''
        ''SqlDeleteCommand5
        ''
        'Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        'Me.SqlDeleteCommand5.Connection = Me.conn
        'Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t08_id_testata_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_testata_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_cod_testata_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_cod_testata_ordine_for", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_cod_testata_ordine_for", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_cod_testata_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_id_fornitore_t11", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_id_fornitore_t11", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_fornitore_t11", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_ordine", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_ordine", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_ordine", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_ordine", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_tipo_ordine", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_tipo_ordine", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_tipo_ordine", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_tipo_ordine", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_id_causale_ordine_for_t15", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_id_causale_ordine_for_t15", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_id_causale_ordine_for_t15", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t08_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t08_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t08_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t08_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat08_testate_ordini_for
        ''
        'Me.dat08_testate_ordini_for.DeleteCommand = Me.SqlDeleteCommand5
        'Me.dat08_testate_ordini_for.InsertCommand = Me.SqlInsertCommand6
        'Me.dat08_testate_ordini_for.SelectCommand = Me.SqlSelectCommand6
        'Me.dat08_testate_ordini_for.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t08_testate_ordini_for", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t08_id_testata_ordine_for", "t08_id_testata_ordine_for"), New System.Data.Common.DataColumnMapping("t08_cod_testata_ordine_for", "t08_cod_testata_ordine_for"), New System.Data.Common.DataColumnMapping("t08_descrizione", "t08_descrizione"), New System.Data.Common.DataColumnMapping("t08_id_fornitore_t11", "t08_id_fornitore_t11"), New System.Data.Common.DataColumnMapping("t08_dt_ordine", "t08_dt_ordine"), New System.Data.Common.DataColumnMapping("t08_dt_consegna", "t08_dt_consegna"), New System.Data.Common.DataColumnMapping("t08_tipo_ordine", "t08_tipo_ordine"), New System.Data.Common.DataColumnMapping("t08_id_causale_ordine_for_t15", "t08_id_causale_ordine_for_t15"), New System.Data.Common.DataColumnMapping("t08_dt_creazione", "t08_dt_creazione"), New System.Data.Common.DataColumnMapping("t08_dt_modifica", "t08_dt_modifica"), New System.Data.Common.DataColumnMapping("t08_dt_cancellazione", "t08_dt_cancellazione")})})
        'Me.dat08_testate_ordini_for.UpdateCommand = Me.SqlUpdateCommand5
        ''
        ''SqlSelectCommand7
        ''
        'Me.SqlSelectCommand7.CommandText = "SELECT     t09_righe_ordine_for.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t09_righe_ordine_for"
        'Me.SqlSelectCommand7.Connection = Me.conn
        ''
        ''SqlInsertCommand7
        ''
        'Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        'Me.SqlInsertCommand7.Connection = Me.conn
        'Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t09_cod_riga_ordine_for", System.Data.SqlDbType.VarChar, 0, "t09_cod_riga_ordine_for"), New System.Data.SqlClient.SqlParameter("@t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, "t09_id_testata_ordine_for_t08"), New System.Data.SqlClient.SqlParameter("@t09_posizione", System.Data.SqlDbType.Int, 0, "t09_posizione"), New System.Data.SqlClient.SqlParameter("@t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t09_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t09_qt_ordinata", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_qt_evasa", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_prezzo_uni", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t09_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.[Char], 0, "t09_id_stato_riga_ordine_t10"), New System.Data.SqlClient.SqlParameter("@t09_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t09_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t09_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t09_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t09_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t09_dt_cancellazione")})
        ''
        ''SqlUpdateCommand6
        ''
        'Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        'Me.SqlUpdateCommand6.Connection = Me.conn
        'Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t09_cod_riga_ordine_for", System.Data.SqlDbType.VarChar, 0, "t09_cod_riga_ordine_for"), New System.Data.SqlClient.SqlParameter("@t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, "t09_id_testata_ordine_for_t08"), New System.Data.SqlClient.SqlParameter("@t09_posizione", System.Data.SqlDbType.Int, 0, "t09_posizione"), New System.Data.SqlClient.SqlParameter("@t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t09_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t09_qt_ordinata", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_qt_evasa", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_prezzo_uni", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t09_dt_consegna", System.Data.SqlDbType.DateTime, 0, "t09_dt_consegna"), New System.Data.SqlClient.SqlParameter("@t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.[Char], 0, "t09_id_stato_riga_ordine_t10"), New System.Data.SqlClient.SqlParameter("@t09_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t09_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t09_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t09_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t09_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t09_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t09_id_riga_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_riga_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_cod_riga_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_cod_riga_ordine_for", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_cod_riga_ordine_for", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_cod_riga_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_testata_ordine_for_t08", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_testata_ordine_for_t08", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_articolo_t20", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_qt_ordinata", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_qt_ordinata", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_qt_evasa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_qt_evasa", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_prezzo_uni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_prezzo_uni", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_stato_riga_ordine_t10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_stato_riga_ordine_t10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t09_id_riga_ordine_for", System.Data.SqlDbType.Int, 4, "t09_id_riga_ordine_for")})
        ''
        ''SqlDeleteCommand6
        ''
        'Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        'Me.SqlDeleteCommand6.Connection = Me.conn
        'Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t09_id_riga_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_riga_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_cod_riga_ordine_for", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_cod_riga_ordine_for", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_cod_riga_ordine_for", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_cod_riga_ordine_for", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_testata_ordine_for_t08", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_testata_ordine_for_t08", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_testata_ordine_for_t08", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_articolo_t20", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_qt_ordinata", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_qt_ordinata", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_ordinata", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_qt_evasa", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_qt_evasa", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_qt_evasa", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_prezzo_uni", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_prezzo_uni", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(2, Byte), "t09_prezzo_uni", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_consegna", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_consegna", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_consegna", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_consegna", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_id_stato_riga_ordine_t10", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_id_stato_riga_ordine_t10", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_id_stato_riga_ordine_t10", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t09_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t09_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t09_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t09_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat09_righe_ordine_for
        ''
        'Me.dat09_righe_ordine_for.DeleteCommand = Me.SqlDeleteCommand6
        'Me.dat09_righe_ordine_for.InsertCommand = Me.SqlInsertCommand7
        'Me.dat09_righe_ordine_for.SelectCommand = Me.SqlSelectCommand7
        'Me.dat09_righe_ordine_for.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t09_righe_ordine_for", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t09_id_riga_ordine_for", "t09_id_riga_ordine_for"), New System.Data.Common.DataColumnMapping("t09_cod_riga_ordine_for", "t09_cod_riga_ordine_for"), New System.Data.Common.DataColumnMapping("t09_id_testata_ordine_for_t08", "t09_id_testata_ordine_for_t08"), New System.Data.Common.DataColumnMapping("t09_posizione", "t09_posizione"), New System.Data.Common.DataColumnMapping("t09_id_articolo_t20", "t09_id_articolo_t20"), New System.Data.Common.DataColumnMapping("t09_qt_ordinata", "t09_qt_ordinata"), New System.Data.Common.DataColumnMapping("t09_qt_evasa", "t09_qt_evasa"), New System.Data.Common.DataColumnMapping("t09_prezzo_uni", "t09_prezzo_uni"), New System.Data.Common.DataColumnMapping("t09_dt_consegna", "t09_dt_consegna"), New System.Data.Common.DataColumnMapping("t09_id_stato_riga_ordine_t10", "t09_id_stato_riga_ordine_t10"), New System.Data.Common.DataColumnMapping("t09_dt_creazione", "t09_dt_creazione"), New System.Data.Common.DataColumnMapping("t09_dt_modifica", "t09_dt_modifica"), New System.Data.Common.DataColumnMapping("t09_dt_cancellazione", "t09_dt_cancellazione")})})
        'Me.dat09_righe_ordine_for.UpdateCommand = Me.SqlUpdateCommand6
        ''
        ''SqlSelectCommand8
        ''
        'Me.SqlSelectCommand8.CommandText = "SELECT     t25_id_matricola, t25_id_articolo_t20, t25_cod_matricola, t25_descrizi" & _
        '    "one, t25_dt_creazione, t25_dt_cancellazione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t25_matricole"
        'Me.SqlSelectCommand8.Connection = Me.conn
        ''
        ''SqlInsertCommand8
        ''
        'Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        'Me.SqlInsertCommand8.Connection = Me.conn
        'Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t25_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t25_cod_matricola", System.Data.SqlDbType.VarChar, 0, "t25_cod_matricola"), New System.Data.SqlClient.SqlParameter("@t25_descrizione", System.Data.SqlDbType.VarChar, 0, "t25_descrizione"), New System.Data.SqlClient.SqlParameter("@t25_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t25_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t25_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t25_dt_cancellazione")})
        ''
        ''SqlUpdateCommand7
        ''
        'Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        'Me.SqlUpdateCommand7.Connection = Me.conn
        'Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, "t25_id_articolo_t20"), New System.Data.SqlClient.SqlParameter("@t25_cod_matricola", System.Data.SqlDbType.VarChar, 0, "t25_cod_matricola"), New System.Data.SqlClient.SqlParameter("@t25_descrizione", System.Data.SqlDbType.VarChar, 0, "t25_descrizione"), New System.Data.SqlClient.SqlParameter("@t25_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t25_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t25_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t25_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t25_id_matricola", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_id_matricola", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_id_articolo_t20", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_cod_matricola", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_cod_matricola", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_cod_matricola", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_cod_matricola", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t25_id_matricola", System.Data.SqlDbType.Int, 4, "t25_id_matricola")})
        ''
        ''SqlDeleteCommand7
        ''
        'Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        'Me.SqlDeleteCommand7.Connection = Me.conn
        'Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t25_id_matricola", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_id_matricola", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_id_articolo_t20", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_id_articolo_t20", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_id_articolo_t20", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_cod_matricola", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_cod_matricola", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_cod_matricola", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_cod_matricola", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t25_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t25_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t25_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t25_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat25_matricole
        ''
        'Me.dat25_matricole.DeleteCommand = Me.SqlDeleteCommand7
        'Me.dat25_matricole.InsertCommand = Me.SqlInsertCommand8
        'Me.dat25_matricole.SelectCommand = Me.SqlSelectCommand8
        'Me.dat25_matricole.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t25_matricole", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t25_id_matricola", "t25_id_matricola"), New System.Data.Common.DataColumnMapping("t25_id_articolo_t20", "t25_id_articolo_t20"), New System.Data.Common.DataColumnMapping("t25_cod_matricola", "t25_cod_matricola"), New System.Data.Common.DataColumnMapping("t25_descrizione", "t25_descrizione"), New System.Data.Common.DataColumnMapping("t25_dt_creazione", "t25_dt_creazione"), New System.Data.Common.DataColumnMapping("t25_dt_cancellazione", "t25_dt_cancellazione")})})
        'Me.dat25_matricole.UpdateCommand = Me.SqlUpdateCommand7
        ''
        ''SqlSelectCommand9
        ''
        'Me.SqlSelectCommand9.CommandText = "SELECT     t26_formule_prezzi.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t26_formule_prezzi"
        'Me.SqlSelectCommand9.Connection = Me.conn
        ''
        ''SqlInsertCommand9
        ''
        'Me.SqlInsertCommand9.CommandText = resources.GetString("SqlInsertCommand9.CommandText")
        'Me.SqlInsertCommand9.Connection = Me.conn
        'Me.SqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t26_cod_formula", System.Data.SqlDbType.VarChar, 0, "t26_cod_formula"), New System.Data.SqlClient.SqlParameter("@t26_descrizione", System.Data.SqlDbType.VarChar, 0, "t26_descrizione"), New System.Data.SqlClient.SqlParameter("@t26_formula_da", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_formula_a", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_prezzo_fisso", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_fattore", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_arrotondamento", System.Data.SqlDbType.SmallInt, 0, "t26_arrotondamento")})
        ''
        ''SqlUpdateCommand8
        ''
        'Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        'Me.SqlUpdateCommand8.Connection = Me.conn
        'Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t26_cod_formula", System.Data.SqlDbType.VarChar, 0, "t26_cod_formula"), New System.Data.SqlClient.SqlParameter("@t26_descrizione", System.Data.SqlDbType.VarChar, 0, "t26_descrizione"), New System.Data.SqlClient.SqlParameter("@t26_formula_da", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_formula_a", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_prezzo_fisso", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_fattore", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@t26_arrotondamento", System.Data.SqlDbType.SmallInt, 0, "t26_arrotondamento"), New System.Data.SqlClient.SqlParameter("@Original_t26_id_formula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_id_formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_cod_formula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_cod_formula", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_cod_formula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_cod_formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_formula_da", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_formula_da", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_formula_a", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_formula_a", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_prezzo_fisso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_prezzo_fisso", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_fattore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_fattore", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_arrotondamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_arrotondamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_arrotondamento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_arrotondamento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t26_id_formula", System.Data.SqlDbType.Int, 4, "t26_id_formula")})
        ''
        ''SqlDeleteCommand8
        ''
        'Me.SqlDeleteCommand8.CommandText = resources.GetString("SqlDeleteCommand8.CommandText")
        'Me.SqlDeleteCommand8.Connection = Me.conn
        'Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t26_id_formula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_id_formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_cod_formula", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_cod_formula", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_cod_formula", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_cod_formula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_formula_da", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_formula_da", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_da", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_formula_a", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_formula_a", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_formula_a", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_prezzo_fisso", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_prezzo_fisso", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_prezzo_fisso", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_fattore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_fattore", System.Data.SqlDbType.[Decimal], 0, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "t26_fattore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t26_arrotondamento", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t26_arrotondamento", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t26_arrotondamento", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t26_arrotondamento", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat26_formule_prezzi
        ''
        'Me.dat26_formule_prezzi.DeleteCommand = Me.SqlDeleteCommand8
        'Me.dat26_formule_prezzi.InsertCommand = Me.SqlInsertCommand9
        'Me.dat26_formule_prezzi.SelectCommand = Me.SqlSelectCommand9
        'Me.dat26_formule_prezzi.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t26_formule_prezzi", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t26_id_formula", "t26_id_formula"), New System.Data.Common.DataColumnMapping("t26_cod_formula", "t26_cod_formula"), New System.Data.Common.DataColumnMapping("t26_descrizione", "t26_descrizione"), New System.Data.Common.DataColumnMapping("t26_formula_da", "t26_formula_da"), New System.Data.Common.DataColumnMapping("t26_formula_a", "t26_formula_a"), New System.Data.Common.DataColumnMapping("t26_prezzo_fisso", "t26_prezzo_fisso"), New System.Data.Common.DataColumnMapping("t26_fattore", "t26_fattore"), New System.Data.Common.DataColumnMapping("t26_arrotondamento", "t26_arrotondamento")})})
        'Me.dat26_formule_prezzi.UpdateCommand = Me.SqlUpdateCommand8
        ''
        ''SqlSelectCommand10
        ''
        'Me.SqlSelectCommand10.CommandText = "SELECT     t11_fornitori.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t11_fornitori"
        'Me.SqlSelectCommand10.Connection = Me.conn
        ''
        ''SqlInsertCommand10
        ''
        'Me.SqlInsertCommand10.CommandText = resources.GetString("SqlInsertCommand10.CommandText")
        'Me.SqlInsertCommand10.Connection = Me.conn
        'Me.SqlInsertCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t11_cod_fornitore", System.Data.SqlDbType.VarChar, 0, "t11_cod_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_descrizione", System.Data.SqlDbType.VarChar, 0, "t11_descrizione"), New System.Data.SqlClient.SqlParameter("@t11_telefono", System.Data.SqlDbType.VarChar, 0, "t11_telefono"), New System.Data.SqlClient.SqlParameter("@t11_note", System.Data.SqlDbType.Text, 0, "t11_note"), New System.Data.SqlClient.SqlParameter("@t11_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t11_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t11_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t11_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t11_dt_cancellazione")})
        ''
        ''SqlUpdateCommand9
        ''
        'Me.SqlUpdateCommand9.CommandText = resources.GetString("SqlUpdateCommand9.CommandText")
        'Me.SqlUpdateCommand9.Connection = Me.conn
        'Me.SqlUpdateCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t11_cod_fornitore", System.Data.SqlDbType.VarChar, 0, "t11_cod_fornitore"), New System.Data.SqlClient.SqlParameter("@t11_descrizione", System.Data.SqlDbType.VarChar, 0, "t11_descrizione"), New System.Data.SqlClient.SqlParameter("@t11_telefono", System.Data.SqlDbType.VarChar, 0, "t11_telefono"), New System.Data.SqlClient.SqlParameter("@t11_note", System.Data.SqlDbType.Text, 0, "t11_note"), New System.Data.SqlClient.SqlParameter("@t11_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t11_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t11_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t11_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t11_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t11_id_fornitore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_id_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_cod_fornitore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_cod_fornitore", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@t11_id_fornitore", System.Data.SqlDbType.Int, 4, "t11_id_fornitore")})
        ''
        ''SqlDeleteCommand9
        ''
        'Me.SqlDeleteCommand9.CommandText = resources.GetString("SqlDeleteCommand9.CommandText")
        'Me.SqlDeleteCommand9.Connection = Me.conn
        'Me.SqlDeleteCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t11_id_fornitore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_id_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_cod_fornitore", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_cod_fornitore", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_cod_fornitore", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_telefono", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_telefono", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_telefono", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t11_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t11_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t11_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''dat11_fornitori
        ''
        'Me.dat11_fornitori.DeleteCommand = Me.SqlDeleteCommand9
        'Me.dat11_fornitori.InsertCommand = Me.SqlInsertCommand10
        'Me.dat11_fornitori.SelectCommand = Me.SqlSelectCommand10
        'Me.dat11_fornitori.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t11_fornitori", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t11_id_fornitore", "t11_id_fornitore"), New System.Data.Common.DataColumnMapping("t11_cod_fornitore", "t11_cod_fornitore"), New System.Data.Common.DataColumnMapping("t11_descrizione", "t11_descrizione"), New System.Data.Common.DataColumnMapping("t11_telefono", "t11_telefono"), New System.Data.Common.DataColumnMapping("t11_note", "t11_note"), New System.Data.Common.DataColumnMapping("t11_dt_creazione", "t11_dt_creazione"), New System.Data.Common.DataColumnMapping("t11_dt_modifica", "t11_dt_modifica"), New System.Data.Common.DataColumnMapping("t11_dt_cancellazione", "t11_dt_cancellazione")})})
        'Me.dat11_fornitori.UpdateCommand = Me.SqlUpdateCommand9
        ''
        ''dat07_stati_istanza
        ''
        'Me.dat07_stati_istanza.DeleteCommand = Me.SqlDeleteCommand
        'Me.dat07_stati_istanza.InsertCommand = Me.SqlInsertCommand
        'Me.dat07_stati_istanza.SelectCommand = Me.SqlSelectCommand
        'Me.dat07_stati_istanza.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t07_stati_istanza", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t07_id_stato_istanza", "t07_id_stato_istanza"), New System.Data.Common.DataColumnMapping("t07_descrizione", "t07_descrizione"), New System.Data.Common.DataColumnMapping("t07_posizione", "t07_posizione"), New System.Data.Common.DataColumnMapping("t07_dt_creazione", "t07_dt_creazione"), New System.Data.Common.DataColumnMapping("t07_dt_modifica", "t07_dt_modifica"), New System.Data.Common.DataColumnMapping("t07_dt_cancellazione", "t07_dt_cancellazione")})})
        'Me.dat07_stati_istanza.UpdateCommand = Me.SqlUpdateCommand
        ''
        ''SqlDeleteCommand
        ''
        'Me.SqlDeleteCommand.CommandText = resources.GetString("SqlDeleteCommand.CommandText")
        'Me.SqlDeleteCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_t07_id_stato_istanza", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_id_stato_istanza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_posizione", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        ''
        ''SqlInsertCommand
        ''
        'Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        'Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t07_id_stato_istanza", System.Data.SqlDbType.[Char], 0, "t07_id_stato_istanza"), New System.Data.SqlClient.SqlParameter("@t07_descrizione", System.Data.SqlDbType.VarChar, 0, "t07_descrizione"), New System.Data.SqlClient.SqlParameter("@t07_posizione", System.Data.SqlDbType.TinyInt, 0, "t07_posizione"), New System.Data.SqlClient.SqlParameter("@t07_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t07_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t07_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t07_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t07_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t07_dt_cancellazione")})
        ''
        ''SqlSelectCommand
        ''
        'Me.SqlSelectCommand.CommandText = "SELECT     t07_stati_istanza.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         t07_stati_istanza"
        ''
        ''SqlUpdateCommand
        ''
        'Me.SqlUpdateCommand.CommandText = resources.GetString("SqlUpdateCommand.CommandText")
        'Me.SqlUpdateCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t07_id_stato_istanza", System.Data.SqlDbType.[Char], 0, "t07_id_stato_istanza"), New System.Data.SqlClient.SqlParameter("@t07_descrizione", System.Data.SqlDbType.VarChar, 0, "t07_descrizione"), New System.Data.SqlClient.SqlParameter("@t07_posizione", System.Data.SqlDbType.TinyInt, 0, "t07_posizione"), New System.Data.SqlClient.SqlParameter("@t07_dt_creazione", System.Data.SqlDbType.DateTime, 0, "t07_dt_creazione"), New System.Data.SqlClient.SqlParameter("@t07_dt_modifica", System.Data.SqlDbType.DateTime, 0, "t07_dt_modifica"), New System.Data.SqlClient.SqlParameter("@t07_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, "t07_dt_cancellazione"), New System.Data.SqlClient.SqlParameter("@Original_t07_id_stato_istanza", System.Data.SqlDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_id_stato_istanza", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_descrizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_descrizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_descrizione", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_descrizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_posizione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_posizione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_posizione", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_posizione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_creazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_creazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_creazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_creazione", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_modifica", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_modifica", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_modifica", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_modifica", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_t07_dt_cancellazione", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "t07_dt_cancellazione", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_t07_dt_cancellazione", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "t07_dt_cancellazione", System.Data.DataRowVersion.Original, Nothing)})
        '
        'GestioneProduzione2009DataSet1
        '
        Me.GestioneProduzione2009DataSet1.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T11_fornitoriTableAdapter1
        '
        Me.T11_fornitoriTableAdapter1.ClearBeforeFill = True
        '
        'T20_articoliTableAdapter1
        '
        Me.T20_articoliTableAdapter1.ClearBeforeFill = True
        '
        'T21_articoli_macchineTableAdapter1
        '
        Me.T21_articoli_macchineTableAdapter1.ClearBeforeFill = True
        '
        'T22_articoli_articoliTableAdapter1
        '
        Me.T22_articoli_articoliTableAdapter1.ClearBeforeFill = True
        '
        'T07_stati_istanzaTableAdapter1
        '
        Me.T07_stati_istanzaTableAdapter1.ClearBeforeFill = True
        '
        'T06_istanze_macchineTableAdapter1
        '
        Me.T06_istanze_macchineTableAdapter1.ClearBeforeFill = True
        '
        'T05_macchineTableAdapter1
        '
        Me.T05_macchineTableAdapter1.ClearBeforeFill = True
        '
        'T25_matricoleTableAdapter1
        '
        Me.T25_matricoleTableAdapter1.ClearBeforeFill = True
        '
        'T08_testate_ordini_forTableAdapter1
        '
        Me.T08_testate_ordini_forTableAdapter1.ClearBeforeFill = True
        '
        'T09_righe_ordine_forTableAdapter1
        '
        Me.T09_righe_ordine_forTableAdapter1.ClearBeforeFill = True
        '
        'T26_formule_prezziTableAdapter1
        '
        Me.T26_formule_prezziTableAdapter1.ClearBeforeFill = True
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Public Const COMMESSA_STATO_ANNULLATA = "A" 'COMMESSA_STATO_ANNULLATA
    Public Const COMMESSA_STATO_CHIUSA = "C"
    Public Const COMMESSA_STATO_IN_PRODUZIONE = "P"
    Public Const COMMESSA_STATO_SOSPESA = "S" 'COMMESSA_STATO_SOSPESA

    Public Const STATO_RIGA_ORDINE_FOR_APERTA = "A"
    Public Const STATO_RIGA_ORDINE_FOR_EVASA = "E"

    Public Const ORDINE_FOR_CAUSALE_ACQUISTO = 1
    Public Const ORDINE_FOR_CAUSALE_CLAVORAZIONE = 2

    Public Sub Init()
        'conn.ConnectionString = Global.GestioneProduzione.My.MySettings.Default.GestioneProduzione2009ConnectionString.ToString() 'CType(configurationAppSettings.GetValue("conn.ConnectionString", GetType(String)), String)
    End Sub


    ''' <summary>
    ''' Riempie il dataset con i valori dal database, utilizzando la stringa di connessione predefinita
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Fill()

        Try
            'Me.Init()

            'Me.GestioneProduzione2009DataSet1.Clear()

            'Me.conn.Open()

            'dat20_articoli.SelectCommand.Connection = conn
            'dat20_articoli.InsertCommand.Connection = conn
            'dat20_articoli.UpdateCommand.Connection = conn
            'dat20_articoli.DeleteCommand.Connection = conn
            'dat20_articoli.Fill(Me.GestioneProduzione2009DataSet1.t20_articoli)
            Me.T20_articoliTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t20_articoli)

            'dat22_articoli_articoli.SelectCommand.Connection = conn
            'dat22_articoli_articoli.InsertCommand.Connection = conn
            ''dat22_articoli_articoli.UpdateCommand.Connection = conn
            ''dat22_articoli_articoli.DeleteCommand.Connection = conn
            'dat22_articoli_articoli.Fill(Me.GestioneProduzione2009DataSet1.t22_articoli_articoli)
            Me.T22_articoli_articoliTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t22_articoli_articoli)

            'dat05_macchine.SelectCommand.Connection = conn
            'dat05_macchine.InsertCommand.Connection = conn
            'dat05_macchine.UpdateCommand.Connection = conn
            'dat05_macchine.DeleteCommand.Connection = conn
            'dat05_macchine.Fill(Me.GestioneProduzione2009DataSet1.t05_macchine)
            Me.T05_macchineTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t05_macchine)

            'dat06_istanze_macchine.SelectCommand.Connection = conn
            'dat06_istanze_macchine.SelectCommand.CommandText = "SELECT * FROM t06_istanze_macchine WHERE (t06_dt_cancellazione IS NULL) ORDER BY t06_dt_consegna DESC, t06_id_stato_istanza_t07"
            'dat06_istanze_macchine.InsertCommand.Connection = conn
            'dat06_istanze_macchine.UpdateCommand.Connection = conn
            'dat06_istanze_macchine.DeleteCommand.Connection = conn
            'dat06_istanze_macchine.Fill(Me.GestioneProduzione2009DataSet1.t06_istanze_macchine)
            Me.T06_istanze_macchineTableAdapter1.FillBy(Me.GestioneProduzione2009DataSet1.t06_istanze_macchine)

            'dat21_articoli_macchine.SelectCommand.Connection = conn
            'dat21_articoli_macchine.InsertCommand.Connection = conn
            'dat21_articoli_macchine.UpdateCommand.Connection = conn
            'dat21_articoli_macchine.DeleteCommand.Connection = conn
            'dat21_articoli_macchine.Fill(Me.GestioneProduzione2009DataSet1.t21_articoli_macchine)
            Me.T21_articoli_macchineTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t21_articoli_macchine)

            'dat08_testate_ordini_for.SelectCommand.Connection = conn
            'dat08_testate_ordini_for.InsertCommand.Connection = conn
            'dat08_testate_ordini_for.UpdateCommand.Connection = conn
            'dat08_testate_ordini_for.DeleteCommand.Connection = conn
            'dat08_testate_ordini_for.Fill(Me.GestioneProduzione2009DataSet1.t08_testate_ordini_for)
            Me.T08_testate_ordini_forTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t08_testate_ordini_for)

            'dat09_righe_ordine_for.SelectCommand.Connection = conn
            'dat09_righe_ordine_for.InsertCommand.Connection = conn
            'dat09_righe_ordine_for.UpdateCommand.Connection = conn
            'dat09_righe_ordine_for.DeleteCommand.Connection = conn
            'dat09_righe_ordine_for.Fill(Me.GestioneProduzione2009DataSet1.t09_righe_ordine_for)
            Me.T09_righe_ordine_forTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t09_righe_ordine_for)

            'dat25_matricole.SelectCommand.Connection = conn
            'dat25_matricole.InsertCommand.Connection = conn
            'dat25_matricole.UpdateCommand.Connection = conn
            'dat25_matricole.DeleteCommand.Connection = conn
            'dat25_matricole.Fill(Me.GestioneProduzione2009DataSet1.t25_matricole)
            Me.T25_matricoleTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t25_matricole)

            'dat26_formule_prezzi.SelectCommand.Connection = conn
            'dat26_formule_prezzi.InsertCommand.Connection = conn
            'dat26_formule_prezzi.DeleteCommand.Connection = conn
            'dat26_formule_prezzi.UpdateCommand.Connection = conn
            'dat26_formule_prezzi.Fill(Me.GestioneProduzione2009DataSet1.t26_formule_prezzi)
            Me.T26_formule_prezziTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t26_formule_prezzi)

            'dat11_fornitori.SelectCommand.Connection = conn
            'dat11_fornitori.InsertCommand.Connection = conn
            'dat11_fornitori.DeleteCommand.Connection = conn
            'dat11_fornitori.UpdateCommand.Connection = conn
            'dat11_fornitori.Fill(Me.GestioneProduzione2009DataSet1.t11_fornitori)
            Me.T11_fornitoriTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t11_fornitori)

            'dat07_stati_istanza.SelectCommand.Connection = conn
            'dat07_stati_istanza.InsertCommand.Connection = conn
            'dat07_stati_istanza.DeleteCommand.Connection = conn
            'dat07_stati_istanza.UpdateCommand.Connection = conn
            'dat07_stati_istanza.Fill(Me.GestioneProduzione2009DataSet1.t07_stati_istanza)
            Me.T07_stati_istanzaTableAdapter1.Fill(Me.GestioneProduzione2009DataSet1.t07_stati_istanza)

        Catch e As Exception
            Throw e
        Finally
            'If Me.conn.State = ConnectionState.Open Then
            '    conn.Close()
            'End If
        End Try

    End Sub

    ''' <summary>
    ''' Procedura unificata per il calcolo dello stato degli articoli.
    ''' </summary>
    ''' <param name="TreeView1">Passare un oggetto valido se si vuole riempire il treeview</param>
    ''' <remarks></remarks>
    Public Sub PreparaDati(ByVal TreeView1 As TreeView)

        ArticoliInGruppi()

        'EsplodiDistinte()
        EsplodiDistinte2(TreeView1)
        'CalcolaConsumiArticoli()
        CalcolaConsumiArticoli2()
        CalcolaArticoliInOrdine()
        RiepilogoArticoli()

        'If Not TreeView1 Is Nothing Then
        '    AggiornaStatoTreeView(TreeView1)
        'End If

    End Sub

    ''' <summary>
    ''' Esplode la distinta della macchina e calcola i consumi degli articoli 
    ''' considerando anche le quantità a magazzino dei gruppi
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EsplodiDistinte2(ByVal TreeView1 As TreeView)
        Dim qt_produzione As Integer

        Me.GestioneProduzione2009DataSet1.Impegnati.Clear()

        'Ciclo per tute le macchine in produzione
        For Each macchina_in_produzione As GestioneProduzione2009DataSet.t06_istanze_macchineRow In Me.GestioneProduzione2009DataSet1.t06_istanze_macchine.Rows
            'Debug.WriteLine("macchina_in_produzione" & macchina_in_produzione.t06_id_istanza_macchina)

            If macchina_in_produzione.Ist06_dt_cancellazioneNull And _
            (macchina_in_produzione.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_IN_PRODUZIONE Or macchina_in_produzione.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_SOSPESA) Then

                qt_produzione = macchina_in_produzione.t06_quantita

                'Ciclo per tutte le macchine
                Dim tipo_macchina As GestioneProduzione2009DataSet.t05_macchineRow = macchina_in_produzione.GetParentRow("FK_t06_istanze_macchine_t05_macchine") '("GetParentRow t05_macchinet06_istanze_macchine")

                Dim nodoMacchina As TreeNode = Nothing
                If Not TreeView1 Is Nothing Then
                    nodoMacchina = TreeView1.Nodes.Add(macchina_in_produzione.t06_quantita & " x " & macchina_in_produzione.t06_descrizione & " - " & tipo_macchina.t05_descrizione)
                    nodoMacchina.ImageIndex = 0
                    nodoMacchina.SelectedImageIndex = 0
                    nodoMacchina.Tag = macchina_in_produzione.t06_id_istanza_macchina
                    If macchina_in_produzione.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_SOSPESA Then
                        nodoMacchina.BackColor = Color.LightBlue
                    End If
                End If

                ' Ciclo per tutti gli articoli collegati alle macchine
                For Each macchina_articoli As GestioneProduzione2009DataSet.t21_articoli_macchineRow In tipo_macchina.Gett21_articoli_macchineRows  '"GetChildRows t05_macchinet21_articoli_macchine")
                    Dim articolo As GestioneProduzione2009DataSet.t20_articoliRow = macchina_articoli.GetParentRow("FK_t21_articoli_macchine_t20_articoli") '"GetParentRow t20_articolit21_articoli_macchine")

                    ' Se il collegamento non è stato cancellato e neppure l'articolo collegato
                    If (macchina_articoli.Ist21_dt_cancellazioneNull And _
                        articolo.Ist20_dt_cancellazioneNull) Then

                        Dim consumo_calcolato As Decimal = 0
                        Dim consumo_effettivo As Decimal = 0
                        Dim disponibilta_gruppo As Decimal = 0
                        Dim impegnato As Decimal = 0

                        consumo_calcolato = qt_produzione * macchina_articoli.t21_consumo

                        If Not articolo.Ist20_qt_disponibileNull Then
                            disponibilta_gruppo = articolo.t20_qt_disponibile
                        End If

                        'Verifico se l'articolo è un Gruppo e ne ho a Magazzino
                        If (articolo.t20_is_gruppo) Then

                            'Verifico se il gruppo è disponibile a magazzino
                            'e togliendo quello che eventualmente è già stato impegnato per altre macchine
                            'ottengo quello che ho ancora a disposizione
                            If (disponibilta_gruppo > 0) Then
                                impegnato = CalcolaImpegnoArticolo(articolo.t20_id_articolo)

                                'DisponibilitaArticolo
                                consumo_effettivo = consumo_calcolato - (disponibilta_gruppo - impegnato)

                                ' Se ho quantita minori di zero significa che ho tutto quanto mi serve a magazzino
                                If consumo_effettivo < 0 Then
                                    consumo_effettivo = 0
                                End If

                                impegnato = consumo_calcolato - consumo_effettivo
                            Else
                                consumo_effettivo = consumo_calcolato
                            End If


                        Else
                            consumo_effettivo = consumo_calcolato
                        End If

                        Dim rigaImpeganti As GestioneProduzione2009DataSet.ImpegnatiRow = Me.GestioneProduzione2009DataSet1.Impegnati.NewImpegnatiRow()
                        rigaImpeganti.t06_id_istanza_macchina = macchina_in_produzione.t06_id_istanza_macchina
                        rigaImpeganti.t21_id_macchina_t05 = macchina_articoli.t21_id_macchina_t05
                        rigaImpeganti.t22_id_articolo_t20 = articolo.t20_id_articolo
                        rigaImpeganti.Sett22_id_articolo_padre_t20Null()
                        rigaImpeganti.t20_is_gruppo = articolo.t20_is_gruppo
                        rigaImpeganti.t20_is_gruppo_padre = True
                        rigaImpeganti.t22_consumo = macchina_articoli.t21_consumo
                        rigaImpeganti.consumo_calcolato = consumo_calcolato

                        rigaImpeganti.magazzino = disponibilta_gruppo
                        rigaImpeganti.consumo_effettivo = consumo_effettivo
                        rigaImpeganti.impegnato = impegnato
                        rigaImpeganti.magazzinoSufficiente = disponibilta_gruppo - impegnato >= 0

                        rigaImpeganti.t22_posizione = macchina_articoli.t21_posizione
                        rigaImpeganti.lvl = 1
                        rigaImpeganti.t06_id_stato_istanza_t07 = macchina_in_produzione.t06_id_stato_istanza_t07
                        rigaImpeganti.riga_cod = articolo.t20_cod_articolo
                        rigaImpeganti.riga_descrizione = articolo.t20_descrizione
                        Me.GestioneProduzione2009DataSet1.Impegnati.AddImpegnatiRow(rigaImpeganti)

                        Dim nodoArticolo As TreeNode = Nothing
                        If Not TreeView1 Is Nothing Then
                            nodoArticolo = nodoMacchina.Nodes.Add(macchina_articoli.t21_consumo & " x " & articolo.t20_descrizione)
                            If articolo.t20_is_gruppo Then
                                nodoArticolo.ImageIndex = 1
                                nodoArticolo.SelectedImageIndex = 1
                            Else
                                nodoArticolo.ImageIndex = 2
                                nodoArticolo.SelectedImageIndex = 2
                            End If
                            'ID Articolo nel Tag del nodo
                            nodoArticolo.Tag = rigaImpeganti.t22_id_articolo_t20

                            If rigaImpeganti.consumo_effettivo = 0 Then
                                nodoArticolo.ForeColor = Color.Gray
                            ElseIf rigaImpeganti.magazzinoSufficiente = False Then
                                nodoArticolo.ForeColor = Color.Red
                            End If
                        End If

                        AlberoDeiFigli2(articolo, rigaImpeganti, nodoArticolo)

                        If Not TreeView1 Is Nothing Then
                            For Each nodofiglio As TreeNode In nodoArticolo.Nodes
                                If nodofiglio.ForeColor = Color.Red Then
                                    nodoArticolo.ForeColor = Color.Red
                                End If
                            Next
                        End If
                    End If
                Next

                If Not TreeView1 Is Nothing Then
                    For Each nodofiglio As TreeNode In nodoMacchina.Nodes
                        If nodofiglio.ForeColor = Color.Red Then
                            nodoMacchina.ForeColor = Color.Red
                        End If
                    Next
                End If
            End If
        Next

        'GestioneProduzione2009DataSet.Impegnati.WriteXml("C:\Impegnati.xml")
    End Sub

    ''' <summary>
    ''' AGGIUNTO DA MIRCO il 15-10-2014 per velocizzare il ciclo
    ''' </summary>
    ''' <remarks></remarks>
    Dim impegnoFast As Dictionary(Of Integer, Decimal)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="t20_id_articolo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CalcolaImpegnoArticolo(ByVal t20_id_articolo As Integer) As Decimal
        Dim impegno As Decimal = 0

        '' Procedura normale, esistente che per ogni chiamata cicla per la somma
        'For Each riga As GestioneProduzione2009DataSet.ImpegnatiRow In Me.GestioneProduzione2009DataSet1.Impegnati
        '    If riga.t22_id_articolo_t20 = t20_id_articolo Then
        '        impegno = impegno + riga.impegnato
        '    End If
        'Next

        ' Procedura 2014, somma tutti in un ciclo e poi usiamo il dictionary
        If impegnoFast Is Nothing Then
            impegnoFast = New Dictionary(Of Integer, Decimal)

            For Each riga As GestioneProduzione2009DataSet.ImpegnatiRow In Me.GestioneProduzione2009DataSet1.Impegnati
                Dim idArticolo = riga.t22_id_articolo_t20
                Dim sumByArticolo As Decimal = 0
                If impegnoFast.ContainsKey(idArticolo) Then
                    sumByArticolo = impegnoFast(idArticolo)
                End If
                sumByArticolo = sumByArticolo + riga.impegnato
                impegnoFast(idArticolo) = sumByArticolo
            Next
            Console.WriteLine("CalcolaImpegnoArticolo")
        End If

        If impegnoFast.ContainsKey(t20_id_articolo) Then
            impegno = impegnoFast(t20_id_articolo)
        End If

        CalcolaImpegnoArticolo = impegno
    End Function

    ''' <summary>
    ''' Esplode la distinta della macchina e calcola i consumi degli articoli 
    ''' considerando anche le quantità a magazzino dei gruppi
    ''' </summary>
    ''' <param name="articolo"></param>
    ''' <param name="calcolo_precedente"></param>
    ''' <remarks></remarks>
    Private Sub AlberoDeiFigli2(ByVal articolo As GestioneProduzione2009DataSet.t20_articoliRow, ByVal calcolo_precedente As GestioneProduzione2009DataSet.ImpegnatiRow, ByVal nodo As TreeNode)

        ' Questa relazione mi da tutti i figli
        'GetChildRows("t20_articolit22_articoli_articoli1")
        If articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1.Length > 0 Then
            'Debug.WriteLine("ha figli")
            For Each articoli_figli As GestioneProduzione2009DataSet.t22_articoli_articoliRow In articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1  'GetChildRows "t20_articolit22_articoli_articoli1")
                Dim articolo_figlio As GestioneProduzione2009DataSet.t20_articoliRow = articoli_figli.GetParentRow("FK_t22_articoli_articoli_t20_articoli") 'GetParentRow "t20_articolit22_articoli_articoli")

                If (articolo_figlio.Ist20_dt_cancellazioneNull) Then

                    Dim consumo_calcolato As Decimal = 0
                    Dim consumo_effettivo As Decimal = 0
                    Dim disponibilta_gruppo As Decimal = 0
                    Dim impegnato As Decimal = 0

                    'IL CONSUMO_EFFETTIVO è IL CONSUMO_RESIDUO
                    consumo_calcolato = articoli_figli.t22_consumo * calcolo_precedente.consumo_effettivo

                    If Not articolo_figlio.Ist20_qt_disponibileNull Then
                        disponibilta_gruppo = articolo_figlio.t20_qt_disponibile
                    Else
                        disponibilta_gruppo = 0
                    End If

                    'Verifico se l'articolo è un Gruppo e ne ho a Magazzino
                    If (articolo_figlio.t20_is_gruppo) Then

                        'Verifico se il gruppo è disponibile a magazzino
                        'e togliendo quello che eventualmente è già stato impegnato per altre macchine
                        'ottengo quello che ho ancora a disposizione
                        If (disponibilta_gruppo > 0) Then
                            impegnato = CalcolaImpegnoArticolo(articolo_figlio.t20_id_articolo)

                            'DisponibilitaArticolo
                            consumo_effettivo = consumo_calcolato - (disponibilta_gruppo - impegnato)

                            ' Se ho quantita minori di zero significa che ho tutto quanto mi serve a magazzino
                            If consumo_effettivo < 0 Then
                                consumo_effettivo = 0
                            End If

                            impegnato = consumo_calcolato - consumo_effettivo
                        Else
                            consumo_effettivo = consumo_calcolato
                        End If
                    Else
                        consumo_effettivo = consumo_calcolato
                        impegnato = consumo_calcolato
                    End If


                    Dim rigaImpegnati As GestioneProduzione2009DataSet.ImpegnatiRow = Me.GestioneProduzione2009DataSet1.Impegnati.NewImpegnatiRow()
                    rigaImpegnati.t06_id_istanza_macchina = calcolo_precedente.t06_id_istanza_macchina
                    rigaImpegnati.t21_id_macchina_t05 = calcolo_precedente.t21_id_macchina_t05
                    rigaImpegnati.t22_id_articolo_t20 = articolo_figlio.t20_id_articolo
                    rigaImpegnati.t22_id_articolo_padre_t20 = articolo.t20_id_articolo
                    rigaImpegnati.t20_is_gruppo = articolo_figlio.t20_is_gruppo
                    rigaImpegnati.t20_is_gruppo_padre = articolo.t20_is_gruppo
                    rigaImpegnati.t22_consumo = articoli_figli.t22_consumo
                    rigaImpegnati.consumo_calcolato = articoli_figli.t22_consumo * calcolo_precedente.consumo_calcolato

                    rigaImpegnati.magazzino = disponibilta_gruppo
                    rigaImpegnati.consumo_effettivo = consumo_effettivo  'articoli_figli.t22_consumo * calcolo_precedente.consumo_effettivo
                    rigaImpegnati.impegnato = impegnato
                    rigaImpegnati.magazzinoSufficiente = disponibilta_gruppo - impegnato >= 0

                    rigaImpegnati.t22_posizione = articoli_figli.t22_posizione
                    rigaImpegnati.lvl = calcolo_precedente.lvl + 1
                    rigaImpegnati.t06_id_stato_istanza_t07 = calcolo_precedente.t06_id_stato_istanza_t07
                    rigaImpegnati.riga_cod = articolo_figlio.t20_cod_articolo
                    rigaImpegnati.riga_descrizione = articolo_figlio.t20_descrizione
                    'Aggiungo agli impegati solo se è un articolo o un gruppo (non un articolo figlio di un articolo)
                    If Not articolo_figlio.t20_is_gruppo And articolo.t20_is_gruppo Then
                        Me.GestioneProduzione2009DataSet1.Impegnati.AddImpegnatiRow(rigaImpegnati)
                    End If

                    Dim nodoArticoloFiglio As TreeNode = Nothing
                    If Not nodo Is Nothing Then
                        nodoArticoloFiglio = nodo.Nodes.Add(articoli_figli.t22_consumo & " x " & articolo_figlio.t20_cod_articolo & " - " & articolo_figlio.t20_descrizione)
                        'Dim nodoArticoloFiglio As TreeNode = nodo.Nodes.Add(articoli_figli.t22_consumo & " x " & articolo_figlio.t20_id_articolo)
                        If articolo_figlio.t20_is_gruppo Then
                            nodoArticoloFiglio.ImageIndex = 1
                            nodoArticoloFiglio.SelectedImageIndex = 1
                        Else
                            nodoArticoloFiglio.ImageIndex = 2
                            nodoArticoloFiglio.SelectedImageIndex = 2
                        End If
                        'ID Articolo nel Tag del nodo
                        nodoArticoloFiglio.Tag = rigaImpegnati.t22_id_articolo_t20

                        ' Verifico che l'articolo corrente sia figlio di un gruppo
                        ' e non di un articolo (quindi un grezzo)
                        If Not articolo_figlio.t20_is_gruppo And articolo.t20_is_gruppo Then
                            If rigaImpegnati.consumo_effettivo = 0 Then
                                nodoArticoloFiglio.ForeColor = Color.Gray
                            ElseIf rigaImpegnati.magazzinoSufficiente = False Then
                                nodoArticoloFiglio.ForeColor = Color.Red
                            End If
                        End If

                    End If

                    AlberoDeiFigli2(articolo_figlio, rigaImpegnati, nodoArticoloFiglio)
                    If Not nodoArticoloFiglio Is Nothing Then
                        For Each nodofiglio As TreeNode In nodoArticoloFiglio.Nodes
                            If nodofiglio.ForeColor = Color.Red Then
                                nodoArticoloFiglio.ForeColor = Color.Red
                            End If
                        Next
                    End If
                End If
            Next
        Else
            'Debug.WriteLine("è foglia")
        End If

    End Sub

    ''' <summary>
    ''' Questa procedura somma i consumi per raggruppati per articoli e gruppi che sono figli di un gruppo.
    ''' In questo modo non vengono scaricati i figli di un articolo con distinta.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CalcolaConsumiArticoli2()

        ' Creo una tabella con i consumi totati per articolo e per gruppi
        Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.Clear()
        Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.DefaultView.Sort = "t22_id_articolo_t20"
        Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.Clear()
        Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.DefaultView.Sort = "t22_id_articolo_t20"

        For Each articolo As GestioneProduzione2009DataSet.ImpegnatiRow In Me.GestioneProduzione2009DataSet1.Impegnati.Rows

            ' ARTICOLI

            ' Considero l'articolo solo se è un figlio di un gruppo ed in produzione
            ' le condizioni sono state copiate dalla relativa view
            If Not articolo.Ist20_is_gruppoNull And _
                articolo.t20_is_gruppo = False And _
                articolo.t20_is_gruppo_padre = True And _
                (articolo.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_IN_PRODUZIONE Or _
                 articolo.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_SOSPESA) Then
                Dim rigaConsumo As GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliArticoliRow

                ' Verifico se esiste già nella tabella una riga per questo articolo
                If Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.DefaultView.Find(articolo.t22_id_articolo_t20) > -1 Then

                    rigaConsumo = CType(Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.DefaultView.FindRows(articolo.t22_id_articolo_t20)(0).Row, GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliArticoliRow)
                    rigaConsumo.t22_id_articolo_t20 = articolo.t22_id_articolo_t20
                    rigaConsumo.consumo_totale = rigaConsumo.consumo_totale + articolo.consumo_effettivo 'rigaConsumo.consumo_totale + articolo.consumo_calcolato

                    rigaConsumo.AcceptChanges()
                Else
                    rigaConsumo = Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.NewviewTreeIstanzeMacchineTotaliArticoliRow()
                    rigaConsumo.t22_id_articolo_t20 = articolo.t22_id_articolo_t20
                    rigaConsumo.consumo_totale = articolo.consumo_effettivo 'articolo.consumo_calcolato

                    Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.AddviewTreeIstanzeMacchineTotaliArticoliRow(rigaConsumo)
                End If
            End If

            ' GRUPPI

            ' Considero l'articolo solo se è un figlio di un gruppo ed in produzione
            ' le condizioni sono state copiate dalla relativa view
            If Not articolo.Ist20_is_gruppoNull And _
                articolo.t20_is_gruppo = True And _
                articolo.t20_is_gruppo_padre = True And _
                (articolo.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_IN_PRODUZIONE Or _
                 articolo.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_SOSPESA) Then

                Dim rigaConsumo As GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliGruppiRow
                ' Verifico se esiste già nella tabella una riga per questo articolo
                If Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.DefaultView.Find(articolo.t22_id_articolo_t20) > -1 Then
                    rigaConsumo = CType(Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.DefaultView.FindRows(articolo.t22_id_articolo_t20)(0).Row, GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliGruppiRow)
                    rigaConsumo.t22_id_articolo_t20 = articolo.t22_id_articolo_t20
                    'NEI GRUPPI USO L'IMPEGNATO calcolato in PRECEDENZA in fase di esplosione della distinta
                    rigaConsumo.consumo_totale = rigaConsumo.consumo_totale + articolo.impegnato 'articolo.consumo_effettivo 'rigaConsumo.consumo_totale + articolo.consumo_calcolato

                    rigaConsumo.AcceptChanges()
                Else
                    rigaConsumo = Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.NewviewTreeIstanzeMacchineTotaliGruppiRow()
                    rigaConsumo.t22_id_articolo_t20 = articolo.t22_id_articolo_t20
                    'NEI GRUPPI USO L'IMPEGNATO calcolato in PRECEDENZA in fase di esplosione della distinta
                    rigaConsumo.consumo_totale = articolo.impegnato ' articolo.consumo_effettivo 'articolo.consumo_calcolato

                    Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.AddviewTreeIstanzeMacchineTotaliGruppiRow(rigaConsumo)
                End If
            End If
        Next

        'GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliArticoli.WriteXml("C:\viewTreeIstanzeMacchineTotaliArticoli.xml")
        'GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliGruppi.WriteXml("C:\viewTreeIstanzeMacchineTotaliGruppi.xml")

    End Sub

    Private Sub CalcolaArticoliInOrdine()

        Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.Clear()
        Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.DefaultView.Sort = "t22_id_articolo_t20"

        For Each ordine As GestioneProduzione2009DataSet.t08_testate_ordini_forRow In Me.GestioneProduzione2009DataSet1.t08_testate_ordini_for.Rows

            If ordine.Ist08_dt_cancellazioneNull Then

                For Each riga_ordine As GestioneProduzione2009DataSet.t09_righe_ordine_forRow In ordine.Gett09_righe_ordine_forRows()  'GetChildRows("t08_testate_ordini_fort09_righe_ordine_for")

                    If riga_ordine.t09_id_stato_riga_ordine_t10 = DataModel.STATO_RIGA_ORDINE_FOR_APERTA Then
                        Dim rigaOrdinato As GestioneProduzione2009DataSet.ufn_GetQuantitaOrdinataArticoloRow
                        'Verifico se ho gia' messo una riga riepilogativa per l'ordinato di questo articolo
                        If Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.DefaultView.Find(riga_ordine.t09_id_articolo_t20) > -1 Then

                            rigaOrdinato = CType(Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.DefaultView.FindRows(riga_ordine.t09_id_articolo_t20)(0).Row, GestioneProduzione2009DataSet.ufn_GetQuantitaOrdinataArticoloRow)
                            rigaOrdinato.t22_id_articolo_t20 = riga_ordine.t09_id_articolo_t20
                            rigaOrdinato.t09_qt_ordinata = rigaOrdinato.t09_qt_ordinata + riga_ordine.t09_qt_ordinata
                            rigaOrdinato.t09_qt_evasa = rigaOrdinato.t09_qt_evasa + riga_ordine.t09_qt_evasa

                            rigaOrdinato.AcceptChanges()
                        Else
                            rigaOrdinato = Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.Newufn_GetQuantitaOrdinataArticoloRow()
                            rigaOrdinato.t22_id_articolo_t20 = riga_ordine.t09_id_articolo_t20
                            rigaOrdinato.t09_qt_ordinata = riga_ordine.t09_qt_ordinata
                            rigaOrdinato.t09_qt_evasa = riga_ordine.t09_qt_evasa

                            Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.Addufn_GetQuantitaOrdinataArticoloRow(rigaOrdinato)
                        End If
                    End If
                Next

            End If

        Next

        'Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.WriteXml("C:\ufn_GetQuantitaOrdinataArticolo.xml")
    End Sub

    Private Sub RiepilogoArticoli()
        Dim quantita_disponibile As Decimal
        Dim lotto_riordino As Decimal
        Dim consumo_totale As Decimal
        Dim qt_ordinata_articolo As Decimal
        Dim elencoMatricole As String
        Dim costo_articolo As Decimal
        Dim prezzo_calcolato As Decimal
        Dim fornitore As String
        Dim quantita_disponibile_in_gruppo As Decimal
        Dim situazione_in_gruppo As Decimal

        Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.Clear()

        ' Verifico per ogni articolo se è stato consumato o ordinato
        For Each articolo As GestioneProduzione2009DataSet.t20_articoliRow In Me.GestioneProduzione2009DataSet1.t20_articoli.Rows

            ' Considero solo gli articoli non cancellati
            If articolo.Ist20_dt_cancellazioneNull Then

                quantita_disponibile = 0
                lotto_riordino = 0
                costo_articolo = 0
                consumo_totale = 0
                qt_ordinata_articolo = 0
                elencoMatricole = ""
                prezzo_calcolato = 0
                fornitore = ""

                'Distinguo fra Gruppi ed Articolo in quanto solo per gli articoli ho i calcoli
                'If Not articolo.t20_is_gruppo Then

                'Gestisco i campi null dell'articolo per il riepilogo

                If Not articolo.Ist20_qt_disponibileNull Then
                    quantita_disponibile = articolo.t20_qt_disponibile()
                Else
                    quantita_disponibile = 0
                End If

                If Not articolo.Ist20_lotto_riordinoNull Then
                    lotto_riordino = articolo.t20_lotto_riordino
                Else
                    lotto_riordino = 0
                End If

                If Not articolo.Ist20_prezzoNull Then
                    costo_articolo = articolo.t20_prezzo
                Else
                    costo_articolo = 0
                End If


                'ATTENZIONE GRUPPI E ARTICOLI SONO SU DUE CONTEGGI DIVERSI
                If articolo.t20_is_gruppo Then
                    ' Guardo se il gruppo compare fra gli usati
                    If Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.DefaultView.Find(articolo.t20_id_articolo) > -1 Then
                        Dim rigaConsumato As GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliGruppiRow
                        rigaConsumato = CType(Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliGruppi.DefaultView.FindRows(articolo.t20_id_articolo)(0).Row, GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliGruppiRow)

                        consumo_totale = rigaConsumato.consumo_totale
                    End If
                Else

                    ' Guardo se l'articolo compare fra gli usati
                    If Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.DefaultView.Find(articolo.t20_id_articolo) > -1 Then
                        Dim rigaConsumato As GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliArticoliRow
                        rigaConsumato = CType(Me.GestioneProduzione2009DataSet1.viewTreeIstanzeMacchineTotaliArticoli.DefaultView.FindRows(articolo.t20_id_articolo)(0).Row, GestioneProduzione2009DataSet.viewTreeIstanzeMacchineTotaliArticoliRow)

                        consumo_totale = rigaConsumato.consumo_totale
                    End If
                End If

                ' Guardo se l'articolo compare fra gli ordinati
                If Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.DefaultView.Find(articolo.t20_id_articolo) > -1 Then
                    Dim rigaOrdinato As GestioneProduzione2009DataSet.ufn_GetQuantitaOrdinataArticoloRow
                    rigaOrdinato = CType(Me.GestioneProduzione2009DataSet1.ufn_GetQuantitaOrdinataArticolo.DefaultView.FindRows(articolo.t20_id_articolo)(0).Row, GestioneProduzione2009DataSet.ufn_GetQuantitaOrdinataArticoloRow)

                    qt_ordinata_articolo = rigaOrdinato.t09_qt_ordinata - rigaOrdinato.t09_qt_evasa
                End If

                'Concateno le matricole per agevolare le ricerche

                For Each rigaMatricola As GestioneProduzione2009DataSet.t25_matricoleRow In Me.GestioneProduzione2009DataSet1.t25_matricole.Rows
                    'Not rigaMatricola.Ist25_cod_matricolaNull AndAlso ORA E' CHIAVE
                    If Not rigaMatricola.Ist25_id_articolo_t20Null AndAlso rigaMatricola.t25_id_articolo_t20 = articolo.t20_id_articolo Then
                        If elencoMatricole = "" Then
                            elencoMatricole = rigaMatricola.t25_cod_matricola
                        Else
                            elencoMatricole = elencoMatricole & "," & rigaMatricola.t25_cod_matricola
                        End If
                    End If
                Next

                'Calcolo il prezzo

                For Each rigaFormulaPrezzi As GestioneProduzione2009DataSet.t26_formule_prezziRow In Me.GestioneProduzione2009DataSet1.t26_formule_prezzi
                    'TODO: Unificare con altra procedura di calcolo
                    ' Verifico in quale range rientro
                    If costo_articolo >= rigaFormulaPrezzi.t26_formula_da And costo_articolo < rigaFormulaPrezzi.t26_formula_a Then
                        'Verifico se devo usare un prezzo fisso o calcolarlo
                        If rigaFormulaPrezzi.Ist26_prezzo_fissoNull Then
                            prezzo_calcolato = articolo.t20_prezzo * rigaFormulaPrezzi.t26_fattore

                            'If (rigaFormulaPrezzi.Ist26_arrotondamentoNull) Then rigaFormulaPrezzi.t26_arrotondamento = 2
                            'prezzo_calcolato = Decimal.Round(prezzo_calcolato, CInt(rigaFormulaPrezzi.t26_arrotondamento))

                            If (rigaFormulaPrezzi.Ist26_arrotondamentoNull) Then
                                prezzo_calcolato = VS2005Commons.PrezziUtils.arrotondaPrezzo(prezzo_calcolato, VS2005Commons.PrezziUtils.arrotondamento.nessuno)
                            ElseIf rigaFormulaPrezzi.t26_arrotondamento = 0.5 Then
                                prezzo_calcolato = VS2005Commons.PrezziUtils.arrotondaPrezzo(prezzo_calcolato, VS2005Commons.PrezziUtils.arrotondamento.mezzo_euro_successivo)
                            ElseIf rigaFormulaPrezzi.t26_arrotondamento = 1 Then
                                prezzo_calcolato = VS2005Commons.PrezziUtils.arrotondaPrezzo(prezzo_calcolato, VS2005Commons.PrezziUtils.arrotondamento.euro_successivo)
                            Else
                                prezzo_calcolato = VS2005Commons.PrezziUtils.arrotondaPrezzo(prezzo_calcolato, VS2005Commons.PrezziUtils.arrotondamento.nessuno)
                            End If

                        Else
                            prezzo_calcolato = rigaFormulaPrezzi.t26_prezzo_fisso
                            End If
                        End If
                Next


                For Each rigaFornitore As GestioneProduzione2009DataSet.t11_fornitoriRow In Me.GestioneProduzione2009DataSet1.t11_fornitori.Rows
                    If Not articolo.Ist20_id_fornitore_t11Null AndAlso rigaFornitore.t11_id_fornitore = articolo.t20_id_fornitore_t11 Then
                        fornitore = rigaFornitore.t11_descrizione
                    End If
                Next

                'End If


                ' Creo la nuova riga di riepilogo
                Dim riepilogo As GestioneProduzione2009DataSet.RiepilogoArticoliRow
                riepilogo = Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.NewRiepilogoArticoliRow()

                riepilogo.t20_id_articolo = articolo.t20_id_articolo
                riepilogo.t20_cod_articolo = articolo.t20_cod_articolo
                riepilogo.t20_descrizione = articolo.t20_descrizione.Replace(vbNewLine, " ")
                riepilogo.t20_qt_disponibile = quantita_disponibile
                riepilogo.t20_lotto_riordino = lotto_riordino

                riepilogo.qt_ordinata_articolo = qt_ordinata_articolo
                riepilogo.consumo_totale = consumo_totale

                riepilogo.situazione = (quantita_disponibile + qt_ordinata_articolo) - consumo_totale
                riepilogo.situazione_senza_ordinato = quantita_disponibile - consumo_totale

                riepilogo.matricole = elencoMatricole
                riepilogo.costo = articolo.t20_prezzo
                riepilogo.prezzo_calcolato = prezzo_calcolato

                If articolo.Ist20_prezzo_forzatoNull Then
                    riepilogo.prezzo_forzato = 0
                Else
                    riepilogo.prezzo_forzato = articolo.t20_prezzo_forzato
                End If

                riepilogo.t20_is_gruppo = articolo.t20_is_gruppo
                riepilogo.fornitore = fornitore
                If articolo.Ist20_is_ricambioNull Then
                    riepilogo.t20_is_ricambio = False
                Else
                    riepilogo.t20_is_ricambio = articolo.t20_is_ricambio
                End If

                ' TODO: QUANTITA DISPONIBILE IN GRUPPI
                'Dim qt_in_gruppi As Decimal
                'qt_in_gruppi = getQuantitaArticoloInGruppi(articolo.t20_id_articolo)
                'riepilogo.qt_disponibile_in_gruppi = qt_in_gruppi
                'riepilogo.situazione_in_gruppi = qt_in_gruppi - 

                Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.AddRiepilogoArticoliRow(riepilogo)

            End If
        Next

        'Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.WriteXml("C:\RiepilogoArticoli.xml")
    End Sub

    ''' <summary>
    ''' Lo scopo di questa procedura è rappresentare i colori e gli stili correttamente nel treeview in funzione dello stato
    ''' </summary>
    ''' <param name="TreeView1"></param>
    ''' <remarks></remarks>
    Private Sub AggiornaStatoTreeView(ByVal TreeView1 As TreeView)
        Dim haFigliSottoScorta As Boolean = False
        Dim idMacchina As Integer = -1

        Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.Sort = "t20_id_articolo"

        For Each nodo As TreeNode In TreeView1.Nodes

            idMacchina = nodo.Tag

            'Coloro il nodo corrente
            RicorsioneNode(nodo, haFigliSottoScorta, idMacchina)

            If haFigliSottoScorta Then
                nodo.ForeColor = Color.Red
            End If

            haFigliSottoScorta = False
        Next
    End Sub

    Private Sub RicorsioneNode(ByVal nodoPadre As TreeNode, ByRef haFigliSottoScorta As Boolean, ByVal idMacchina As Integer)

        For Each nodo As TreeNode In nodoPadre.Nodes
            'Coloro il nodo corrente
            Dim id As Integer = CType(nodo.Tag, Integer)

            Dim row As GestioneProduzione2009DataSet.RiepilogoArticoliRow
            ' Potrei non trovare la riga se è un gruppo
            If Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.Find(id) > -1 Then
                row = CType(Me.GestioneProduzione2009DataSet1.RiepilogoArticoli.DefaultView.FindRows(id)(0).Row, GestioneProduzione2009DataSet.RiepilogoArticoliRow)
                If row.situazione_senza_ordinato < 0 Then
                    nodo.ForeColor = Color.Red
                    haFigliSottoScorta = True
                End If
            End If

            If haFigliSottoScorta Then
                nodoPadre.ForeColor = Color.Red
            End If

            RicorsioneNode(nodo, haFigliSottoScorta, idMacchina)

        Next

    End Sub

    ''' <summary>
    ''' Scompone un gruppo mettendo a magazzino la quantita indicata
    ''' </summary>
    ''' <param name="idGruppo"></param>
    ''' <remarks></remarks>
    Public Function ScomponiGruppo(ByVal idGruppo As Integer) As String
        Dim res As String = ""

        For Each articolo As GestioneProduzione2009DataSet.t20_articoliRow In Me.GestioneProduzione2009DataSet1.t20_articoli.Rows
            If articolo.Ist20_dt_cancellazioneNull AndAlso articolo.t20_id_articolo = idGruppo Then
                ' verifico che sia effettivamente un gruppo
                ' e ce ne siano a magazzino
                If articolo.t20_is_gruppo AndAlso Not articolo.Ist20_qt_disponibileNull AndAlso articolo.t20_qt_disponibile > 0 Then
                    'per ogni articolo che compone il gruppo
                    'scomponendolo lo tolgo dal magazzino
                    'e rimetto gli articoli che lo compongono al loro posto
                    For Each articoli_figli As GestioneProduzione2009DataSet.t22_articoli_articoliRow In articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1  '"GetChildRows t20_articolit22_articoli_articoli1")
                        Dim articolo_figlio As GestioneProduzione2009DataSet.t20_articoliRow = articoli_figli.GetParentRow("FK_t22_articoli_articoli_t20_articoli") '"GetParentRow t20_articolit22_articoli_articoli")

                        'Carico l' articolo figlio a magazzino
                        'in funzione de consumo
                        If Not articolo_figlio.Ist20_qt_disponibileNull Then
                            articolo_figlio.t20_qt_disponibile = articolo_figlio.t20_qt_disponibile + articoli_figli.t22_consumo
                        Else
                            articolo_figlio.t20_qt_disponibile = articoli_figli.t22_consumo
                        End If

                        'articolo_figlio.AcceptChanges()
                    Next

                    ' Scarico il gruppo dal magazzino
                    articolo.t20_qt_disponibile = articolo.t20_qt_disponibile - 1

                    ' Aggiorno il database
                    'Me.dat20_articoli.Update(Me.GestioneProduzione2009DataSet1)
                    Me.T20_articoliTableAdapter1.Update(Me.GestioneProduzione2009DataSet1.t20_articoli)
                Else
                    res = "L'articolo selezionato non è un gruppo oppure non ce ne sono a magazzino."

                End If


            End If
        Next

        Return res
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ChiudiMacchina(ByVal idMacchina As Integer)
        Dim strMsg As String

        strMsg = "Confermi la chiusura della commessa ? " & vbCrLf & vbCrLf & "ATTENZIONE! "
        strMsg += "Con la chiusura verranno aggiornate tutte le quantità a "
        strMsg += "magazzino degli articoli che compongono la macchina!"

        If MessageBox.Show(strMsg, My.Application.ApplicationContext.MainForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            For Each macchina_in_produzione As GestioneProduzione2009DataSet.t06_istanze_macchineRow In Me.GestioneProduzione2009DataSet1.t06_istanze_macchine
                If macchina_in_produzione.Ist06_dt_cancellazioneNull AndAlso macchina_in_produzione.t06_id_istanza_macchina = idMacchina Then
                    'Verifico che sia in produzione
                    If macchina_in_produzione.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_IN_PRODUZIONE Then

                        ' Ciclo sulla tabelle che contiene i calcoli già fatti per 
                        ' articoli e gruppi
                        For Each rigaImpegnato As GestioneProduzione2009DataSet.ImpegnatiRow In Me.GestioneProduzione2009DataSet1.Impegnati

                            If rigaImpegnato.t06_id_istanza_macchina = idMacchina Then

                                Dim rigaArticolo As GestioneProduzione2009DataSet.t20_articoliRow
                                rigaArticolo = Me.GestioneProduzione2009DataSet1.t20_articoli.FindByt20_id_articolo(rigaImpegnato.t22_id_articolo_t20)
                                If Not rigaArticolo Is Nothing Then

                                    Dim qt_disponibile As Decimal = 0
                                    Dim consumo_effettivo As Decimal = 0

                                    qt_disponibile = rigaArticolo.t20_qt_disponibile
                                    If rigaArticolo.t20_is_gruppo Then
                                        consumo_effettivo = rigaImpegnato.impegnato
                                    Else
                                        consumo_effettivo = rigaImpegnato.consumo_effettivo
                                    End If

                                    qt_disponibile = qt_disponibile - consumo_effettivo

                                    If Not rigaArticolo.t20_is_gruppo Then
                                        'Essendo un articolo verifico di non andare sotto scorta

                                        If qt_disponibile < 0 Then
                                            'Impossibile andare sotto scorta con l'articolo
                                            MessageBox.Show("Impossibile chiudere la commessa, almeno un articolo andrebbe a giacenza negativa!", My.Application.ApplicationContext.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                            Exit Sub
                                        End If
                                    End If

                                    'If (rigaArticolo.t20_qt_disponibile <> qt_disponibile) Then
                                    rigaArticolo.t20_qt_disponibile = qt_disponibile
                                    'End If

                                End If
                            End If
                        Next

                        'Aggiorno il database
                        'Me.dat20_articoli.Update(Me.GestioneProduzione2009DataSet1.t20_articoli)
                        'Me.GestioneProduzione2009DataSet1.t20_articoli.WriteXml("C:\t20_articoli2.xml")
                        'Try

                        Me.T20_articoliTableAdapter1.Update(Me.GestioneProduzione2009DataSet1.t20_articoli)

                        ' Questo dava un errore a causa della mancanza di un timestamp
                        '"Violazione di concorrenza: UpdateCommand ha modificato 0 dei 1 record previsti."
                        'Catch
                        'For Each row As GestioneProduzione2009DataSet.t20_articoliRow In Me.GestioneProduzione2009DataSet1.t20_articoli.Rows
                        '    If row.HasErrors Then
                        '        Debug.Print(row.t20_id_articolo)
                        '        Debug.Print(row.RowState.ToString)
                        '        Debug.Print(row.RowError)
                        '    End If
                        'Next
                        'End Try

                        'Me.GestioneProduzione2009DataSet1.t20_articoli.WriteXml("C:\t20_articoli.xml")

                        'Aggiornamento dello stato della macchina
                        macchina_in_produzione.t06_id_stato_istanza_t07 = DataModel.COMMESSA_STATO_CHIUSA
                        macchina_in_produzione.t06_dt_modifica = Now()
                        'Me.dat06_istanze_macchine.Update(Me.GestioneProduzione2009DataSet1.t06_istanze_macchine)
                        Me.T06_istanze_macchineTableAdapter1.Update(Me.GestioneProduzione2009DataSet1.t06_istanze_macchine)

                    Else
                        MessageBox.Show("La macchina non è in produzione")
                    End If
                End If
            Next

        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ArticoliInGruppi()

        Me.GestioneProduzione2009DataSet1.ArticoliInGruppi.Clear()

        For Each articolo As GestioneProduzione2009DataSet.t20_articoliRow In Me.GestioneProduzione2009DataSet1.t20_articoli
            ' per ogni articolo mi interessano solo quelli
            ' - non cancellati
            ' - che siano gruppi
            ' - che ce ne siano a magazzino
            If articolo.Ist20_dt_cancellazioneNull And articolo.t20_is_gruppo And articolo.t20_qt_disponibile > 0 Then

                Debug.Print(articolo.t20_cod_articolo & "-" & articolo.t20_qt_disponibile)

                For Each link_figli As GestioneProduzione2009DataSet.t22_articoli_articoliRow In articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1  '"GetChildRows t20_articolit22_articoli_articoli1")
                    Dim articolo_figlio As GestioneProduzione2009DataSet.t20_articoliRow = link_figli.GetParentRow("FK_t22_articoli_articoli_t20_articoli") '"GetParentRow t20_articolit22_articoli_articoli")
                    If (articolo_figlio.Ist20_dt_cancellazioneNull) Then
                        ' NOTA:
                        ' Non devo considerare gli articoli con distinta in quanto
                        ' a magazzino un articolo con distinta non deve far conteggiare i figli
                        If Not articolo_figlio.t20_is_gruppo Then
                            Debug.Print(" " & articolo_figlio.t20_cod_articolo & "-" & articolo_figlio.t20_qt_disponibile)
                            AggiungiInArticoliInGruppi(articolo_figlio, articolo.t20_qt_disponibile * link_figli.t22_consumo)
                        Else
                            DistintaArticolo(articolo_figlio, articolo.t20_qt_disponibile * link_figli.t22_consumo)
                        End If
                    End If
                Next
            End If
        Next

        'Me.GestioneProduzione2009DataSet1.ArticoliInGruppi.WriteXml("C:\ArticoliInGruppi.xml")
    End Sub

    Private Sub DistintaArticolo(ByVal articolo As GestioneProduzione2009DataSet.t20_articoliRow, ByVal consumo As Decimal)

        ' NOTA
        ' Se l'articolo che sto controllando è un gruppo allora procedo con figli altrimenti mi fermo
        'GetChildRows("t20_articolit22_articoli_articoli1")
        If articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1.Length > 0 AndAlso articolo.t20_is_gruppo Then

            'Debug.WriteLine("ha figli")
            For Each link_figli As GestioneProduzione2009DataSet.t22_articoli_articoliRow In articolo.Gett22_articoli_articoliRowsByFK_t22_articoli_articoli_t20_articoli1  '"GetChildRows t20_articolit22_articoli_articoli1")
                Dim articolo_figlio As GestioneProduzione2009DataSet.t20_articoliRow = link_figli.GetParentRow("FK_t22_articoli_articoli_t20_articoli") '"GetParentRow t20_articolit22_articoli_articoli")

                If (articolo_figlio.Ist20_dt_cancellazioneNull) Then

                    If Not articolo_figlio.t20_is_gruppo Then
                        Debug.Print("  " & articolo.t20_cod_articolo & "-" & articolo.t20_qt_disponibile)
                        AggiungiInArticoliInGruppi(articolo_figlio, consumo * link_figli.t22_consumo)
                    Else
                        DistintaArticolo(articolo_figlio, consumo * link_figli.t22_consumo)
                    End If

                End If
            Next
        Else
            'Debug.WriteLine("è foglia")
        End If

    End Sub


    Private Sub AggiungiInArticoliInGruppi(ByVal articolo As GestioneProduzione2009DataSet.t20_articoliRow, ByVal quantita As Decimal)
        Dim rigaArticoloInGruppo As GestioneProduzione2009DataSet.ArticoliInGruppiRow
        rigaArticoloInGruppo = GestioneProduzione2009DataSet1.ArticoliInGruppi.FindByt22_id_articolo_t20(articolo.t20_id_articolo)
        If rigaArticoloInGruppo Is Nothing Then
            rigaArticoloInGruppo = Me.GestioneProduzione2009DataSet1.ArticoliInGruppi.NewArticoliInGruppiRow()

            rigaArticoloInGruppo.t22_id_articolo_t20 = articolo.t20_id_articolo
            rigaArticoloInGruppo.t20_cod_articolo = articolo.t20_cod_articolo
            rigaArticoloInGruppo.qt_disponibile_in_gruppi = quantita

            Me.GestioneProduzione2009DataSet1.ArticoliInGruppi.AddArticoliInGruppiRow(rigaArticoloInGruppo)
        Else
            rigaArticoloInGruppo.t22_id_articolo_t20 = articolo.t20_id_articolo
            rigaArticoloInGruppo.t20_cod_articolo = articolo.t20_cod_articolo
            rigaArticoloInGruppo.qt_disponibile_in_gruppi = rigaArticoloInGruppo.qt_disponibile_in_gruppi + quantita

            rigaArticoloInGruppo.AcceptChanges()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="id_articolo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getQuantitaArticoloInGruppi(ByVal id_articolo As Integer) As Decimal
        Dim res As Decimal = 0
        Dim rigaArticoloInGruppo As GestioneProduzione2009DataSet.ArticoliInGruppiRow
        rigaArticoloInGruppo = Me.GestioneProduzione2009DataSet1.ArticoliInGruppi.FindByt22_id_articolo_t20(id_articolo)
        If Not rigaArticoloInGruppo Is Nothing Then
            res = rigaArticoloInGruppo.qt_disponibile_in_gruppi
        End If

        getQuantitaArticoloInGruppi = res
    End Function

    Public Function CalcolaImpegnoArticoliInGruppi()

    End Function

    Public Function CalcolaPrezzoGruppo() As Decimal

    End Function

    ''' <summary>
    ''' DA FARE
    ''' </summary>
    ''' <param name="idArticolo"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function PrezzoArticolo(ByVal idArticolo As Integer) As Decimal
        Dim res As Decimal

        'For Each articolo As GestioneProduzione2009DataSet.t20_articoliRow In Me.T20_articoliTableAdapter1.GetDataByID(idArticolo).Rows
        '    If articolo.Ist20_prezzo_forzatoNull Then
        '    Else
        '        'res = T20_articoliTableAdapter1 TODO: FINIRE
        '    End If
        'Next

        Return res
    End Function
End Class
