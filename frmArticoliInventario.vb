Imports System.Text
Imports VS2005Commons
Imports GestioneProduzione2014Data

Public Class frmArticoliInventario

    Private Sub ArticoliModificaVeloce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CaricaDati()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        ChangeEditMode()
    End Sub

    Private Sub ChangeEditMode()

        Me.dgvArticoli.ReadOnly = Not Me.dgvArticoli.ReadOnly
        Me.dgvArticoli.RowHeadersVisible = Not Me.dgvArticoli.RowHeadersVisible
        btnSalva.Visible = Not Me.dgvArticoli.ReadOnly

        If Not dgvArticoli.ReadOnly Then
            btnModifica.Text = "Annulla"
            btnModifica.Image = My.Resources.undo
        Else

            For Each row As GestioneProduzione2009DataSet.t20_articoliRow In Me.GestioneProduzione2009DataSet.t20_articoli.Rows
                row.RejectChanges()
            Next

            'CaricaDati()
            btnModifica.Text = "Modifica"
            btnModifica.Image = My.Resources.edit
        End If

    End Sub

    Private Sub CaricaDati()
        Me.Cursor = Cursors.WaitCursor

        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t20_articoli' table. You can move, or remove it, as needed.
        Me.T20_articoliTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t20_articoli)

        ApplicaFiltro()

        If Me.T20articoliBindingSource.Sort = "" Then
            Me.T20articoliBindingSource.Sort = GestioneProduzione2009DataSet.t20_articoli.t20_cod_articoloColumn.ColumnName
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ApplicaFiltro()
        Dim filtro As StringBuilder
        filtro = New StringBuilder()

        Me.Cursor = Cursors.WaitCursor

        filtro.Append(GestioneProduzione2009DataSet.t20_articoli.t20_dt_cancellazioneColumn.ColumnName + " IS NULL ")
        filtro.Append(" AND ")
        filtro.Append(GestioneProduzione2009DataSet.t20_articoli.t20_is_gruppoColumn.ColumnName + " = FALSE ")

        If Not txtFiltroCodice.Text = "" Then
            filtro.Append(" AND ")
            filtro.Append(QueryUtils.likeCondition(GestioneProduzione2009DataSet.t20_articoli.t20_cod_articoloColumn.ColumnName, txtFiltroCodice.Text, True))
        End If

        If Not txtFiltroDescrizione.Text = "" Then
            filtro.Append(" AND ")
            filtro.Append(QueryUtils.likeCondition(GestioneProduzione2009DataSet.t20_articoli.t20_descrizioneColumn.ColumnName, txtFiltroDescrizione.Text, True))
        End If


        Me.T20articoliBindingSource.Filter = filtro.ToString()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtFiltroCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroCodice.TextChanged
        ApplicaFiltro()
    End Sub

    Private Sub txtFiltroDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltroDescrizione.TextChanged
        ApplicaFiltro()
    End Sub

    Private Sub dgvArticoli_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvArticoli.CellBeginEdit

    End Sub

    Private Sub dgvArticoli_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvArticoli.CellEndEdit

    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click

        If MessageBox.Show("Salvare le modifiche apportate?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.T20_articoliTableAdapter.Update(GestioneProduzione2009DataSet.t20_articoli)

            ChangeEditMode()
        Else

        End If
    End Sub

    Private Sub btnChiudi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiudi.Click
        If dgvArticoli.ReadOnly Then
            Me.Close()
        End If
    End Sub
End Class