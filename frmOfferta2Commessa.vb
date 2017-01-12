Imports VS2005Commons

Public Class frmOfferta2Commessa

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnConfirm.Click

        If String.IsNullOrEmpty(txtCommessaNum.Text.Trim()) Then
            FormsHelper.Error("Specifica un Numero di Commessa Valido.", Me.Text)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If


    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class