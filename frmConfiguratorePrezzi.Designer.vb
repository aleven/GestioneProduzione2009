<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguratorePrezzi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguratorePrezzi))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.T26_formule_prezziBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.T26_formule_prezziBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestioneProduzione2009DataSet = New GestioneProduzione2014Data.GestioneProduzione2009DataSet
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.T26_formule_prezziBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.pnlGrid = New System.Windows.Forms.Panel
        Me.T26_formule_prezziDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumnFisso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumnMoltiplica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.t26_arrotondamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pnlDetail = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSconto = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.T26_formule_prezziTableAdapter = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
        Me.T31_configurazioneTableAdapter1 = New GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t31_configurazioneTableAdapter
        CType(Me.T26_formule_prezziBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T26_formule_prezziBindingNavigator.SuspendLayout()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrid.SuspendLayout()
        CType(Me.T26_formule_prezziDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDetail.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'T26_formule_prezziBindingNavigator
        '
        Me.T26_formule_prezziBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T26_formule_prezziBindingNavigator.BindingSource = Me.T26_formule_prezziBindingSource
        Me.T26_formule_prezziBindingNavigator.CountItem = Nothing
        Me.T26_formule_prezziBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T26_formule_prezziBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator2, Me.T26_formule_prezziBindingNavigatorSaveItem})
        Me.T26_formule_prezziBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.T26_formule_prezziBindingNavigator.MoveFirstItem = Nothing
        Me.T26_formule_prezziBindingNavigator.MoveLastItem = Nothing
        Me.T26_formule_prezziBindingNavigator.MoveNextItem = Nothing
        Me.T26_formule_prezziBindingNavigator.MovePreviousItem = Nothing
        Me.T26_formule_prezziBindingNavigator.Name = "T26_formule_prezziBindingNavigator"
        Me.T26_formule_prezziBindingNavigator.PositionItem = Nothing
        Me.T26_formule_prezziBindingNavigator.Size = New System.Drawing.Size(740, 25)
        Me.T26_formule_prezziBindingNavigator.TabIndex = 0
        Me.T26_formule_prezziBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(68, 22)
        Me.BindingNavigatorAddNewItem.Text = "Aggiungi"
        '
        'T26_formule_prezziBindingSource
        '
        Me.T26_formule_prezziBindingSource.DataMember = "t26_formule_prezzi"
        Me.T26_formule_prezziBindingSource.DataSource = Me.GestioneProduzione2009DataSet
        Me.T26_formule_prezziBindingSource.Sort = "t26_formula_da"
        '
        'GestioneProduzione2009DataSet
        '
        Me.GestioneProduzione2009DataSet.DataSetName = "GestioneProduzione2009DataSet"
        Me.GestioneProduzione2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(59, 22)
        Me.BindingNavigatorDeleteItem.Text = "Elimina"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'T26_formule_prezziBindingNavigatorSaveItem
        '
        Me.T26_formule_prezziBindingNavigatorSaveItem.Image = CType(resources.GetObject("T26_formule_prezziBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T26_formule_prezziBindingNavigatorSaveItem.Name = "T26_formule_prezziBindingNavigatorSaveItem"
        Me.T26_formule_prezziBindingNavigatorSaveItem.Size = New System.Drawing.Size(101, 22)
        Me.T26_formule_prezziBindingNavigatorSaveItem.Text = "Salva modifiche"
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.T26_formule_prezziDataGridView)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 25)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(740, 425)
        Me.pnlGrid.TabIndex = 2
        Me.pnlGrid.UseWaitCursor = True
        '
        'T26_formule_prezziDataGridView
        '
        Me.T26_formule_prezziDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender
        Me.T26_formule_prezziDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.T26_formule_prezziDataGridView.AutoGenerateColumns = False
        Me.T26_formule_prezziDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumnFisso, Me.DataGridViewTextBoxColumnMoltiplica, Me.t26_arrotondamento})
        Me.T26_formule_prezziDataGridView.DataSource = Me.T26_formule_prezziBindingSource
        Me.T26_formule_prezziDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T26_formule_prezziDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.T26_formule_prezziDataGridView.Name = "T26_formule_prezziDataGridView"
        Me.T26_formule_prezziDataGridView.Size = New System.Drawing.Size(740, 425)
        Me.T26_formule_prezziDataGridView.TabIndex = 2
        Me.T26_formule_prezziDataGridView.UseWaitCursor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "t26_id_formula"
        Me.DataGridViewTextBoxColumn1.HeaderText = "t26_id_formula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "t26_cod_formula"
        Me.DataGridViewTextBoxColumn2.HeaderText = "t26_cod_formula"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "t26_descrizione"
        Me.DataGridViewTextBoxColumn3.HeaderText = "t26_descrizione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "t26_formula_da"
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Lim. Inferiore (>=)"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "t26_formula_a"
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "Lim. Superiore (<)"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumnFisso
        '
        Me.DataGridViewTextBoxColumnFisso.DataPropertyName = "t26_prezzo_fisso"
        DataGridViewCellStyle9.Format = "N2"
        Me.DataGridViewTextBoxColumnFisso.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumnFisso.HeaderText = "Criterio a Prezzo Fisso"
        Me.DataGridViewTextBoxColumnFisso.Name = "DataGridViewTextBoxColumnFisso"
        Me.DataGridViewTextBoxColumnFisso.Width = 150
        '
        'DataGridViewTextBoxColumnMoltiplica
        '
        Me.DataGridViewTextBoxColumnMoltiplica.DataPropertyName = "t26_fattore"
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumnMoltiplica.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumnMoltiplica.HeaderText = "Criterio a Moltiplicazione"
        Me.DataGridViewTextBoxColumnMoltiplica.Name = "DataGridViewTextBoxColumnMoltiplica"
        Me.DataGridViewTextBoxColumnMoltiplica.Width = 150
        '
        't26_arrotondamento
        '
        Me.t26_arrotondamento.DataPropertyName = "t26_arrotondamento"
        Me.t26_arrotondamento.HeaderText = "Euro Arrotondamento (0.5 o 1)"
        Me.t26_arrotondamento.Name = "t26_arrotondamento"
        Me.t26_arrotondamento.ToolTipText = "Puoi impostare come arrotondare il prezzo, se al mezzo euro o all'euro successivi" & _
            ""
        Me.t26_arrotondamento.Width = 200
        '
        'pnlDetail
        '
        Me.pnlDetail.Controls.Add(Me.GroupBox2)
        Me.pnlDetail.Controls.Add(Me.GroupBox1)
        Me.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlDetail.Location = New System.Drawing.Point(0, 228)
        Me.pnlDetail.Name = "pnlDetail"
        Me.pnlDetail.Size = New System.Drawing.Size(740, 222)
        Me.pnlDetail.TabIndex = 3
        Me.pnlDetail.UseWaitCursor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtSconto)
        Me.GroupBox2.Location = New System.Drawing.Point(602, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(137, 212)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LISTINO"
        Me.GroupBox2.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "%"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listino Cliente = Listino Rivenditore +"
        Me.Label1.UseWaitCursor = True
        '
        'txtSconto
        '
        Me.txtSconto.Location = New System.Drawing.Point(6, 59)
        Me.txtSconto.Name = "txtSconto"
        Me.txtSconto.Size = New System.Drawing.Size(95, 20)
        Me.txtSconto.TabIndex = 0
        Me.txtSconto.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(596, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Indicazioni"
        Me.GroupBox1.UseWaitCursor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(590, 197)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.UseWaitCursor = True
        '
        'T26_formule_prezziTableAdapter
        '
        Me.T26_formule_prezziTableAdapter.ClearBeforeFill = True
        '
        'T31_configurazioneTableAdapter1
        '
        Me.T31_configurazioneTableAdapter1.ClearBeforeFill = True
        '
        'frmConfiguratorePrezzi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 450)
        Me.Controls.Add(Me.pnlDetail)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.T26_formule_prezziBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguratorePrezzi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Configuratore formule dei Prezzi Calcolati"
        CType(Me.T26_formule_prezziBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T26_formule_prezziBindingNavigator.ResumeLayout(False)
        Me.T26_formule_prezziBindingNavigator.PerformLayout()
        CType(Me.T26_formule_prezziBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestioneProduzione2009DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.T26_formule_prezziDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDetail.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GestioneProduzione2009DataSet As GestioneProduzione2014Data.GestioneProduzione2009DataSet
    Friend WithEvents T26_formule_prezziBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T26_formule_prezziTableAdapter As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t26_formule_prezziTableAdapter
    Friend WithEvents T26_formule_prezziBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T26_formule_prezziBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlGrid As System.Windows.Forms.Panel
    Friend WithEvents T26_formule_prezziDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents pnlDetail As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnFisso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumnMoltiplica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t26_arrotondamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSconto As System.Windows.Forms.TextBox
    Friend WithEvents T31_configurazioneTableAdapter1 As GestioneProduzione2014Data.GestioneProduzione2009DataSetTableAdapters.t31_configurazioneTableAdapter
End Class
