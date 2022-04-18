Imports System.ComponentModel
Public Class frmWelcome
    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Opacity = 0
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        btnNext.Hide()
        My.Settings.settingsWelcome = True
        Form1.addtoLog("Privacy policy accepted")
        Form1.addtoLog("Waiting for session restart")
        My.Settings.Save()
        Try
            System.Diagnostics.Process.Start(Application.StartupPath & "\Jote.TV.exe")
            Me.Close()
            Form1.Close()
            'End
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmWelcome_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub
End Class