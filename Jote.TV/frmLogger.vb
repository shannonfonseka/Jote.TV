Public Class frmLogger
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        frmAbout.Show()
        frmAbout.Focus()
        frmAbout.loadlog()
        frmAbout.TopMost = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklblIssues.LinkClicked
        System.Diagnostics.Process.Start("https://" + lnklblIssues.Text)
    End Sub
    Public Sub produceClipboard()
        txtbxClipboard.Text = "**Exception Details**" + Environment.NewLine
        txtbxClipboard.Text += ">" + txtbxException.Text + Environment.NewLine
        txtbxClipboard.Text += Environment.NewLine
        txtbxClipboard.Text += "**Log Details**" + Environment.NewLine
        txtbxClipboard.Text += ">" + txtbxLog.Text + Environment.NewLine
        txtbxClipboard.Text += Environment.NewLine
        txtbxClipboard.Text += "[Describe clearly how you got this error.][Add your text here!]"
    End Sub

    Private Sub btnClipboard_Click(sender As Object, e As EventArgs) Handles btnClipboard.Click
        txtbxClipboard.SelectAll()
        txtbxClipboard.Copy()
        Dim msgresult As DialogResult = MessageBox.Show("Exception information copied succesfully. 
Now go to 'issues' website and paste the copied information to the description.", "Clipboard message.",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1)
    End Sub

    Private Sub frmLogger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogger_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
    End Sub
End Class