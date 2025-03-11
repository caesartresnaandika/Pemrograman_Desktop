Public Class PendapatanForm
    Private Sub btnTutupPendapatanForm_Click(sender As Object, e As EventArgs) Handles btnTutupPendapatanForm.Click
        Dim formBaru As New FormUtama()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub
End Class