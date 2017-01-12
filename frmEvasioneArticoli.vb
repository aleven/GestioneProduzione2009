Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmEvasioneArticoli
    Inherits System.Windows.Forms.Form

    Private m_IDArticolo As Integer
    Private m_SQL As String
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Private objdsOrdiniArticolo As DataSet

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
    Friend WithEvents btnSceltaArticolo As System.Windows.Forms.Button
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents txtDescrArticolo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodArticolo As System.Windows.Forms.Label
    Friend WithEvents txtCodArticolo As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents IDOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataInserimento As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrOrdine As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtOrdinata As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtEvasa As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridOrdiniArticolo As System.Windows.Forms.DataGrid
    Friend WithEvents txtQtDisponibile As System.Windows.Forms.TextBox
    Friend WithEvents lblQtDisponibile As System.Windows.Forms.Label
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuEvadi As System.Windows.Forms.MenuItem
    Friend WithEvents Prezzo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Codice As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Fornitore As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvasioneArticoli))
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.txtDescrArticolo = New System.Windows.Forms.TextBox
        Me.lblCodArticolo = New System.Windows.Forms.Label
        Me.txtCodArticolo = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSceltaArticolo = New System.Windows.Forms.Button
        Me.DataGridOrdiniArticolo = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.IDOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataInserimento = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Codice = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Fornitore = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrOrdine = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtOrdinata = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Prezzo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtEvasa = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtQtDisponibile = New System.Windows.Forms.TextBox
        Me.lblQtDisponibile = New System.Windows.Forms.Label
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuEvadi = New System.Windows.Forms.MenuItem
        Me.btnChiudi = New System.Windows.Forms.Button
        CType(Me.DataGridOrdiniArticolo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 48)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(100, 23)
        Me.lblDescrizione.TabIndex = 3
        Me.lblDescrizione.Text = "Descrizione :"
        '
        'txtDescrArticolo
        '
        Me.txtDescrArticolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrArticolo.Location = New System.Drawing.Point(112, 48)
        Me.txtDescrArticolo.MaxLength = 255
        Me.txtDescrArticolo.Multiline = True
        Me.txtDescrArticolo.Name = "txtDescrArticolo"
        Me.txtDescrArticolo.ReadOnly = True
        Me.txtDescrArticolo.Size = New System.Drawing.Size(680, 48)
        Me.txtDescrArticolo.TabIndex = 1
        Me.txtDescrArticolo.TabStop = False
        '
        'lblCodArticolo
        '
        Me.lblCodArticolo.Location = New System.Drawing.Point(8, 16)
        Me.lblCodArticolo.Name = "lblCodArticolo"
        Me.lblCodArticolo.Size = New System.Drawing.Size(100, 23)
        Me.lblCodArticolo.TabIndex = 0
        Me.lblCodArticolo.Text = "Codice Articolo :"
        '
        'txtCodArticolo
        '
        Me.txtCodArticolo.Location = New System.Drawing.Point(112, 16)
        Me.txtCodArticolo.MaxLength = 20
        Me.txtCodArticolo.Name = "txtCodArticolo"
        Me.txtCodArticolo.ReadOnly = True
        Me.txtCodArticolo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodArticolo.TabIndex = 0
        Me.txtCodArticolo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.txtCodArticolo, "Codice Articolo (F9=Ricerca)")
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'btnSceltaArticolo
        '
        Me.btnSceltaArticolo.Image = Global.GestioneProduzione.My.Resources.Resources.cerca
        Me.btnSceltaArticolo.Location = New System.Drawing.Point(272, 8)
        Me.btnSceltaArticolo.Name = "btnSceltaArticolo"
        Me.btnSceltaArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnSceltaArticolo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSceltaArticolo, "Ricerca e selezione articolo")
        '
        'DataGridOrdiniArticolo
        '
        Me.DataGridOrdiniArticolo.AllowSorting = False
        Me.DataGridOrdiniArticolo.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridOrdiniArticolo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridOrdiniArticolo.CaptionText = "Elenco Ordini Aperti"
        Me.DataGridOrdiniArticolo.DataMember = ""
        Me.DataGridOrdiniArticolo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridOrdiniArticolo.Location = New System.Drawing.Point(8, 136)
        Me.DataGridOrdiniArticolo.Name = "DataGridOrdiniArticolo"
        Me.DataGridOrdiniArticolo.ReadOnly = True
        Me.DataGridOrdiniArticolo.Size = New System.Drawing.Size(784, 171)
        Me.DataGridOrdiniArticolo.TabIndex = 7
        Me.DataGridOrdiniArticolo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridOrdiniArticolo
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.IDOrdine, Me.DataInserimento, Me.Codice, Me.Fornitore, Me.DescrOrdine, Me.QtOrdinata, Me.Prezzo, Me.QtEvasa})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "OrdiniArticolo"
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
        'DataInserimento
        '
        Me.DataInserimento.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataInserimento.Format = "dd/MM/yyyy"
        Me.DataInserimento.FormatInfo = Nothing
        Me.DataInserimento.HeaderText = "Data"
        Me.DataInserimento.MappingName = "t08_dt_creazione"
        Me.DataInserimento.NullText = "  /  /    "
        Me.DataInserimento.Width = 0
        '
        'Codice
        '
        Me.Codice.Format = ""
        Me.Codice.FormatInfo = Nothing
        Me.Codice.HeaderText = "Codice"
        Me.Codice.MappingName = "t08_cod_testata_ordine_for"
        Me.Codice.Width = 75
        '
        'Fornitore
        '
        Me.Fornitore.Format = ""
        Me.Fornitore.FormatInfo = Nothing
        Me.Fornitore.HeaderText = "Fornitore"
        Me.Fornitore.MappingName = "t11_descrizione"
        Me.Fornitore.Width = 140
        '
        'DescrOrdine
        '
        Me.DescrOrdine.Format = ""
        Me.DescrOrdine.FormatInfo = Nothing
        Me.DescrOrdine.HeaderText = "Descrizione"
        Me.DescrOrdine.MappingName = "t08_descrizione"
        Me.DescrOrdine.NullText = ""
        Me.DescrOrdine.Width = 400
        '
        'QtOrdinata
        '
        Me.QtOrdinata.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtOrdinata.Format = "#####0.00"
        Me.QtOrdinata.FormatInfo = Nothing
        Me.QtOrdinata.HeaderText = "Q.tà Ordinata"
        Me.QtOrdinata.MappingName = "t09_qt_ordinata"
        Me.QtOrdinata.NullText = "0"
        Me.QtOrdinata.Width = 70
        '
        'Prezzo
        '
        Me.Prezzo.Format = ""
        Me.Prezzo.FormatInfo = Nothing
        Me.Prezzo.HeaderText = "Prezzo"
        Me.Prezzo.MappingName = "t09_prezzo_uni"
        Me.Prezzo.Width = 70
        '
        'QtEvasa
        '
        Me.QtEvasa.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtEvasa.Format = "#####0.00"
        Me.QtEvasa.FormatInfo = Nothing
        Me.QtEvasa.HeaderText = "Q.tà Evasa"
        Me.QtEvasa.MappingName = "t09_qt_evasa"
        Me.QtEvasa.NullText = "0"
        Me.QtEvasa.Width = 75
        '
        'txtQtDisponibile
        '
        Me.txtQtDisponibile.Location = New System.Drawing.Point(112, 104)
        Me.txtQtDisponibile.Name = "txtQtDisponibile"
        Me.txtQtDisponibile.ReadOnly = True
        Me.txtQtDisponibile.Size = New System.Drawing.Size(72, 20)
        Me.txtQtDisponibile.TabIndex = 2
        Me.txtQtDisponibile.TabStop = False
        Me.txtQtDisponibile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblQtDisponibile
        '
        Me.lblQtDisponibile.Location = New System.Drawing.Point(8, 104)
        Me.lblQtDisponibile.Name = "lblQtDisponibile"
        Me.lblQtDisponibile.Size = New System.Drawing.Size(100, 23)
        Me.lblQtDisponibile.TabIndex = 5
        Me.lblQtDisponibile.Text = "Q.tà Disponibile :"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEvadi})
        '
        'mnuEvadi
        '
        Me.mnuEvadi.Index = 0
        Me.mnuEvadi.Text = "Evadi Definitivamente Riga"
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(696, 319)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 8
        Me.btnChiudi.Text = "&Chiudi"
        '
        'frmEvasioneArticoli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(800, 361)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.txtQtDisponibile)
        Me.Controls.Add(Me.lblQtDisponibile)
        Me.Controls.Add(Me.DataGridOrdiniArticolo)
        Me.Controls.Add(Me.txtCodArticolo)
        Me.Controls.Add(Me.txtDescrArticolo)
        Me.Controls.Add(Me.btnSceltaArticolo)
        Me.Controls.Add(Me.lblCodArticolo)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvasioneArticoli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evasione Ordini Per Articolo"
        CType(Me.DataGridOrdiniArticolo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property IDArticolo() As Integer
        Get
            Return m_IDArticolo
        End Get
        Set(ByVal Value As Integer)
            m_IDArticolo = Value
        End Set
    End Property



    Private Sub frmEvasioneArticoli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        If m_IDArticolo > 0 Then 'Chiamata con parametro
            Call CaricaDatiArticolo()
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSceltaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaArticolo.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormSceltaArticolo As New frmSceltaArticolo
        FormSceltaArticolo.ModoSelezione = frmSceltaArticolo.TModoSelezione.SELEZIONA
        FormSceltaArticolo.ShowDialog()

        If FormSceltaArticolo.IDArticolo <> -1 Then

            m_IDArticolo = FormSceltaArticolo.IDArticolo()
            Call CaricaDatiArticolo()

        End If

    End Sub

    Private Sub CaricaDatiArticolo()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRArticolo As SqlClient.SqlDataReader

        m_SQL = ""
        'm_SQL += "SELECT * FROM t01_articoli WHERE t01_id_articolo = " & m_IDArticolo.ToString
        m_SQL += "SELECT * FROM t20_articoli WHERE t20_id_articolo = " & m_IDArticolo.ToString

        DRArticolo = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)
        If DRArticolo.HasRows Then

            DRArticolo.Read()

            If DRArticolo("t20_cod_articolo").GetType Is Type.GetType("System.DBNull") Then
                Me.txtCodArticolo.Text = ""
            Else
                Me.txtCodArticolo.Text = DRArticolo("t20_cod_articolo")
            End If

            If DRArticolo("t20_descrizione").GetType Is Type.GetType("System.DBNull") Then
                Me.txtDescrArticolo.Text = ""
            Else
                Me.txtDescrArticolo.Text = DRArticolo("t20_descrizione")
            End If

            If DRArticolo("t20_qt_disponibile").GetType Is Type.GetType("System.DBNull") Then
                Me.txtQtDisponibile.Text = 0
            Else
                Me.txtQtDisponibile.Text = DRArticolo("t20_qt_disponibile")
            End If

        End If

        FormattaComeNumero(Me.txtQtDisponibile.Text, 2)

        m_SQL = ""
        'm_SQL += "SELECT * FROM t08_testate_ordini_for INNER JOIN t09_righe_ordine_for "
        'm_SQL += "ON t08_id_testata_ordine_for = t09_id_testata_ordine_for_t08 "
        'm_SQL += "INNER JOIN t01_articoli ON t09_id_articolo_t01 = t01_id_articolo "
        'm_SQL += "INNER JOIN t11_fornitori ON t08_testate_ordini_for.t08_id_fornitore_t11 = t11_fornitori.t11_id_fornitore "
        'm_SQL += "WHERE t08_dt_cancellazione IS NULL AND t09_dt_cancellazione IS NULL AND "
        'm_SQL += "t09_id_stato_riga_ordine_t10 = 'A' AND t09_id_articolo_t01 = " & m_IDArticolo.ToString & " "
        'm_SQL += "ORDER BY t08_id_testata_ordine_for, t09_posizione"
        m_SQL += "SELECT * FROM t08_testate_ordini_for INNER JOIN t09_righe_ordine_for "
        m_SQL += "ON t08_id_testata_ordine_for = t09_id_testata_ordine_for_t08 "
        m_SQL += "INNER JOIN t20_articoli ON t09_id_articolo_t20 = t20_id_articolo "
        m_SQL += "LEFT JOIN t11_fornitori ON t08_testate_ordini_for.t08_id_fornitore_t11 = t11_fornitori.t11_id_fornitore "
        m_SQL += "WHERE t08_dt_cancellazione IS NULL AND t09_dt_cancellazione IS NULL AND "
        m_SQL += "t09_id_stato_riga_ordine_t10 = 'A' AND t09_id_articolo_t20 = " & m_IDArticolo.ToString & " "
        m_SQL += "ORDER BY t08_id_testata_ordine_for, t09_posizione"

        objdsOrdiniArticolo = ExecuteDataset(conn1.ConnectionString, CommandType.Text, m_SQL)
        objdsOrdiniArticolo.Tables(0).TableName = "OrdiniArticolo"

        DataGridOrdiniArticolo.DataSource = objdsOrdiniArticolo
        DataGridOrdiniArticolo.DataMember = "OrdiniArticolo"

        'default
        Cursor.Current = Cursors.Default

        If objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows.Count <= 0 Then
            MessageBox.Show("L'articolo attualmente non risulta in ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ''' <summary>
    ''' Evasione Parziale
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridOrdiniArticolo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridOrdiniArticolo.DoubleClick

        If m_IDArticolo = 0 Then
            MessageBox.Show("Scegliere un articolo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows.Count <= 0 Then
            MessageBox.Show("Impossibile inserire una quantità da evadere! L'articolo attualmente non risulta in ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intIDTestataOrdine As Integer
        Dim intIDRiga As Integer
        Dim blnAggiornaStato As Boolean = False

        intIDTestataOrdine = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t08_id_testata_ordine_for")
        intIDRiga = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t09_id_riga_ordine_for")

        'memorizzo i valori precedenti per eventuali controlli
        Dim sngQtOrdinata As Single
        Dim sngQtEvasaPrecedente As Single

        Try
            sngQtOrdinata = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t09_qt_ordinata")
        Catch ex As Exception
            sngQtOrdinata = 0
        End Try

        Try
            sngQtEvasaPrecedente = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t09_qt_evasa")
        Catch ex As Exception
            sngQtEvasaPrecedente = 0
        End Try

        'Richiesta quantità da evadere
        Dim strQtDaEvadere As String
        Dim sngQtDaEvadere As Single
        strQtDaEvadere = InputBox("Inserire la quantità da evadere :", Me.Text, "0")
        If strQtDaEvadere Is Nothing Then strQtDaEvadere = "0"
        strQtDaEvadere = Replace(strQtDaEvadere, ",", ".")
        If Not IsNumeric(strQtDaEvadere) Then
            MessageBox.Show("Non è stato inserito un valore numerico! Operazione annullata!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        sngQtDaEvadere = CType(Replace(strQtDaEvadere, ".", ","), Single)

        If sngQtDaEvadere = 0 Then Exit Sub

        If sngQtOrdinata < 0 Then

            'la quantità evasa dopo questa evasione non deve essere inferiore alla quantità ordinata
            If (sngQtDaEvadere + sngQtEvasaPrecedente) < sngQtOrdinata Then
                MessageBox.Show("Impossibile evadere quantità negative inferiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'la quantità evasa dopo questa evasione non deve essere maggiore di 0
            If (sngQtDaEvadere + sngQtEvasaPrecedente) > 0 Then
                MessageBox.Show("Impossibile evadere quantità negative inferiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        Else

            'la quantità evasa dopo questa evasione non deve essere maggiore alla quantità ordinata
            If (sngQtDaEvadere + sngQtEvasaPrecedente) > sngQtOrdinata Then
                MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'la quantità evasa dopo questa evasione non deve essere inferiore a 0
            If (sngQtDaEvadere + sngQtEvasaPrecedente) < 0 Then
                MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        End If

        'se la quantità evasa dopo questa evasione è pari alla
        'quantità ordinata chiede conferma di evasione completa
        '(cambio stato riga)
        If CSng(sngQtDaEvadere + sngQtEvasaPrecedente) = CSng(sngQtOrdinata) Then
            If MessageBox.Show("Dopo questa evasione la quantità evasa sarà pari quella ordinata. Evadere definitivamente la riga d'ordine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                blnAggiornaStato = True
            End If
        End If

        Cursor.Current = Cursors.WaitCursor

        'Vengono aggiornate le quantità evase del rigo
        'ed aumentata la quantità disponibili a livello di
        'magazzino (anagrafica articolo)
        m_SQL = ""
        m_SQL += "UPDATE t09_righe_ordine_for SET "
        m_SQL += "t09_qt_evasa = t09_qt_evasa + " & strQtDaEvadere & ", "
        If blnAggiornaStato Then
            m_SQL += "t09_id_stato_riga_ordine_t10 = 'E', "
        End If
        m_SQL += "t09_dt_modifica = GetDate() WHERE "
        m_SQL += "t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        m_SQL += "t09_id_riga_ordine_for = " & intIDRiga.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        m_SQL = ""
        'm_SQL += "UPDATE t01_articoli SET "
        'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + " & strQtDaEvadere & ", "
        'm_SQL += "t01_dt_modifica = GetDate() WHERE "
        'm_SQL += "t01_id_articolo = " & m_IDArticolo.ToString
        m_SQL += "UPDATE t20_articoli SET "
        m_SQL += "t20_qt_disponibile = t20_qt_disponibile + " & strQtDaEvadere & ", "
        m_SQL += "t20_dt_modifica = GetDate() WHERE "
        m_SQL += "t20_id_articolo = " & m_IDArticolo.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        Call CaricaDatiArticolo()

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub FormattaComeNumero(ByRef strNumero As String, ByVal NrDecimali As Byte)

        Dim strFormat As String
        strFormat = "##########0"
        If NrDecimali > 0 Then
            strFormat += "." & Strings.StrDup(NrDecimali, "0")
        End If
        Try
            strNumero = CType(strNumero, Single).ToString(strFormat)
        Catch ex As Exception
            strNumero = Format(0, strFormat)
        End Try

    End Sub

    ''' <summary>
    ''' Evasione definitiva Riga
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEvadi.Click

        If m_IDArticolo = 0 Then
            MessageBox.Show("Scegliere un articolo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows.Count <= 0 Then
            MessageBox.Show("Impossibile evadere la riga! L'articolo attualmente non risulta in ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi evasione definitiva riga ordine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

        Dim intIDTestataOrdine As Integer
        Dim intIDRiga As Integer
        Dim intIDArticolo As Integer

        intIDTestataOrdine = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t08_id_testata_ordine_for")
        intIDRiga = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t09_id_riga_ordine_for")
        intIDArticolo = objdsOrdiniArticolo.Tables("OrdiniArticolo").Rows(DataGridOrdiniArticolo.CurrentRowIndex)("t09_id_articolo_t20")

        Cursor.Current = Cursors.WaitCursor

        m_SQL = ""
        m_SQL += "UPDATE t09_righe_ordine_for SET "
        m_SQL += "t09_id_stato_riga_ordine_t10 = 'E', "
        m_SQL += "t09_dt_modifica = GetDate() WHERE "
        m_SQL += "t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        m_SQL += "t09_id_riga_ordine_for = " & intIDRiga.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        '----
        ' Aggiunto da Mirco per Aggiornare la t01_qt_disponibile quando viene evaso definitivamente un RIGO
        m_SQL = ""
        'm_SQL += "UPDATE t01_articoli SET "
        'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + "
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_qt_ordinata - t09_qt_evasa FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ), "
        'm_SQL += "t01_dt_modifica = GetDate() WHERE "
        'm_SQL += "t01_id_articolo = "
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_id_articolo_t01 FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ) "
        m_SQL += "UPDATE t20_articoli SET "
        m_SQL += "t20_qt_disponibile = t20_qt_disponibile + "
        m_SQL += "      ( "
        m_SQL += "      SELECT t09_qt_ordinata - t09_qt_evasa FROM t09_righe_ordine_for WHERE "
        m_SQL += "      t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        m_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        m_SQL += "      ), "
        m_SQL += "t20_dt_modifica = GetDate() WHERE "
        m_SQL += "t20_id_articolo = " & intIDArticolo.ToString
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_id_articolo_t20 FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & intIDTestataOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ) "
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)
        '----

        Call CaricaDatiArticolo()

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub DataGridOrdiniArticolo_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridOrdiniArticolo.MouseDown

        'Visualizza il menù di contesto solo nel RowHeader
        Dim pt As System.Drawing.Point = New Point(e.X, e.Y)
        Dim hti As DataGrid.HitTestInfo = DataGridOrdiniArticolo.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.RowHeader Then
            If e.Button = MouseButtons.Right Then
                DataGridOrdiniArticolo.CurrentCell = New DataGridCell(hti.Row, hti.Column)
                ContextMenu1.Show(DataGridOrdiniArticolo, pt)
            End If
        End If

    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub
End Class
