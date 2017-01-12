Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmAnagraficaArticoli
    Inherits System.Windows.Forms.Form

    Private m_Variazione As Boolean
    Private m_IDArticolo As Integer
    Private m_Codice As String
    Private m_Descrizione As String
    Private m_Modificato As Boolean
    Private m_ChiudiDopoSalvataggio As Boolean

    'SETTARE QUESTA VARIABILE A FALSE SE SI VUOLE IMPEDIRE
    'IL SALVATAGGIO DI CODICI ARTICOLO DOPPI. ALTRIMENTI, PER
    'VISUALIZZARE CONFERMA DI SALVATAGGIO SETTARE A TRUE.
    Private m_ConsentiCodiciDoppi As Boolean = False
    Friend WithEvents chbRicambio As System.Windows.Forms.CheckBox

    Private m_SQL As String

    ' Private CanClose As Boolean = False ' Verifico se l'utente preme il pulsante per uscire o la X

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
    Friend WithEvents btnEliminaArticolo As System.Windows.Forms.Button
    Friend WithEvents btnNuovoArticolo As System.Windows.Forms.Button
    Friend WithEvents btnSceltaArticolo As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents lblQtDisponibile As System.Windows.Forms.Label
    Friend WithEvents lblQtOrdinata As System.Windows.Forms.Label
    Friend WithEvents txtDescrArticolo As System.Windows.Forms.TextBox
    Friend WithEvents txtQtDisponibile As System.Windows.Forms.TextBox
    Friend WithEvents txtQtOrdinata As System.Windows.Forms.TextBox
    Friend WithEvents lblCodArticolo As System.Windows.Forms.Label
    Friend WithEvents txtCodArticolo As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblPrezzo As System.Windows.Forms.Label
    Friend WithEvents txtPrezzo As System.Windows.Forms.TextBox
    Friend WithEvents btnEvadi As System.Windows.Forms.Button
    Friend WithEvents btnOrdina As System.Windows.Forms.Button
    Friend WithEvents lblLottoRiordino As System.Windows.Forms.Label
    Friend WithEvents txtLottoMinimo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalva1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnagraficaArticoli))
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.lblQtDisponibile = New System.Windows.Forms.Label
        Me.lblQtOrdinata = New System.Windows.Forms.Label
        Me.txtDescrArticolo = New System.Windows.Forms.TextBox
        Me.txtQtDisponibile = New System.Windows.Forms.TextBox
        Me.txtQtOrdinata = New System.Windows.Forms.TextBox
        Me.lblCodArticolo = New System.Windows.Forms.Label
        Me.txtCodArticolo = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.btnEliminaArticolo = New System.Windows.Forms.Button
        Me.btnNuovoArticolo = New System.Windows.Forms.Button
        Me.btnSceltaArticolo = New System.Windows.Forms.Button
        Me.btnSalva1 = New System.Windows.Forms.Button
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnOrdina = New System.Windows.Forms.Button
        Me.btnEvadi = New System.Windows.Forms.Button
        Me.lblPrezzo = New System.Windows.Forms.Label
        Me.txtPrezzo = New System.Windows.Forms.TextBox
        Me.txtLottoMinimo = New System.Windows.Forms.TextBox
        Me.lblLottoRiordino = New System.Windows.Forms.Label
        Me.chbRicambio = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 48)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(100, 23)
        Me.lblDescrizione.TabIndex = 5
        Me.lblDescrizione.Text = "Descrizione :"
        '
        'lblQtDisponibile
        '
        Me.lblQtDisponibile.Location = New System.Drawing.Point(8, 168)
        Me.lblQtDisponibile.Name = "lblQtDisponibile"
        Me.lblQtDisponibile.Size = New System.Drawing.Size(100, 23)
        Me.lblQtDisponibile.TabIndex = 9
        Me.lblQtDisponibile.Text = "Q.tà Disponibile :"
        '
        'lblQtOrdinata
        '
        Me.lblQtOrdinata.Location = New System.Drawing.Point(8, 200)
        Me.lblQtOrdinata.Name = "lblQtOrdinata"
        Me.lblQtOrdinata.Size = New System.Drawing.Size(80, 23)
        Me.lblQtOrdinata.TabIndex = 11
        Me.lblQtOrdinata.Text = "Q.tà Ordinata :"
        '
        'txtDescrArticolo
        '
        Me.txtDescrArticolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrArticolo.Location = New System.Drawing.Point(112, 48)
        Me.txtDescrArticolo.MaxLength = 4000
        Me.txtDescrArticolo.Multiline = True
        Me.txtDescrArticolo.Name = "txtDescrArticolo"
        Me.txtDescrArticolo.Size = New System.Drawing.Size(360, 48)
        Me.txtDescrArticolo.TabIndex = 1
        '
        'txtQtDisponibile
        '
        Me.txtQtDisponibile.Location = New System.Drawing.Point(112, 168)
        Me.txtQtDisponibile.Name = "txtQtDisponibile"
        Me.txtQtDisponibile.Size = New System.Drawing.Size(72, 20)
        Me.txtQtDisponibile.TabIndex = 4
        Me.txtQtDisponibile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtOrdinata
        '
        Me.txtQtOrdinata.Location = New System.Drawing.Point(112, 200)
        Me.txtQtOrdinata.Name = "txtQtOrdinata"
        Me.txtQtOrdinata.ReadOnly = True
        Me.txtQtOrdinata.Size = New System.Drawing.Size(72, 20)
        Me.txtQtOrdinata.TabIndex = 12
        Me.txtQtOrdinata.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.txtCodArticolo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodArticolo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCodArticolo, "Codice Articolo (F9=Ricerca, F10=Nuovo)")
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'btnEliminaArticolo
        '
        Me.btnEliminaArticolo.Image = CType(resources.GetObject("btnEliminaArticolo.Image"), System.Drawing.Image)
        Me.btnEliminaArticolo.Location = New System.Drawing.Point(352, 8)
        Me.btnEliminaArticolo.Name = "btnEliminaArticolo"
        Me.btnEliminaArticolo.Size = New System.Drawing.Size(32, 31)
        Me.btnEliminaArticolo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnEliminaArticolo, "Elimina articolo")
        '
        'btnNuovoArticolo
        '
        Me.btnNuovoArticolo.Image = CType(resources.GetObject("btnNuovoArticolo.Image"), System.Drawing.Image)
        Me.btnNuovoArticolo.Location = New System.Drawing.Point(312, 8)
        Me.btnNuovoArticolo.Name = "btnNuovoArticolo"
        Me.btnNuovoArticolo.Size = New System.Drawing.Size(32, 31)
        Me.btnNuovoArticolo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnNuovoArticolo, "Nuovo articolo")
        '
        'btnSceltaArticolo
        '
        Me.btnSceltaArticolo.Image = CType(resources.GetObject("btnSceltaArticolo.Image"), System.Drawing.Image)
        Me.btnSceltaArticolo.Location = New System.Drawing.Point(274, 8)
        Me.btnSceltaArticolo.Name = "btnSceltaArticolo"
        Me.btnSceltaArticolo.Size = New System.Drawing.Size(32, 32)
        Me.btnSceltaArticolo.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.btnSceltaArticolo, "Ricerca e selezione articolo")
        '
        'btnSalva1
        '
        Me.btnSalva1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva1.Location = New System.Drawing.Point(304, 248)
        Me.btnSalva1.Name = "btnSalva1"
        Me.btnSalva1.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva1.TabIndex = 5
        Me.btnSalva1.Text = "&Salva"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Location = New System.Drawing.Point(392, 248)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 16
        Me.btnAnnulla.Text = "&Chiudi"
        '
        'btnOrdina
        '
        Me.btnOrdina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrdina.Location = New System.Drawing.Point(8, 247)
        Me.btnOrdina.Name = "btnOrdina"
        Me.btnOrdina.Size = New System.Drawing.Size(75, 23)
        Me.btnOrdina.TabIndex = 13
        Me.btnOrdina.Text = "&Ordina"
        Me.ToolTip1.SetToolTip(Me.btnOrdina, "Apre la finestra d'inserimento ordini fornitore")
        '
        'btnEvadi
        '
        Me.btnEvadi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEvadi.Location = New System.Drawing.Point(96, 247)
        Me.btnEvadi.Name = "btnEvadi"
        Me.btnEvadi.Size = New System.Drawing.Size(75, 23)
        Me.btnEvadi.TabIndex = 14
        Me.btnEvadi.Text = "&Evadi"
        Me.ToolTip1.SetToolTip(Me.btnEvadi, "Apre la finestra d'evasione ordini")
        '
        'lblPrezzo
        '
        Me.lblPrezzo.Location = New System.Drawing.Point(8, 104)
        Me.lblPrezzo.Name = "lblPrezzo"
        Me.lblPrezzo.Size = New System.Drawing.Size(80, 23)
        Me.lblPrezzo.TabIndex = 7
        Me.lblPrezzo.Text = "Prezzo :"
        '
        'txtPrezzo
        '
        Me.txtPrezzo.Location = New System.Drawing.Point(112, 104)
        Me.txtPrezzo.Name = "txtPrezzo"
        Me.txtPrezzo.Size = New System.Drawing.Size(72, 20)
        Me.txtPrezzo.TabIndex = 2
        Me.txtPrezzo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLottoMinimo
        '
        Me.txtLottoMinimo.Location = New System.Drawing.Point(112, 136)
        Me.txtLottoMinimo.Name = "txtLottoMinimo"
        Me.txtLottoMinimo.Size = New System.Drawing.Size(72, 20)
        Me.txtLottoMinimo.TabIndex = 3
        Me.txtLottoMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLottoRiordino
        '
        Me.lblLottoRiordino.Location = New System.Drawing.Point(8, 136)
        Me.lblLottoRiordino.Name = "lblLottoRiordino"
        Me.lblLottoRiordino.Size = New System.Drawing.Size(112, 23)
        Me.lblLottoRiordino.TabIndex = 18
        Me.lblLottoRiordino.Text = "Lotto Min. Riordino :"
        '
        'chbRicambio
        '
        Me.chbRicambio.AutoSize = True
        Me.chbRicambio.Location = New System.Drawing.Point(386, 106)
        Me.chbRicambio.Name = "chbRicambio"
        Me.chbRicambio.Size = New System.Drawing.Size(92, 17)
        Me.chbRicambio.TabIndex = 19
        Me.chbRicambio.Text = "E' un ricambio"
        Me.chbRicambio.UseVisualStyleBackColor = True
        '
        'frmAnagraficaArticoli
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnAnnulla
        Me.ClientSize = New System.Drawing.Size(480, 285)
        Me.Controls.Add(Me.chbRicambio)
        Me.Controls.Add(Me.txtLottoMinimo)
        Me.Controls.Add(Me.txtPrezzo)
        Me.Controls.Add(Me.txtCodArticolo)
        Me.Controls.Add(Me.txtDescrArticolo)
        Me.Controls.Add(Me.txtQtDisponibile)
        Me.Controls.Add(Me.txtQtOrdinata)
        Me.Controls.Add(Me.lblLottoRiordino)
        Me.Controls.Add(Me.btnOrdina)
        Me.Controls.Add(Me.btnEvadi)
        Me.Controls.Add(Me.lblPrezzo)
        Me.Controls.Add(Me.btnSalva1)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnEliminaArticolo)
        Me.Controls.Add(Me.btnNuovoArticolo)
        Me.Controls.Add(Me.btnSceltaArticolo)
        Me.Controls.Add(Me.lblCodArticolo)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Controls.Add(Me.lblQtDisponibile)
        Me.Controls.Add(Me.lblQtOrdinata)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnagraficaArticoli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anagrafica Articoli"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Definizione Property"

    Public Property IDArticolo() As Integer
        Get
            Return m_IDArticolo
        End Get
        Set(ByVal Value As Integer)
            m_IDArticolo = Value
        End Set
    End Property


    Public Property Codice() As String
        Get
            Return m_Codice
        End Get
        Set(ByVal Value As String)
            m_Codice = Value
        End Set
    End Property

    Public Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get
        Set(ByVal Value As String)
            m_Descrizione = Value
        End Set
    End Property

    Public Property ChiudiDopoSalvataggio() As Boolean
        Get
            Return m_ChiudiDopoSalvataggio
        End Get
        Set(ByVal Value As Boolean)
            m_ChiudiDopoSalvataggio = Value
        End Set
    End Property

