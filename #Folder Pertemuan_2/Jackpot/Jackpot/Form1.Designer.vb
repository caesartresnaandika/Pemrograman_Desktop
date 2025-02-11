<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jackpot
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
        components = New ComponentModel.Container()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lblStatus = New Label()
        Button1 = New Button()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Timer3 = New Timer(components)
        Timer4 = New Timer(components)
        SuspendLayout()
        ' 
        ' lbl1
        ' 
        lbl1.BorderStyle = BorderStyle.Fixed3D
        lbl1.Font = New Font("Segoe UI", 24F)
        lbl1.Location = New Point(29, 25)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(100, 117)
        lbl1.TabIndex = 0
        lbl1.Text = "A"
        lbl1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl2
        ' 
        lbl2.BorderStyle = BorderStyle.Fixed3D
        lbl2.Font = New Font("Segoe UI", 24F)
        lbl2.Location = New Point(135, 25)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(100, 117)
        lbl2.TabIndex = 1
        lbl2.Text = "A"
        lbl2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl3
        ' 
        lbl3.BorderStyle = BorderStyle.Fixed3D
        lbl3.Font = New Font("Segoe UI", 24F)
        lbl3.Location = New Point(241, 25)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(100, 117)
        lbl3.TabIndex = 2
        lbl3.Text = "A"
        lbl3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 12F)
        lblStatus.Location = New Point(21, 184)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(59, 21)
        lblStatus.TabIndex = 3
        lblStatus.Text = "Status :"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(266, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 39)
        Button1.TabIndex = 4
        Button1.Text = "Spin"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 10
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 9
        ' 
        ' Timer3
        ' 
        Timer3.Interval = 11
        ' 
        ' Timer4
        ' 
        Timer4.Interval = 1000
        ' 
        ' Jackpot
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(364, 254)
        Controls.Add(Button1)
        Controls.Add(lblStatus)
        Controls.Add(lbl3)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Name = "Jackpot"
        Text = "Jackpot"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer

End Class
