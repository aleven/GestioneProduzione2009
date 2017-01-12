<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain2
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SituazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArticoliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GruppiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MacchineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(134, 251)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchiviToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(134, 273)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchiviToolStripMenuItem
        '
        Me.ArchiviToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SituazioneToolStripMenuItem, Me.ToolStripMenuItem1, Me.InventarioToolStripMenuItem, Me.ArticoliToolStripMenuItem, Me.GruppiToolStripMenuItem, Me.MacchineToolStripMenuItem})
        Me.ArchiviToolStripMenuItem.Name = "ArchiviToolStripMenuItem"
        Me.ArchiviToolStripMenuItem.ShortcutKeyDisplayString = "1"
        Me.ArchiviToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.ArchiviToolStripMenuItem.Size = New System.Drawing.Size(127, 17)
        Me.ArchiviToolStripMenuItem.Text = "Archivi"
        '
        'SituazioneToolStripMenuItem
        '
        Me.SituazioneToolStripMenuItem.AutoSize = False
        Me.SituazioneToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.games_difficult
        Me.SituazioneToolStripMenuItem.Name = "SituazioneToolStripMenuItem"
        Me.SituazioneToolStripMenuItem.ShortcutKeyDisplayString = "Alt+A"
        Me.SituazioneToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SituazioneToolStripMenuItem.Size = New System.Drawing.Size(152, 38)
        Me.SituazioneToolStripMenuItem.Text = "Situazione"
        Me.SituazioneToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.SituazioneToolStripMenuItem.ToolTipText = "Alt+A"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.edit_paste
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ArticoliToolStripMenuItem
        '
        Me.ArticoliToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledyellow1
        Me.ArticoliToolStripMenuItem.Name = "ArticoliToolStripMenuItem"
        Me.ArticoliToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.ArticoliToolStripMenuItem.Text = "Articoli"
        '
        'GruppiToolStripMenuItem
        '
        Me.GruppiToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledorange1
        Me.GruppiToolStripMenuItem.Name = "GruppiToolStripMenuItem"
        Me.GruppiToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.GruppiToolStripMenuItem.Text = "Gruppi"
        '
        'MacchineToolStripMenuItem
        '
        Me.MacchineToolStripMenuItem.Image = Global.GestioneProduzione.My.Resources.Resources.ledpurple1
        Me.MacchineToolStripMenuItem.Name = "MacchineToolStripMenuItem"
        Me.MacchineToolStripMenuItem.Size = New System.Drawing.Size(168, 38)
        Me.MacchineToolStripMenuItem.Text = "Macchine"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'frmMain2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 273)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Produzione 2009"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchiviToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArticoliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GruppiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MacchineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
End Class
