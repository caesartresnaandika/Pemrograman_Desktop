Public Class Form1
    Dim brs As Integer = 0
    Dim kol As Integer = 0
    Dim bomb As Integer = 0
    Dim mines(,) As TextBox

    Private Sub HapusTextBox(ByVal ctl As Panel)
        For Each ct In ctl.Controls
            If TypeOf (ct) Is TextBox Then
                Me.Controls.Remove(ct)
                ct.dispose()
            End If
        Next
        Me.Refresh()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuat_Click(sender As System.Object, e As System.EventArgs) Handles btnBuat.Click
        HapusTextBox(Panel1)
        For i As Integer = 0 To brs - 1
            For j As Integer = 0 To kol - 1
                mines(i, j).Text = "0"
                mines(i, j).Visible = False
            Next
        Next

        brs = CInt(nudBaris.Value)
        kol = CInt(nudKolom.Value)
        bomb = CInt(nudBom.Value)

        'Buat kotak
        ReDim mines(brs, kol)
        For i As Integer = 0 To brs - 1
            For j As Integer = 0 To kol - 1
                mines(i, j) = New TextBox()
                Panel1.Controls.Add(mines(i, j))
                mines(i, j).Width = 30
                mines(i, j).Height = 20
                mines(i, j).Location = New Point(5 + j * 36, 10 + i * 26)
                mines(i, j).Name = "mines" & CStr(i) & CStr(j)
                mines(i, j).Visible = True
                mines(i, j).Text = "0"
            Next j
        Next i


        'Random Bom
        Dim myrandom As Random = New Random
        Randomize()
        Dim jmlbom = 0
        While jmlbom < bomb
            Dim x As Integer = myrandom.Next(0, brs)
            Dim y As Integer = myrandom.Next(0, kol)
            If mines(x, y).Text <> "999" Then
                mines(x, y).Text = "999"
                jmlbom = jmlbom + 1
            End If
        End While
        For i As Integer = 0 To brs - 1
            For j As Integer = 0 To kol - 1
                If mines(i, j).Text = "999" Then
                    'atas
                    If (i - 1 >= 0) And (j >= 0) Then
                        If mines(i - 1, j).Text <> "999" Then
                            mines(i - 1, j).Text = (CInt(mines(i - 1, j).Text) + 1).ToString
                        End If
                    End If
                    'atas kanan
                    If (i - 1 >= 0) And (j + 1 < kol) Then
                        If mines(i - 1, j + 1).Text <> "999" Then
                            mines(i - 1, j + 1).Text = (CInt(mines(i - 1, j + 1).Text) + 1).ToString
                        End If
                    End If
                    'kanan
                    If (i >= 0) And (j + 1 < kol) Then
                        If mines(i, j + 1).Text <> "999" Then
                            mines(i, j + 1).Text = (CInt(mines(i, j + 1).Text) + 1).ToString
                        End If
                    End If
                    'kanan bawah
                    If (i + 1 < brs) And (j + 1 < kol) Then
                        If mines(i + 1, j + 1).Text <> "999" Then
                            mines(i + 1, j + 1).Text = (CInt(mines(i + 1, j + 1).Text) + 1).ToString
                        End If
                    End If
                    'bawah
                    If (i + 1 < brs) And (j < kol) Then
                        If mines(i + 1, j).Text <> "999" Then
                            mines(i + 1, j).Text = (CInt(mines(i + 1, j).Text) + 1).ToString
                        End If
                    End If
                    'bawah kiri
                    If (i + 1 < brs) And (j - 1 >= 0) Then
                        If mines(i + 1, j - 1).Text <> "999" Then
                            mines(i + 1, j - 1).Text = (CInt(mines(i + 1, j - 1).Text) + 1).ToString
                        End If
                    End If
                    'kiri
                    If (i >= 0) And (j - 1 >= 0) Then
                        If mines(i, j - 1).Text <> "999" Then
                            mines(i, j - 1).Text = (CInt(mines(i, j - 1).Text) + 1).ToString
                        End If
                    End If
                    'kiri atas
                    If (i - 1 >= 0) And (j - 1 >= 0) Then
                        If mines(i - 1, j - 1).Text <> "999" Then
                            mines(i - 1, j - 1).Text = (CInt(mines(i - 1, j - 1).Text) + 1).ToString
                        End If
                    End If
                End If
            Next j
        Next i
    End Sub

End Class
