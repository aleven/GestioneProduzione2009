<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguratoreMatricole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguratoreMatricole))
        Me.dgMatricole = New System.Windows.Forms.DataGridView
        Me.txtFiltroMatricola = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalva = New System.Windows.Forms.Button
        Me.btnModifica = New System.Windows.Forms.Button
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.lblCount = New System.Windows.Forms.Label
        Me.chkFiltroAssociate = New System.Windows.Forms.CheckBox
        Me.T20articoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.T25matricoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T25_matricoleTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
        Me.T20_articoliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        Me.T25codmatricolaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_id_articolo_t20 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Articolo = New System.Windows.Forms.DataGridViewButtonColumn
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.t25_descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_descrizione_commerciale_it = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_descrizione_commerciale_en = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_descrizione_commerciale_es = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_descrizione_commerciale_fr = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_prezzo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t25_prezzo_forzato = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgMatricole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T25matricoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgMatricole
        '
        Me.dgMatricole.AllowUserToAddRows = False
        Me.dgMatricole.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgMatricole.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMatricole.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMatricole.AutoGenerateColumns = False
        Me.dgMatricole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMatricole.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T25codmatricolaDataGridViewTextBoxColumn, Me.t25_id_articolo_t20, Me.Articolo, Me.DataGridViewComboBoxColumn1, Me.t25_descrizione, Me.t25_descrizione_commerciale_it, Me.t25_descrizione_commerciale_en, Me.t25_descrizione_commerciale_es, Me.t25_descrizione_commerciale_fr, Me.t25_prezzo, Me.t25_prezzo_forzato})
        Me.dgMatricole.DataSource = Me.T25matricoleBindingSource
        Me.dgMatricole.Location = New System.Drawing.Point(12, 50)
        Me.dgMatricole.Name = "dgMatricole"
        Me.dgMatricole.ReadOnly = True
        Me.dgMatricole.Size = New System.Drawing.Size(641, 364)
        Me.dgMatricole.TabIndex = 0
        '
        'txtFiltroMatricola
        '
        Me.txtFiltroMatricola.Location = New System.Drawing.Point(12, 25)
        Me.txtFiltroMatricola.Name = "txtFiltroMatricola"
        Me.txtFiltroMatricola.Size = New System.Drawing.Size(161, 20)
        Me.txtFiltroMatricola.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matricola Articolo"
        '
        'btnSalva
        '
        Me.btnSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalva.Enabled = False
        Me.btnSalva.Image = Global.GestioneProduzione.My.Resources.Resources.save_all
        Me.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalva.Location = New System.Drawing.Point(447, 420)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(100, 30)
        Me.btnSalva.TabIndex = 25
        Me.btnSalva.Text = "&Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'btnModifica
        '
        Me.btnModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifica.Image = Global.GestioneProduzione.My.Resources.Resources.edit
        Me.btnModifica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifica.Location = New System.Drawing.Point(553, 420)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(100, 30)
        Me.btnModifica.TabIndex = 24
        Me.btnModifica.Text = "&Modifica"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.Enabled = False
        Me.btnAnnulla.Image = Global.GestioneProduzione.My.Resources.Resources.undo
        Me.btnAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnulla.Location = New System.Drawing.Point(342, 420)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 30)
        Me.btnAnnulla.TabIndex = 26
        Me.btnAnnulla.Text = "&Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCount.Location = New System.Drawing.Point(530, 27)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(123, 23)
        Me.lblCount.TabIndex = 27
        Me.lblCount.Text = "..."
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkFiltroAssociate
        '
        Me.chkFiltroAssociate.AutoSize = True
        Me.chkFiltroAssociate.Location = New System.Drawing.Point(179, 27)
        Me.chkFiltroAssociate.Name = "chkFiltroAssociate"
        Me.chkFiltroAssociate.Size = New System.Drawing.Size(138, 17)
        Me.chkFiltroAssociate.TabIndex = 28
        Me.chkFiltroAssociate.Text = "Matricole non associate"
        Me.chkFiltroAssociate.UseVisualStyleBackColor = True
        '
        'T20articoliBindingSource
        '
        Me.T20articoliBindingSource.DataMember = "t20_articoli"
        Me.T20articoliBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        Me.T20articoliBindingSource.Filter = ""
        Me.T20articoliBindingSource.Sort = ""
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T25matricoleBindingSource
        '
        Me.T25matricoleBindingSource.DataMember = "t25_matricole"
        Me.T25matricoleBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        '
        'T25_matricoleTableAdapter
        '
        Me.T25_matricoleTableAdapter.ClearBeforeFill = True
        '
        'T20_articoliTableAdapter
        '
        Me.T20_articoliTableAdapter.ClearBeforeFill = True
        '
        'T25codmatricolaDataGridViewTextBoxColumn
        '
        Me.T25codmatricolaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.T25codmatricolaDataGridViewTextBoxColumn.DataPropertyName = "t25_cod_matricola"
        Me.T25codmatricolaDataGridViewTextBoxColumn.HeaderText = "Matricola"
        Me.T25codmatricolaDataGridViewTextBoxColumn.Name = "T25codmatricolaDataGridViewTextBoxColumn"
        Me.T25codmatricolaDataGridViewTextBoxColumn.ReadOnly = True
        Me.T25codmatricolaDataGridViewTextBoxColumn.Width = 150
        '
        't25_id_articolo_t20
        '
        Me.t25_id_articolo_t20.DataPropertyName = "t25_id_articolo_t20"
        Me.t25_id_articolo_t20.HeaderText = "t25_id_articolo_t20"
        Me.t25_id_articolo_t20.Name = "t25_id_articolo_t20"
        Me.t25_id_articolo_t20.ReadOnly = True
        Me.t25_id_articolo_t20.Visible = False
        '
        'Articolo
        '
        Me.Articolo.HeaderText = "Associa Articolo"
        Me.Articolo.Name = "Articolo"
        Me.Articolo.ReadOnly = True
        Me.Articolo.Text = "Seleziona"
        Me.Articolo.UseColumnTextForButtonValue = True
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "t25_id_articolo_t20"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.T20articoliBindingSource
        Me.DataGridViewComboBoxColumn1.DisplayMember = "t20_descrizione"
        Me.DataGridViewComboBoxColumn1.HeaderText = "Descrizione Articolo Associato"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.ValueMember = "t20_id_articolo"
        '
        't25_descrizione
        '
        Me.t25_descrizione.DataPropertyName = "t25_descrizione"
        Me.t25_descrizione.HeaderText = "Descrizione Tecnica"
        Me.t25_descrizione.Name = "t25_descrizione"
        Me.t25_descrizione.ReadOnly = True
        '
        't25_descrizione_commerciale_it
        '
        Me.t25_descrizione_commerciale_it.DataPropertyName = "t25_descrizione_commerciale_it"
        Me.t25_descrizione_commerciale_it.HeaderText = "Desc.Comm. Italiano"
        Me.t25_descrizione_commerciale_it.Name = "t25_descrizione_commerciale_it"
        Me.t25_descrizione_commerciale_it.ReadOnly = True
        '
        't25_descrizione_commerciale_en
        '
        Me.t25_descrizione_commerciale_en.DataPropertyName = "t25_descrizione_commerciale_en"
        Me.t25_descrizione_commerciale_en.HeaderText = "Desc.Comm. Inglese"
        Me.t25_descrizione_commerciale_en.Name = "t25_descrizione_commerciale_en"
        Me.t25_descrizione_commerciale_en.ReadOnly = True
        '
        't25_descrizione_commerciale_es
        '
        Me.t25_descrizione_commerciale_es.DataPropertyName = "t25_descrizione_commerciale_es"
        Me.t25_descrizione_commerciale_es.HeaderText = "Desc.Comm. Spagnolo"
        Me.t25_descrizione_commerciale_es.Name = "t25_descrizione_commerciale_es"
        Me.t25_descrizione_commerciale_es.ReadOnly = True
        '
        't25_descrizione_commerciale_fr
        '
        Me.t25_descrizione_commerciale_fr.DataPropertyName = "t25_descrizione_commerciale_fr"
        Me.t25_descrizione_commerciale_fr.HeaderText = "Desc.Comm. Francese"
        Me.t25_descrizione_commerciale_fr.Name = "t25_descrizione_commerciale_fr"
        Me.t25_descrizione_commerciale_fr.ReadOnly = True
        '
        't25_prezzo
        '
        Me.t25_prezzo.DataPropertyName = "t25_prezzo"
        Me.t25_prezzo.HeaderText = "Prezzo"
        Me.t25_prezzo.Name = "t25_prezzo"
        Me.t25_prezzo.ReadOnly = True
        '
        't25_prezzo_forzato
        '
        Me.t25_prezzo_forzato.DataPropertyName = "t25_prezzo_forzato"
        Me.t25_prezzo_forzato.HeaderText = "Prezzo Forzato"
        Me.t25_prezzo_forzato.Name = "t25_prezzo_forzato"
        Me.t25_prezzo_forzato.ReadOnly = True
        '
        'frmConfiguratoreMatricole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 459)
        Me.Controls.Add(Me.chkFiltroAssociate)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.txtFiltroMatricola)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgMatricole)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguratoreMatricole"
        Me.Text = "Configurazione Matricole"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgMatricole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T25matricoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgMatricole As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T25matricoleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T25_matricoleTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t25_matricoleTableAdapter
    Friend WithEvents T20articoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T20_articoliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
    Friend WithEvents txtFiltroMatricola As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents chkFiltroAssociate As System.Windows.Forms.CheckBox
    Friend WithEvents T25codmatricolaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_id_articolo_t20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articolo As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewComboBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents t25_descrizione As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_descrizione_commerciale_it As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_descrizione_commerciale_en As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_descrizione_commerciale_es As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_descrizione_commerciale_fr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_prezzo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t25_prezzo_forzato As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
