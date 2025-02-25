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
        StatusStrip1 = New StatusStrip()
        ToolStripStatusReady = New ToolStripStatusLabel()
        ToolStripStatusLine = New ToolStripStatusLabel()
        insertStripStatus = New ToolStripStatusLabel()
        capsStripStatus = New ToolStripStatusLabel()
        numStripStatus = New ToolStripStatusLabel()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        PageSetupToolStripMenuItem = New ToolStripMenuItem()
        PrintToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        FindToolStripMenuItem = New ToolStripMenuItem()
        FindNextToolStripMenuItem = New ToolStripMenuItem()
        ReplaceToolStripMenuItem = New ToolStripMenuItem()
        GoToToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        InsertDateTimeToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        WordWrapToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        StatusBarToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutNotpadKuToolStripMenuItem = New ToolStripMenuItem()
        OpenFileDialog1 = New OpenFileDialog()
        FontDialog1 = New FontDialog()
        PrintDialog1 = New PrintDialog()
        PageSetupDialog1 = New PageSetupDialog()
        SaveFileDialog1 = New SaveFileDialog()
        PrintDocument1 = New Printing.PrintDocument()
        txtNotepad = New TextBox()
        StatusStrip1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusReady, ToolStripStatusLine, insertStripStatus, capsStripStatus, numStripStatus})
        StatusStrip1.Location = New Point(0, 426)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 24)
        StatusStrip1.TabIndex = 0
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusReady
        ' 
        ToolStripStatusReady.Margin = New Padding(0, 3, 50, 2)
        ToolStripStatusReady.Name = "ToolStripStatusReady"
        ToolStripStatusReady.Size = New Size(42, 19)
        ToolStripStatusReady.Text = "Ready."
        ' 
        ' ToolStripStatusLine
        ' 
        ToolStripStatusLine.BorderSides = ToolStripStatusLabelBorderSides.Left Or ToolStripStatusLabelBorderSides.Right
        ToolStripStatusLine.BorderStyle = Border3DStyle.Etched
        ToolStripStatusLine.Name = "ToolStripStatusLine"
        ToolStripStatusLine.Size = New Size(48, 19)
        ToolStripStatusLine.Text = "Line : 1"
        ' 
        ' insertStripStatus
        ' 
        insertStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        insertStripStatus.BorderStyle = Border3DStyle.Etched
        insertStripStatus.Name = "insertStripStatus"
        insertStripStatus.Size = New Size(29, 19)
        insertStripStatus.Text = "INS"
        ' 
        ' capsStripStatus
        ' 
        capsStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        capsStripStatus.BorderStyle = Border3DStyle.Etched
        capsStripStatus.Enabled = False
        capsStripStatus.Name = "capsStripStatus"
        capsStripStatus.Size = New Size(40, 19)
        capsStripStatus.Text = "CAPS"
        ' 
        ' numStripStatus
        ' 
        numStripStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        numStripStatus.BorderStyle = Border3DStyle.Etched
        numStripStatus.Enabled = False
        numStripStatus.Name = "numStripStatus"
        numStripStatus.Size = New Size(39, 19)
        numStripStatus.Text = "NUM"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, FormatToolStripMenuItem, ViewToolStripMenuItem, AboutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator1, PageSetupToolStripMenuItem, PrintToolStripMenuItem, ToolStripSeparator2, CloseToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(133, 22)
        NewToolStripMenuItem.Text = "&New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(133, 22)
        OpenToolStripMenuItem.Text = "&Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(133, 22)
        SaveToolStripMenuItem.Text = "&Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(133, 22)
        SaveAsToolStripMenuItem.Text = "&Save &As..."
        SaveAsToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(130, 6)
        ' 
        ' PageSetupToolStripMenuItem
        ' 
        PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        PageSetupToolStripMenuItem.Size = New Size(133, 22)
        PageSetupToolStripMenuItem.Text = "&Page Setup"
        ' 
        ' PrintToolStripMenuItem
        ' 
        PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        PrintToolStripMenuItem.Size = New Size(133, 22)
        PrintToolStripMenuItem.Text = "P&rint"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(130, 6)
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(133, 22)
        CloseToolStripMenuItem.Text = "&Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(133, 22)
        ExitToolStripMenuItem.Text = "&Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, ToolStripSeparator3, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator4, FindToolStripMenuItem, FindNextToolStripMenuItem, ReplaceToolStripMenuItem, GoToToolStripMenuItem, ToolStripSeparator5, SelectAllToolStripMenuItem, InsertDateTimeToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(39, 20)
        EditToolStripMenuItem.Text = "&Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(159, 22)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(156, 6)
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(159, 22)
        CutToolStripMenuItem.Text = "&Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(159, 22)
        CopyToolStripMenuItem.Text = "C&opy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(159, 22)
        PasteToolStripMenuItem.Text = "&Paste"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(156, 6)
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(159, 22)
        FindToolStripMenuItem.Text = "&Find..."
        ' 
        ' FindNextToolStripMenuItem
        ' 
        FindNextToolStripMenuItem.Name = "FindNextToolStripMenuItem"
        FindNextToolStripMenuItem.Size = New Size(159, 22)
        FindNextToolStripMenuItem.Text = "Find &Next"
        ' 
        ' ReplaceToolStripMenuItem
        ' 
        ReplaceToolStripMenuItem.Name = "ReplaceToolStripMenuItem"
        ReplaceToolStripMenuItem.Size = New Size(159, 22)
        ReplaceToolStripMenuItem.Text = "&Replace..."
        ' 
        ' GoToToolStripMenuItem
        ' 
        GoToToolStripMenuItem.Name = "GoToToolStripMenuItem"
        GoToToolStripMenuItem.Size = New Size(159, 22)
        GoToToolStripMenuItem.Text = "&Go To..."
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(156, 6)
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(159, 22)
        SelectAllToolStripMenuItem.Text = "&Select All"
        ' 
        ' InsertDateTimeToolStripMenuItem
        ' 
        InsertDateTimeToolStripMenuItem.Name = "InsertDateTimeToolStripMenuItem"
        InsertDateTimeToolStripMenuItem.Size = New Size(159, 22)
        InsertDateTimeToolStripMenuItem.Text = "Insert Date &Time"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {WordWrapToolStripMenuItem, FontToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(57, 20)
        FormatToolStripMenuItem.Text = "&Format"
        ' 
        ' WordWrapToolStripMenuItem
        ' 
        WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        WordWrapToolStripMenuItem.Size = New Size(180, 22)
        WordWrapToolStripMenuItem.Text = "&Word Wrap"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(180, 22)
        FontToolStripMenuItem.Text = "F&ont"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StatusBarToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "&View"
        ' 
        ' StatusBarToolStripMenuItem
        ' 
        StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        StatusBarToolStripMenuItem.Size = New Size(132, 22)
        StatusBarToolStripMenuItem.Text = "$Status Bar"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem, AboutNotpadKuToolStripMenuItem})
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(52, 20)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(164, 22)
        HelpToolStripMenuItem.Text = "&Help..."
        ' 
        ' AboutNotpadKuToolStripMenuItem
        ' 
        AboutNotpadKuToolStripMenuItem.Name = "AboutNotpadKuToolStripMenuItem"
        AboutNotpadKuToolStripMenuItem.Size = New Size(164, 22)
        AboutNotpadKuToolStripMenuItem.Text = "About NotpadKu"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "*.txt"
        OpenFileDialog1.FileName = "Untitled"
        OpenFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        OpenFileDialog1.Title = "Open File Text"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PageSetupDialog1
        ' 
        PageSetupDialog1.EnableMetric = True
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "*.txt"
        SaveFileDialog1.FileName = "Untitled.txt"
        SaveFileDialog1.Filter = "Text File|*.txt|All Files|*.*"
        SaveFileDialog1.Title = "Save File Text as"
        ' 
        ' txtNotepad
        ' 
        txtNotepad.AcceptsReturn = True
        txtNotepad.AcceptsTab = True
        txtNotepad.AllowDrop = True
        txtNotepad.Dock = DockStyle.Fill
        txtNotepad.Location = New Point(0, 24)
        txtNotepad.Multiline = True
        txtNotepad.Name = "txtNotepad"
        txtNotepad.ScrollBars = ScrollBars.Both
        txtNotepad.Size = New Size(800, 402)
        txtNotepad.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNotepad)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = " NotePadKU"
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindNextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReplaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertDateTimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusReady As ToolStripStatusLabel
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotpadKuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLine As ToolStripStatusLabel
    Friend WithEvents insertStripStatus As ToolStripStatusLabel
    Friend WithEvents capsStripStatus As ToolStripStatusLabel
    Friend WithEvents numStripStatus As ToolStripStatusLabel
    Friend WithEvents txtNotepad As TextBox

End Class
