﻿Public Class Calculator
    Private valHolder1 As Double
    Private valHolder2 As Double
    Private tmpValue As Double
    Private hasDecimal As Boolean
    Private inputStatus As Boolean = True
    Private clearText As Boolean
    Private calcFunc As String

    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        If inputStatus = False Then
            txtInput.Text &= cmd1.Text
        Else
            txtInput.Text = cmd1.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        If inputStatus = False Then
            txtInput.Text &= cmd2.Text
        Else
            txtInput.Text = cmd2.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        If inputStatus = False Then
            txtInput.Text &= cmd3.Text
        Else
            txtInput.Text = cmd3.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        If inputStatus = False Then
            txtInput.Text &= cmd4.Text
        Else
            txtInput.Text = cmd4.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        If inputStatus = False Then
            txtInput.Text &= cmd5.Text
        Else
            txtInput.Text = cmd5.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        If inputStatus = False Then
            txtInput.Text &= cmd6.Text
        Else
            txtInput.Text = cmd6.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        If inputStatus = False Then
            txtInput.Text &= cmd7.Text
        Else
            txtInput.Text = cmd7.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        If inputStatus = False Then
            txtInput.Text &= cmd8.Text
        Else
            txtInput.Text = cmd8.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        If inputStatus = False Then
            txtInput.Text &= cmd9.Text
        Else
            txtInput.Text = cmd9.Text
            inputStatus = False
        End If
    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        If inputStatus = False Then
            If txtInput.Text.Length >= 1 Then
                txtInput.Text &= cmd0.Text
            End If
        End If
    End Sub

    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        If inputStatus Then
            If Not hasDecimal Then
                If txtInput.Text.Length > 1 Then
                    If Not txtInput.Text = "0" Then
                        txtInput.Text &= cmdDecimal.Text
                        hasDecimal = True
                    End If
                Else
                    txtInput.Text = "0."
                End If
            End If
        End If
    End Sub
    Private Sub CalculateTotals()
        valHolder2 = CType(txtInput.Text, Double)
        Select Case calcFunc
            Case "Add"
                valHolder1 = valHolder1 + valHolder2
            Case "Subtract"
                valHolder1 = valHolder1 - valHolder2
            Case "Divide"
                valHolder1 = valHolder1 / valHolder2
            Case "Multiply"
                valHolder1 = valHolder1 * valHolder2
            Case "PowerOf"
                valHolder1 = System.Math.Pow(valHolder1, valHolder2)
        End Select
        txtInput.Text = CType(valHolder1, String)
        inputStatus = True
    End Sub

    Private Sub cmdC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdC.Click
        txtInput.Text = String.Empty
        valHolder1 = 0
        valHolder2 = 0
        calcFunc = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCE.Click
        txtInput.Text = String.Empty
        hasDecimal = False
    End Sub

    Private Sub cmdBackspace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBackspace.Click
        Dim str As String
        Dim loc As Integer
        If txtInput.Text.Length > 0 Then
            str = txtInput.Text.Chars(txtInput.Text.Length - 1)
            'Jika karakter terakhir adalah , (desimal)
            If str = "." Then
                hasDecimal = False
            End If
            loc = txtInput.Text.Length
            txtInput.Text = txtInput.Text.Remove(loc - 1, 1)
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(txtInput.Text)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Add"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSubstract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubstract.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Subtract"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CDbl(txtInput.Text)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Multiply"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdDivison_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivison.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "Divide"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSqrt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrt.Click
        If txtInput.Text.Length <> 0 Then
            tmpValue = CType(txtInput.Text, Double)
            tmpValue = System.Math.Sqrt(tmpValue)
            txtInput.Text = CType(tmpValue, String)
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdPf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPf.Click
        If txtInput.Text.Length <> 0 Then
            If calcFunc = String.Empty Then
                valHolder1 = CType(txtInput.Text, Double)
                txtInput.Text = String.Empty
            Else
                CalculateTotals()
            End If
            calcFunc = "PowerOf"
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEqual.Click
        If txtInput.Text.Length <> 0 AndAlso valHolder1 <> 0 Then
            CalculateTotals()
            calcFunc = ""
            hasDecimal = False
        End If
    End Sub

    Private Sub cmdSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSign.Click
        If inputStatus = False Then
            If txtInput.Text.Length > 0 Then
                valHolder1 = -1 * CDbl(txtInput.Text)
                txtInput.Text = CStr(valHolder1)
            End If
        End If
    End Sub

    Private Sub cmdInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInverse.Click
        If txtInput.Text.Length <> 0 Then
            tmpValue = CDbl(txtInput.Text)
            tmpValue = 1 / tmpValue
            txtInput.Text = CStr(tmpValue)
            hasDecimal = False
        End If
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdn.Click
        Dim n As Integer
        If Integer.TryParse(txtInput.Text, n) Then
            'n tidak negatif dan tidak lebih dari 20
            If n < 0 Then
                MessageBox.Show("Silakan masukkan angka non-negatif untuk faktorial.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf n > 20 Then
                MessageBox.Show("Faktorial dari angka lebih dari 20 dapat menyebabkan overflow. Silakan masukkan angka 20 atau lebih kecil.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim result As Long = 1
                For i As Integer = 1 To n
                    result *= i
                Next
                txtInput.Text = result.ToString()
            End If
        Else
            MessageBox.Show("Silakan masukkan angka bulat yang valid.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmdn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdn3.Click
        Dim n As Double
        If Double.TryParse(txtInput.Text, n) Then
            ' Hitung akar pangkat 3
            Dim result As Double = Math.Cbrt(n)
            txtInput.Text = result.ToString()
        Else
            MessageBox.Show("Silakan masukkan angka yang valid untuk menghitung akar pangkat 3.", "Input Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
