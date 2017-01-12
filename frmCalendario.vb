Public Class frmCalendario
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnNow As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnNow = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(8, 8)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(155, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "OK"
        '
        'btnNow
        '
        Me.btnNow.Location = New System.Drawing.Point(8, 8)
        Me.btnNow.Name = "btnNow"
        Me.btnNow.Size = New System.Drawing.Size(75, 23)
        Me.btnNow.TabIndex = 3
        Me.btnNow.Text = "Oggi"
        Me.btnNow.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNow)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 40)
        Me.Panel1.TabIndex = 4
        '
        'frmCalendario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(242, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "frmCalendario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmCalendario"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNow.Click
        MonthCalendar1.SetDate(DateTime.Now())
    End Sub

    Public Data As DateTime
    Public Messaggio As String = ""

    Private Sub frmCalendario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Data = Nothing Then
            Data = DateTime.Now
        End If

        MonthCalendar1.SetDate(Data)
        Me.Text = Messaggio
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Data = MonthCalendar1.dat
        Me.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Data = e.Start()
    End Sub
End Class
