<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        Button1 = New Button()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(55, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(688, 375)
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
        Label1.Location = New Point(366, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 37)
        Label1.TabIndex = 3
        Label1.Text = "MENU"
        ' 
        ' Label3
        ' 
        Label3.AllowDrop = True
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(77, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 28)
        Label3.TabIndex = 5
        Label3.Text = "Menu Favorit"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(77, 101)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(180, 180)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(284, 101)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(180, 180)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(494, 101)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(180, 180)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(579, 67)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 23)
        Button1.TabIndex = 9
        Button1.Text = "Lihat Menu Lainnya - >"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(537, 284)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 20)
        Label2.TabIndex = 10
        Label2.Text = "Chateaubriand"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(110, 284)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 11
        Label4.Text = "Beef Wellington"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F)
        Label5.Location = New Point(314, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 20)
        Label5.TabIndex = 12
        Label5.Text = "Lobster Thermidor"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 11F)
        TextBox1.Location = New Point(152, 307)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "0"
        TextBox1.Size = New Size(30, 27)
        TextBox1.TabIndex = 13
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 11F)
        TextBox2.Location = New Point(366, 307)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "0"
        TextBox2.Size = New Size(30, 27)
        TextBox2.TabIndex = 14
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 11F)
        TextBox3.Location = New Point(579, 307)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "0"
        TextBox3.Size = New Size(30, 27)
        TextBox3.TabIndex = 15
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 11F)
        TextBox4.Location = New Point(402, 307)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "0"
        TextBox4.Size = New Size(30, 27)
        TextBox4.TabIndex = 16
        TextBox4.Text = "+"
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 11F)
        TextBox5.Location = New Point(543, 307)
        TextBox5.Name = "TextBox5"
        TextBox5.PlaceholderText = "0"
        TextBox5.Size = New Size(30, 27)
        TextBox5.TabIndex = 17
        TextBox5.Text = "-"
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(791, 349)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 18
        Label6.Text = "Label6"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 11F)
        TextBox6.Location = New Point(330, 307)
        TextBox6.Name = "TextBox6"
        TextBox6.PlaceholderText = "0"
        TextBox6.Size = New Size(30, 27)
        TextBox6.TabIndex = 19
        TextBox6.Text = "-"
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 11F)
        TextBox7.Location = New Point(116, 307)
        TextBox7.Name = "TextBox7"
        TextBox7.PlaceholderText = "0"
        TextBox7.Size = New Size(30, 27)
        TextBox7.TabIndex = 20
        TextBox7.Text = "-"
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 11F)
        TextBox8.Location = New Point(615, 307)
        TextBox8.Name = "TextBox8"
        TextBox8.PlaceholderText = "0"
        TextBox8.Size = New Size(30, 27)
        TextBox8.TabIndex = 21
        TextBox8.Text = "+"
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 11F)
        TextBox9.Location = New Point(188, 307)
        TextBox9.Name = "TextBox9"
        TextBox9.PlaceholderText = "0"
        TextBox9.Size = New Size(30, 27)
        TextBox9.TabIndex = 22
        TextBox9.Text = "+"
        TextBox9.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 11F)
        Button2.Location = New Point(632, 379)
        Button2.Name = "Button2"
        Button2.Size = New Size(95, 30)
        Button2.TabIndex = 23
        Button2.Text = "PESAN"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Button2 As Button
End Class
