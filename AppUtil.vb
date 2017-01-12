Public Class AppUtil

    Public Shared DATE_FORMAT As String = "dd/MM/yyyy"

    Public Shared Function GetAppPath(ByVal fileName As String) As String
        Return IO.Path.Combine(Application.StartupPath, fileName)
    End Function

End Class
