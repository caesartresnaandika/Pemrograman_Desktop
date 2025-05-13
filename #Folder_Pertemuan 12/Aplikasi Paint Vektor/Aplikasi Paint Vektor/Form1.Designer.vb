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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        SimpanToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        GbTools = New GroupBox()
        ShapeIsian = New Panel()
        ShapeTepi = New Panel()
        NumericUpDown1 = New NumericUpDown()
        Label1 = New Label()
        RbElipsIsi = New RadioButton()
        RbKotakIsi = New RadioButton()
        RbElips = New RadioButton()
        RbKotak = New RadioButton()
        RbGaris = New RadioButton()
        RbBebas = New RadioButton()
        GbWarna = New GroupBox()
        BtnGambarUlang = New Button()
        BtnBersihkan = New Button()
        BtnUndo = New Button()
        Warna5 = New Panel()
        Warna1 = New Panel()
        Warna6 = New Panel()
        Warna2 = New Panel()
        Warna4 = New Panel()
        Warna3 = New Panel()
        GbObjek = New GroupBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        MenuStrip1.SuspendLayout()
        GbTools.SuspendLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GbWarna.SuspendLayout()
        GbObjek.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, SimpanToolStripMenuItem1, ToolStripSeparator1, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(114, 22)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' SimpanToolStripMenuItem1
        ' 
        SimpanToolStripMenuItem1.Name = "SimpanToolStripMenuItem1"
        SimpanToolStripMenuItem1.Size = New Size(114, 22)
        SimpanToolStripMenuItem1.Text = "Simpan"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(111, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(114, 22)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' GbTools
        ' 
        GbTools.Controls.Add(ShapeIsian)
        GbTools.Controls.Add(ShapeTepi)
        GbTools.Controls.Add(NumericUpDown1)
        GbTools.Controls.Add(Label1)
        GbTools.Controls.Add(RbElipsIsi)
        GbTools.Controls.Add(RbKotakIsi)
        GbTools.Controls.Add(RbElips)
        GbTools.Controls.Add(RbKotak)
        GbTools.Controls.Add(RbGaris)
        GbTools.Controls.Add(RbBebas)
        GbTools.Dock = DockStyle.Left
        GbTools.Font = New Font("Segoe UI", 10F)
        GbTools.Location = New Point(0, 24)
        GbTools.Name = "GbTools"
        GbTools.Size = New Size(136, 426)
        GbTools.TabIndex = 1
        GbTools.TabStop = False
        GbTools.Text = "Tools"
        ' 
        ' ShapeIsian
        ' 
        ShapeIsian.BackColor = Color.White
        ShapeIsian.Location = New Point(70, 322)
        ShapeIsian.Name = "ShapeIsian"
        ShapeIsian.Size = New Size(40, 40)
        ShapeIsian.TabIndex = 9
        ' 
        ' ShapeTepi
        ' 
        ShapeTepi.BackColor = SystemColors.ActiveCaptionText
        ShapeTepi.Location = New Point(24, 322)
        ShapeTepi.Name = "ShapeTepi"
        ShapeTepi.Size = New Size(40, 40)
        ShapeTepi.TabIndex = 8
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(22, 257)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(79, 25)
        NumericUpDown1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 19)
        Label1.TabIndex = 6
        Label1.Text = "Ukuran Garis Tepi"
        ' 
        ' RbElipsIsi
        ' 
        RbElipsIsi.AutoSize = True
        RbElipsIsi.Location = New Point(12, 178)
        RbElipsIsi.Name = "RbElipsIsi"
        RbElipsIsi.Size = New Size(71, 23)
        RbElipsIsi.TabIndex = 5
        RbElipsIsi.TabStop = True
        RbElipsIsi.Text = "Elips Isi"
        RbElipsIsi.UseVisualStyleBackColor = True
        ' 
        ' RbKotakIsi
        ' 
        RbKotakIsi.AutoSize = True
        RbKotakIsi.Location = New Point(12, 149)
        RbKotakIsi.Name = "RbKotakIsi"
        RbKotakIsi.Size = New Size(79, 23)
        RbKotakIsi.TabIndex = 4
        RbKotakIsi.TabStop = True
        RbKotakIsi.Text = "Kotak Isi"
        RbKotakIsi.UseVisualStyleBackColor = True
        ' 
        ' RbElips
        ' 
        RbElips.AutoSize = True
        RbElips.Location = New Point(12, 120)
        RbElips.Name = "RbElips"
        RbElips.Size = New Size(54, 23)
        RbElips.TabIndex = 3
        RbElips.TabStop = True
        RbElips.Text = "Elips"
        RbElips.UseVisualStyleBackColor = True
        ' 
        ' RbKotak
        ' 
        RbKotak.AutoSize = True
        RbKotak.Location = New Point(12, 91)
        RbKotak.Name = "RbKotak"
        RbKotak.Size = New Size(62, 23)
        RbKotak.TabIndex = 2
        RbKotak.TabStop = True
        RbKotak.Text = "Kotak"
        RbKotak.UseVisualStyleBackColor = True
        ' 
        ' RbGaris
        ' 
        RbGaris.AutoSize = True
        RbGaris.Location = New Point(12, 62)
        RbGaris.Name = "RbGaris"
        RbGaris.Size = New Size(58, 23)
        RbGaris.TabIndex = 1
        RbGaris.TabStop = True
        RbGaris.Text = "Garis"
        RbGaris.UseVisualStyleBackColor = True
        ' 
        ' RbBebas
        ' 
        RbBebas.AutoSize = True
        RbBebas.Location = New Point(12, 33)
        RbBebas.Name = "RbBebas"
        RbBebas.Size = New Size(63, 23)
        RbBebas.TabIndex = 0
        RbBebas.TabStop = True
        RbBebas.Text = "Bebas"
        RbBebas.UseVisualStyleBackColor = True
        ' 
        ' GbWarna
        ' 
        GbWarna.Controls.Add(BtnGambarUlang)
        GbWarna.Controls.Add(BtnBersihkan)
        GbWarna.Controls.Add(BtnUndo)
        GbWarna.Controls.Add(Warna5)
        GbWarna.Controls.Add(Warna1)
        GbWarna.Controls.Add(Warna6)
        GbWarna.Controls.Add(Warna2)
        GbWarna.Controls.Add(Warna4)
        GbWarna.Controls.Add(Warna3)
        GbWarna.Dock = DockStyle.Bottom
        GbWarna.Font = New Font("Segoe UI", 10F)
        GbWarna.Location = New Point(136, 401)
        GbWarna.Name = "GbWarna"
        GbWarna.Size = New Size(664, 49)
        GbWarna.TabIndex = 2
        GbWarna.TabStop = False
        GbWarna.Text = "Warna"
        ' 
        ' BtnGambarUlang
        ' 
        BtnGambarUlang.AutoSize = True
        BtnGambarUlang.Font = New Font("Segoe UI", 9F)
        BtnGambarUlang.Location = New Point(543, 14)
        BtnGambarUlang.Name = "BtnGambarUlang"
        BtnGambarUlang.Size = New Size(109, 29)
        BtnGambarUlang.TabIndex = 17
        BtnGambarUlang.Text = "Gambar Ulang"
        BtnGambarUlang.UseVisualStyleBackColor = True
        ' 
        ' BtnBersihkan
        ' 
        BtnBersihkan.AutoSize = True
        BtnBersihkan.Font = New Font("Segoe UI", 9F)
        BtnBersihkan.Location = New Point(386, 14)
        BtnBersihkan.Name = "BtnBersihkan"
        BtnBersihkan.Size = New Size(109, 29)
        BtnBersihkan.TabIndex = 16
        BtnBersihkan.Text = "Bersihkan Canvas"
        BtnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' BtnUndo
        ' 
        BtnUndo.AutoSize = True
        BtnUndo.Font = New Font("Segoe UI", 9F)
        BtnUndo.Location = New Point(305, 14)
        BtnUndo.Name = "BtnUndo"
        BtnUndo.Size = New Size(75, 29)
        BtnUndo.TabIndex = 15
        BtnUndo.Text = "Undo"
        BtnUndo.UseVisualStyleBackColor = True
        ' 
        ' Warna5
        ' 
        Warna5.BackColor = Color.Black
        Warna5.Location = New Point(145, 23)
        Warna5.Name = "Warna5"
        Warna5.Size = New Size(20, 20)
        Warna5.TabIndex = 14
        ' 
        ' Warna1
        ' 
        Warna1.BackColor = Color.Red
        Warna1.Location = New Point(15, 23)
        Warna1.Name = "Warna1"
        Warna1.Size = New Size(20, 20)
        Warna1.TabIndex = 9
        ' 
        ' Warna6
        ' 
        Warna6.BackColor = Color.White
        Warna6.Location = New Point(119, 23)
        Warna6.Name = "Warna6"
        Warna6.Size = New Size(20, 20)
        Warna6.TabIndex = 13
        ' 
        ' Warna2
        ' 
        Warna2.BackColor = Color.Yellow
        Warna2.Location = New Point(41, 23)
        Warna2.Name = "Warna2"
        Warna2.Size = New Size(20, 20)
        Warna2.TabIndex = 10
        ' 
        ' Warna4
        ' 
        Warna4.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Warna4.Location = New Point(93, 23)
        Warna4.Name = "Warna4"
        Warna4.Size = New Size(20, 20)
        Warna4.TabIndex = 12
        ' 
        ' Warna3
        ' 
        Warna3.BackColor = Color.Green
        Warna3.Location = New Point(67, 23)
        Warna3.Name = "Warna3"
        Warna3.Size = New Size(20, 20)
        Warna3.TabIndex = 11
        ' 
        ' GbObjek
        ' 
        GbObjek.Controls.Add(TextBox1)
        GbObjek.Dock = DockStyle.Right
        GbObjek.Location = New Point(631, 24)
        GbObjek.Name = "GbObjek"
        GbObjek.Size = New Size(169, 377)
        GbObjek.TabIndex = 3
        GbObjek.TabStop = False
        GbObjek.Text = "Objek"
        ' 
        ' TextBox1
        ' 
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Location = New Point(3, 19)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(163, 355)
        TextBox1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(136, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(495, 377)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(GbObjek)
        Controls.Add(GbWarna)
        Controls.Add(GbTools)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        GbTools.ResumeLayout(False)
        GbTools.PerformLayout()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GbWarna.ResumeLayout(False)
        GbWarna.PerformLayout()
        GbObjek.ResumeLayout(False)
        GbObjek.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GbTools As GroupBox
    Friend WithEvents RbBebas As RadioButton
    Friend WithEvents RbGaris As RadioButton
    Friend WithEvents RbKotak As RadioButton
    Friend WithEvents RbElips As RadioButton
    Friend WithEvents RbKotakIsi As RadioButton
    Friend WithEvents RbElipsIsi As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ShapeIsian As Panel
    Friend WithEvents ShapeTepi As Panel
    Friend WithEvents GbWarna As GroupBox
    Friend WithEvents Warna1 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents GbObjek As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnUndo As Button
    Friend WithEvents BtnBersihkan As Button
    Friend WithEvents BtnGambarUlang As Button
    Friend WithEvents TextBox1 As TextBox

End Class
