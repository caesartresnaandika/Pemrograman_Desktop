<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LanggananForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        tbNamaLangganan = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        DataGridView1 = New DataGridView()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(51, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 21)
        Label1.TabIndex = 1
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(51, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 2
        Label2.Text = "Nomor Plat"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(51, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 21)
        Label3.TabIndex = 3
        Label3.Text = "Tarif Langganan "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(51, 170)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 21)
        Label4.TabIndex = 4
        Label4.Text = "Berlaku Hingga "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(577, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 21)
        Label5.TabIndex = 5
        Label5.Text = "ID Pelanggan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(449, 100)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 21)
        Label6.TabIndex = 6
        Label6.Text = "Jenis Kendaraan"
        ' 
        ' tbNamaLangganan
        ' 
        tbNamaLangganan.Font = New Font("Segoe UI", 11F)
        tbNamaLangganan.Location = New Point(189, 54)
        tbNamaLangganan.Name = "tbNamaLangganan"
        tbNamaLangganan.Size = New Size(293, 27)
        tbNamaLangganan.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(189, 98)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(243, 27)
        TextBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.Location = New Point(189, 131)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(243, 27)
        TextBox2.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 11F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(574, 98)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(170, 28)
        ComboBox1.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 11F)
        TextBox4.Location = New Point(686, 52)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(58, 27)
        TextBox4.TabIndex = 12
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 11F)
        DateTimePicker1.Location = New Point(189, 170)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 27)
        DateTimePicker1.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.Location = New Point(577, 166)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 30)
        Button1.TabIndex = 14
        Button1.Text = "Edit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Segoe UI", 11F)
        Button2.Location = New Point(483, 167)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 30)
        Button2.TabIndex = 15
        Button2.Text = "Tambah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.Font = New Font("Segoe UI", 11F)
        Button3.Location = New Point(669, 167)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 30)
        Button3.TabIndex = 16
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.AutoSize = True
        Button4.Font = New Font("Segoe UI", 11F)
        Button4.Location = New Point(669, 391)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 30)
        Button4.TabIndex = 17
        Button4.Text = "Tutup"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(51, 242)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(693, 143)
        DataGridView1.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(51, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(254, 21)
        Label7.TabIndex = 19
        Label7.Text = "Kendaraan yang terdaftar langanan"
        ' 
        ' LanggananForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox4)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(tbNamaLangganan)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LanggananForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LanggananForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNamaLangganan As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
End Class
