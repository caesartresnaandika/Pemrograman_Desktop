<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KonversiSuhu
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
        txtCelcius = New TextBox()
        lblCelcius = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtRMR = New TextBox()
        txtKLV = New TextBox()
        txtFH = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' txtCelcius
        ' 
        txtCelcius.Location = New Point(116, 26)
        txtCelcius.Name = "txtCelcius"
        txtCelcius.Size = New Size(100, 23)
        txtCelcius.TabIndex = 0
        ' 
        ' lblCelcius
        ' 
        lblCelcius.AutoSize = True
        lblCelcius.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCelcius.Location = New Point(12, 24)
        lblCelcius.Name = "lblCelcius"
        lblCelcius.Size = New Size(63, 21)
        lblCelcius.TabIndex = 1
        lblCelcius.Text = "Celcius "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 21)
        Label1.TabIndex = 2
        Label1.Text = "Fahrenheit"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 21)
        Label2.TabIndex = 3
        Label2.Text = "Kelvin"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 21)
        Label3.TabIndex = 4
        Label3.Text = "Reamur"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(234, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 21)
        Label4.TabIndex = 5
        ' 
        ' txtRMR
        ' 
        txtRMR.Location = New Point(116, 146)
        txtRMR.Name = "txtRMR"
        txtRMR.ReadOnly = True
        txtRMR.Size = New Size(100, 23)
        txtRMR.TabIndex = 6
        ' 
        ' txtKLV
        ' 
        txtKLV.Location = New Point(116, 107)
        txtKLV.Name = "txtKLV"
        txtKLV.ReadOnly = True
        txtKLV.Size = New Size(100, 23)
        txtKLV.TabIndex = 7
        ' 
        ' txtFH
        ' 
        txtFH.Location = New Point(116, 67)
        txtFH.Name = "txtFH"
        txtFH.ReadOnly = True
        txtFH.Size = New Size(100, 23)
        txtFH.TabIndex = 8
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(260, 26)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 9
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(357, 26)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 10
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' KonversiSuhu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(531, 211)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtFH)
        Controls.Add(txtKLV)
        Controls.Add(txtRMR)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblCelcius)
        Controls.Add(txtCelcius)
        Name = "KonversiSuhu"
        Text = "Konversi Suhu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents lblCelcius As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRMR As TextBox
    Friend WithEvents txtKLV As TextBox
    Friend WithEvents txtFH As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button

End Class
