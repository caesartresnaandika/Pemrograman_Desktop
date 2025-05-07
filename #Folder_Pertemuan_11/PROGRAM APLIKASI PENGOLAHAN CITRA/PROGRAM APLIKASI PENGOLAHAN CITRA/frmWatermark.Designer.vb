<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWatermark
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
        tbWaterMark = New TextBox()
        btnBatal = New Button()
        btnSimpan = New Button()
        Label2 = New Label()
        cbWarnaWatermark = New ComboBox()
        nudFontSize = New NumericUpDown()
        Label3 = New Label()
        nudSpacing = New NumericUpDown()
        Label4 = New Label()
        CType(nudFontSize, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudSpacing, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(36, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 20)
        Label1.TabIndex = 0
        Label1.Text = "Masukkan Watermark"
        ' 
        ' tbWaterMark
        ' 
        tbWaterMark.Font = New Font("Segoe UI", 10F)
        tbWaterMark.Location = New Point(189, 46)
        tbWaterMark.Name = "tbWaterMark"
        tbWaterMark.PlaceholderText = "masukan watermark"
        tbWaterMark.Size = New Size(247, 25)
        tbWaterMark.TabIndex = 1
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(189, 164)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 2
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(361, 164)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(75, 23)
        btnSimpan.TabIndex = 3
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(59, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 20)
        Label2.TabIndex = 4
        Label2.Text = "Warna Watermark"
        ' 
        ' cbWarnaWatermark
        ' 
        cbWarnaWatermark.FormattingEnabled = True
        cbWarnaWatermark.Items.AddRange(New Object() {"Merah", "Kuning", "Hijau", "Biru", "Ungu", "Hitam", "Putih", "Abu-abu"})
        cbWarnaWatermark.Location = New Point(189, 77)
        cbWarnaWatermark.Name = "cbWarnaWatermark"
        cbWarnaWatermark.Size = New Size(247, 23)
        cbWarnaWatermark.TabIndex = 5
        ' 
        ' nudFontSize
        ' 
        nudFontSize.Location = New Point(189, 106)
        nudFontSize.Name = "nudFontSize"
        nudFontSize.Size = New Size(247, 23)
        nudFontSize.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(56, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 20)
        Label3.TabIndex = 7
        Label3.Text = "Ukuran Watermark"
        ' 
        ' nudSpacing
        ' 
        nudSpacing.Location = New Point(189, 135)
        nudSpacing.Name = "nudSpacing"
        nudSpacing.Size = New Size(247, 23)
        nudSpacing.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(69, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 20)
        Label4.TabIndex = 9
        Label4.Text = "Jarak Watermark"
        ' 
        ' frmWatermark
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 231)
        Controls.Add(Label4)
        Controls.Add(nudSpacing)
        Controls.Add(Label3)
        Controls.Add(nudFontSize)
        Controls.Add(cbWarnaWatermark)
        Controls.Add(Label2)
        Controls.Add(btnSimpan)
        Controls.Add(btnBatal)
        Controls.Add(tbWaterMark)
        Controls.Add(Label1)
        Name = "frmWatermark"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmWatermark"
        CType(nudFontSize, ComponentModel.ISupportInitialize).EndInit()
        CType(nudSpacing, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbWaterMark As TextBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbWarnaWatermark As ComboBox
    Friend WithEvents nudFontSize As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudSpacing As NumericUpDown
    Friend WithEvents Label4 As Label
End Class
