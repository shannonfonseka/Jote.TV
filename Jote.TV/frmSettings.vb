Imports System.ComponentModel

Public Class frmSettings
    Dim filepath As String
    Private Sub cmbxContenttype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxContenttype.SelectedIndexChanged
        My.Settings.settingsContentType = cmbxContenttype.SelectedItem
        My.Settings.Save()
        If My.Settings.settingsContentType = Form1.lblContentType.Text Then
            Form1.btnRefresh2.Hide()
            lblDesc.Text = "Select which type of content to be delivered to your computer."
            lblDesc.ForeColor = Color.White
        Else
            lblDesc.Text = "Press the refresh button in the library window to make changes."
            lblDesc.ForeColor = Color.OrangeRed
            Form1.btnRefresh2.Show()
        End If
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.addtoLog("Settings: Opened")
        cmbxContenttype.Text = My.Settings.settingsContentType
        cmbxCrop.Text = My.Settings.settingsCrop
        cmbxRatio.Text = My.Settings.settingsAspectRatio
        cmbxRecordQuality.Text = My.Settings.settingsRecordQuality
        cmbxUpdate.Text = My.Settings.settingsUpdateCheck
        trkbrOpacity.Value = My.Settings.settingsOpacity
        lblPercentage.Text = trkbrOpacity.Value.ToString + "%"
        lblDesc.Text = "Select which type of content to be delivered to your computer."
        lblDesc.ForeColor = Color.White
        Form1.addtoLog("Settings: Settings.xml loaded, user is ready to use settings")
        If My.Settings.settingsContentType <> Form1.lblContentType.Text Then
            Form1.btnRefresh2.Show()
        Else
            Form1.btnRefresh2.Hide()
        End If
    End Sub

    Private Sub cmbxRatio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxRatio.SelectedIndexChanged
        My.Settings.settingsAspectRatio = cmbxRatio.Text
        applytoplayer()
        My.Settings.Save()
    End Sub

    Private Sub cmbxCrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxCrop.SelectedIndexChanged
        My.Settings.settingsCrop = cmbxCrop.Text
        applytoplayer()
        My.Settings.Save()
    End Sub

    Private Sub cmbxRecordQuality_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxRecordQuality.SelectedIndexChanged
        My.Settings.settingsRecordQuality = cmbxRecordQuality.Text
        My.Settings.Save()
    End Sub

    Private Sub cmbxUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbxUpdate.SelectedIndexChanged
        My.Settings.settingsUpdateCheck = cmbxUpdate.Text
        My.Settings.Save()
    End Sub

    Private Sub frmSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'e.Cancel = True
        'lblDesc.Text = "Select which type of content to be delivered to your computer."
        'lblDesc.ForeColor = Color.White
        'Me.Hide()
        'Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
        'panelSettings.Focus()
        Form1.addtoLog("Settings: Closed")
    End Sub
    Private Sub applytoplayer()
        frmVideoPlayer.axvlcVideoPlayer.video.aspectRatio = cmbxRatio.SelectedItem
        frmVideoPlayer.axvlcVideoPlayer.video.crop = cmbxCrop.SelectedItem
    End Sub

    Private Sub btnLicense_Click(sender As Object, e As EventArgs) Handles btnLicense.Click
        frmAbout.Show()
        frmAbout.Focus()
        frmAbout.loadlicense()
    End Sub

    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        frmAbout.Show()
        frmAbout.Focus()
        frmAbout.loadabout()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAbout.Show()
        frmAbout.Focus()
        frmAbout.loadlog()
    End Sub

    Private Sub btnExceptionWindow_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnReset.LinkClicked
        Dim msgresult As DialogResult = MessageBox.Show("This would delete all the information, databases and other associated files.
Do you still want to reset?",
         "Reset and uninstall",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Exclamation,
         MessageBoxDefaultButton.Button2)
        If msgresult = DialogResult.Yes Then
            Form1.btnStop_Click(sender, e)
            My.Settings.settingsAspectRatio = "4:3"
            My.Settings.settingsContentType = "Jote TV"
            My.Settings.settingsCrop = "16:9"
            My.Settings.settingsPlaystatus = "stop"
            My.Settings.settingsRecordQuality = "Standard Definition"
            My.Settings.settingsUpdateCheck = "On startup"
            My.Settings.settingsOpacity = 100
            My.Settings.settingsWelcome = False
            My.Settings.Save()

            filepath = Application.StartupPath & "\Playlists\channels.jotetv_playlist"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If


            filepath = Application.StartupPath & "\Program-Information\Log-Information.txt"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If

            filepath = Application.StartupPath & "\Program-Information\update.txt"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If
            'REMOVE THIS IN FUTURE
            filepath = Application.StartupPath & "\Program-Information\update.jote_list"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If

            'REMOVE THIS IN FUTURE
            filepath = Application.StartupPath & "\Program-Information\releasenotes.jote_list"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If
            'REMOVE THIS IN FUTURE
            filepath = Application.StartupPath & "\Program-Information\messages.jote_list"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If

            filepath = Application.StartupPath & "\Program-Information\update.exe"
            If System.IO.File.Exists(filepath) = True Then
                System.IO.File.Delete(filepath)
            End If

            filepath = Application.StartupPath & "\Playlists\"
            If System.IO.Directory.Exists(filepath) = True Then
                System.IO.Directory.Delete(filepath)
            End If

            filepath = Application.StartupPath & "\Program-Information\"
            If System.IO.Directory.Exists(filepath) = True Then
                System.IO.Directory.Delete(filepath)
            End If
            Try
                System.Diagnostics.Process.Start(Application.StartupPath & "\unins000.exe")
            Catch ex As Exception
                MsgBox("Uninstaller program has been removed or changed... Go to 'Control Panel > Programs and Features' and uninstall the program.")
            End Try
            End
        End If
    End Sub

    Private Sub trkbrOpacity_Scroll(sender As Object, e As ScrollEventArgs) Handles trkbrOpacity.Scroll
        lblPercentage.Text = trkbrOpacity.Value.ToString + "%"
        My.Settings.settingsOpacity = trkbrOpacity.Value
        My.Settings.Save()
        If frmVideoPlayer.pipmode = False Then
            frmVideoPlayer.Opacity = 0.1 + My.Settings.settingsOpacity / 100
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim msgresult As DialogResult = MessageBox.Show(RichTextBox1.Text,
         "Jote.TV Privacy Policy",
         MessageBoxButtons.OK,
         MessageBoxIcon.None,
         MessageBoxDefaultButton.Button2)
    End Sub
End Class