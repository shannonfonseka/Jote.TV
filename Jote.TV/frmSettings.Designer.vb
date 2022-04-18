<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblHeadingIcon = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.panelSettings = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblHeading11 = New System.Windows.Forms.Label()
        Me.lblDesc8 = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.trkbrOpacity = New MetroFramework.Controls.MetroTrackBar()
        Me.btnReset = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnInformation = New System.Windows.Forms.Button()
        Me.btnLicense = New System.Windows.Forms.Button()
        Me.lblHeading10 = New System.Windows.Forms.Label()
        Me.lblHeading9 = New System.Windows.Forms.Label()
        Me.lblDesc7 = New System.Windows.Forms.Label()
        Me.cmbxUpdate = New System.Windows.Forms.ComboBox()
        Me.lblHeading7 = New System.Windows.Forms.Label()
        Me.lblDesc6 = New System.Windows.Forms.Label()
        Me.cmbxRecordQuality = New System.Windows.Forms.ComboBox()
        Me.lblDesc5 = New System.Windows.Forms.Label()
        Me.btnCheckRecord = New System.Windows.Forms.Button()
        Me.lblDesc4 = New System.Windows.Forms.Label()
        Me.lblHeading6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbxCrop = New System.Windows.Forms.ComboBox()
        Me.lblDesc3 = New System.Windows.Forms.Label()
        Me.lblHeading5 = New System.Windows.Forms.Label()
        Me.cmbxRatio = New System.Windows.Forms.ComboBox()
        Me.lblDesc2 = New System.Windows.Forms.Label()
        Me.lblHeading4 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.cmbxContenttype = New System.Windows.Forms.ComboBox()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.panelSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeadingIcon
        '
        Me.lblHeadingIcon.AutoSize = True
        Me.lblHeadingIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingIcon.Location = New System.Drawing.Point(24, 29)
        Me.lblHeadingIcon.Name = "lblHeadingIcon"
        Me.lblHeadingIcon.Size = New System.Drawing.Size(34, 24)
        Me.lblHeadingIcon.TabIndex = 4
        Me.lblHeadingIcon.Text = ""
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(56, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(87, 30)
        Me.lblHeading.TabIndex = 5
        Me.lblHeading.Text = "Settings"
        '
        'panelSettings
        '
        Me.panelSettings.AutoScroll = True
        Me.panelSettings.Controls.Add(Me.Button2)
        Me.panelSettings.Controls.Add(Me.RichTextBox1)
        Me.panelSettings.Controls.Add(Me.lblHeading11)
        Me.panelSettings.Controls.Add(Me.lblDesc8)
        Me.panelSettings.Controls.Add(Me.lblPercentage)
        Me.panelSettings.Controls.Add(Me.trkbrOpacity)
        Me.panelSettings.Controls.Add(Me.btnReset)
        Me.panelSettings.Controls.Add(Me.Button1)
        Me.panelSettings.Controls.Add(Me.btnInformation)
        Me.panelSettings.Controls.Add(Me.btnLicense)
        Me.panelSettings.Controls.Add(Me.lblHeading10)
        Me.panelSettings.Controls.Add(Me.lblHeading9)
        Me.panelSettings.Controls.Add(Me.lblDesc7)
        Me.panelSettings.Controls.Add(Me.cmbxUpdate)
        Me.panelSettings.Controls.Add(Me.lblHeading7)
        Me.panelSettings.Controls.Add(Me.lblDesc6)
        Me.panelSettings.Controls.Add(Me.cmbxRecordQuality)
        Me.panelSettings.Controls.Add(Me.lblDesc5)
        Me.panelSettings.Controls.Add(Me.btnCheckRecord)
        Me.panelSettings.Controls.Add(Me.lblDesc4)
        Me.panelSettings.Controls.Add(Me.lblHeading6)
        Me.panelSettings.Controls.Add(Me.Label7)
        Me.panelSettings.Controls.Add(Me.cmbxCrop)
        Me.panelSettings.Controls.Add(Me.lblDesc3)
        Me.panelSettings.Controls.Add(Me.lblHeading5)
        Me.panelSettings.Controls.Add(Me.cmbxRatio)
        Me.panelSettings.Controls.Add(Me.lblDesc2)
        Me.panelSettings.Controls.Add(Me.lblHeading4)
        Me.panelSettings.Controls.Add(Me.lblDesc)
        Me.panelSettings.Controls.Add(Me.cmbxContenttype)
        Me.panelSettings.Controls.Add(Me.lblHeading2)
        Me.panelSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelSettings.Location = New System.Drawing.Point(0, 64)
        Me.panelSettings.Name = "panelSettings"
        Me.panelSettings.Size = New System.Drawing.Size(495, 386)
        Me.panelSettings.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(24, 793)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 32)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "View privacy note"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(168, 768)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox1.TabIndex = 49
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        Me.RichTextBox1.Visible = False
        '
        'lblHeading11
        '
        Me.lblHeading11.AutoSize = True
        Me.lblHeading11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading11.Location = New System.Drawing.Point(24, 763)
        Me.lblHeading11.Name = "lblHeading11"
        Me.lblHeading11.Size = New System.Drawing.Size(59, 20)
        Me.lblHeading11.TabIndex = 47
        Me.lblHeading11.Text = "Privacy"
        '
        'lblDesc8
        '
        Me.lblDesc8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc8.Location = New System.Drawing.Point(24, 723)
        Me.lblDesc8.Name = "lblDesc8"
        Me.lblDesc8.Size = New System.Drawing.Size(320, 18)
        Me.lblDesc8.TabIndex = 46
        Me.lblDesc8.Text = "Tip: To see changes, go to Mini player mode."
        '
        'lblPercentage
        '
        Me.lblPercentage.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.Location = New System.Drawing.Point(304, 691)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(40, 24)
        Me.lblPercentage.TabIndex = 45
        Me.lblPercentage.Text = "0%"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'trkbrOpacity
        '
        Me.trkbrOpacity.BackColor = System.Drawing.Color.Transparent
        Me.trkbrOpacity.Location = New System.Drawing.Point(24, 691)
        Me.trkbrOpacity.Minimum = 75
        Me.trkbrOpacity.Name = "trkbrOpacity"
        Me.trkbrOpacity.Size = New System.Drawing.Size(272, 23)
        Me.trkbrOpacity.TabIndex = 44
        Me.trkbrOpacity.Text = "MetroTrackBar1"
        Me.trkbrOpacity.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trkbrOpacity.UseCustomBackColor = True
        Me.trkbrOpacity.Value = 75
        '
        'btnReset
        '
        Me.btnReset.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.btnReset.AutoSize = True
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnReset.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.btnReset.LinkColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(24, 1008)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(133, 13)
        Me.btnReset.TabIndex = 43
        Me.btnReset.TabStop = True
        Me.btnReset.Text = "Reset data and Uninstall"
        Me.btnReset.VisitedLinkColor = System.Drawing.Color.White
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(24, 960)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 32)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "Log Information"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnInformation
        '
        Me.btnInformation.BackColor = System.Drawing.Color.LightGray
        Me.btnInformation.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnInformation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformation.Location = New System.Drawing.Point(24, 920)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(136, 32)
        Me.btnInformation.TabIndex = 41
        Me.btnInformation.Text = "About Information"
        Me.btnInformation.UseVisualStyleBackColor = False
        '
        'btnLicense
        '
        Me.btnLicense.BackColor = System.Drawing.Color.LightGray
        Me.btnLicense.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnLicense.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLicense.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLicense.Location = New System.Drawing.Point(24, 880)
        Me.btnLicense.Name = "btnLicense"
        Me.btnLicense.Size = New System.Drawing.Size(136, 32)
        Me.btnLicense.TabIndex = 40
        Me.btnLicense.Text = "License"
        Me.btnLicense.UseVisualStyleBackColor = False
        '
        'lblHeading10
        '
        Me.lblHeading10.AutoSize = True
        Me.lblHeading10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading10.Location = New System.Drawing.Point(24, 848)
        Me.lblHeading10.Name = "lblHeading10"
        Me.lblHeading10.Size = New System.Drawing.Size(51, 20)
        Me.lblHeading10.TabIndex = 39
        Me.lblHeading10.Text = "About"
        '
        'lblHeading9
        '
        Me.lblHeading9.AutoSize = True
        Me.lblHeading9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading9.Location = New System.Drawing.Point(24, 667)
        Me.lblHeading9.Name = "lblHeading9"
        Me.lblHeading9.Size = New System.Drawing.Size(141, 20)
        Me.lblHeading9.TabIndex = 35
        Me.lblHeading9.Text = "Mini player opacity"
        '
        'lblDesc7
        '
        Me.lblDesc7.AutoSize = True
        Me.lblDesc7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc7.Location = New System.Drawing.Point(24, 595)
        Me.lblDesc7.Name = "lblDesc7"
        Me.lblDesc7.Size = New System.Drawing.Size(114, 17)
        Me.lblDesc7.TabIndex = 25
        Me.lblDesc7.Text = "Check for updates"
        '
        'cmbxUpdate
        '
        Me.cmbxUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmbxUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbxUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxUpdate.ForeColor = System.Drawing.Color.White
        Me.cmbxUpdate.FormattingEnabled = True
        Me.cmbxUpdate.Items.AddRange(New Object() {"On startup", "Never"})
        Me.cmbxUpdate.Location = New System.Drawing.Point(24, 619)
        Me.cmbxUpdate.Name = "cmbxUpdate"
        Me.cmbxUpdate.Size = New System.Drawing.Size(320, 25)
        Me.cmbxUpdate.TabIndex = 24
        '
        'lblHeading7
        '
        Me.lblHeading7.AutoSize = True
        Me.lblHeading7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading7.Location = New System.Drawing.Point(24, 567)
        Me.lblHeading7.Name = "lblHeading7"
        Me.lblHeading7.Size = New System.Drawing.Size(115, 20)
        Me.lblHeading7.TabIndex = 22
        Me.lblHeading7.Text = "Update settings"
        '
        'lblDesc6
        '
        Me.lblDesc6.AutoSize = True
        Me.lblDesc6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc6.Location = New System.Drawing.Point(24, 520)
        Me.lblDesc6.Name = "lblDesc6"
        Me.lblDesc6.Size = New System.Drawing.Size(180, 17)
        Me.lblDesc6.TabIndex = 21
        Me.lblDesc6.Text = "Recording plugin: OBS Studio"
        '
        'cmbxRecordQuality
        '
        Me.cmbxRecordQuality.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmbxRecordQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRecordQuality.Enabled = False
        Me.cmbxRecordQuality.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbxRecordQuality.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRecordQuality.ForeColor = System.Drawing.Color.White
        Me.cmbxRecordQuality.FormattingEnabled = True
        Me.cmbxRecordQuality.Items.AddRange(New Object() {"Standard Definition", "High Definition"})
        Me.cmbxRecordQuality.Location = New System.Drawing.Point(24, 488)
        Me.cmbxRecordQuality.Name = "cmbxRecordQuality"
        Me.cmbxRecordQuality.Size = New System.Drawing.Size(320, 25)
        Me.cmbxRecordQuality.TabIndex = 20
        '
        'lblDesc5
        '
        Me.lblDesc5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc5.Location = New System.Drawing.Point(24, 464)
        Me.lblDesc5.Name = "lblDesc5"
        Me.lblDesc5.Size = New System.Drawing.Size(312, 24)
        Me.lblDesc5.TabIndex = 19
        Me.lblDesc5.Text = "Recording quality"
        '
        'btnCheckRecord
        '
        Me.btnCheckRecord.BackColor = System.Drawing.Color.LightGray
        Me.btnCheckRecord.Enabled = False
        Me.btnCheckRecord.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnCheckRecord.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCheckRecord.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckRecord.Location = New System.Drawing.Point(24, 424)
        Me.btnCheckRecord.Name = "btnCheckRecord"
        Me.btnCheckRecord.Size = New System.Drawing.Size(136, 32)
        Me.btnCheckRecord.TabIndex = 18
        Me.btnCheckRecord.Text = "Check recordings"
        Me.btnCheckRecord.UseVisualStyleBackColor = False
        '
        'lblDesc4
        '
        Me.lblDesc4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc4.Location = New System.Drawing.Point(24, 377)
        Me.lblDesc4.Name = "lblDesc4"
        Me.lblDesc4.Size = New System.Drawing.Size(320, 40)
        Me.lblDesc4.TabIndex = 17
        Me.lblDesc4.Text = "Records video in a digital format and saves it in your computer. The saved record" &
    "ing is encrypted."
        '
        'lblHeading6
        '
        Me.lblHeading6.AutoSize = True
        Me.lblHeading6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading6.Location = New System.Drawing.Point(24, 353)
        Me.lblHeading6.Name = "lblHeading6"
        Me.lblHeading6.Size = New System.Drawing.Size(174, 20)
        Me.lblHeading6.TabIndex = 16
        Me.lblHeading6.Text = "DVR (Beta) (Unreleased)"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 1033)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 17)
        Me.Label7.TabIndex = 15
        '
        'cmbxCrop
        '
        Me.cmbxCrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmbxCrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCrop.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbxCrop.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCrop.ForeColor = System.Drawing.Color.White
        Me.cmbxCrop.FormattingEnabled = True
        Me.cmbxCrop.Items.AddRange(New Object() {"4:3", "16:9", "1:1", "16:10", "2.21:1", "2.35:1", "2.39:1", "5:4"})
        Me.cmbxCrop.Location = New System.Drawing.Point(24, 297)
        Me.cmbxCrop.Name = "cmbxCrop"
        Me.cmbxCrop.Size = New System.Drawing.Size(320, 25)
        Me.cmbxCrop.TabIndex = 14
        '
        'lblDesc3
        '
        Me.lblDesc3.AutoSize = True
        Me.lblDesc3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc3.Location = New System.Drawing.Point(24, 273)
        Me.lblDesc3.Name = "lblDesc3"
        Me.lblDesc3.Size = New System.Drawing.Size(287, 17)
        Me.lblDesc3.TabIndex = 13
        Me.lblDesc3.Text = "Removal of unwanted outer areas from a video." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHeading5
        '
        Me.lblHeading5.AutoSize = True
        Me.lblHeading5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading5.Location = New System.Drawing.Point(24, 249)
        Me.lblHeading5.Name = "lblHeading5"
        Me.lblHeading5.Size = New System.Drawing.Size(42, 20)
        Me.lblHeading5.TabIndex = 12
        Me.lblHeading5.Text = "Crop"
        '
        'cmbxRatio
        '
        Me.cmbxRatio.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmbxRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRatio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbxRatio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxRatio.ForeColor = System.Drawing.Color.White
        Me.cmbxRatio.FormattingEnabled = True
        Me.cmbxRatio.Items.AddRange(New Object() {"4:3", "16:9", "1:1", "16:10", "2.21:1", "2.35:1", "2.39:1", "5:4"})
        Me.cmbxRatio.Location = New System.Drawing.Point(24, 192)
        Me.cmbxRatio.Name = "cmbxRatio"
        Me.cmbxRatio.Size = New System.Drawing.Size(320, 25)
        Me.cmbxRatio.TabIndex = 11
        '
        'lblDesc2
        '
        Me.lblDesc2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc2.Location = New System.Drawing.Point(24, 152)
        Me.lblDesc2.Name = "lblDesc2"
        Me.lblDesc2.Size = New System.Drawing.Size(320, 40)
        Me.lblDesc2.TabIndex = 10
        Me.lblDesc2.Text = "Proportional relationship between its width and its height."
        '
        'lblHeading4
        '
        Me.lblHeading4.AutoSize = True
        Me.lblHeading4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading4.Location = New System.Drawing.Point(24, 129)
        Me.lblHeading4.Name = "lblHeading4"
        Me.lblHeading4.Size = New System.Drawing.Size(93, 20)
        Me.lblHeading4.TabIndex = 9
        Me.lblHeading4.Text = "Aspect Ratio"
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(24, 32)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(320, 40)
        Me.lblDesc.TabIndex = 8
        Me.lblDesc.Text = "Select which type of content to be delivered to your computer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmbxContenttype
        '
        Me.cmbxContenttype.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmbxContenttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxContenttype.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbxContenttype.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxContenttype.ForeColor = System.Drawing.Color.White
        Me.cmbxContenttype.FormattingEnabled = True
        Me.cmbxContenttype.Items.AddRange(New Object() {"Jote TV", "Jote Radio"})
        Me.cmbxContenttype.Location = New System.Drawing.Point(24, 72)
        Me.cmbxContenttype.Name = "cmbxContenttype"
        Me.cmbxContenttype.Size = New System.Drawing.Size(320, 25)
        Me.cmbxContenttype.TabIndex = 7
        '
        'lblHeading2
        '
        Me.lblHeading2.AutoSize = True
        Me.lblHeading2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.Location = New System.Drawing.Point(24, 8)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(97, 20)
        Me.lblHeading2.TabIndex = 6
        Me.lblHeading2.Text = "Content type"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 450)
        Me.Controls.Add(Me.panelSettings)
        Me.Controls.Add(Me.lblHeadingIcon)
        Me.Controls.Add(Me.lblHeading)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.panelSettings.ResumeLayout(False)
        Me.panelSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeadingIcon As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents panelSettings As Panel
    Friend WithEvents lblHeading10 As Label
    Friend WithEvents lblHeading9 As Label
    Friend WithEvents lblDesc7 As Label
    Friend WithEvents cmbxUpdate As ComboBox
    Friend WithEvents lblHeading7 As Label
    Friend WithEvents lblDesc6 As Label
    Friend WithEvents cmbxRecordQuality As ComboBox
    Friend WithEvents lblDesc5 As Label
    Friend WithEvents btnCheckRecord As Button
    Friend WithEvents lblDesc4 As Label
    Friend WithEvents lblHeading6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbxCrop As ComboBox
    Friend WithEvents lblDesc3 As Label
    Friend WithEvents lblHeading5 As Label
    Friend WithEvents cmbxRatio As ComboBox
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents lblHeading4 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents cmbxContenttype As ComboBox
    Friend WithEvents lblHeading2 As Label
    Friend WithEvents btnInformation As Button
    Friend WithEvents btnLicense As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReset As LinkLabel
    Friend WithEvents trkbrOpacity As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblDesc8 As Label
    Friend WithEvents lblHeading11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
