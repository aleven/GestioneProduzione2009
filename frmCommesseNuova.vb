Imports Microsoft.ApplicationBlocks.Data.SqlHelper

Public Class frmCommesseNuova
    Inherits System.Windows.Forms.Form

    Private m_IDIstanza As Integer
    Private m_Variazione As Boolean

    Private m_SQL As String
    Private m_IDMacchina As Integer
    Private m_Modificato As Boolean
    Private m_ReadOnly As Boolean

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
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents lblDescrizione As System.Windows.Forms.Label
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents cboStatoIstanza As System.Windows.Forms.ComboBox
    Friend WithEvents lblStato As System.Windows.Forms.Label
    Friend WithEvents lblDataConsegna As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerConsegna As System.Windows.Forms.DateTimePicker
    Public WithEvents conn1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents UDQuantita As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblQuantita As System.Windows.Forms.Label
    Friend WithEvents lblCodMacchina As System.Windows.Forms.Label
    Friend WithEvents lblDescrMacchina As System.Windows.Forms.Label
    Friend WithEvents txtCodMacchina As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrMacchina As System.Windows.Forms.TextBox
    Friend WithEvents btnSceltaMacchina As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents objdsStatiIstanza As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommesseNuova))
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.btnSalva = New System.Windows.Forms.Button
        Me.lblDescrizione = New System.Windows.Forms.Label
        Me.txtDescrizione = New System.Windows.Forms.TextBox
        Me.cboStatoIstanza = New System.Windows.Forms.ComboBox
        Me.objdsStatiIstanza = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.lblStato = New System.Windows.Forms.Label
        Me.lblDataConsegna = New System.Windows.Forms.Label
        Me.DateTimePickerConsegna = New System.Windows.Forms.DateTimePicker
        Me.conn1 = New System.Data.SqlClient.SqlConnection
        Me.UDQuantita = New System.Windows.Forms.NumericUpDown
        Me.lblQuantita = New System.Windows.Forms.Label
        Me.lblCodMacchina = New System.Windows.Forms.Label
        Me.lblDescrMacchina = New System.Windows.Forms.Label
        Me.txtCodMacchina = New System.Windows.Forms.TextBox
        Me.txtDescrMacchina = New System.Windows.Forms.TextBox
        Me.btnSceltaMacchina = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.objdsStatiIstanza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UDQuantita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Location = New System.Drawing.Point(424, 264)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 15
        Me.btnAnnulla.Text = "&Chiudi"
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Location = New System.Drawing.Point(336, 264)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 14
        Me.btnSalva.Text = "&Salva"
        '
        'lblDescrizione
        '
        Me.lblDescrizione.Location = New System.Drawing.Point(8, 16)
        Me.lblDescrizione.Name = "lblDescrizione"
        Me.lblDescrizione.Size = New System.Drawing.Size(128, 16)
        Me.lblDescrizione.TabIndex = 0
        Me.lblDescrizione.Text = "Commessa - Cliente :"
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizione.Location = New System.Drawing.Point(8, 32)
        Me.txtDescrizione.MaxLength = 255
        Me.txtDescrizione.Multiline = True
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(496, 32)
        Me.txtDescrizione.TabIndex = 1
        '
        'cboStatoIstanza
        '
        Me.cboStatoIstanza.DataSource = Me.objdsStatiIstanza
        Me.cboStatoIstanza.DisplayMember = "t07_stati_istanza.t07_descrizione"
        Me.cboStatoIstanza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatoIstanza.Location = New System.Drawing.Point(112, 224)
        Me.cboStatoIstanza.Name = "cboStatoIstanza"
        Me.cboStatoIstanza.Size = New System.Drawing.Size(112, 21)
        Me.cboStatoIstanza.TabIndex = 12
        Me.cboStatoIstanza.ValueMember = "t07_stati_istanza.t07_id_stato_istanza"
        '
        'objdsStatiIstanza
        '
        Me.objdsStatiIstanza.DataSetName = "dsStatiIstanza"
        Me.objdsStatiIstanza.Locale = New System.Globalization.CultureInfo("it-IT")
        Me.objdsStatiIstanza.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblStato
        '
        Me.lblStato.Location = New System.Drawing.Point(8, 224)
        Me.lblStato.Name = "lblStato"
        Me.lblStato.Size = New System.Drawing.Size(72, 16)
        Me.lblStato.TabIndex = 11
        Me.lblStato.Text = "Stato :"
        '
        'lblDataConsegna
        '
        Me.lblDataConsegna.Location = New System.Drawing.Point(8, 72)
        Me.lblDataConsegna.Name = "lblDataConsegna"
        Me.lblDataConsegna.Size = New System.Drawing.Size(96, 23)
        Me.lblDataConsegna.TabIndex = 2
        Me.lblDataConsegna.Text = "Data Consegna :"
        '
        'DateTimePickerConsegna
        '
        Me.DateTimePickerConsegna.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePickerConsegna.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerConsegna.Location = New System.Drawing.Point(112, 72)
        Me.DateTimePickerConsegna.Name = "DateTimePickerConsegna"
        Me.DateTimePickerConsegna.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePickerConsegna.TabIndex = 3
        '
        'conn1
        '
        Me.conn1.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=GestioneProduzione2009_REDA;Pers" & _
            "ist Security Info=True;User ID=sa;Password=sa2005"
        Me.conn1.FireInfoMessageEventOnUserErrors = False
        '
        'UDQuantita
        '
        Me.UDQuantita.Location = New System.Drawing.Point(112, 192)
        Me.UDQuantita.Maximum = New Decimal(New Integer() {32767, 0, 0, 0})
        Me.UDQuantita.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.UDQuantita.Name = "UDQuantita"
        Me.UDQuantita.Size = New System.Drawing.Size(112, 20)
        Me.UDQuantita.TabIndex = 10
        Me.UDQuantita.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UDQuantita.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblQuantita
        '
        Me.lblQuantita.Location = New System.Drawing.Point(8, 192)
        Me.lblQuantita.Name = "lblQuantita"
        Me.lblQuantita.Size = New System.Drawing.Size(96, 16)
        Me.lblQuantita.TabIndex = 9
        Me.lblQuantita.Text = "Q.tà Da Produrre :"
        '
        'lblCodMacchina
        '
        Me.lblCodMacchina.Location = New System.Drawing.Point(8, 104)
        Me.lblCodMacchina.Name = "lblCodMacchina"
        Me.lblCodMacchina.Size = New System.Drawing.Size(100, 23)
        Me.lblCodMacchina.TabIndex = 4
        Me.lblCodMacchina.Text = "Codice Macchina :"
        '
        'lblDescrMacchina
        '
        Me.lblDescrMacchina.Location = New System.Drawing.Point(8, 136)
        Me.lblDescrMacchina.Name = "lblDescrMacchina"
        Me.lblDescrMacchina.Size = New System.Drawing.Size(100, 32)
        Me.lblDescrMacchina.TabIndex = 7
        Me.lblDescrMacchina.Text = "Descrizione Macchina :"
        '
        'txtCodMacchina
        '
        Me.txtCodMacchina.Location = New System.Drawing.Point(112, 104)
        Me.txtCodMacchina.Name = "txtCodMacchina"
        Me.txtCodMacchina.ReadOnly = True
        Me.txtCodMacchina.Size = New System.Drawing.Size(216, 20)
        Me.txtCodMacchina.TabIndex = 5
        Me.txtCodMacchina.TabStop = False
        '
        'txtDescrMacchina
        '
        Me.txtDescrMacchina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrMacchina.Location = New System.Drawing.Point(112, 136)
        Me.txtDescrMacchina.MaxLength = 255
        Me.txtDescrMacchina.Multiline = True
        Me.txtDescrMacchina.Name = "txtDescrMacchina"
        Me.txtDescrMacchina.ReadOnly = True
        Me.txtDescrMacchina.Size = New System.Drawing.Size(392, 48)
        Me.txtDescrMacchina.TabIndex = 8
        Me.txtDescrMacchina.TabStop = False
        '
        'btnSceltaMacchina
        '
        Me.btnSceltaMacchina.Image = CType(resources.GetObject("btnSceltaMacchina.Image"), System.Drawing.Image)
        Me.btnSceltaMacchina.Location = New System.Drawing.Point(344, 96)
        Me.btnSceltaMacchina.Name = "btnSceltaMacchina"
        Me.btnSceltaMacchina.Size = New System.Drawing.Size(32, 31)
        Me.btnSceltaMacchina.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnSceltaMacchina, "Ricerca e selezione macchina")
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "t07_stati_istanza", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("t07_id_stato_istanza", "t07_id_stato_istanza"), New System.Data.Common.DataColumnMapping("t07_descrizione", "t07_descrizione")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.conn1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@t07_id_stato_istanza", System.Data.SqlDbType.VarChar, 1, "t07_id_stato_istanza"), New System.Data.SqlClient.SqlParameter("@t07_descrizione", System.Data.SqlDbType.VarChar, 64, "t07_descrizione")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT t07_id_stato_istanza, t07_descrizione FROM t07_stati_istanza WHERE (t07_dt" & _
            "_cancellazione IS NULL) ORDER BY t07_posizione"
        Me.SqlSelectCommand1.Connection = Me.conn1
        '
        'frmCommesseNuova
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 302)
        Me.Controls.Add(Me.btnSceltaMacchina)
        Me.Controls.Add(Me.txtDescrMacchina)
        Me.Controls.Add(Me.txtCodMacchina)
        Me.Controls.Add(Me.lblDescrMacchina)
        Me.Controls.Add(Me.lblCodMacchina)
        Me.Controls.Add(Me.lblQuantita)
        Me.Controls.Add(Me.UDQuantita)
        Me.Controls.Add(Me.DateTimePickerConsegna)
        Me.Controls.Add(Me.lblDataConsegna)
        Me.Controls.Add(Me.lblStato)
        Me.Controls.Add(Me.cboStatoIstanza)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.lblDescrizione)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommesseNuova"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commessa"
        CType(Me.objdsStatiIstanza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UDQuantita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Variazione() As Boolean
        Get
            Return m_Variazione
        End Get
        Set(ByVal Value As Boolean)
            m_Variazione = Value
        End Set
    End Property

    Public Property IDIstanza() As Integer
        Get
            Return m_IDIstanza
        End Get
        Set(ByVal Value As Integer)
            m_IDIstanza = Value
        End Set
    End Property

    Private Sub NuovaIstanza()
        m_IDIstanza = -1
        m_Variazione = False
        m_IDMacchina = -1

        Me.txtDescrizione.Text = ""
        Me.DateTimePickerConsegna.Value = Date.Today
        Me.txtCodMacchina.Text = ""
        Me.txtDescrMacchina.Text = ""
        Me.UDQuantita.Value = 1
        Me.cboStatoIstanza.SelectedIndex = 0    'IN PRODUZIONE

        m_Modificato = False
    End Sub

    Private Sub CaricaIstanza()

        Dim drIstanza As SqlClient.SqlDataReader

        m_SQL = "SELECT * FROM t06_istanze_macchine INNER JOIN t05_macchine "
        m_SQL = m_SQL & "ON t06_id_macchina_t05 = t05_id_macchina INNER JOIN "
        m_SQL = m_SQL & "t07_stati_istanza ON t06_id_stato_istanza_t07 = t07_id_stato_istanza "
        m_SQL = m_SQL & "WHERE t06_id_istanza_macchina = " & m_IDIstanza.ToString

        drIstanza = ExecuteReader(conn1.ConnectionString, CommandType.Text, m_SQL)

        If Not drIstanza.HasRows Then

            MessageBox.Show("Impossibile trovare la commessa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            Exit Sub

        Else

            drIstanza.Read()

            If drIstanza("t06_descrizione").GetType Is Type.GetType("System.DBNull") Then
                Me.txtDescrizione.Text = ""
            Else
                Me.txtDescrizione.Text = drIstanza("t06_descrizione")
            End If

            If drIstanza("t06_dt_consegna").GetType Is Type.GetType("System.DBNull") Then
                MessageBox.Show("La data di consegna verrà imposta a oggi, perchè non indicata!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DateTimePickerConsegna.Value = Date.Today
            Else
                Me.DateTimePickerConsegna.Value = drIstanza("t06_dt_consegna")
            End If

            If drIstanza("t05_cod_macchina").GetType Is Type.GetType("System.DBNull") Then
                Me.txtCodMacchina.Text = ""
            Else
                Me.txtCodMacchina.Text = drIstanza("t05_cod_macchina")
            End If

            If drIstanza("t05_descrizione").GetType Is Type.GetType("System.DBNull") Then
                Me.txtDescrMacchina.Text = ""
            Else
                Me.txtDescrMacchina.Text = drIstanza("t05_descrizione")
            End If

            If drIstanza("t06_quantita").GetType Is Type.GetType("System.DBNull") Then
                Me.UDQuantita.Value = 1
            Else
                Me.UDQuantita.Value = drIstanza("t06_quantita")
            End If

            If drIstanza("t06_id_stato_istanza_t07").GetType Is Type.GetType("System.DBNull") Then
                Me.UDQuantita.Value = "P"
            Else
                Me.cboStatoIstanza.SelectedValue = drIstanza("t06_id_stato_istanza_t07")
            End If

            m_IDMacchina = drIstanza("t06_id_macchina_t05")

        End If

        m_Modificato = False

        'Se l'istanza risulta chiusa non è possibile fare alcun tipo
        'di operazione!
        If Me.cboStatoIstanza.SelectedValue = "C" Then

            Me.txtDescrizione.Enabled = False
            Me.txtCodMacchina.Enabled = False
            Me.txtDescrMacchina.Enabled = False
            Me.DateTimePickerConsegna.Enabled = False
            Me.btnSceltaMacchina.Enabled = False
            Me.UDQuantita.Enabled = False
            Me.cboStatoIstanza.Enabled = False
            Me.btnSalva.Enabled = False
            MessageBox.Show("La commessa risulta chiusa perciò non è possibile apportare modifiche!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            m_ReadOnly = True

        End If

    End Sub

    Private Sub frmIstanze_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conn1.ConnectionString = frmMain.ConnectionString

        'se non siamo in variazione (quindi in inserimento) i soli stati istanza disponibili
        'sono In Produzione e Sospesa

        If Not m_Variazione Then
            m_SQL = "SELECT t07_id_stato_istanza, t07_descrizione FROM t07_stati_istanza "
            m_SQL += "WHERE (t07_dt_cancellazione IS NULL) AND (t07_id_stato_istanza = 'P' OR t07_id_stato_istanza = 'S' OR "
            m_SQL += "t07_id_stato_istanza = 'C') ORDER BY t07_posizione"
            Me.SqlSelectCommand1.CommandText = m_SQL
        End If

        SqlDataAdapter1.Fill(objdsStatiIstanza)
        If m_Variazione Then
            'In variazione lo stato non è modificabile da qui.
            'Modificabile solo nell'elenco istanze.
            Me.cboStatoIstanza.Enabled = False
            Call CaricaIstanza()
        Else
            Call NuovaIstanza()
        End If

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Dim blnSalvataggioOk As Boolean
        blnSalvataggioOk = SalvaDati()
        If blnSalvataggioOk And m_Variazione Then
            Me.Close()
        End If
    End Sub

    Private Function DateISO(ByVal DateDB As Date) As String
        'Funzione che ritorna una stringa che rappresenta la data in formato ISO (inclusi gli apici)
        Return "'" & DateDB.ToString("yyyyMMdd") & "'"
    End Function

    Private Function SalvaDati() As Boolean

        'CONTROLLI PRIMA DEL SALVATAGGIO
        If Me.txtDescrizione.Text = "" Then
            MessageBox.Show("E' necessario indicare una descrizione per la commessa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If m_IDMacchina = -1 Then
            MessageBox.Show("E' necessario scegliere la macchina per memorizzare la commessa!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        If UDQuantita.Value <= 0 Then
            MessageBox.Show("E' necessario indicare una quantità maggiore di 0!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        'Clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not m_Variazione Then

            m_SQL = "INSERT INTO t06_istanze_macchine (t06_descrizione, t06_dt_consegna, "
            m_SQL = m_SQL & "t06_id_macchina_t05, t06_quantita, t06_id_stato_istanza_t07) VALUES ("
            m_SQL = m_SQL & "'" & DoppioApostrofo(Me.txtDescrizione.Text) & "', " & DateISO(Me.DateTimePickerConsegna.Value) & ", "
            m_SQL = m_SQL & m_IDMacchina.ToString & ", " & UDQuantita.Value.ToString & ", "
            m_SQL = m_SQL & "'" & cboStatoIstanza.SelectedValue & "')"

            'EFFETTUA L'INSERIMENTO
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            Call NuovaIstanza()

        Else

            m_SQL = "UPDATE t06_istanze_macchine SET "
            m_SQL = m_SQL & "t06_descrizione = '" & DoppioApostrofo(Me.txtDescrizione.Text) & "', "
            m_SQL = m_SQL & "t06_dt_consegna = " & DateISO(Me.DateTimePickerConsegna.Value) & ", "
            m_SQL = m_SQL & "t06_id_macchina_t05 = " & m_IDMacchina.ToString & ", "
            m_SQL = m_SQL & "t06_quantita = " & UDQuantita.Value.ToString & ", "
            m_SQL = m_SQL & "t06_id_stato_istanza_t07 = '" & cboStatoIstanza.SelectedValue & "', "
            m_SQL = m_SQL & "t06_dt_modifica = GetDate() WHERE "
            m_SQL = m_SQL & "t06_id_istanza_macchina = " & m_IDIstanza.ToString

            'EFFETTUA L'UPDATE
            Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteNonQuery(conn1.ConnectionString, CommandType.Text, m_SQL)

            m_Modificato = False

        End If

        Me.txtDescrizione.Select()

        'Default
        Cursor.Current = Cursors.Default

        Return True

    End Function

    Private Function DoppioApostrofo(ByVal strDaMemorizzare As String) As String
        Return Replace(strDaMemorizzare, "'", "''")
    End Function

    Private Sub btnSceltaMacchina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSceltaMacchina.Click

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormSceltaMacchina As New frmSceltaMacchina
        FormSceltaMacchina.ShowDialog()

        If FormSceltaMacchina.IDMacchina <> -1 Then

            m_IDMacchina = FormSceltaMacchina.IDMacchina()
            Me.txtCodMacchina.Text = FormSceltaMacchina.CodMacchina
            Me.txtDescrMacchina.Text = FormSceltaMacchina.DescrizioneMacchina
            m_Modificato = True

        End If

    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.Close()
    End Sub

    Private Sub txtDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.TextChanged
        m_Modificato = True
    End Sub

    Private Sub DateTimePickerConsegna_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerConsegna.ValueChanged
        m_Modificato = True
    End Sub

    Private Sub UDQuantita_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UDQuantita.ValueChanged
        m_Modificato = True
    End Sub

    Private Sub cboStatoIstanza_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStatoIstanza.SelectedIndexChanged
        m_Modificato = True
    End Sub

    Private Sub frmIstanze_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        'se a sola lettura non si preoccupa del controllo modifiche
        If m_ReadOnly Then Exit Sub

        'Solo se ci sono state modifiche viene chiesto la conferma di salvataggio
        If m_Modificato Then
            If DialogResult.Yes = MessageBox.Show("Salvare le modifiche apportate prima della chiusura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) Then
                If Not SalvaDati() Then
                    e.Cancel = True
                End If
            End If
        End If

    End Sub

    Private Sub lblDescrizione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescrizione.Click

    End Sub
End Class
