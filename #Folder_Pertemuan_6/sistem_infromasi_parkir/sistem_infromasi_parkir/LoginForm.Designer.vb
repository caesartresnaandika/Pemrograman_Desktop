﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Label1 = New Label()
        Label2 = New Label()
        txtEnterUsername = New TextBox()
        txtEnterPassword = New TextBox()
        Button1 = New Button()
        cbShowPassword = New CheckBox()
        Button2 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(110, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(115, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtEnterUsername
        ' 
        txtEnterUsername.Font = New Font("Segoe UI", 12F)
        txtEnterUsername.Location = New Point(197, 92)
        txtEnterUsername.Name = "txtEnterUsername"
        txtEnterUsername.PlaceholderText = "Enter your username"
        txtEnterUsername.Size = New Size(181, 29)
        txtEnterUsername.TabIndex = 2
        ' 
        ' txtEnterPassword
        ' 
        txtEnterPassword.Font = New Font("Segoe UI", 12F)
        txtEnterPassword.Location = New Point(197, 139)
        txtEnterPassword.Name = "txtEnterPassword"
        txtEnterPassword.PlaceholderText = "Enter your Password"
        txtEnterPassword.Size = New Size(181, 29)
        txtEnterPassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Segoe UI", 11F)
        Button1.Location = New Point(197, 208)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 31)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cbShowPassword
        ' 
        cbShowPassword.AutoSize = True
        cbShowPassword.Location = New Point(197, 174)
        cbShowPassword.Name = "cbShowPassword"
        cbShowPassword.Size = New Size(108, 19)
        cbShowPassword.TabIndex = 5
        cbShowPassword.Text = "Show Password"
        cbShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.Font = New Font("Segoe UI", 11F)
        Button2.Location = New Point(303, 208)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 31)
        Button2.TabIndex = 6
        Button2.Text = "Logout"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(115, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(246, 25)
        Label3.TabIndex = 7
        Label3.Text = "Selamat Datang di SIPARKIR"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(534, 311)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(cbShowPassword)
        Controls.Add(Button1)
        Controls.Add(txtEnterPassword)
        Controls.Add(txtEnterUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEnterUsername As TextBox
    Friend WithEvents txtEnterPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cbShowPassword As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label

End Class
