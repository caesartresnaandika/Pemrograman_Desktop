Public Class frmWatermark
    Public Property WatermarkText As String = ""
    Public Property WatermarkColor As Color = Color.FromArgb(128, 255, 255, 255) ' Semi-transparent white
    Public Property FontSize As Integer = 20
    Public Property UserDialogResult As DialogResult = DialogResult.Cancel

    Public Property Spacing As Integer = 100 ' Jarak antar watermark

    Private Sub frmWatermark_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi ComboBox Warna
        cbWarnaWatermark.Items.AddRange({"Merah", "Kuning", "Hijau", "Biru", "Ungu", "Hitam", "Putih", "Abu-abu"})
        cbWarnaWatermark.SelectedIndex = 6 ' Default: Putih (transparan)

        ' Set default values
        nudFontSize.Value = FontSize
        nudSpacing.Value = Spacing ' Kontrol baru untuk jarak
    End Sub

    Private Sub tbWaterMark_TextChanged(sender As Object, e As EventArgs) Handles tbWaterMark.TextChanged
        ' Update watermark text property
        WatermarkText = tbWaterMark.Text
    End Sub

    Private Sub cbWarnaWatermark_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWarnaWatermark.SelectedIndexChanged
        ' Mengatur warna watermark berdasarkan pilihan ComboBox
        Select Case cbWarnaWatermark.SelectedItem.ToString()
            Case "Merah" : WatermarkColor = Color.FromArgb(128, Color.Red)
            Case "Kuning" : WatermarkColor = Color.FromArgb(128, Color.Yellow)
            Case "Hijau" : WatermarkColor = Color.FromArgb(128, Color.Green)
            Case "Biru" : WatermarkColor = Color.FromArgb(128, Color.Blue)
            Case "Ungu" : WatermarkColor = Color.FromArgb(128, Color.Purple)
            Case "Hitam" : WatermarkColor = Color.FromArgb(128, Color.Black)
            Case "Putih" : WatermarkColor = Color.FromArgb(128, Color.White)
            Case "Abu-abu" : WatermarkColor = Color.FromArgb(128, Color.Gray)
        End Select
    End Sub

    Private Sub nudFontSize_ValueChanged(sender As Object, e As EventArgs) Handles nudFontSize.ValueChanged
        ' Update ukuran font
        FontSize = CInt(nudFontSize.Value)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi input
        If String.IsNullOrWhiteSpace(WatermarkText) Then
            MessageBox.Show("Masukkan teks watermark terlebih dahulu!", "Peringatan",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub nudSpacing_ValueChanged(sender As Object, e As EventArgs) Handles nudSpacing.ValueChanged
        ' Update jarak antar watermark
        Spacing = CInt(nudSpacing.Value)
    End Sub

End Class