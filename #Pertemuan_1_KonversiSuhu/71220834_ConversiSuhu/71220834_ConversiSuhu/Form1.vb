Public Class KonversiSuhu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblCelcius.Click

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim celcius, fahrenheit, reamur, kelvin As Double
        celcius = Val(txtCelcius.Text)
        fahrenheit = 9 / 5 * (celcius) + 32
        reamur = 4 / 5 * (celcius)
        kelvin = celcius + 273
        txtFH.Text = CStr(fahrenheit)
        txtRMR.Text = CStr(reamur)
        txtKLV.Text = CStr(kelvin)

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub

    Private Sub txtFH_TextChanged(sender As Object, e As EventArgs) Handles txtFH.TextChanged

    End Sub
End Class