#End Region

#Region "Eventi Form"

    Private Sub frmArticoli_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        If m_IDArticolo > 0 Then
            Call CaricaDatiArticolo()
            Me.txtCodArticolo.Enabled = False
            Me.btnSceltaArticolo.Enabled = False
            Me.btnNuovoArticolo.Enabled = False
        Else
            Call NuovoArticolo()
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmArticoli_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'Solo se ci sono state modifiche viene chiesto la conferma di salvataggio
        If m_Modificato Then
            If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima della chiusura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                If Not SalvaDati() Then
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

#End Region

#Region "Eventi Controlli Form"

    Private Sub txtCodArticolo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodArticolo.TextChanged
        m_Modificato = True
    End Sub

    Private Sub txtCodArticolo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodArticolo.KeyDown
        If e.KeyValue = Keys.F9 Then
            Call btnSceltaArticolo_Click(txtCodArticolo, Nothing)
        ElseIf e.KeyValue = Keys.F10 Then
            Call btnNuovoArticolo_Click(txtCodArticolo, Nothing)
        End If
    End Sub

    Private Sub txtDescrArticolo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrArticolo.TextChanged
        m_Modificato = True
    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub btnOrdina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdina.Click

        If m_IDArticolo <> -1 Then

            If m_Modificato Then

                Dim m_OldIDArticolo As Integer
                'memorizza l'ID Articolo
                m_OldIDArticolo = m_IDArticolo

                If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima dell'inserimento ordini?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                    If Not SalvaDati() Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

                'ripristina l'ID Articolo (resettato da SalvaDati)
                m_IDArticolo = m_OldIDArticolo
                Call CaricaDatiArticolo()

            End If

        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormOrdiniFor As New frmOrdiniFor
        FormOrdiniFor.ShowDialog()

        'richiama l'articolo per un refresh
        Call CaricaDatiArticolo()

    End Sub

    Private Sub btnEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEvadi.Click

        If m_IDArticolo <> -1 Then

            If m_Modificato Then

                Dim m_OldIDArticolo As Integer
                'memorizza l'ID Articolo
                m_OldIDArticolo = m_IDArticolo

                If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima dell'evasione?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                    If Not SalvaDati() Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

                'ripristina l'ID Articolo (resettato da SalvaDati)
                m_IDArticolo = m_OldIDArticolo
                Call CaricaDatiArticolo()

            End If

        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormEvasione As New frmEvasioneArticoli
        If m_IDArticolo <> -1 Then
            FormEvasione.IDArticolo = m_IDArticolo
        End If
        FormEvasione.ShowDialog()

        'richiama l'articolo per un refresh
        If m_IDArticolo <> -1 Then
            Call CaricaDatiArticolo()
        End If

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

    Private Sub btnNuovoArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoArticolo.Click

        If m_Modificato Then
            If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima dell'inserimento nuovo articolo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                Dim blnSalvataggioOk As Boolean
                blnSalvataggioOk = SalvaDati()
            Else
                Call NuovoArticolo()
            End If
        End If

    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva1.Click

        Dim blnSalvataggioOk As Boolean
        blnSalvataggioOk = SalvaDati()
        If blnSalvataggioOk And m_ChiudiDopoSalvataggio Then
            Me.Close()
        End If

    End Sub

    Private Sub btnEliminaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaArticolo.Click

        If Not m_Variazione Then
            MessageBox.Show("Articolo in fase di inserimento! Impossibile eliminarlo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If m_IDArticolo = -1 Then
            MessageBox.Show("Scegliere prima un articolo valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi eliminazione articolo?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim DRControlloGruppi As SqlClient.SqlDataReader

            'un articolo non è eliminabile se fa parte di un gruppo non eliminato
            'm_SQL = ""
            'm_SQL += "SELECT * FROM t01_articoli INNER JOIN t02_articoli_gruppi ON "
            'm_SQL += "t01_id_articolo = t02_id_articolo_t01 INNER JOIN t03_gruppi ON "
            'm_SQL += "t02_id_gruppo_t03 = t03_id_gruppo WHERE t03_dt_cancellazione IS NULL AND "
            'm_SQL += "t02_dt_cancellazione IS NULL AND "
            'm_SQL += "t01_id_articolo = " & m_IDArticolo.ToString
            m_SQL = ""
            m_SQL += "SELECT t20_articoli.* FROM t20_articoli INNER JOIN t22_articoli_articoli ON "
            m_SQL += "t20_id_articolo = t22_id_articolo_t20 INNER JOIN t20_articoli AS PADRI ON "
            m_SQL += "t22_id_articolo_padre_t20 = PADRI.t20_articoli WHERE PADRI.t20_dt_cancellazione IS NULL AND "
            m_SQL += "t22_dt_cancellazione IS NULL AND "
            m_SQL += "t20_id_articolo = " & m_IDArticolo.ToString

            DRControlloGruppi = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)
            If DRControlloGruppi.HasRows Then
                MessageBox.Show("Impossibile eliminare l'articolo perchè appartiene almeno ad un articolo o gruppo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            'm_SQL = "UPDATE t01_articoli SET t01_dt_cancellazione = GetDate() WHERE t01_id_articolo = " & m_IDArticolo.ToString
            m_SQL = "UPDATE t20_articoli SET t20_dt_cancellazione = GetDate() WHERE t20_id_articolo = " & m_IDArticolo.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            Call NuovoArticolo()
        End If

    End Sub

#Region "Eventi txtPrezzo"

    Private Sub txtPrezzo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrezzo.TextChanged

        Dim intCursorPos As Integer = txtPrezzo.SelectionStart

        With txtPrezzo
            .Text = Replace(.Text, ".", ",")    'rimpiazza il "." con la ","
            If intCursorPos > -1 Then
                .SelectionStart = intCursorPos
            End If
        End With

        m_Modificato = True

    End Sub

    Private Sub txtPrezzo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrezzo.KeyPress

        'variabile che indica se è selezionato tutto il testo
        Dim blnSelectedAll As Boolean = (Me.txtPrezzo.SelectedText = Me.txtPrezzo.Text And Me.txtPrezzo.SelectionLength = Me.txtPrezzo.Text.Length)

        'Permette BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        'Permette il "." o la "," solo una volta.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 46 Then
            'N.B.: viene controllata la "," in quanto il "." viene 
            'rimpiazzato dalla "," nell'evento TextChanged()
            If Not blnSelectedAll Then
                If InStr(Me.txtPrezzo.Text, ",") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If

        'Permette il "-" solo una volta e come primo carattere.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 45 Then
            If Not blnSelectedAll Then
                'se c'è già un "-" non ne permette un nuovo inserimento
                If InStr(Me.txtPrezzo.Text, "-") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    'viene accettato solo come primo carattere
                    If txtPrezzo.SelectionStart > 0 Then
                        e.Handled = True
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            Else
                Exit Sub
            End If
        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtPrezzo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPrezzo.Validating
        FormattaComeNumero(Me.txtPrezzo.Text, 4)
    End Sub

    Private Sub txtPrezzo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrezzo.Enter
        Me.txtPrezzo.SelectionStart = 0
        Me.txtPrezzo.SelectionLength = Me.txtPrezzo.Text.Length
    End Sub

#End Region

#Region "Eventi txtLottoMinimo"

    Private Sub txtLottoMinimo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLottoMinimo.TextChanged

        Dim intCursorPos As Integer = txtLottoMinimo.SelectionStart

        With txtLottoMinimo
            .Text = Replace(.Text, ".", ",")    'rimpiazza il "." con la ","
            If intCursorPos > -1 Then
                .SelectionStart = intCursorPos
            End If
        End With

        m_Modificato = True

    End Sub

    Private Sub txtLottoMinimo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLottoMinimo.KeyPress

        'variabile che indica se è selezionato tutto il testo
        Dim blnSelectedAll As Boolean = (Me.txtLottoMinimo.SelectedText = Me.txtLottoMinimo.Text And Me.txtLottoMinimo.SelectionLength = Me.txtLottoMinimo.Text.Length)

        'Permette BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        'Permette il "." o la "," solo una volta.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 46 Then
            'N.B.: viene controllata la "," in quanto il "." viene 
            'rimpiazzato dalla "," nell'evento TextChanged()
            If Not blnSelectedAll Then
                If InStr(Me.txtLottoMinimo.Text, ",") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If

        'Permette il "-" solo una volta e come primo carattere.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 45 Then
            If Not blnSelectedAll Then
                'se c'è già un "-" non ne permette un nuovo inserimento
                If InStr(Me.txtLottoMinimo.Text, "-") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    'viene accettato solo come primo carattere
                    If txtLottoMinimo.SelectionStart > 0 Then
                        e.Handled = True
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            Else
                Exit Sub
            End If
        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtLottoMinimo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtLottoMinimo.Validating
        FormattaComeNumero(Me.txtLottoMinimo.Text, 4)
    End Sub

    Private Sub txtLottoMinimo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLottoMinimo.Enter
        Me.txtLottoMinimo.SelectionStart = 0
        Me.txtLottoMinimo.SelectionLength = Me.txtLottoMinimo.Text.Length
    End Sub

#End Region

#Region "Eventi txtQtDisponibile"

    Private Sub txtQtDisponibile_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtDisponibile.TextChanged
        Dim intCursorPos As Integer = txtQtDisponibile.SelectionStart

        With txtQtDisponibile
            .Text = Replace(.Text, ".", ",")    'rimpiazza il "." con la ","
            If intCursorPos > -1 Then
                .SelectionStart = intCursorPos
            End If
        End With

        m_Modificato = True
    End Sub

    Private Sub txtQtDisponibile_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtDisponibile.KeyPress

        'variabile che indica se è selezionato tutto il testo
        Dim blnSelectedAll As Boolean = (Me.txtQtDisponibile.SelectedText = Me.txtQtDisponibile.Text And Me.txtQtDisponibile.SelectionLength = Me.txtQtDisponibile.Text.Length)

        'Permette BACKSPACE
        If Asc(e.KeyChar) = 8 Then
            Exit Sub
        End If

        'Permette il "." o la "," solo una volta.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 44 Or Asc(e.KeyChar) = 46 Then
            'N.B.: viene controllata la "," in quanto il "." viene 
            'rimpiazzato dalla "," nell'evento TextChanged()
            If Not blnSelectedAll Then
                If InStr(Me.txtQtDisponibile.Text, ",") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If

        'Permette il "-" solo una volta e come primo carattere.
        'Se è selezionato tutto permette sempre il carattere
        If Asc(e.KeyChar) = 45 Then
            If Not blnSelectedAll Then
                'se c'è già un "-" non ne permette un nuovo inserimento
                If InStr(Me.txtQtDisponibile.Text, "-") > 0 Then
                    e.Handled = True
                    Exit Sub
                Else
                    'viene accettato solo come primo carattere
                    If txtQtDisponibile.SelectionStart > 0 Then
                        e.Handled = True
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            Else
                Exit Sub
            End If
        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtQtDisponibile_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtQtDisponibile.Validating
        FormattaComeNumero(Me.txtQtDisponibile.Text, 2)
    End Sub

    Private Sub txtQtDisponibile_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQtDisponibile.Enter
        Me.txtQtDisponibile.SelectionStart = 0
        Me.txtQtDisponibile.SelectionLength = Me.txtQtDisponibile.Text.Length
    End Sub

#End Region

#End Region

#Region "Sub e Function personalizzate"

    Private Sub NuovoArticolo()

        m_IDArticolo = -1
        m_Variazione = False

        Me.txtCodArticolo.Text = ""
        Me.txtDescrArticolo.Text = ""
        Me.txtPrezzo.Text = 0
        Me.txtLottoMinimo.Text = 0
        Me.txtQtDisponibile.Text = 0
        Me.txtQtOrdinata.Text = 0

        Call FormattaCampiNumeri()

        m_Modificato = False

        Me.txtCodArticolo.Select()

    End Sub

    Private Sub CaricaDatiArticolo()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRArticolo As SqlClient.SqlDataReader

        'm_SQL = "SELECT t01_articoli.*, dbo.ufn_GetQuantitaOrdinataArticolo(t01_id_articolo) As t01_qt_ordinata FROM t01_articoli WHERE t01_id_articolo = " & m_IDArticolo.ToString
        m_SQL = "SELECT t20_articoli.*, dbo.ufn_GetQuantitaOrdinataArticolo(t20_id_articolo) As t20_qt_ordinata FROM t20_articoli WHERE t20_id_articolo = " & m_IDArticolo.ToString

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

            If DRArticolo("t20_prezzo").GetType Is Type.GetType("System.DBNull") Then
                Me.txtPrezzo.Text = 0
            Else
                Me.txtPrezzo.Text = DRArticolo("t20_prezzo")
            End If

            If DRArticolo("t20_lotto_riordino").GetType Is Type.GetType("System.DBNull") Then
                Me.txtLottoMinimo.Text = 0
            Else
                Me.txtLottoMinimo.Text = DRArticolo("t20_lotto_riordino")
            End If

            If DRArticolo("t20_qt_disponibile").GetType Is Type.GetType("System.DBNull") Then
                Me.txtQtDisponibile.Text = 0
            Else
                Me.txtQtDisponibile.Text = DRArticolo("t20_qt_disponibile")
            End If

            If DRArticolo("t20_qt_ordinata").GetType Is Type.GetType("System.DBNull") Then
                Me.txtQtOrdinata.Text = 0
            Else
                Me.txtQtOrdinata.Text = DRArticolo("t20_qt_ordinata")
            End If

            If DRArticolo("t20_is_ricambio").GetType Is Type.GetType("System.DBNull") Then
                Me.chbRicambio.Checked = False
            Else
                Me.chbRicambio.Checked = DRArticolo("t20_is_ricambio")
            End If

            'formattazione campi numerici
            Call FormattaCampiNumeri()

            'TODO: Controllare ufn_GetSubtreeInProduzioneSospese
            ''CONTROLLO SE L'ARTICOLO E' UN COMPONENTE DI UN GRUPPO DI UNA MACCHINA 
            ''ISTANZIATA IN PRODUZIONE O SOSPESA
            'm_SQL = "SELECT * FROM ufn_GetSubtreeInProduzioneSospese() WHERE "
            'm_SQL += "t02_id_articolo_t01 = " & m_IDArticolo.ToString

            m_SQL = "SELECT * FROM ufn_GetSubtree2() WHERE "
            m_SQL += "t22_id_articolo_t20 = " & m_IDArticolo.ToString
            m_SQL += " AND (t06_id_stato_istanza_t07 = 'P' OR t06_id_stato_istanza_t07 = 'S')"

            Dim DRIstanze As SqlClient.SqlDataReader
            DRIstanze = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)
            If DRIstanze.HasRows Then
                MessageBox.Show("ATTENZIONE! L'articolo che si sta richiamando appartiene ad una macchina istanziata in produzione o sospesa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else

            MessageBox.Show("Articolo non memorizzato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        m_Variazione = True
        m_Modificato = False

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

    Private Function DoppioApostrofo(ByVal strDaMemorizzare As String) As String
        Return "'" & Replace(strDaMemorizzare, "'", "''") & "'"
    End Function

    Private Function RimpiazzaVirgola(ByVal strNumero As String) As String
        Return Replace(strNumero, ",", ".")
    End Function

    Private Function BooleanToBit(ByVal valore As Boolean) As Byte
        If valore Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Private Sub FormattaCampiNumeri()
        FormattaComeNumero(Me.txtPrezzo.Text, 4)
        FormattaComeNumero(Me.txtQtDisponibile.Text, 2)
        FormattaComeNumero(Me.txtQtOrdinata.Text, 2)
        FormattaComeNumero(Me.txtLottoMinimo.Text, 2)
    End Sub

    Private Function SalvaDati() As Boolean

        Dim blnCodiceArticoloDoppio As Boolean

        If Me.txtCodArticolo.Text.Trim = "" Then
            MessageBox.Show("E' necessario indicare un codice articolo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If Me.txtDescrArticolo.Text.Trim = "" Then
            MessageBox.Show("E' necessario indicare una descrizione articolo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        blnCodiceArticoloDoppio = CodiceArticoloDoppio()
        If blnCodiceArticoloDoppio Then
            If m_ConsentiCodiciDoppi Then
                'solo messaggio di notifica e richiesta di salvataggio
                If MessageBox.Show("Codice articolo già memorizzato! Salvare comunque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return False
                End If
            Else
                'messaggio con blocco salvataggio
                MessageBox.Show("Codice articolo già memorizzato! Impossibile salvare!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If m_Variazione Then    'UPDATE

            'm_SQL = ""
            'm_SQL += "UPDATE t01_articoli SET "
            'm_SQL += "t01_cod_articolo = " & DoppioApostrofo(Me.txtCodArticolo.Text) & ", "
            'm_SQL += "t01_descrizione = " & DoppioApostrofo(Me.txtDescrArticolo.Text) & ", "
            'm_SQL += "t01_prezzo = " & RimpiazzaVirgola(Me.txtPrezzo.Text) & ", "
            'm_SQL += "t01_lotto_riordino = " & RimpiazzaVirgola(Me.txtLottoMinimo.Text) & ", "
            'm_SQL += "t01_qt_disponibile = " & RimpiazzaVirgola(Me.txtQtDisponibile.Text) & ", "
            'm_SQL += "t01_dt_modifica = GetDate() WHERE "
            'm_SQL += "t01_id_articolo = " & m_IDArticolo.ToString
            m_SQL = ""
            m_SQL += "UPDATE t20_articoli SET "
            m_SQL += "t20_cod_articolo = " & DoppioApostrofo(Me.txtCodArticolo.Text) & ", "
            m_SQL += "t20_descrizione = " & DoppioApostrofo(Me.txtDescrArticolo.Text) & ", "
            m_SQL += "t20_prezzo = " & RimpiazzaVirgola(Me.txtPrezzo.Text) & ", "
            m_SQL += "t20_lotto_riordino = " & RimpiazzaVirgola(Me.txtLottoMinimo.Text) & ", "
            m_SQL += "t20_qt_disponibile = " & RimpiazzaVirgola(Me.txtQtDisponibile.Text) & ", "
            m_SQL += "t20_is_ricambio = " & BooleanToBit(Me.chbRicambio.Checked) & ", "
            m_SQL += "t20_dt_modifica = GetDate() WHERE "
            m_SQL += "t20_id_articolo = " & m_IDArticolo.ToString

        Else    'insert

            'm_SQL = ""
            'm_SQL += "INSERT INTO t01_articoli (t01_cod_articolo, t01_descrizione, "
            'm_SQL += "t01_prezzo, t01_lotto_riordino, t01_qt_disponibile) VALUES ("
            'm_SQL += DoppioApostrofo(Me.txtCodArticolo.Text) & ", "
            'm_SQL += DoppioApostrofo(Me.txtDescrArticolo.Text) & ", "
            'm_SQL += RimpiazzaVirgola(Me.txtPrezzo.Text) & ", "
            'm_SQL += RimpiazzaVirgola(Me.txtLottoMinimo.Text) & ", "
            'm_SQL += RimpiazzaVirgola(Me.txtQtDisponibile.Text) & ")"
            m_SQL = ""
            m_SQL += "INSERT INTO t20_articoli (t20_cod_articolo, t20_descrizione, "
            m_SQL += "t20_prezzo, t20_lotto_riordino, t20_qt_disponibile, t20_is_ricambio) VALUES ("
            m_SQL += DoppioApostrofo(Me.txtCodArticolo.Text) & ", "
            m_SQL += DoppioApostrofo(Me.txtDescrArticolo.Text) & ", "
            m_SQL += RimpiazzaVirgola(Me.txtPrezzo.Text) & ", "
            m_SQL += RimpiazzaVirgola(Me.txtLottoMinimo.Text) & ", "
            m_SQL += RimpiazzaVirgola(Me.txtQtDisponibile.Text) & ", "
            m_SQL += BooleanToBit(Me.chbRicambio.Checked) & ")"

        End If

        'esegue Update o Insert
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        Call NuovoArticolo()

        'default
        Cursor.Current = Cursors.Default

        Return True

    End Function

    Private Function CodiceArticoloDoppio() As Boolean

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRControlloCodiceDoppio As SqlClient.SqlDataReader

        'Verifica se il codice articolo dell'attuale inserimento/variazione
        'esiste già. Se si tratta di variazione esclude dalla ricerca il
        'corrente IDArticolo. Se si tratta di inserimento controlla in tutto
        'l'archivio.
        'm_SQL = "SELECT * FROM t01_articoli WHERE t01_dt_cancellazione IS NULL AND "
        'm_SQL += "t01_cod_articolo = " & DoppioApostrofo(Me.txtCodArticolo.Text)
        'If m_Variazione Then
        '    m_SQL += " AND t01_id_articolo <> " & m_IDArticolo.ToString
        'End If
        m_SQL = "SELECT * FROM t20_articoli WHERE t20_dt_cancellazione IS NULL AND "
        m_SQL += "t20_cod_articolo = " & DoppioApostrofo(Me.txtCodArticolo.Text)
        If m_Variazione Then
            m_SQL += " AND t20_id_articolo <> " & m_IDArticolo.ToString
        End If

        DRControlloCodiceDoppio = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)

        'default
        Cursor.Current = Cursors.Default

        Return DRControlloCodiceDoppio.HasRows

    End Function

#End Region

    Private Sub chbRicambio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRicambio.CheckedChanged

    End Sub
End Class
