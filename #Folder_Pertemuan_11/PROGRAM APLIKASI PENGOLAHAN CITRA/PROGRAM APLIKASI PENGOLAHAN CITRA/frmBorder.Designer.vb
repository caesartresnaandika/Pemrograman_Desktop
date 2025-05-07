<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorder
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
        cbWarnaBorder = New ComboBox()
        cbKetebalanBorder = New ComboBox()
        btnBatal = New Button()
        btnOk = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(74, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 0
        Label1.Text = "Warna Border"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(49, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ketebalan Border"
        ' 
        ' cbWarnaBorder
        ' 
        cbWarnaBorder.FormattingEnabled = True
        cbWarnaBorder.Location = New Point(260, 52)
        cbWarnaBorder.Name = "cbWarnaBorder"
        cbWarnaBorder.Size = New Size(121, 23)
        cbWarnaBorder.TabIndex = 2
        ' 
        ' cbKetebalanBorder
        ' 
        cbKetebalanBorder.FormattingEnabled = True
        cbKetebalanBorder.Location = New Point(260, 113)
        cbKetebalanBorder.Name = "cbKetebalanBorder"
        cbKetebalanBorder.Size = New Size(121, 23)
        cbKetebalanBorder.TabIndex = 3
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(99, 188)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(75, 23)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(306, 188)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(75, 23)
        btnOk.TabIndex = 5
        btnOk.Text = "Simpan"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' frmBorder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(494, 261)
        Controls.Add(btnOk)
        Controls.Add(btnBatal)
        Controls.Add(cbKetebalanBorder)
        Controls.Add(cbWarnaBorder)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmBorder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmBorder"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbWarnaBorder As ComboBox
    Friend WithEvents cbKetebalanBorder As ComboBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnOk As Button
End Class
