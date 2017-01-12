Imports VS2005Commons
Imports GestioneProduzione2014GinuxImport
Imports System.Data.SqlClient
Imports GestioneProduzione2014Data

Public Class frmMain

    Public ConnectionString As String
    Public Shared Profilo As GestioneProduzione2009DataSet.t30_utentiRow
    Public Shared Utenti As GestioneProduzione2009DataSet.t30_utentiDataTable

    'Dim mainDataModel As DataModel
    ' Dim ribbonHelper As New RibbonFormHelper(Me)

    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ElencoArticoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoArticoliToolStripMenuItem.Click
        ArticoliSituazione()
    End Sub
    Private Sub ArticoliSituazione()
        'clessidra
        Me.Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmArticoliSituazione.GetType) Then
            Dim formElencoArticoli As New frmArticoliSituazione()
            formElencoArticoli.MdiParent = Me
            formElencoArticoli.Show()
        End If
    End Sub
    Private Sub ConfiguratoreArticoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguratoreArticoliToolStripMenuItem.Click
        ConfiguraArticoli()
    End Sub

    Private Sub ConfiguratoreGruppiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguratoreGruppiToolStripMenuItem.Click
        ConfiguraGruppi()
    End Sub

    Private Sub NuovoOrdineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovoOrdineToolStripMenuItem.Click
        NuovoOrdineAcquisto()

    End Sub

    Private Sub ElencoOrdiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoOrdiniToolStripMenuItem.Click
        ElencoOrdiniAcquisto()
    End Sub

    Private Sub EvasionePerArticoloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvasionePerArticoloToolStripMenuItem.Click
        EvasioneOrdiniAcquistoArticolo()
    End Sub

    Private Sub EvasioneOrdiniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvasioneOrdiniToolStripMenuItem.Click
        EvasioneOrdiniAcquisto()
    End Sub

    Private Sub NuovoOrdineToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovoOrdineToolStripMenuItem1.Click
        NuovaCommessaRicambi()
    End Sub

    Private Sub ElencoOrdiniToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoOrdiniToolStripMenuItem1.Click
        ElencoCommessaRicambi()
    End Sub

    Private Sub EvasioneOrdineDiVenditaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EvasioneOrdineDiVenditaToolStripMenuItem.Click
        EvasioneCommessaRicambi()
    End Sub

    Private Sub NuovaCommessaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovaCommessaToolStripMenuItem.Click
        NuovaCommessaProduzione()
    End Sub

    Private Sub ElencoCommesseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoCommesseToolStripMenuItem.Click
        ElencoCommesseProduzione()
    End Sub

    Private Sub SimulazioneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimulazioneToolStripMenuItem.Click
        SimulazioneCommesseProduzione()

    End Sub

    Private Sub SituazioneMacchineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SituazioneMacchineToolStripMenuItem.Click
        StampaSituazioneMacchine()

    End Sub

    Private Sub SituazioneArticoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SituazioneArticoliToolStripMenuItem.Click
        StampaSituazioneArticoli()
    End Sub

    Private Sub ConfigurazioneMacchineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigurazioneMacchineToolStripMenuItem.Click
        StampaConfigurazioneMacchine()
    End Sub

    Private Sub ElencoOrdiniAcquistoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoOrdiniAcquistoToolStripMenuItem.Click
        StampaElencoOrdiniAcquisto()
    End Sub

    Private Sub ElencoCommesseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoCommesseToolStripMenuItem1.Click
        StampaElencoCommesse()
    End Sub

    Private Sub ElencoArticoliInOrdineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoArticoliInOrdineToolStripMenuItem.Click
        StampaArticoliInOrdine()
    End Sub

    Private Sub InformazioniSuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniSuToolStripMenuItem.Click
        About()
    End Sub

    Private Sub About()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'Dim FormInformazioni As New frmInformazioniSu
        'FormInformazioni.ShowDialog()
        Dim FormAbout As New frmInformazioniSu
        FormAbout.ShowDialog()
    End Sub

    Private Sub ConfiguratoreMacchineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguratoreMacchineToolStripMenuItem.Click
        ConfiguraMacchine()

    End Sub

    Private Sub ConfiguratoreMatricoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguratoreMatricoleToolStripMenuItem.Click


        ConfiguraMatricole()
    End Sub

    Private Sub ConfiguratoreFormulePrezziToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguratoreFormulePrezziToolStripMenuItem.Click

        ConfiguraPrezzi()
    End Sub

    Private Sub ElencoFornitoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoFornitoriToolStripMenuItem.Click
        ElencoFornitori()
    End Sub

    Private Sub ElencoClientiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElencoClientiToolStripMenuItem.Click
        ElencoClienti()

    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        System.Diagnostics.Process.Start("BackupDB.bat")
    End Sub

    Private Function CheckMdiChildren(ByVal formType As Type) As Boolean
        Dim formGiaApertta As Boolean = False
        If Me.MdiChildren.Length > 0 Then
            For Each children As Form In Me.MdiChildren
                If children.GetType.Equals(formType) Then
                    formGiaApertta = True
                    If children.WindowState = FormWindowState.Minimized Then
                        children.WindowState = FormWindowState.Normal
                    End If
                    children.Activate()
                    Exit For
                End If
            Next
        End If

        Return formGiaApertta
    End Function

    Private Sub InventarioArticoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventarioArticoliToolStripMenuItem.Click
        InventarioArticoli()
    End Sub

    Private Sub InventarioArticoli()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'frmSceltaArticolo
        If Not CheckMdiChildren(frmArticoliInventario.GetType) Then
            Dim FormArticoli As New frmArticoliInventario
            'FormArticoli.ModoSelezione = frmSceltaArticolo.TModoSelezione.MODIFICA
            FormArticoli.MdiParent = Me
            FormArticoli.Show()
        End If
    End Sub
    Private Sub frmMain2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GestioneProfiliUtente()
            ' IMPORTANTE IMPOSTAZIONE DELLA CONNECTION STRING
            Me.ConnectionString = mainDataModel.T20_articoliTableAdapter1.Connection.ConnectionString
        Catch ex As Exception
            FormsHelper.Error("Si e' verificato un errore: " + Chr(13) + ex.Message, Me.Text)
            Application.Exit()
        End Try
    End Sub

    Private Sub ConfiguraArticoli()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmConfiguratoreArticoli.GetType) Then
            Dim FormArticoli As New frmConfiguratoreArticoli
            FormArticoli.MdiParent = Me
            FormArticoli.Show()
        End If
    End Sub

    Private Function getDataModel(ByVal onlyFill As Boolean) As DataModel
        If Me.mainDataModel Is Nothing Then
            Me.mainDataModel = New DataModel()
        End If

        Me.mainDataModel.Fill()
        If Not onlyFill Then
            Me.mainDataModel.PreparaDati(Nothing)
        End If

        getDataModel = Me.mainDataModel
    End Function

    Private Sub ListinoRicambiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListinoRicambiToolStripMenuItem.Click
        ListinoRicambi()
    End Sub

    Private Sub RibbonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton1.Click
        About()
    End Sub

    Private Sub btnSituazione_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSituazione.Click
        ArticoliSituazione()
    End Sub

    Private Sub btnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventario.Click
        InventarioArticoli()
    End Sub

    Private Sub btnConfArticoli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfArticoli.Click
        ConfiguraArticoli()
    End Sub

    Private Sub btnConfGruppi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfGruppi.Click
        ConfiguraGruppi()
    End Sub

    Private Sub btnConfMacchine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfMacchine.Click
        ConfiguraMacchine()
    End Sub

    Private Sub btnMatricole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMatricole.Click
        ConfiguraMatricole()
    End Sub

    Private Sub btnPrezzi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrezzi.Click
        ConfiguraPrezzi()
    End Sub

    Private Sub btnAnaClienti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnaClienti.Click
        ElencoClienti()
    End Sub

    Private Sub btnAnaFornitori_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnaFornitori.Click
        ElencoFornitori()
    End Sub

    Private Sub btnOrdiniNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdiniNuovo.Click
        NuovoOrdineAcquisto()
    End Sub

    Private Sub btnOrdiniElenco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdiniElenco.Click
        ElencoOrdiniAcquisto()
    End Sub

    Private Sub btnOrdiniEvadiArticolo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdiniEvadiArticolo.Click
        EvasioneOrdiniAcquistoArticolo()
    End Sub

    Private Sub btnOrdiniEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrdiniEvadi.Click
        EvasioneOrdiniAcquisto()
    End Sub

    Private Sub btnRicambiNuovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicambiNuovo.Click
        NuovaCommessaRicambi()
    End Sub

    Private Sub btnRicambiElenco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicambiElenco.Click
        ElencoCommessaRicambi()
    End Sub

    Private Sub btnRicambiEvadi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicambiEvadi.Click
        EvasioneCommessaRicambi()
    End Sub

    Private Sub btnListinoRicambi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRicambiListino.Click
        ListinoRicambi()
    End Sub

    Private Sub btnCommessaNuova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommessaNuova.Click
        NuovaCommessaProduzione()

    End Sub

    Private Sub btnCommessaElenco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommessaElenco.Click
        ElencoCommesseProduzione()
    End Sub

    Private Sub btnSimula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimula.Click
        SimulazioneCommesseProduzione()
    End Sub

    Private Sub RibbonButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton9.Click
        StampaSituazioneMacchine()
    End Sub

    Private Sub RibbonButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton10.Click
        StampaSituazioneArticoli()
    End Sub

    Private Sub RibbonButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton11.Click
        StampaConfigurazioneMacchine()
    End Sub

    Private Sub RibbonButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton12.Click
        StampaElencoOrdiniAcquisto()
    End Sub

    Private Sub RibbonButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton13.Click
        StampaElencoCommesse()
    End Sub

    Private Sub RibbonButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton14.Click
        StampaArticoliInOrdine()
    End Sub

    Sub ConfiguraGruppi()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmConfiguratoreGruppi.GetType) Then
            Dim FormGruppi As New frmConfiguratoreGruppi
            FormGruppi.MdiParent = Me
            FormGruppi.Show()
        End If
    End Sub

    Sub ConfiguraMacchine()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmConfiguratoreMacchine.GetType) Then
            Dim FormMacchine As New frmConfiguratoreMacchine
            FormMacchine.MdiParent = Me
            FormMacchine.Show()
        End If
    End Sub

    Sub ConfiguraMatricole()
        If Not CheckMdiChildren(frmConfiguratoreMatricole.GetType) Then
            Dim formElencoMatricole As New frmConfiguratoreMatricole
            'formElencoArticoli.ModoSelezione = frmSceltaArticolo.TModoSelezione.MODIFICA
            formElencoMatricole.MdiParent = Me
            formElencoMatricole.Show()
        End If
    End Sub

    Sub ConfiguraPrezzi()
        If Not CheckMdiChildren(frmConfiguratorePrezzi.GetType) Then
            Dim formPrezzi As New frmConfiguratorePrezzi
            formPrezzi.MdiParent = Me
            formPrezzi.Show()
        End If
    End Sub

    Sub ElencoFornitori()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmAnagraficaFornitori.GetType) Then
            Dim FormFornitori As New frmAnagraficaFornitori
            FormFornitori.MdiParent = Me
            FormFornitori.Show()
        End If
    End Sub

    Sub ElencoClienti()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmAnagraficaClienti.GetType) Then
            Dim FormClienti As New frmAnagraficaClienti
            FormClienti.MdiParent = Me
            FormClienti.Show()
        End If
    End Sub

    Sub NuovoOrdineAcquisto()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmOrdiniFor.GetType) Then
            Dim FormOrdiniFor As New frmOrdiniFor
            FormOrdiniFor.MdiParent = Me
            FormOrdiniFor.Show()
        End If
    End Sub

    Sub ElencoOrdiniAcquisto()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmElencoOrdiniFor.GetType) Then
            Dim FormElencoOrdiniFor As New frmElencoOrdiniFor
            FormElencoOrdiniFor.MdiParent = Me
            FormElencoOrdiniFor.Show()
            FormElencoOrdiniFor.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Sub EvasioneOrdiniAcquistoArticolo()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmEvasioneArticoli.GetType) Then
            Dim FormEvasione As New frmEvasioneArticoli
            FormEvasione.MdiParent = Me
            FormEvasione.Show()
        End If
    End Sub
    Sub EvasioneOrdiniAcquisto()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmEvasioneOrdini.GetType) Then
            Dim FormEvasione As New frmEvasioneOrdini
            FormEvasione.MdiParent = Me
            FormEvasione.Show()
        End If
    End Sub

    Sub NuovaCommessaRicambi()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        'If Not CheckMdiChildren(frmOrdiniCli.GetType) Then
        '    Dim FormOrdiniCli As New frmOrdiniCli
        '    FormOrdiniCli.MdiParent = Me
        '    FormOrdiniCli.Show()
        'End If
        If Not CheckMdiChildren(frmOrdiniRicambiNuovo.GetType) Then
            Dim FormOrdiniCli As New frmOrdiniRicambiNuovo
            FormOrdiniCli.MdiParent = Me
            FormOrdiniCli.Show()
        End If
    End Sub

    Sub ElencoCommessaRicambi()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmOrdiniRicambiElenco.GetType) Then
            Dim frmOrdiniRicambiElenco As New frmOrdiniRicambiElenco
            frmOrdiniRicambiElenco.MdiParent = Me
            frmOrdiniRicambiElenco.Show()
            frmOrdiniRicambiElenco.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Sub EvasioneCommessaRicambi()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmEvasioneOrdiniRicambi.GetType) Then
            Dim FormEvasioneOrdiniCli As New frmEvasioneOrdiniRicambi
            FormEvasioneOrdiniCli.MdiParent = Me
            FormEvasioneOrdiniCli.Show()
            FormEvasioneOrdiniCli.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Sub ListinoRicambi()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmListinoRicambi.GetType) Then
            Dim frmListinoRicambi As New frmListinoRicambi
            frmListinoRicambi.MdiParent = Me
            frmListinoRicambi.Show()
        End If
    End Sub

    Sub NuovaCommessaProduzione()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmCommesseNuova.GetType) Then
            Dim FormIstanzeMacchine As New frmCommesseNuova
            FormIstanzeMacchine.MdiParent = Me
            FormIstanzeMacchine.Show()
        End If
    End Sub

    Sub ElencoCommesseProduzione()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmCommesseElenco.GetType) Then
            Dim FormElencoIstanzeMacchine As New frmCommesseElenco
            FormElencoIstanzeMacchine.MdiParent = Me
            FormElencoIstanzeMacchine.Show()
        End If
    End Sub

    Sub SimulazioneCommesseProduzione()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        If Not CheckMdiChildren(frmCommesseSimulazione.GetType) Then
            Dim FormElencoArticoli As New frmCommesseSimulazione
            FormElencoArticoli.MdiParent = Me
            FormElencoArticoli.Show()
        End If
    End Sub

    Sub StampaSituazioneMacchine()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        MessageBox.Show("Report da Aggiornare", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Exit Sub

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-IstanzeMacchine.rpt"))

        FormReport.Show()
    End Sub

    Sub StampaSituazioneArticoli()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        'FormReport.reportDocumentSource.Load("TEMAC-Articoli.rpt") ' = New Articoli
        'FormReport.reportDocumentSource.Load("REDA-Articoli.rpt") ' = New Articoli
        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-Articoli2.rpt"))
        FormReport.reportDocumentSource.SetDataSource(Me.getDataModel(False).GestioneProduzione2009DataSet1)

        FormReport.Show()
    End Sub

    Sub StampaConfigurazioneMacchine()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-ConfigurazioneMacchine.rpt"))

        FormReport.Show()
    End Sub

    Sub StampaElencoOrdiniAcquisto()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        'FormReport.reportDocumentSource.Load("TEMAC-OrdiniFor.rpt") ' = New OrdiniFor
        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-OrdiniFor.rpt"))

        FormReport.Show()
    End Sub

    Sub StampaElencoCommesse()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        'FormReport.reportDocumentSource.Load("REDA-Commesse.rpt") ' = New Commesse
        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-Commesse2.rpt"))
        FormReport.reportDocumentSource.SetDataSource(Me.getDataModel(True).GestioneProduzione2009DataSet1)

        FormReport.Show()
    End Sub
    Sub StampaArticoliInOrdine()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath("REDA-ArticoliInOrdine.rpt"))

        FormReport.Show()
    End Sub

    Sub GinuxArticoliImporta()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim test As New frmArticoliImporta()
        If Not CheckMdiChildren(test.GetType) Then
            Dim form As New frmArticoliImporta()
            form.Init(My.Settings.GestioneProduzione2009ConnectionString, My.Settings.GinuxPath)
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Sub GestioneDescrizioniCommerciali()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim test As New frmArticoliDescrizioniCommerciali()
        If Not CheckMdiChildren(test.GetType) Then
            Dim form As New frmArticoliDescrizioniCommerciali()
            form.Init(My.Settings.GestioneProduzione2009ConnectionString, My.Settings.GinuxPath)
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Sub OffertaNuova()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim test As New frmOffertaNuova()
        If Not CheckMdiChildren(test.GetType) Then
            Dim form As New frmOffertaNuova()
            'form.Init(My.Settings.GestioneProduzione2009ConnectionString, My.Settings.GinuxPath)
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Sub GestioneUtenti()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim test As New frmUtenti()
        If Not CheckMdiChildren(test.GetType) Then
            Dim form As New frmUtenti()
            form.Init(My.Settings.GestioneProduzione2009ConnectionString, My.Settings.GinuxPath)
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Sub GestioneProfiliUtente()

        Dim userName As String
        userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name
        statusUtente.Text = "Utente:" + userName

        Dim connectionString = My.Settings.GestioneProduzione2009ConnectionString
        Dim builder As SqlConnectionStringBuilder
        builder = New SqlConnectionStringBuilder(connectionString)
        statusConnessione.Text = "DataBase:" + builder.DataSource

        Dim utenti As GestioneProduzione2009DataSet.t30_utentiDataTable
        utenti = T30_utentiTableAdapter1.GetDataBy(userName)
        If (utenti.Rows.Count = 0) Then
            utenti.Addt30_utentiRow(userName, True, True, True, True, True, True, DateTime.Now, DateTime.Now, True)
            T30_utentiTableAdapter1.Update(utenti)
        End If

        frmMain.Profilo = utenti.Rows(0)
        frmMain.Utenti = T30_utentiTableAdapter1.GetData()

        Profilo.data_ultimo_accesso = DateTime.Now
        T30_utentiTableAdapter1.Update(utenti)

        TabArchivi.Visible = Profilo.menu_archivi
        TabOrdini.Visible = Profilo.menu_ordini
        TabRicambi.Visible = Profilo.menu_ricambi
        TabCommesse.Visible = Profilo.menu_commesse
        TabStampe.Visible = Profilo.menu_stampe
        TabOfferte.Visible = Profilo.menu_offerte
        tabConfigurazione.Visible = Profilo.menu_configurazione

        For Each tab As RibbonTab In RibbonMenu.Tabs
            If (tab.Visible) Then
                RibbonMenu.ActiveTab = tab
                Exit For
            End If
        Next

    End Sub


    Private Sub btnGinuxArticoliImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGinuxArticoliImport.Click
        GinuxArticoliImporta()
    End Sub

    Private Sub btnLingue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLingue.Click
        GestioneDescrizioniCommerciali()
    End Sub

    Private Sub RibbonMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonMenu.Click

    End Sub

    Private Sub RibbonButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOffertaNuova.Click
        'FormsHelper.Warn("Funzionalità ancora in fase di sviluppo.", Me.Text)
        OffertaNuova()
    End Sub

    Private Sub RibbonButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles panelAccessi.Click
        GestioneUtenti()
    End Sub


    Private Sub btnOffertaElenco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOffertaElenco.Click
        OffertaElenco()
    End Sub

    Sub OffertaElenco()
        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim test As New frmOffertaElenco()
        If Not CheckMdiChildren(test.GetType) Then
            Dim form As New frmOffertaElenco()
            'form.Init(My.Settings.GestioneProduzione2009ConnectionString, My.Settings.GinuxPath)
            form.MdiParent = Me
            form.Show()
        End If
    End Sub

    Private Sub RibbonButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonButton6.Click
        StampaArticoliInOrdine()
    End Sub
End Class