<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statusUtente = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusConnessione = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabArchivi = New System.Windows.Forms.RibbonTab
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel
        Me.btnSituazione = New System.Windows.Forms.RibbonButton
        Me.RibbonTextBox1 = New System.Windows.Forms.RibbonTextBox
        Me.btnInventario = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel
        Me.btnConfArticoli = New System.Windows.Forms.RibbonButton
        Me.btnConfGruppi = New System.Windows.Forms.RibbonButton
        Me.btnConfMacchine = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel
        Me.btnMatricole = New System.Windows.Forms.RibbonButton
        Me.btnPrezzi = New System.Windows.Forms.RibbonButton
        Me.btnLingue = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel13 = New System.Windows.Forms.RibbonPanel
        Me.btnGinuxArticoliImport = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel
        Me.btnAnaClienti = New System.Windows.Forms.RibbonButton
        Me.btnAnaFornitori = New System.Windows.Forms.RibbonButton
        Me.TabOrdini = New System.Windows.Forms.RibbonTab
        Me.panelAcquistoOrdini = New System.Windows.Forms.RibbonPanel
        Me.btnOrdiniNuovo = New System.Windows.Forms.RibbonButton
        Me.btnOrdiniElenco = New System.Windows.Forms.RibbonButton
        Me.panelAcquistoEvasione = New System.Windows.Forms.RibbonPanel
        Me.btnOrdiniEvadiArticolo = New System.Windows.Forms.RibbonButton
        Me.btnOrdiniEvadi = New System.Windows.Forms.RibbonButton
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel
        Me.RibbonButton6 = New System.Windows.Forms.RibbonButton
        Me.TabRicambi = New System.Windows.Forms.RibbonTab
        Me.panelRicambi = New System.Windows.Forms.RibbonPanel
        Me.btnRicambiNuovo = New System.Windows.Forms.RibbonButton
        Me.btnRicambiElenco = New System.Windows.Forms.RibbonButton
        Me.panelRicambiEvasione = New System.Windows.Forms.RibbonPanel
        Me.btnRicambiEvadi = New System.Windows.Forms.RibbonButton
        Me.panelRicambiListino = New System.Windows.Forms.RibbonPanel
        Me.btnRicambiListino = New System.Windows.Forms.RibbonButton
        Me.TabCommesse = New System.Windows.Forms.RibbonTab
        Me.panelCommesse = New System.Windows.Forms.RibbonPanel
        Me.btnCommessaNuova = New System.Windows.Forms.RibbonButton
        Me.btnCommessaElenco = New System.Windows.Forms.RibbonButton
        Me.panelSimulatore = New System.Windows.Forms.RibbonPanel
        Me.btnSimula = New System.Windows.Forms.RibbonButton
        Me.TabStampe = New System.Windows.Forms.RibbonTab
        Me.panelStampe = New System.Windows.Forms.RibbonPanel
        Me.RibbonButton9 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton10 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton11 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton12 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton13 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton14 = New System.Windows.Forms.RibbonButton
        Me.TabOfferte = New System.Windows.Forms.RibbonTab
        Me.panelOfferte = New System.Windows.Forms.RibbonPanel
        Me.btnOffertaNuova = New System.Windows.Forms.RibbonButton
        Me.btnOffertaElenco = New System.Windows.Forms.RibbonButton
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoArticoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioArticoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ConfiguratoreArticoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguratoreGruppiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguratoreMacchineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.ConfiguratoreMatricoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguratoreFormulePrezziToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.ElencoFornitoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoClientiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdiniAcquistoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuovoOrdineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoOrdiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.EvasionePerArticoloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EvasioneOrdiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdiniVenditaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuovoOrdineToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoOrdiniToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.EvasioneOrdineDiVenditaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator
        Me.ListinoRicambiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommesseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuovaCommessaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoCommesseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.SimulazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StampeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SituazioneMacchineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SituazioneArticoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigurazioneMacchineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoOrdiniAcquistoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoCommesseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ElencoArticoliInOrdineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.InformazioniSuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel
        Me.RibbonMenu = New System.Windows.Forms.Ribbon
        Me.tabConfigurazione = New System.Windows.Forms.RibbonTab
        Me.RibbonPanel15 = New System.Windows.Forms.RibbonPanel
        Me.panelAccessi = New System.Windows.Forms.RibbonButton
        Me.T30_utentiTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t30_utentiTableAdapter
        Me.GestioneProduzione2009DataSet1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.RibbonButtonList1 = New System.Windows.Forms.RibbonButtonList
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton4 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton5 = New System.Windows.Forms.RibbonButton
        Me.RibbonButton7 = New System.Windows.Forms.RibbonButton
        Me.mainDataModel = New GestioneProduzione.DataModel(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusUtente, Me.statusConnessione})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 351)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(981, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusUtente
        '
        Me.statusUtente.Name = "statusUtente"
        Me.statusUtente.Size = New System.Drawing.Size(40, 17)
        Me.statusUtente.Text = "Utenet"
        '
        'statusConnessione
        '
        Me.statusConnessione.Name = "statusConnessione"
        Me.statusConnessione.Size = New System.Drawing.Size(61, 17)
        Me.statusConnessione.Text = "Connection"
        '
        'TabArchivi
        '
        Me.TabArchivi.Panels.Add(Me.RibbonPanel1)
        Me.TabArchivi.Panels.Add(Me.RibbonPanel2)
        Me.TabArchivi.Panels.Add(Me.RibbonPanel3)
        Me.TabArchivi.Panels.Add(Me.RibbonPanel13)
        Me.TabArchivi.Panels.Add(Me.RibbonPanel4)
        Me.TabArchivi.Text = "Archivi"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnSituazione)
        Me.RibbonPanel1.Items.Add(Me.btnInventario)
        Me.RibbonPanel1.Text = "Articoli"
        '
        'btnSituazione
        '
        Me.btnSituazione.DropDownItems.Add(Me.RibbonTextBox1)
        Me.btnSituazione.Image = Global.GestioneProduzione.My.Resources.Resources.games_difficult
        Me.btnSituazione.SmallImage = CType(resources.GetObject("btnSituazione.SmallImage"), System.Drawing.Image)
        Me.btnSituazione.Text = "Situazione"
        '
        'RibbonTextBox1
        '
        Me.RibbonTextBox1.Text = "RibbonTextBox1"
        Me.RibbonTextBox1.TextBoxText = Nothing
        '
        'btnInventario
        '
        Me.btnInventario.Image = Global.GestioneProduzione.My.Resources.Resources.edit_paste
        Me.btnInventario.SmallImage = CType(resources.GetObject("btnInventario.SmallImage"), System.Drawing.Image)
        Me.btnInventario.Text = "Inventario"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.btnConfArticoli)
        Me.RibbonPanel2.Items.Add(Me.btnConfGruppi)
        Me.RibbonPanel2.Items.Add(Me.btnConfMacchine)
        Me.RibbonPanel2.Text = "Configuratore"
        '
        'btnConfArticoli
        '
        Me.btnConfArticoli.Image = Global.GestioneProduzione.My.Resources.Resources.ledyellow1
        Me.btnConfArticoli.SmallImage = CType(resources.GetObject("btnConfArticoli.SmallImage"), System.Drawing.Image)
        Me.btnConfArticoli.Text = "Articoli"
        '
        'btnConfGruppi
        '
        Me.btnConfGruppi.Image = Global.GestioneProduzione.My.Resources.Resources.ledorange1
        Me.btnConfGruppi.SmallImage = CType(resources.GetObject("btnConfGruppi.SmallImage"), System.Drawing.Image)
        Me.btnConfGruppi.Text = "Gruppi"
        '
        'btnConfMacchine
        '
        Me.btnConfMacchine.Image = Global.GestioneProduzione.My.Resources.Resources.ledpurple1
        Me.btnConfMacchine.SmallImage = CType(resources.GetObject("btnConfMacchine.SmallImage"), System.Drawing.Image)
        Me.btnConfMacchine.Text = "Macchine"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.btnMatricole)
        Me.RibbonPanel3.Items.Add(Me.btnPrezzi)
        Me.RibbonPanel3.Items.Add(Me.btnLingue)
        Me.RibbonPanel3.Text = "Ricambi"
        '
        'btnMatricole
        '
        Me.btnMatricole.Image = Global.GestioneProduzione.My.Resources.Resources.db_comit
        Me.btnMatricole.SmallImage = CType(resources.GetObject("btnMatricole.SmallImage"), System.Drawing.Image)
        Me.btnMatricole.Text = "Matricole"
        '
        'btnPrezzi
        '
        Me.btnPrezzi.Image = Global.GestioneProduzione.My.Resources.Resources.kodo
        Me.btnPrezzi.SmallImage = CType(resources.GetObject("btnPrezzi.SmallImage"), System.Drawing.Image)
        Me.btnPrezzi.Text = "Formule Prezzi"
        '
        'btnLingue
        '
        Me.btnLingue.Image = Global.GestioneProduzione.My.Resources.Resources.list_add_font
        Me.btnLingue.SmallImage = CType(resources.GetObject("btnLingue.SmallImage"), System.Drawing.Image)
        Me.btnLingue.Text = "Descrizioni Commerc."
        '
        'RibbonPanel13
        '
        Me.RibbonPanel13.Items.Add(Me.btnGinuxArticoliImport)
        Me.RibbonPanel13.Text = "Ginux"
        '
        'btnGinuxArticoliImport
        '
        Me.btnGinuxArticoliImport.Image = CType(resources.GetObject("btnGinuxArticoliImport.Image"), System.Drawing.Image)
        Me.btnGinuxArticoliImport.SmallImage = CType(resources.GetObject("btnGinuxArticoliImport.SmallImage"), System.Drawing.Image)
        Me.btnGinuxArticoliImport.Text = "Importa Prezzi"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.btnAnaClienti)
        Me.RibbonPanel4.Items.Add(Me.btnAnaFornitori)
        Me.RibbonPanel4.Text = "Anagrafiche"
        '
        'btnAnaClienti
        '
        Me.btnAnaClienti.Image = Global.GestioneProduzione.My.Resources.Resources.edit_user
        Me.btnAnaClienti.SmallImage = CType(resources.GetObject("btnAnaClienti.SmallImage"), System.Drawing.Image)
        Me.btnAnaClienti.Text = "Clienti"
        '
        'btnAnaFornitori
        '
        Me.btnAnaFornitori.Image = Global.GestioneProduzione.My.Resources.Resources.kuser
        Me.btnAnaFornitori.SmallImage = CType(resources.GetObject("btnAnaFornitori.SmallImage"), System.Drawing.Image)
        Me.btnAnaFornitori.Text = "Fornitori"
        '
        'TabOrdini
        '
        Me.TabOrdini.Panels.Add(Me.panelAcquistoOrdini)
        Me.TabOrdini.Panels.Add(Me.panelAcquistoEvasione)
        Me.TabOrdini.Panels.Add(Me.RibbonPanel5)
        Me.TabOrdini.Text = "Ordini Acquisto"
        '
        'panelAcquistoOrdini
        '
        Me.panelAcquistoOrdini.Items.Add(Me.btnOrdiniNuovo)
        Me.panelAcquistoOrdini.Items.Add(Me.btnOrdiniElenco)
        Me.panelAcquistoOrdini.Text = "Ordini"
        '
        'btnOrdiniNuovo
        '
        Me.btnOrdiniNuovo.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.btnOrdiniNuovo.SmallImage = CType(resources.GetObject("btnOrdiniNuovo.SmallImage"), System.Drawing.Image)
        Me.btnOrdiniNuovo.Text = "Nuovo Ordine"
        '
        'btnOrdiniElenco
        '
        Me.btnOrdiniElenco.Image = Global.GestioneProduzione.My.Resources.Resources.view_list_details_32
        Me.btnOrdiniElenco.SmallImage = CType(resources.GetObject("btnOrdiniElenco.SmallImage"), System.Drawing.Image)
        Me.btnOrdiniElenco.Text = "Elenco Ordini"
        '
        'panelAcquistoEvasione
        '
        Me.panelAcquistoEvasione.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right
        Me.panelAcquistoEvasione.Items.Add(Me.btnOrdiniEvadiArticolo)
        Me.panelAcquistoEvasione.Items.Add(Me.btnOrdiniEvadi)
        Me.panelAcquistoEvasione.Text = "Evasione"
        '
        'btnOrdiniEvadiArticolo
        '
        Me.btnOrdiniEvadiArticolo.Image = CType(resources.GetObject("btnOrdiniEvadiArticolo.Image"), System.Drawing.Image)
        Me.btnOrdiniEvadiArticolo.SmallImage = Global.GestioneProduzione.My.Resources.Resources.ledyellow
        Me.btnOrdiniEvadiArticolo.Text = "Evasione per Articolo"
        '
        'btnOrdiniEvadi
        '
        Me.btnOrdiniEvadi.Image = CType(resources.GetObject("btnOrdiniEvadi.Image"), System.Drawing.Image)
        Me.btnOrdiniEvadi.SmallImage = Global.GestioneProduzione.My.Resources.Resources.format_list_ordered_16
        Me.btnOrdiniEvadi.Text = "Evasione per Ordine"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.RibbonButton6)
        Me.RibbonPanel5.Text = Nothing
        '
        'RibbonButton6
        '
        Me.RibbonButton6.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton6.SmallImage = CType(resources.GetObject("RibbonButton6.SmallImage"), System.Drawing.Image)
        Me.RibbonButton6.Text = "Articoli in Ordine"
        '
        'TabRicambi
        '
        Me.TabRicambi.Panels.Add(Me.panelRicambi)
        Me.TabRicambi.Panels.Add(Me.panelRicambiEvasione)
        Me.TabRicambi.Panels.Add(Me.panelRicambiListino)
        Me.TabRicambi.Text = "Ricambi"
        '
        'panelRicambi
        '
        Me.panelRicambi.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right
        Me.panelRicambi.Items.Add(Me.btnRicambiNuovo)
        Me.panelRicambi.Items.Add(Me.btnRicambiElenco)
        Me.panelRicambi.Text = "Commesse Ricambi"
        '
        'btnRicambiNuovo
        '
        Me.btnRicambiNuovo.Image = CType(resources.GetObject("btnRicambiNuovo.Image"), System.Drawing.Image)
        Me.btnRicambiNuovo.SmallImage = Global.GestioneProduzione.My.Resources.Resources.document_new_22
        Me.btnRicambiNuovo.Text = "Nuova Commessa Ricambi"
        '
        'btnRicambiElenco
        '
        Me.btnRicambiElenco.Image = CType(resources.GetObject("btnRicambiElenco.Image"), System.Drawing.Image)
        Me.btnRicambiElenco.SmallImage = Global.GestioneProduzione.My.Resources.Resources.list_22
        Me.btnRicambiElenco.Text = "Elenco Commesse Ricambi"
        '
        'panelRicambiEvasione
        '
        Me.panelRicambiEvasione.FlowsTo = System.Windows.Forms.RibbonPanelFlowDirection.Right
        Me.panelRicambiEvasione.Items.Add(Me.btnRicambiEvadi)
        Me.panelRicambiEvasione.Text = "Evasione"
        '
        'btnRicambiEvadi
        '
        Me.btnRicambiEvadi.Image = CType(resources.GetObject("btnRicambiEvadi.Image"), System.Drawing.Image)
        Me.btnRicambiEvadi.SmallImage = Global.GestioneProduzione.My.Resources.Resources.format_list_ordered_22
        Me.btnRicambiEvadi.Text = "Evasione Commesse Ricambi"
        '
        'panelRicambiListino
        '
        Me.panelRicambiListino.Items.Add(Me.btnRicambiListino)
        Me.panelRicambiListino.Text = ""
        '
        'btnRicambiListino
        '
        Me.btnRicambiListino.Image = Global.GestioneProduzione.My.Resources.Resources.book_32
        Me.btnRicambiListino.SmallImage = CType(resources.GetObject("btnRicambiListino.SmallImage"), System.Drawing.Image)
        Me.btnRicambiListino.Text = "Listino"
        '
        'TabCommesse
        '
        Me.TabCommesse.Panels.Add(Me.panelCommesse)
        Me.TabCommesse.Panels.Add(Me.panelSimulatore)
        Me.TabCommesse.Text = "Commesse"
        '
        'panelCommesse
        '
        Me.panelCommesse.Items.Add(Me.btnCommessaNuova)
        Me.panelCommesse.Items.Add(Me.btnCommessaElenco)
        Me.panelCommesse.Text = "Commesse"
        '
        'btnCommessaNuova
        '
        Me.btnCommessaNuova.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.btnCommessaNuova.SmallImage = CType(resources.GetObject("btnCommessaNuova.SmallImage"), System.Drawing.Image)
        Me.btnCommessaNuova.Text = "Nuova"
        '
        'btnCommessaElenco
        '
        Me.btnCommessaElenco.Image = Global.GestioneProduzione.My.Resources.Resources.view_list_details_32
        Me.btnCommessaElenco.SmallImage = CType(resources.GetObject("btnCommessaElenco.SmallImage"), System.Drawing.Image)
        Me.btnCommessaElenco.Text = "Elenco"
        '
        'panelSimulatore
        '
        Me.panelSimulatore.Items.Add(Me.btnSimula)
        Me.panelSimulatore.Text = "Simulatore"
        '
        'btnSimula
        '
        Me.btnSimula.Image = Global.GestioneProduzione.My.Resources.Resources.exec
        Me.btnSimula.SmallImage = CType(resources.GetObject("btnSimula.SmallImage"), System.Drawing.Image)
        Me.btnSimula.Text = "Simulazione"
        '
        'TabStampe
        '
        Me.TabStampe.Panels.Add(Me.panelStampe)
        Me.TabStampe.Text = "Stampe"
        '
        'panelStampe
        '
        Me.panelStampe.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.panelStampe.Items.Add(Me.RibbonButton9)
        Me.panelStampe.Items.Add(Me.RibbonButton10)
        Me.panelStampe.Items.Add(Me.RibbonButton11)
        Me.panelStampe.Items.Add(Me.RibbonButton12)
        Me.panelStampe.Items.Add(Me.RibbonButton13)
        Me.panelStampe.Items.Add(Me.RibbonButton14)
        Me.panelStampe.Text = "Stampe"
        '
        'RibbonButton9
        '
        Me.RibbonButton9.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton9.SmallImage = CType(resources.GetObject("RibbonButton9.SmallImage"), System.Drawing.Image)
        Me.RibbonButton9.Text = "Situazione Macchine"
        Me.RibbonButton9.Visible = False
        '
        'RibbonButton10
        '
        Me.RibbonButton10.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton10.SmallImage = CType(resources.GetObject("RibbonButton10.SmallImage"), System.Drawing.Image)
        Me.RibbonButton10.Text = "Situazione Articoli"
        '
        'RibbonButton11
        '
        Me.RibbonButton11.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton11.SmallImage = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton11.Text = "Configurazione Macchine"
        '
        'RibbonButton12
        '
        Me.RibbonButton12.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton12.SmallImage = CType(resources.GetObject("RibbonButton12.SmallImage"), System.Drawing.Image)
        Me.RibbonButton12.Text = "Ordini Acquisto"
        '
        'RibbonButton13
        '
        Me.RibbonButton13.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton13.SmallImage = CType(resources.GetObject("RibbonButton13.SmallImage"), System.Drawing.Image)
        Me.RibbonButton13.Text = "Elenco Commesse"
        '
        'RibbonButton14
        '
        Me.RibbonButton14.Image = Global.GestioneProduzione.My.Resources.Resources.document_print
        Me.RibbonButton14.SmallImage = CType(resources.GetObject("RibbonButton14.SmallImage"), System.Drawing.Image)
        Me.RibbonButton14.Text = "Articoli in Ordine"
        '
        'TabOfferte
        '
        Me.TabOfferte.Panels.Add(Me.panelOfferte)
        Me.TabOfferte.Text = "Offerte"
        '
        'panelOfferte
        '
        Me.panelOfferte.Items.Add(Me.btnOffertaNuova)
        Me.panelOfferte.Items.Add(Me.btnOffertaElenco)
        Me.panelOfferte.Text = "Offerte"
        '
        'btnOffertaNuova
        '
        Me.btnOffertaNuova.Image = Global.GestioneProduzione.My.Resources.Resources.accessories_text_editor_32
        Me.btnOffertaNuova.SmallImage = CType(resources.GetObject("btnOffertaNuova.SmallImage"), System.Drawing.Image)
        Me.btnOffertaNuova.Text = "Nuova Offerta"
        '
        'btnOffertaElenco
        '
        Me.btnOffertaElenco.Image = Global.GestioneProduzione.My.Resources.Resources.view_list_details_32
        Me.btnOffertaElenco.SmallImage = CType(resources.GetObject("btnOffertaElenco.SmallImage"), System.Drawing.Image)
        Me.btnOffertaElenco.Text = "Elenco Offerte"
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 157)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(981, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchiviToolStripMenuItem
        '
        Me.ArchiviToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ElencoArticoliToolStripMenuItem, Me.InventarioArticoliToolStripMenuItem, Me.ToolStripMenuItem1, Me.ConfiguratoreArticoliToolStripMenuItem, Me.ConfiguratoreGruppiToolStripMenuItem, Me.ConfiguratoreMacchineToolStripMenuItem, Me.ToolStripMenuItem2, Me.ConfiguratoreMatricoleToolStripMenuItem, Me.ConfiguratoreFormulePrezziToolStripMenuItem, Me.ToolStripMenuItem3, Me.ElencoFornitoriToolStripMenuItem, Me.ElencoClientiToolStripMenuItem, Me.ToolStripMenuItem4, Me.BackupDatabaseToolStripMenuItem, Me.ToolStripMenuItem5, Me.EsciToolStripMenuItem})
        Me.ArchiviToolStripMenuItem.Name = "ArchiviToolStripMenuItem"
        Me.ArchiviToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ArchiviToolStripMenuItem.Text = "&Archivi"
        Me.ArchiviToolStripMenuItem.Visible = False
        '
        'ElencoArticoliToolStripMenuItem
        '
        Me.ElencoArticoliToolStripMenuItem.Name = "ElencoArticoliToolStripMenuItem"
        Me.ElencoArticoliToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ElencoArticoliToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ElencoArticoliToolStripMenuItem.Text = "&Elenco e Situazione Articoli e Gruppi"
        '
        'InventarioArticoliToolStripMenuItem
        '
        Me.InventarioArticoliToolStripMenuItem.Name = "InventarioArticoliToolStripMenuItem"
        Me.InventarioArticoliToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.InventarioArticoliToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.InventarioArticoliToolStripMenuItem.Text = "&Inventario Articoli"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(286, 6)
        '
        'ConfiguratoreArticoliToolStripMenuItem
        '
        Me.ConfiguratoreArticoliToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledyellow
        Me.ConfiguratoreArticoliToolStripMenuItem.Name = "ConfiguratoreArticoliToolStripMenuItem"
        Me.ConfiguratoreArticoliToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ConfiguratoreArticoliToolStripMenuItem.Text = "Configuratore &Articoli"
        '
        'ConfiguratoreGruppiToolStripMenuItem
        '
        Me.ConfiguratoreGruppiToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledorange
        Me.ConfiguratoreGruppiToolStripMenuItem.Name = "ConfiguratoreGruppiToolStripMenuItem"
        Me.ConfiguratoreGruppiToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ConfiguratoreGruppiToolStripMenuItem.Text = "Configuratore &Gruppi"
        '
        'ConfiguratoreMacchineToolStripMenuItem
        '
        Me.ConfiguratoreMacchineToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledpurple
        Me.ConfiguratoreMacchineToolStripMenuItem.Name = "ConfiguratoreMacchineToolStripMenuItem"
        Me.ConfiguratoreMacchineToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ConfiguratoreMacchineToolStripMenuItem.Text = "Configuratore &Macchine"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(286, 6)
        '
        'ConfiguratoreMatricoleToolStripMenuItem
        '
        Me.ConfiguratoreMatricoleToolStripMenuItem.Name = "ConfiguratoreMatricoleToolStripMenuItem"
        Me.ConfiguratoreMatricoleToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ConfiguratoreMatricoleToolStripMenuItem.Text = "Configuratore Ma&tricole"
        '
        'ConfiguratoreFormulePrezziToolStripMenuItem
        '
        Me.ConfiguratoreFormulePrezziToolStripMenuItem.Name = "ConfiguratoreFormulePrezziToolStripMenuItem"
        Me.ConfiguratoreFormulePrezziToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ConfiguratoreFormulePrezziToolStripMenuItem.Text = "Configuratore &Formule Prezzi"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(286, 6)
        '
        'ElencoFornitoriToolStripMenuItem
        '
        Me.ElencoFornitoriToolStripMenuItem.Name = "ElencoFornitoriToolStripMenuItem"
        Me.ElencoFornitoriToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ElencoFornitoriToolStripMenuItem.Text = "Elenco Fornitori"
        '
        'ElencoClientiToolStripMenuItem
        '
        Me.ElencoClientiToolStripMenuItem.Name = "ElencoClientiToolStripMenuItem"
        Me.ElencoClientiToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.ElencoClientiToolStripMenuItem.Text = "Elenco Clienti"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(286, 6)
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "&Backup Database"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(286, 6)
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(289, 22)
        Me.EsciToolStripMenuItem.Text = "Esci"
        '
        'OrdiniAcquistoToolStripMenuItem
        '
        Me.OrdiniAcquistoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoOrdineToolStripMenuItem, Me.ElencoOrdiniToolStripMenuItem, Me.ToolStripMenuItem6, Me.EvasionePerArticoloToolStripMenuItem, Me.EvasioneOrdiniToolStripMenuItem})
        Me.OrdiniAcquistoToolStripMenuItem.Name = "OrdiniAcquistoToolStripMenuItem"
        Me.OrdiniAcquistoToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.OrdiniAcquistoToolStripMenuItem.Text = "&Ordini Acquisto"
        Me.OrdiniAcquistoToolStripMenuItem.Visible = False
        '
        'NuovoOrdineToolStripMenuItem
        '
        Me.NuovoOrdineToolStripMenuItem.Name = "NuovoOrdineToolStripMenuItem"
        Me.NuovoOrdineToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NuovoOrdineToolStripMenuItem.Text = "&Nuovo Ordine"
        '
        'ElencoOrdiniToolStripMenuItem
        '
        Me.ElencoOrdiniToolStripMenuItem.Name = "ElencoOrdiniToolStripMenuItem"
        Me.ElencoOrdiniToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ElencoOrdiniToolStripMenuItem.Text = "&Elenco Ordini"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(183, 6)
        '
        'EvasionePerArticoloToolStripMenuItem
        '
        Me.EvasionePerArticoloToolStripMenuItem.Name = "EvasionePerArticoloToolStripMenuItem"
        Me.EvasionePerArticoloToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EvasionePerArticoloToolStripMenuItem.Text = "E&vasione Per Articolo"
        '
        'EvasioneOrdiniToolStripMenuItem
        '
        Me.EvasioneOrdiniToolStripMenuItem.Name = "EvasioneOrdiniToolStripMenuItem"
        Me.EvasioneOrdiniToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EvasioneOrdiniToolStripMenuItem.Text = "Evasione &Ordini"
        '
        'OrdiniVenditaToolStripMenuItem
        '
        Me.OrdiniVenditaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoOrdineToolStripMenuItem1, Me.ElencoOrdiniToolStripMenuItem1, Me.ToolStripMenuItem7, Me.EvasioneOrdineDiVenditaToolStripMenuItem, Me.ToolStripMenuItem10, Me.ListinoRicambiToolStripMenuItem})
        Me.OrdiniVenditaToolStripMenuItem.Name = "OrdiniVenditaToolStripMenuItem"
        Me.OrdiniVenditaToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.OrdiniVenditaToolStripMenuItem.Text = "&Ricambi"
        Me.OrdiniVenditaToolStripMenuItem.Visible = False
        '
        'NuovoOrdineToolStripMenuItem1
        '
        Me.NuovoOrdineToolStripMenuItem1.Name = "NuovoOrdineToolStripMenuItem1"
        Me.NuovoOrdineToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.NuovoOrdineToolStripMenuItem1.Text = "Nuova Commessa Ricambi"
        '
        'ElencoOrdiniToolStripMenuItem1
        '
        Me.ElencoOrdiniToolStripMenuItem1.Name = "ElencoOrdiniToolStripMenuItem1"
        Me.ElencoOrdiniToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.ElencoOrdiniToolStripMenuItem1.Text = "Elenco Commesse Ricambi"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(218, 6)
        '
        'EvasioneOrdineDiVenditaToolStripMenuItem
        '
        Me.EvasioneOrdineDiVenditaToolStripMenuItem.Name = "EvasioneOrdineDiVenditaToolStripMenuItem"
        Me.EvasioneOrdineDiVenditaToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.EvasioneOrdineDiVenditaToolStripMenuItem.Text = "Evasione Commessa Ricambi"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(218, 6)
        '
        'ListinoRicambiToolStripMenuItem
        '
        Me.ListinoRicambiToolStripMenuItem.Name = "ListinoRicambiToolStripMenuItem"
        Me.ListinoRicambiToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ListinoRicambiToolStripMenuItem.Text = "Listino Ricambi"
        '
        'CommesseToolStripMenuItem
        '
        Me.CommesseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovaCommessaToolStripMenuItem, Me.ElencoCommesseToolStripMenuItem, Me.ToolStripMenuItem8, Me.SimulazioneToolStripMenuItem})
        Me.CommesseToolStripMenuItem.Name = "CommesseToolStripMenuItem"
        Me.CommesseToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CommesseToolStripMenuItem.Text = "&Commesse"
        Me.CommesseToolStripMenuItem.Visible = False
        '
        'NuovaCommessaToolStripMenuItem
        '
        Me.NuovaCommessaToolStripMenuItem.Name = "NuovaCommessaToolStripMenuItem"
        Me.NuovaCommessaToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NuovaCommessaToolStripMenuItem.Text = "&Nuova Commessa"
        '
        'ElencoCommesseToolStripMenuItem
        '
        Me.ElencoCommesseToolStripMenuItem.Name = "ElencoCommesseToolStripMenuItem"
        Me.ElencoCommesseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ElencoCommesseToolStripMenuItem.Text = "&Elenco Commesse"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(167, 6)
        '
        'SimulazioneToolStripMenuItem
        '
        Me.SimulazioneToolStripMenuItem.Name = "SimulazioneToolStripMenuItem"
        Me.SimulazioneToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SimulazioneToolStripMenuItem.Text = "Simulazione"
        '
        'StampeToolStripMenuItem
        '
        Me.StampeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SituazioneMacchineToolStripMenuItem, Me.SituazioneArticoliToolStripMenuItem, Me.ConfigurazioneMacchineToolStripMenuItem, Me.ElencoOrdiniAcquistoToolStripMenuItem, Me.ElencoCommesseToolStripMenuItem1, Me.ElencoArticoliInOrdineToolStripMenuItem})
        Me.StampeToolStripMenuItem.Name = "StampeToolStripMenuItem"
        Me.StampeToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.StampeToolStripMenuItem.Text = "&Stampe"
        Me.StampeToolStripMenuItem.Visible = False
        '
        'SituazioneMacchineToolStripMenuItem
        '
        Me.SituazioneMacchineToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.SituazioneMacchineToolStripMenuItem.Name = "SituazioneMacchineToolStripMenuItem"
        Me.SituazioneMacchineToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SituazioneMacchineToolStripMenuItem.Text = "Situazione Macchine"
        '
        'SituazioneArticoliToolStripMenuItem
        '
        Me.SituazioneArticoliToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.SituazioneArticoliToolStripMenuItem.Name = "SituazioneArticoliToolStripMenuItem"
        Me.SituazioneArticoliToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.SituazioneArticoliToolStripMenuItem.Text = "Situazione Articoli"
        '
        'ConfigurazioneMacchineToolStripMenuItem
        '
        Me.ConfigurazioneMacchineToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.ConfigurazioneMacchineToolStripMenuItem.Name = "ConfigurazioneMacchineToolStripMenuItem"
        Me.ConfigurazioneMacchineToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ConfigurazioneMacchineToolStripMenuItem.Text = "Configurazione Macchine"
        '
        'ElencoOrdiniAcquistoToolStripMenuItem
        '
        Me.ElencoOrdiniAcquistoToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.ElencoOrdiniAcquistoToolStripMenuItem.Name = "ElencoOrdiniAcquistoToolStripMenuItem"
        Me.ElencoOrdiniAcquistoToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ElencoOrdiniAcquistoToolStripMenuItem.Text = "Elenco Ordini Acquisto"
        '
        'ElencoCommesseToolStripMenuItem1
        '
        Me.ElencoCommesseToolStripMenuItem1.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.ElencoCommesseToolStripMenuItem1.Name = "ElencoCommesseToolStripMenuItem1"
        Me.ElencoCommesseToolStripMenuItem1.Size = New System.Drawing.Size(204, 22)
        Me.ElencoCommesseToolStripMenuItem1.Text = "Elenco Commesse"
        '
        'ElencoArticoliInOrdineToolStripMenuItem
        '
        Me.ElencoArticoliInOrdineToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.printer
        Me.ElencoArticoliInOrdineToolStripMenuItem.Name = "ElencoArticoliInOrdineToolStripMenuItem"
        Me.ElencoArticoliInOrdineToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ElencoArticoliInOrdineToolStripMenuItem.Text = "Elenco Articoli in Ordine"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniSuToolStripMenuItem})
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem9.Text = "&?"
        Me.ToolStripMenuItem9.Visible = False
        '
        'InformazioniSuToolStripMenuItem
        '
        Me.InformazioniSuToolStripMenuItem.Name = "InformazioniSuToolStripMenuItem"
        Me.InformazioniSuToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.InformazioniSuToolStripMenuItem.Text = "Informazioni su..."
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(150, 151)
        '
        'RibbonMenu
        '
        Me.RibbonMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonMenu.Location = New System.Drawing.Point(0, 0)
        Me.RibbonMenu.Minimized = False
        Me.RibbonMenu.Name = "RibbonMenu"
        '
        '
        '
        Me.RibbonMenu.OrbDropDown.BorderRoundness = 8
        Me.RibbonMenu.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.RibbonMenu.OrbDropDown.Name = ""
        Me.RibbonMenu.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.RibbonMenu.OrbDropDown.TabIndex = 0
        Me.RibbonMenu.OrbImage = Nothing
        Me.RibbonMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.RibbonMenu.OrbText = "?"
        Me.RibbonMenu.OrbVisible = False
        '
        '
        '
        Me.RibbonMenu.QuickAcessToolbar.Text = ""
        Me.RibbonMenu.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.RibbonMenu.Size = New System.Drawing.Size(981, 157)
        Me.RibbonMenu.TabIndex = 5
        Me.RibbonMenu.Tabs.Add(Me.TabArchivi)
        Me.RibbonMenu.Tabs.Add(Me.TabOrdini)
        Me.RibbonMenu.Tabs.Add(Me.TabCommesse)
        Me.RibbonMenu.Tabs.Add(Me.TabOfferte)
        Me.RibbonMenu.Tabs.Add(Me.TabRicambi)
        Me.RibbonMenu.Tabs.Add(Me.TabStampe)
        Me.RibbonMenu.Tabs.Add(Me.tabConfigurazione)
        Me.RibbonMenu.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.RibbonMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'tabConfigurazione
        '
        Me.tabConfigurazione.Panels.Add(Me.RibbonPanel15)
        Me.tabConfigurazione.Text = "Configurazione"
        '
        'RibbonPanel15
        '
        Me.RibbonPanel15.Items.Add(Me.panelAccessi)
        Me.RibbonPanel15.Text = "Accessi"
        '
        'panelAccessi
        '
        Me.panelAccessi.Image = Global.GestioneProduzione.My.Resources.Resources.edit_user
        Me.panelAccessi.SmallImage = Global.GestioneProduzione.My.Resources.Resources.edit_user
        Me.panelAccessi.Text = "Utenti"
        '
        'T30_utentiTableAdapter1
        '
        Me.T30_utentiTableAdapter1.ClearBeforeFill = True
        '
        'GestioneProduzione2009DataSet1
        '
        Me.GestioneProduzione2009DataSet1.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonButtonList1
        '
        Me.RibbonButtonList1.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large
        Me.RibbonButtonList1.FlowToBottom = False
        Me.RibbonButtonList1.ItemsSizeInDropwDownMode = New System.Drawing.Size(7, 5)
        Me.RibbonButtonList1.Text = "RibbonButtonList1"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.DropDownItems.Add(Me.RibbonButton2)
        Me.RibbonButton1.DropDownItems.Add(Me.RibbonButtonList1)
        Me.RibbonButton1.Image = Global.GestioneProduzione.My.Resources.Resources.help_about
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = Global.GestioneProduzione.My.Resources.Resources.help_about
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "RibbonButton2"
        '
        'RibbonButton3
        '
        Me.RibbonButton3.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "Nuova"
        '
        'RibbonButton4
        '
        Me.RibbonButton4.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.RibbonButton4.SmallImage = CType(resources.GetObject("RibbonButton4.SmallImage"), System.Drawing.Image)
        Me.RibbonButton4.Text = "Nuova"
        '
        'RibbonButton5
        '
        Me.RibbonButton5.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.RibbonButton5.SmallImage = CType(resources.GetObject("RibbonButton5.SmallImage"), System.Drawing.Image)
        Me.RibbonButton5.Text = "Nuova"
        '
        'RibbonButton7
        '
        Me.RibbonButton7.Image = Global.GestioneProduzione.My.Resources.Resources.document_new_32
        Me.RibbonButton7.SmallImage = CType(resources.GetObject("RibbonButton7.SmallImage"), System.Drawing.Image)
        Me.RibbonButton7.Text = "Nuova"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 373)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.RibbonMenu)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Gestione Produzione 2009"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.GestioneProduzione2009DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TabArchivi As System.Windows.Forms.RibbonTab
    Friend WithEvents TabOrdini As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel1 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnSituazione As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonTextBox1 As System.Windows.Forms.RibbonTextBox
    Friend WithEvents btnInventario As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel2 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnConfArticoli As System.Windows.Forms.RibbonButton
    Friend WithEvents btnConfGruppi As System.Windows.Forms.RibbonButton
    Friend WithEvents btnConfMacchine As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel3 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonPanel4 As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelAcquistoOrdini As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelAcquistoEvasione As System.Windows.Forms.RibbonPanel
    Friend WithEvents TabRicambi As System.Windows.Forms.RibbonTab
    Friend WithEvents TabCommesse As System.Windows.Forms.RibbonTab
    Friend WithEvents TabStampe As System.Windows.Forms.RibbonTab
    Friend WithEvents panelRicambi As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelRicambiEvasione As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelRicambiListino As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelCommesse As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnCommessaNuova As System.Windows.Forms.RibbonButton
    Friend WithEvents btnCommessaElenco As System.Windows.Forms.RibbonButton
    Friend WithEvents panelSimulatore As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnSimula As System.Windows.Forms.RibbonButton
    Friend WithEvents panelStampe As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonButton9 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton10 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton11 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton12 As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOrdiniNuovo As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOrdiniElenco As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOrdiniEvadiArticolo As System.Windows.Forms.RibbonButton
    Friend WithEvents btnOrdiniEvadi As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton13 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton14 As System.Windows.Forms.RibbonButton
    Friend WithEvents btnRicambiNuovo As System.Windows.Forms.RibbonButton
    Friend WithEvents btnRicambiElenco As System.Windows.Forms.RibbonButton
    Friend WithEvents btnRicambiEvadi As System.Windows.Forms.RibbonButton
    Friend WithEvents btnRicambiListino As System.Windows.Forms.RibbonButton
    Friend WithEvents btnMatricole As System.Windows.Forms.RibbonButton
    Friend WithEvents btnPrezzi As System.Windows.Forms.RibbonButton
    Friend WithEvents btnAnaClienti As System.Windows.Forms.RibbonButton
    Friend WithEvents btnAnaFornitori As System.Windows.Forms.RibbonButton
    Friend WithEvents mainDataModel As GestioneProduzione.DataModel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchiviToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoArticoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioArticoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfiguratoreArticoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguratoreGruppiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguratoreMacchineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ConfiguratoreMatricoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguratoreFormulePrezziToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ElencoFornitoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoClientiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BackupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdiniAcquistoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovoOrdineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoOrdiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EvasionePerArticoloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EvasioneOrdiniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdiniVenditaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovoOrdineToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoOrdiniToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EvasioneOrdineDiVenditaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListinoRicambiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommesseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovaCommessaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoCommesseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SimulazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StampeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituazioneMacchineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituazioneArticoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurazioneMacchineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoOrdiniAcquistoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoCommesseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElencoArticoliInOrdineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniSuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents RibbonButton1 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton2 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButtonList1 As System.Windows.Forms.RibbonButtonList
    Friend WithEvents RibbonPanel13 As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnGinuxArticoliImport As System.Windows.Forms.RibbonButton
    Friend WithEvents statusUtente As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusConnessione As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnLingue As System.Windows.Forms.RibbonButton
    Friend WithEvents TabOfferte As System.Windows.Forms.RibbonTab
    Friend WithEvents panelOfferte As System.Windows.Forms.RibbonPanel
    Friend WithEvents btnOffertaNuova As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton3 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton4 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton5 As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonButton7 As System.Windows.Forms.RibbonButton
    Friend WithEvents T30_utentiTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t30_utentiTableAdapter
    Friend WithEvents GestioneProduzione2009DataSet1 As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents tabConfigurazione As System.Windows.Forms.RibbonTab
    Friend WithEvents RibbonPanel15 As System.Windows.Forms.RibbonPanel
    Friend WithEvents panelAccessi As System.Windows.Forms.RibbonButton
    Private WithEvents RibbonMenu As System.Windows.Forms.Ribbon
    Friend WithEvents btnOffertaElenco As System.Windows.Forms.RibbonButton
    Friend WithEvents RibbonPanel5 As System.Windows.Forms.RibbonPanel
    Friend WithEvents RibbonButton6 As System.Windows.Forms.RibbonButton
End Class
