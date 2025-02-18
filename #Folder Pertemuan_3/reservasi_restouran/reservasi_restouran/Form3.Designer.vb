<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label8 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(204, 73)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(413, 333)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(10))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(263, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(290, 37)
        Label1.TabIndex = 2
        Label1.Text = "RESERVASI BERHASIL"
        ' 
        ' Label3
        ' 
        Label3.AllowDrop = True
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(218, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 28)
        Label3.TabIndex = 4
        Label3.Text = "Nama Pemesan"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(218, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 28)
        Label2.TabIndex = 5
        Label2.Text = "Nomor HP"
        ' 
        ' Label4
        ' 
        Label4.AllowDrop = True
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(218, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 28)
        Label4.TabIndex = 8
        Label4.Text = "Jumlah Orang"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 13F)
        TextBox1.Location = New Point(398, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 31)
        TextBox1.TabIndex = 9
        TextBox1.Text = "Tresna Andika"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 13F)
        TextBox2.Location = New Point(398, 160)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 31)
        TextBox2.TabIndex = 10
        TextBox2.Text = "71220834"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 13F)
        TextBox3.Location = New Point(398, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(32, 31)
        TextBox3.TabIndex = 11
        TextBox3.Text = "2"
        ' 
        ' Label5
        ' 
        Label5.AllowDrop = True
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(218, 265)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 28)
        Label5.TabIndex = 12
        Label5.Text = "Nomor Meja*"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 13F)
        TextBox4.Location = New Point(398, 270)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(32, 31)
        TextBox4.TabIndex = 13
        TextBox4.Text = "2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(218, 304)
        Label8.Name = "Label8"
        Label8.Size = New Size(352, 15)
        Label8.TabIndex = 16
        Label8.Text = "*Tunjukan Bukti Pemesanan ke waiter, kami akan memandu anda"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(445, 354)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 23)
        Button1.TabIndex = 17
        Button1.Text = "PESAN MAKANAN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form3"
        Text = "Form3"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
End Class
