Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmAnagraficaClienti
    Inherits System.Windows.Forms.Form

    Private m_Variazione As Boolean
    Private m_IDFornitore As Integer
    Private m_Modificato As Boolean
    Private m_ChiudiDopoSalvataggio As Boolean

    'SETTARE QUESTA VARIABILE A FALSE SE SI VUOLE IMPEDIRE
    'IL SALVATAGGIO DI CODICI ARTICOLO DOPPI. ALTRIMENTI, PER
    'VISUALIZZARE CONFERMA DI SALVATAGGIO SETTARE A TRUE.
    Private m_ConsentiCodiciDoppi As Boolean = False

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
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents txtDescrFornitore As System.Windows.Forms.TextBox
    Friend WithEvents lblCodFornitore As System.Windows.Forms.Label
    Friend WithEvents txtCodFornitore As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents btnSceltaFornitore As System.Windows.Forms.Button
    Friend WithEvents btnNuovoFornitore As System.Windows.Forms.Button
    Friend WithEvents btnEliminaFornitore As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnagraficaClienti))
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.txtDescrFornitore = New System.Windows.Forms.TextBox
        Me.lblCodFornitore = New System.Windows.Forms.Label
        Me.txtCodFornitore = New System.Windows.Forms.TextBox
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.btnSalva = New System.Windows.Forms.Button
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSceltaFornitore = New System.Windows.Forms.Button
        Me.btnNuovoFornitore = New System.Windows.Forms.Button
        Me.btnEliminaFornitore = New System.Windows.Forms.Button
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
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
        'txtDescrFornitore
        '
        Me.txtDescrFornitore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrFornitore.Location = New System.Drawing.Point(112, 48)
        Me.txtDescrFornitore.MaxLength = 255
        Me.txtDescrFornitore.Multiline = True
        Me.txtDescrFornitore.Name = "txtDescrFornitore"
        Me.txtDescrFornitore.Size = New System.Drawing.Size(360, 48)
        Me.txtDescrFornitore.TabIndex = 1
        '
        'lblCodFornitore
        '
        Me.lblCodFornitore.Location = New System.Drawing.Point(8, 16)
        Me.lblCodFornitore.Name = "lblCodFornitore"
        Me.lblCodFornitore.Size = New System.Drawing.Size(100, 23)
        Me.lblCodFornitore.TabIndex = 0
        Me.lblCodFornitore.Text = "Codice Cliente :"
        '
        'txtCodFornitore
        '
        Me.txtCodFornitore.Location = New System.Drawing.Point(112, 16)
        Me.txtCodFornitore.MaxLength = 20
        Me.txtCodFornitore.Name = "txtCodFornitore"
        Me.txtCodFornitore.Size = New System.Drawing.Size(144, 20)
        Me.txtCodFornitore.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtCodFornitore, "Codice Fornitore (F9=Ricerca, F10=Nuovo)")
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Location = New System.Drawing.Point(304, 248)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 4
        Me.btnSalva.Text = "&Salva"
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
        'btnSceltaFornitore
        '
        Me.btnSceltaFornitore.Image = CType(resources.GetObject("btnSceltaFornitore.Image"), System.Drawing.Image)
        Me.btnSceltaFornitore.Location = New System.Drawing.Point(272, 8)
        Me.btnSceltaFornitore.Name = "btnSceltaFornitore"
        Me.btnSceltaFornitore.Size = New System.Drawing.Size(32, 32)
        Me.btnSceltaFornitore.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnSceltaFornitore, "Ricerca e selezione articolo")
        '
        'btnNuovoFornitore
        '
        Me.btnNuovoFornitore.Image = CType(resources.GetObject("btnNuovoFornitore.Image"), System.Drawing.Image)
        Me.btnNuovoFornitore.Location = New System.Drawing.Point(312, 8)
        Me.btnNuovoFornitore.Name = "btnNuovoFornitore"
        Me.btnNuovoFornitore.Size = New System.Drawing.Size(32, 31)
        Me.btnNuovoFornitore.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnNuovoFornitore, "Nuovo articolo")
        '
        'btnEliminaFornitore
        '
        Me.btnEliminaFornitore.Image = CType(resources.GetObject("btnEliminaFornitore.Image"), System.Drawing.Image)
        Me.btnEliminaFornitore.Location = New System.Drawing.Point(352, 8)
        Me.btnEliminaFornitore.Name = "btnEliminaFornitore"
        Me.btnEliminaFornitore.Size = New System.Drawing.Size(32, 31)
        Me.btnEliminaFornitore.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnEliminaFornitore, "Elimina articolo")
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(8, 104)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 23)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Telefono :"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(112, 104)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(72, 20)
        Me.txtTelefono.TabIndex = 2
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(112, 136)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(360, 56)
        Me.txtNote.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Note :"
        '
        'frmAnagraficaClienti
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 285)
        Me.Controls.Add(Me.btnEliminaFornitore)
        Me.Controls.Add(Me.btnNuovoFornitore)
        Me.Controls.Add(Me.btnSceltaFornitore)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCodFornitore)
        Me.Controls.Add(Me.txtDescrFornitore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.lblCodFornitore)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAnagraficaClienti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Anagrafica Clienti"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Definizione Property"

    Public Property IDFornitore() As Integer
        Get
            Return m_IDFornitore
        End Get
        Set(ByVal Value As Integer)
            m_IDFornitore = Value
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

    Private Sub frmClienti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        If m_IDFornitore > 0 Then
            Call CaricaDatiFornitore()
            Me.btnSceltaFornitore.Enabled = False
            Me.btnNuovoFornitore.Enabled = False
        Else
            Call NuovoFornitore()
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmClienti_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
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

    Private Sub txtCodFornitore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodFornitore.TextChanged
        m_Modificato = True
    End Sub

    Private Sub txtCodFornitore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodFornitore.KeyDown
        'If e.KeyValue = Keys.F9 Then
        '    Call btnSceltaFornitore_Click(txtCodFornitore, Nothing)
        'ElseIf e.KeyValue = Keys.F10 Then
        '    Call btnNuovoFornitore_Click(txtCodFornitore, Nothing)
        'End If
    End Sub

    Private Sub txtDescrFornitore_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrFornitore.TextChanged
        m_Modificato = True
    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub btnOrdina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If m_IDFornitore <> -1 Then

            If m_Modificato Then

                Dim m_OldIDFornitore As Integer
                'memorizza l'ID Fornitore
                m_OldIDFornitore = m_IDFornitore

                If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima dell'inserimento ordini?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                    If Not SalvaDati() Then
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

                'ripristina l'ID Fornitore (resettato da SalvaDati)
                m_IDFornitore = m_OldIDFornitore
                Call CaricaDatiFornitore()

            End If

        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormOrdiniFor As New frmOrdiniFor
        FormOrdiniFor.ShowDialog()

        'richiama l'fornitore per un refresh
        Call CaricaDatiFornitore()

    End Sub


    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click

        Dim blnSalvataggioOk As Boolean
        blnSalvataggioOk = SalvaDati()
        If blnSalvataggioOk And m_ChiudiDopoSalvataggio Then
            Me.Close()
        End If

    End Sub


