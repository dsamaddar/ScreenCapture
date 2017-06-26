<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScrCap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScrCap))
        Me.notificationIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'notificationIcon
        '
        Me.notificationIcon.Icon = CType(resources.GetObject("notificationIcon.Icon"), System.Drawing.Icon)
        Me.notificationIcon.Text = "Scr Cap"
        Me.notificationIcon.Visible = True
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 60000
        '
        'frmScrCap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(116, 0)
        Me.Name = "frmScrCap"
        Me.Text = "Reliance Finance Limited"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents notificationIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents timer As System.Windows.Forms.Timer

End Class
