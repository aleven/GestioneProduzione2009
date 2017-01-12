Imports VS2005Commons
Imports GestioneProduzione2014GinuxImport
Imports GestioneProduzione2014Data
Imports GestioneProduzione2014OfficeExport
Imports System.IO

Public Class frmOffertaRicambiBase 

    Public Shared STATO_APERTO As String = "A"
    Public Shared STATO_CHIUSO As String = "C"
    Public Shared STATO_EVASO As String = "E"

    Protected _idOrdine As Integer
    Protected ricambioSelezionato As GestioneProduzione2009DataSet.ListinoRicambiRow
    Protected rigaSelezionata As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow
    'Serve a capire se sto aggiungendo un ricambio o una riga semplice
    Protected aggiuntoDaAdd As Boolean = False
    Protected datiCaricatiFiltroOrdinamento As Boolean = False

    Protected elementoModificato As Boolean = False

    Public Property IDOrdine() As Integer
        Get
            Return _idOrdine
        End Get
        Set(ByVal Value As Integer)
            _idOrdine = Value
        End Set
    End Property

    Protected Sub PrintPreviewExport(ByVal nome As String, ByVal export As Boolean, ByVal dataset As GestioneProduzione2009DataSet)

        'clessidra
        Cursor.Current = Cursors.WaitCursor

        Dim FormReport As New frmReport
        FormReport.MdiParent = Me.MdiParent

        FormReport.reportDocumentSource.Load(AppUtil.GetAppPath(nome + ".rpt"))

        Dim formula = "{" & dataset.t28_testate_ordini_cli.TableName & "." & dataset.t28_testate_ordini_cli.t28_idColumn.ColumnName & "} = " & IDOrdine
        formula = formula + " AND ISNULL({" + dataset.t29_righe_ordine_cli.TableName & "." & dataset.t29_righe_ordine_cli.t29_dt_cancellazioneColumn.ColumnName + "})"
        FormReport.reportDocumentSource.RecordSelectionFormula = formula
        'FormReport.reportDocumentSource.SetDataSource(Me.GestioneProduzione2009DataSet1)
        FormReport.reportDocumentSource.SetDataSource(dataset)

        If Not export Then
            FormReport.Show()
        Else
            Dim file As String
            file = nome
            'file += IIf(StringUtils.isNotEmpty(txtFiltroMatricola.Text), "-" & FileUtils.encodeFileName(txtFiltroMatricola.Text), "")
            file += "-" & DateTime.Now.ToString(DateUtils.FORMAT_IT_MINUS)
            file += ".xls"

            file = My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.Desktop, file)

            If FormReport.EsportaInExcel(file, True) Then
                Try
                    Process.Start(file)
                Catch ex As Exception
                    MessageBox.Show("Errore: " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Protected Function verificaElementoModificato() As Boolean
        If elementoModificato Then
            FormsHelper.Warn("Salvare prima di procedere", Me.Text)
            verificaElementoModificato = False
        Else
            verificaElementoModificato = True
        End If
    End Function

    Private Sub frmOffertaRicambiBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim ctrl As Control
        'For Each ctrl In Me.Controls
        '    If (ctrl.GetType() Is GetType(TextBox)) Then
        '        Dim txt As TextBox = CType(ctrl, TextBox)
        '        txt.BackColor = Color.LightYellow
        '    End If
        'Next



    End Sub

    'Sub ClearAllControls(ByRef container As Panel, Optional ByVal Recurse As Boolean = True)
    '    'Clear all of the controls within the container object
    '    'If "Recurse" is true, then also clear controls within any sub-containers
    '    Dim ctrl As Control
    '    For Each ctrl In container.Controls
    '        If (ctrl.GetType() Is GetType(TextBox)) Then
    '            Dim txt As TextBox = CType(ctrl, TextBox)
    '            txt.Text = ""
    '        End If
    '        If (ctrl.GetType() Is GetType(CheckBox)) Then
    '            Dim chkbx As CheckBox = CType(ctrl, CheckBox)
    '            chkbx.Checked = False
    '        End If
    '        If (ctrl.GetType() Is GetType(ComboBox)) Then
    '            Dim cbobx As ComboBox = CType(ctrl, ComboBox)
    '            cbobx.SelectedIndex = -1
    '        End If
    '        If (ctrl.GetType() Is GetType(DateTimePicker)) Then
    '            Dim dtp As DateTimePicker = CType(ctrl, DateTimePicker)
    '            dtp.Value = Now()
    '        End If

    '        If Recurse Then
    '            If (ctrl.GetType() Is GetType(Panel)) Then
    '                Dim pnl As Panel = CType(ctrl, Panel)
    '                ClearAllControls(pnl, Recurse)
    '            End If
    '            If ctrl.GetType() Is GetType(GroupBox) Then
    '                Dim grbx As GroupBox = CType(ctrl, GroupBox)
    '                ClearAllControls(grbx, Recurse)
    '            End If
    '        End If
    '    Next
    'End Sub

    Private _FormChiamante As Form
    Property FormChiamante() As Form Implements IFormCallRefreshable.FormChiamante
        Get
            FormChiamante = Me._FormChiamante
        End Get
        Set(ByVal FormChiamante As Form)
            Me._FormChiamante = FormChiamante
        End Set
    End Property

    Private Sub frmOffertaRicambiBase_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If (Not Me.Parent Is Nothing) Then
            If TypeOf Me.FormChiamante Is IFormRefreshable Then
                Dim parent As IFormRefreshable
                parent = CType(Me.FormChiamante, IFormRefreshable)
                parent.CallRefresh()
            End If
        End If
    End Sub

    ''' <summary>
    ''' ELIMINA DEFINITIVAMENTE L'OFFERTA
    ''' </summary>
    ''' <param name="taTestata"></param>
    ''' <param name="taRighe"></param>
    ''' <remarks></remarks>
    Protected Sub EliminaDati(ByVal taTestata As GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter, ByVal taRighe As GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter)
        If (IDOrdine > 0 AndAlso FormsHelper.Confirm("Confermi eliminazione?", Me.Text)) Then

            Dim righeDaCancellare As GestioneProduzione2009DataSet.t29_righe_ordine_cliDataTable
            righeDaCancellare = taRighe.GetDataByIdTestataForDelete(Me.IDOrdine)

            For Each riga As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow In righeDaCancellare
                'riga.Delete()
                If (riga.Ist29_dt_cancellazioneNull) Then
                    riga.t29_dt_cancellazione = DateTime.Now
                End If
            Next
            taRighe.Update(righeDaCancellare)

            Dim testataDaCancellare As GestioneProduzione2009DataSet.t28_testate_ordini_cliDataTable
            testataDaCancellare = taTestata.GetDataById(Me.IDOrdine)
            For Each testata As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow In testataDaCancellare
                'testata.Delete()
                testata.t28_dt_cancellazione = DateTime.Now
                testata.t28_utente_cancellazione = frmMain.Profilo.nome
            Next
            taTestata.Update(testataDaCancellare)

            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Duplica e Prepara le Righe come RIGHE APERTE NON EVASE
    ''' </summary>
    ''' <param name="taTestata"></param>
    ''' <param name="taRighe"></param>
    ''' <remarks></remarks>
    Protected Function DuplicaOffertaOCommessa(ByVal taTestata As GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter, ByVal taRighe As GestioneProduzione2009DataSetTableAdapters.t29_righe_ordine_cliTableAdapter) As Integer
        Dim nuovoID As Integer = 0

        If (datiCaricatiFiltroOrdinamento) Then
            If (IDOrdine > 0 AndAlso FormsHelper.Confirm("Vuoi fare una copia di questa Offerta?", Me.Text)) Then

                ' DUPLICAZIONE TESTATA 
                Dim dtNuovaTestata As New GestioneProduzione2009DataSet.t28_testate_ordini_cliDataTable
                Dim drNuovaTestata As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow
                drNuovaTestata = dtNuovaTestata.Newt28_testate_ordini_cliRow()

                For Each testata As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow In taTestata.GetDataById(Me.IDOrdine)
                    drNuovaTestata.ItemArray = testata.ItemArray

                    PreparaNuovaOfferta(drNuovaTestata)
                    drNuovaTestata.t28_offerta_num = drNuovaTestata.t28_offerta_num + " (COPIA)"
                    drNuovaTestata.Sett28_commessaNull() ' IMportante per controllo form apertura Offerta
                    drNuovaTestata.Sett28_commessa_delNull()
                    drNuovaTestata.t28_cliente = ""
                    drNuovaTestata.t28_cliente2 = ""

                    dtNuovaTestata.Addt28_testate_ordini_cliRow(drNuovaTestata)
                    Exit For
                Next
                taTestata.Update(dtNuovaTestata)

                ' DUPLICAZIONE RIGHE
                Dim dtNuoveRighe As New GestioneProduzione2009DataSet.t29_righe_ordine_cliDataTable
                Dim drNuovaRiga As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow
                drNuovaRiga = dtNuoveRighe.Newt29_righe_ordine_cliRow()

                For Each riga As GestioneProduzione2009DataSet.t29_righe_ordine_cliRow In taRighe.GetDataByIdTestataAll(Me.IDOrdine)
                    drNuovaRiga.ItemArray = riga.ItemArray
                    drNuovaRiga.t29_id_testata_t28 = drNuovaTestata.t28_id
                    If (Not drNuovaRiga.Ist29_id_articolo_t20Null) Then
                        drNuovaRiga.Sett29_data_evasioneNull()
                        drNuovaRiga.t29_stato_riga_ordine = STATO_APERTO
                        drNuovaRiga.t29_qt_evasa = 0
                    End If
                    dtNuoveRighe.Addt29_righe_ordine_cliRow(drNuovaRiga)
                Next
                taRighe.Update(dtNuoveRighe)

                nuovoID = drNuovaTestata.t28_id ' dtNuovaTestata.Rows(0)(dtNuovaTestata.t28_idColumn.ColumnName)
            End If
        End If

        DuplicaOffertaOCommessa = nuovoID
    End Function

    Protected Sub PreparaNuovaOfferta(ByVal nuova As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow)
        nuova.t28_utente_creazione = frmMain.Profilo.nome
        nuova.t28_dt_creazione = DateTime.Now
        nuova.t28_offerta = True
        nuova.t28_offerta_stato = STATO_APERTO
        nuova.t28_offerta_del = DateTime.Now
    End Sub

    Protected Sub PreparaNuovaCommessa(ByVal nuova As GestioneProduzione2009DataSet.t28_testate_ordini_cliRow)
        nuova.t28_utente_creazione = frmMain.Profilo.nome
        nuova.t28_utente_creazione_commessa = frmMain.Profilo.nome
        nuova.t28_dt_creazione = DateTime.Now
        'nuova.t28_offerta = True
        nuova.t28_stato_testata_ordine = STATO_APERTO
        nuova.t28_commessa_del = DateTime.Now
    End Sub
End Class