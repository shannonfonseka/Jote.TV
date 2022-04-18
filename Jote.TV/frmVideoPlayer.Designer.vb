<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVideoPlayer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVideoPlayer))
        Me.axvlcVideoPlayer = New AxAXVLC.AxVLCPlugin2()
        Me.panelControls = New System.Windows.Forms.Panel()
        Me.btnPiP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.trkbrSeekbar = New MetroFramework.Controls.MetroTrackBar()
        Me.lblTimeTotal = New System.Windows.Forms.Label()
        Me.flowpanelControls = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInfo = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblSpacer = New System.Windows.Forms.Label()
        Me.btn10 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPlay = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn30 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblSpacer2 = New System.Windows.Forms.Label()
        Me.btnStop = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblTimeElapsed = New System.Windows.Forms.Label()
        Me.btnFullscreen = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnToPlayer = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tmrTrackbar = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelHeading = New System.Windows.Forms.Panel()
        Me.lblNowPlaying = New System.Windows.Forms.Label()
        Me.panelHint = New System.Windows.Forms.Panel()
        Me.lblHint = New System.Windows.Forms.Label()
        Me.lblHintIcon = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlaypauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowhideControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrControls = New System.Windows.Forms.Timer(Me.components)
        CType(Me.axvlcVideoPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelControls.SuspendLayout()
        Me.flowpanelControls.SuspendLayout()
        Me.panelHeading.SuspendLayout()
        Me.panelHint.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'axvlcVideoPlayer
        '
        Me.axvlcVideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.axvlcVideoPlayer.Enabled = True
        Me.axvlcVideoPlayer.Location = New System.Drawing.Point(0, 0)
        Me.axvlcVideoPlayer.Name = "axvlcVideoPlayer"
        Me.axvlcVideoPlayer.OcxState = CType(resources.GetObject("axvlcVideoPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.axvlcVideoPlayer.Size = New System.Drawing.Size(698, 401)
        Me.axvlcVideoPlayer.TabIndex = 0
        '
        'panelControls
        '
        Me.panelControls.Controls.Add(Me.btnPiP)
        Me.panelControls.Controls.Add(Me.trkbrSeekbar)
        Me.panelControls.Controls.Add(Me.lblTimeTotal)
        Me.panelControls.Controls.Add(Me.flowpanelControls)
        Me.panelControls.Controls.Add(Me.lblTimeElapsed)
        Me.panelControls.Controls.Add(Me.btnFullscreen)
        Me.panelControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelControls.Location = New System.Drawing.Point(0, 336)
        Me.panelControls.Name = "panelControls"
        Me.panelControls.Size = New System.Drawing.Size(698, 65)
        Me.panelControls.TabIndex = 24
        '
        'btnPiP
        '
        Me.btnPiP.Activecolor = System.Drawing.Color.Transparent
        Me.btnPiP.BackColor = System.Drawing.Color.Transparent
        Me.btnPiP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPiP.BorderRadius = 0
        Me.btnPiP.ButtonText = ""
        Me.btnPiP.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnPiP.DisabledColor = System.Drawing.Color.Gray
        Me.btnPiP.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPiP.Iconimage = Nothing
        Me.btnPiP.Iconimage_right = Nothing
        Me.btnPiP.Iconimage_right_Selected = Nothing
        Me.btnPiP.Iconimage_Selected = Nothing
        Me.btnPiP.IconMarginLeft = 0
        Me.btnPiP.IconMarginRight = 0
        Me.btnPiP.IconRightVisible = True
        Me.btnPiP.IconRightZoom = 0R
        Me.btnPiP.IconVisible = True
        Me.btnPiP.IconZoom = 90.0R
        Me.btnPiP.IsTab = False
        Me.btnPiP.Location = New System.Drawing.Point(8, 20)
        Me.btnPiP.Name = "btnPiP"
        Me.btnPiP.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPiP.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnPiP.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnPiP.selected = False
        Me.btnPiP.Size = New System.Drawing.Size(41, 37)
        Me.btnPiP.TabIndex = 37
        Me.btnPiP.Text = ""
        Me.btnPiP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPiP.Textcolor = System.Drawing.Color.White
        Me.btnPiP.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnPiP, "Stop")
        '
        'trkbrSeekbar
        '
        Me.trkbrSeekbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkbrSeekbar.BackColor = System.Drawing.Color.Transparent
        Me.trkbrSeekbar.Location = New System.Drawing.Point(56, 0)
        Me.trkbrSeekbar.Name = "trkbrSeekbar"
        Me.trkbrSeekbar.Size = New System.Drawing.Size(585, 23)
        Me.trkbrSeekbar.TabIndex = 19
        Me.trkbrSeekbar.Text = "MetroTrackBar1"
        Me.trkbrSeekbar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.trkbrSeekbar.UseCustomBackColor = True
        Me.trkbrSeekbar.Value = 0
        '
        'lblTimeTotal
        '
        Me.lblTimeTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTimeTotal.Location = New System.Drawing.Point(652, 3)
        Me.lblTimeTotal.Name = "lblTimeTotal"
        Me.lblTimeTotal.Size = New System.Drawing.Size(40, 16)
        Me.lblTimeTotal.TabIndex = 22
        Me.lblTimeTotal.Text = "0:0"
        Me.lblTimeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flowpanelControls
        '
        Me.flowpanelControls.Controls.Add(Me.btnInfo)
        Me.flowpanelControls.Controls.Add(Me.lblSpacer)
        Me.flowpanelControls.Controls.Add(Me.btn10)
        Me.flowpanelControls.Controls.Add(Me.btnPlay)
        Me.flowpanelControls.Controls.Add(Me.btn30)
        Me.flowpanelControls.Controls.Add(Me.lblSpacer2)
        Me.flowpanelControls.Controls.Add(Me.btnStop)
        Me.flowpanelControls.Location = New System.Drawing.Point(96, 24)
        Me.flowpanelControls.MinimumSize = New System.Drawing.Size(232, 40)
        Me.flowpanelControls.Name = "flowpanelControls"
        Me.flowpanelControls.Size = New System.Drawing.Size(504, 40)
        Me.flowpanelControls.TabIndex = 4
        Me.flowpanelControls.WrapContents = False
        '
        'btnInfo
        '
        Me.btnInfo.Activecolor = System.Drawing.Color.Transparent
        Me.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnInfo.BorderRadius = 0
        Me.btnInfo.ButtonText = ""
        Me.btnInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnInfo.DisabledColor = System.Drawing.Color.Gray
        Me.btnInfo.Iconcolor = System.Drawing.Color.Transparent
        Me.btnInfo.Iconimage = Nothing
        Me.btnInfo.Iconimage_right = Nothing
        Me.btnInfo.Iconimage_right_Selected = Nothing
        Me.btnInfo.Iconimage_Selected = Nothing
        Me.btnInfo.IconMarginLeft = 0
        Me.btnInfo.IconMarginRight = 0
        Me.btnInfo.IconRightVisible = True
        Me.btnInfo.IconRightZoom = 0R
        Me.btnInfo.IconVisible = True
        Me.btnInfo.IconZoom = 90.0R
        Me.btnInfo.IsTab = False
        Me.btnInfo.Location = New System.Drawing.Point(3, 3)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Normalcolor = System.Drawing.Color.Transparent
        Me.btnInfo.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnInfo.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnInfo.selected = False
        Me.btnInfo.Size = New System.Drawing.Size(41, 37)
        Me.btnInfo.TabIndex = 32
        Me.btnInfo.Text = ""
        Me.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnInfo.Textcolor = System.Drawing.Color.White
        Me.btnInfo.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnInfo, "Stop")
        '
        'lblSpacer
        '
        Me.lblSpacer.Location = New System.Drawing.Point(50, 0)
        Me.lblSpacer.Name = "lblSpacer"
        Me.lblSpacer.Size = New System.Drawing.Size(41, 13)
        Me.lblSpacer.TabIndex = 28
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
        Me.ToolTip1.SetToolTip(Me.btn10, "Rewinf by 10 seconds")
        '
        'btnPlay
        '
        Me.btnPlay.Activecolor = System.Drawing.Color.Transparent
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.BorderRadius = 0
        Me.btnPlay.ButtonText = ""
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Arrow
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
        Me.lblSpacer2.Location = New System.Drawing.Point(238, 0)
        Me.lblSpacer2.Name = "lblSpacer2"
        Me.lblSpacer2.Size = New System.Drawing.Size(41, 13)
        Me.lblSpacer2.TabIndex = 29
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
        'lblTimeElapsed
        '
        Me.lblTimeElapsed.Location = New System.Drawing.Point(8, 3)
        Me.lblTimeElapsed.Name = "lblTimeElapsed"
        Me.lblTimeElapsed.Size = New System.Drawing.Size(40, 16)
        Me.lblTimeElapsed.TabIndex = 21
        Me.lblTimeElapsed.Text = "0:0"
        Me.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFullscreen
        '
        Me.btnFullscreen.Activecolor = System.Drawing.Color.Transparent
        Me.btnFullscreen.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFullscreen.BackColor = System.Drawing.Color.Transparent
        Me.btnFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFullscreen.BorderRadius = 0
        Me.btnFullscreen.ButtonText = ""
        Me.btnFullscreen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnFullscreen.DisabledColor = System.Drawing.Color.Gray
        Me.btnFullscreen.Iconcolor = System.Drawing.Color.Transparent
        Me.btnFullscreen.Iconimage = Nothing
        Me.btnFullscreen.Iconimage_right = Nothing
        Me.btnFullscreen.Iconimage_right_Selected = Nothing
        Me.btnFullscreen.Iconimage_Selected = Nothing
        Me.btnFullscreen.IconMarginLeft = 0
        Me.btnFullscreen.IconMarginRight = 0
        Me.btnFullscreen.IconRightVisible = True
        Me.btnFullscreen.IconRightZoom = 0R
        Me.btnFullscreen.IconVisible = True
        Me.btnFullscreen.IconZoom = 90.0R
        Me.btnFullscreen.IsTab = False
        Me.btnFullscreen.Location = New System.Drawing.Point(656, 20)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Normalcolor = System.Drawing.Color.Transparent
        Me.btnFullscreen.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnFullscreen.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnFullscreen.selected = False
        Me.btnFullscreen.Size = New System.Drawing.Size(41, 37)
        Me.btnFullscreen.TabIndex = 36
        Me.btnFullscreen.Text = ""
        Me.btnFullscreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFullscreen.Textcolor = System.Drawing.Color.White
        Me.btnFullscreen.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnFullscreen, "Stop")
        '
        'btnToPlayer
        '
        Me.btnToPlayer.Activecolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToPlayer.BackColor = System.Drawing.Color.Transparent
        Me.btnToPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnToPlayer.BorderRadius = 0
        Me.btnToPlayer.ButtonText = ""
        Me.btnToPlayer.Cursor = System.Windows.Forms.Cursors.Arrow
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
        Me.btnToPlayer.Location = New System.Drawing.Point(640, 0)
        Me.btnToPlayer.Name = "btnToPlayer"
        Me.btnToPlayer.Normalcolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnToPlayer.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnToPlayer.selected = False
        Me.btnToPlayer.Size = New System.Drawing.Size(57, 32)
        Me.btnToPlayer.TabIndex = 26
        Me.btnToPlayer.Text = ""
        Me.btnToPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnToPlayer.Textcolor = System.Drawing.Color.White
        Me.btnToPlayer.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnToPlayer, "Go to library")
        '
        'tmrTrackbar
        '
        Me.tmrTrackbar.Enabled = True
        Me.tmrTrackbar.Interval = 1
        '
        'btnSettings
        '
        Me.btnSettings.Activecolor = System.Drawing.Color.Transparent
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettings.BorderRadius = 0
        Me.btnSettings.ButtonText = ""
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Arrow
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
        Me.btnSettings.Location = New System.Drawing.Point(600, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSettings.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnSettings.OnHoverTextColor = System.Drawing.Color.DimGray
        Me.btnSettings.selected = False
        Me.btnSettings.Size = New System.Drawing.Size(41, 32)
        Me.btnSettings.TabIndex = 35
        Me.btnSettings.Text = ""
        Me.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSettings.Textcolor = System.Drawing.Color.White
        Me.btnSettings.TextFont = New System.Drawing.Font("Segoe MDL2 Assets", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolTip1.SetToolTip(Me.btnSettings, "Stop")
        '
        'panelHeading
        '
        Me.panelHeading.Controls.Add(Me.btnSettings)
        Me.panelHeading.Controls.Add(Me.btnToPlayer)
        Me.panelHeading.Controls.Add(Me.lblNowPlaying)
        Me.panelHeading.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeading.Location = New System.Drawing.Point(0, 0)
        Me.panelHeading.Name = "panelHeading"
        Me.panelHeading.Size = New System.Drawing.Size(698, 32)
        Me.panelHeading.TabIndex = 25
        '
        'lblNowPlaying
        '
        Me.lblNowPlaying.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNowPlaying.AutoEllipsis = True
        Me.lblNowPlaying.Location = New System.Drawing.Point(8, 8)
        Me.lblNowPlaying.Name = "lblNowPlaying"
        Me.lblNowPlaying.Size = New System.Drawing.Size(488, 16)
        Me.lblNowPlaying.TabIndex = 0
        Me.lblNowPlaying.Text = "Nothing playing right now, select from the library."
        '
        'panelHint
        '
        Me.panelHint.Controls.Add(Me.lblHint)
        Me.panelHint.Controls.Add(Me.lblHintIcon)
        Me.panelHint.Location = New System.Drawing.Point(8, 40)
        Me.panelHint.Name = "panelHint"
        Me.panelHint.Size = New System.Drawing.Size(400, 16)
        Me.panelHint.TabIndex = 26
        '
        'lblHint
        '
        Me.lblHint.AutoSize = True
        Me.lblHint.Location = New System.Drawing.Point(16, 1)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(386, 13)
        Me.lblHint.TabIndex = 2
        Me.lblHint.Text = "Hint: Click anywhere around here/press F1 to hide/show the play controls"
        '
        'lblHintIcon
        '
        Me.lblHintIcon.AutoSize = True
        Me.lblHintIcon.Font = New System.Drawing.Font("Segoe MDL2 Assets", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHintIcon.Location = New System.Drawing.Point(2, 2)
        Me.lblHintIcon.Name = "lblHintIcon"
        Me.lblHintIcon.Size = New System.Drawing.Size(17, 12)
        Me.lblHintIcon.TabIndex = 3
        Me.lblHintIcon.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(698, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlaypauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.FullscreenToolStripMenuItem, Me.HideToolStripMenuItem, Me.ShowhideControlsToolStripMenuItem})
        Me.ControlsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'PlaypauseToolStripMenuItem
        '
        Me.PlaypauseToolStripMenuItem.Name = "PlaypauseToolStripMenuItem"
        Me.PlaypauseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlaypauseToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PlaypauseToolStripMenuItem.Text = "Play/pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.StopToolStripMenuItem.Text = "stop"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.HideToolStripMenuItem.Text = "hide"
        '
        'ShowhideControlsToolStripMenuItem
        '
        Me.ShowhideControlsToolStripMenuItem.Name = "ShowhideControlsToolStripMenuItem"
        Me.ShowhideControlsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ShowhideControlsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ShowhideControlsToolStripMenuItem.Text = "show/hide controls"
        '
        'tmrControls
        '
        Me.tmrControls.Interval = 8000
        '
        'frmVideoPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 401)
        Me.Controls.Add(Me.panelHint)
        Me.Controls.Add(Me.panelHeading)
        Me.Controls.Add(Me.panelControls)
        Me.Controls.Add(Me.axvlcVideoPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MinimumSize = New System.Drawing.Size(380, 380)
        Me.Name = "frmVideoPlayer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.axvlcVideoPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelControls.ResumeLayout(False)
        Me.flowpanelControls.ResumeLayout(False)
        Me.panelHeading.ResumeLayout(False)
        Me.panelHint.ResumeLayout(False)
        Me.panelHint.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents axvlcVideoPlayer As AxAXVLC.AxVLCPlugin2
    Friend WithEvents panelControls As Panel
    Friend WithEvents trkbrSeekbar As MetroFramework.Controls.MetroTrackBar
    Friend WithEvents lblTimeTotal As Label
    Friend WithEvents flowpanelControls As FlowLayoutPanel
    Friend WithEvents btnToPlayer As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn10 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPlay As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn30 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnStop As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblTimeElapsed As Label
    Friend WithEvents tmrTrackbar As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents panelHeading As Panel
    Friend WithEvents lblNowPlaying As Label
    Friend WithEvents lblSpacer As Label
    Friend WithEvents lblSpacer2 As Label
    Friend WithEvents panelHint As Panel
    Friend WithEvents lblHint As Label
    Friend WithEvents lblHintIcon As Label
    Friend WithEvents btnInfo As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnFullscreen As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaypauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnPiP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ShowhideControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmrControls As Timer
End Class
