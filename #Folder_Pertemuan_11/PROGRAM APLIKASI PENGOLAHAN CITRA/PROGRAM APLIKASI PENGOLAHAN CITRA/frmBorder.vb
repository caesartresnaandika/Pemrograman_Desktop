Public Class frmBorder
    Public Property BorderColor As Color = Color.Black
    Public Property BorderSize As Integer = 10
    Public Property UserDialogResult As DialogResult = DialogResult.Cancel

    Private Sub frmBorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi ComboBox Warna
        cbWarnaBorder.Items.AddRange({"Merah", "Kuning", "Hijau", "Biru", "Ungu", "Hitam", "Putih", "Abu-abu"})
        cbWarnaBorder.SelectedIndex = 5 ' Default: Hitam

        ' Inisialisasi ComboBox Ketebalan
        cbKetebalanBorder.Items.AddRange({"1 px", "5 px", "10 px", "15 px", "20 px", "25 px", "30 px", "40 px", "50 px"})
        cbKetebalanBorder.SelectedIndex = 2 ' Default: 10 px
    End Sub

    Private Sub cbWarnaBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbWarnaBorder.SelectedIndexChanged
        ' Mengatur warna border berdasarkan pilihan
        Select Case cbWarnaBorder.SelectedItem.ToString()
            Case "Merah" : BorderColor = Color.Red
            Case "Kuning" : BorderColor = Color.Yellow
            Case "Hijau" : BorderColor = Color.Green
            Case "Biru" : BorderColor = Color.Blue
            Case "Ungu" : BorderColor = Color.Purple
            Case "Hitam" : BorderColor = Color.Black
            Case "Putih" : BorderColor = Color.White
            Case "Abu-abu" : BorderColor = Color.Gray
        End Select
    End Sub

    Private Sub cbKetebalanBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKetebalanBorder.SelectedIndexChanged
        ' Mengatur ketebalan border berdasarkan pilihan
        Dim selectedText As String = cbKetebalanBorder.SelectedItem.ToString()
        BorderSize = Integer.Parse(selectedText.Replace(" px", ""))
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class