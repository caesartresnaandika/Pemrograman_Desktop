Public Class LanggananForm
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formBaru As New FormUtama()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub
End Class