<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Menu = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem1 = New ToolStripMenuItem()
        GarisBatasToolStripMenuItem1 = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        lblFolderpath = New Label()
        txtPath = New TextBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        clbWallpaper = New CheckedListBox()
        cbPreview = New CheckBox()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        cbInterval = New ComboBox()
        Label3 = New Label()
        btnRun = New Button()
        TimerWall = New Timer(components)
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusCurrent = New ToolStripStatusLabel()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        TimerElapsed = New Timer(components)
        FolderBrowserDialog2 = New FolderBrowserDialog()
        Menu.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        Menu.Location = New Point(0, 0)
        Menu.Name = "Menu"
        Menu.Size = New Size(800, 29)
        Menu.TabIndex = 5
        Menu.Text = "Menu"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem1, GarisBatasToolStripMenuItem1, ExitToolStripMenuItem1})
        FileToolStripMenuItem.Font = New Font("Segoe UI", 12F)
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 25)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem1
        ' 
        NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        NewToolStripMenuItem1.Size = New Size(185, 26)
        NewToolStripMenuItem1.Text = "New"
        ' 
        ' GarisBatasToolStripMenuItem1
        ' 
        GarisBatasToolStripMenuItem1.Name = "GarisBatasToolStripMenuItem1"
        GarisBatasToolStripMenuItem1.Size = New Size(185, 26)
        GarisBatasToolStripMenuItem1.Text = "Garis Batas ( - )"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(185, 26)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Font = New Font("Segoe UI", 12F)
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(54, 25)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(122, 26)
        NewToolStripMenuItem.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(122, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' lblFolderpath
        ' 
        lblFolderpath.AutoSize = True
        lblFolderpath.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFolderpath.Location = New Point(12, 52)
        lblFolderpath.Name = "lblFolderpath"
        lblFolderpath.Size = New Size(95, 21)
        lblFolderpath.TabIndex = 7
        lblFolderpath.Text = "Folder Path :"
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(113, 54)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(537, 23)
        txtPath.TabIndex = 8
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(674, 54)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(75, 23)
        btnBrowse.TabIndex = 9
        btnBrowse.Text = "..."
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(12, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(289, 21)
        Label1.TabIndex = 10
        Label1.Text = "Please select one or more picture below "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(clbWallpaper)
        Panel1.Location = New Point(12, 137)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 280)
        Panel1.TabIndex = 11
        ' 
        ' clbWallpaper
        ' 
        clbWallpaper.BorderStyle = BorderStyle.None
        clbWallpaper.Font = New Font("Segoe UI", 12F)
        clbWallpaper.FormattingEnabled = True
        clbWallpaper.Location = New Point(13, 16)
        clbWallpaper.Name = "clbWallpaper"
        clbWallpaper.Size = New Size(210, 240)
        clbWallpaper.TabIndex = 0
        ' 
        ' cbPreview
        ' 
        cbPreview.AutoSize = True
        cbPreview.Checked = True
        cbPreview.CheckState = CheckState.Checked
        cbPreview.Font = New Font("Segoe UI", 12F)
        cbPreview.Location = New Point(421, 137)
        cbPreview.Name = "cbPreview"
        cbPreview.Size = New Size(131, 25)
        cbPreview.TabIndex = 12
        cbPreview.Text = "Preview Image"
        cbPreview.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(499, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(421, 168)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(344, 214)
        Panel2.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(14, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 185)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' cbInterval
        ' 
        cbInterval.Font = New Font("Segoe UI", 12F)
        cbInterval.FormattingEnabled = True
        cbInterval.Items.AddRange(New Object() {"10", "60", "3"})
        cbInterval.Location = New Point(500, 394)
        cbInterval.Name = "cbInterval"
        cbInterval.Size = New Size(121, 29)
        cbInterval.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(421, 396)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 21)
        Label3.TabIndex = 16
        Label3.Text = "Interval : "
        ' 
        ' btnRun
        ' 
        btnRun.Font = New Font("Segoe UI", 12F)
        btnRun.Location = New Point(690, 394)
        btnRun.Name = "btnRun"
        btnRun.Size = New Size(75, 31)
        btnRun.TabIndex = 17
        btnRun.Text = "Run"
        btnRun.UseVisualStyleBackColor = True
        ' 
        ' TimerWall
        ' 
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusCurrent})
        StatusStrip1.Location = New Point(0, 436)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 24)
        StatusStrip1.TabIndex = 18
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Font = New Font("Segoe UI", 10F)
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(46, 19)
        ToolStripStatusReady.Text = "Ready"
        ' 
        ' ToolStripStatusCurrent
        ' 
        ToolStripStatusCurrent.Name = "ToolStripStatusCurrent"
        ToolStripStatusCurrent.Size = New Size(139, 19)
        ToolStripStatusCurrent.Text = "Current Wallpaper: none."
        ' 
        ' TimerElapsed
        ' 
        TimerElapsed.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 460)
        Controls.Add(StatusStrip1)
        Controls.Add(btnRun)
        Controls.Add(Label3)
        Controls.Add(cbInterval)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(cbPreview)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(txtPath)
        Controls.Add(lblFolderpath)
        Controls.Add(Menu)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Wallpaper Changer"
        Menu.ResumeLayout(False)
        Menu.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblFolderpath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents clbWallpaper As CheckedListBox
    Friend WithEvents cbPreview As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbInterval As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GarisBatasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TimerWall As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusCurrent As ToolStripStatusLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TimerElapsed As Timer
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Private WithEvents PictureBox1 As PictureBox

End Class
