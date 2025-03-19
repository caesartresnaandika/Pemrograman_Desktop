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
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        SistemToolStripMenuItem = New ToolStripMenuItem()
        ProfilToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        AdminToolStripMenuItem = New ToolStripMenuItem()
        LanggananKendaraanToolStripMenuItem = New ToolStripMenuItem()
        BantuanToolStripMenuItem = New ToolStripMenuItem()
        BaToolStripMenuItem = New ToolStripMenuItem()
        TentangToolStripMenuItem = New ToolStripMenuItem()
        lblPlat = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        ColNoPlat = New DataGridViewTextBoxColumn()
        ColMasuk = New DataGridViewTextBoxColumn()
        ColKeluar = New DataGridViewTextBoxColumn()
        ColHarga = New DataGridViewTextBoxColumn()
        ColJenis = New DataGridViewTextBoxColumn()
        id = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        txtPlat = New TextBox()
        lblInfoUser = New Label()
        lblTgl = New Label()
        DeleteToolStripMenuItem = New ContextMenuStrip(components)
        Delete = New ToolStripMenuItem()
        lblJenis = New TextBox()
        lblJmlKendaraan = New Label()
        Label5 = New Label()
        Label6 = New Label()
        lblHarga = New TextBox()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        DeleteToolStripMenuItem.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Segoe UI", 10F)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SistemToolStripMenuItem, AdminToolStripMenuItem, BantuanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(895, 27)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SistemToolStripMenuItem
        ' 
        SistemToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProfilToolStripMenuItem, LogoutToolStripMenuItem})
        SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        SistemToolStripMenuItem.Size = New Size(61, 23)
        SistemToolStripMenuItem.Text = "Sistem"
        ' 
        ' ProfilToolStripMenuItem
        ' 
        ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem"
        ProfilToolStripMenuItem.Size = New Size(122, 24)
        ProfilToolStripMenuItem.Text = "Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(122, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' AdminToolStripMenuItem
        ' 
        AdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LanggananKendaraanToolStripMenuItem})
        AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        AdminToolStripMenuItem.Size = New Size(61, 23)
        AdminToolStripMenuItem.Text = "Admin"
        ' 
        ' LanggananKendaraanToolStripMenuItem
        ' 
        LanggananKendaraanToolStripMenuItem.Name = "LanggananKendaraanToolStripMenuItem"
        LanggananKendaraanToolStripMenuItem.Size = New Size(207, 24)
        LanggananKendaraanToolStripMenuItem.Text = "Langanan Kendaraan"
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
        ' lblPlat
        ' 
        lblPlat.Font = New Font("Segoe UI", 60F)
        lblPlat.Location = New Point(27, 30)
        lblPlat.Name = "lblPlat"
        lblPlat.ReadOnly = True
        lblPlat.Size = New Size(852, 114)
        lblPlat.TabIndex = 1
        lblPlat.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(16, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 2
        Label1.Text = "Input No Plat"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(72, 275)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 3
        Label2.Text = "Jenis"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(27, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 20)
        Label3.TabIndex = 4
        Label3.Text = "Biaya Parkir"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ColNoPlat, ColMasuk, ColKeluar, ColHarga, ColJenis, id})
        DataGridView1.Location = New Point(330, 170)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(549, 268)
        DataGridView1.TabIndex = 5
        ' 
        ' ColNoPlat
        ' 
        ColNoPlat.HeaderText = "No Plat"
        ColNoPlat.Name = "ColNoPlat"
        ColNoPlat.ReadOnly = True
        ' 
        ' ColMasuk
        ' 
        ColMasuk.HeaderText = "Masuk"
        ColMasuk.Name = "ColMasuk"
        ColMasuk.ReadOnly = True
        ' 
        ' ColKeluar
        ' 
        ColKeluar.HeaderText = "Keluar"
        ColKeluar.Name = "ColKeluar"
        ColKeluar.ReadOnly = True
        ' 
        ' ColHarga
        ' 
        ColHarga.HeaderText = "Harga"
        ColHarga.Name = "ColHarga"
        ' 
        ' ColJenis
        ' 
        ColJenis.HeaderText = "Jenis"
        ColJenis.Name = "ColJenis"
        ' 
        ' id
        ' 
        id.HeaderText = "id"
        id.Name = "id"
        id.ReadOnly = True
        id.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(330, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(208, 20)
        Label4.TabIndex = 6
        Label4.Text = "Kendaraan yang sedang Parkir"
        ' 
        ' txtPlat
        ' 
        txtPlat.Font = New Font("Segoe UI", 11F)
        txtPlat.Location = New Point(118, 235)
        txtPlat.Name = "txtPlat"
        txtPlat.Size = New Size(206, 27)
        txtPlat.TabIndex = 7
        ' 
        ' lblInfoUser
        ' 
        lblInfoUser.AutoSize = True
        lblInfoUser.Font = New Font("Segoe UI", 11F)
        lblInfoUser.Location = New Point(16, 368)
        lblInfoUser.Name = "lblInfoUser"
        lblInfoUser.Size = New Size(81, 20)
        lblInfoUser.TabIndex = 12
        lblInfoUser.Text = "Informasi -"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Font = New Font("Segoe UI", 12F)
        lblTgl.Location = New Point(16, 388)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(151, 21)
        lblTgl.TabIndex = 13
        lblTgl.Text = "Tanggal 12-12-2045"
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Items.AddRange(New ToolStripItem() {Delete})
        DeleteToolStripMenuItem.Name = "ContextMenuStrip1"
        DeleteToolStripMenuItem.Size = New Size(108, 26)
        ' 
        ' Delete
        ' 
        Delete.Name = "Delete"
        Delete.Size = New Size(107, 22)
        Delete.Text = "Delete"
        ' 
        ' lblJenis
        ' 
        lblJenis.Font = New Font("Segoe UI", 11F)
        lblJenis.Location = New Point(118, 268)
        lblJenis.Name = "lblJenis"
        lblJenis.Size = New Size(206, 27)
        lblJenis.TabIndex = 20
        ' 
        ' lblJmlKendaraan
        ' 
        lblJmlKendaraan.AutoSize = True
        lblJmlKendaraan.Font = New Font("Segoe UI", 10F)
        lblJmlKendaraan.ForeColor = SystemColors.ControlText
        lblJmlKendaraan.Location = New Point(16, 419)
        lblJmlKendaraan.Name = "lblJmlKendaraan"
        lblJmlKendaraan.Size = New Size(291, 19)
        lblJmlKendaraan.TabIndex = 21
        lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Sepeda, 0 Bis/Truk"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(109, 298)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 38)
        Label5.TabIndex = 22
        Label5.Text = "F1 - Motor, F2 - Mobil, F3 - Taksi," & vbCrLf & "F4 - Sepeda, F5 - Bis/Truk"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(12, 341)
        Label6.Name = "Label6"
        Label6.Size = New Size(216, 19)
        Label6.TabIndex = 23
        Label6.Text = "Tekan Enter untuk Masuk / Keluar"
        ' 
        ' lblHarga
        ' 
        lblHarga.Font = New Font("Segoe UI", 30F)
        lblHarga.Location = New Point(118, 168)
        lblHarga.Name = "lblHarga"
        lblHarga.ReadOnly = True
        lblHarga.Size = New Size(206, 61)
        lblHarga.TabIndex = 11
        lblHarga.Text = "Rp."
        lblHarga.TextAlign = HorizontalAlignment.Center
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(895, 450)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblJmlKendaraan)
        Controls.Add(lblJenis)
        Controls.Add(lblTgl)
        Controls.Add(lblInfoUser)
        Controls.Add(lblHarga)
        Controls.Add(txtPlat)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblPlat)
        Controls.Add(MenuStrip1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Parkir System v.1.0"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        DeleteToolStripMenuItem.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananKendaraanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPlat As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents DeleteToolStripMenuItem As ContextMenuStrip
    Friend WithEvents Delete As ToolStripMenuItem
    Friend WithEvents ColNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents lblJenis As TextBox
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents lblHarga As TextBox

End Class
