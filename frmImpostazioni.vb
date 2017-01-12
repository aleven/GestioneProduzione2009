Public Class frmImpostazioni

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim sqlConnString As SqlClient.SqlConnectionStringBuilder
        sqlConnString = New SqlClient.SqlConnectionStringBuilder(My.Settings.GestioneProduzione2009ConnectionString)

        sqlConnString.DataSource = txtServer.Text
        sqlConnString.InitialCatalog = txtDatabase.Text
        sqlConnString.UserID = txtUsername.Text
        sqlConnString.Password = txtPassword.Text

        ' My.Settings.GestioneProduzione2009ConnectionString = sqlConnString.ConnectionString
        ' TODO: SALVARE I SETTAGGI
        'My.Settings.GestioneProduzione2009ConnectionString

        Application.Exit()
    End Sub

    Private Sub frmImpostazioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServer.Text = ConnectionStringUtil.GetServer()
        txtDatabase.Text = ConnectionStringUtil.GetDataBase()
        txtUsername.Text = ConnectionStringUtil.GetUserName()
        txtPassword.Text = ConnectionStringUtil.GetPassword()
    End Sub
End Class