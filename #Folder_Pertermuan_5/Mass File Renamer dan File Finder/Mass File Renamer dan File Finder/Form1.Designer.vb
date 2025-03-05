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
        FolderBrowserDialog1 = New FolderBrowserDialog()
        Label1 = New Label()
        txtPath = New TextBox()
        btnPath = New Button()
        Label2 = New Label()
        txtExt = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        lvlOri = New ListView()
        chFileName = New ColumnHeader()
        chExtension = New ColumnHeader()
        chAttribute = New ColumnHeader()
        chCreated = New ColumnHeader()
        chAccessed = New ColumnHeader()
        chModified = New ColumnHeader()
        lvlPreview = New ListView()
        chFileName2 = New ColumnHeader()
        chExtension2 = New ColumnHeader()
        chAttribute2 = New ColumnHeader()
        chCreated2 = New ColumnHeader()
        chAccessed2 = New ColumnHeader()
        chModified2 = New ColumnHeader()
        TabControl1 = New TabControl()
        tpFileName = New TabPage()
        cbCaseF = New ComboBox()
        txtWithThisF = New TextBox()
        txtInsertAfterF = New TextBox()
        txtRightCropNCharF = New TextBox()
        rbInsertAfterF = New RadioButton()
        txtLeftCropNCharF = New TextBox()
        txtInsertBeforeF = New TextBox()
        txtReplaceThisF = New TextBox()
        txtReplaceWithF = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        rbRightCropNCharF = New RadioButton()
        rbLeftCropNCharF = New RadioButton()
        rbInsertBeforeF = New RadioButton()
        rbReplaceThisF = New RadioButton()
        rbReplaceWithF = New RadioButton()
        tpExtension = New TabPage()
        cbCaseE = New ComboBox()
        txtWithThisE = New TextBox()
        txtInsertAfterE = New TextBox()
        txtRightCropNCharE = New TextBox()
        rbInsertAfterE = New RadioButton()
        Label7 = New Label()
        Label8 = New Label()
        rbRightCropNCharE = New RadioButton()
        txtLeftCropNCharE = New TextBox()
        txtInsertBeforeE = New TextBox()
        txtReplaceThisE = New TextBox()
        txtReplaceWithE = New TextBox()
        rbLeftCropNCharE = New RadioButton()
        rbInsertBeforeE = New RadioButton()
        rbReplaceThisE = New RadioButton()
        rbReplaceWithE = New RadioButton()
        tpAutonumber = New TabPage()
        gbWith = New GroupBox()
        nudIncrementBy = New NumericUpDown()
        nudStartWithNumber = New NumericUpDown()
        Label10 = New Label()
        Label9 = New Label()
        gbPlace = New GroupBox()
        rbBeforeFileName = New RadioButton()
        rbAfterFileName = New RadioButton()
        btnPreview = New Button()
        btnRename = New Button()
        btnUndo = New Button()
        ImageList1 = New ImageList(components)
        TabControl1.SuspendLayout()
        tpFileName.SuspendLayout()
        tpExtension.SuspendLayout()
        tpAutonumber.SuspendLayout()
        gbWith.SuspendLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).BeginInit()
        gbPlace.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 15)
        Label1.TabIndex = 0
        Label1.Text = "Path : "
        ' 
        ' txtPath
        ' 
        txtPath.Location = New Point(58, 28)
        txtPath.Name = "txtPath"
        txtPath.ReadOnly = True
        txtPath.Size = New Size(536, 23)
        txtPath.TabIndex = 1
        ' 
        ' btnPath
        ' 
        btnPath.Location = New Point(600, 29)
        btnPath.Name = "btnPath"
        btnPath.Size = New Size(44, 23)
        btnPath.TabIndex = 2
        btnPath.Text = "..."
        btnPath.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(650, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 3
        Label2.Text = "File Mask"
        ' 
        ' txtExt
        ' 
        txtExt.Location = New Point(712, 29)
        txtExt.Name = "txtExt"
        txtExt.Size = New Size(62, 23)
        txtExt.TabIndex = 4
        txtExt.Text = "*.*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 63)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 15)
        Label3.TabIndex = 5
        Label3.Text = "Original File"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(494, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 6
        Label4.Text = "Preview File"
        ' 
        ' lvlOri
        ' 
        lvlOri.Columns.AddRange(New ColumnHeader() {chFileName, chExtension, chAttribute, chCreated, chAccessed, chModified})
        lvlOri.GridLines = True
        lvlOri.Location = New Point(12, 81)
        lvlOri.Name = "lvlOri"
        lvlOri.Size = New Size(433, 269)
        lvlOri.TabIndex = 7
        lvlOri.UseCompatibleStateImageBehavior = False
        lvlOri.View = View.Details
        ' 
        ' chFileName
        ' 
        chFileName.Text = "File Name"
        ' 
        ' chExtension
        ' 
        chExtension.Text = " Extension"
        ' 
        ' chAttribute
        ' 
        chAttribute.Text = "Attributes"
        ' 
        ' chCreated
        ' 
        chCreated.Text = "Date Created"
        ' 
        ' chAccessed
        ' 
        chAccessed.Text = "Date Accessed"
        ' 
        ' chModified
        ' 
        chModified.Text = "Date Modified"
        ' 
        ' lvlPreview
        ' 
        lvlPreview.Columns.AddRange(New ColumnHeader() {chFileName2, chExtension2, chAttribute2, chCreated2, chAccessed2, chModified2})
        lvlPreview.GridLines = True
        lvlPreview.Location = New Point(460, 81)
        lvlPreview.Name = "lvlPreview"
        lvlPreview.Size = New Size(432, 269)
        lvlPreview.TabIndex = 8
        lvlPreview.UseCompatibleStateImageBehavior = False
        lvlPreview.View = View.Details
        ' 
        ' chFileName2
        ' 
        chFileName2.Text = "File Name"
        ' 
        ' chExtension2
        ' 
        chExtension2.Text = "Extension"
        ' 
        ' chCreated2
        ' 
        chCreated2.Text = "Date Created"
        ' 
        ' chAccessed2
        ' 
        chAccessed2.Text = "Date Accessed"
        ' 
        ' chModified2
        ' 
        chModified2.Text = "Date Modified"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpFileName)
        TabControl1.Controls.Add(tpExtension)
        TabControl1.Controls.Add(tpAutonumber)
        TabControl1.Location = New Point(12, 356)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(790, 183)
        TabControl1.TabIndex = 9
        ' 
        ' tpFileName
        ' 
        tpFileName.Controls.Add(cbCaseF)
        tpFileName.Controls.Add(txtWithThisF)
        tpFileName.Controls.Add(txtInsertAfterF)
        tpFileName.Controls.Add(txtRightCropNCharF)
        tpFileName.Controls.Add(rbInsertAfterF)
        tpFileName.Controls.Add(txtLeftCropNCharF)
        tpFileName.Controls.Add(txtInsertBeforeF)
        tpFileName.Controls.Add(txtReplaceThisF)
        tpFileName.Controls.Add(txtReplaceWithF)
        tpFileName.Controls.Add(Label6)
        tpFileName.Controls.Add(Label5)
        tpFileName.Controls.Add(rbRightCropNCharF)
        tpFileName.Controls.Add(rbLeftCropNCharF)
        tpFileName.Controls.Add(rbInsertBeforeF)
        tpFileName.Controls.Add(rbReplaceThisF)
        tpFileName.Controls.Add(rbReplaceWithF)
        tpFileName.Location = New Point(4, 24)
        tpFileName.Name = "tpFileName"
        tpFileName.Padding = New Padding(3)
        tpFileName.Size = New Size(782, 155)
        tpFileName.TabIndex = 0
        tpFileName.Text = "Filename"
        tpFileName.UseVisualStyleBackColor = True
        ' 
        ' cbCaseF
        ' 
        cbCaseF.FormattingEnabled = True
        cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseF.Location = New Point(574, 19)
        cbCaseF.Name = "cbCaseF"
        cbCaseF.Size = New Size(202, 23)
        cbCaseF.TabIndex = 15
        ' 
        ' txtWithThisF
        ' 
        txtWithThisF.Location = New Point(527, 48)
        txtWithThisF.Name = "txtWithThisF"
        txtWithThisF.ReadOnly = True
        txtWithThisF.Size = New Size(249, 23)
        txtWithThisF.TabIndex = 14
        ' 
        ' txtInsertAfterF
        ' 
        txtInsertAfterF.Location = New Point(527, 77)
        txtInsertAfterF.Name = "txtInsertAfterF"
        txtInsertAfterF.ReadOnly = True
        txtInsertAfterF.Size = New Size(249, 23)
        txtInsertAfterF.TabIndex = 13
        ' 
        ' txtRightCropNCharF
        ' 
        txtRightCropNCharF.Location = New Point(559, 106)
        txtRightCropNCharF.Name = "txtRightCropNCharF"
        txtRightCropNCharF.ReadOnly = True
        txtRightCropNCharF.Size = New Size(217, 23)
        txtRightCropNCharF.TabIndex = 12
        ' 
        ' rbInsertAfterF
        ' 
        rbInsertAfterF.AutoSize = True
        rbInsertAfterF.Location = New Point(435, 81)
        rbInsertAfterF.Name = "rbInsertAfterF"
        rbInsertAfterF.Size = New Size(83, 19)
        rbInsertAfterF.TabIndex = 11
        rbInsertAfterF.Text = "Insert After"
        rbInsertAfterF.UseVisualStyleBackColor = True
        ' 
        ' txtLeftCropNCharF
        ' 
        txtLeftCropNCharF.Location = New Point(121, 106)
        txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        txtLeftCropNCharF.ReadOnly = True
        txtLeftCropNCharF.Size = New Size(164, 23)
        txtLeftCropNCharF.TabIndex = 10
        ' 
        ' txtInsertBeforeF
        ' 
        txtInsertBeforeF.Location = New Point(121, 77)
        txtInsertBeforeF.Name = "txtInsertBeforeF"
        txtInsertBeforeF.ReadOnly = True
        txtInsertBeforeF.Size = New Size(308, 23)
        txtInsertBeforeF.TabIndex = 9
        ' 
        ' txtReplaceThisF
        ' 
        txtReplaceThisF.Location = New Point(121, 48)
        txtReplaceThisF.Name = "txtReplaceThisF"
        txtReplaceThisF.ReadOnly = True
        txtReplaceThisF.Size = New Size(340, 23)
        txtReplaceThisF.TabIndex = 8
        ' 
        ' txtReplaceWithF
        ' 
        txtReplaceWithF.Location = New Point(121, 19)
        txtReplaceWithF.Name = "txtReplaceWithF"
        txtReplaceWithF.ReadOnly = True
        txtReplaceWithF.Size = New Size(400, 23)
        txtReplaceWithF.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(467, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 15)
        Label6.TabIndex = 6
        Label6.Text = "With this"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(527, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 5
        Label5.Text = "Case : "
        ' 
        ' rbRightCropNCharF
        ' 
        rbRightCropNCharF.AutoSize = True
        rbRightCropNCharF.Location = New Point(435, 111)
        rbRightCropNCharF.Name = "rbRightCropNCharF"
        rbRightCropNCharF.Size = New Size(118, 19)
        rbRightCropNCharF.TabIndex = 4
        rbRightCropNCharF.Text = "Right Crop n char"
        rbRightCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbLeftCropNCharF
        ' 
        rbLeftCropNCharF.AutoSize = True
        rbLeftCropNCharF.Location = New Point(10, 106)
        rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        rbLeftCropNCharF.Size = New Size(110, 19)
        rbLeftCropNCharF.TabIndex = 3
        rbLeftCropNCharF.Text = "Left Crop n char"
        rbLeftCropNCharF.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeF
        ' 
        rbInsertBeforeF.AutoSize = True
        rbInsertBeforeF.Location = New Point(10, 81)
        rbInsertBeforeF.Name = "rbInsertBeforeF"
        rbInsertBeforeF.Size = New Size(91, 19)
        rbInsertBeforeF.TabIndex = 2
        rbInsertBeforeF.Text = "Insert Before"
        rbInsertBeforeF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisF
        ' 
        rbReplaceThisF.AutoSize = True
        rbReplaceThisF.Location = New Point(10, 52)
        rbReplaceThisF.Name = "rbReplaceThisF"
        rbReplaceThisF.Size = New Size(90, 19)
        rbReplaceThisF.TabIndex = 1
        rbReplaceThisF.Text = "Replace This"
        rbReplaceThisF.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithF
        ' 
        rbReplaceWithF.AutoSize = True
        rbReplaceWithF.Checked = True
        rbReplaceWithF.Location = New Point(10, 23)
        rbReplaceWithF.Name = "rbReplaceWithF"
        rbReplaceWithF.Size = New Size(94, 19)
        rbReplaceWithF.TabIndex = 0
        rbReplaceWithF.TabStop = True
        rbReplaceWithF.Text = "Replace With"
        rbReplaceWithF.UseVisualStyleBackColor = True
        ' 
        ' tpExtension
        ' 
        tpExtension.Controls.Add(cbCaseE)
        tpExtension.Controls.Add(txtWithThisE)
        tpExtension.Controls.Add(txtInsertAfterE)
        tpExtension.Controls.Add(txtRightCropNCharE)
        tpExtension.Controls.Add(rbInsertAfterE)
        tpExtension.Controls.Add(Label7)
        tpExtension.Controls.Add(Label8)
        tpExtension.Controls.Add(rbRightCropNCharE)
        tpExtension.Controls.Add(txtLeftCropNCharE)
        tpExtension.Controls.Add(txtInsertBeforeE)
        tpExtension.Controls.Add(txtReplaceThisE)
        tpExtension.Controls.Add(txtReplaceWithE)
        tpExtension.Controls.Add(rbLeftCropNCharE)
        tpExtension.Controls.Add(rbInsertBeforeE)
        tpExtension.Controls.Add(rbReplaceThisE)
        tpExtension.Controls.Add(rbReplaceWithE)
        tpExtension.Location = New Point(4, 24)
        tpExtension.Name = "tpExtension"
        tpExtension.Padding = New Padding(3)
        tpExtension.Size = New Size(782, 155)
        tpExtension.TabIndex = 1
        tpExtension.Text = "Extension"
        tpExtension.UseVisualStyleBackColor = True
        ' 
        ' cbCaseE
        ' 
        cbCaseE.FormattingEnabled = True
        cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        cbCaseE.Location = New Point(574, 20)
        cbCaseE.Name = "cbCaseE"
        cbCaseE.Size = New Size(202, 23)
        cbCaseE.TabIndex = 26
        ' 
        ' txtWithThisE
        ' 
        txtWithThisE.Location = New Point(527, 49)
        txtWithThisE.Name = "txtWithThisE"
        txtWithThisE.ReadOnly = True
        txtWithThisE.Size = New Size(249, 23)
        txtWithThisE.TabIndex = 25
        ' 
        ' txtInsertAfterE
        ' 
        txtInsertAfterE.Location = New Point(527, 78)
        txtInsertAfterE.Name = "txtInsertAfterE"
        txtInsertAfterE.ReadOnly = True
        txtInsertAfterE.Size = New Size(249, 23)
        txtInsertAfterE.TabIndex = 24
        ' 
        ' txtRightCropNCharE
        ' 
        txtRightCropNCharE.Location = New Point(559, 107)
        txtRightCropNCharE.Name = "txtRightCropNCharE"
        txtRightCropNCharE.ReadOnly = True
        txtRightCropNCharE.Size = New Size(217, 23)
        txtRightCropNCharE.TabIndex = 23
        ' 
        ' rbInsertAfterE
        ' 
        rbInsertAfterE.AutoSize = True
        rbInsertAfterE.Location = New Point(435, 82)
        rbInsertAfterE.Name = "rbInsertAfterE"
        rbInsertAfterE.Size = New Size(83, 19)
        rbInsertAfterE.TabIndex = 22
        rbInsertAfterE.Text = "Insert After"
        rbInsertAfterE.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(467, 55)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 21
        Label7.Text = "With this"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(527, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(41, 15)
        Label8.TabIndex = 20
        Label8.Text = "Case : "
        ' 
        ' rbRightCropNCharE
        ' 
        rbRightCropNCharE.AutoSize = True
        rbRightCropNCharE.Location = New Point(435, 112)
        rbRightCropNCharE.Name = "rbRightCropNCharE"
        rbRightCropNCharE.Size = New Size(118, 19)
        rbRightCropNCharE.TabIndex = 19
        rbRightCropNCharE.Text = "Right Crop n char"
        rbRightCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' txtLeftCropNCharE
        ' 
        txtLeftCropNCharE.Location = New Point(121, 107)
        txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        txtLeftCropNCharE.ReadOnly = True
        txtLeftCropNCharE.Size = New Size(164, 23)
        txtLeftCropNCharE.TabIndex = 18
        ' 
        ' txtInsertBeforeE
        ' 
        txtInsertBeforeE.Location = New Point(121, 78)
        txtInsertBeforeE.Name = "txtInsertBeforeE"
        txtInsertBeforeE.ReadOnly = True
        txtInsertBeforeE.Size = New Size(308, 23)
        txtInsertBeforeE.TabIndex = 17
        ' 
        ' txtReplaceThisE
        ' 
        txtReplaceThisE.Location = New Point(121, 49)
        txtReplaceThisE.Name = "txtReplaceThisE"
        txtReplaceThisE.ReadOnly = True
        txtReplaceThisE.Size = New Size(340, 23)
        txtReplaceThisE.TabIndex = 16
        ' 
        ' txtReplaceWithE
        ' 
        txtReplaceWithE.Location = New Point(121, 20)
        txtReplaceWithE.Name = "txtReplaceWithE"
        txtReplaceWithE.ReadOnly = True
        txtReplaceWithE.Size = New Size(400, 23)
        txtReplaceWithE.TabIndex = 15
        ' 
        ' rbLeftCropNCharE
        ' 
        rbLeftCropNCharE.AutoSize = True
        rbLeftCropNCharE.Location = New Point(10, 108)
        rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        rbLeftCropNCharE.Size = New Size(110, 19)
        rbLeftCropNCharE.TabIndex = 14
        rbLeftCropNCharE.Text = "Left Crop n char"
        rbLeftCropNCharE.UseVisualStyleBackColor = True
        ' 
        ' rbInsertBeforeE
        ' 
        rbInsertBeforeE.AutoSize = True
        rbInsertBeforeE.Location = New Point(10, 82)
        rbInsertBeforeE.Name = "rbInsertBeforeE"
        rbInsertBeforeE.Size = New Size(91, 19)
        rbInsertBeforeE.TabIndex = 13
        rbInsertBeforeE.Text = "Insert Before"
        rbInsertBeforeE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceThisE
        ' 
        rbReplaceThisE.AutoSize = True
        rbReplaceThisE.Location = New Point(10, 53)
        rbReplaceThisE.Name = "rbReplaceThisE"
        rbReplaceThisE.Size = New Size(90, 19)
        rbReplaceThisE.TabIndex = 12
        rbReplaceThisE.Text = "Replace This"
        rbReplaceThisE.UseVisualStyleBackColor = True
        ' 
        ' rbReplaceWithE
        ' 
        rbReplaceWithE.AutoSize = True
        rbReplaceWithE.Checked = True
        rbReplaceWithE.Location = New Point(10, 24)
        rbReplaceWithE.Name = "rbReplaceWithE"
        rbReplaceWithE.Size = New Size(94, 19)
        rbReplaceWithE.TabIndex = 11
        rbReplaceWithE.TabStop = True
        rbReplaceWithE.Text = "Replace With"
        rbReplaceWithE.UseVisualStyleBackColor = True
        ' 
        ' tpAutonumber
        ' 
        tpAutonumber.Controls.Add(gbWith)
        tpAutonumber.Controls.Add(gbPlace)
        tpAutonumber.Location = New Point(4, 24)
        tpAutonumber.Name = "tpAutonumber"
        tpAutonumber.Size = New Size(782, 155)
        tpAutonumber.TabIndex = 2
        tpAutonumber.Text = "Autonumber"
        tpAutonumber.UseVisualStyleBackColor = True
        ' 
        ' gbWith
        ' 
        gbWith.Controls.Add(nudIncrementBy)
        gbWith.Controls.Add(nudStartWithNumber)
        gbWith.Controls.Add(Label10)
        gbWith.Controls.Add(Label9)
        gbWith.Location = New Point(271, 13)
        gbWith.Name = "gbWith"
        gbWith.Size = New Size(265, 128)
        gbWith.TabIndex = 1
        gbWith.TabStop = False
        gbWith.Text = "With:"
        ' 
        ' nudIncrementBy
        ' 
        nudIncrementBy.Location = New Point(124, 74)
        nudIncrementBy.Name = "nudIncrementBy"
        nudIncrementBy.Size = New Size(120, 23)
        nudIncrementBy.TabIndex = 3
        ' 
        ' nudStartWithNumber
        ' 
        nudStartWithNumber.Location = New Point(124, 45)
        nudStartWithNumber.Name = "nudStartWithNumber"
        nudStartWithNumber.Size = New Size(120, 23)
        nudStartWithNumber.TabIndex = 2
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 79)
        Label10.Name = "Label10"
        Label10.Size = New Size(86, 15)
        Label10.TabIndex = 1
        Label10.Text = "Increment by : "
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 47)
        Label9.Name = "Label9"
        Label9.Size = New Size(112, 15)
        Label9.TabIndex = 0
        Label9.Text = "Start With Number :"
        ' 
        ' gbPlace
        ' 
        gbPlace.Controls.Add(rbBeforeFileName)
        gbPlace.Controls.Add(rbAfterFileName)
        gbPlace.Location = New Point(16, 13)
        gbPlace.Name = "gbPlace"
        gbPlace.Size = New Size(249, 128)
        gbPlace.TabIndex = 0
        gbPlace.TabStop = False
        gbPlace.Text = "Place:"
        ' 
        ' rbBeforeFileName
        ' 
        rbBeforeFileName.AutoSize = True
        rbBeforeFileName.Location = New Point(26, 75)
        rbBeforeFileName.Name = "rbBeforeFileName"
        rbBeforeFileName.Size = New Size(108, 19)
        rbBeforeFileName.TabIndex = 1
        rbBeforeFileName.TabStop = True
        rbBeforeFileName.Text = "Before filename"
        rbBeforeFileName.UseVisualStyleBackColor = True
        ' 
        ' rbAfterFileName
        ' 
        rbAfterFileName.AutoSize = True
        rbAfterFileName.Location = New Point(26, 45)
        rbAfterFileName.Name = "rbAfterFileName"
        rbAfterFileName.Size = New Size(100, 19)
        rbAfterFileName.TabIndex = 0
        rbAfterFileName.TabStop = True
        rbAfterFileName.Text = "After filename"
        rbAfterFileName.UseVisualStyleBackColor = True
        ' 
        ' btnPreview
        ' 
        btnPreview.Location = New Point(808, 380)
        btnPreview.Name = "btnPreview"
        btnPreview.Size = New Size(75, 23)
        btnPreview.TabIndex = 10
        btnPreview.Text = "Preview"
        btnPreview.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Location = New Point(808, 409)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(75, 23)
        btnRename.TabIndex = 11
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' btnUndo
        ' 
        btnUndo.Location = New Point(808, 438)
        btnUndo.Name = "btnUndo"
        btnUndo.Size = New Size(75, 23)
        btnUndo.TabIndex = 12
        btnUndo.Text = "Undo"
        btnUndo.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(906, 562)
        Controls.Add(btnUndo)
        Controls.Add(btnRename)
        Controls.Add(btnPreview)
        Controls.Add(TabControl1)
        Controls.Add(lvlPreview)
        Controls.Add(lvlOri)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtExt)
        Controls.Add(Label2)
        Controls.Add(btnPath)
        Controls.Add(txtPath)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Mass Renamer"
        TabControl1.ResumeLayout(False)
        tpFileName.ResumeLayout(False)
        tpFileName.PerformLayout()
        tpExtension.ResumeLayout(False)
        tpExtension.PerformLayout()
        tpAutonumber.ResumeLayout(False)
        gbWith.ResumeLayout(False)
        gbWith.PerformLayout()
        CType(nudIncrementBy, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStartWithNumber, ComponentModel.ISupportInitialize).EndInit()
        gbPlace.ResumeLayout(False)
        gbPlace.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lvlOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvlPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpFileName As TabPage
    Friend WithEvents tpExtension As TabPage
    Friend WithEvents tpAutonumber As TabPage
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ImageList1 As ImageList

End Class
