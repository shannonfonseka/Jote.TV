Imports System.ComponentModel
Imports AxAXVLC

Public Class frmVideoPlayer
    Dim control As String = "show"
    Public pipmode As Boolean = True
    Private Sub frmVideoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flowpanelControls.Size = New Point(232, 40)
        CenterControls()
        setupUI()
        tmrControls.Enabled = True
    End Sub
    Public Sub setupUI()
        btnToPlayer.Hide()
        btn10.Hide()
        btnPlay.Hide()
        btn30.Hide()
        btnStop.Hide()

        btnToPlayer.Show()
        btn10.Show()
        btnPlay.Show()
        btn30.Show()
        btnStop.Show()

        If Form1.lblContentType.Text = "Jote TV" Then
            btn30.Hide()
            btn10.Hide()
            btnPlay.Hide()
            lblSpacer2.Visible = True
            lblSpacer.Visible = False
            trkbrSeekbar.Enabled = False
        ElseIf Form1.lblContentType.Text = "Jote Radio" Then
            lblSpacer2.Visible = True
            lblSpacer2.Visible = False
            btn30.Hide()
            trkbrSeekbar.Enabled = False
        ElseIf Form1.lblContentType.Text = "Jote Movies+TV" Then
            btnToPlayer.Show()
            btn10.Show()
            btnPlay.Show()
            btn30.Show()
            btnStop.Show()
            lblSpacer.Visible = False
            lblSpacer2.Visible = False
            trkbrSeekbar.Enabled = True
        End If
    End Sub

    Private Sub frmVideoPlayer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Form1.Show()
        pipmode = False
        btnPiP_Click(sender, e)
        CenterControls()
        Me.Hide()
    End Sub
    Public Sub CenterControls()
        flowpanelControls.Top = (panelControls.Height / 1.5) - (flowpanelControls.Height / 1.5)
        flowpanelControls.Left = (panelControls.Width / 2) - (flowpanelControls.Width / 2)
    End Sub

    Private Sub frmVideoPlayer_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterControls()
        'lblNowPlaying.Text = Me.Size.ToString
    End Sub

    Private Sub tmrTrackbar_Tick(sender As Object, e As EventArgs) Handles tmrTrackbar.Tick
        Dim totallength As Double = Me.axvlcVideoPlayer.input.length
        Dim lengthplayed As Double = Me.axvlcVideoPlayer.input.time
        Dim tl As TimeSpan = TimeSpan.FromMilliseconds(totallength)
        Dim lp As TimeSpan = TimeSpan.FromMilliseconds(lengthplayed)
        Try
            With trkbrSeekbar
                .Minimum = 0
                .Maximum = Me.axvlcVideoPlayer.input.length
            End With
            trkbrSeekbar.Value = Me.axvlcVideoPlayer.input.time
        Catch ex As Exception

        End Try
        Try
            If tl.Hours.ToString >= 1 Then
                lblTimeElapsed.Text = lp.Hours.ToString & ":" & lp.Minutes.ToString & ":" & lp.Seconds.ToString
                lblTimeTotal.Text = tl.Hours.ToString & ":" & tl.Minutes.ToString & ":" & tl.Seconds.ToString
            Else
                lblTimeElapsed.Text = lp.Minutes.ToString & ":" & lp.Seconds.ToString
                lblTimeTotal.Text = tl.Minutes.ToString & ":" & tl.Seconds.ToString
            End If
            'Me.lblNowPlaying.Text = Me.axvlcVideoPlayer.mediaDescription.title + " - " + Me.axvlcVideoPlayer.mediaDescription.nowPlaying
        Catch ex As Exception
            lblTimeElapsed.Text = "--:--"
            lblTimeTotal.Text = "--:--"
        End Try
    End Sub

    Private Sub trkbrSeekbar_Scroll(sender As Object, e As ScrollEventArgs) Handles trkbrSeekbar.Scroll
        Me.axvlcVideoPlayer.input.time = trkbrSeekbar.Value
        Me.axvlcVideoPlayer.playlist.play()
        If Me.axvlcVideoPlayer.playlist.isPlaying = True Then
            'pause
            btnPlay.Text = ""
            My.Settings.settingsPlaystatus = "play"
        Else
            trkbrSeekbar.Value = 0
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        playbutton()
    End Sub
    Private Sub playbutton()
        If btnPlay.Text = "" Then 'play
            'pause
            btnPlay.Text = ""
            Form1.btnPlay.Text = ""
            Me.axvlcVideoPlayer.playlist.play()
        Else
            'play
            btnPlay.Text = ""
            Form1.btnPlay.Text = ""
            Me.axvlcVideoPlayer.playlist.pause()
        End If
        If My.Settings.settingsPlaystatus = "stop" Then
            'play
            btnPlay.Text = ""
            Form1.btnPlay.Text = ""
            Me.axvlcVideoPlayer.playlist.pause()
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopbutton()
        If My.Settings.settingsPlaystatus <> "stop" Then
            pipmode = False
            btnPiP_Click(sender, e)
        End If
    End Sub
    Private Sub stopbutton()
        Me.axvlcVideoPlayer.playlist.stop()
        Me.axvlcVideoPlayer.playlist.items.clear()
        trkbrSeekbar.Value = 0
        Form1.trkbrSeekbar.Value = 0
        'play
        btnPlay.Text = ""
        Form1.btnPlay.Text = ""
        If My.Settings.settingsPlaystatus <> "stop" Then
            Me.Hide()
            Me.Close()
        End If
        My.Settings.settingsPlaystatus = "stop"
        lblNowPlaying.Text = "Nothing playing right now, select from the library."
    End Sub

    Private Sub btnToPlayer_Click(sender As Object, e As EventArgs) Handles btnToPlayer.Click
        Me.Hide()
        pipmode = False
        btnPiP_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub axvlcVideoPlayer_ClickEvent(sender As Object, e As EventArgs) Handles axvlcVideoPlayer.ClickEvent
        If panelControls.Visible = False Then
            panelControls.Visible = True
            panelHeading.Visible = True
            tmrControls.Enabled = True
            CenterControls()
        Else
            panelControls.Visible = False
            panelHeading.Visible = False
            CenterControls()
        End If
        panelHint.Hide()
        CenterControls()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If Me.axvlcVideoPlayer.input.time > 10000 Then
            Me.axvlcVideoPlayer.input.time -= 10000
        Else
            Me.axvlcVideoPlayer.input.time = 0
        End If
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        Dim checklength As Integer
        checklength = Me.axvlcVideoPlayer.input.length - Me.axvlcVideoPlayer.input.time
        If checklength > 30000 Then
            Me.axvlcVideoPlayer.input.time += 30000
        Else
            Me.axvlcVideoPlayer.input.time = Me.axvlcVideoPlayer.input.length
        End If
    End Sub
    Private Sub PlaypauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaypauseToolStripMenuItem.Click
        playbutton()
    End Sub
    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        stopbutton()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
        frmSettings.Focus()
    End Sub

    Private Sub btnFullscreen_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        fullscreenbutton()
    End Sub
    Private Sub fullscreenbutton()
        If Me.WindowState = FormWindowState.Maximized And Me.FormBorderStyle = FormBorderStyle.None Then
            'normal
            FormBorderStyle = FormBorderStyle.Sizable
            WindowState = FormWindowState.Maximized
            btnPiP.Show()
            btnFullscreen.Text = ""
        Else
            'fullscreen
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Normal
            Me.WindowState = FormWindowState.Maximized
            btnPiP.Hide()
            btnFullscreen.Text = ""
            tmrControls.Enabled = True
        End If
    End Sub
    Private Sub FullscreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullscreenToolStripMenuItem.Click
        panelControls.Visible = True
        panelHeading.Visible = True
        tmrControls.Enabled = True
        If btnFullscreen.Visible = True Then
            fullscreenbutton()
        End If
    End Sub

    Private Sub axvlcVideoPlayer_MediaPlayerEncounteredError(sender As Object, e As EventArgs) Handles axvlcVideoPlayer.MediaPlayerEncounteredError
        stopbutton()
        Dim msgresult As DialogResult = MessageBox.Show("Jote.TV is unable to open the stream. Make sure you are connected to the internet or the stream might be unavailable.", "Could not load stream.",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub btnPiP_Click(sender As Object, e As EventArgs) Handles btnPiP.Click
        If pipmode = True Then
            pipmode = False
            MinimumSize = New Size(0, 0)
            FormBorderStyle = FormBorderStyle.None
            WindowState = FormWindowState.Normal
            Size = New Size(451, 253)
            Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Width), (Screen.PrimaryScreen.WorkingArea.Height - Height))
            Me.TopMost = True
            btnFullscreen.Hide()
            btnPiP.Text = ""
            tmrControls.Enabled = True
            Me.Opacity = 0.1 + My.Settings.settingsOpacity / 100
        Else
            pipmode = True
            MinimumSize = New Size(380, 380)
            FormBorderStyle = FormBorderStyle.Sizable
            Size = New Size(714, 440)
            Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2)
            Me.TopMost = False
            WindowState = FormWindowState.Maximized
            btnFullscreen.Show()
            btnPiP.Text = ""
            Me.Opacity = 100
        End If
    End Sub

    Private Sub ShowhideControlsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowhideControlsToolStripMenuItem.Click
        axvlcVideoPlayer_ClickEvent(sender, e)
    End Sub

    Private Sub tmrControls_Tick(sender As Object, e As EventArgs) Handles tmrControls.Tick
        panelControls.Visible = False
        panelHeading.Visible = False
        tmrControls.Enabled = False
        panelHint.Hide()
    End Sub

    Private Sub frmVideoPlayer_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        panelControls.Visible = True
        panelHeading.Visible = True
        tmrControls.Enabled = True
        panelHint.Hide()
    End Sub
End Class