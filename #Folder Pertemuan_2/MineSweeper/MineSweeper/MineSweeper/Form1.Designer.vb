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
        lblBaris = New Label()
        Label2 = New Label()
        Label3 = New Label()
        nudBaris = New NumericUpDown()
        nudKolom = New NumericUpDown()
        nudBom = New NumericUpDown()
        btnBuat = New Button()
        Panel1 = New Panel()
        CType(nudBaris, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudKolom, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudBom, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBaris
        ' 
        lblBaris.AutoSize = True
        lblBaris.Location = New Point(12, 21)
        lblBaris.Name = "lblBaris"
        lblBaris.Size = New Size(32, 15)
        lblBaris.TabIndex = 0
        lblBaris.Text = "Baris"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Kolom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(198, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Bomb"
        ' 
        ' nudBaris
        ' 
        nudBaris.Location = New Point(61, 19)
        nudBaris.Name = "nudBaris"
        nudBaris.Size = New Size(120, 23)
        nudBaris.TabIndex = 3
        ' 
        ' nudKolom
        ' 
        nudKolom.Location = New Point(60, 51)
        nudKolom.Name = "nudKolom"
        nudKolom.Size = New Size(120, 23)
        nudKolom.TabIndex = 4
        ' 
        ' nudBom
        ' 
        nudBom.Location = New Point(284, 19)
        nudBom.Name = "nudBom"
        nudBom.Size = New Size(120, 23)
        nudBom.TabIndex = 5
        ' 
        ' btnBuat
        ' 
        btnBuat.Location = New Point(284, 51)
        btnBuat.Name = "btnBuat"
        btnBuat.Size = New Size(75, 23)
        btnBuat.TabIndex = 6
        btnBuat.Text = "Buat"
        btnBuat.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(12, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(456, 332)
        Panel1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 424)
        Controls.Add(Panel1)
        Controls.Add(btnBuat)
        Controls.Add(nudBom)
        Controls.Add(nudKolom)
        Controls.Add(nudBaris)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblBaris)
        Name = "Form1"
        Text = "Form1"
        CType(nudBaris, ComponentModel.ISupportInitialize).EndInit()
        CType(nudKolom, ComponentModel.ISupportInitialize).EndInit()
        CType(nudBom, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBaris As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nudBaris As NumericUpDown
    Friend WithEvents nudKolom As NumericUpDown
    Friend WithEvents nudBom As NumericUpDown
    Friend WithEvents btnBuat As Button
    Friend WithEvents Panel1 As Panel

End Class
