<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendapatanForm
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
        Label2 = New Label()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        NoPlat = New DataGridViewTextBoxColumn()
        Namapemilik = New DataGridViewTextBoxColumn()
        Biaya = New DataGridViewTextBoxColumn()
        Jenis = New DataGridViewTextBoxColumn()
        Expired = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        Label4 = New Label()
        lblId = New Label()
        txtNoPlat = New TextBox()
        txtNama = New TextBox()
        txtBiaya = New TextBox()
        cmbJenis = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        Label5 = New Label()
        btnTambah = New Button()
        btnEdit = New Button()
        btnCancel = New Button()
        btnHapus = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(47, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 4
        Label2.Text = "No plat :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(57, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 5
        Label1.Text = "Nama :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.Control
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {id, NoPlat, Namapemilik, Biaya, Jenis, Expired})
        DataGridView1.GridColor = SystemColors.Control
        DataGridView1.Location = New Point(12, 167)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 271)
        DataGridView1.TabIndex = 9
        ' 
        ' id
        ' 
        id.HeaderText = "id"
        id.Name = "id"
        ' 
        ' NoPlat
        ' 
        NoPlat.HeaderText = "No Plat"
        NoPlat.Name = "NoPlat"
        ' 
        ' Namapemilik
        ' 
        Namapemilik.HeaderText = "Nama Pemilik"
        Namapemilik.Name = "Namapemilik"
        ' 
        ' Biaya
        ' 
        Biaya.HeaderText = "Biaya"
        Biaya.Name = "Biaya"
        ' 
        ' Jenis
        ' 
        Jenis.HeaderText = "Jenis"
        Jenis.Name = "Jenis"
        ' 
        ' Expired
        ' 
        Expired.HeaderText = "Expired"
        Expired.Name = "Expired"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(61, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 10
        Label3.Text = "Biaya :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(47, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 11
        Label4.Text = "Expired :"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 11F)
        lblId.Location = New Point(382, 23)
        lblId.Name = "lblId"
        lblId.Size = New Size(22, 20)
        lblId.TabIndex = 12
        lblId.Text = "id"
        lblId.Visible = False
        ' 
        ' txtNoPlat
        ' 
        txtNoPlat.Location = New Point(119, 20)
        txtNoPlat.Name = "txtNoPlat"
        txtNoPlat.Size = New Size(225, 23)
        txtNoPlat.TabIndex = 13
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(119, 49)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(285, 23)
        txtNama.TabIndex = 14
        ' 
        ' txtBiaya
        ' 
        txtBiaya.Location = New Point(119, 78)
        txtBiaya.Name = "txtBiaya"
        txtBiaya.Size = New Size(225, 23)
        txtBiaya.TabIndex = 15
        ' 
        ' cmbJenis
        ' 
        cmbJenis.FormattingEnabled = True
        cmbJenis.Items.AddRange(New Object() {"Motor", "Mobil", "Taxi/Umum", "Truk", "Sepeda"})
        cmbJenis.Location = New Point(410, 78)
        cmbJenis.Name = "cmbJenis"
        cmbJenis.Size = New Size(121, 23)
        cmbJenis.TabIndex = 16
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(119, 107)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(357, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(47, 20)
        Label5.TabIndex = 18
        Label5.Text = "Jenis :"
        ' 
        ' btnTambah
        ' 
        btnTambah.AutoSize = True
        btnTambah.Font = New Font("Segoe UI", 10F)
        btnTambah.Location = New Point(470, 131)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 30)
        btnTambah.TabIndex = 19
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.AutoSize = True
        btnEdit.Font = New Font("Segoe UI", 10F)
        btnEdit.Location = New Point(551, 131)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 29)
        btnEdit.TabIndex = 20
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.AutoSize = True
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.Location = New Point(713, 131)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(75, 29)
        btnCancel.TabIndex = 22
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.AutoSize = True
        btnHapus.Font = New Font("Segoe UI", 10F)
        btnHapus.Location = New Point(632, 131)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(75, 29)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' PendapatanForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnHapus)
        Controls.Add(btnCancel)
        Controls.Add(btnEdit)
        Controls.Add(btnTambah)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(cmbJenis)
        Controls.Add(txtBiaya)
        Controls.Add(txtNama)
        Controls.Add(txtNoPlat)
        Controls.Add(lblId)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "PendapatanForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PendapatanForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtNoPlat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtBiaya As TextBox
    Friend WithEvents cmbJenis As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents NoPlat As DataGridViewTextBoxColumn
    Friend WithEvents Namapemilik As DataGridViewTextBoxColumn
    Friend WithEvents Biaya As DataGridViewTextBoxColumn
    Friend WithEvents Jenis As DataGridViewTextBoxColumn
    Friend WithEvents Expired As DataGridViewTextBoxColumn
End Class
