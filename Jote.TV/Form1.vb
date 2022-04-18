Imports System.ComponentModel
Imports System.IO
Imports System.Net
Public Class Form1
    Dim file As IO.StreamReader
    Dim filepath As String = Application.StartupPath & "\Playlists\"
    Dim filename As String
    Dim updatefilepath As String = Application.StartupPath & "\Program-Information\"
    Dim updatefilename As String
    Dim logfilepath As String = Application.StartupPath & "\Program-Information\"
    Public WithEvents playlistdownloader As New WebClient
    Public WithEvents updatechecker As New WebClient
    Public WithEvents updatedownloader As New WebClient
    Dim BaseVersion = "1.37" 'FIRST CHANGE THE VERSION BEFORE ANY CHANGE!!!    

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If System.IO.File.Exists(logfilepath + "Log-Information.txt") = True Then
                rchtxtbxLogger.LoadFile(logfilepath + "Log-Information.txt", RichTextBoxStreamType.PlainText)
                addblanktoLog()
                addtoLog("Log file loaded")
            Else
                Directory.CreateDirectory(filepath)
                Directory.CreateDirectory(updatefilepath)
                createlogger()
                addtoLog("Created directories")
            End If
            addblanktoLog()
            addtoLog(Date.Now.ToString("[MMMM dd, yyyy]") + Environment.NewLine + " ~~Session Started~~")
            Me.Size = New Point(312, 440)
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
            lblContentType.Text = My.Settings.settingsContentType
            lblError.Location = New Point(8, 88)
            lblError.Size = New Size(280, 200)
            btnExceptionWindow.Location = New Point(56, 368)
            panelDownloadStatus.Location = New Point(0, 352)
            panelDownloadStatus.Size = New Size(296, 48)
            hideUIforLabel()
            My.Settings.settingsPlaystatus = "stop"

            If My.Settings.settingsWelcome = False Then
                frmWelcome.Show()
                frmWelcome.Focus()
                addtoLog("Privacy policy screen shown")
                Me.ShowInTaskbar = False
            ElseIf My.Settings.settingsUpdateCheck = "On startup" Then
                lblError.Text = "Checking for new updates..."
                tmrUpdates.Enabled = True
            ElseIf My.Settings.settingsUpdateCheck = "Never" Then
                tmrDownloadPlaylist.Enabled = True
                lblError.Text = "Loading..."
            End If
            setupUI()
            applytoplayer()
            addtoLog("Load UI finished")
        Catch ex As Exception
            exceptionhandler("Error Code: Err_FrmLoad_. Better send an issue to developer", ex.ToString)
            Me.Size = New Point(312, 440)
            Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
            lblContentType.Text = My.Settings.settingsContentType
            lblError.Location = New Point(8, 88)
            lblError.Size = New Size(280, 200)
            btnExceptionWindow.Location = New Point(56, 368)
        End Try
    End Sub

    Private Sub applytoplayer()
        frmVideoPlayer.axvlcVideoPlayer.video.aspectRatio = My.Settings.settingsAspectRatio
        frmVideoPlayer.axvlcVideoPlayer.video.crop = My.Settings.settingsCrop
    End Sub

    Private Sub setupUI()
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

        If My.Settings.settingsContentType = "Jote TV" Then
            btn30.Hide()
            btn10.Hide()
            btnPlay.Hide()
            lblSpacer2.Visible = True
            lblSpacer.Visible = False
            trkbrSeekbar.Enabled = False
        ElseIf My.Settings.settingsContentType = "Jote Radio" Then
            lblSpacer2.Visible = True
            lblSpacer2.Visible = False
            trkbrSeekbar.Enabled = False
            btn30.Hide()
        ElseIf My.Settings.settingsContentType = "Jote Movies+TV" Or My.Settings.settingsContentType = "Jote Podcast" Then
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrDownloadPlaylist.Tick
        tmrDownloadPlaylist.Enabled = False
        tmrDownloadPlaylist.Interval = 100
        prgsbrLoading.Show()
        prgsbrLoading.Value = 0
        addtoLog("Download playlist session started")
            hideUIforLabel()
            lblError.Text = "Loading..."

            'DELETE UPDATE CACHE
            updatefilename = updatefilepath + "update.exe"
        If System.IO.File.Exists(updatefilename) = True Then
            System.IO.File.Delete(updatefilename)
            addtoLog("Update cache deleted successfully")
        End If

        updatefilename = updatefilepath + "messages.txt"
        Directory.CreateDirectory(updatefilepath)
            If System.IO.File.Exists(updatefilename) = True Then
                System.IO.File.Delete(updatefilename)
                addtoLog("Deleted pre existing playlist cache")
            End If

            'Jote TV
            'Jote Radio
            'Jote Movies + TV
            'Jote Podcast
            'Jote Experimental
            addtoLog("Start playlist download")
        If My.Settings.settingsContentType = "Jote TV" Then
            'Jote TV
            addtoLog("Load TV playlist")
            filename = filepath + "channels.jotetv_playlist"
            playlistdownloader.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/shannonfonseka/Jote-TV/master/Channels/Jote%20TV%20channels.txt".ToString), filename)
        ElseIf My.Settings.settingsContentType = "Jote Radio" Then
            'Jote Radio
            addtoLog("Load Radio playlist")
            filename = filepath + "channels.jotetv_playlist"
            playlistdownloader.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/shannonfonseka/Jote-TV/master/Channels/Jote%20FM%20Channels.txt"), filename)
        End If
    End Sub
    Private Sub playlistdownloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles playlistdownloader.DownloadFileCompleted
        If Not e.Cancelled AndAlso e.Error Is Nothing Then

            addtoLog("Playlist downloaded")
            addtoLog("End playlist download")
            lblError.Hide()
            btnRefresh.Hide()
            prgsbrLoading.Hide()
            addtoLog("Load UI for playlist started")
            lstbxTemp.Items.Clear()
            file = New IO.StreamReader(Application.StartupPath & "\Playlists\channels.jotetv_playlist")
            While file.Peek() > -1
                lstbxTemp.Items.Add(file.ReadLine)
            End While
            file.Close()
            file.Dispose()
            sortplaylist()

            lstbxChannels.Items.Clear()
            For count = 0 To lstbxNames.Items.Count - 1
                lstbxChannels.Items.Add(lstbxNames.Items(count))
            Next
            channelcount()
            cmbxSort.selectedIndex = 0
            addtoLog("Loaded playlist file channels to Jote.TV")
            addtoLog("Playlist loaded successfully")
            showUI()
            Try
                lstbxChannels.SelectedIndex = 0
            Catch ex As Exception

            End Try
            addtoLog("Load UI for playlist finished")
            addtoLog("Download playlist session ended")
            encryptPlaylist()
            addtoLog("User is ready to use Jote.TV")
        Else
            'MessageBox.Show(e.Error.ToString)
            If e.Error.ToString.Contains("raw.githubusercontent.com") Then
                hideUIforRefresh()
                tmrDownloadPlaylist.Enabled = False
                lblError.Text = "Uh..Oh, looks like you are not connected to the internet.  Connect to a network and try again." + Environment.NewLine + Environment.NewLine + "Error Code:  NO_INTERNET"
                readyexceptionhandler("Error Code:  NO_INTERNET", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("Unable to connect to the remote server") Then
                hideUIforLabel()
                tmrDownloadPlaylist.Enabled = False
                lblError.Text = "Uh..Oh, Jote.TV can't connect with our server.  Try again later." + Environment.NewLine + Environment.NewLine + "Error Code: CONNECTION_LOST"
                readyexceptionhandler("Error Code: CONNECTION_LOST", "This error can be resolved by user.")
                tmrDownloadPlaylist.Interval = 4500
                tmrDownloadPlaylist.Enabled = True

            ElseIf e.Error.ToString.Contains("The operation has timed out") Then
                hideUIforRefresh()
                tmrDownloadPlaylist.Enabled = False
                lblError.Text = "Uh..Oh, looks like your internet connection has timed out. Check back again by connecting to another network." + Environment.NewLine + Environment.NewLine + "Error Code: CONNECTION_TIMED_OUT"
                readyexceptionhandler("Error Code: CONNECTION_TIMED_OUT", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("process cannot access the file") Then
                stopbutton()
                hideUIforLabel()
                lblError.Text = "An error occurred when saving the files! Close any programs that may interfere with the playlists and re-open this program." + Environment.NewLine + Environment.NewLine + "Error Code: ERROR_SAVEFILE"
                readyexceptionhandler("Error Code: ERROR_SAVEFILE", "This error can be resolved by user.")
                tmrDownloadPlaylist.Enabled = False

            ElseIf e.Error.ToString.Contains("Could not find file") Then
                stopbutton()
                hideUIforSettings()

                lblError.Text = "Jote.TV could not find the file. This could be certain anti-virus programs interfering." + Environment.NewLine + Environment.NewLine + "Error Code: ERROR_FILE_NOTFOUND"
                readyexceptionhandler("Error Code: ERROR_FILE_NOTFOUND", "This error can be resolved by user.")
                '+= (Environment.NewLine + Me.CodeEditor.Text + Environment.NewLine)
                tmrDownloadPlaylist.Enabled = False
            ElseIf e.Error.ToString.Contains("A socket operation was attempted to an unreachable network") Then
                stopbutton()
                lblVersion.Text = "VersionPending"
                lblDownloaded.Text = "Gathering information for update..."
                prgsbrDone.Style = ProgressBarStyle.Marquee
                hideUIforRefresh()
                lblError.Text = "A change of network/IP address was detected (sometimes IP address is missing). Try connecting to another network and refresh again." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_NETWORK_IP_ADDRESS_CHANGE"
                tmrUpdates.Enabled = False
                readyexceptionhandler("Error Code: ERROR_NETWORK_IP_ADDRESS_CHANGE", "This error can be resolved by user.")

            Else
                exceptionhandler("Error (Exception Handler was called): " + e.Error.ToString + ". Better send an issue to developer", e.Error.ToString)
            End If
        End If
    End Sub

    Public Sub exceptionhandler(errorlog As String, errorexception As String)
        'call the exception handler
        tmrDownloadPlaylist.Enabled = False
        frmVideoPlayer.axvlcVideoPlayer.playlist.stop()
        lstbxChannels.Hide()
        cmbxSort.Hide()
        btnRefresh.Hide()
        lblError.Show()
        btnRefresh2.Hide()
        btnSettings.Hide()
        frmLogger.txtbxException.Text = errorexception.ToString
        frmLogger.txtbxLog.Text = Date.Now.ToString("[dd/MMMM/yyyy][h:mm:ss tt] ") + errorlog.ToString
        addtoLog(errorlog.ToString)
        frmLogger.Show()
        frmLogger.Focus()
        lblError.Text = "The application is in BREAK MODE." + Environment.NewLine + "Refer to the Exception Handler window for more information."
        lblError.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnExceptionWindow.Show()
        frmLogger.produceClipboard()
    End Sub

    Public Sub readyexceptionhandler(errorlog As String, errorexception As String)
        'call the ready exception handler
        tmrDownloadPlaylist.Enabled = False
        frmVideoPlayer.axvlcVideoPlayer.playlist.stop()
        lstbxChannels.Hide()
        cmbxSort.Hide()
        lblError.Show()
        frmLogger.txtbxException.Text = errorexception.ToString
        frmLogger.txtbxLog.Text = Date.Now.ToString("[dd/MMMM/yyyy][h:mm:ss tt] ") + errorlog.ToString
        addtoLog(errorlog.ToString)
        'btnExceptionWindow.Show()
        frmLogger.produceClipboard()
    End Sub

    Private Sub sortplaylist()
        If lstbxTemp.Items.Count >= 401 Then
            Dim msgresult As DialogResult = MessageBox.Show("Jote.TV exceeded the maximum capacity for channel storage the maximum limit is only 400 channels. Contact our services for issues with channels.",
                               "Warning!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1)
            End
        Else
            lstbxLinks.Items.Clear()
            lstbxNames.Items.Clear()
            Dim nextchar As Integer
            Dim str As String
            For count = 0 To lstbxTemp.Items.Count - 1
                str = ""
                nextchar = 0
                'listbox which contain combined string
                lstbxTemp.SelectedIndex = count
                Do Until lstbxTemp.SelectedItem(nextchar) = "|"
                    str += lstbxTemp.SelectedItem(nextchar)
                    nextchar += 1
                Loop
                'Name list
                lstbxNames.Items.Add(str)
                str = ""
                nextchar += 1
                Do Until lstbxTemp.SelectedItem(nextchar) = "#"
                    str += lstbxTemp.SelectedItem(nextchar)
                    nextchar += 1
                Loop
                'other list
                lstbxLinks.Items.Add(str)
            Next
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If My.Settings.settingsUpdateCheck = "On startup" And lblVersion.Text = "VersionPending" Then
            tmrUpdates.Enabled = True
            lblError.Text = "Checking for new updates..."
            btnRefresh.Hide()
            btnRefresh2.Hide()
        Else
            tmrDownloadPlaylist.Enabled = True
            lblError.Text = "Loading..."
            btnRefresh.Hide()
            btnRefresh2.Hide()
        End If
        btnExceptionWindow.Hide()
    End Sub

    Private Sub GotoPlayer()
        frmVideoPlayer.Show()
        frmVideoPlayer.FormBorderStyle = FormBorderStyle.Sizable
        frmVideoPlayer.WindowState = FormWindowState.Maximized
        frmVideoPlayer.panelControls.Visible = True
        frmVideoPlayer.panelHeading.Visible = True
        frmVideoPlayer.tmrControls.Enabled = True
        frmVideoPlayer.CenterControls()
        frmVideoPlayer.btnFullscreen.Text = ""
        frmVideoPlayer.btnPiP.Show()
        Me.Hide()
    End Sub

    Private Sub btnToPlayer_Click(sender As Object, e As EventArgs) Handles btnToPlayer.Click
        If lblContentType.Text <> "Jote Radio" And lblContentType.Text <> "Jote Podcast" Then
            If My.Settings.settingsPlaystatus <> "stop" Then
                GotoPlayer()
                frmVideoPlayer.pipmode = False
                frmVideoPlayer.btnPiP_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub tmrTrackbar_Tick(sender As Object, e As EventArgs) Handles tmrTrackbar.Tick
        Dim totallength As Double = frmVideoPlayer.axvlcVideoPlayer.input.length
        Dim lengthplayed As Double = frmVideoPlayer.axvlcVideoPlayer.input.time
        Dim tl As TimeSpan = TimeSpan.FromMilliseconds(totallength)
        Dim lp As TimeSpan = TimeSpan.FromMilliseconds(lengthplayed)
        Try
            With trkbrSeekbar
                .Minimum = 0
                .Maximum = frmVideoPlayer.axvlcVideoPlayer.input.length
            End With
            trkbrSeekbar.Value = frmVideoPlayer.axvlcVideoPlayer.input.time
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
        Catch ex As Exception
            lblTimeElapsed.Text = "--:--"
            lblTimeTotal.Text = "--:--"
        End Try
    End Sub

    Private Sub trkbrSeekbar_Scroll(sender As Object, e As ScrollEventArgs) Handles trkbrSeekbar.Scroll
        frmVideoPlayer.axvlcVideoPlayer.input.time = trkbrSeekbar.Value
        frmVideoPlayer.axvlcVideoPlayer.playlist.play()
        If frmVideoPlayer.axvlcVideoPlayer.playlist.isPlaying = True Then
            'pause
            btnPlay.Text = ""
            My.Settings.settingsPlaystatus = "play"
        Else
            trkbrSeekbar.Value = 0
        End If
    End Sub

    Private Sub lstbxChannels_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxChannels.SelectedIndexChanged
        lstbxNames.SelectedItem = lstbxChannels.SelectedItem
    End Sub

    Private Sub lstbxNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxNames.SelectedIndexChanged
        lstbxLinks.SelectedIndex = lstbxNames.SelectedIndex
    End Sub

    Private Sub startplayback()
        Dim tempname As String
        frmVideoPlayer.axvlcVideoPlayer.playlist.stop()
        frmVideoPlayer.axvlcVideoPlayer.playlist.items.clear()
        frmVideoPlayer.axvlcVideoPlayer.playlist.add(lstbxLinks.SelectedItem)
        frmVideoPlayer.axvlcVideoPlayer.playlist.play()
        tempname = "Now playing: " + lstbxNames.SelectedItem
        'pause
        Me.btnPlay.Text = ""
        frmVideoPlayer.btnPlay.Text = ""
        My.Settings.settingsPlaystatus = "play"
        trkbrSeekbar.Value = 0
        frmVideoPlayer.trkbrSeekbar.Value = 0
        frmVideoPlayer.lblNowPlaying.Text = tempname
        If lblContentType.Text = "Jote TV" Or lblContentType.Text = "Jote Movies+TV" Then
            GotoPlayer()
        End If
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        playbutton()
    End Sub

    Private Sub playbutton()
        If btnPlay.Text = "" Then 'play
            'pause
            btnPlay.Text = ""
            frmVideoPlayer.btnPlay.Text = ""
            frmVideoPlayer.axvlcVideoPlayer.playlist.play()
        Else
            'play
            btnPlay.Text = ""
            frmVideoPlayer.btnPlay.Text = ""
            frmVideoPlayer.axvlcVideoPlayer.playlist.pause()
        End If
        If My.Settings.settingsPlaystatus = "stop" Then
            'play
            btnPlay.Text = ""
            frmVideoPlayer.btnPlay.Text = ""
            frmVideoPlayer.axvlcVideoPlayer.playlist.pause()
        End If
    End Sub

    Public Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        stopbutton()
    End Sub

    Private Sub stopbutton()
        frmVideoPlayer.axvlcVideoPlayer.playlist.stop()
        frmVideoPlayer.axvlcVideoPlayer.playlist.items.clear()
        trkbrSeekbar.Value = 0
        frmVideoPlayer.trkbrSeekbar.Value = 0
        'play
        btnPlay.Text = ""
        frmVideoPlayer.btnPlay.Text = ""
        My.Settings.settingsPlaystatus = "stop"
        frmVideoPlayer.lblNowPlaying.Text = "Nothing playing right now, select from the library."
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If frmVideoPlayer.axvlcVideoPlayer.input.time > 10000 Then
            frmVideoPlayer.axvlcVideoPlayer.input.time -= 10000
        Else
            frmVideoPlayer.axvlcVideoPlayer.input.time = 0
        End If
    End Sub

    Private Sub btn30_Click(sender As Object, e As EventArgs) Handles btn30.Click
        Dim checklength As Integer
        checklength = frmVideoPlayer.axvlcVideoPlayer.input.length - frmVideoPlayer.axvlcVideoPlayer.input.time
        If checklength > 30000 Then
            frmVideoPlayer.axvlcVideoPlayer.input.time += 30000
        Else
            frmVideoPlayer.axvlcVideoPlayer.input.time = frmVideoPlayer.axvlcVideoPlayer.input.length
        End If
    End Sub

    Private Sub btnRefresh2_Click(sender As Object, e As EventArgs) Handles btnRefresh2.Click
        lblError.Font = New Font("Segoe UI", 8.25, FontStyle.Regular)
        cmbxSort.selectedIndex = 0
        If My.Settings.settingsPlaystatus = "play" Then
            Dim msgresult As DialogResult = MessageBox.Show("Refreshing a playlist would need stop playback." +
                                                            " Do you want to refresh?",
                           "Stop playback?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1)
            If msgresult = DialogResult.Yes Then
                refreshbutton()
            Else
                My.Settings.settingsContentType = lblContentType.Text
                My.Settings.Save()
                btnRefresh2.Hide()
                frmSettings.Close()
            End If
        Else
            refreshbutton()
        End If
    End Sub

    Private Sub refreshbutton()
        lblContentType.Text = My.Settings.settingsContentType
        stopbutton()
        tmrDownloadPlaylist.Enabled = True
        setupUI()
        frmVideoPlayer.setupUI()
        lblError.Text = "Loading..."
        hideUIforLabel()
        frmSettings.Close()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
        frmSettings.Focus()
        'btnRefresh2.Hide()
        If My.Settings.settingsContentType <> lblContentType.Text Then
            frmSettings.lblDesc.Text = "Press the refresh button in the library window to make changes."
            frmSettings.lblDesc.ForeColor = Color.OrangeRed
        End If
    End Sub

    Private Sub lstbxChannels_DoubleClick(sender As Object, e As EventArgs) Handles lstbxChannels.DoubleClick
        displayplaybackmessage()
    End Sub

    Private Sub displayplaybackmessage()
        Dim msgresult As DialogResult = MessageBox.Show("Do you want to start playback: " + lstbxChannels.SelectedItem.ToString + "?",
           "Start playback",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.None,
    MessageBoxDefaultButton.Button1)
        If msgresult = DialogResult.Yes Then
            startplayback()
        End If
    End Sub

    Private Sub lstbxChannels_KeyDown(sender As Object, e As KeyEventArgs) Handles lstbxChannels.KeyDown
        If e.KeyCode = Keys.Enter Then
            displayplaybackmessage()
        End If
    End Sub

    Private Sub PlaypauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaypauseToolStripMenuItem.Click
        playbutton()
    End Sub

    Private Sub GotoPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GotoPlayerToolStripMenuItem.Click
        GotoPlayer()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        stopbutton()
    End Sub

    Private Sub tmrUpdates_Tick(sender As Object, e As EventArgs) Handles tmrUpdates.Tick
        prgsbrLoading.Show()
        prgsbrLoading.Value = 0
        addtoLog("Check for updates session started")
        updatefilename = updatefilepath + "update.txt"
        Directory.CreateDirectory(updatefilepath)
        If System.IO.File.Exists(updatefilename) = True Then
            System.IO.File.Delete(updatefilename)
        End If
        addtoLog("Deleted pre existing update cache")
        'download update list
        updatefilename = updatefilepath + "update.txt"
        updatechecker.DownloadFileAsync(New Uri("https://raw.githubusercontent.com/shannonfonseka/Jote-TV/master/Other%20information/Update-Information.txt"), updatefilename)
        tmrUpdates.Enabled = False
    End Sub

    Private Sub updatechecker_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles updatechecker.DownloadFileCompleted
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            'set lblVersion to update version
            addtoLog("Update information downloaded")
            file = New IO.StreamReader(updatefilepath + "update.txt")
            lstbxTemp.Items.Clear()
            While file.Peek() > -1
                lstbxTemp.Items.Add(file.ReadLine)
            End While
            file.Close()
            prgsbrLoading.Hide()
            lstbxTemp.SelectedIndex = 0
            lblVersion.Text = lstbxTemp.SelectedItem
            tmrUpdates.Enabled = False
            lblError.Text = "Pending response..."
            rchtxtbxMessage.Clear()
            rchtxtbxMessage.LoadFile(updatefilepath + "update.txt", RichTextBoxStreamType.PlainText)

            'check version
            If lblVersion.Text <> BaseVersion Then
                addtoLog("Update available waiting for user response")
                Dim msgresult As DialogResult = MessageBox.Show("Jote.TV is out of date!" + Environment.NewLine + Environment.NewLine + "Current version: " + BaseVersion + "." + Environment.NewLine + "- - - - - - - - - - - - - - - - -" + Environment.NewLine + Environment.NewLine + "The latest Jote.TV information:" + Environment.NewLine + "- - - - - - - - - - - - - - - - -" + Environment.NewLine + "Version: " + rchtxtbxMessage.Text + Environment.NewLine + "Download new update?", "Check for update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.None,
                    MessageBoxDefaultButton.Button1)
                If msgresult = DialogResult.Yes Then
                    addtoLog("User response: yes")
                    lblError.Text = "Downloading update... Please wait..." +
                        Environment.NewLine + Environment.NewLine + "This program will close automatically when the download is complete."

                    updatefilename = updatefilepath + "update.exe"
                    If System.IO.File.Exists(updatefilename) = True Then
                        System.IO.File.Delete(updatefilename)
                    End If
                    addtoLog("Fetching a latest update from server")
                    updatedownloader.DownloadFileAsync(New Uri("https://github.com/shannonfonseka/Jote-TV/raw/master/JoteTVInstaller.exe"), updatefilename)
                    panelDownloadStatus.Show()
                Else
                    addtoLog("User response: no")
                    addtoLog("Update check session ended")
                    addtoLog("Calling download playlist")
                    'continue on download playlist
                    tmrDownloadPlaylist.Enabled = True
                    lblError.Text = "Loading..."
                End If
            Else
                addtoLog("Latest update running")
                addtoLog("Update check session ended")
                addtoLog("Calling download playlist")
                'continue on download playlist
                tmrDownloadPlaylist.Enabled = True
                lblError.Text = "Loading..."
            End If
        Else
            panelDownloadStatus.Hide()
            tmrUpdates.Enabled = False
            If e.Error.ToString.Contains("raw.githubusercontent.com") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, looks like you are not connected to the internet.  Connect to a network and try again." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_NO_INTERNET"
                readyexceptionhandler("Error Code: UPDATE_NO_INTERNET", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("Unable to connect to the remote server") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, Jote.TV can't connect with our server.  Try again later." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_CONNECTION_LOST"
                readyexceptionhandler("Error Code: UPDATE_CONNECTION_LOST", "This error can be resolved by user.")
                tmrUpdates.Enabled = True

            ElseIf e.Error.ToString.Contains("The operation has timed out") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, looks like your internet connection has timed out. Check back again by connecting to another network." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_CONNECTION_TIMED_OUT"
                readyexceptionhandler("Error Code: UPDATE_CONNECTION_TIMED_OUT", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("process cannot access the file") Then
                stopbutton()
                hideUIforLabel()
                lblError.Text = "An error occurred when saving the files! Close any programs that may interfere with the playlists and re-open this program." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_SAVEFILE"
                tmrUpdates.Enabled = False
                readyexceptionhandler("Error Code: UPDATE_ERROR_SAVEFILE", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("Could not find file") Then
                stopbutton()
                hideUIforSettings()
                lblError.Text = "Jote.TV could not find the file. This could be certain anti-virus programs interfering." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_FILE_NOTFOUND"
                readyexceptionhandler("Error Code: UPDATE_ERROR_FILE_NOTFOUND", "This error can be resolved by user.")
                '+= (Environment.NewLine + Me.CodeEditor.Text + Environment.NewLine)
                tmrUpdates.Enabled = False

            ElseIf e.Error.ToString.Contains("A socket operation was attempted to an unreachable network") Then
                stopbutton()
                lblVersion.Text = "VersionPending"
                lblDownloaded.Text = "Gathering information for update..."
                prgsbrDone.Style = ProgressBarStyle.Marquee
                hideUIforRefresh()
                lblError.Text = "A change of network/IP address was detected (sometimes IP address is missing). Try connecting to another network and refresh to update again." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_NETWORK_IP_ADDRESS_CHANGE"
                tmrUpdates.Enabled = False
                readyexceptionhandler("Error Code: UPDATE_ERROR_NETWORK_IP_ADDRESS_CHANGE", "This error can be resolved by user.")

            Else
                tmrUpdates.Enabled = False
                exceptionhandler("Error (Exception Handler was called): " + e.Error.ToString + ". Better send an issue to developer", e.Error.ToString)
            End If
        End If
    End Sub

    Private Sub updatedownloader_DownloadFileCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles updatedownloader.DownloadFileCompleted
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            updatefilename = updatefilepath + "update.exe"
            addtoLog("Update downloaded successfully")
            addtoLog("Starting to begin update.exe execute process")
            Process.Start(updatefilename)
            addtoLog("update.exe procces started succesfully")
            addtoLog("Session ended due to update")
            End
        Else
            panelDownloadStatus.Hide()
            tmrUpdates.Enabled = False
            If e.Error.ToString.Contains("raw.githubusercontent.com") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, looks like you are not connected to the internet.  Connect to a network and try again." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_NO_INTERNET"
                readyexceptionhandler("Error Code: UPDATE_NO_INTERNET", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("Unable to connect to the remote server") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, Jote.TV can't connect with our server.  Try again later." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_CONNECTION_LOST"
                readyexceptionhandler("Error Code: UPDATE_CONNECTION_LOST", "This error can be resolved by user.")
                tmrUpdates.Enabled = True

            ElseIf e.Error.ToString.Contains("The operation has timed out") Then
                hideUIforRefresh()
                tmrUpdates.Enabled = False
                lblError.Text = "Uh..Oh, looks like your internet connection has timed out. Check back again by connecting to another network." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_CONNECTION_TIMED_OUT"
                readyexceptionhandler("Error Code: UPDATE_CONNECTION_TIMED_OUT", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("process cannot access the file") Then
                stopbutton()
                hideUIforLabel()
                lblError.Text = "An error occurred when saving the files! Close any programs that may interfere with the playlists and re-open this program." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_SAVEFILE"
                tmrUpdates.Enabled = False
                readyexceptionhandler("Error Code: UPDATE_ERROR_SAVEFILE", "This error can be resolved by user.")

            ElseIf e.Error.ToString.Contains("Could not find file") Then
                stopbutton()
                hideUIforSettings()
                lblError.Text = "Jote.TV could not find the file. This could be certain anti-virus programs interfering." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_FILE_NOTFOUND"
                readyexceptionhandler("Error Code: UPDATE_ERROR_FILE_NOTFOUND", "This error can be resolved by user.")
                '+= (Environment.NewLine + Me.CodeEditor.Text + Environment.NewLine)
                tmrUpdates.Enabled = False
            ElseIf e.Error.ToString.Contains("A socket operation was attempted to an unreachable network") Then
                stopbutton()
                lblVersion.Text = "VersionPending"
                lblDownloaded.Text = "Gathering information for update..."
                prgsbrDone.Style = ProgressBarStyle.Marquee
                hideUIforRefresh()
                lblError.Text = "A change of network/IP address was detected (sometimes IP address is missing). Try connecting to another network and refresh to update again." + Environment.NewLine + Environment.NewLine + "Error Code: UPDATE_ERROR_NETWORK_IP_ADDRESS_CHANGE"
                tmrUpdates.Enabled = False
                readyexceptionhandler("Error Code: UPDATE_ERROR_NETWORK_IP_ADDRESS_CHANGE", "This error can be resolved by user.")
            Else
                tmrUpdates.Enabled = False
                exceptionhandler("Error (Exception Handler was called): " + e.Error.ToString + ". Better send an issue to developer", e.Error.ToString)
            End If
        End If
    End Sub

    Private Sub cmbxSort_onItemSelected(sender As Object, e As EventArgs) Handles cmbxSort.onItemSelected
        If cmbxSort.selectedIndex = 0 Then
            showUI()
            lstbxChannels.Items.Clear()
            For count = 0 To lstbxNames.Items.Count - 1
                lstbxChannels.Items.Add(lstbxNames.Items(count))
            Next
            channelcount()
            Try
                lstbxChannels.SelectedIndex = 0
            Catch ex As Exception

            End Try
        ElseIf cmbxSort.selectedIndex = 1 Then
            SearchListBox(InputBox("Enter the name of the channel." + Environment.NewLine + "The search is case-insensitive", "Custom search"))
        Else
            SearchListBox("[" + cmbxSort.selectedValue + "]")
        End If
    End Sub

    Private Sub SearchListBox(searchterm As String)
        'load all lists
        lstbxChannels.Items.Clear()
        For count = 0 To lstbxNames.Items.Count - 1
            lstbxChannels.Items.Add(lstbxNames.Items(count))
        Next
        'start search
        If searchterm <> Nothing Then
            Dim items = From it In lstbxChannels.Items.Cast(Of Object)()
                        Where it.ToString().IndexOf(searchterm, StringComparison.CurrentCultureIgnoreCase) >= 0
            Dim matchingItemList As List(Of Object) = items.ToList()
            lstbxChannels.BeginUpdate()
            lstbxChannels.Items.Clear()
            For Each item In matchingItemList
                lstbxChannels.Items.Add(item)
            Next
            lstbxChannels.EndUpdate()
            channelcount()
        Else
            cmbxSort.selectedIndex = 0
        End If

        Try
            ' if found
            showUI()
            lblError.Font = New Font("Segoe UI", 8.25, FontStyle.Regular)
            lstbxChannels.SelectedIndex = 0
        Catch ex As Exception
            'not found
            hideUIforSearch()
            lblCount.Hide()
            lblError.Font = New Font("Segoe UI", 13, FontStyle.Regular)
            lblError.Text = "💩" + Environment.NewLine + "No results"
        End Try
    End Sub

    Private Sub btnExceptionWindow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnExceptionWindow.LinkClicked
        frmLogger.Show()
        frmLogger.Focus()
        frmLogger.WindowState = FormWindowState.Normal
    End Sub

    Public Sub addtoLog(logtext As String)
        rchtxtbxLogger.Text += Date.Now.ToString("[h:mm:ss tt] ") + logtext.ToString + Environment.NewLine
        rchtxtbxLogger.SaveFile(logfilepath + "Log-Information.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Public Sub addblanktoLog()
        rchtxtbxLogger.Text += "" + Environment.NewLine
        rchtxtbxLogger.SaveFile(logfilepath + "Log-Information.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Public Sub createlogger()
        rchtxtbxLogger.Text += "Computer Name: " + My.Computer.Name.ToString + Environment.NewLine
        rchtxtbxLogger.Text += "OS Full Name: " + My.Computer.Info.OSFullName.ToString + Environment.NewLine
        rchtxtbxLogger.Text += "OS Platform: " + My.Computer.Info.OSPlatform.ToString + Environment.NewLine
        rchtxtbxLogger.Text += "OS Version: " + My.Computer.Info.OSVersion.ToString + Environment.NewLine
        rchtxtbxLogger.Text += "Processor: " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing) + Environment.NewLine
        rchtxtbxLogger.Text += "Physical RAM: " + (Fix(My.Computer.Info.TotalPhysicalMemory / 1073741824 * 100) / 100).ToString + "GB" + Environment.NewLine
        rchtxtbxLogger.Text += "Installed UI Culture: " + My.Computer.Info.InstalledUICulture.ToString + Environment.NewLine
        rchtxtbxLogger.Text += "Motherboard Manufacturer: " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardManufacturer", Nothing) + Environment.NewLine
        rchtxtbxLogger.Text += "Motherboard: " + My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\BIOS", "BaseBoardProduct", Nothing) + Environment.NewLine
        rchtxtbxLogger.Text += "Installed Location: 'C:\Jote Television\'" + Environment.NewLine
        rchtxtbxLogger.Text += "Log Location: 'C:\Jote Television\Program-Information\Log-Information.txt'" + Environment.NewLine

        addblanktoLog()
        addtoLog("Log-Information created...")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        addtoLog(Environment.NewLine + " ~~Session Ended~~")
    End Sub
    Public Sub showUI()
        prgsbrLoading.Hide()
        lblError.Hide()
        panelControls.Show()
        btnRefresh.Hide()
        btnRefresh2.Hide()
        btnSettings.Show()
        cmbxSort.Show()
        btnMail.Show()
        lblCount.Show()
        btnExceptionWindow.Hide()
        lstbxChannels.Show()
    End Sub
    Public Sub hideUIforLabel()
        prgsbrLoading.Hide()
        lblError.Show()
        panelControls.Hide()
        btnMail.Hide()
        btnRefresh.Hide()
        btnRefresh2.Hide()
        btnSettings.Hide()
        lblCount.Hide()
        cmbxSort.Hide()
        btnExceptionWindow.Hide()
        lstbxChannels.Hide()
    End Sub
    Public Sub hideUIforSettings()
        prgsbrLoading.Hide()
        lblError.Show()
        panelControls.Hide()
        btnRefresh.Hide()
        btnMail.Hide()
        lblCount.Hide()
        btnRefresh2.Hide()
        btnSettings.Show()
        cmbxSort.Hide()
        btnExceptionWindow.Hide()
        lstbxChannels.Hide()
    End Sub
    Public Sub hideUIforRefresh()
        prgsbrLoading.Hide()
        lblError.Show()
        panelControls.Hide()
        btnMail.Hide()
        lblCount.Hide()
        btnRefresh.Show()
        btnRefresh2.Hide()
        btnSettings.Hide()
        cmbxSort.Hide()
        btnExceptionWindow.Hide()
        lstbxChannels.Hide()
    End Sub
    Public Sub hideUIforSearch()
        prgsbrLoading.Hide()
        lblError.Show()
        panelControls.Show()
        btnMail.Show()
        lblCount.Show()
        btnRefresh.Hide()
        btnRefresh2.Hide()
        btnSettings.Show()
        cmbxSort.Show()
        btnExceptionWindow.Hide()
        lstbxChannels.Show()
    End Sub
    Private Sub encryptPlaylist()
        addtoLog("File encryption started")
        rchtxtbxEncryptor.LoadFile(Application.StartupPath & "\Playlists\channels.jotetv_playlist", RichTextBoxStreamType.UnicodePlainText)
        rchtxtbxEncryptor.SaveFile(Application.StartupPath & "\Playlists\channels.jotetv_playlist", RichTextBoxStreamType.PlainText)
        addtoLog("File encryption finished")
    End Sub

    Private Sub btnMail_Click(sender As Object, e As EventArgs) Handles btnMail.Click
        Try
            rchtxtbxMessage.LoadFile(updatefilepath + "messages.jote_list", RichTextBoxStreamType.PlainText)
            Dim msgresult As DialogResult = MessageBox.Show(rchtxtbxMessage.Text,
                               "Messages",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MsgBox("File not found!")
        End Try
    End Sub
    Private Sub channelcount()
        If lstbxChannels.Items.Count = 1 Then
            lblCount.Text = "1 channel"
        Else
            lblCount.Text = lstbxChannels.Items.Count.ToString + " channels"
        End If
    End Sub

    Private Sub ENDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENDToolStripMenuItem.Click
        End
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        btnSettings_Click(sender, e)
    End Sub

    Private Sub updatedownloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles updatedownloader.DownloadProgressChanged
        prgsbrDone.Value = e.ProgressPercentage
        prgsbrDone.Style = ProgressBarStyle.Blocks
        lblDownloaded.Text = "Downloaded " + e.ProgressPercentage.ToString + "% [" + (Fix(e.BytesReceived / 1048576 * 100) / 100).ToString + " MB/" + (Fix(e.TotalBytesToReceive / 1048576 * 100) / 100).ToString + " MB]"
    End Sub

    Private Sub updatechecker_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles updatechecker.DownloadProgressChanged
        prgsbrLoading.Show()
        prgsbrLoading.Value = e.ProgressPercentage
    End Sub

    Private Sub playlistdownloader_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles playlistdownloader.DownloadProgressChanged
        prgsbrLoading.Show()
        prgsbrLoading.Value = e.ProgressPercentage
    End Sub
End Class