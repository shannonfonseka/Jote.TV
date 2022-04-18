Imports System.ComponentModel

Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadabout()
        Try
            Me.Text = "About Information"
            RichTextBox1.LoadFile(Application.StartupPath & "\Information.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            RichTextBox1.Text = "Error: Couldn't load 'About Information'"
        End Try
    End Sub
    Public Sub loadlicense()
        Try
            Me.Text = "License"
            RichTextBox1.LoadFile(Application.StartupPath & "\License.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            RichTextBox1.Text = "Error: Couldn't load 'License'"
        End Try
    End Sub
    Public Sub loadlog()
        Try
            Me.Text = "Log-Information"
            RichTextBox1.LoadFile(Application.StartupPath & "\Program-Information\Log-Information.txt", RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            RichTextBox1.Text = "Error: Couldn't load 'Log-Information'"
        End Try
    End Sub

    Private Sub frmAbout_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.TopMost = False
    End Sub
End Class