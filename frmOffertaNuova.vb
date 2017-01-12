Imports VS2005Commons
Imports GestioneProduzione2014GinuxImport
Imports GestioneProduzione2014Data
Imports GestioneProduzione2014OfficeExport
Imports System.IO

Public Class frmOffertaNuova

    'Public Shared STATO_APERTO As String = "A"
    'Public Shared STATO_CHIUSO As String = "C"
    'Public Shared STATO_EVASO As String = "E"

    'Private _idOrdine As Integer
    'Private ricambioSelezionato As GestioneProduzione2009DataSet.ListinoRicambiRow
    'Private rigaSelezionata As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow
    ''Serve a capire se sto aggiungendo un ricambio o una riga semplice
    'Private aggiuntoDaAdd As Boolean = False
    'Private datiCaricatiFiltroOrdinamento As Boolean = False

    'Private elementoModificato As Boolean = False

    'Public Property IDOrdine() As Integer
    '    Get
    '        Return _idOrdine
    '    End Get
    '    Set(ByVal Value As Integer)
    '        _idOrdine = Value
    '    End Set
    'End Property

    Private Sub frmOrdiniCli2Nuovo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        CaricaDati()
        FiltraDati()
        OrdinaDati()

        'AggiornaPosizioniETotale()

        SplitContainer1.SplitterDistance = SplitContainer1.Size.Width / 3

    End Sub

    Private Sub CaricaDati()
        datiCaricatiFiltroOrdinamento = False

        btnCommessa.Text = "Crea Commessa Ricambi"
        btnSalva.Enabled = True
        btnCommessa.Enabled = True
        btnAdd.Enabled = True
        btnRemove.Enabled = True
        btnSpostaSu.Enabled = True
        btnSpostaGiu.Enabled = True
        dgvRighe.ReadOnly = False
        btnEliminaOfferta.Enabled = True

        If IDOrdine > 0 Then
            'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t28_testate_ordini_cli' table. You can move, or remove it, as needed.
            Me.T28_testate_ordini_cliTableAdapter.FillById(Me.GestioneProduzione2009DataSet1.t28_testate_ordini_cli, Me.IDOrdine)
            'Me.T28_testate_ordini_cliBindingSource.Filter = GestioneProduzione2009DataSet.t28_testate_ordini_cli.t28_idColumn.ColumnName & " = " & IDOrdine

            'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t29_righe_ordine_cli' table. You can move, or remove it, as needed.
            Me.T29_righe_ordine_cliTableAdapter.FillByIdTestataAll(Me.GestioneProduzione2009DataSet1.t29_righe_ordine_cli, Me.IDOrdine)
            'Me.T29_righe_ordine_cliBindingSource.Filter = GestioneProduzione2009DataSet.t29_righe_ordine_cli.t29_id_testata_t28Column.ColumnName & " = " & IDOrdine

            Me.Text = "Offerta " & txtCommessaNum.Text & " del " & txtCommessaDel.Text

            Dim ordineCorrente As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow = Me.GestioneProduzione2009DataSet1.t28_testate_ordini_cli.Rows(0)
            'If (ordineCorrente.t28_stato_testata_ordine = frmOrdiniRicambiNuovo.STATO_EVASO) Then
            '    MessageBox.Show("L'ordine e' già stato evaso, impossibile fare modifiche!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    btnSalva.Enabled = False
            '    '
            '    btnAdd.Enabled = False
            '    btnRemove.Enabled = False
            '    '
            '    btnSpostaSu.Enabled = False
            '    btnSpostaGiu.Enabled = False
            'End If
            If (Not ordineCorrente.Ist28_commessaNull) Then
                'FormsHelper.Warn("L'offerta e' già stata convertita in Commessa Ricambi, impossibile fare modifice.", Me.Text)
                btnCommessa.Text = "Offerta già Confermata"
                btnSalva.Enabled = False
                btnCommessa.Enabled = False
                btnAdd.Enabled = False
                btnRemove.Enabled = False
                btnSpostaSu.Enabled = False
                btnSpostaGiu.Enabled = False
                dgvRighe.ReadOnly = True
                btnEliminaOfferta.Enabled = False
            End If
        Else
            Me.Text = "Nuova Offerta "

            Me.T28_testate_ordini_cliBindingSource.AddNew()

            Dim nuova As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow
            nuova = CType(Me.T28_testate_ordini_cliBindingSource.Current, DataRowView).Row

            PreparaNuovaOfferta(nuova)
            'nuova.t28_utente_creazione = frmMain.Profilo.nome
            'nuova.t28_dt_creazione = DateTime.Now
            'nuova.t28_offerta = True
            'nuova.t28_offerta_stato = STATO_APERTO
            'nuova.t28_offerta_del = DateTime.Now
            nuova.t28_offerta_lingua = "Italiano"
            nuova.t28_offerta_cliente = "Spett." & vbCrLf

        End If

        ' Listino
        Me.T26_formule_prezziTableAdapter.Fill(Me.GestioneProduzione2009DataSet1.t26_formule_prezzi)
        'Me.GestioneProduzione2009DataSet.EnforceConstraints = False
        Me.ListinoRicambiTableAdapter.Fill(Me.GestioneProduzione2009DataSet1.ListinoRicambi)
        'Me.GestioneProduzione2009DataSet.EnforceConstraints = True
        Me.GestioneProduzione2009DataSet1.AggiornaPrezziListinoRicambi()

        datiCaricatiFiltroOrdinamento = True
    End Sub

    Private Sub FiltraDati()
        datiCaricatiFiltroOrdinamento = False
        If IDOrdine = 0 Then
            'Me.T28_testate_ordini_cliBindingSource.AddNew()
            ' Metto sempre il filtro per quelle Cancellate così posso cancellarle anche in caso di creazione di una nuova
            Me.T29_righe_ordine_cliBindingSource.Filter = GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_dt_cancellazioneColumn.ColumnName + " IS NULL"
        Else
            ' Filtro la testata
            Me.T28_testate_ordini_cliBindingSource.Filter = GestioneProduzione2009DataSet1.t28_testate_ordini_cli.t28_idColumn.ColumnName & " = " & IDOrdine.ToString
            ' Filtro le righe
            Me.T29_righe_ordine_cliBindingSource.Filter = GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_id_testata_t28Column.ColumnName & " = " & IDOrdine.ToString
            Me.T29_righe_ordine_cliBindingSource.Filter += " AND " + GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_dt_cancellazioneColumn.ColumnName + " IS NULL"
        End If


        'Me.ViewRicambiBindingSource.Filter = GestioneProduzione2009DataSet.t20_articoli.t20_is_ricambioColumn.ColumnName & " = true"
        'Filtra Articoli (Ricambi)
        Me.ListinoRicambiBindingSource.Filter = QueryUtils.likeCondition2(GestioneProduzione2009DataSet1.dvArticoliConMatricole.t25_cod_matricolaColumn.ColumnName, txtFiltroArticoli.Text) + " OR " + QueryUtils.likeCondition2(GestioneProduzione2009DataSet1.dvArticoliConMatricole.t20_cod_articoloColumn.ColumnName, txtFiltroArticoli.Text) + " OR " + QueryUtils.likeCondition2(GestioneProduzione2009DataSet1.dvArticoliConMatricole.t20_descrizioneColumn.ColumnName, txtFiltroArticoli.Text)
        datiCaricatiFiltroOrdinamento = True
    End Sub

    Private Sub OrdinaDati()
        datiCaricatiFiltroOrdinamento = False
        If StringUtils.isNullOrEmpty(Me.T29_righe_ordine_cliBindingSource.Sort) Then
            'Ordino per posizione
            Me.T29_righe_ordine_cliBindingSource.Sort = GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_posizioneColumn.ColumnName & " ASC"
        End If
        datiCaricatiFiltroOrdinamento = True
    End Sub

    Private Sub txtFiltroArticoli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroArticoli.TextChanged
        FiltraDati()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Salva(False)
    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs)
        'Dim theRow As DataGridViewRow = e.Row
        'theRow.Cells(T29idtestatat28DataGridViewTextBoxColumn.Name).Value = txtID.Text
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub T29_righe_ordine_cliBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles T29_righe_ordine_cliBindingSource.AddingNew
        Debug.WriteLine("AddingNew")
        ' Appena aggiunto la riga nuova imposto la testata
        ' Preso da questo esempio:
        ' http://community.visual-basic.it/lucianob/archive/2009/09/25/26516.aspx

        Dim rowView As DataRowView = CType(T29_righe_ordine_cliBindingSource.List, DataView).AddNew
        'Dim newRow As DataRow = CType(rowView.Row, DataRow)

        ' Alla riga che sto aggiungendo assegno ID di testata e Posizione
        rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_id_testata_t28Column.ColumnName) = Me.IDOrdine
        rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_posizioneColumn.ColumnName) = Me.T29_righe_ordine_cliBindingSource.Count ' rappresenta il numero di righe visualizzato

        If aggiuntoDaAdd Then
            If (Not ricambioSelezionato Is Nothing) Then
                Dim quantita As Integer = 1
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_codColumn.ColumnName) = ricambioSelezionato.t20_cod_articolo
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_descrizioneColumn.ColumnName) = ricambioSelezionato.t20_descrizione ' GeneratoreOfferta.descrizioneInLingua(ricambioSelezionato, cmbLingua.Text, ricambioSelezionato.t20_descrizione)
                If Not ricambioSelezionato.Ist20_descrizione_commerciale_itNull Then rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_descrizione_commerciale_itColumn.ColumnName) = ricambioSelezionato.t20_descrizione_commerciale_it
                If Not ricambioSelezionato.Ist20_descrizione_commerciale_enNull Then rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_descrizione_commerciale_enColumn.ColumnName) = ricambioSelezionato.t20_descrizione_commerciale_en
                If Not ricambioSelezionato.Ist20_descrizione_commerciale_esNull Then rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_descrizione_commerciale_esColumn.ColumnName) = ricambioSelezionato.t20_descrizione_commerciale_es
                If Not ricambioSelezionato.Ist20_descrizione_commerciale_frNull Then rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_descrizione_commerciale_frColumn.ColumnName) = ricambioSelezionato.t20_descrizione_commerciale_fr

                'Mirco 15/10/2014: Non associo gli articoli fittizzi 999999999
                If (ricambioSelezionato.t20_id_articolo <> 999999999) Then
                    rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_id_articolo_t20Column.ColumnName) = ricambioSelezionato.t20_id_articolo
                End If
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_qt_ordinataColumn.ColumnName) = quantita
                'rowView(GestioneProduzione2009DataSet.t29_righe_ordine_cli.t29_id_testata_t28Column.ColumnName) = IDOrdine
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_stato_riga_ordineColumn.ColumnName) = frmOrdiniRicambiNuovo.STATO_APERTO
                ' TOLTO questa situazione Mirco: alcuni ricambi non hanno la matricola:
                'If Not ricambioSelezionato.Ist25_cod_matricolaNull Then
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_matricolaColumn.ColumnName) = ricambioSelezionato.t25_cod_matricola
                'End If

                ' Ora la procedura viene fatta su AggiornaPosizioniETotale ma impostiamo il prezzo originale
                Dim prezzo As Double = ricambioSelezionato.t20_prezzo
                rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_prezzo_originaleColumn.ColumnName) = prezzo
                'If (chkListinoCliente.Checked) Then
                '    prezzo = prezzo + (prezzo * 0.25)
                'End If
                'rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_prezzo_uniColumn.ColumnName) = prezzo
                'Dim sconto = Val(txtSconto.Text) / 100
                'Dim prezzoTot As Double = quantita * prezzo - (prezzo * sconto)
                'rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_prezzo_totaColumn.ColumnName) = prezzoTot

                colonnaPrezzoUni.ReadOnly = True

                ' Dopo l'aggiunta sembrerebbe ancora in uno stato strano
                rowView.EndEdit()

                aggiuntoDaAdd = False
            End If
        Else
            colonnaPrezzoUni.ReadOnly = False
        End If

        T29_righe_ordine_cliBindingSource.Position = T29_righe_ordine_cliBindingSource.Count

        'AggiornaPosizioniETotale()
        e.NewObject = rowView
        Me.T29_righe_ordine_cliBindingSource.EndEdit()
    End Sub

    'Private Function descrizioneInLingua(ByVal ricambio As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow, ByVal lingua As String, ByVal defaultValue As String) As String
    '    Dim res As String
    '    res = defaultValue
    '    If lingua = "Italiano" Then
    '        If Not ricambio.Ist29_descrizione_commerciale_itNull Then
    '            res = ricambio.t29_descrizione_commerciale_it
    '        End If
    '    ElseIf lingua = "Inglese" Then
    '        If Not ricambio.Ist29_descrizione_commerciale_enNull Then
    '            res = ricambio.t29_descrizione_commerciale_en
    '        End If
    '    ElseIf lingua = "Spagnolo" Then
    '        If Not ricambio.Ist29_descrizione_commerciale_esNull Then
    '            res = ricambio.t29_descrizione_commerciale_es
    '        End If
    '    ElseIf lingua = "Francese" Then
    '        If Not ricambio.Ist29_descrizione_commerciale_frNull Then
    '            res = ricambio.t29_descrizione_commerciale_fr
    '        End If
    '    End If
    '    descrizioneInLingua = res
    'End Function

    Private Sub dgvRighe_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRighe.CellEndEdit
        ' In teoria ora viene tutto calcolato da AggiornaPosizioniETotale

        '' Se modifico quantita ordinata o prezzo unitario aggiorno il totale
        'If e.ColumnIndex = colonnaPrezzoUni.Index Or e.ColumnIndex = colonnaQuantita.Index Then
        '    If Not IsDBNull(dgvRighe.Rows(e.RowIndex).Cells(colonnaPrezzoUni.Index).Value) And Not IsDBNull(dgvRighe.Rows(e.RowIndex).Cells(colonnaQuantita.Index).Value) Then
        '        ' Agisco sulla cella della griglia, forse e' il caso di agire sulla riga bindata?
        '        Dim sconto, prezzoUni, quantita As Double
        '        sconto = 0
        '        prezzoUni = 0
        '        quantita = 0
        '        Double.TryParse(txtSconto.Text, sconto)
        '        Double.TryParse(dgvRighe.Rows(e.RowIndex).Cells(colonnaPrezzoUni.Index).Value, prezzoUni)
        '        Double.TryParse(dgvRighe.Rows(e.RowIndex).Cells(colonnaQuantita.Index).Value, quantita)
        '        ' sconto = (prezzoUni * quantita) * (sconto / 100)
        '        dgvRighe.Rows(e.RowIndex).Cells(colonnaPrezzoTot.Index).Value = (prezzoUni * quantita) - sconto
        '    Else
        '        dgvRighe.Rows(e.RowIndex).Cells(colonnaPrezzoTot.Index).Value = DBNull.Value
        '    End If
        'End If

        AggiornaPosizioniETotale()
    End Sub

    Private Sub dgvRighe_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRighe.EditingControlShowing

        ' La verifica del tasto punto e virgola viene fatta solo per alcune colonne 
        Dim columnName = dgvRighe.Columns(dgvRighe.CurrentCell.ColumnIndex).Name
        If columnName = colonnaQuantita.Name Or columnName = colonnaPrezzoUni.Name Then
            VS2005Commons.DataGridHelper.getIstanza().GestioneNumericPad(sender, e)
        End If

        elementoModificato = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        aggiuntoDaAdd = True

        ' Verifico che non sia stato aggiunto in precedenza (le devo controllare sulle righe in memoria)
        'T29_righe_ordine_cliBindingSource.EndEdit()
        'dgvRicambi.CancelEdit()

        Me.T29_righe_ordine_cliBindingSource.AddNew()

        ' Selezione Riga appena Aggiunta e Scrolla sulla Riga
        dgvRighe.ClearSelection()
        dgvRighe.Rows(dgvRighe.RowCount - 2).Selected = True
        dgvRighe.FirstDisplayedScrollingRowIndex = dgvRighe.RowCount - 2
        'DataGridHelper.Scrool()

        elementoModificato = True
    End Sub

    Private Sub btnSpostaSu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaSu.Click
        Ordinamento(-1)
        elementoModificato = True
    End Sub

    Private Sub btnSpostaGiu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpostaGiu.Click
        Ordinamento(+1)
        elementoModificato = True
    End Sub

    'TODO: SISTEMARE
    Private Sub Ordinamento(ByVal incremento As Integer)

        'dgvRighe.EndEdit()
        'dgvRighe.BeginEdit(False)

        ' Non incremento decremento l'ultima e la prima
        ' ATTENZIONE: dgvRicambi.Rows.Count rappresenta tutte le righe non solo quelle visualizzate
        ' ATTENZIONE: dgvRicambi.CurrentRow non rispecchia l'ordinamento

        If Not dgvRicambi.CurrentRow Is Nothing Then
            Dim currentRowIndex = dgvRighe.CurrentRow.Index
            If (incremento > 0) Then
                If (currentRowIndex < dgvRighe.RowCount) Then
                    'Dim curPos = dgvRighe.CurrentRow.Cells(colonnaPosizione.Index).Value
                    'dgvRighe.CurrentRow.Cells(colonnaPosizione.Index).Value = dgvRighe(colonnaPosizione.Index, dgvRighe.CurrentRow.Index + 1).Value
                    'dgvRighe(colonnaPosizione.Index, dgvRighe.CurrentRow.Index + 1).Value = curPos

                    Dim curPos = dgvRighe(colonnaPosizione.Index, currentRowIndex).Value
                    Dim nextPos = dgvRighe(colonnaPosizione.Index, currentRowIndex + 1).Value
                    dgvRighe.Rows(currentRowIndex).Cells(colonnaPosizione.Index).Value = nextPos
                    dgvRighe.Rows(currentRowIndex + 1).Cells(colonnaPosizione.Index).Value = curPos

                    Console.WriteLine("riga {0} posizione da {1} a {2}", currentRowIndex, curPos, nextPos)
                    Console.WriteLine("riga {0} posizione da {1} a {2}", currentRowIndex + 1, nextPos, curPos)

                    'dgvRighe.RefreshEdit()
                    T29_righe_ordine_cliBindingSource.EndEdit()
                    'dgvRighe.ClearSelection()
                    'dgvRighe.Rows(currentRowIndex + 1).Selected = True

                End If
            Else
                If (currentRowIndex > 0) Then
                    'Dim curPos = dgvRighe.CurrentRow.Cells(colonnaPosizione.Index).Value
                    'dgvRighe.CurrentRow.Cells(colonnaPosizione.Index).Value = dgvRighe(colonnaPosizione.Index, dgvRighe.CurrentRow.Index - 1).Value
                    'dgvRighe(colonnaPosizione.Index, dgvRighe.CurrentRow.Index - 1).Value = curPos

                    Dim curPos = dgvRighe(colonnaPosizione.Index, currentRowIndex).Value
                    Dim prevPos = dgvRighe(colonnaPosizione.Index, currentRowIndex - 1).Value
                    dgvRighe.Rows(currentRowIndex).Cells(colonnaPosizione.Index).Value = prevPos
                    dgvRighe.Rows(currentRowIndex - 1).Cells(colonnaPosizione.Index).Value = curPos

                    Console.WriteLine("riga {0} posizione da {1} a {2}", currentRowIndex, curPos, prevPos)
                    Console.WriteLine("riga {0} posizione da {1} a {2}", currentRowIndex - 1, prevPos, curPos)

                    'dgvRighe.RefreshEdit()
                    T29_righe_ordine_cliBindingSource.EndEdit()
                    'dgvRighe.ClearSelection()
                    'dgvRighe.Rows(currentRowIndex - 1).Selected = True

                End If
            End If
            'OrdinaDati()
        End If

        'AggiornaPosizioniETotale()
        'dgvRighe.EndEdit()
        'dgvRighe.Refresh()

    End Sub

    Private Sub AggiornaPosizioniETotale()
        Debug.WriteLine("AggiornaPosizioniETotale")

        Dim scontoRivenditore As Single
        scontoRivenditore = 0.25
        Dim dt As GestioneProduzione2009DataSet.t31_configurazioneDataTable
        dt = Me.T31_configurazioneTableAdapter1.GetData()
        If (dt.Rows.Count > 0) Then
            Dim dr As GestioneProduzione2009DataSet.t31_configurazioneRow
            dr = dt.Rows(0)
            If (Not dr.Issconto_rivenditoreNull) Then
                scontoRivenditore = dr.sconto_rivenditore / 100
            End If
        End If


        Dim totale As Double
        totale = 0
        Dim posizione As Integer
        posizione = 1

        'dgvRighe.BeginEdit(False)
        For Each row As DataGridViewRow In dgvRighe.Rows()

            row.Cells(colonnaPosizione.Index).Value = posizione
            posizione = posizione + 1

            ' Aggiorno i prezzi unitari dei ricambi in base al listino selezionato
            Dim prezzo As Double = 0
            If IsNumeric(row.Cells(colonnaPrezzoOriginale.Index).Value) Then
                prezzo = row.Cells(colonnaPrezzoOriginale.Index).Value
                If Not (row.Cells(colonnaIdArticolo.Index).Value Is Nothing) Then
                    If (chkListinoCliente.Checked) Then
                        prezzo = prezzo + (prezzo * scontoRivenditore)
                    End If
                    'rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_prezzo_uniColumn.ColumnName) = prezzo
                    row.Cells(colonnaPrezzoUni.Index).Value = prezzo
                End If
            End If
            ' prendo quello appena aggiornato oppure quello manuale per le righe impostate a mano
            If IsNumeric(row.Cells(colonnaPrezzoUni.Index).Value) Then
                prezzo = row.Cells(colonnaPrezzoUni.Index).Value

                ' Aggiorno i totali di riga in base allo sconto applicato
                Dim sconto = Val(txtSconto.Text) / 100
                Dim quantita As Double = 0
                ' se specificata la quantita la uso altimenti la imposto a 0
                If IsNumeric(row.Cells(colonnaQuantita.Index).Value) Then
                    quantita = row.Cells(colonnaQuantita.Index).Value
                Else
                    row.Cells(colonnaQuantita.Index).Value = 1
                End If
                Dim prezzoTot As Double = quantita * prezzo
                prezzoTot = prezzoTot - (prezzoTot * sconto)
                'rowView(GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_prezzo_totaColumn.ColumnName) = prezzoTot
                row.Cells(colonnaPrezzoTot.Index).Value = prezzoTot

                If IsNumeric(row.Cells(colonnaPrezzoTot.Index).Value) Then
                    totale = totale + Double.Parse(row.Cells(colonnaPrezzoTot.Index).Value.ToString())
                End If
            End If
        Next
        'dgvRighe.EndEdit()

        txtTotale.Text = totale.ToString("0.00")
    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        'Dim rowToDelete As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow = CType(Me.T29_righe_ordine_cliBindingSource.Current, DataRowView).Row

        Dim testoRiga As String
        If Not LangUtils.isEmpty(rigaSelezionata) Then
            If rigaSelezionata.Ist29_codNull Then
                'testoRiga = rigaSelezionata.t29_descrizione
                If (rigaSelezionata.Ist29_descrizioneNull) Then
                    testoRiga = ""
                Else
                    testoRiga = rigaSelezionata.t29_descrizione
                End If
            Else
                testoRiga = rigaSelezionata.t29_matricola
            End If

            Dim message As String
            message = "Eliminare il ricambio " + testoRiga + " ?"
            If (String.IsNullOrEmpty(testoRiga)) Then
                message = "Eliminare la riga?"
            End If
            If FormsHelper.Confirm(message, Me.Text) Then
                'OLD:
                'rigaSelezionata.t29_posizione = 0
                'rigaSelezionata.t29_dt_cancellazione = DateTime.Now
                'rigaSelezionata.EndEdit()
                'NEW:
                rigaSelezionata.Delete()
                'rigaSelezionata.EndEdit()

                'dgvRighe.Refresh()
                elementoModificato = True
                'Salva(True)

            End If
        End If

        'rowToDelete.SetModified()

    End Sub

    Private Sub ListinoRicambiBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListinoRicambiBindingSource.CurrentChanged
        ' anche se sto filtrano qui deve selezionarsi il current filtrato
        Debug.WriteLine("Listino CurrentChanged")
        If LangUtils.isNotEmpty(Me.ListinoRicambiBindingSource.Current) Then
            'If datiCaricatiFiltroOrdinamento Then
            'da DataRowView .Row ricavo la row dati selezionata
            ricambioSelezionato = CType(Me.ListinoRicambiBindingSource.Current, DataRowView).Row
            'End If
        Else
            ricambioSelezionato = Nothing
        End If
    End Sub

    Private Sub T29_righe_ordine_cliBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T29_righe_ordine_cliBindingSource.CurrentChanged
        If (datiCaricatiFiltroOrdinamento) Then
            Debug.WriteLine("T29_righe CurrentChanged")
            If LangUtils.isNotEmpty(Me.T29_righe_ordine_cliBindingSource.Current) Then
                If (datiCaricatiFiltroOrdinamento) Then
                    rigaSelezionata = CType(Me.T29_righe_ordine_cliBindingSource.Current, DataRowView).Row
                    ' Editing sulla Griglia (questo imposta le colonne readonly in funzione del tipo di riga selezionato)
                    If (Not rigaSelezionata.Ist29_id_articolo_t20Null() AndAlso rigaSelezionata.t29_id_articolo_t20 > 0) Then
                        colonnaPrezzoUni.ReadOnly = True
                        colonnaMatricola.ReadOnly = True
                    Else
                        colonnaPrezzoUni.ReadOnly = False
                        colonnaMatricola.ReadOnly = False
                    End If

                    ' TODO: Se faccio invio sulla ultima riga di una riga aggiunta a mano poi passa su quella nuova che ' detached e nonaggiorna i totali
                    ' SISTEMATO: con aggiorna su end edit
                    If (rigaSelezionata.RowState <> DataRowState.Detached) Then
                        AggiornaPosizioniETotale()
                    End If
                End If
            Else
                rigaSelezionata = Nothing
            End If
            'AggiornaPosizioniETotale()
        End If
    End Sub





    Private Sub PrintPreviewExport(ByVal nome As String, ByVal export As Boolean)

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath(nome + ".rpt"))

        Dim formula = "{" & GestioneProduzione2009DataSet1.t28_testate_ordini_cli.TableName & "." & GestioneProduzione2009DataSet1.t28_testate_ordini_cli.t28_idColumn.ColumnName & "} = " & IDOrdine
        formula = formula + " AND ISNULL({" + GestioneProduzione2009DataSet1.t29_righe_ordine_cli.TableName & "." & GestioneProduzione2009DataSet1.t29_righe_ordine_cli.t29_dt_cancellazioneColumn.ColumnName + "})"
        FormReport.reportDocumentSource.RecordSelectionFormula = formula
        FormReport.reportDocumentSource.SetDataSource(Me.GestioneProduzione2009DataSet1)

        If Not export Then
            FormReport.Show()
        Else
            Dim file As String
            file = nome
            'file += IIf(StringUtils.isNotEmpty(txtFiltroMatricola.Text), "-" & FileUtils.encodeFileName(txtFiltroMatricola.Text), "")
            file += "-" & DateTime.Now.ToString(DateUtils.FORMAT_IT_MINUS)
            file += ".xls"

            file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Desktop, file)

            If FormReport.EsportaInExcel(file, True) Then
                Try
                    Process.Start(file)
                Catch ex As Exception
                    MessageBox.Show("Errore: " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub


    Private Sub dgvRighe_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvRighe.CellFormatting
        Dim rowIndex As Integer = e.RowIndex
        Dim theRow As DataGridViewRow = dgvRighe.Rows(rowIndex)

        Dim stato As String
        Try
            stato = theRow.Cells(t29_stato_riga_ordine.DataPropertyName).Value.ToString()
        Catch
        End Try

        If stato = frmOrdiniRicambiNuovo.STATO_EVASO Then
            theRow.DefaultCellStyle.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If (CheckBox1.Checked) Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            Me.T28_testate_ordini_cliBindingSource.EndEdit()
        End If
        elementoModificato = True
    End Sub

    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        If (CheckBox2.Checked) Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
            Me.T28_testate_ordini_cliBindingSource.EndEdit()
        End If
        elementoModificato = True
    End Sub

    Private Sub CheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        If (CheckBox3.Checked) Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            Me.T28_testate_ordini_cliBindingSource.EndEdit()
        End If
        elementoModificato = True
    End Sub


    Private Sub dgvRighe_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRighe.CellEnter
        ' Edit della colonna descrizione solo per le righe Non Articolo
        If (e.RowIndex >= 0) Then
            If (LangUtils.isDbNull(dgvRighe.Rows(e.RowIndex).Cells(colonnaIdArticolo.Name).Value)) Then
                colonnaDescrizione.ReadOnly = False
                colonnaMatricola.ReadOnly = False
            Else
                colonnaDescrizione.ReadOnly = True
                colonnaMatricola.ReadOnly = True
            End If
        End If
    End Sub

    'Private Function verificaElementoModificato() As Boolean
    '    If elementoModificato Then
    '        FormsHelper.Warn("Salvare prima di procedere", Me.Text)
    '        verificaElementoModificato = False
    '    Else
    '        verificaElementoModificato = True
    '    End If
    'End Function

    Private Sub dgvRighe_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgvRighe.CellValidating
        ' Colonna QTA
        If (e.ColumnIndex = colonnaQuantita.Index) Or (e.ColumnIndex = colonnaPrezzoUni.Index) Then
            Dim qta As Double
            If (dgvRighe.Rows(e.RowIndex).IsNewRow) Then
                Return
            End If

            If (e.FormattedValue <> Nothing) Then
                If (Not Double.TryParse(e.FormattedValue, qta)) Then
                    e.Cancel = True
                    If (e.ColumnIndex = colonnaQuantita.Index) Then
                        dgvRighe.Rows(e.RowIndex).ErrorText = "Attenzione: Quantita non valida."
                        'MessageBox.Show("Attenzione: Quantita non valida.")
                    ElseIf (e.ColumnIndex = colonnaPrezzoUni.Index) Then
                        dgvRighe.Rows(e.RowIndex).ErrorText = "Attenzione: Prezzo non valido."
                        'MessageBox.Show("Attenzione: Prezzo non valido.")
                    End If

                    'If (e.ColumnIndex = colonnaQuantita.Index Or e.ColumnIndex = colonnaPrezzoUni.Index) Then
                    '    dgvRighe.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                    'End If

                Else
                    dgvRighe.Rows(e.RowIndex).ErrorText = ""
                End If
            End If
        End If
    End Sub

    Private Sub chkListinoRivenditore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkListinoRivenditore.Click
        If (chkListinoRivenditore.Checked) Then
            chkListinoCliente.Checked = False
        End If
        Me.T28_testate_ordini_cliBindingSource.EndEdit()
        AggiornaPosizioniETotale()
        elementoModificato = True
    End Sub

    Private Sub chkListinoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkListinoCliente.Click
        If (chkListinoCliente.Checked) Then
            chkListinoRivenditore.Checked = False
        End If
        Me.T28_testate_ordini_cliBindingSource.EndEdit()
        AggiornaPosizioniETotale()
        elementoModificato = True
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        If verificaElementoModificato() Then
            Dim generatore As New GeneratoreOfferta()
            Dim modelloOfferta As String
            Try
                modelloOfferta = "Reda-Offerta-" + cmbLingua.Text + ".xls"

                Dim excel = generatore.Genera(modelloOfferta, IDOrdine)

                If (File.Exists(excel)) Then
                    System.Diagnostics.Process.Start(excel)
                End If
            Catch ex As Exception
                FormsHelper.Error("Si e' verificato un errore." & vbCrLf & ex.Message, Me.Text)
            End Try
        End If
    End Sub

    Private Sub btnCommessa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommessa.Click

        If verificaElementoModificato() Then

            Dim row As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow
            row = CType((CType(T28_testate_ordini_cliBindingSource.Current, DataRowView).Row), GestioneProduzione2009DataSet.t28_testate_ordini_cliRow)

            ' Chiediamo all'utente di inserire Numero e Data Commessa
            Dim dialog As New frmOfferta2Commessa
            dialog.txtCommessaNum.Text = row.t28_offerta_num
            dialog.txtCommessaData.SelectionStart = DateTime.Now
            dialog.txtCommessaData.SelectionEnd = DateTime.Now

            If (dialog.ShowDialog = Windows.Forms.DialogResult.OK) Then
                'If (FormsHelper.Confirm("Convertire questa Offerta in Commessa?", Me.Text)) Then
                Dim numero As String
                numero = dialog.txtCommessaNum.Text
                Dim data As DateTime
                data = dialog.txtCommessaData.SelectionStart


                ' le offerte sono offerta = 1 le commesse sono offerta = 0
                row.t28_offerta = True
                row.t28_offerta_stato = STATO_CHIUSO
                row.t28_commessa = numero

                row.t28_commessa_del = data
                'nuova.t28_commessa = DateTime.Now.ToString(DateUtils.FORMAT_ISO_COMPACT)
                row.t28_stato_testata_ordine = STATO_APERTO
                row.t28_utente_creazione_commessa = frmMain.Profilo.nome

                row.t28_cliente = row.t28_offerta_cliente.Replace(vbCrLf, " ").Replace("  ", " ")
                'row.t28_cliente2 = 
                row.t28_rif_reda = "Rif. Offerta n." + row.t28_offerta_num + " del " + row.t28_offerta_del.ToShortDateString()

                Salva(True)

                ' Chiediamo se vuole Stampare la Commessa Ricambi
                If FormsHelper.Confirm("Stampare la Commessa?", Me.Text) Then
                    PrintPreviewExport("REDA-CommessaVenditaMag", False)
                End If

            End If

            'End If
        End If

    End Sub

    Private Sub Salva(ByVal force As Boolean)
        'Dim conn As SqlClient.SqlConnection
        'Dim transaction As SqlClient.SqlTransaction = Nothing

        Try
            If (force OrElse FormsHelper.Confirm("Confermi salvataggio?", Me.Text)) Then

                Me.Validate()
                Me.T28_testate_ordini_cliBindingSource.EndEdit()
                Me.T29_righe_ordine_cliBindingSource.EndEdit()

                If String.IsNullOrEmpty(txtCommessaNum.Text.Trim()) Then
                    Throw New Exception("Specifica un Numero di Offerta Valido.")
                End If

                'conn = Me.T28_testate_ordini_cliTableAdapter.Connection()
                'conn.Open()
                'transaction = conn.BeginTransaction()

                'Salvo testata
                'Me.T28_testate_ordini_cliTableAdapter.Connection = transaction.Connection
                Me.T28_testate_ordini_cliTableAdapter.Update(Me.GestioneProduzione2009DataSet1.t28_testate_ordini_cli)
                'Se c'e' un controllo bindato con id del record inserito viene aggiornato
                'Me.T28_testate_ordini_cliBindingSource.ResetCurrentItem()

                Dim testata As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow = CType(Me.T28_testate_ordini_cliBindingSource.Current, DataRowView).Row
                Me.IDOrdine = testata.t28_id

                'Salvo righe e se non c'e' la testata impostata la configuro
                For Each row As DataGridViewRow In dgvRighe.Rows
                    If (row.Cells(T29idtestatat28DataGridViewTextBoxColumn.Name).Value Is DBNull.Value OrElse row.Cells(T29idtestatat28DataGridViewTextBoxColumn.Name).Value = 0) Then
                        row.Cells(T29idtestatat28DataGridViewTextBoxColumn.Name).Value = testata.t28_id
                    End If
                Next

                'Me.T29_righe_ordine_cliTableAdapter.Connection = transaction.Connection
                Me.T29_righe_ordine_cliTableAdapter.Update(Me.GestioneProduzione2009DataSet1.t29_righe_ordine_cli)
                'Me.T28_testate_ordini_cliBindingSource.ResetItem()

                'transaction.Commit()

                elementoModificato = False

                If (force) Then
                    'Me.Close()
                    CaricaDati()
                End If
            End If
        Catch ex As Exception
            'If Not transaction Is Nothing Then
            'transaction.Rollback()
            'End If
            MessageBox.Show("Errore: " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'SqlUtils.CloseConnection(conn)
        End Try
    End Sub

    'Private Sub frmOffertaNuova_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
    '    If (Not Me.Parent Is Nothing) Then
    '        If TypeOf Me.FormChiamante Is IFormRefreshable Then
    '            Dim parent As IFormRefreshable
    '            parent = CType(Me.FormChiamante, IFormRefreshable)
    '            parent.CallRefresh()
    '        End If
    '    End If
    'End Sub

    'Private _FormChiamante As Form
    'Property FormChiamante() As Form Implements IFormCallRefreshable.FormChiamante
    '    Get
    '        FormChiamante = Me._FormChiamante
    '    End Get
    '    Set(ByVal FormChiamante As Form)
    '        Me._FormChiamante = FormChiamante
    '    End Set
    'End Property

    Private Sub txtSconto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AggiornaPosizioniETotale()
    End Sub

    Private Sub txtCommessaNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSconto.TextChanged, txtRifOrd.TextChanged, txtPartitaIva.TextChanged, txtCommessaNum.TextChanged, txtCommessaDel.TextChanged, txtCommessaCliente1.TextChanged, txtCodCliente.TextChanged
        If (datiCaricatiFiltroOrdinamento) Then
            elementoModificato = True
        End If
    End Sub

    Private Sub cmbLingua_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLingua.TextChanged, cmbCausale.TextChanged
        If (datiCaricatiFiltroOrdinamento) Then
            elementoModificato = True
        End If
    End Sub

    Private Sub btnEliminaOfferta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminaOfferta.Click
        EliminaDati(Me.T28_testate_ordini_cliTableAdapter, Me.T29_righe_ordine_cliTableAdapter)
    End Sub

    Private Sub btnDuplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplica.Click
        If (datiCaricatiFiltroOrdinamento) Then
            Me.IDOrdine = DuplicaOffertaOCommessa(Me.T28_testate_ordini_cliTableAdapter, Me.T29_righe_ordine_cliTableAdapter)

            'Come nel load
            CaricaDati()
            FiltraDati()
            OrdinaDati()
        End If
    End Sub
End Class