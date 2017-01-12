Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            ' Get the splash screen.
            'Dim splash As SplashScreen1 = CType(My.Application.SplashScreen, SplashScreen1)
            ' Display current status information.

            'Threading.Thread.Sleep(500)

            Try
                'splash.Status.Text = "Configurazione connessione al database..."

                'Apertura connessione
                'Dim dm As New DataModel()
                'dm.Init()
                'dm.conn.Open()
                'dm.conn.Close()

                'Dim conn As New System.Data.SqlClient.SqlConnection()
                'conn.ConnectionString = CType(New System.Configuration.AppSettingsReader().GetValue("conn.ConnectionString", GetType(String)), String)
                'conn.Open()
                'conn.Close()

                'Application.EnableVisualStyles = True

                GestioneProduzione2014Data.Configura.Imposta(My.Settings.GestioneProduzione2009ConnectionString)
                GestioneProduzione2014GinuxImport.Configura.Imposta(My.Settings.GestioneProduzione2009ConnectionString)

            Catch ex As Exception

                MessageBox.Show("Errore: " + ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                'MessageBox.Show("Impossibile aprire la connessione con il database.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Dim impostazioni As frmImpostazioni
                'impostazioni = New frmImpostazioni()
                'impostazioni.ShowDialog()

                'Try
                '    splash.Status.Text = "Connessione fallita!"
                'Catch ex As Exception

                'End Try

            End Try

        End Sub

    End Class

End Namespace

