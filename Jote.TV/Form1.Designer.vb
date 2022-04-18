<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstbxChannels = New System.Windows.Forms.ListBox()
        Me.tmrDownloadPlaylist = New System.Windows.Forms.Timer(Me.components)
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.flowpanelControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnToPlayer = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblSpacer = New System.Windows.Forms.Label()
        Me.btn10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn30 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblSpacer2 = New System.Windows.Forms.Label()
        Me.btnStop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.trkbrSeekbar = New MetroFramework.Controls.MetroTrackBar()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblTimeElapsed = New System.Windows.Forms.Label()
        Me.lblTimeTotal = New System.Windows.Forms.Label()
        Me.tmrTrackbar = New System.Windows.Forms.Timer(Me.components)
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.lstbxNames = New System.Windows.Forms.ListBox()
        Me.lstbxLinks = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRefresh2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaypauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GotoPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrUpdates = New System.Windows.Forms.Timer(Me.components)
        Me.lblContentType = New System.Windows.Forms.Label()
        Me.BunifuTransition1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.cmbxSort = New Bunifu.Framework.UI.BunifuDropdown()
        Me.picbxLogo = New System.Windows.Forms.PictureBox()
        Me.btnExceptionWindow = New System.Windows.Forms.LinkLabel()
        Me.rchtxtbxLogger = New System.Windows.Forms.RichTextBox()
        Me.btnMail = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.rchtxtbxEncryptor = New System.Windows.Forms.RichTextBox()
        Me.rchtxtbxMessage = New System.Windows.Forms.RichTextBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lstbxTemp = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ENDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.prgsbrDone = New System.Windows.Forms.ProgressBar()
        Me.panelDownloadStatus = New System.Windows.Forms.Panel()
        Me.lblDownloaded = New System.Windows.Forms.Label()
        Me.prgsbrLoading = New Bunifu.Framework.UI.BunifuProgressBar()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.flowpanelControls.SuspendLayout()
        Me.panelControls.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelDownloadStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstbxChannels
        '
        Me.lstbxChannels.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lstbxChannels.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.lstbxChannels, BunifuAnimatorNS.DecorationType.None)
        Me.lstbxChannels.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxChannels.ForeColor = System.Drawing.Color.White
        Me.lstbxChannels.FormattingEnabled = True
        Me.lstbxChannels.ItemHeight = 18
        Me.lstbxChannels.Location = New System.Drawing.Point(8, 104)
        Me.lstbxChannels.Name = "lstbxChannels"
        Me.lstbxChannels.Size = New System.Drawing.Size(280, 198)
        Me.lstbxChannels.Sorted = True
        Me.lstbxChannels.TabIndex = 1
        Me.lstbxChannels.Visible = False
        '
        'tmrDownloadPlaylist
        '
        '
        'lblError
        '
        Me.BunifuTransition1.SetDecoration(Me.lblError, BunifuAnimatorNS.DecorationType.None)
        Me.lblError.Location = New System.Drawing.Point(296, 56)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(200, 72)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "Continue from the previous screen."
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRefresh
        '
        Me.BunifuTransition1.SetDecoration(Me.btnRefresh, BunifuAnimatorNS.DecorationType.None)
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(88, 288)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 32)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        Me.btnRefresh.Visible = False
        '
        'flowpanelControls
        '
        Me.flowpanelControls.Controls.Add(Me.btnToPlayer)
        Me.flowpanelControls.Controls.Add(Me.lblSpacer)
        Me.flowpanelControls.Controls.Add(Me.btn10)
        Me.flowpanelControls.Controls.Add(Me.btnPlay)
        Me.flowpanelControls.Controls.Add(Me.btn30)
        Me.flowpanelControls.Controls.Add(Me.lblSpacer2)
        Me.flowpanelControls.Controls.Add(Me.btnStop)
        Me.BunifuTransition1.SetDecoration(Me.flowpanelControls, BunifuAnimatorNS.DecorationType.None)
        Me.flowpanelControls.Location = New System.Drawing.Point(32, 17)
        Me.flowpanelControls.MinimumSize = New System.Drawing.Size(216, 40)
        Me.flowpanelControls.Name = "flowpanelControls"
        Me.flowpanelControls.Size = New System.Drawing.Size(368, 40)
        Me.flowpanelControls.TabIndex = 4
        Me.flowpanelControls.WrapContents = False
        '
        'btnToPlayer
        '
        Me.btnToPlayer.Activecolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.BackColor = System.Drawing.Color.Transparent
        Me.btnToPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToPlayer.BorderRadius = 0
        Me.btnToPlayer.ButtonText = ""
        Me.btnToPlayer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnToPlayer, BunifuAnimatorNS.DecorationType.None)
        Me.btnToPlayer.DisabledColor = System.Drawing.Color.Gray
        Me.btnToPlayer.Iconcolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.Iconimage = Nothing
        Me.btnToPlayer.Iconimage_right = Nothing
        Me.btnToPlayer.Iconimage_right_Selected = Nothing
        Me.btnToPlayer.Iconimage_Selected = Nothing
        Me.btnToPlayer.IconMarginLeft = 0
        Me.btnToPlayer.IconMarginRight = 0
        Me.btnToPlayer.IconRightVisible = True
        Me.btnToPlayer.IconRightZoom = 0R
        Me.btnToPlayer.IconVisible = True
        Me.btnToPlayer.IconZoom = 90.0R
        Me.btnToPlayer.IsTab = False
        Me.btnToPlayer.Location = New System.Drawing.Point(3, 3)
        Me.btnToPlayer.Name = "btnToPlayer"
        Me.btnToPlayer.Normalcolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnToPlayer.selected = False
        Me.btnToPlayer.Size = New System.Drawing.Size(41, 37)
        Me.btnToPlayer.TabIndex = 26
        Me.btnToPlayer.Text = ""
        Me.btnToPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnToPlayer.Textcolor = System.Drawing.Color.White
        Me.btnToPlayer.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnToPlayer, "Go to player")
        '
        'lblSpacer
        '
        Me.BunifuTransition1.SetDecoration(Me.lblSpacer, BunifuAnimatorNS.DecorationType.None)
        Me.lblSpacer.Location = New System.Drawing.Point(50, 0)
        Me.lblSpacer.Name = "lblSpacer"
        Me.lblSpacer.Size = New System.Drawing.Size(41, 13)
        Me.lblSpacer.TabIndex = 27
        Me.lblSpacer.Visible = False
        '
        'btn10
        '
        Me.btn10.Activecolor = System.Drawing.Color.Transparent
        Me.btn10.BackColor = System.Drawing.Color.Transparent
        Me.btn10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn10.BorderRadius = 0
        Me.btn10.ButtonText = ""
        Me.btn10.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btn10, BunifuAnimatorNS.DecorationType.None)
        Me.btn10.DisabledColor = System.Drawing.Color.Gray
        Me.btn10.Iconcolor = System.Drawing.Color.Transparent
        Me.btn10.Iconimage = Nothing
        Me.btn10.Iconimage_right = Nothing
        Me.btn10.Iconimage_right_Selected = Nothing
        Me.btn10.Iconimage_Selected = Nothing
        Me.btn10.IconMarginLeft = 0
        Me.btn10.IconMarginRight = 0
        Me.btn10.IconRightVisible = True
        Me.btn10.IconRightZoom = 0R
        Me.btn10.IconVisible = True
        Me.btn10.IconZoom = 90.0R
        Me.btn10.IsTab = False
        Me.btn10.Location = New System.Drawing.Point(97, 3)
        Me.btn10.Name = "btn10"
        Me.btn10.Normalcolor = System.Drawing.Color.Transparent
        Me.btn10.OnHovercolor = System.Drawing.Color.Transparent
        Me.btn10.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btn10.selected = False
        Me.btn10.Size = New System.Drawing.Size(41, 37)
        Me.btn10.TabIndex = 24
        Me.btn10.Text = ""
        Me.btn10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn10.Textcolor = System.Drawing.Color.White
        Me.btn10.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btn10, "Rewind by 10 seconds")
        '
        'btnPlay
        '
        Me.btnPlay.Activecolor = System.Drawing.Color.Transparent
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.BorderRadius = 0
        Me.btnPlay.ButtonText = ""
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnPlay, BunifuAnimatorNS.DecorationType.None)
        Me.btnPlay.DisabledColor = System.Drawing.Color.Gray
        Me.btnPlay.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPlay.Iconimage = Nothing
        Me.btnPlay.Iconimage_right = Nothing
        Me.btnPlay.Iconimage_right_Selected = Nothing
        Me.btnPlay.Iconimage_Selected = Nothing
        Me.btnPlay.IconMarginLeft = 0
        Me.btnPlay.IconMarginRight = 0
        Me.btnPlay.IconRightVisible = True
        Me.btnPlay.IconRightZoom = 0R
        Me.btnPlay.IconVisible = True
        Me.btnPlay.IconZoom = 90.0R
        Me.btnPlay.IsTab = False
        Me.btnPlay.Location = New System.Drawing.Point(144, 3)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPlay.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnPlay.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnPlay.selected = False
        Me.btnPlay.Size = New System.Drawing.Size(41, 37)
        Me.btnPlay.TabIndex = 21
        Me.btnPlay.Text = ""
        Me.btnPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPlay.Textcolor = System.Drawing.Color.White
        Me.btnPlay.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnPlay, "Play/Pause")
        '
        'btn30
        '
        Me.btn30.Activecolor = System.Drawing.Color.Transparent
        Me.btn30.BackColor = System.Drawing.Color.Transparent
        Me.btn30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn30.BorderRadius = 0
        Me.btn30.ButtonText = ""
        Me.btn30.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btn30, BunifuAnimatorNS.DecorationType.None)
        Me.btn30.DisabledColor = System.Drawing.Color.Gray
        Me.btn30.Iconcolor = System.Drawing.Color.Transparent
        Me.btn30.Iconimage = Nothing
        Me.btn30.Iconimage_right = Nothing
        Me.btn30.Iconimage_right_Selected = Nothing
        Me.btn30.Iconimage_Selected = Nothing
        Me.btn30.IconMarginLeft = 0
        Me.btn30.IconMarginRight = 0
        Me.btn30.IconRightVisible = True
        Me.btn30.IconRightZoom = 0R
        Me.btn30.IconVisible = True
        Me.btn30.IconZoom = 90.0R
        Me.btn30.IsTab = False
        Me.btn30.Location = New System.Drawing.Point(191, 3)
        Me.btn30.Name = "btn30"
        Me.btn30.Normalcolor = System.Drawing.Color.Transparent
        Me.btn30.OnHovercolor = System.Drawing.Color.Transparent
        Me.btn30.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btn30.selected = False
        Me.btn30.Size = New System.Drawing.Size(41, 37)
        Me.btn30.TabIndex = 23
        Me.btn30.Text = ""
        Me.btn30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn30.Textcolor = System.Drawing.Color.White
        Me.btn30.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btn30, "Fast-Forward by 30 seconds")
        '
        'lblSpacer2
        '
        Me.BunifuTransition1.SetDecoration(Me.lblSpacer2, BunifuAnimatorNS.DecorationType.None)
        Me.lblSpacer2.Location = New System.Drawing.Point(238, 0)
        Me.lblSpacer2.Name = "lblSpacer2"
        Me.lblSpacer2.Size = New System.Drawing.Size(41, 13)
        Me.lblSpacer2.TabIndex = 28
        Me.lblSpacer2.Visible = False
        '
        'btnStop
        '
        Me.btnStop.Activecolor = System.Drawing.Color.Transparent
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.BorderRadius = 0
        Me.btnStop.ButtonText = ""
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnStop, BunifuAnimatorNS.DecorationType.None)
        Me.btnStop.DisabledColor = System.Drawing.Color.Gray
        Me.btnStop.Iconcolor = System.Drawing.Color.Transparent
        Me.btnStop.Iconimage = Nothing
        Me.btnStop.Iconimage_right = Nothing
        Me.btnStop.Iconimage_right_Selected = Nothing
        Me.btnStop.Iconimage_Selected = Nothing
        Me.btnStop.IconMarginLeft = 0
        Me.btnStop.IconMarginRight = 0
        Me.btnStop.IconRightVisible = True
        Me.btnStop.IconRightZoom = 0R
        Me.btnStop.IconVisible = True
        Me.btnStop.IconZoom = 90.0R
        Me.btnStop.IsTab = False
        Me.btnStop.Location = New System.Drawing.Point(285, 3)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Normalcolor = System.Drawing.Color.Transparent
        Me.btnStop.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnStop.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnStop.selected = False
        Me.btnStop.Size = New System.Drawing.Size(41, 37)
        Me.btnStop.TabIndex = 22
        Me.btnStop.Text = ""
        Me.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnStop.Textcolor = System.Drawing.Color.White
        Me.btnStop.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnStop, "Stop")
        '
        'trkbrSeekbar
        '
        Me.trkbrSeekbar.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.trkbrSeekbar, BunifuAnimatorNS.DecorationType.None)
        Me.trkbrSeekbar.Location = New System.Drawing.Point(56, 0)
        Me.trkbrSeekbar.Name = "trkbrSeekbar"
        Me.trkbrSeekbar.Size = New System.Drawing.Size(184, 23)
        Me.trkbrSeekbar.TabIndex = 19
        Me.trkbrSeekbar.Text = "MetroTrackBar1"
        Me.trkbrSeekbar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trkbrSeekbar.UseCustomBackColor = True
        Me.trkbrSeekbar.Value = 0
        '
        'btnSettings
        '
        Me.btnSettings.Activecolor = System.Drawing.Color.Transparent
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.BorderRadius = 0
        Me.btnSettings.ButtonText = ""
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnSettings, BunifuAnimatorNS.DecorationType.None)
        Me.btnSettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnSettings.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSettings.Iconimage = Nothing
        Me.btnSettings.Iconimage_right = Nothing
        Me.btnSettings.Iconimage_right_Selected = Nothing
        Me.btnSettings.Iconimage_Selected = Nothing
        Me.btnSettings.IconMarginLeft = 0
        Me.btnSettings.IconMarginRight = 0
        Me.btnSettings.IconRightVisible = True
        Me.btnSettings.IconRightZoom = 0R
        Me.btnSettings.IconVisible = True
        Me.btnSettings.IconZoom = 90.0R
        Me.btnSettings.IsTab = False
        Me.btnSettings.Location = New System.Drawing.Point(256, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSettings.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnSettings.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnSettings.selected = False
        Me.btnSettings.Size = New System.Drawing.Size(40, 48)
        Me.btnSettings.TabIndex = 20
        Me.btnSettings.Text = ""
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSettings.Textcolor = System.Drawing.Color.White
        Me.btnSettings.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Visible = False
        '
        'lblTimeElapsed
        '
        Me.BunifuTransition1.SetDecoration(Me.lblTimeElapsed, BunifuAnimatorNS.DecorationType.None)
        Me.lblTimeElapsed.Location = New System.Drawing.Point(8, 3)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(40, 16)
        Me.lblTimeElapsed.TabIndex = 21
        Me.lblTimeElapsed.Text = "0:0"
        Me.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeTotal
        '
        Me.BunifuTransition1.SetDecoration(Me.lblTimeTotal, BunifuAnimatorNS.DecorationType.None)
        Me.lblTimeTotal.Location = New System.Drawing.Point(248, 3)
        Me.lblTimeTotal.Name = "lblTimeTotal"
        Me.lblTimeTotal.Size = New System.Drawing.Size(40, 16)
        Me.lblTimeTotal.TabIndex = 22
        Me.lblTimeTotal.Text = "0:0"
        Me.lblTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrTrackbar
        '
        Me.tmrTrackbar.Enabled = True
        Me.tmrTrackbar.Interval = 1
        '
        'panelControls
        '
        Me.panelControls.Controls.Add(Me.trkbrSeekbar)
        Me.panelControls.Controls.Add(Me.lblTimeTotal)
        Me.panelControls.Controls.Add(Me.flowpanelControls)
        Me.panelControls.Controls.Add(Me.lblTimeElapsed)
        Me.BunifuTransition1.SetDecoration(Me.panelControls, BunifuAnimatorNS.DecorationType.None)
        Me.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControls.Location = New System.Drawing.Point(0, 336)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Size = New System.Drawing.Size(503, 65)
        Me.panelControls.TabIndex = 23
        Me.panelControls.Visible = False
        '
        'lstbxNames
        '
        Me.lstbxNames.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lstbxNames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.lstbxNames, BunifuAnimatorNS.DecorationType.None)
        Me.lstbxNames.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxNames.ForeColor = System.Drawing.Color.White
        Me.lstbxNames.FormattingEnabled = True
        Me.lstbxNames.ItemHeight = 17
        Me.lstbxNames.Location = New System.Drawing.Point(296, 216)
        Me.lstbxNames.Name = "lstbxNames"
        Me.lstbxNames.Size = New System.Drawing.Size(200, 17)
        Me.lstbxNames.TabIndex = 24
        Me.lstbxNames.Visible = False
        '
        'lstbxLinks
        '
        Me.lstbxLinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lstbxLinks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.lstbxLinks, BunifuAnimatorNS.DecorationType.None)
        Me.lstbxLinks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxLinks.ForeColor = System.Drawing.Color.White
        Me.lstbxLinks.FormattingEnabled = True
        Me.lstbxLinks.ItemHeight = 17
        Me.lstbxLinks.Location = New System.Drawing.Point(296, 184)
        Me.lstbxLinks.Name = "lstbxLinks"
        Me.lstbxLinks.Size = New System.Drawing.Size(200, 17)
        Me.lstbxLinks.TabIndex = 25
        Me.lstbxLinks.Visible = False
        '
        'btnRefresh2
        '
        Me.btnRefresh2.Activecolor = System.Drawing.Color.Transparent
        Me.btnRefresh2.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh2.BorderRadius = 0
        Me.btnRefresh2.ButtonText = ""
        Me.btnRefresh2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnRefresh2, BunifuAnimatorNS.DecorationType.None)
        Me.btnRefresh2.DisabledColor = System.Drawing.Color.Gray
        Me.btnRefresh2.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRefresh2.Iconimage = Nothing
        Me.btnRefresh2.Iconimage_right = Nothing
        Me.btnRefresh2.Iconimage_right_Selected = Nothing
        Me.btnRefresh2.Iconimage_Selected = Nothing
        Me.btnRefresh2.IconMarginLeft = 0
        Me.btnRefresh2.IconMarginRight = 0
        Me.btnRefresh2.IconRightVisible = True
        Me.btnRefresh2.IconRightZoom = 0R
        Me.btnRefresh2.IconVisible = True
        Me.btnRefresh2.IconZoom = 90.0R
        Me.btnRefresh2.IsTab = False
        Me.btnRefresh2.Location = New System.Drawing.Point(216, 0)
        Me.btnRefresh2.Name = "btnRefresh2"
        Me.btnRefresh2.Normalcolor = System.Drawing.Color.Transparent
        Me.btnRefresh2.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnRefresh2.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnRefresh2.selected = False
        Me.btnRefresh2.Size = New System.Drawing.Size(40, 48)
        Me.btnRefresh2.TabIndex = 27
        Me.btnRefresh2.Text = ""
        Me.btnRefresh2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRefresh2.Textcolor = System.Drawing.Color.White
        Me.btnRefresh2.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh2.Visible = False
        '
        'MenuStrip1
        '
        Me.BunifuTransition1.SetDecoration(Me.MenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem, Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 24)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaypauseToolStripMenuItem, Me.GotoPlayerToolStripMenuItem, Me.StopToolStripMenuItem})
        Me.ControlsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'PlaypauseToolStripMenuItem
        '
        Me.PlaypauseToolStripMenuItem.Name = "PlaypauseToolStripMenuItem"
        Me.PlaypauseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlaypauseToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PlaypauseToolStripMenuItem.Text = "Play/pause"
        '
        'GotoPlayerToolStripMenuItem
        '
        Me.GotoPlayerToolStripMenuItem.Name = "GotoPlayerToolStripMenuItem"
        Me.GotoPlayerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.GotoPlayerToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.GotoPlayerToolStripMenuItem.Text = "Goto Player"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.ProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'tmrUpdates
        '
        '
        'lblContentType
        '
        Me.lblContentType.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblContentType, BunifuAnimatorNS.DecorationType.None)
        Me.lblContentType.Location = New System.Drawing.Point(304, 8)
        Me.lblContentType.Name = "lblContentType"
        Me.lblContentType.Size = New System.Drawing.Size(72, 13)
        Me.lblContentType.TabIndex = 30
        Me.lblContentType.Text = "ContentType"
        Me.lblContentType.Visible = False
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'cmbxSort
        '
        Me.cmbxSort.BackColor = System.Drawing.Color.Transparent
        Me.cmbxSort.BorderRadius = 3
        Me.cmbxSort.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.cmbxSort, BunifuAnimatorNS.DecorationType.None)
        Me.cmbxSort.ForeColor = System.Drawing.Color.White
        Me.cmbxSort.Items = New String() {"All channels", "Search channel", "Movie", "News", "General", "Music", "Edu", "Doc", "Kids", "Comedy"}
        Me.cmbxSort.Location = New System.Drawing.Point(8, 64)
        Me.cmbxSort.Name = "cmbxSort"
        Me.cmbxSort.NomalColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmbxSort.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmbxSort.selectedIndex = -1
        Me.cmbxSort.Size = New System.Drawing.Size(280, 32)
        Me.cmbxSort.TabIndex = 31
        Me.cmbxSort.Visible = False
        '
        'picbxLogo
        '
        Me.picbxLogo.BackgroundImage = Global.Jote.TV.My.Resources.Resources.JoteTVLogo
        Me.picbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuTransition1.SetDecoration(Me.picbxLogo, BunifuAnimatorNS.DecorationType.None)
        Me.picbxLogo.Location = New System.Drawing.Point(96, 24)
        Me.picbxLogo.Name = "picbxLogo"
        Me.picbxLogo.Size = New System.Drawing.Size(100, 32)
        Me.picbxLogo.TabIndex = 0
        Me.picbxLogo.TabStop = False
        '
        'btnExceptionWindow
        '
        Me.btnExceptionWindow.ActiveLinkColor = System.Drawing.Color.DimGray
        Me.btnExceptionWindow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnExceptionWindow, BunifuAnimatorNS.DecorationType.None)
        Me.btnExceptionWindow.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.btnExceptionWindow.LinkColor = System.Drawing.Color.White
        Me.btnExceptionWindow.Location = New System.Drawing.Point(296, 136)
        Me.btnExceptionWindow.Name = "btnExceptionWindow"
        Me.btnExceptionWindow.Size = New System.Drawing.Size(184, 16)
        Me.btnExceptionWindow.TabIndex = 33
        Me.btnExceptionWindow.TabStop = True
        Me.btnExceptionWindow.Text = "Open Exception Handler window"
        Me.btnExceptionWindow.Visible = False
        Me.btnExceptionWindow.VisitedLinkColor = System.Drawing.Color.White
        '
        'rchtxtbxLogger
        '
        Me.rchtxtbxLogger.BackColor = System.Drawing.Color.Black
        Me.BunifuTransition1.SetDecoration(Me.rchtxtbxLogger, BunifuAnimatorNS.DecorationType.None)
        Me.rchtxtbxLogger.ForeColor = System.Drawing.Color.White
        Me.rchtxtbxLogger.Location = New System.Drawing.Point(296, 160)
        Me.rchtxtbxLogger.Name = "rchtxtbxLogger"
        Me.rchtxtbxLogger.ReadOnly = True
        Me.rchtxtbxLogger.Size = New System.Drawing.Size(200, 16)
        Me.rchtxtbxLogger.TabIndex = 34
        Me.rchtxtbxLogger.Text = ""
        Me.rchtxtbxLogger.Visible = False
        '
        'btnMail
        '
        Me.btnMail.Activecolor = System.Drawing.Color.Transparent
        Me.btnMail.BackColor = System.Drawing.Color.Transparent
        Me.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMail.BorderRadius = 0
        Me.btnMail.ButtonText = ""
        Me.btnMail.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.BunifuTransition1.SetDecoration(Me.btnMail, BunifuAnimatorNS.DecorationType.None)
        Me.btnMail.DisabledColor = System.Drawing.Color.Gray
        Me.btnMail.Iconcolor = System.Drawing.Color.Transparent
        Me.btnMail.Iconimage = Nothing
        Me.btnMail.Iconimage_right = Nothing
        Me.btnMail.Iconimage_right_Selected = Nothing
        Me.btnMail.Iconimage_Selected = Nothing
        Me.btnMail.IconMarginLeft = 0
        Me.btnMail.IconMarginRight = 0
        Me.btnMail.IconRightVisible = True
        Me.btnMail.IconRightZoom = 0R
        Me.btnMail.IconVisible = True
        Me.btnMail.IconZoom = 90.0R
        Me.btnMail.IsTab = False
        Me.btnMail.Location = New System.Drawing.Point(0, 0)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Normalcolor = System.Drawing.Color.Transparent
        Me.btnMail.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnMail.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnMail.selected = False
        Me.btnMail.Size = New System.Drawing.Size(40, 48)
        Me.btnMail.TabIndex = 35
        Me.btnMail.Text = ""
        Me.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMail.Textcolor = System.Drawing.Color.White
        Me.btnMail.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMail.Visible = False
        '
        'rchtxtbxEncryptor
        '
        Me.rchtxtbxEncryptor.BackColor = System.Drawing.Color.Black
        Me.BunifuTransition1.SetDecoration(Me.rchtxtbxEncryptor, BunifuAnimatorNS.DecorationType.None)
        Me.rchtxtbxEncryptor.ForeColor = System.Drawing.Color.White
        Me.rchtxtbxEncryptor.Location = New System.Drawing.Point(296, 248)
        Me.rchtxtbxEncryptor.Name = "rchtxtbxEncryptor"
        Me.rchtxtbxEncryptor.ReadOnly = True
        Me.rchtxtbxEncryptor.Size = New System.Drawing.Size(200, 16)
        Me.rchtxtbxEncryptor.TabIndex = 36
        Me.rchtxtbxEncryptor.Text = ""
        Me.rchtxtbxEncryptor.Visible = False
        '
        'rchtxtbxMessage
        '
        Me.rchtxtbxMessage.BackColor = System.Drawing.Color.Black
        Me.BunifuTransition1.SetDecoration(Me.rchtxtbxMessage, BunifuAnimatorNS.DecorationType.None)
        Me.rchtxtbxMessage.ForeColor = System.Drawing.Color.White
        Me.rchtxtbxMessage.Location = New System.Drawing.Point(296, 272)
        Me.rchtxtbxMessage.Name = "rchtxtbxMessage"
        Me.rchtxtbxMessage.ReadOnly = True
        Me.rchtxtbxMessage.Size = New System.Drawing.Size(200, 16)
        Me.rchtxtbxMessage.TabIndex = 37
        Me.rchtxtbxMessage.Text = ""
        Me.rchtxtbxMessage.Visible = False
        '
        'lblCount
        '
        Me.BunifuTransition1.SetDecoration(Me.lblCount, BunifuAnimatorNS.DecorationType.None)
        Me.lblCount.Location = New System.Drawing.Point(0, 312)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(296, 16)
        Me.lblCount.TabIndex = 38
        Me.lblCount.Text = "0 channel(s)"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCount.Visible = False
        '
        'lstbxTemp
        '
        Me.lstbxTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lstbxTemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.lstbxTemp, BunifuAnimatorNS.DecorationType.None)
        Me.lstbxTemp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbxTemp.ForeColor = System.Drawing.Color.White
        Me.lstbxTemp.FormattingEnabled = True
        Me.lstbxTemp.ItemHeight = 17
        Me.lstbxTemp.Location = New System.Drawing.Point(296, 296)
        Me.lstbxTemp.Name = "lstbxTemp"
        Me.lstbxTemp.Size = New System.Drawing.Size(200, 17)
        Me.lstbxTemp.TabIndex = 39
        Me.lstbxTemp.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.BunifuTransition1.SetDecoration(Me.ContextMenuStrip1, BunifuAnimatorNS.DecorationType.None)
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENDToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 26)
        '
        'ENDToolStripMenuItem
        '
        Me.ENDToolStripMenuItem.Name = "ENDToolStripMenuItem"
        Me.ENDToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ENDToolStripMenuItem.Text = "End process"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.lblVersion, BunifuAnimatorNS.DecorationType.None)
        Me.lblVersion.Location = New System.Drawing.Point(304, 32)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(88, 13)
        Me.lblVersion.TabIndex = 29
        Me.lblVersion.Text = "VersionPending"
        Me.lblVersion.Visible = False
        '
        'prgsbrDone
        '
        Me.BunifuTransition1.SetDecoration(Me.prgsbrDone, BunifuAnimatorNS.DecorationType.None)
        Me.prgsbrDone.Location = New System.Drawing.Point(8, 8)
        Me.prgsbrDone.MarqueeAnimationSpeed = 10
        Me.prgsbrDone.Name = "prgsbrDone"
        Me.prgsbrDone.Size = New System.Drawing.Size(280, 8)
        Me.prgsbrDone.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgsbrDone.TabIndex = 40
        '
        'panelDownloadStatus
        '
        Me.panelDownloadStatus.Controls.Add(Me.lblDownloaded)
        Me.panelDownloadStatus.Controls.Add(Me.prgsbrDone)
        Me.BunifuTransition1.SetDecoration(Me.panelDownloadStatus, BunifuAnimatorNS.DecorationType.None)
        Me.panelDownloadStatus.Location = New System.Drawing.Point(392, 0)
        Me.panelDownloadStatus.Name = "panelDownloadStatus"
        Me.panelDownloadStatus.Size = New System.Drawing.Size(104, 48)
        Me.panelDownloadStatus.TabIndex = 41
        Me.panelDownloadStatus.Visible = False
        '
        'lblDownloaded
        '
        Me.BunifuTransition1.SetDecoration(Me.lblDownloaded, BunifuAnimatorNS.DecorationType.None)
        Me.lblDownloaded.Location = New System.Drawing.Point(8, 24)
        Me.lblDownloaded.Name = "lblDownloaded"
        Me.lblDownloaded.Size = New System.Drawing.Size(272, 16)
        Me.lblDownloaded.TabIndex = 41
        Me.lblDownloaded.Text = "Gathering information for update..."
        Me.lblDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prgsbrLoading
        '
        Me.prgsbrLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.prgsbrLoading.BorderRadius = 0
        Me.BunifuTransition1.SetDecoration(Me.prgsbrLoading, BunifuAnimatorNS.DecorationType.None)
        Me.prgsbrLoading.Location = New System.Drawing.Point(0, 0)
        Me.prgsbrLoading.MaximumValue = 100
        Me.prgsbrLoading.Name = "prgsbrLoading"
        Me.prgsbrLoading.ProgressColor = System.Drawing.Color.DimGray
        Me.prgsbrLoading.Size = New System.Drawing.Size(304, 8)
        Me.prgsbrLoading.TabIndex = 42
        Me.prgsbrLoading.Value = 0
        Me.prgsbrLoading.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Jote Television"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(503, 401)
        Me.Controls.Add(Me.prgsbrLoading)
        Me.Controls.Add(Me.panelDownloadStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lstbxTemp)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.rchtxtbxMessage)
        Me.Controls.Add(Me.rchtxtbxEncryptor)
        Me.Controls.Add(Me.btnMail)
        Me.Controls.Add(Me.rchtxtbxLogger)
        Me.Controls.Add(Me.btnExceptionWindow)
        Me.Controls.Add(Me.panelControls)
        Me.Controls.Add(Me.cmbxSort)
        Me.Controls.Add(Me.lblContentType)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnRefresh2)
        Me.Controls.Add(Me.picbxLogo)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lstbxLinks)
        Me.Controls.Add(Me.lstbxNames)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lstbxChannels)
        Me.BunifuTransition1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jote TV"
        Me.flowpanelControls.ResumeLayout(False)
        Me.panelControls.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelDownloadStatus.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picbxLogo As PictureBox
    Friend WithEvents lstbxChannels As ListBox
    Friend WithEvents tmrDownloadPlaylist As Timer
    Friend WithEvents lblError As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents flowpanelControls As FlowLayoutPanel
    Friend WithEvents trkbrSeekbar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn30 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnToPlayer As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents lblTimeTotal As Label
    Friend WithEvents tmrTrackbar As Timer
    Friend WithEvents panelControls As Panel
    Friend WithEvents lstbxNames As ListBox
    Friend WithEvents lstbxLinks As ListBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnRefresh2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblSpacer As Label
    Friend WithEvents lblSpacer2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaypauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GotoPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrUpdates As Timer
    Friend WithEvents lblContentType As Label
    Friend WithEvents BunifuTransition1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents cmbxSort As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents btnExceptionWindow As LinkLabel
    Friend WithEvents rchtxtbxLogger As RichTextBox
    Friend WithEvents btnMail As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents rchtxtbxEncryptor As RichTextBox
    Friend WithEvents rchtxtbxMessage As RichTextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lstbxTemp As ListBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ENDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblVersion As Label
    Friend WithEvents prgsbrDone As ProgressBar
    Friend WithEvents panelDownloadStatus As Panel
    Friend WithEvents lblDownloaded As Label
    Friend WithEvents prgsbrLoading As Bunifu.Framework.UI.BunifuProgressBar
End Class
