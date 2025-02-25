<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        StatusStrip1 = New StatusStrip()
        toolStripStatusReady = New ToolStripStatusLabel()
        toolStripStatusDimension = New ToolStripStatusLabel()
        toolStripStatusBits = New ToolStripStatusLabel()
        toolStripStatusResolution = New ToolStripStatusLabel()
        toolStripStatusRawFormat = New ToolStripStatusLabel()
        ToolTip1 = New ToolTip(components)
        TvDrive = New TreeView()
        ImageList1 = New ImageList(components)
        LvImage = New ListView()
        chName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chFileSize = New ColumnHeader()
        chLastModified = New ColumnHeader()
        chLastAccessed = New ColumnHeader()
        chCreatedDate = New ColumnHeader()
        chAttributes = New ColumnHeader()
        PictureBox1 = New PictureBox()
        SplitContainer1 = New SplitContainer()
        SplitContainerBawah = New SplitContainer()
        SplitContainerBawah2 = New SplitContainer()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PropertyGrid1 = New PropertyGrid()
        TabPage2 = New TabPage()
        lvExif = New ListView()
        chProperty = New ColumnHeader()
        chValue = New ColumnHeader()
        StatusStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah.Panel1.SuspendLayout()
        SplitContainerBawah.Panel2.SuspendLayout()
        SplitContainerBawah.SuspendLayout()
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerBawah2.Panel1.SuspendLayout()
        SplitContainerBawah2.Panel2.SuspendLayout()
        SplitContainerBawah2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {toolStripStatusReady, toolStripStatusDimension, toolStripStatusBits, toolStripStatusResolution, toolStripStatusRawFormat})
        StatusStrip1.Location = New Point(0, 567)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(723, 24)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' toolStripStatusReady
        ' 
        toolStripStatusReady.Name = "toolStripStatusReady"
        toolStripStatusReady.Size = New Size(42, 19)
        toolStripStatusReady.Text = "Ready."
        ' 
        ' toolStripStatusDimension
        ' 
        toolStripStatusDimension.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusDimension.BorderStyle = Border3DStyle.Etched
        toolStripStatusDimension.Name = "toolStripStatusDimension"
        toolStripStatusDimension.Size = New Size(73, 19)
        toolStripStatusDimension.Text = "Dimensions"
        ' 
        ' toolStripStatusBits
        ' 
        toolStripStatusBits.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusBits.BorderStyle = Border3DStyle.Etched
        toolStripStatusBits.Name = "toolStripStatusBits"
        toolStripStatusBits.Size = New Size(54, 19)
        toolStripStatusBits.Text = "# of bits"
        ' 
        ' toolStripStatusResolution
        ' 
        toolStripStatusResolution.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusResolution.BorderStyle = Border3DStyle.Etched
        toolStripStatusResolution.ForeColor = SystemColors.ActiveCaptionText
        toolStripStatusResolution.Name = "toolStripStatusResolution"
        toolStripStatusResolution.Size = New Size(67, 19)
        toolStripStatusResolution.Text = "Resolution"
        ' 
        ' toolStripStatusRawFormat
        ' 
        toolStripStatusRawFormat.BorderSides = ToolStripStatusLabelBorderSides.Left
        toolStripStatusRawFormat.BorderStyle = Border3DStyle.Etched
        toolStripStatusRawFormat.Name = "toolStripStatusRawFormat"
        toolStripStatusRawFormat.Size = New Size(74, 19)
        toolStripStatusRawFormat.Text = "Raw Format"
        ' 
        ' ToolTip1
        ' 
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ToolTip1.ToolTipTitle = "ImageViewer Tip:"
        ' 
        ' TvDrive
        ' 
        TvDrive.Dock = DockStyle.Fill
        TvDrive.ImageIndex = 0
        TvDrive.ImageList = ImageList1
        TvDrive.Location = New Point(0, 0)
        TvDrive.Name = "TvDrive"
        TvDrive.SelectedImageIndex = 0
        TvDrive.Size = New Size(159, 567)
        TvDrive.TabIndex = 0
        ToolTip1.SetToolTip(TvDrive, "Please select drive/folder that contain")
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drive.bmp.png")
        ImageList1.Images.SetKeyName(1, "folder.bmp.png")
        ' 
        ' LvImage
        ' 
        LvImage.Columns.AddRange(New ColumnHeader() {chName, chExtension, chFileSize, chLastModified, chLastAccessed, chCreatedDate, chAttributes})
        LvImage.Dock = DockStyle.Fill
        LvImage.GridLines = True
        LvImage.Location = New Point(0, 0)
        LvImage.Name = "LvImage"
        LvImage.Size = New Size(560, 354)
        LvImage.SmallImageList = ImageList1
        LvImage.TabIndex = 2
        ToolTip1.SetToolTip(LvImage, "Image file(s)")
        LvImage.UseCompatibleStateImageBehavior = False
        LvImage.View = View.Details
        ' 
        ' chName
        ' 
        chName.Text = "Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = "Extension"
        ' 
        ' chFileSize
        ' 
        chFileSize.Text = "File Size"
        ' 
        ' chLastModified
        ' 
        chLastModified.Text = "Modified Date"
        ' 
        ' chLastAccessed
        ' 
        chLastAccessed.Text = "Last Accessed"
        ' 
        ' chCreatedDate
        ' 
        chCreatedDate.Text = "Created Date"
        ' 
        ' chAttributes
        ' 
        chAttributes.Text = "Attributes "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(339, 209)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ToolTip1.SetToolTip(PictureBox1, "Double click to view this image in auto")
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(TvDrive)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SplitContainerBawah)
        SplitContainer1.Panel2.ForeColor = SystemColors.ControlLightLight
        SplitContainer1.Size = New Size(723, 567)
        SplitContainer1.SplitterDistance = 159
        SplitContainer1.TabIndex = 1
        ' 
        ' SplitContainerBawah
        ' 
        SplitContainerBawah.Dock = DockStyle.Fill
        SplitContainerBawah.Location = New Point(0, 0)
        SplitContainerBawah.Name = "SplitContainerBawah"
        SplitContainerBawah.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainerBawah.Panel1
        ' 
        SplitContainerBawah.Panel1.Controls.Add(LvImage)
        ' 
        ' SplitContainerBawah.Panel2
        ' 
        SplitContainerBawah.Panel2.Controls.Add(SplitContainerBawah2)
        SplitContainerBawah.Size = New Size(560, 567)
        SplitContainerBawah.SplitterDistance = 354
        SplitContainerBawah.TabIndex = 0
        ' 
        ' SplitContainerBawah2
        ' 
        SplitContainerBawah2.Dock = DockStyle.Fill
        SplitContainerBawah2.Location = New Point(0, 0)
        SplitContainerBawah2.Name = "SplitContainerBawah2"
        ' 
        ' SplitContainerBawah2.Panel1
        ' 
        SplitContainerBawah2.Panel1.Controls.Add(TabControl1)
        ' 
        ' SplitContainerBawah2.Panel2
        ' 
        SplitContainerBawah2.Panel2.Controls.Add(PictureBox1)
        SplitContainerBawah2.Size = New Size(560, 209)
        SplitContainerBawah2.SplitterDistance = 217
        SplitContainerBawah2.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.AccessibleName = ""
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(217, 209)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(PropertyGrid1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(209, 181)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Image Properties"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' PropertyGrid1
        ' 
        PropertyGrid1.Dock = DockStyle.Fill
        PropertyGrid1.Location = New Point(3, 3)
        PropertyGrid1.Name = "PropertyGrid1"
        PropertyGrid1.Size = New Size(203, 175)
        PropertyGrid1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(lvExif)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(209, 181)
        TabPage2.TabIndex = 1
        TabPage2.Text = "EXIF Metadata"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' lvExif
        ' 
        lvExif.Columns.AddRange(New ColumnHeader() {chProperty, chValue})
        lvExif.Dock = DockStyle.Fill
        lvExif.GridLines = True
        lvExif.Location = New Point(3, 3)
        lvExif.Name = "lvExif"
        lvExif.Size = New Size(203, 175)
        lvExif.TabIndex = 0
        lvExif.UseCompatibleStateImageBehavior = False
        lvExif.View = View.Details
        ' 
        ' chProperty
        ' 
        chProperty.Text = "Property"
        ' 
        ' chValue
        ' 
        chValue.Text = "Value"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(723, 591)
        Controls.Add(SplitContainer1)
        Controls.Add(StatusStrip1)
        Name = "Form1"
        Text = "Form1"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainerBawah.Panel1.ResumeLayout(False)
        SplitContainerBawah.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah.ResumeLayout(False)
        SplitContainerBawah2.Panel1.ResumeLayout(False)
        SplitContainerBawah2.Panel2.ResumeLayout(False)
        CType(SplitContainerBawah2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerBawah2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents toolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents toolStripStatusDimension As ToolStripStatusLabel
    Friend WithEvents toolStripStatusBits As ToolStripStatusLabel
    Friend WithEvents toolStripStatusResolution As ToolStripStatusLabel
    Friend WithEvents toolStripStatusRawFormat As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TvDrive As TreeView
    Friend WithEvents SplitContainerBawah As SplitContainer
    Friend WithEvents SplitContainerBawah2 As SplitContainer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents LvImage As ListView
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents PropertyGrid1 As PropertyGrid
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents lvExif As ListView
    Friend WithEvents chProperty As ColumnHeader
    Friend WithEvents chValue As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
End Class
