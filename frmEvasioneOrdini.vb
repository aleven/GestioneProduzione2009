Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmEvasioneOrdini
    Inherits System.Windows.Forms.Form

    Friend m_IDOrdine As Integer
    Private m_SQL As String
    Friend WithEvents txtCausaleOrdine As System.Windows.Forms.TextBox
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Private objdsRigheOrdine As DataSet

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
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents QtOrdinata As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtEvasa As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents mnuEvadi As System.Windows.Forms.MenuItem
    Friend WithEvents lblNrOrdine As System.Windows.Forms.Label
    Friend WithEvents txtNrOrdine As System.Windows.Forms.TextBox
    Friend WithEvents btnSceltaOrdine As System.Windows.Forms.Button
    Friend WithEvents txtDescrOrdine As System.Windows.Forms.TextBox
    Friend WithEvents lblDataOrdine As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerOrdine As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridRigheOrdine As System.Windows.Forms.DataGrid
    Friend WithEvents CodArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DescrArticolo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents QtDisponibile As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvasioneOrdini))
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.txtDescrOrdine = New System.Windows.Forms.TextBox
        Me.lblNrOrdine = New System.Windows.Forms.Label
        Me.txtNrOrdine = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSceltaOrdine = New System.Windows.Forms.Button
        Me.txtCausaleOrdine = New System.Windows.Forms.TextBox
        Me.DataGridRigheOrdine = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CodArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DescrArticolo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtDisponibile = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtOrdinata = New System.Windows.Forms.DataGridTextBoxColumn
        Me.QtEvasa = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.mnuEvadi = New System.Windows.Forms.MenuItem
        Me.DateTimePickerOrdine = New System.Windows.Forms.DateTimePicker
        Me.lblDataOrdine = New System.Windows.Forms.Label
        Me.btnChiudi = New System.Windows.Forms.Button
        CType(Me.DataGridRigheOrdine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 48)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(112, 23)
        Me.lblDescrizione.TabIndex = 3
        Me.lblDescrizione.Text = "Descrizione Ordine :"
        '
        'txtDescrOrdine
        '
        Me.txtDescrOrdine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrOrdine.Location = New System.Drawing.Point(112, 48)
        Me.txtDescrOrdine.MaxLength = 255
        Me.txtDescrOrdine.Multiline = True
        Me.txtDescrOrdine.Name = "txtDescrOrdine"
        Me.txtDescrOrdine.ReadOnly = True
        Me.txtDescrOrdine.Size = New System.Drawing.Size(680, 48)
        Me.txtDescrOrdine.TabIndex = 4
        Me.txtDescrOrdine.TabStop = False
        '
        'lblNrOrdine
        '
        Me.lblNrOrdine.Location = New System.Drawing.Point(8, 16)
        Me.lblNrOrdine.Name = "lblNrOrdine"
        Me.lblNrOrdine.Size = New System.Drawing.Size(100, 23)
        Me.lblNrOrdine.TabIndex = 0
        Me.lblNrOrdine.Text = "Numero Ordine :"
        '
        'txtNrOrdine
        '
        Me.txtNrOrdine.Location = New System.Drawing.Point(112, 16)
        Me.txtNrOrdine.MaxLength = 20
        Me.txtNrOrdine.Name = "txtNrOrdine"
        Me.txtNrOrdine.ReadOnly = True
        Me.txtNrOrdine.Size = New System.Drawing.Size(88, 20)
        Me.txtNrOrdine.TabIndex = 1
        Me.txtNrOrdine.TabStop = False
        Me.txtNrOrdine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtNrOrdine, "Codice Articolo (F9=Ricerca)")
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'btnSceltaOrdine
        '
        Me.btnSceltaOrdine.Image = Global.GestioneProduzione.My.Resources.Resources.cerca
        Me.btnSceltaOrdine.Location = New System.Drawing.Point(216, 8)
        Me.btnSceltaOrdine.Name = "btnSceltaOrdine"
        Me.btnSceltaOrdine.Size = New System.Drawing.Size(32, 32)
        Me.btnSceltaOrdine.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSceltaOrdine, "Ricerca e selezione ordine")
        '
        'txtCausaleOrdine
        '
        Me.txtCausaleOrdine.Location = New System.Drawing.Point(273, 15)
        Me.txtCausaleOrdine.MaxLength = 20
        Me.txtCausaleOrdine.Name = "txtCausaleOrdine"
        Me.txtCausaleOrdine.ReadOnly = True
        Me.txtCausaleOrdine.Size = New System.Drawing.Size(88, 20)
        Me.txtCausaleOrdine.TabIndex = 11
        Me.txtCausaleOrdine.TabStop = False
        Me.txtCausaleOrdine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtCausaleOrdine, "Codice Articolo (F9=Ricerca)")
        Me.txtCausaleOrdine.Visible = False
        '
        'DataGridRigheOrdine
        '
        Me.DataGridRigheOrdine.AllowSorting = False
        Me.DataGridRigheOrdine.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DataGridRigheOrdine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridRigheOrdine.CaptionText = "Elenco Righe Aperte"
        Me.DataGridRigheOrdine.DataMember = ""
        Me.DataGridRigheOrdine.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridRigheOrdine.Location = New System.Drawing.Point(8, 136)
        Me.DataGridRigheOrdine.Name = "DataGridRigheOrdine"
        Me.DataGridRigheOrdine.ReadOnly = True
        Me.DataGridRigheOrdine.Size = New System.Drawing.Size(784, 171)
        Me.DataGridRigheOrdine.TabIndex = 7
        Me.DataGridRigheOrdine.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.DataGridTableStyle1.DataGrid = Me.DataGridRigheOrdine
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.CodArticolo, Me.DescrArticolo, Me.QtDisponibile, Me.QtOrdinata, Me.QtEvasa})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "RigheOrdine"
        '
        'CodArticolo
        '
        Me.CodArticolo.Format = ""
        Me.CodArticolo.FormatInfo = Nothing
        Me.CodArticolo.HeaderText = "Codice Articolo"
        Me.CodArticolo.MappingName = "t20_cod_articolo"
        Me.CodArticolo.NullText = ""
        Me.CodArticolo.Width = 75
        '
        'DescrArticolo
        '
        Me.DescrArticolo.Format = ""
        Me.DescrArticolo.FormatInfo = Nothing
        Me.DescrArticolo.HeaderText = "Descrizione Articolo"
        Me.DescrArticolo.MappingName = "t20_descrizione"
        Me.DescrArticolo.NullText = ""
        Me.DescrArticolo.Width = 400
        '
        'QtDisponibile
        '
        Me.QtDisponibile.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtDisponibile.Format = "#####0.00"
        Me.QtDisponibile.FormatInfo = Nothing
        Me.QtDisponibile.HeaderText = "Q.tà Disponibile"
        Me.QtDisponibile.MappingName = "t20_qt_disponibile"
        Me.QtDisponibile.NullText = "0"
        Me.QtDisponibile.Width = 75
        '
        'QtOrdinata
        '
        Me.QtOrdinata.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.QtOrdinata.Format = "#####0.00"
        Me.QtOrdinata.FormatInfo = Nothing
        Me.QtOrdinata.HeaderText = "Q.tà Ordinata"
        Me.QtOrdinata.MappingName = "t09_qt_ordinata"
        Me.QtOrdinata.NullText = "0"
        Me.QtOrdinata.Width = 75
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
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEvadi})
        '
        'mnuEvadi
        '
        Me.mnuEvadi.Index = 0
        Me.mnuEvadi.Text = "Evadi Definitivamente Riga"
        '
        'DateTimePickerOrdine
        '
        Me.DateTimePickerOrdine.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerOrdine.Enabled = False
        Me.DateTimePickerOrdine.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerOrdine.Location = New System.Drawing.Point(112, 104)
        Me.DateTimePickerOrdine.Name = "DateTimePickerOrdine"
        Me.DateTimePickerOrdine.ShowCheckBox = True
        Me.DateTimePickerOrdine.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePickerOrdine.TabIndex = 10
        '
        'lblDataOrdine
        '
        Me.lblDataOrdine.Location = New System.Drawing.Point(8, 104)
        Me.lblDataOrdine.Name = "lblDataOrdine"
        Me.lblDataOrdine.Size = New System.Drawing.Size(96, 23)
        Me.lblDataOrdine.TabIndex = 9
        Me.lblDataOrdine.Text = "Data Ordine :"
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(696, 317)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 12
        Me.btnChiudi.Text = "&Chiudi"
        '
        'frmEvasioneOrdini
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(800, 361)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.txtCausaleOrdine)
        Me.Controls.Add(Me.DateTimePickerOrdine)
        Me.Controls.Add(Me.lblDataOrdine)
        Me.Controls.Add(Me.DataGridRigheOrdine)
        Me.Controls.Add(Me.txtNrOrdine)
        Me.Controls.Add(Me.txtDescrOrdine)
        Me.Controls.Add(Me.btnSceltaOrdine)
        Me.Controls.Add(Me.lblNrOrdine)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEvasioneOrdini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Evasione Ordini"
        CType(Me.DataGridRigheOrdine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property ID_Ordine() As Integer
        Get
            Return m_IDOrdine
        End Get
        Set(ByVal Value As Integer)
            m_IDOrdine = Value
        End Set
    End Property

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmEvasioneOrdini_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        Me.DateTimePickerOrdine.Value = Date.Today

        If m_IDOrdine > 0 Then 'Chiamata con parametro
            Call CaricaDatiOrdine()
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSceltaOrdine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaOrdine.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormElencoOrdiniFor As New frmElencoOrdiniFor
        FormElencoOrdiniFor.Ricerca = True
        FormElencoOrdiniFor.ShowDialog()

        If FormElencoOrdiniFor.IDOrdine_Cercato <> -1 Then
            m_IDOrdine = FormElencoOrdiniFor.IDOrdine_Cercato
            Call CaricaDatiOrdine()
        End If

    End Sub

    Private Sub CaricaDatiOrdine()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DROrdine As SqlClient.SqlDataReader

        m_SQL = "SELECT * FROM t08_testate_ordini_for WHERE t08_id_testata_ordine_for = " & m_IDOrdine.ToString

        DROrdine = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)

        If DROrdine.HasRows Then

            DROrdine.Read()

            'If DROrdine("t08_id_testata_ordine_for").GetType Is Type.GetType("System.DBNull") Then
            '    Me.txtNrOrdine.Text = ""
            'Else
            '    Me.txtNrOrdine.Text = DROrdine("t08_id_testata_ordine_for")
            'End If

            If DROrdine("t08_cod_testata_ordine_for").GetType Is Type.GetType("System.DBNull") Then
                Me.txtNrOrdine.Text = ""
            Else
                Me.txtNrOrdine.Text = DROrdine("t08_cod_testata_ordine_for")
            End If

            If DROrdine("t08_descrizione").GetType Is Type.GetType("System.DBNull") Then
                Me.txtDescrOrdine.Text = ""
            Else
                Me.txtDescrOrdine.Text = DROrdine("t08_descrizione")
            End If

            If DROrdine("t08_dt_ordine").GetType Is Type.GetType("System.DBNull") Then
                Me.DateTimePickerOrdine.Value = Date.Today
            Else
                Me.DateTimePickerOrdine.Value = DROrdine("t08_dt_ordine")
            End If

            'Valorizzo la causale per un controllo in fase di evasione
            If DROrdine("t08_id_causale_ordine_for_t15").GetType Is Type.GetType("System.DBNull") Then
                Me.txtCausaleOrdine.Text = ""
            Else
                Me.txtCausaleOrdine.Text = DROrdine("t08_id_causale_ordine_for_t15")
            End If

        End If

        m_SQL = ""
        m_SQL += "SELECT * FROM t08_testate_ordini_for INNER JOIN t09_righe_ordine_for "
        m_SQL += "ON t08_id_testata_ordine_for = t09_id_testata_ordine_for_t08 "
        m_SQL += "INNER JOIN t20_articoli ON t09_id_articolo_t20 = t20_id_articolo "
        m_SQL += "WHERE t08_dt_cancellazione IS NULL AND t09_dt_cancellazione IS NULL AND "
        m_SQL += "t09_id_stato_riga_ordine_t10 = 'A' AND t08_id_testata_ordine_for = " & m_IDOrdine.ToString & " "
        m_SQL += "ORDER BY t08_id_testata_ordine_for, t09_posizione"

        objdsRigheOrdine = ExecuteDataset(conn1.ConnectionString, CommandType.Text, m_SQL)
        objdsRigheOrdine.Tables(0).TableName = "RigheOrdine"

        DataGridRigheOrdine.DataSource = objdsRigheOrdine
        DataGridRigheOrdine.DataMember = "RigheOrdine"

        'default
        Cursor.Current = Cursors.Default

        If objdsRigheOrdine.Tables("RigheOrdine").Rows.Count <= 0 Then
            MessageBox.Show("L'ordine attualmente non ha righe aperte!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    ''' <summary>
    ''' Evasione Parziale
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridOrdiniArticolo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridRigheOrdine.DoubleClick

        If m_IDOrdine = 0 Then
            MessageBox.Show("Scegliere un ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsRigheOrdine.Tables("RigheOrdine").Rows.Count <= 0 Then
            MessageBox.Show("Impossibile inserire una quantità da evadere! L'ordine attualmente non ha righe aperte!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim intIDRiga As Integer
        Dim intIDArticolo As Integer
        Dim blnAggiornaStato As Boolean = False

        intIDRiga = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_id_riga_ordine_for")
        intIDArticolo = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_id_articolo_t20")

        'memorizzo i valori precedenti per eventuali controlli
        Dim sngQtOrdinata As Single
        Dim sngQtEvasaPrecedente As Single

        Try
            sngQtOrdinata = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_qt_ordinata")
        Catch ex As Exception
            sngQtOrdinata = 0
        End Try

        Try
            sngQtEvasaPrecedente = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_qt_evasa")
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

                If txtCausaleOrdine.Text = DataModel.ORDINE_FOR_CAUSALE_CLAVORAZIONE.ToString Then
                    MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    If MessageBox.Show("ATTENZIONE: evadere questa quantità superiore all'ordinato?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

            'la quantità evasa dopo questa evasione non deve essere inferiore a 0
            If (sngQtDaEvadere + sngQtEvasaPrecedente) < 0 Then
                If txtCausaleOrdine.Text = DataModel.ORDINE_FOR_CAUSALE_CLAVORAZIONE.ToString Then

                    MessageBox.Show("Impossibile evadere quantità superiori all'ordinato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    If MessageBox.Show("ATTENZIONE: evadere questa quantità superiore all'ordinato?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If

        End If

        'se la quantità evasa dopo questa evasione è maggiore o pari alla
        'quantità ordinata chiede conferma di evasione completa
        '(cambio stato riga)
        If CSng(sngQtDaEvadere + sngQtEvasaPrecedente) >= CSng(sngQtOrdinata) Then
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
        If blnAggiornaStato Then m_SQL += "t09_id_stato_riga_ordine_t10 = 'E', "
        m_SQL += "t09_dt_modifica = GetDate() WHERE "
        m_SQL += "t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        m_SQL += "t09_id_riga_ordine_for = " & intIDRiga.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        'm_SQL = ""
        'm_SQL += "UPDATE t01_articoli SET "
        'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + " & strQtDaEvadere & ", "
        'm_SQL += "t01_dt_modifica = GetDate() WHERE "
        'm_SQL += "t01_id_articolo = " & intIDArticolo.ToString
        m_SQL = ""
        m_SQL += "UPDATE t20_articoli SET "
        m_SQL += "t20_qt_disponibile = t20_qt_disponibile + " & strQtDaEvadere & ", "
        m_SQL += "t20_dt_modifica = GetDate() WHERE "
        m_SQL += "t20_id_articolo = " & intIDArticolo.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        Call CaricaDatiOrdine()

        Cursor.Current = Cursors.Default

    End Sub

    ''' <summary>
    ''' Evasione definitiva Riga
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub mnuEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEvadi.Click

        If m_IDOrdine = 0 Then
            MessageBox.Show("Scegliere un ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If objdsRigheOrdine.Tables("RigheOrdine").Rows.Count <= 0 Then
            MessageBox.Show("Impossibile evadere la riga! L'ordine attualmente non ha righe aperte!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi evasione definitiva riga ordine?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Exit Sub

        Dim intIDRiga As Integer
        Dim intIDArticolo As Integer

        intIDRiga = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_id_riga_ordine_for")
        intIDArticolo = objdsRigheOrdine.Tables("RigheOrdine").Rows(DataGridRigheOrdine.CurrentRowIndex)("t09_id_articolo_t20")

        Cursor.Current = Cursors.WaitCursor

        m_SQL = ""
        m_SQL += "UPDATE t09_righe_ordine_for SET "
        m_SQL += "t09_id_stato_riga_ordine_t10 = 'E', "
        m_SQL += "t09_dt_modifica = GetDate() WHERE "
        m_SQL += "t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        m_SQL += "t09_id_riga_ordine_for = " & intIDRiga.ToString
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        '----
        ' Aggiunto da Mirco per Aggiornare la t01_qt_disponibile quando viene evaso definitivamente un RIGO
        'm_SQL = ""
        'm_SQL += "UPDATE t01_articoli SET "
        'm_SQL += "t01_qt_disponibile = t01_qt_disponibile + "
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_qt_ordinata - t09_qt_evasa FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ), "
        'm_SQL += "t01_dt_modifica = GetDate() WHERE "
        'm_SQL += "t01_id_articolo = "
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_id_articolo_t20 FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ) "
        m_SQL = ""
        m_SQL += "UPDATE t20_articoli SET "
        m_SQL += "t20_qt_disponibile = t20_qt_disponibile + "
        m_SQL += "      ( "
        m_SQL += "      SELECT t09_qt_ordinata - t09_qt_evasa FROM t09_righe_ordine_for WHERE "
        m_SQL += "      t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        m_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        m_SQL += "      ), "
        m_SQL += "t20_dt_modifica = GetDate() WHERE "
        m_SQL += "t20_id_articolo = " & intIDArticolo.ToString
        'm_SQL += "      ( "
        'm_SQL += "      SELECT t09_id_articolo_t20 FROM t09_righe_ordine_for WHERE "
        'm_SQL += "      t09_id_testata_ordine_for_t08 = " & m_IDOrdine.ToString & " AND "
        'm_SQL += "      t09_id_riga_ordine_for = " & intIDRiga.ToString
        'm_SQL += "      ) "
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)
        '----

        Call CaricaDatiOrdine()

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub DataGridOrdiniArticolo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridRigheOrdine.MouseDown

        'Visualizza il menù di contesto solo nel RowHeader
        Dim pt As System.Drawing.Point = New Point(e.X, e.Y)
        Dim hti As DataGrid.HitTestInfo = DataGridRigheOrdine.HitTest(pt)

        If hti.Type = DataGrid.HitTestType.RowHeader Then
            If e.Button = MouseButtons.Right Then
                DataGridRigheOrdine.CurrentCell = New DataGridCell(hti.Row, hti.Column)
                ContextMenu1.Show(DataGridRigheOrdine, pt)
            End If
        End If

    End Sub

    Private Sub DataGridRigheOrdine_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGridRigheOrdine.Navigate

    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub
End Class
