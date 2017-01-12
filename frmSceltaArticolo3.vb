Imports VS2005Commons

Public Class frmSceltaArticolo3

    Public IDArticolo As Integer

    Private Sub frmSceltaArticolo3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtRicercaCodice.Select()

        'TODO: This line of code loads data into the 'GestioneProduzione2009DataSet.t20_articoli' table. You can move, or remove it, as needed.
        Me.T20_articoliTableAdapter.Fill(Me.GestioneProduzione2009DataSet.t20_articoli)

    End Sub

    Private Sub txtCercaCodice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaCodice.TextChanged
        ApplicaFiltri()
    End Sub

    Private Sub txtCercaDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRicercaDescrizione.TextChanged
        ApplicaFiltri()
    End Sub

    Private Sub ApplicaFiltri()
        Dim strFiltroCodice As String
        Dim strFiltroDescrizione As String

        Dim strFiltro As String = ""

        strFiltroCodice = QueryUtils.encodeString(Me.txtRicercaCodice.Text)
        strFiltroDescrizione = QueryUtils.encodeString(Me.txtRicercaDescrizione.Text)

        If strFiltroCodice.Trim <> "" Then
            strFiltro = "t20_cod_articolo LIKE '*" & strFiltroCodice & "*' "
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = strFiltro & "AND "
                strFiltro = strFiltro & "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        Else
            If strFiltroDescrizione.Trim <> "" Then
                strFiltro = "t20_descrizione LIKE '*" & strFiltroDescrizione & "*'"
            End If
        End If

        T20articoliBindingSource.Filter = strFiltro
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim dgv As DataGridView = CType(sender, DataGridView)

        CloseDialog(dgv.Item(0, e.RowIndex).Value)
    End Sub

    Private Sub GestisciEnter(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CloseDialog(DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
        End If
    End Sub

    Private Sub CloseDialog(ByVal id As Integer)
        Me.IDArticolo = id
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub txtRicercaCodice_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRicercaCodice.KeyDown
        GestisciEnter(e)
    End Sub

    Private Sub txtRicercaDescrizione_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRicercaDescrizione.KeyDown
        GestisciEnter(e)
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        GestisciEnter(e)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class