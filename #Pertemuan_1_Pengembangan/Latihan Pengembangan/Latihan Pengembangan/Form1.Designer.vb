<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConvertAngka
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
        lblDecimal = New Label()
        lblBinary = New Label()
        lblOctal = New Label()
        lblHexa = New Label()
        txtDecimal = New TextBox()
        txtHexa = New TextBox()
        txtOctal = New TextBox()
        txtBinary = New TextBox()
        btnConvert = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblDecimal
        ' 
        lblDecimal.AutoSize = True
        lblDecimal.Font = New Font("Segoe UI", 12.0F)
        lblDecimal.Location = New Point(26, 24)
        lblDecimal.Name = "lblDecimal"
        lblDecimal.Size = New Size(66, 21)
        lblDecimal.TabIndex = 0
        lblDecimal.Text = "Decimal"
        ' 
        ' lblBinary
        ' 
        lblBinary.AutoSize = True
        lblBinary.Font = New Font("Segoe UI", 12.0F)
        lblBinary.Location = New Point(26, 63)
        lblBinary.Name = "lblBinary"
        lblBinary.Size = New Size(54, 21)
        lblBinary.TabIndex = 1
        lblBinary.Text = "Binary"
        ' 
        ' lblOctal
        ' 
        lblOctal.AutoSize = True
        lblOctal.Font = New Font("Segoe UI", 12.0F)
        lblOctal.Location = New Point(26, 105)
        lblOctal.Name = "lblOctal"
        lblOctal.Size = New Size(46, 21)
        lblOctal.TabIndex = 2
        lblOctal.Text = "Octal"
        ' 
        ' lblHexa
        ' 
        lblHexa.AutoSize = True
        lblHexa.Font = New Font("Segoe UI", 12.0F)
        lblHexa.Location = New Point(26, 147)
        lblHexa.Name = "lblHexa"
        lblHexa.Size = New Size(44, 21)
        lblHexa.TabIndex = 3
        lblHexa.Text = "Hexa"
        ' 
        ' txtDecimal
        ' 
        txtDecimal.Location = New Point(95, 24)
        txtDecimal.Name = "txtDecimal"
        txtDecimal.Size = New Size(100, 23)
        txtDecimal.TabIndex = 4
        ' 
        ' txtHexa
        ' 
        txtHexa.Location = New Point(95, 145)
        txtHexa.Name = "txtHexa"
        txtHexa.ReadOnly = True
        txtHexa.Size = New Size(100, 23)
        txtHexa.TabIndex = 5
        ' 
        ' txtOctal
        ' 
        txtOctal.Location = New Point(95, 105)
        txtOctal.Name = "txtOctal"
        txtOctal.ReadOnly = True
        txtOctal.Size = New Size(100, 23)
        txtOctal.TabIndex = 6
        ' 
        ' txtBinary
        ' 
        txtBinary.Location = New Point(95, 63)
        txtBinary.Name = "txtBinary"
        txtBinary.ReadOnly = True
        txtBinary.Size = New Size(100, 23)
        txtBinary.TabIndex = 7
        ' 
        ' btnConvert
        ' 
        btnConvert.BackColor = SystemColors.InactiveCaption
        btnConvert.Location = New Point(227, 24)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(75, 23)
        btnConvert.TabIndex = 8
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.RosyBrown
        btnKeluar.Location = New Point(324, 24)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 9
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' ConvertAngka
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 202)
        Controls.Add(btnKeluar)
        Controls.Add(btnConvert)
        Controls.Add(txtBinary)
        Controls.Add(txtOctal)
        Controls.Add(txtHexa)
        Controls.Add(txtDecimal)
        Controls.Add(lblHexa)
        Controls.Add(lblOctal)
        Controls.Add(lblBinary)
        Controls.Add(lblDecimal)
        Name = "ConvertAngka"
        Text = "Convert Angka"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblBinary As Label
    Friend WithEvents lblOctal As Label
    Friend WithEvents lblHexa As Label
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents txtHexa As TextBox
    Friend WithEvents txtOctal As TextBox
    Friend WithEvents txtBinary As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnKeluar As Button

End Class
