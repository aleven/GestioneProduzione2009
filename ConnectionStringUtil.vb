Public Class ConnectionStringUtil

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetUserName() As String
        Dim sqlConnString As SqlClient.SqlConnectionStringBuilder
        sqlConnString = New SqlClient.SqlConnectionStringBuilder(My.Settings.GestioneProduzione2009ConnectionString)

        GetUserName = sqlConnString.UserID
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetPassword() As String
        Dim sqlConnString As SqlClient.SqlConnectionStringBuilder
        sqlConnString = New SqlClient.SqlConnectionStringBuilder(My.Settings.GestioneProduzione2009ConnectionString)

        GetPassword = sqlConnString.Password
    End Function

    Public Shared Function GetServer() As String
        Dim sqlConnString As SqlClient.SqlConnectionStringBuilder
        sqlConnString = New SqlClient.SqlConnectionStringBuilder(My.Settings.GestioneProduzione2009ConnectionString)

        GetServer = sqlConnString.DataSource
    End Function

    Public Shared Function GetDataBase() As String
        Dim sqlConnString As SqlClient.SqlConnectionStringBuilder
        sqlConnString = New SqlClient.SqlConnectionStringBuilder(My.Settings.GestioneProduzione2009ConnectionString)

        GetDataBase = sqlConnString.InitialCatalog
    End Function
End Class
