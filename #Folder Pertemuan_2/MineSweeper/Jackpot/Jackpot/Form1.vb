Public Class Jackpot
    Private Sub Jackpot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim myrandom As Random
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        Timer4.Enabled = True
        Randomize()
        myrandom = New Random
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII besar 
        lbl1.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII besar 
        lbl2.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Dim hasil As Integer = myrandom.Next(65, 92) 'ASCII besar 
        lbl3.Text = Chr(hasil).ToString
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        If lbl1.Text = lbl2.Text And lbl2.Text = lbl3.Text Then
            lblStatus.Text = "3 WIN!"
        ElseIf lbl1.Text = lbl2.Text Or lbl1.Text = lbl3.Text Or lbl2.Text = lbl3.Text Then
            lblStatus.Text = "2 WIN!"
        Else
            lblStatus.Text = "TRY AGAIN"
        End If
        Timer4.Enabled = False
    End Sub
End Class
