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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripProgressBar1 = New ToolStripProgressBar()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExportToolStripMenuItem = New ToolStripMenuItem()
        RefreshToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        btnSearch = New Button()
        txtExtension = New TextBox()
        cbFind = New ComboBox()
        Label1 = New Label()
        SplitContainer1 = New SplitContainer()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        tvDrive = New TreeView()
        lvFile = New ListView()
        chName = New ColumnHeader()
        Extension = New ColumnHeader()
        FileSize = New ColumnHeader()
        LastModified = New ColumnHeader()
        LastAccessed = New ColumnHeader()
        CreatedDate = New ColumnHeader()
        Attributes = New ColumnHeader()
        FullPath = New ColumnHeader()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        OpenFolderToolStripMenuItem = New ToolStripMenuItem()
        CopyPathToolStripMenuItem = New ToolStripMenuItem()
        CopyFolderPathToClipboardToolStripMenuItem = New ToolStripMenuItem()
        ImageList1 = New ImageList(components)
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel3.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripProgressBar1})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(683, 17)
        ToolStripStatusLabel1.Spring = True
        ToolStripStatusLabel1.Text = "Ready."
        ToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ToolStripProgressBar1
        ' 
        ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        ToolStripProgressBar1.Size = New Size(100, 16)
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExportToolStripMenuItem, RefreshToolStripMenuItem, ToolStripSeparator1, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' ExportToolStripMenuItem
        ' 
        ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        ExportToolStripMenuItem.Size = New Size(209, 22)
        ExportToolStripMenuItem.Text = "Export File List to Text File"
        ' 
        ' RefreshToolStripMenuItem
        ' 
        RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        RefreshToolStripMenuItem.Size = New Size(209, 22)
        RefreshToolStripMenuItem.Text = "Refresh Folder"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(206, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(209, 22)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(180, 22)
        HelpToolStripMenuItem1.Text = "Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(180, 22)
        AboutToolStripMenuItem.Text = "A&bout"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(txtExtension)
        Panel1.Controls.Add(cbFind)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 27)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 39)
        Panel1.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(730, 9)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(58, 23)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtExtension
        ' 
        txtExtension.Location = New Point(686, 9)
        txtExtension.Name = "txtExtension"
        txtExtension.Size = New Size(38, 23)
        txtExtension.TabIndex = 2
        txtExtension.Text = "*.*"
        ' 
        ' cbFind
        ' 
        cbFind.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbFind.AutoCompleteSource = AutoCompleteSource.FileSystem
        cbFind.FormattingEnabled = True
        cbFind.Location = New Point(48, 8)
        cbFind.Name = "cbFind"
        cbFind.Size = New Size(632, 23)
        cbFind.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 15)
        Label1.TabIndex = 0
        Label1.Text = "Find"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Location = New Point(0, 72)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(Panel3)
        SplitContainer1.Panel1.Controls.Add(tvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(lvFile)
        SplitContainer1.Size = New Size(800, 353)
        SplitContainer1.SplitterDistance = 266
        SplitContainer1.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(3, 250)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(260, 100)
        Panel3.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(9, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 15)
        Label2.TabIndex = 0
        Label2.Text = "Free Fixed Disk Info:"
        ' 
        ' tvDrive
        ' 
        tvDrive.Dock = DockStyle.Fill
        tvDrive.Location = New Point(0, 0)
        tvDrive.Name = "tvDrive"
        tvDrive.Size = New Size(266, 353)
        tvDrive.TabIndex = 1
        ' 
        ' lvFile
        ' 
        lvFile.Columns.AddRange(New ColumnHeader() {chName, Extension, FileSize, LastModified, LastAccessed, CreatedDate, Attributes, FullPath})
        lvFile.ContextMenuStrip = ContextMenuStrip1
        lvFile.Dock = DockStyle.Fill
        lvFile.GridLines = True
        lvFile.Location = New Point(0, 0)
        lvFile.Name = "lvFile"
        lvFile.Size = New Size(530, 353)
        lvFile.SmallImageList = ImageList1
        lvFile.TabIndex = 0
        lvFile.UseCompatibleStateImageBehavior = False
        lvFile.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' Extension
        ' 
        Extension.Text = "Extension"
        ' 
        ' FileSize
        ' 
        FileSize.Text = "File Size"
        ' 
        ' LastModified
        ' 
        LastModified.Text = "Last Modified"
        ' 
        ' LastAccessed
        ' 
        LastAccessed.Text = "Last Accessed"
        ' 
        ' CreatedDate
        ' 
        CreatedDate.Text = "Created Date"
        ' 
        ' Attributes
        ' 
        Attributes.Text = "Attributes"
        ' 
        ' FullPath
        ' 
        FullPath.Text = "Full Path"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, OpenFolderToolStripMenuItem, CopyPathToolStripMenuItem, CopyFolderPathToClipboardToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(230, 92)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(229, 22)
        OpenToolStripMenuItem.Text = "Open/Execute FIle"
        ' 
        ' OpenFolderToolStripMenuItem
        ' 
        OpenFolderToolStripMenuItem.Name = "OpenFolderToolStripMenuItem"
        OpenFolderToolStripMenuItem.Size = New Size(229, 22)
        OpenFolderToolStripMenuItem.Text = "Open and Select File in Foder"
        ' 
        ' CopyPathToolStripMenuItem
        ' 
        CopyPathToolStripMenuItem.Name = "CopyPathToolStripMenuItem"
        CopyPathToolStripMenuItem.Size = New Size(229, 22)
        CopyPathToolStripMenuItem.Text = "Copy Full Path to Clipboard"
        ' 
        ' CopyFolderPathToClipboardToolStripMenuItem
        ' 
        CopyFolderPathToClipboardToolStripMenuItem.Name = "CopyFolderPathToClipboardToolStripMenuItem"
        CopyFolderPathToClipboardToolStripMenuItem.Size = New Size(229, 22)
        CopyFolderPathToClipboardToolStripMenuItem.Text = "Copy Full Folder to Clipboard"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp.png")
        ImageList1.Images.SetKeyName(1, "folder.bmp.png")
        ImageList1.Images.SetKeyName(2, "icons8-file-50.png")
        ImageList1.Images.SetKeyName(3, "icons8-exe-50.png")
        ImageList1.Images.SetKeyName(4, "icons8-image-50.png")
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(SplitContainer1)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FileFinder"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label1 As Label
    Friend WithEvents cbFind As ComboBox
    Friend WithEvents txtExtension As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents tvDrive As TreeView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lvFile As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents Extension As ColumnHeader
    Friend WithEvents FileSize As ColumnHeader
    Friend WithEvents LastModified As ColumnHeader
    Friend WithEvents LastAccessed As ColumnHeader
    Friend WithEvents CreatedDate As ColumnHeader
    Friend WithEvents Attributes As ColumnHeader
    Friend WithEvents FullPath As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyFolderPathToClipboardToolStripMenuItem As ToolStripMenuItem

End Class
