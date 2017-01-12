<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticoliInventario
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArticoliInventario))
        Me.dgvArticoli = New System.Windows.Forms.DataGridView
        Me.T20articoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.T20_articoliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Me.btnModifica = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFiltroCodice = New System.Windows.Forms.TextBox
        Me.txtFiltroDescrizione = New System.Windows.Forms.TextBox
        Me.btnSalva = New System.Windows.Forms.Button
        Me.btnChiudi = New System.Windows.Forms.Button
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20qtdisponibileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20lottoriordinoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20prezzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20isgruppoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T20dtcreazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20dtmodificaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20dtcancellazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20idfornitoret11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20prezzoforzatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20isricambioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.dgvArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvArticoli
        '
        Me.dgvArticoli.AllowUserToAddRows = False
        Me.dgvArticoli.AllowUserToDeleteRows = False
        Me.dgvArticoli.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.dgvArticoli.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvArticoli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArticoli.AutoGenerateColumns = False
        Me.dgvArticoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArticoli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T20idarticoloDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn, Me.T20qtdisponibileDataGridViewTextBoxColumn, Me.T20lottoriordinoDataGridViewTextBoxColumn, Me.T20prezzoDataGridViewTextBoxColumn, Me.T20isgruppoDataGridViewCheckBoxColumn, Me.T20dtcreazioneDataGridViewTextBoxColumn, Me.T20dtmodificaDataGridViewTextBoxColumn, Me.T20dtcancellazioneDataGridViewTextBoxColumn, Me.T20idfornitoret11DataGridViewTextBoxColumn, Me.T20prezzoforzatoDataGridViewTextBoxColumn, Me.T20isricambioDataGridViewCheckBoxColumn})
        Me.dgvArticoli.DataSource = Me.T20articoliBindingSource
        Me.dgvArticoli.Location = New System.Drawing.Point(1, 32)
        Me.dgvArticoli.Name = "dgvArticoli"
        Me.dgvArticoli.ReadOnly = True
        Me.dgvArticoli.Size = New System.Drawing.Size(581, 393)
        Me.dgvArticoli.TabIndex = 3
        '
        'T20articoliBindingSource
        '
        Me.T20articoliBindingSource.DataMember = "t20_articoli"
        Me.T20articoliBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T20_articoliTableAdapter
        '
        Me.T20_articoliTableAdapter.ClearBeforeFill = True
        '
        'btnModifica
        '
        Me.btnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifica.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnModifica.Image = Global.GestioneProduzione.My.Resources.Resources.edit
        Me.btnModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifica.Location = New System.Drawing.Point(373, 431)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(98, 30)
        Me.btnModifica.TabIndex = 4
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ricerca"
        '
        'txtFiltroCodice
        '
        Me.txtFiltroCodice.Location = New System.Drawing.Point(57, 6)
        Me.txtFiltroCodice.Name = "txtFiltroCodice"
        Me.txtFiltroCodice.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltroCodice.TabIndex = 0
        '
        'txtFiltroDescrizione
        '
        Me.txtFiltroDescrizione.Location = New System.Drawing.Point(163, 6)
        Me.txtFiltroDescrizione.Name = "txtFiltroDescrizione"
        Me.txtFiltroDescrizione.Size = New System.Drawing.Size(157, 20)
        Me.txtFiltroDescrizione.TabIndex = 2
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalva.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalva.Location = New System.Drawing.Point(272, 431)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(95, 30)
        Me.btnSalva.TabIndex = 5
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        Me.btnSalva.Visible = False
        '
        'btnChiudi
        '
        Me.btnChiudi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChiudi.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChiudi.Image = Global.GestioneProduzione.My.Resources.Resources.dialog_close
        Me.btnChiudi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChiudi.Location = New System.Drawing.Point(477, 431)
        Me.btnChiudi.Name = "btnChiudi"
        Me.btnChiudi.Size = New System.Drawing.Size(97, 30)
        Me.btnChiudi.TabIndex = 28
        Me.btnChiudi.Text = "&Chiudi"
        Me.btnChiudi.UseVisualStyleBackColor = True
        '
        'T20idarticoloDataGridViewTextBoxColumn
        '
        Me.T20idarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.HeaderText = "t20_id_articolo"
        Me.T20idarticoloDataGridViewTextBoxColumn.Name = "T20idarticoloDataGridViewTextBoxColumn"
        Me.T20idarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20idarticoloDataGridViewTextBoxColumn.Visible = False
        '
        'T20codarticoloDataGridViewTextBoxColumn
        '
        Me.T20codarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_cod_articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.MaxInputLength = 4000
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20descrizioneDataGridViewTextBoxColumn.Width = 200
        '
        'T20qtdisponibileDataGridViewTextBoxColumn
        '
        Me.T20qtdisponibileDataGridViewTextBoxColumn.DataPropertyName = "t20_qt_disponibile"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.HeaderText = "Qt. disponibile"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.Name = "T20qtdisponibileDataGridViewTextBoxColumn"
        Me.T20qtdisponibileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20lottoriordinoDataGridViewTextBoxColumn
        '
        Me.T20lottoriordinoDataGridViewTextBoxColumn.DataPropertyName = "t20_lotto_riordino"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.HeaderText = "Scorta minima"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.Name = "T20lottoriordinoDataGridViewTextBoxColumn"
        Me.T20lottoriordinoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20prezzoDataGridViewTextBoxColumn
        '
        Me.T20prezzoDataGridViewTextBoxColumn.DataPropertyName = "t20_prezzo"
        Me.T20prezzoDataGridViewTextBoxColumn.HeaderText = "Costo"
        Me.T20prezzoDataGridViewTextBoxColumn.Name = "T20prezzoDataGridViewTextBoxColumn"
        Me.T20prezzoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T20isgruppoDataGridViewCheckBoxColumn
        '
        Me.T20isgruppoDataGridViewCheckBoxColumn.DataPropertyName = "t20_is_gruppo"
        Me.T20isgruppoDataGridViewCheckBoxColumn.HeaderText = "t20_is_gruppo"
        Me.T20isgruppoDataGridViewCheckBoxColumn.Name = "T20isgruppoDataGridViewCheckBoxColumn"
        Me.T20isgruppoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.T20isgruppoDataGridViewCheckBoxColumn.Visible = False
        '
        'T20dtcreazioneDataGridViewTextBoxColumn
        '
        Me.T20dtcreazioneDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_creazione"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.HeaderText = "t20_dt_creazione"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.Name = "T20dtcreazioneDataGridViewTextBoxColumn"
        Me.T20dtcreazioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20dtcreazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20dtmodificaDataGridViewTextBoxColumn
        '
        Me.T20dtmodificaDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_modifica"
        Me.T20dtmodificaDataGridViewTextBoxColumn.HeaderText = "t20_dt_modifica"
        Me.T20dtmodificaDataGridViewTextBoxColumn.Name = "T20dtmodificaDataGridViewTextBoxColumn"
        Me.T20dtmodificaDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20dtmodificaDataGridViewTextBoxColumn.Visible = False
        '
        'T20dtcancellazioneDataGridViewTextBoxColumn
        '
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.DataPropertyName = "t20_dt_cancellazione"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.HeaderText = "t20_dt_cancellazione"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.Name = "T20dtcancellazioneDataGridViewTextBoxColumn"
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20dtcancellazioneDataGridViewTextBoxColumn.Visible = False
        '
        'T20idfornitoret11DataGridViewTextBoxColumn
        '
        Me.T20idfornitoret11DataGridViewTextBoxColumn.DataPropertyName = "t20_id_fornitore_t11"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.HeaderText = "t20_id_fornitore_t11"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.Name = "T20idfornitoret11DataGridViewTextBoxColumn"
        Me.T20idfornitoret11DataGridViewTextBoxColumn.ReadOnly = True
        Me.T20idfornitoret11DataGridViewTextBoxColumn.Visible = False
        '
        'T20prezzoforzatoDataGridViewTextBoxColumn
        '
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.DataPropertyName = "t20_prezzo_forzato"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.HeaderText = "t20_prezzo_forzato"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.Name = "T20prezzoforzatoDataGridViewTextBoxColumn"
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20prezzoforzatoDataGridViewTextBoxColumn.Visible = False
        '
        'T20isricambioDataGridViewCheckBoxColumn
        '
        Me.T20isricambioDataGridViewCheckBoxColumn.DataPropertyName = "t20_is_ricambio"
        Me.T20isricambioDataGridViewCheckBoxColumn.HeaderText = "Ricambio"
        Me.T20isricambioDataGridViewCheckBoxColumn.Name = "T20isricambioDataGridViewCheckBoxColumn"
        Me.T20isricambioDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'frmArticoliModificaVeloce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnChiudi
        Me.ClientSize = New System.Drawing.Size(586, 473)
        Me.Controls.Add(Me.btnChiudi)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.txtFiltroDescrizione)
        Me.Controls.Add(Me.txtFiltroCodice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.dgvArticoli)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmArticoliModificaVeloce"
        Me.Text = "Elenco Articoli"
        CType(Me.dgvArticoli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvArticoli As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T20articoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T20_articoliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnChiudi As System.Windows.Forms.Button
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20qtdisponibileDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20lottoriordinoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20prezzoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20isgruppoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents T20dtcreazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20dtmodificaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20dtcancellazioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20idfornitoret11DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20prezzoforzatoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20isricambioDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
