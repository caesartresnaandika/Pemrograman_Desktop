<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        AturProfileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LangananToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BaToolStripMenuItem = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI", 10F)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 27)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AturProfileToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(61, 23)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' AturProfileToolStripMenuItem
        ' 
        AturProfileToolStripMenuItem.Name = "AturProfileToolStripMenuItem"
        AturProfileToolStripMenuItem.Size = New Size(180, 24)
        AturProfileToolStripMenuItem.Text = "Atur Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(180, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LangananToolStripMenuItem, LaporanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(61, 23)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LangananToolStripMenuItem
        ' 
        LangananToolStripMenuItem.Name = "LangananToolStripMenuItem"
        LangananToolStripMenuItem.Size = New Size(138, 24)
        LangananToolStripMenuItem.Text = "Langanan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(138, 24)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' BantuanToolStripMenuItem
        ' 
        BantuanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BaToolStripMenuItem, TentangToolStripMenuItem})
        BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        BantuanToolStripMenuItem.Size = New Size(72, 23)
        BantuanToolStripMenuItem.Text = "Bantuan"
        ' 
        ' BaToolStripMenuItem
        ' 
        BaToolStripMenuItem.Name = "BaToolStripMenuItem"
        BaToolStripMenuItem.Size = New Size(129, 24)
        BaToolStripMenuItem.Text = "Bantuan"
        ' 
        ' TentangToolStripMenuItem
        ' 
        TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        TentangToolStripMenuItem.Size = New Size(129, 24)
        TentangToolStripMenuItem.Text = "Tentang"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 60F)
        TextBox1.Location = New Point(27, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(742, 114)
        TextBox1.TabIndex = 1
        TextBox1.Text = "D 1145 SC"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(27, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nomor Plat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(27, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 3
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(27, 268)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 4
        Label3.Text = "Biaya Parkir"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(509, 191)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(260, 222)
        DataGridView1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(509, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(208, 20)
        Label4.TabIndex = 6
        Label4.Text = "Kendaraan yang sedang Parkir"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.Location = New Point(117, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(338, 27)
        TextBox2.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(117, 198)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(170, 28)
        ComboBox1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.Location = New Point(284, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 30)
        Button1.TabIndex = 9
        Button1.Text = "Masuk"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Segoe UI", 11F)
        Button2.Location = New Point(380, 232)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 30)
        Button2.TabIndex = 10
        Button2.Text = "Keluar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 30F)
        TextBox3.Location = New Point(117, 268)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(338, 61)
        TextBox3.TabIndex = 11
        TextBox3.Text = "Rp.70.000"
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(27, 343)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 21)
        Label5.TabIndex = 12
        Label5.Text = "Informasi"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(26, 370)
        Label6.Name = "Label6"
        Label6.Size = New Size(151, 21)
        Label6.TabIndex = 13
        Label6.Text = "Tanggal 12-12-2045"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(207, 370)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 21)
        Label7.TabIndex = 14
        Label7.Text = "Jam 00:00:00"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 12F)
        RadioButton1.Location = New Point(27, 405)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(71, 25)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Motor"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Segoe UI", 12F)
        RadioButton2.Location = New Point(104, 405)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(68, 25)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "Mobil"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Segoe UI", 12F)
        RadioButton3.Location = New Point(178, 405)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(61, 25)
        RadioButton3.TabIndex = 17
        RadioButton3.TabStop = True
        RadioButton3.Text = "Taksi"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Segoe UI", 12F)
        RadioButton4.Location = New Point(245, 405)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(79, 25)
        RadioButton4.TabIndex = 18
        RadioButton4.TabStop = True
        RadioButton4.Text = "Sepeda"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Segoe UI", 12F)
        RadioButton5.Location = New Point(330, 405)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(96, 25)
        RadioButton5.TabIndex = 19
        RadioButton5.TabStop = True
        RadioButton5.Text = "Bus/Truck"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormUtama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LangananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
End Class
