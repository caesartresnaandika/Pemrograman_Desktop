Public Class FormUtama
    Private Sub BaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaToolStripMenuItem.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub AturProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AturProfileToolStripMenuItem.Click
        Dim formBaru As New ProfileForm()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub LangananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LangananToolStripMenuItem.Click
        Dim formBaru As New LanggananForm()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim formBaru As New PendapatanForm()
        formBaru.Show()
        Me.Hide() ' Menutup Form1
    End Sub
End Class