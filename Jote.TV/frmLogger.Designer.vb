<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogger))
        Me.txtbxException = New System.Windows.Forms.RichTextBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblExeception = New System.Windows.Forms.Label()
        Me.txtbxLog = New System.Windows.Forms.RichTextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnClipboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnklblIssues = New System.Windows.Forms.LinkLabel()
        Me.txtbxClipboard = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtbxException
        '
        Me.txtbxException.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtbxException.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxException.ForeColor = System.Drawing.Color.White
        Me.txtbxException.Location = New System.Drawing.Point(8, 144)
        Me.txtbxException.Name = "txtbxException"
        Me.txtbxException.ReadOnly = True
        Me.txtbxException.Size = New System.Drawing.Size(432, 96)
        Me.txtbxException.TabIndex = 1
        Me.txtbxException.Text = ""
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(8, 8)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(432, 112)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = resources.GetString("lblHeading.Text")
        '
        'lblExeception
        '
        Me.lblExeception.AutoSize = True
        Me.lblExeception.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExeception.Location = New System.Drawing.Point(8, 128)
        Me.lblExeception.Name = "lblExeception"
        Me.lblExeception.Size = New System.Drawing.Size(105, 13)
        Me.lblExeception.TabIndex = 3
        Me.lblExeception.Text = "Exeception Details:"
        '
        'txtbxLog
        '
        Me.txtbxLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtbxLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxLog.ForeColor = System.Drawing.Color.White
        Me.txtbxLog.Location = New System.Drawing.Point(8, 264)
        Me.txtbxLog.Name = "txtbxLog"
        Me.txtbxLog.ReadOnly = True
        Me.txtbxLog.Size = New System.Drawing.Size(432, 48)
        Me.txtbxLog.TabIndex = 4
        Me.txtbxLog.Text = ""
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLog.Location = New System.Drawing.Point(8, 248)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(68, 13)
        Me.lblLog.TabIndex = 5
        Me.lblLog.Text = "Log Details:"
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(8, 320)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(432, 40)
        Me.lblDesc.TabIndex = 6
        Me.lblDesc.Text = "DISCONTINUE THE USE OF THIS PROGRAM!." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The above log information is added to the " &
    "log file. Go to Settings > Log-Information to view a full descriptive log."
        '
        'btnLog
        '
        Me.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Location = New System.Drawing.Point(8, 368)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(75, 23)
        Me.btnLog.TabIndex = 7
        Me.btnLog.Text = "Go to Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnClipboard
        '
        Me.btnClipboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClipboard.Location = New System.Drawing.Point(88, 368)
        Me.btnClipboard.Name = "btnClipboard"
        Me.btnClipboard.Size = New System.Drawing.Size(208, 23)
        Me.btnClipboard.TabIndex = 8
        Me.btnClipboard.Text = "Copy to clipboard for GitHub issues"
        Me.btnClipboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Exception Handler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.5.9"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lnklblIssues
        '
        Me.lnklblIssues.ActiveLinkColor = System.Drawing.Color.Silver
        Me.lnklblIssues.AutoSize = True
        Me.lnklblIssues.ForeColor = System.Drawing.Color.DimGray
        Me.lnklblIssues.LinkColor = System.Drawing.Color.White
        Me.lnklblIssues.Location = New System.Drawing.Point(120, 24)
        Me.lnklblIssues.Name = "lnklblIssues"
        Me.lnklblIssues.Size = New System.Drawing.Size(260, 13)
        Me.lnklblIssues.TabIndex = 10
        Me.lnklblIssues.TabStop = True
        Me.lnklblIssues.Text = "github.com/shannonfonseka/Jote-TV/issues/new"
        Me.lnklblIssues.VisitedLinkColor = System.Drawing.Color.White
        '
        'txtbxClipboard
        '
        Me.txtbxClipboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.txtbxClipboard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbxClipboard.ForeColor = System.Drawing.Color.White
        Me.txtbxClipboard.Location = New System.Drawing.Point(96, 248)
        Me.txtbxClipboard.Name = "txtbxClipboard"
        Me.txtbxClipboard.ReadOnly = True
        Me.txtbxClipboard.Size = New System.Drawing.Size(320, 8)
        Me.txtbxClipboard.TabIndex = 11
        Me.txtbxClipboard.Text = ""
        Me.txtbxClipboard.Visible = False
        '
        'frmLogger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 401)
        Me.Controls.Add(Me.txtbxClipboard)
        Me.Controls.Add(Me.lnklblIssues)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClipboard)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.txtbxLog)
        Me.Controls.Add(Me.lblExeception)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.txtbxException)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLogger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exception Handler: Error Request"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxException As RichTextBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblExeception As Label
    Friend WithEvents txtbxLog As RichTextBox
    Friend WithEvents lblLog As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents btnLog As Button
    Friend WithEvents btnClipboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lnklblIssues As LinkLabel
    Friend WithEvents txtbxClipboard As RichTextBox
End Class
