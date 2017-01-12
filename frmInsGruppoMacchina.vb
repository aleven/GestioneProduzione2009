Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmInsGruppoMacchina

    Inherits System.Windows.Forms.Form

    Public Enum TAnagrafica As Short
        Gruppo = 0
        Macchina = 1
    End Enum

    Public Enum TInserimento As Short
        Nuovo = 0
        Variazione = 1
    End Enum

    Private m_TipoAnagrafica As TAnagrafica = TAnagrafica.Gruppo
    Private m_TipoInserimento As TInserimento = TInserimento.Nuovo
    Private m_ID As Integer
    Private m_Codice As String
    Private m_Descrizione As String
    Private m_SQL As String
    Private m_ConnectionString As String
    Private m_Modificato As Boolean
    Private m_FormLoaded As Boolean

    'SETTARE QUESTA VARIABILE A FALSE SE SI VUOLE IMPEDIRE
    'IL SALVATAGGIO DI CODICI GRUPPI/MACCHINE DOPPI. ALTRIMENTI, PER
    'VISUALIZZARE CONFERMA DI SALVATAGGIO SETTARE A TRUE.
    Private m_ConsentiCodiciDoppi As Boolean = False

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
    Friend WithEvents txtCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents lblCodice As System.Windows.Forms.Label
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInsGruppoMacchina))
        Me.txtCodice = New System.Windows.Forms.TextBox
        Me.txtDescrizione = New System.Windows.Forms.TextBox
        Me.lblCodice = New System.Windows.Forms.Label
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.btnSalva = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtCodice
        '
        Me.txtCodice.Location = New System.Drawing.Point(88, 16)
        Me.txtCodice.MaxLength = 20
        Me.txtCodice.Name = "txtCodice"
        Me.txtCodice.Size = New System.Drawing.Size(216, 20)
        Me.txtCodice.TabIndex = 1
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizione.Location = New System.Drawing.Point(88, 40)
        Me.txtDescrizione.MaxLength = 255
        Me.txtDescrizione.Multiline = True
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(388, 48)
        Me.txtDescrizione.TabIndex = 3
        '
        'lblCodice
        '
        Me.lblCodice.Location = New System.Drawing.Point(8, 16)
        Me.lblCodice.Name = "lblCodice"
        Me.lblCodice.Size = New System.Drawing.Size(72, 23)
        Me.lblCodice.TabIndex = 0
        Me.lblCodice.Text = "Codice :"
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 40)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(72, 23)
        Me.lblDescrizione.TabIndex = 2
        Me.lblDescrizione.Text = "Descrizione :"
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(376, 96)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 5
        Me.btnChiudi.Text = "&Chiudi"
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalva.Location = New System.Drawing.Point(272, 96)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(96, 32)
        Me.btnSalva.TabIndex = 4
        Me.btnSalva.Text = "&Salva"
        '
        'frmInsGruppoMacchina
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(488, 134)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Controls.Add(Me.lblCodice)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.txtCodice)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInsGruppoMacchina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserimento Gruppo/Macchina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property TipoAnagrafica() As TAnagrafica
        Get
            Return m_TipoAnagrafica
        End Get
        Set(ByVal Value As TAnagrafica)
            m_TipoAnagrafica = Value
        End Set
    End Property

    Public Property TipoInserimento() As TInserimento
        Get
            Return m_TipoInserimento
        End Get
        Set(ByVal Value As TInserimento)
            m_TipoInserimento = Value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return m_ID
        End Get
        Set(ByVal Value As Integer)
            m_ID = Value
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

    Public Property ConnectionString() As String
        Get
            Return m_ConnectionString
        End Get
        Set(ByVal Value As String)
            m_ConnectionString = Value
        End Set
    End Property

    Private Sub frmInsGruppoMacchina_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strCaption As String = ""

        Select Case m_TipoAnagrafica

            Case TAnagrafica.Gruppo
                Select Case m_TipoInserimento
                    Case TInserimento.Nuovo
                        strCaption = "Inserimento Nuovo Gruppo"
                    Case TInserimento.Variazione
                        strCaption = "Variazione Gruppo"
                End Select

            Case TAnagrafica.Macchina
                Select Case m_TipoInserimento
                    Case TInserimento.Nuovo
                        strCaption = "Inserimento Nuova Macchina"
                    Case TInserimento.Variazione
                        strCaption = "Variazione Macchina"
                End Select

        End Select

        'assegna la caption del form
        Me.Text = strCaption

        'se si tratta di variazione vengono ricavati codice e descrizione
        If m_TipoInserimento = TInserimento.Variazione Then

            Select Case m_TipoAnagrafica
                Case TAnagrafica.Gruppo
                    m_SQL = "SELECT * FROM v03_gruppi WHERE t20_id_articolo = " & m_ID.ToString 'SELECT * FROM t03_gruppi WHERE t03_id_gruppo = 
                Case TAnagrafica.Macchina
                    m_SQL = "SELECT * FROM t05_macchine WHERE t05_id_macchina = " & m_ID.ToString
            End Select

            Dim dr As System.Data.SqlClient.SqlDataReader = ExecuteReader(m_ConnectionString, CommandType.Text, m_SQL)

            'se non viene trovata la corrispondenza per quell'ID disabilita i controlli del form
            'dopo aver avvisato l'utente
            If Not dr.HasRows Then

                Dim strMsg As String

                If m_TipoAnagrafica = TAnagrafica.Gruppo Then
                    strMsg = "Gruppo non memorizzato!"
                ElseIf m_TipoAnagrafica = TAnagrafica.Macchina Then
                    strMsg = "Macchina non memorizzata"
                End If

                MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Me.txtCodice.Enabled = False
                Me.txtDescrizione.Enabled = False
                Me.btnSalva.Enabled = False
                Me.Close()
                Exit Sub

            Else

                dr.Read()

                If m_TipoAnagrafica = TAnagrafica.Gruppo Then
                    m_Codice = dr("t20_cod_articolo") 't03_cod_gruppo
                    m_Descrizione = dr("t20_descrizione") 't03_descrizione
                ElseIf m_TipoAnagrafica = TAnagrafica.Macchina Then
                    m_Codice = dr("t05_cod_macchina")
                    m_Descrizione = dr("t05_descrizione")
                End If

                Me.txtCodice.Text = m_Codice
                Me.txtDescrizione.Text = m_Descrizione

            End If

        End If

        'Form caricato e valori assegnati
        m_FormLoaded = True

    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        If SalvaDati() Then
            Me.Close()
        End If
    End Sub

    Private Function SalvaDati() As Boolean

        Dim blnCodiceDoppio As Boolean

        'L'ID è già valorizzato correttamente se si tratta di variazione
        m_Codice = Me.txtCodice.Text
        m_Descrizione = Me.txtDescrizione.Text

        'se il codice o la descrizione sono nulli è impossibile salvare
        If m_Codice.Trim = "" Or m_Descrizione.Trim = "" Then
            MessageBox.Show("ATTENZIONE! Codice e descrizione devono essere valorizzati!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        blnCodiceDoppio = CodiceDoppio()
        If blnCodiceDoppio Then
            If m_ConsentiCodiciDoppi Then
                'solo messaggio di notifica e richiesta di salvataggio
                If MessageBox.Show("Codice già memorizzato! Salvare comunque?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Return False
                End If
            Else
                'messaggio con blocco salvataggio
                MessageBox.Show("Codice già memorizzato! Impossibile salvare!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Select Case m_TipoInserimento

            Case TInserimento.Nuovo
                Select Case m_TipoAnagrafica
                    Case TAnagrafica.Gruppo
                        m_SQL = "INSERT INTO t20_articoli (t20_cod_articolo, t20_descrizione, t20_is_gruppo) VALUES (" 'INSERT INTO t03_gruppi (t03_cod_gruppo, t03_descrizione) VALUES (
                        m_SQL = m_SQL & DoppioApostrofo(m_Codice) & ", " & DoppioApostrofo(m_Descrizione) & ", 1)"
                    Case TAnagrafica.Macchina
                        m_SQL = "INSERT INTO t05_macchine (t05_cod_macchina, t05_descrizione) VALUES ("
                        m_SQL = m_SQL & DoppioApostrofo(m_Codice) & ", " & DoppioApostrofo(m_Descrizione) & ")"
                End Select

            Case TInserimento.Variazione
                Select Case m_TipoAnagrafica
                    Case TAnagrafica.Gruppo
                        'm_SQL = "UPDATE t03_gruppi SET "
                        'm_SQL = m_SQL & "t03_cod_gruppo = " & DoppioApostrofo(m_Codice) & ", "
                        'm_SQL = m_SQL & "t03_descrizione = " & DoppioApostrofo(m_Descrizione) & ", "
                        'm_SQL = m_SQL & "t03_dt_modifica = GetDate() "
                        'm_SQL = m_SQL & "WHERE "
                        'm_SQL = m_SQL & "t03_id_gruppo = " & m_ID.ToString
                        m_SQL = "UPDATE t20_articoli SET "
                        m_SQL = m_SQL & "t20_cod_articolo = " & DoppioApostrofo(m_Codice) & ", "
                        m_SQL = m_SQL & "t20_descrizione = " & DoppioApostrofo(m_Descrizione) & ", "
                        m_SQL = m_SQL & "t20_dt_modifica = GetDate() "
                        m_SQL = m_SQL & "WHERE "
                        m_SQL = m_SQL & "t20_id_articolo = " & m_ID.ToString
                    Case TAnagrafica.Macchina
                        m_SQL = "UPDATE t05_macchine SET "
                        m_SQL = m_SQL & "t05_cod_macchina = " & DoppioApostrofo(m_Codice) & ", "
                        m_SQL = m_SQL & "t05_descrizione = " & DoppioApostrofo(m_Descrizione) & ", "
                        m_SQL = m_SQL & "t05_dt_modifica = GetDate() "
                        m_SQL = m_SQL & "WHERE "
                        m_SQL = m_SQL & "t05_id_macchina = " & m_ID.ToString
                End Select

        End Select

        Try
            'Esegue query di INSERT o UPDATE
            ExecuteNonQuery(m_ConnectionString, CommandType.Text, m_SQL)
        Catch ex As Exception
            'default
            Cursor.Current = Cursors.Default
            MessageBox.Show("Si è verificato il seguente errore durante il salvataggio:" & vbCrLf & vbCrLf & ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End Try

        'default
        Cursor.Current = Cursors.Default

        m_Modificato = False

        Return True

    End Function

    Private Function CodiceDoppio() As Boolean

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim DRControlloCodiceDoppio As SqlClient.SqlDataReader

        'Verifica se il codice articolo dell'attuale inserimento/variazione
        'esiste già. Se si tratta di variazione esclude dalla ricerca il
        'corrente ID. Se si tratta di inserimento controlla in tutto
        'l'archivio.
        If m_TipoAnagrafica = TAnagrafica.Gruppo Then

            'm_SQL = "SELECT * FROM t03_gruppi WHERE t03_dt_cancellazione IS NULL AND "
            'm_SQL += "t03_cod_gruppo = " & DoppioApostrofo(Me.txtCodice.Text)
            'If m_TipoInserimento = TInserimento.Variazione Then
            '    m_SQL += " AND t03_id_gruppo <> " & m_ID.ToString
            'End If
            m_SQL = "SELECT * FROM t20_articoli WHERE t20_dt_cancellazione IS NULL AND "
            m_SQL += "t20_cod_articolo = " & DoppioApostrofo(Me.txtCodice.Text)
            If m_TipoInserimento = TInserimento.Variazione Then
                m_SQL += " AND t20_id_articolo <> " & m_ID.ToString
            End If
        Else    'Macchine

            m_SQL = "SELECT * FROM t05_macchine WHERE t05_dt_cancellazione IS NULL AND "
            m_SQL += "t05_cod_macchina = " & DoppioApostrofo(Me.txtCodice.Text)
            If m_TipoInserimento = TInserimento.Variazione Then
                m_SQL += " AND t05_id_macchina <> " & m_ID.ToString
            End If

        End If

        DRControlloCodiceDoppio = ExecuteReader(m_ConnectionString, CommandType.Text, m_SQL)

        'default
        Cursor.Current = Cursors.Default

        Return DRControlloCodiceDoppio.HasRows

    End Function

    Private Function DoppioApostrofo(ByVal strDaMemorizzare As String) As String
        Return "'" & Replace(strDaMemorizzare, "'", "''") & "'"
    End Function

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub

    Private Sub txtCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodice.TextChanged
        If Not m_FormLoaded Then Exit Sub
        m_Modificato = True
    End Sub

    Private Sub txtDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.TextChanged
        If Not m_FormLoaded Then Exit Sub
        m_Modificato = True
    End Sub

    Private Sub frmInsGruppoMacchina_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'Solo se ci sono state modifiche viene chiesto la conferma di salvataggio
        If m_Modificato Then
            If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima della chiusura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                If Not SalvaDati() Then
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

End Class