#End Region

#Region "Sub e Function personalizzate"

    Private Sub NuovoFornitore()

        m_IDFornitore = -1
        m_Variazione = False

        Me.txtCodFornitore.Text = ""
        Me.txtDescrFornitore.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtNote.Text = ""

        Call FormattaCampiNumeri()

        m_Modificato = False

        Me.txtCodFornitore.Select()

    End Sub

    Private Sub CaricaDatiFornitore()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRFornitore As SqlClient.SqlDataReader

        m_SQL = "SELECT t14_clienti.* FROM t14_clienti WHERE t14_id_cliente = " & m_IDFornitore.ToString

        DRFornitore = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)

        If DRFornitore.HasRows Then

            DRFornitore.Read()

            If DRFornitore("t14_cod_cliente").GetType Is Type.GetType("System.DBNull") Then
                Me.txtCodFornitore.Text = ""
            Else
                Me.txtCodFornitore.Text = DRFornitore("t14_cod_cliente")
            End If

            If DRFornitore("t14_descrizione").GetType Is Type.GetType("System.DBNull") Then
                Me.txtDescrFornitore.Text = ""
            Else
                Me.txtDescrFornitore.Text = DRFornitore("t14_descrizione")
            End If

            If DRFornitore("t14_telefono").GetType Is Type.GetType("System.DBNull") Then
                Me.txtTelefono.Text = 0
            Else
                Me.txtTelefono.Text = DRFornitore("t14_telefono")
            End If

            If DRFornitore("t14_note").GetType Is Type.GetType("System.DBNull") Then
                Me.txtNote.Text = 0
            Else
                Me.txtNote.Text = DRFornitore("t14_note")
            End If

            'formattazione campi numerici
            Call FormattaCampiNumeri()

            'CONTROLLO SE IL FORNITORE E' GIA' ASSOCIATO AD UN ORDINE FORNITORE
            m_SQL = "SELECT * FROM t12_testate_ordini_cli WHERE "
            m_SQL += "t12_id_cliente_t14 = " & m_IDFornitore.ToString

            Dim DRIstanze As SqlClient.SqlDataReader
            DRIstanze = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)
            If DRIstanze.HasRows Then
                MessageBox.Show("ATTENZIONE! Il cliente che si sta richiamando appartiene ad un ordine!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else

            MessageBox.Show("Cliente non memorizzato!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    Private Sub FormattaCampiNumeri()

    End Sub

    Private Function SalvaDati() As Boolean

        Dim blnCodiceFornitoreDoppio As Boolean

        'If Me.txtCodFornitore.Text.Trim = "" Then
        '    MessageBox.Show("E' necessario indicare un codice fornitore!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return False
        'End If

        If Me.txtDescrFornitore.Text.Trim = "" Then
            MessageBox.Show("E' necessario indicare una descrizione fornitore!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        blnCodiceFornitoreDoppio = CodiceFornitoreDoppio()
        If blnCodiceFornitoreDoppio Then
            If m_ConsentiCodiciDoppi Then
                'solo messaggio di notifica e richiesta di salvataggio
                If MessageBox.Show("Codice fornitore già memorizzato! Salvare comunque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return False
                End If
            Else
                'messaggio con blocco salvataggio
                MessageBox.Show("Codice fornitore già memorizzato! Impossibile salvare!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If m_Variazione Then    'UPDATE

            m_SQL = ""
            m_SQL += "UPDATE t14_clienti SET "
            m_SQL += "t14_cod_cliente = " & DoppioApostrofo(Me.txtCodFornitore.Text) & ", "
            m_SQL += "t14_descrizione = " & DoppioApostrofo(Me.txtDescrFornitore.Text) & ", "
            m_SQL += "t14_telefono = " & DoppioApostrofo(Me.txtTelefono.Text) & ", "
            m_SQL += "t14_note = " & DoppioApostrofo(Me.txtNote.Text) & ", "
            m_SQL += "t14_dt_modifica = GetDate() WHERE "
            m_SQL += "t14_id_cliente = " & m_IDFornitore.ToString

        Else    'insert

            m_SQL = ""
            m_SQL += "INSERT INTO t14_clienti (t14_cod_cliente, t14_descrizione, "
            m_SQL += "t14_telefono, t14_note) VALUES ("
            m_SQL += DoppioApostrofo(Me.txtCodFornitore.Text) & ", "
            m_SQL += DoppioApostrofo(Me.txtDescrFornitore.Text) & ", "
            m_SQL += DoppioApostrofo(Me.txtTelefono.Text) & ", "
            m_SQL += DoppioApostrofo(Me.txtNote.Text) & ") "

        End If

        'esegue Update o Insert
        ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

        Call NuovoFornitore()

        'default
        Cursor.Current = Cursors.Default

        Return True

    End Function

    Private Function CodiceFornitoreDoppio() As Boolean

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRControlloCodiceDoppio As SqlClient.SqlDataReader

        'Verifica se il codice fornitore dell'attuale inserimento/variazione
        'esiste già. Se si tratta di variazione esclude dalla ricerca il
        'corrente IDFornitore. Se si tratta di inserimento controlla in tutto
        'l'archivio.
        m_SQL = "SELECT * FROM t14_clienti WHERE t14_dt_cancellazione IS NULL AND "
        m_SQL += "t14_cod_cliente = " & DoppioApostrofo(Me.txtCodFornitore.Text)
        If m_Variazione Then
            m_SQL += " AND t14_id_cliente <> " & m_IDFornitore.ToString
        End If

        DRControlloCodiceDoppio = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)

        'default
        Cursor.Current = Cursors.Default

        Return DRControlloCodiceDoppio.HasRows

    End Function

#End Region

    Private Sub txtTelefono_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.TextChanged
        m_Modificato = True
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        m_Modificato = True
    End Sub

    Private Sub btnSceltaFornitore_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaFornitore.Click
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormSceltaCliente As New frmSceltaCliente
        FormSceltaCliente.ShowDialog()

        If FormSceltaCliente.IDFornitore <> -1 Then

            m_IDFornitore = FormSceltaCliente.IDFornitore()
            Call CaricaDatiFornitore()

        End If
    End Sub

    Private Sub btnNuovoFornitore_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuovoFornitore.Click
        If m_Modificato Then
            If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima dell'inserimento nuovo cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                Dim blnSalvataggioOk As Boolean
                blnSalvataggioOk = SalvaDati()
            Else
                Call NuovoFornitore()
            End If
        End If
    End Sub

    Private Sub btnEliminaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaFornitore.Click

        If Not m_Variazione Then
            MessageBox.Show("Cliente in fase di inserimento! Impossibile eliminarlo!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If m_IDFornitore = -1 Then
            MessageBox.Show("Scegliere prima un cliente valido!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBox.Show("Confermi eliminazione cliente?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim DRControlloGruppi As SqlClient.SqlDataReader

            'un fornitore non è eliminabile se fa parte di un' ordine non eliminato
            m_SQL = ""
            m_SQL += "SELECT * FROM t14_clienti INNER JOIN t12_testate_ordini_cli ON "
            m_SQL += "t14_id_cliente = t12_id_cliente_t14 "
            m_SQL += "WHERE t12_dt_cancellazione IS NULL AND "
            m_SQL += "t14_dt_cancellazione IS NULL AND "
            m_SQL += "t14_id_cliente = " & m_IDFornitore.ToString

            DRControlloGruppi = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)
            If DRControlloGruppi.HasRows Then
                MessageBox.Show("Impossibile eliminare il fornitore perchè appartiene almeno ad un ordine fornitore", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            m_SQL = "UPDATE t14_clienti SET t14_dt_cancellazione = GetDate() WHERE t14_id_cliente = " & m_IDFornitore.ToString
            ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            Call NuovoFornitore()
        End If
    End Sub
End Class
