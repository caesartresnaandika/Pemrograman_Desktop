<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AllowDrop = True
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(10))
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(341, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 37)
        Label1.TabIndex = 1
        Label1.Text = "RESERVASI"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(237, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 28)
        Label2.TabIndex = 2
        Label2.Text = "Nomor HP"
        ' 
        ' Label3
        ' 
        Label3.AllowDrop = True
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(237, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 28)
        Label3.TabIndex = 3
        Label3.Text = "Nama Pemesan"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(400, 152)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Isi nama anda"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(400, 200)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Isi nomor telepon anda"
        TextBox2.Size = New Size(182, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(507, 300)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "RESERVASI"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AllowDrop = True
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(237, 240)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 28)
        Label4.TabIndex = 7
        Label4.Text = "Jumlah Orang"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(400, 248)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Isi Jumlah Orang"
        TextBox3.Size = New Size(39, 23)
        TextBox3.TabIndex = 8
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(219, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(394, 222)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form2"
        Text = "Restoran Bintang 100"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
