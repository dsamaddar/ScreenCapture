Imports Microsoft.Win32

Public Class frmScrCap

    Protected Sub CaptureScreen()
        Try
            Dim bounds As Rectangle
            Dim screenshot As System.Drawing.Bitmap
            Dim graph As Graphics
            Dim FileName As String = Environment.UserName & "_" & Now.Year & "_" & Now.Month & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & "_" & Now.Ticks.ToString()

            bounds = Screen.PrimaryScreen.Bounds
            screenshot = New System.Drawing.Bitmap(bounds.Width, bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb)
            graph = Graphics.FromImage(screenshot)
            graph.CopyFromScreen(0, 0, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy)
            screenshot.Save("\\WSID-175\ScreenCapture$\" & FileName & ".jpg", Imaging.ImageFormat.Bmp)
            graph.Dispose()
            screenshot.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmScrCap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler SystemEvents.SessionSwitch, AddressOf Switch
        'RemoveHandler SystemEvents.SessionSwitch, AddressOf Switch
    End Sub

    Private Sub timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        CaptureScreen()
    End Sub

    Private Sub Switch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        Select Case e.Reason
            Case SessionSwitchReason.SessionLock
                timer.Enabled = False
            Case SessionSwitchReason.SessionUnlock
                timer.Enabled = True
        End Select
    End Sub

    Private Sub frmScrCap_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.Visible = False
        notificationIcon.Visible = False
    End Sub
End Class
