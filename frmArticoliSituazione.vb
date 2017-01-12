Imports VS2005Commons
Imports GestioneProduzione2014OfficeExport


Public Class frmArticoliSituazione

    Dim DataModel1 As New DataModel()
    Dim m_CurrentRowIndexArticoli As Integer = -1
    Dim m_IDArticolo As Integer = -1
    Dim datiCaricati As Boolean = False
    Dim editArticoloMode As Boolean = False

    Private Sub frmElencoArticoli2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'dsSituazioneArticoli.t25_matricole' table. You can move, or remove it, as needed.
        'Me.T25_matricoleTableAdapter.Fill(Me.dsSituazioneArticoli.t25_matricole)

        AggiornaDati()

        'Tabelle accessorie, non le carico con aggiorna dati cosi' non si resettano le combo box
        Me.T11_fornitoriTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t11_fornitori)
        Me.T11fornitoriBindingSource.Sort = GestioneProduzione2009DataSet.t11_fornitori.t11_descrizioneColumn.ColumnName & " ASC"
        Me.T11fornitoriBindingSource2.Sort = GestioneProduzione2009DataSet.t11_fornitori.t11_descrizioneColumn.ColumnName & " ASC"

        'BackgroundWorker1.RunWorkerAsync(Me)

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AggiornaDati()


        'PannelloAttesa(True)

        Dim currentSort As String
        currentSort = Me.riepilogoArticoliBindingSource.Sort
        Dim currentFilter As String
        currentFilter = Me.riepilogoArticoliBindingSource.Filter
        Dim currentRowIndex As Integer
        If Not dgArticoliRiepilogo.CurrentCell Is Nothing Then
            currentRowIndex = dgArticoliRiepilogo.CurrentCell.RowIndex
        End If

        Me.dgArticoliRiepilogo.SuspendLayout()
        Me.dgArticoliRiepilogo.Visible = False
        Me.lblLoading.Visible = True
        'Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Me.dsSituazioneArticoli.Clear()

        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t11_fornitori' table. You can move, or remove it, as needed.

        Dim stopwatch1 As New Stopwatch()
        stopwatch1.Start()
        DataModel1.Fill()
        DataModel1.PreparaDati(Nothing)
        stopwatch1.Stop()
        Console.WriteLine("{0}ms", stopwatch1.ElapsedMilliseconds)

        ' Assegno alle istanza di Finestra i dati popolati nel Modello
        Me.dsSituazioneArticoli = DataModel1.GestioneProduzione2009DataSet1
        Me.riepilogoArticoliBindingSource.DataSource = DataModel1.GestioneProduzione2009DataSet1
        Me.riepilogoArticoliBindingSource.DataMember = DataModel1.GestioneProduzione2009DataSet1.RiepilogoArticoli.TableName

        t20_articoliBindingSource.DataSource = DataModel1.GestioneProduzione2009DataSet1
        t20_articoliBindingSource.DataMember = DataModel1.GestioneProduzione2009DataSet1.t20_articoli.TableName

        t25matricoleBindingSource.DataSource = DataModel1.GestioneProduzione2009DataSet1
        t25matricoleBindingSource.DataMember = DataModel1.GestioneProduzione2009DataSet1.t25_matricole.TableName

        If currentSort <> "" Then
            Me.riepilogoArticoliBindingSource.Sort = currentSort '"t20_cod_articolo"
        Else
            Me.riepilogoArticoliBindingSource.Sort = T20codarticoloDataGridViewTextBoxColumn.DataPropertyName
        End If
        Me.riepilogoArticoliBindingSource.Filter = currentFilter
        'Me.dgArticoliRiepilogo.Sort(T20idarticoloDataGridViewTextBoxColumn, System.ComponentModel.ListSortDirection.Ascending)

        dgArticoliRiepilogo.ResumeLayout()
        Me.dgArticoliRiepilogo.Visible = True
        Me.lblLoading.Visible = False
        Application.DoEvents()

        Try

            'Dim i As Integer
            'For i = 0 To dgArticoliRiepilogo.Rows.Count
            '    'dgArticoliRiepilogo.Rows(0).Selected = False
            '    'dgArticoliRiepilogo.Rows(currentRowIndex - 1).Selected = False
            dgArticoliRiepilogo.Rows(currentRowIndex).Selected = True
            ''dgArticoliRiepilogo.Rows(currentRowIndex + 1).Selected = False
            'If i = currentRowIndex Then
            '    dgArticoliRiepilogo.Rows(i).Selected = True
            'Else
            '    dgArticoliRiepilogo.Rows(i).Selected = False
            'End If
            'Next

        Catch
        End Try

        datiCaricati = True

        'PannelloAttesa(False)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dgArticoliRiepilogo_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgArticoliRiepilogo.CellFormatting

        'Attenzione a non usare CURRENT ROW perché sulle selezioni multiple colora

        'Dim rowIndex As Integer = e.RowIndex
        'Dim theRow As DataGridViewRow = DataGridView1.Rows(rowIndex)

        'Dim qt_ordinata_articolo As Decimal = CType(theRow.Cells("qt_ordinata_articolo").Value, Decimal)
        'Dim consumo_totale As Decimal = CType(theRow.Cells("consumo_totale").Value, Decimal)
        'Dim situazione As Decimal = CType(theRow.Cells("situazione").Value, Decimal)
        'Dim lotto_riordino As Decimal = CType(theRow.Cells("t20_lotto_riordino").Value, Decimal)

        'If situazione > 0 And situazione < lotto_riordino Then
        '    theRow.DefaultCellStyle.BackColor = Color.Yellow
        'ElseIf situazione < 0 Then
        '    theRow.DefaultCellStyle.BackColor = Color.Red
        'End If


        Dim rowIndex As Integer = e.RowIndex
        'If (rowIndex > 0) Then
        Dim theRow As DataGridViewRow = dgArticoliRiepilogo.Rows(rowIndex)

        'Invece che usare le celle, che sono le colonne visibili, e potrei nasconderle uso gli Item
        Dim consumo_totale As Decimal
        consumo_totale = theRow.Cells(ConsumototaleDataGridViewTextBoxColumn.Name).Value '.Item("consumo_totale", rowIndex).Value ' CType(theRow.Cells("consumo_totale").Value, Decimal)
        Dim situazione As Decimal
        situazione = theRow.Cells(SituazioneDataGridViewTextBoxColumn.Name).Value ' CType(theRow.Cells("situazione").Value, Decimal)
        Dim lotto_riordino As Decimal
        lotto_riordino = theRow.Cells(T20lottoriordinoDataGridViewTextBoxColumn.Name).Value ' CType(theRow.Cells("t20_lotto_riordino").Value, Decimal)

        If situazione >= 0 And situazione < lotto_riordino Then
            theRow.DefaultCellStyle.BackColor = Color.Khaki
        ElseIf situazione < 0 Then
            theRow.DefaultCellStyle.BackColor = Color.LightSalmon
            'Else
            '    'Aggiungo anche il default bianco perché ho notato che nei refresh altrimenti restano rosse o gialle
            '    theRow.DefaultCellStyle.BackColor = Color.White
        End If
        'End If

        If rdbVisualizzaGruppi.Checked Then
            theRow.ContextMenuStrip = cmnuGruppi
        End If
    End Sub

    Private Sub dgArticoliRiepilogo_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgArticoliRiepilogo.CurrentCellChanged

        If datiCaricati Then

            Dim s As DataGridView = CType(sender, DataGridView)
            If Not IsNothing(s) And Not IsNothing(s.CurrentCell) Then
                'If s.CurrentCell.RowIndex <> m_CurrentRowIndexArticoli Then
                'm_IDArticolo = CType(s.Item(s.CurrentRowIndex, 0), Integer)
                's.Select(s.CurrentRowIndex)
                m_IDArticolo = s.Item(0, s.CurrentCell.RowIndex).Value

                ' Se stavo modificando un articolo in precedenza
                If editArticoloMode Then
                    t20_articoliBindingSource.EndEdit()
                End If

                t20_articoliBindingSource.Filter = "t20_id_articolo = " & m_IDArticolo

                If (txtSituazioneArticolo.Text <> "") Then
                    If Val(txtSituazioneArticolo.Text) >= 0 And Val(txtSituazioneArticolo.Text) < Val(txtLottoRiordinoArticolo.Text) Then
                        txtSituazioneArticolo.BackColor = Color.Khaki
                    ElseIf (Val(txtSituazioneArticolo.Text) < 0) Then
                        txtSituazioneArticolo.BackColor = Color.LightSalmon
                    Else
                        txtSituazioneArticolo.BackColor = SystemColors.Control
                    End If
                End If

                'MostraDatiArticolo()
                'End If
                m_CurrentRowIndexArticoli = s.CurrentCell.RowIndex
            End If
        End If
    End Sub

    Private Sub txtRicercaCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged
        FiltraDati()
    End Sub

    Private Sub txtRicercaDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaDescrizione.TextChanged
        FiltraDati()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaMatricola.TextChanged
        FiltraDati()
    End Sub

    Private Sub FiltraDati()
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String
        Dim strFiltroMatricola As String

        Dim strFiltro As String = "1 = 1"

        strFiltroCodice = QueryUtils.encodeString(Me.txtRicercaCodice.Text)
        strFiltroDescrizione = QueryUtils.encodeString(Me.txtRicercaDescrizione.Text)
        strFiltroMatricola = QueryUtils.encodeString(Me.txtRicercaMatricola.Text)

        If strFiltroCodice.Trim <> "" Then
            strFiltro = strFiltro & " AND " & QueryUtils.likeCondition2("t20_cod_articolo", strFiltroCodice) ' "t20_cod_articolo LIKE '*" & strFiltroCodice & "*' "
            'If strFiltroDescrizione.Trim <> "" Then
            '    strFiltro = strFiltro & "AND "
            '    strFiltro = strFiltro & "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            'End If
            'Else
        End If
        If strFiltroDescrizione.Trim <> "" Then
            strFiltro = strFiltro & " AND " & QueryUtils.likeCondition2("t20_descrizione", strFiltroDescrizione) ' "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
        End If
        'End If

        If strFiltroMatricola.Trim <> "" Then
            strFiltro = strFiltro & " AND " & QueryUtils.likeCondition2("matricole", strFiltroMatricola) ' "matricole LIKE '*" & strFiltroMatricola & "*'"
        End If

        If chbRicercaDaOrdinare.Checked Then
            strFiltro = strFiltro & " AND " & "(situazione < 0 OR (situazione >= 0 AND situazione < t20_lotto_riordino))"
        End If

        If rdbVisualizzaArticoli.Checked Then
            strFiltro = strFiltro & " AND " & "t20_is_gruppo = 0"
        Else
            strFiltro = strFiltro & " AND " & "t20_is_gruppo = 1"
        End If

        If chbRicambi.Checked Then
            strFiltro = strFiltro & " AND " & "t20_is_ricambio = 1"
            'Else
            '    strFiltro = strFiltro & " AND " & "t20_is_ricambio = 0"
        End If

        If Not cmbFornitore.SelectedValue Is Nothing AndAlso cmbFornitore.SelectedValue.ToString().Trim <> String.Empty Then
            strFiltro = strFiltro & " AND " & "fornitore = '" & cmbFornitore.SelectedValue & "'"
        End If

        Me.riepilogoArticoliBindingSource.Filter = strFiltro
    End Sub

    Private Sub chbRicercaDaOrdinare_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRicercaDaOrdinare.CheckedChanged
        FiltraDati()
    End Sub

    Private Sub btnModificaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaArticolo.Click
        CambiaStatoCampiArticolo()
    End Sub

    Private Sub CambiaStatoCampiArticolo()

        editArticoloMode = Not editArticoloMode

        txtCodiceArticolo.ReadOnly = Not txtCodiceArticolo.ReadOnly
        txtDescrizioneArticolo.ReadOnly = Not txtDescrizioneArticolo.ReadOnly
        cmbFornitoreArticolo.Enabled = Not cmbFornitoreArticolo.Enabled
        txtCostoArticolo.ReadOnly = Not txtCostoArticolo.ReadOnly
        'txtPrezzoCalcolatoArticolo.ReadOnly = Not txtPrezzoCalcolatoArticolo.ReadOnly
        txtPrezzoForzatoArticolo.ReadOnly = Not txtPrezzoForzatoArticolo.ReadOnly
        chbRicambioArticolo.Enabled = Not chbRicambioArticolo.Enabled
        txtQtDisponibileArticolo.ReadOnly = Not txtQtDisponibileArticolo.ReadOnly
        txtLottoRiordinoArticolo.ReadOnly = Not txtLottoRiordinoArticolo.ReadOnly

        btnSalvaArticolo.Enabled = Not btnSalvaArticolo.Enabled
        btnModificaArticolo.Enabled = Not btnModificaArticolo.Enabled
        btnAnnullaArticolo.Enabled = Not btnAnnullaArticolo.Enabled
    End Sub

    Private Sub btnSalvaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvaArticolo.Click
        'Salva modifiche al record corrente
        Me.t20_articoliBindingSource.EndEdit()
        'Me.DataModel1.dat20_articoli.Update(DataModel1.GestioneProduzione2009DataSet1.t20_articoli)
        Me.DataModel1.T20_articoliTableAdapter1.Update(Me.DataModel1.GestioneProduzione2009DataSet1.t20_articoli)

        'Me.dgArticoliRiepilogo.SuspendLayout()

        'Dim rowIndex As Integer = Me.dgArticoliRiepilogo.CurrentRow.Index

        CambiaStatoCampiArticolo()

        AggiornaDati()

        ''Provo a riselezionare la riga precedente
        'Try
        '    Me.dgArticoliRiepilogo.se()
        'Catch
        'End Try

        'Me.dgArticoliRiepilogo.ResumeLayout()

    End Sub

    Private Sub btnAnnullaArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnullaArticolo.Click

        'Annulla modifiche
        t20_articoliBindingSource.CancelEdit()

        CambiaStatoCampiArticolo()
    End Sub

    Private Sub btnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiorna.Click
        AggiornaDati()
    End Sub

    Private Sub rdbVisualizzaGruppi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbVisualizzaGruppi.CheckedChanged
        FiltraDati()

        'dgArticoliRiepilogo.ContextMenuStrip = cmnuGruppi

    End Sub

    Private Sub rdbVisualizzaArticoli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbVisualizzaArticoli.CheckedChanged
        FiltraDati()

        'dgArticoliRiepilogo.ContextMenuStrip = Nothing

    End Sub

    Private Sub cmbFornitore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFornitore.SelectedIndexChanged
        If datiCaricati Then
            FiltraDati()
        End If
    End Sub

    Private Sub ScomponiGruppoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScomponiGruppoToolStripMenuItem.Click
        Dim idArticolo As Integer
        Dim codArticolo As String
        Dim descArticolo As String

        If Not IsNothing(dgArticoliRiepilogo) And Not IsNothing(dgArticoliRiepilogo.CurrentCell) Then
            'If s.CurrentCell.RowIndex <> m_CurrentRowIndexArticoli Then
            'm_IDArticolo = CType(s.Item(s.CurrentRowIndex, 0), Integer)
            's.Select(s.CurrentRowIndex)
            idArticolo = dgArticoliRiepilogo.Item(0, dgArticoliRiepilogo.CurrentCell.RowIndex).Value
            codArticolo = dgArticoliRiepilogo.Item(1, dgArticoliRiepilogo.CurrentCell.RowIndex).Value
            descArticolo = dgArticoliRiepilogo.Item(2, dgArticoliRiepilogo.CurrentCell.RowIndex).Value

            If MessageBox.Show("Scomporre il Gruppo " & codArticolo & " - " & descArticolo & "?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Dim res As String
                res = Me.DataModel1.ScomponiGruppo(idArticolo)
                If res = "" Then
                    MessageBox.Show("Scomposizione di " & codArticolo & " - " & descArticolo & " effettuata correttamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show(res, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
            End If
        End If
    End Sub

    Private Sub chbRicambi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbRicambi.CheckedChanged
        FiltraDati()
    End Sub

    Private Sub frmElencoArticoli2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.riepilogoArticoliBindingSource.Sort = ""
    End Sub

    'Private Sub PannelloAttesa(ByVal visibile As Boolean)
    '    'Me.Cursor = Cursors.WaitCursor

    '    Me.pnlLoading.Visible = visibile
    '    Application.DoEvents()

    '    If visibile Then

    '    End If

    '    'Me.Cursor = Cursors.Default
    'End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        'PannelloAttesa(True)
        'AggiornaDati(CType(e.Argument, frmElencoArticoli2))
        'PannelloAttesa(False)
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        Me.Close()
    End Sub


    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        'Dim StrExport As String = ""
        'For Each C As DataGridViewColumn In dgArticoliRiepilogo.Columns
        '    StrExport &= """" & C.HeaderText & ""","
        'Next
        'StrExport = StrExport.Substring(0, StrExport.Length - 1)
        'StrExport &= Environment.NewLine

        'For Each R As DataGridViewRow In dgArticoliRiepilogo.Rows
        '    For Each C As DataGridViewCell In R.Cells
        '        If Not C.Value Is Nothing Then
        '            StrExport &= """" & C.Value.ToString & ""","
        '        Else
        '            StrExport &= """" & "" & ""","
        '        End If
        '    Next
        '    StrExport = StrExport.Substring(0, StrExport.Length - 1)
        '    StrExport &= Environment.NewLine
        'Next

        'Dim tw As IO.TextWriter = New IO.StreamWriter("C:\Test1.CSV")
        'tw.Write(StrExport)
        'tw.Close()

        Me.Cursor = Cursors.WaitCursor
        DataGridViewToExcel.toCSV("SituazioneArticoli", dgArticoliRiepilogo)
        Me.Cursor = Cursors.Default
    End Sub
End Class