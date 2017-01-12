<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffertaElenco
    Inherits System.Windows.Forms.Form
    Implements IFormRefreshable

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOffertaElenco))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.T28_testate_ordini_cliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.cmbFiltroAnno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbFiltroVista = New System.Windows.Forms.ComboBox
        Me.txtSemeRicerca = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbCausale = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.T28_testate_ordini_cliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
        Me.T28_anni = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_anni
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbUtente = New System.Windows.Forms.ComboBox
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.btnAggiorna = New System.Windows.Forms.Button
        Me.T28idDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.utenteCreazioneColumns = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28codDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28commessaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28commessadelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28clienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaOffertaClienteCodice = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.columnaOffertaLingua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28venditaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28riparazioneDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28completamentofornituraDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T28aspettoesterioreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28misureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28pesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T28noteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t28_causaleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColonnaCommessa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colonnaCommessaDel = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T28_testate_ordini_cliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T28idDataGridViewTextBoxColumn, Me.utenteCreazioneColumns, Me.T28codDataGridViewTextBoxColumn, Me.T28descrizioneDataGridViewTextBoxColumn, Me.T28commessaDataGridViewTextBoxColumn, Me.T28commessadelDataGridViewTextBoxColumn, Me.T28clienteDataGridViewTextBoxColumn, Me.colonnaOffertaClienteCodice, Me.columnaOffertaLingua, Me.T28venditaDataGridViewCheckBoxColumn, Me.T28riparazioneDataGridViewCheckBoxColumn, Me.T28completamentofornituraDataGridViewCheckBoxColumn, Me.T28aspettoesterioreDataGridViewTextBoxColumn, Me.T28misureDataGridViewTextBoxColumn, Me.T28pesoDataGridViewTextBoxColumn, Me.T28noteDataGridViewTextBoxColumn, Me.t28_causaleColumn, Me.ColonnaCommessa, Me.colonnaCommessaDel})
        Me.DataGridView1.DataSource = Me.T28_testate_ordini_cliBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1000, 318)
        Me.DataGridView1.TabIndex = 0
        '
        'T28_testate_ordini_cliBindingSource
        '
        Me.T28_testate_ordini_cliBindingSource.DataMember = "t28_testate_ordini_cli"
        Me.T28_testate_ordini_cliBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbFiltroAnno
        '
        Me.cmbFiltroAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbFiltroAnno.FormattingEnabled = True
        Me.cmbFiltroAnno.Location = New System.Drawing.Point(853, 10)
        Me.cmbFiltroAnno.Name = "cmbFiltroAnno"
        Me.cmbFiltroAnno.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltroAnno.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(815, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Anno"
        '
        'cmbFiltroVista
        '
        Me.cmbFiltroVista.FormattingEnabled = True
        Me.cmbFiltroVista.Location = New System.Drawing.Point(12, 10)
        Me.cmbFiltroVista.Name = "cmbFiltroVista"
        Me.cmbFiltroVista.Size = New System.Drawing.Size(217, 21)
        Me.cmbFiltroVista.TabIndex = 5
        '
        'txtSemeRicerca
        '
        Me.txtSemeRicerca.Location = New System.Drawing.Point(281, 10)
        Me.txtSemeRicerca.Name = "txtSemeRicerca"
        Me.txtSemeRicerca.Size = New System.Drawing.Size(100, 20)
        Me.txtSemeRicerca.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ricerca"
        '
        'cmbCausale
        '
        Me.cmbCausale.FormattingEnabled = True
        Me.cmbCausale.Items.AddRange(New Object() {"", "Riparazione", "Ass. Tecnica"})
        Me.cmbCausale.Location = New System.Drawing.Point(437, 10)
        Me.cmbCausale.Name = "cmbCausale"
        Me.cmbCausale.Size = New System.Drawing.Size(143, 21)
        Me.cmbCausale.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(387, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Causale"
        '
        'T28_testate_ordini_cliTableAdapter
        '
        Me.T28_testate_ordini_cliTableAdapter.ClearBeforeFill = True
        '
        'T28_anni
        '
        Me.T28_anni.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(588, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Utente"
        '
        'cmbUtente
        '
        Me.cmbUtente.FormattingEnabled = True
        Me.cmbUtente.Location = New System.Drawing.Point(638, 10)
        Me.cmbUtente.Name = "cmbUtente"
        Me.cmbUtente.Size = New System.Drawing.Size(143, 21)
        Me.cmbUtente.TabIndex = 30
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = CType(resources.GetObject("btnChiudi.Image"), System.Drawing.Image)
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(916, 361)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(96, 32)
        Me.btnChiudi.TabIndex = 9
        Me.btnChiudi.Text = "&Chiudi"
        '
        'btnAggiorna
        '
        Me.btnAggiorna.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAggiorna.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAggiorna.Image = Global.GestioneProduzione.My.Resources.Resources.reload
        Me.btnAggiorna.Location = New System.Drawing.Point(980, 3)
        Me.btnAggiorna.Name = "btnAggiorna"
        Me.btnAggiorna.Size = New System.Drawing.Size(32, 32)
        Me.btnAggiorna.TabIndex = 8
        '
        'T28idDataGridViewTextBoxColumn
        '
        Me.T28idDataGridViewTextBoxColumn.DataPropertyName = "t28_id"
        Me.T28idDataGridViewTextBoxColumn.HeaderText = "t28_id"
        Me.T28idDataGridViewTextBoxColumn.Name = "T28idDataGridViewTextBoxColumn"
        Me.T28idDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28idDataGridViewTextBoxColumn.Visible = False
        '
        'utenteCreazioneColumns
        '
        Me.utenteCreazioneColumns.DataPropertyName = "t28_utente_creazione"
        Me.utenteCreazioneColumns.HeaderText = "t28_utente_creazione"
        Me.utenteCreazioneColumns.Name = "utenteCreazioneColumns"
        Me.utenteCreazioneColumns.ReadOnly = True
        Me.utenteCreazioneColumns.Visible = False
        '
        'T28codDataGridViewTextBoxColumn
        '
        Me.T28codDataGridViewTextBoxColumn.DataPropertyName = "t28_cod"
        Me.T28codDataGridViewTextBoxColumn.HeaderText = "t28_cod"
        Me.T28codDataGridViewTextBoxColumn.Name = "T28codDataGridViewTextBoxColumn"
        Me.T28codDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28codDataGridViewTextBoxColumn.Visible = False
        '
        'T28descrizioneDataGridViewTextBoxColumn
        '
        Me.T28descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t28_descrizione"
        Me.T28descrizioneDataGridViewTextBoxColumn.HeaderText = "t28_descrizione"
        Me.T28descrizioneDataGridViewTextBoxColumn.Name = "T28descrizioneDataGridViewTextBoxColumn"
        Me.T28descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28descrizioneDataGridViewTextBoxColumn.Visible = False
        '
        'T28commessaDataGridViewTextBoxColumn
        '
        Me.T28commessaDataGridViewTextBoxColumn.DataPropertyName = "t28_offerta_num"
        Me.T28commessaDataGridViewTextBoxColumn.HeaderText = "Offerta"
        Me.T28commessaDataGridViewTextBoxColumn.Name = "T28commessaDataGridViewTextBoxColumn"
        Me.T28commessaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T28commessadelDataGridViewTextBoxColumn
        '
        Me.T28commessadelDataGridViewTextBoxColumn.DataPropertyName = "t28_offerta_del"
        Me.T28commessadelDataGridViewTextBoxColumn.HeaderText = "Del"
        Me.T28commessadelDataGridViewTextBoxColumn.Name = "T28commessadelDataGridViewTextBoxColumn"
        Me.T28commessadelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T28clienteDataGridViewTextBoxColumn
        '
        Me.T28clienteDataGridViewTextBoxColumn.DataPropertyName = "t28_offerta_cliente"
        Me.T28clienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.T28clienteDataGridViewTextBoxColumn.Name = "T28clienteDataGridViewTextBoxColumn"
        Me.T28clienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colonnaOffertaClienteCodice
        '
        Me.colonnaOffertaClienteCodice.DataPropertyName = "t28_offerta_cliente_cod"
        Me.colonnaOffertaClienteCodice.HeaderText = "Cod. Cliente"
        Me.colonnaOffertaClienteCodice.Name = "colonnaOffertaClienteCodice"
        Me.colonnaOffertaClienteCodice.ReadOnly = True
        '
        'columnaOffertaLingua
        '
        Me.columnaOffertaLingua.DataPropertyName = "t28_offerta_lingua"
        Me.columnaOffertaLingua.HeaderText = "Lingua"
        Me.columnaOffertaLingua.Name = "columnaOffertaLingua"
        Me.columnaOffertaLingua.ReadOnly = True
        '
        'T28venditaDataGridViewCheckBoxColumn
        '
        Me.T28venditaDataGridViewCheckBoxColumn.DataPropertyName = "t28_vendita"
        Me.T28venditaDataGridViewCheckBoxColumn.HeaderText = "t28_vendita"
        Me.T28venditaDataGridViewCheckBoxColumn.Name = "T28venditaDataGridViewCheckBoxColumn"
        Me.T28venditaDataGridViewCheckBoxColumn.ReadOnly = True
        Me.T28venditaDataGridViewCheckBoxColumn.Visible = False
        '
        'T28riparazioneDataGridViewCheckBoxColumn
        '
        Me.T28riparazioneDataGridViewCheckBoxColumn.DataPropertyName = "t28_riparazione"
        Me.T28riparazioneDataGridViewCheckBoxColumn.HeaderText = "t28_riparazione"
        Me.T28riparazioneDataGridViewCheckBoxColumn.Name = "T28riparazioneDataGridViewCheckBoxColumn"
        Me.T28riparazioneDataGridViewCheckBoxColumn.ReadOnly = True
        Me.T28riparazioneDataGridViewCheckBoxColumn.Visible = False
        '
        'T28completamentofornituraDataGridViewCheckBoxColumn
        '
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.DataPropertyName = "t28_completamento_fornitura"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.HeaderText = "t28_completamento_fornitura"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.Name = "T28completamentofornituraDataGridViewCheckBoxColumn"
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.ReadOnly = True
        Me.T28completamentofornituraDataGridViewCheckBoxColumn.Visible = False
        '
        'T28aspettoesterioreDataGridViewTextBoxColumn
        '
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.DataPropertyName = "t28_aspetto_esteriore"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.HeaderText = "t28_aspetto_esteriore"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.Name = "T28aspettoesterioreDataGridViewTextBoxColumn"
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28aspettoesterioreDataGridViewTextBoxColumn.Visible = False
        '
        'T28misureDataGridViewTextBoxColumn
        '
        Me.T28misureDataGridViewTextBoxColumn.DataPropertyName = "t28_misure"
        Me.T28misureDataGridViewTextBoxColumn.HeaderText = "t28_misure"
        Me.T28misureDataGridViewTextBoxColumn.Name = "T28misureDataGridViewTextBoxColumn"
        Me.T28misureDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28misureDataGridViewTextBoxColumn.Visible = False
        '
        'T28pesoDataGridViewTextBoxColumn
        '
        Me.T28pesoDataGridViewTextBoxColumn.DataPropertyName = "t28_peso"
        Me.T28pesoDataGridViewTextBoxColumn.HeaderText = "t28_peso"
        Me.T28pesoDataGridViewTextBoxColumn.Name = "T28pesoDataGridViewTextBoxColumn"
        Me.T28pesoDataGridViewTextBoxColumn.ReadOnly = True
        Me.T28pesoDataGridViewTextBoxColumn.Visible = False
        '
        'T28noteDataGridViewTextBoxColumn
        '
        Me.T28noteDataGridViewTextBoxColumn.DataPropertyName = "t28_note"
        Me.T28noteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.T28noteDataGridViewTextBoxColumn.Name = "T28noteDataGridViewTextBoxColumn"
        Me.T28noteDataGridViewTextBoxColumn.ReadOnly = True
        '
        't28_causaleColumn
        '
        Me.t28_causaleColumn.DataPropertyName = "t28_causale"
        Me.t28_causaleColumn.HeaderText = "Causale"
        Me.t28_causaleColumn.Name = "t28_causaleColumn"
        Me.t28_causaleColumn.ReadOnly = True
        '
        'ColonnaCommessa
        '
        Me.ColonnaCommessa.DataPropertyName = "t28_commessa"
        Me.ColonnaCommessa.HeaderText = "Commessa"
        Me.ColonnaCommessa.Name = "ColonnaCommessa"
        Me.ColonnaCommessa.ReadOnly = True
        '
        'colonnaCommessaDel
        '
        Me.colonnaCommessaDel.DataPropertyName = "t28_commessa_del"
        Me.colonnaCommessaDel.HeaderText = "Data Commessa"
        Me.colonnaCommessaDel.Name = "colonnaCommessaDel"
        Me.colonnaCommessaDel.ReadOnly = True
        '
        'frmOffertaElenco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(1024, 402)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbUtente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCausale)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.btnAggiorna)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSemeRicerca)
        Me.Controls.Add(Me.cmbFiltroVista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFiltroAnno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOffertaElenco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elenco Offerte Ricambi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T28_testate_ordini_cliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T28_testate_ordini_cliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T28_testate_ordini_cliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_testate_ordini_cliTableAdapter
    Friend WithEvents T28telDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28rifddtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28riffattDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28datacreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28datamodificaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28datacancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbFiltroAnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbFiltroVista As System.Windows.Forms.ComboBox
    Friend WithEvents T28_anni As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t28_anni
    Friend WithEvents txtSemeRicerca As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAggiorna As System.Windows.Forms.Button
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents cmbCausale As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbUtente As System.Windows.Forms.ComboBox
    Friend WithEvents T28idDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents utenteCreazioneColumns As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28codDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28commessaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28commessadelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28clienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaOffertaClienteCodice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnaOffertaLingua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28venditaDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28riparazioneDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28completamentofornituraDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T28aspettoesterioreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28misureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28pesoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T28noteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t28_causaleColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColonnaCommessa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colonnaCommessaDel As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
