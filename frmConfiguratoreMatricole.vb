Imports System.Text
Imports VS2005Commons

Public Class frmConfiguratoreMatricole

    Dim editMode As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CaricaDati()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CaricaDati()
        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t20_articoli' table. You can move, or remove it, as needed.
        Me.T20_articoliTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t20_articoli)
        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t25_matricole' table. You can move, or remove it, as needed.
        Me.T25_matricoleTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t25_matricole)

        T20articoliBindingSource.Sort = "t20_cod_articolo"

        RefreshNumber()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroMatricola.TextChanged
        ApplicaFiltro()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplicaFiltro()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ApplicaFiltro()
    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMatricole.CellEnter

    End Sub

    Private Sub ApplicaFiltro()
        Dim filtro As StringBuilder
        filtro = New StringBuilder()

        Me.Cursor = Cursors.WaitCursor

        filtro.Append("TRUE")

        Dim filtroMatricola As String = QueryUtils.encodeString(txtFiltroMatricola.Text)

        If StringUtils.isNotEmpty(filtroMatricola) Then
            filtro.Append(" AND ")
            filtro.Append(QueryUtils.likeCondition2(GestioneProduzione2009DataSet.t25_matricole.t25_cod_matricolaColumn.ColumnName, filtroMatricola))
        End If

        If chkFiltroAssociate.Checked Then
            filtro.Append(" AND ")
            filtro.Append(GestioneProduzione2009DataSet.t25_matricole.t25_id_articolo_t20Column.ColumnName + " IS NULL")
        End If

        Me.T25matricoleBindingSource.Filter = filtro.ToString()

        RefreshNumber()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub RefreshNumber()
        lblCount.Text = "Trovate " & Me.dgMatricole.Rows.Count & " matricole"
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMatricole.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        If dgv.Columns(e.ColumnIndex).Name = Articolo.Name Then

            If (editMode) Then

                Dim popup As New frmSceltaArticolo3()
                'popup.ModoSelezione = frmSceltaArticolo.TModoSelezione.SELEZIONA
                popup.ShowDialog()

                If popup.DialogResult = Windows.Forms.DialogResult.OK Then
                    'dgv.Rows(e.RowIndex).Cells("Articolo").Value = popup.IDArticolo

                    dgv.Item(t25_id_articolo_t20.Index, e.RowIndex).Value = popup.IDArticolo

                    dgv.Refresh()
                End If

                'dgv.Columns(e.ColumnIndex) popup.IDArticolo
            Else
                MessageBox.Show("Impossibile modificare in modalità sola-lettura")
            End If

        End If
    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        CambiaStatoCampiArticolo()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Salva()
        CambiaStatoCampiArticolo()
    End Sub

    Private Sub Salva()
        If MessageBox.Show("Confermi il salvataggio delle modifiche apportate?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.T25_matricoleTableAdapter.Update(Me.GestioneProduzione2009DataSet.t25_matricole)
        End If
    End Sub

    Private Sub CambiaStatoCampiArticolo()

        Me.editMode = Not Me.editMode
        Me.dgMatricole.ReadOnly = Not Me.dgMatricole.ReadOnly
        Me.dgMatricole.AllowUserToAddRows = Not Me.dgMatricole.AllowUserToAddRows
        Me.dgMatricole.AllowUserToDeleteRows = Not Me.dgMatricole.AllowUserToDeleteRows

        btnSalva.Enabled = Not btnSalva.Enabled
        btnModifica.Enabled = Not btnModifica.Enabled
        btnAnnulla.Enabled = Not btnAnnulla.Enabled
    End Sub

    Private Sub frmConfiguratoreMatricole_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.editMode Then
            If MessageBox.Show("Confermi di voler chiudere la finestra?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dgMatricole_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgMatricole.DataError
        ' Errore di dati, ad esempio se l'id dell'articolo non esiste pià
    End Sub

    Private Sub T25matricoleBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles T25matricoleBindingSource.AddingNew

    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click

        Me.T25matricoleBindingSource.CancelEdit()
        CaricaDati()

        CambiaStatoCampiArticolo()
    End Sub

    Private Sub dgMatricole_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgMatricole.CellValidating
        'Dim trovato As Boolean = False
        '' Validate the CompanyName entry by disallowing empty strings.
        'If Me.editMode Then

        '    If dgMatricole.Columns(e.ColumnIndex).Name = T25codmatricolaDataGridViewTextBoxColumn.Name Then
        '        If e.FormattedValue IsNot Nothing AndAlso _
        '            String.IsNullOrEmpty(e.FormattedValue.ToString()) Then

        '            dgMatricole.Rows(e.RowIndex).ErrorText = "la Matricola non può essere vuota! (ESC per uscire)"
        '            e.Cancel = True

        '            'Else
        '            '    'Cerco matricole uguali

        '            '    For Each drow As DataGridViewRow In dgMatricole.Rows
        '            '        If e.FormattedValue = drow.Cells(T25codmatricolaDataGridViewTextBoxColumn.Name).Value Then
        '            '            trovato = True
        '            '            Exit For
        '            '        End If
        '            '    Next

        '            '    If trovato Then
        '            '        dgMatricole.Rows(e.RowIndex).ErrorText = "la Matricola esiste già! (ESC per uscire)"
        '            '        e.Cancel = True
        '            '    End If
        '        End If

        '    End If
        'End If

    End Sub

    Private Sub dgMatricole_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMatricole.CellEndEdit
        '' Clear the row error in case the user presses ESC.   
        'dgMatricole.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub chkFiltroAssociate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroAssociate.CheckedChanged
        ApplicaFiltro()

    End Sub

    Private Sub dgMatricole_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgMatricole.CellFormatting
        'Dim rowIndex As Integer = e.RowIndex
        'Dim theRow As DataGridViewRow = dgMatricole.Rows(rowIndex)
        'Dim idArticoloAssociato As Long = -1
        'Try
        '    ' Alcuni potrebbero essere DBNull
        '    idArticoloAssociato = theRow.Cells(t25_id_articolo_t20.Name).Value
        'Catch

        'End Try

        'If (idArticoloAssociato = -1) Then
        '    Articolo.Text = "Associa articolo"
        'Else
        '    Articolo.Text = "Cambia"
        'End If
    End Sub

    Private Sub dgMatricole_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles dgMatricole.UserDeletingRow
        Dim rowIndex As Integer = e.Row.Index
        Dim theRow As DataGridViewRow = dgMatricole.Rows(rowIndex)
        Dim matricola As String
        matricola = theRow.Cells(T25codmatricolaDataGridViewTextBoxColumn.Name).Value

        If MessageBox.Show("Confermi cancellazione della matricola " & matricola & " ?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class
