<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSceltaArticolo3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSceltaArticolo3))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.T20idarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20codarticoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.T20descrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t20_is_gruppo = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.T20articoliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.txtRicercaCodice = New System.Windows.Forms.TextBox
        Me.txtRicercaDescrizione = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.T20_articoliTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.T20idarticoloDataGridViewTextBoxColumn, Me.T20codarticoloDataGridViewTextBoxColumn, Me.T20descrizioneDataGridViewTextBoxColumn, Me.t20_is_gruppo})
        Me.DataGridView1.DataSource = Me.T20articoliBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 55)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(834, 349)
        Me.DataGridView1.TabIndex = 0
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
        Me.T20codarticoloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.T20codarticoloDataGridViewTextBoxColumn.DataPropertyName = "t20_cod_articolo"
        Me.T20codarticoloDataGridViewTextBoxColumn.HeaderText = "Codice"
        Me.T20codarticoloDataGridViewTextBoxColumn.Name = "T20codarticoloDataGridViewTextBoxColumn"
        Me.T20codarticoloDataGridViewTextBoxColumn.ReadOnly = True
        Me.T20codarticoloDataGridViewTextBoxColumn.Width = 65
        '
        'T20descrizioneDataGridViewTextBoxColumn
        '
        Me.T20descrizioneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.T20descrizioneDataGridViewTextBoxColumn.DataPropertyName = "t20_descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.T20descrizioneDataGridViewTextBoxColumn.Name = "T20descrizioneDataGridViewTextBoxColumn"
        Me.T20descrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        't20_is_gruppo
        '
        Me.t20_is_gruppo.DataPropertyName = "t20_is_gruppo"
        Me.t20_is_gruppo.HeaderText = "Gruppo Si/No"
        Me.t20_is_gruppo.Name = "t20_is_gruppo"
        Me.t20_is_gruppo.ReadOnly = True
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
        'txtRicercaCodice
        '
        Me.txtRicercaCodice.Location = New System.Drawing.Point(12, 25)
        Me.txtRicercaCodice.Name = "txtRicercaCodice"
        Me.txtRicercaCodice.Size = New System.Drawing.Size(141, 20)
        Me.txtRicercaCodice.TabIndex = 1
        '
        'txtRicercaDescrizione
        '
        Me.txtRicercaDescrizione.Location = New System.Drawing.Point(159, 25)
        Me.txtRicercaDescrizione.Name = "txtRicercaDescrizione"
        Me.txtRicercaDescrizione.Size = New System.Drawing.Size(300, 20)
        Me.txtRicercaDescrizione.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cerca per Codice :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cerca per Descrizione :"
        '
        'T20_articoliTableAdapter
        '
        Me.T20_articoliTableAdapter.ClearBeforeFill = True
        '
        'frmSceltaArticolo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 416)
        Me.Controls.Add(Me.txtRicercaDescrizione)
        Me.Controls.Add(Me.txtRicercaCodice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSceltaArticolo3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scegli un Articolo o un Gruppo"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T20articoliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T20articoliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T20_articoliTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t20_articoliTableAdapter
    Friend WithEvents txtRicercaCodice As System.Windows.Forms.TextBox
    Friend WithEvents txtRicercaDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents T20idarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20codarticoloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents T20descrizioneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t20_is_gruppo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
