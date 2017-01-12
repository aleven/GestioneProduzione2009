<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOfferta2Commessa
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCommessaNum = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCommessaData = New System.Windows.Forms.MonthCalendar
        Me.btnConfirm = New System.Windows.Forms.Button
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Commessa"
        '
        'txtCommessaNum
        '
        Me.txtCommessaNum.Location = New System.Drawing.Point(117, 12)
        Me.txtCommessaNum.Name = "txtCommessaNum"
        Me.txtCommessaNum.Size = New System.Drawing.Size(157, 20)
        Me.txtCommessaNum.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data"
        '
        'txtCommessaData
        '
        Me.txtCommessaData.Location = New System.Drawing.Point(117, 44)
        Me.txtCommessaData.Name = "txtCommessaData"
        Me.txtCommessaData.TabIndex = 4
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.Image = Global.GestioneProduzione.My.Resources.Resources.apply
        Me.btnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirm.Location = New System.Drawing.Point(152, 217)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(125, 31)
        Me.btnConfirm.TabIndex = 36
        Me.btnConfirm.Text = "Conferma"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnAnnulla.Image = Global.GestioneProduzione.My.Resources.Resources.undo
        Me.btnAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnnulla.Location = New System.Drawing.Point(21, 218)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(125, 30)
        Me.btnAnnulla.TabIndex = 37
        Me.btnAnnulla.Text = "&Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'frmOfferta2Commessa
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnAnnulla
        Me.ClientSize = New System.Drawing.Size(298, 260)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCommessaNum)
        Me.Controls.Add(Me.txtCommessaData)
        Me.Name = "frmOfferta2Commessa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Crea Commessa da Offerta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCommessaNum As System.Windows.Forms.TextBox
    Friend WithEvents txtCommessaData As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
End Class
