<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.picbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(96, 576)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(88, 24)
        Me.btnNext.TabIndex = 2
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Continue"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'picbxLogo
        '
        Me.picbxLogo.BackgroundImage = Global.Jote.TV.My.Resources.Resources.JoteTVLogo
        Me.picbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picbxLogo.Location = New System.Drawing.Point(88, 16)
        Me.picbxLogo.Name = "picbxLogo"
        Me.picbxLogo.Size = New System.Drawing.Size(117, 24)
        Me.picbxLogo.TabIndex = 1
        Me.picbxLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 624)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 256)
        Me.Panel1.TabIndex = 14
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picbxLogo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(313, 352)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(313, 352)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jote TV Privacy Policy"
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picbxLogo As PictureBox
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
