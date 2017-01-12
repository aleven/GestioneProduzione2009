Imports VS2005Commons

Public Class frmOffertaElenco

    Private Const VIEW_OPEN As String = "Mostra solo Offerte Aperte"
    Private Const VIEW_CLOSE As String = "Mostra solo Offerte Confermate"
    Private Const VIEW_ALL As String = "Mostra tutte le Offerte"

    Private datiCaricati As Boolean = False

    Private _modoSelezione As Boolean = False
    Private _idSelezionato As Integer = -1

    Public Property ModoSelezione() As Boolean
        Get
            Return _modoSelezione
        End Get
        Set(ByVal Value As Boolean)
            _modoSelezione = Value
        End Set
    End Property

    Public Property IdSelezionato() As Integer
        Get
            Return _idSelezionato
        End Get
        Set(ByVal Value As Integer)
            _idSelezionato = Value
        End Set
    End Property

    Private Sub frmOrdiniCli2Elenco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        CaricaDatiAccessori()
        CaricaDati()

        If ModoSelezione Then
            cmbFiltroVista.Enabled = False
        End If

        DataGridHelper.Configure(Me.DataGridView1)
    End Sub

    Private Sub CaricaDatiAccessori()

        ' Carico gli stati possibili
        cmbFiltroVista.Items.Add(VIEW_OPEN)
        cmbFiltroVista.Items.Add(VIEW_CLOSE)
        cmbFiltroVista.Items.Add(VIEW_ALL)
        cmbFiltroVista.SelectedIndex = 0

        ' Carico gli anni in distinct dagli ordini
        Me.cmbFiltroAnno.DataSource = Me.T28_anni.GetDataOfferta()
        Me.cmbFiltroAnno.ValueMember = "Anni"
        Me.cmbFiltroAnno.DisplayMember = "Anni"
        Try
            Me.cmbFiltroAnno.SelectedValue = Date.Now.Year
        Catch

        End Try

        ' Carico gli utenti
        Me.cmbUtente.DataSource = frmMain.Utenti
        Me.cmbUtente.ValueMember = "nome"
        Me.cmbUtente.DisplayMember = "nome"
        Try
            Me.cmbUtente.SelectedValue = frmMain.Profilo.nome
        Catch

        End Try

    End Sub

    Private Sub CaricaDati()

        datiCaricati = False

        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t28_testate_ordini_cli' table. You can move, or remove it, as needed.
        Me.T28_testate_ordini_cliTableAdapter.FillOfferta(Me.GestioneProduzione2009DataSet.t28_testate_ordini_cli)

        datiCaricati = True

        FiltraDati()
    End Sub

    Private Sub FiltraDati()
        Dim strFiltro As System.Text.StringBuilder
        strFiltro = New System.Text.StringBuilder()

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If (datiCaricati) Then

            strFiltro.Append("TRUE")

            If (cmbFiltroVista.SelectedItem = VIEW_OPEN) Then
                strFiltro.Append(" AND t28_offerta_stato = 'A'")
            ElseIf cmbFiltroVista.SelectedItem = VIEW_CLOSE Then
                strFiltro.Append(" AND t28_offerta_stato = 'C'")
            Else

            End If
            'If chbFiltroAperti.Checked Then
            '    strFiltro.Append("t08_stato_testata_ordine_for = 'APERTO'")
            'End If
            'If chkEvasi.Checked Then
            '    If strFiltro.Trim <> "" Then
            '        strFiltro = strFiltro & " OR "
            '    End If
            '    strFiltro = "(" & strFiltro & "t08_stato_testata_ordine_for = 'EVASO'" & ")"
            'End If

            ''Se il filtro è nullo significa che non c'è nessun spunto!
            ''Perciò viene impostato un filtro "IMPOSSIBILE" fittizio al
            ''fine di non visualizzare nessun dato sul datagrid
            'If strFiltro.Trim = "" Then
            '    strFiltro = "t08_stato_testata_ordine_for = '@@@@@@'"
            'End If

            'If CliccatoSuFiltri Then
            '    If cmbCausale.SelectedIndex <> -1 Then
            '        Dim rowView As DataRowView = CType(cmbCausale.SelectedItem, DataRowView)
            '        Dim value As String = CType(rowView.Row(cmbCausale.ValueMember), String)
            '        If strFiltro.Trim <> "" Then
            '            strFiltro = strFiltro & " AND "
            '        End If
            '        strFiltro = strFiltro & " t08_id_causale_ordine_for_t15 = '" + value + "'"
            '    End If

            '    If cmbAnno.SelectedIndex <> -1 Then
            '        Dim rowView As DataRowView = CType(cmbAnno.SelectedItem, DataRowView)
            '        Dim value As String = CType(rowView.Row(cmbAnno.ValueMember), String)
            '        If strFiltro.Trim <> "" Then
            '            strFiltro = strFiltro & " AND "
            '        End If
            '        strFiltro = strFiltro & " ANNO = " + value
            '    End If
            'End If

            If (Not LangUtils.isEmpty(cmbFiltroAnno.SelectedValue)) Then
                'strFiltro.Append(" AND YEAR(t28_commessa_del) = " & cmbFiltroAnno.SelectedValue)
                Dim annoSelezionato As Integer = cmbFiltroAnno.SelectedValue
                strFiltro.Append(String.Format(" AND (t28_offerta_del >= #{0:yyyy-MM-dd}# AND t28_offerta_del <= #{1:yyyy-MM-dd}#)", VS2005Commons.DateUtils.getYearStart(annoSelezionato), VS2005Commons.DateUtils.getYearEnd(annoSelezionato)))
            End If

            If StringUtils.isNotEmpty(txtSemeRicerca.Text) Then
                Dim seme As String = QueryUtils.encodeString(txtSemeRicerca.Text)
                strFiltro.Append(" AND (")
                strFiltro.Append(" " & QueryUtils.likeCondition2(T28commessaDataGridViewTextBoxColumn.DataPropertyName, seme))
                strFiltro.Append(" OR " & QueryUtils.likeCondition2(T28descrizioneDataGridViewTextBoxColumn.DataPropertyName, seme))
                strFiltro.Append(" OR " & QueryUtils.likeCondition2(T28clienteDataGridViewTextBoxColumn.DataPropertyName, seme))
                strFiltro.Append(" OR " & QueryUtils.likeCondition2(colonnaOffertaClienteCodice.DataPropertyName, seme))

                strFiltro.Append(" OR " & QueryUtils.likeCondition2(T28noteDataGridViewTextBoxColumn.DataPropertyName, seme))
                'strFiltro.Append(" OR " & QueryUtils.likeCondition(T28rifddtDataGridViewTextBoxColumn.DataPropertyName, seme))
                'strFiltro.Append(" OR " & QueryUtils.likeCondition(T28riffattDataGridViewTextBoxColumn.DataPropertyName, seme))
                strFiltro.Append(" OR " & QueryUtils.likeCondition2(ColonnaCommessa.DataPropertyName, seme))
                'strFiltro.Append(" OR " & QueryUtils.likeCondition(T28rifordineDataGridViewTextBoxColumn.DataPropertyName, seme))
                strFiltro.Append(" )")
            End If

            If StringUtils.isNotEmpty(cmbCausale.Text) Then
                strFiltro.Append(" AND (")
                strFiltro.Append(" " & QueryUtils.equalCondition(t28_causaleColumn.DataPropertyName, cmbCausale.Text))
                strFiltro.Append(" )")
            End If

            If StringUtils.isNotEmpty(cmbUtente.Text) Then
                strFiltro.Append(" AND (")
                strFiltro.Append(" " & QueryUtils.equalCondition(utenteCreazioneColumns.DataPropertyName, cmbUtente.Text))
                strFiltro.Append(" )")
            End If


            'dvviewTestateOrdiniConStato.RowFilter = strFiltro
            Me.T28_testate_ordini_cliBindingSource.Filter = strFiltro.ToString()

        End If

        'default
        Cursor.Current = Cursors.Default

    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick

        Dim id As Integer
        id = DataGridHelper.IDSelezionato(Me.DataGridView1, T28idDataGridViewTextBoxColumn.Index)

        If id > 0 Then
            If ModoSelezione Then
                IdSelezionato = id
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Dim frmOfferta As New frmOffertaNuova
                frmOfferta.IDOrdine = id
                frmOfferta.FormChiamante = Me
                frmOfferta.MdiParent = Me.MdiParent
                frmOfferta.Show()
                'Me.DataGridView1.Refresh()
                CaricaDati()
            End If
        End If
    End Sub

    Private Sub cmbFiltroVista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltroVista.SelectedIndexChanged
        FiltraDati()
    End Sub

    Private Sub cmbFiltroAnno_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFiltroAnno.SelectedIndexChanged
        FiltraDati()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtSemeRicerca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSemeRicerca.TextChanged
        FiltraDati()
    End Sub

    Private Sub btnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiorna.Click
        CaricaDati()
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        If Not ModoSelezione Then
            Me.Close()
        End If
    End Sub


    Private Sub cmbCausale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCausale.SelectedIndexChanged
        FiltraDati()
    End Sub

    Sub CallRefresh() Implements IFormRefreshable.CallRefresh
        CaricaDati()
    End Sub

    Private Sub cmbUtente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUtente.SelectedIndexChanged
        FiltraDati()
    End Sub
End Class