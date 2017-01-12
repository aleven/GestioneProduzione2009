Imports GestioneProduzione2014Data

Public Class frmConfiguratorePrezzi

    Private Sub T26_formule_prezziBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T26_formule_prezziBindingNavigatorSaveItem.Click

        Dim errorMessage As String
        errorMessage = ""

        Me.Validate()
        Me.T26_formule_prezziBindingSource.EndEdit()

        For Each row As GestioneProduzione2009DataSet.t26_formule_prezziRow In Me.GestioneProduzione2009DataSet.t26_formule_prezzi
            If row.Ist26_formula_daNull Or row.Ist26_formula_daNull Then
                errorMessage = "Attenzione non sono stati specificati i limiti per una formula."
            End If

            If row.Ist26_prezzo_fissoNull And row.Ist26_fattoreNull Then
                errorMessage = "Attenzione una formula non contiene il criterio con cui calcolare il prezzo."
            End If
        Next

        If errorMessage = "" Then
            Me.T26_formule_prezziTableAdapter.Update(Me.GestioneProduzione2009DataSet.t26_formule_prezzi)

            Dim sconto As Single
            sconto = Single.Parse(txtSconto.Text)


            Dim dt As GestioneProduzione2009DataSet.t31_configurazioneDataTable
            Dim dr As GestioneProduzione2009DataSet.t31_configurazioneRow
            dt = Me.T31_configurazioneTableAdapter1.GetData()
            If (dt.Rows.Count > 0) Then
                dr = dt.Rows(0)
                dr.sconto_rivenditore = sconto
                Me.T31_configurazioneTableAdapter1.Update(dr)
            Else
                dr = dt.Newt31_configurazioneRow()
                dr.sconto_rivenditore = sconto
                dt.Addt31_configurazioneRow(dr)
                Me.T31_configurazioneTableAdapter1.Update(dr)
            End If


            MessageBox.Show("Salvataggio effettuato.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errorMessage, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmConfiguratorePrezzi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t26_formule_prezzi' table. You can move, or remove it, as needed.
        Me.T26_formule_prezziTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t26_formule_prezzi)

        Dim dt As GestioneProduzione2009DataSet.t31_configurazioneDataTable
        dt = Me.T31_configurazioneTableAdapter1.GetData()
        If (dt.Rows.Count > 0) Then
            Dim dr As GestioneProduzione2009DataSet.t31_configurazioneRow
            dr = dt.Rows(0)
            If (dr.Issconto_rivenditoreNull) Then
                txtSconto.Text = "25"
            Else
                txtSconto.Text = dr.sconto_rivenditore.ToString()
            End If
        Else
            txtSconto.Text = "25"
        End If


        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub T26_formule_prezziDataGridView_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles T26_formule_prezziDataGridView.CellEndEdit
        'Imposto l'una o l'altra cella se ho editato una delle percentuali
        If (Me.T26_formule_prezziDataGridView.Columns(e.ColumnIndex).Name = DataGridViewTextBoxColumnFisso.Name) Then

            Me.T26_formule_prezziDataGridView.Rows(e.RowIndex).Cells(DataGridViewTextBoxColumnMoltiplica.Index).Value = DBNull.Value

        ElseIf (Me.T26_formule_prezziDataGridView.Columns(e.ColumnIndex).Name = DataGridViewTextBoxColumnMoltiplica.Name) Then

            Me.T26_formule_prezziDataGridView.Rows(e.RowIndex).Cells(DataGridViewTextBoxColumnFisso.Index).Value = DBNull.Value
        End If
    End Sub

    Private Sub T26_formule_prezziDataGridView_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles T26_formule_prezziDataGridView.EditingControlShowing
        VS2005Commons.DataGridHelper.getIstanza().GestioneNumericPad(sender, e)
    End Sub

    Private Sub T26_formule_prezziBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T26_formule_prezziBindingNavigator.RefreshItems

    End Sub
End Class