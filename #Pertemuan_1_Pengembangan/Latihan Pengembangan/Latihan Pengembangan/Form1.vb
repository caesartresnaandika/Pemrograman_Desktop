Public Class ConvertAngka
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblBinary.Click

    End Sub

    Private Sub btnConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvert.Click

        Dim decimalNumber As Integer
        Dim binaryNumber As String
        Dim octalNumber As String
        Dim hexadecimalNumber As String

        ' Mengambil input dari textbox
        decimalNumber = Val(txtDecimal.Text)

        ' Konversi ke basis 2
        binaryNumber = Convert.ToString(decimalNumber, 2)

        ' Konversi ke basis 8
        octalNumber = Convert.ToString(decimalNumber, 8)

        ' Konversi ke basis 16
        hexadecimalNumber = Convert.ToString(decimalNumber, 16).ToUpper()

        ' Menampilkan hasil konversi
        txtBinary.Text = binaryNumber
        txtOctal.Text = octalNumber
        txtHexa.Text = hexadecimalNumber
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBinary_TextChanged(sender As Object, e As EventArgs) Handles txtBinary.TextChanged

    End Sub
End Class
