Public Class LoginForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formBaru As New FormUtama()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub
End Class
