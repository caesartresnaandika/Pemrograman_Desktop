<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
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
        CheckBox1 = New CheckBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label3 = New Label()
        txtRetype = New TextBox()
        btnSave = New Button()
        Label4 = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(112, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(81, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 21)
        Label2.TabIndex = 1
        Label2.Text = "Password Baru"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(199, 184)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.Location = New Point(199, 85)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(181, 27)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.Location = New Point(199, 118)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(181, 27)
        txtPassword.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(120, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 21)
        Label3.TabIndex = 5
        Label3.Text = "Ketik lagi"
        ' 
        ' txtRetype
        ' 
        txtRetype.Font = New Font("Segoe UI", 11F)
        txtRetype.Location = New Point(199, 151)
        txtRetype.Name = "txtRetype"
        txtRetype.PasswordChar = "*"c
        txtRetype.Size = New Size(181, 27)
        txtRetype.TabIndex = 6
        ' 
        ' btnSave
        ' 
        btnSave.AutoSize = True
        btnSave.Font = New Font("Segoe UI", 11F)
        btnSave.Location = New Point(199, 209)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 30)
        btnSave.TabIndex = 7
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 8
        Label4.Text = "Profile"
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Font = New Font("Segoe UI", 11F)
        btnClose.Location = New Point(305, 209)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 30)
        btnClose.TabIndex = 9
        btnClose.Text = "Simpan"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' ProfileForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 311)
        Controls.Add(btnClose)
        Controls.Add(Label4)
        Controls.Add(btnSave)
        Controls.Add(txtRetype)
        Controls.Add(Label3)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(CheckBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ProfileForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProfileForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
End Class
