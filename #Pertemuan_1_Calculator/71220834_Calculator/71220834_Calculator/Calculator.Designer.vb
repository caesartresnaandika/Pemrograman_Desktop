<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Panel1 = New Panel()
        txtInput = New TextBox()
        Panel2 = New Panel()
        cmdEqual = New Button()
        cmdAdd = New Button()
        cmdInverse = New Button()
        cmdSqrt = New Button()
        cmdMultiply = New Button()
        cmdSubstract = New Button()
        cmdPf = New Button()
        cmdDivison = New Button()
        cmdDecimal = New Button()
        cmd0 = New Button()
        cmdSign = New Button()
        cmd3 = New Button()
        cmd2 = New Button()
        cmd1 = New Button()
        cmd6 = New Button()
        cmd5 = New Button()
        cmd4 = New Button()
        cmd9 = New Button()
        cmd7 = New Button()
        cmd8 = New Button()
        cmdC = New Button()
        cmdCE = New Button()
        cmdBackspace = New Button()
        cmdn = New Button()
        cmdn3 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtInput)
        Panel1.Location = New Point(10, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(329, 59)
        Panel1.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtInput.Font = New Font("Segoe UI", 18F)
        txtInput.Location = New Point(32, 12)
        txtInput.Margin = New Padding(0)
        txtInput.Multiline = True
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(266, 36)
        txtInput.TabIndex = 0
        txtInput.Text = "0"
        txtInput.TextAlign = HorizontalAlignment.Right
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(cmdn3)
        Panel2.Controls.Add(cmdn)
        Panel2.Controls.Add(cmdEqual)
        Panel2.Controls.Add(cmdAdd)
        Panel2.Controls.Add(cmdInverse)
        Panel2.Controls.Add(cmdSqrt)
        Panel2.Controls.Add(cmdMultiply)
        Panel2.Controls.Add(cmdSubstract)
        Panel2.Controls.Add(cmdPf)
        Panel2.Controls.Add(cmdDivison)
        Panel2.Controls.Add(cmdDecimal)
        Panel2.Controls.Add(cmd0)
        Panel2.Controls.Add(cmdSign)
        Panel2.Controls.Add(cmd3)
        Panel2.Controls.Add(cmd2)
        Panel2.Controls.Add(cmd1)
        Panel2.Controls.Add(cmd6)
        Panel2.Controls.Add(cmd5)
        Panel2.Controls.Add(cmd4)
        Panel2.Controls.Add(cmd9)
        Panel2.Controls.Add(cmd7)
        Panel2.Controls.Add(cmd8)
        Panel2.Controls.Add(cmdC)
        Panel2.Controls.Add(cmdCE)
        Panel2.Controls.Add(cmdBackspace)
        Panel2.Location = New Point(10, 80)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(329, 250)
        Panel2.TabIndex = 1
        ' 
        ' cmdEqual
        ' 
        cmdEqual.Location = New Point(260, 170)
        cmdEqual.Margin = New Padding(3, 2, 3, 2)
        cmdEqual.Name = "cmdEqual"
        cmdEqual.Size = New Size(46, 35)
        cmdEqual.TabIndex = 28
        cmdEqual.Text = "="
        cmdEqual.UseVisualStyleBackColor = True
        ' 
        ' cmdAdd
        ' 
        cmdAdd.Location = New Point(208, 170)
        cmdAdd.Margin = New Padding(3, 2, 3, 2)
        cmdAdd.Name = "cmdAdd"
        cmdAdd.Size = New Size(46, 35)
        cmdAdd.TabIndex = 27
        cmdAdd.Text = "+"
        cmdAdd.UseVisualStyleBackColor = True
        ' 
        ' cmdInverse
        ' 
        cmdInverse.Location = New Point(260, 129)
        cmdInverse.Margin = New Padding(3, 2, 3, 2)
        cmdInverse.Name = "cmdInverse"
        cmdInverse.Size = New Size(46, 35)
        cmdInverse.TabIndex = 26
        cmdInverse.Text = "1/X"
        cmdInverse.UseVisualStyleBackColor = True
        ' 
        ' cmdSqrt
        ' 
        cmdSqrt.Location = New Point(260, 89)
        cmdSqrt.Margin = New Padding(3, 2, 3, 2)
        cmdSqrt.Name = "cmdSqrt"
        cmdSqrt.Size = New Size(65, 35)
        cmdSqrt.TabIndex = 25
        cmdSqrt.Text = "SQRT"
        cmdSqrt.UseVisualStyleBackColor = True
        ' 
        ' cmdMultiply
        ' 
        cmdMultiply.Location = New Point(208, 89)
        cmdMultiply.Margin = New Padding(3, 2, 3, 2)
        cmdMultiply.Name = "cmdMultiply"
        cmdMultiply.Size = New Size(46, 36)
        cmdMultiply.TabIndex = 24
        cmdMultiply.Text = "*"
        cmdMultiply.UseVisualStyleBackColor = True
        ' 
        ' cmdSubstract
        ' 
        cmdSubstract.Location = New Point(208, 130)
        cmdSubstract.Margin = New Padding(3, 2, 3, 2)
        cmdSubstract.Name = "cmdSubstract"
        cmdSubstract.Size = New Size(46, 36)
        cmdSubstract.TabIndex = 24
        cmdSubstract.Text = "-"
        cmdSubstract.UseVisualStyleBackColor = True
        ' 
        ' cmdPf
        ' 
        cmdPf.Location = New Point(260, 50)
        cmdPf.Margin = New Padding(3, 2, 3, 2)
        cmdPf.Name = "cmdPf"
        cmdPf.Size = New Size(46, 35)
        cmdPf.TabIndex = 23
        cmdPf.Text = "X^"
        cmdPf.UseVisualStyleBackColor = True
        ' 
        ' cmdDivison
        ' 
        cmdDivison.Location = New Point(208, 50)
        cmdDivison.Margin = New Padding(3, 2, 3, 2)
        cmdDivison.Name = "cmdDivison"
        cmdDivison.Size = New Size(46, 35)
        cmdDivison.TabIndex = 22
        cmdDivison.Text = "/"
        cmdDivison.UseVisualStyleBackColor = True
        ' 
        ' cmdDecimal
        ' 
        cmdDecimal.Location = New Point(136, 169)
        cmdDecimal.Margin = New Padding(3, 2, 3, 2)
        cmdDecimal.Name = "cmdDecimal"
        cmdDecimal.Size = New Size(46, 35)
        cmdDecimal.TabIndex = 21
        cmdDecimal.Text = "."
        cmdDecimal.UseVisualStyleBackColor = True
        ' 
        ' cmd0
        ' 
        cmd0.Location = New Point(18, 169)
        cmd0.Margin = New Padding(3, 2, 3, 2)
        cmd0.Name = "cmd0"
        cmd0.Size = New Size(46, 35)
        cmd0.TabIndex = 20
        cmd0.Text = "0"
        cmd0.UseVisualStyleBackColor = True
        ' 
        ' cmdSign
        ' 
        cmdSign.Location = New Point(76, 169)
        cmdSign.Margin = New Padding(3, 2, 3, 2)
        cmdSign.Name = "cmdSign"
        cmdSign.Size = New Size(46, 35)
        cmdSign.TabIndex = 19
        cmdSign.Text = "+/-"
        cmdSign.UseVisualStyleBackColor = True
        ' 
        ' cmd3
        ' 
        cmd3.Location = New Point(136, 129)
        cmd3.Margin = New Padding(3, 2, 3, 2)
        cmd3.Name = "cmd3"
        cmd3.Size = New Size(46, 35)
        cmd3.TabIndex = 18
        cmd3.Text = "3"
        cmd3.UseVisualStyleBackColor = True
        ' 
        ' cmd2
        ' 
        cmd2.Location = New Point(76, 129)
        cmd2.Margin = New Padding(3, 2, 3, 2)
        cmd2.Name = "cmd2"
        cmd2.Size = New Size(46, 35)
        cmd2.TabIndex = 17
        cmd2.Text = "2"
        cmd2.UseVisualStyleBackColor = True
        ' 
        ' cmd1
        ' 
        cmd1.Location = New Point(18, 129)
        cmd1.Margin = New Padding(3, 2, 3, 2)
        cmd1.Name = "cmd1"
        cmd1.Size = New Size(46, 35)
        cmd1.TabIndex = 16
        cmd1.Text = "1"
        cmd1.UseVisualStyleBackColor = True
        ' 
        ' cmd6
        ' 
        cmd6.Location = New Point(136, 89)
        cmd6.Margin = New Padding(3, 2, 3, 2)
        cmd6.Name = "cmd6"
        cmd6.Size = New Size(46, 35)
        cmd6.TabIndex = 15
        cmd6.Text = "6"
        cmd6.UseVisualStyleBackColor = True
        ' 
        ' cmd5
        ' 
        cmd5.Location = New Point(76, 89)
        cmd5.Margin = New Padding(3, 2, 3, 2)
        cmd5.Name = "cmd5"
        cmd5.Size = New Size(46, 35)
        cmd5.TabIndex = 14
        cmd5.Text = "5"
        cmd5.UseVisualStyleBackColor = True
        ' 
        ' cmd4
        ' 
        cmd4.Location = New Point(18, 89)
        cmd4.Margin = New Padding(3, 2, 3, 2)
        cmd4.Name = "cmd4"
        cmd4.Size = New Size(46, 35)
        cmd4.TabIndex = 13
        cmd4.Text = "4"
        cmd4.UseVisualStyleBackColor = True
        ' 
        ' cmd9
        ' 
        cmd9.Location = New Point(136, 50)
        cmd9.Margin = New Padding(3, 2, 3, 2)
        cmd9.Name = "cmd9"
        cmd9.Size = New Size(46, 35)
        cmd9.TabIndex = 12
        cmd9.Text = "9"
        cmd9.UseVisualStyleBackColor = True
        ' 
        ' cmd7
        ' 
        cmd7.Location = New Point(18, 50)
        cmd7.Margin = New Padding(3, 2, 3, 2)
        cmd7.Name = "cmd7"
        cmd7.Size = New Size(46, 35)
        cmd7.TabIndex = 11
        cmd7.Text = "7"
        cmd7.UseVisualStyleBackColor = True
        ' 
        ' cmd8
        ' 
        cmd8.Location = New Point(76, 50)
        cmd8.Margin = New Padding(3, 2, 3, 2)
        cmd8.Name = "cmd8"
        cmd8.Size = New Size(46, 35)
        cmd8.TabIndex = 10
        cmd8.Text = "8"
        cmd8.UseVisualStyleBackColor = True
        ' 
        ' cmdC
        ' 
        cmdC.Location = New Point(260, 10)
        cmdC.Margin = New Padding(3, 2, 3, 2)
        cmdC.Name = "cmdC"
        cmdC.Size = New Size(46, 35)
        cmdC.TabIndex = 9
        cmdC.Text = "C"
        cmdC.UseVisualStyleBackColor = True
        ' 
        ' cmdCE
        ' 
        cmdCE.Location = New Point(208, 10)
        cmdCE.Margin = New Padding(3, 2, 3, 2)
        cmdCE.Name = "cmdCE"
        cmdCE.Size = New Size(46, 35)
        cmdCE.TabIndex = 6
        cmdCE.Text = "CE"
        cmdCE.UseVisualStyleBackColor = True
        ' 
        ' cmdBackspace
        ' 
        cmdBackspace.Location = New Point(18, 10)
        cmdBackspace.Margin = New Padding(3, 2, 3, 2)
        cmdBackspace.Name = "cmdBackspace"
        cmdBackspace.Size = New Size(105, 35)
        cmdBackspace.TabIndex = 2
        cmdBackspace.Text = "Backspace"
        cmdBackspace.UseVisualStyleBackColor = True
        ' 
        ' cmdn
        ' 
        cmdn.Location = New Point(18, 208)
        cmdn.Margin = New Padding(3, 2, 3, 2)
        cmdn.Name = "cmdn"
        cmdn.Size = New Size(46, 35)
        cmdn.TabIndex = 29
        cmdn.Text = "n!"
        cmdn.UseVisualStyleBackColor = True
        ' 
        ' cmdn3
        ' 
        cmdn3.Location = New Point(77, 208)
        cmdn3.Margin = New Padding(3, 2, 3, 2)
        cmdn3.Name = "cmdn3"
        cmdn3.Size = New Size(46, 35)
        cmdn3.TabIndex = 30
        cmdn3.Text = "3!"
        cmdn3.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(350, 341)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Calculator"
        Text = "Calculator"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmdC As Button
    Friend WithEvents cmdCE As Button
    Friend WithEvents cmdBackspace As Button
    Friend WithEvents cmdEqual As Button
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdInverse As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdSubstract As Button
    Friend WithEvents cmdPf As Button
    Friend WithEvents cmdDivison As Button
    Friend WithEvents cmdDecimal As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmdn3 As Button
    Friend WithEvents cmdn As Button

End Class
