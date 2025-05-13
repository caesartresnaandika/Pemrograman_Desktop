Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class Form1
    Dim modegambar As String
    Dim warnatepi As Color = Color.Black
    Dim warnaisian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnatepi, 3)
    Dim ukurantepi As Single = 3
    Dim isian As New System.Drawing.SolidBrush(warnaisian)
    Dim titik As Point = Nothing
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap

    Private warnaPalet As Color() = {
        Color.Red,    ' Warna1
        Color.Yellow, ' Warna2
        Color.Green,  ' Warna3
        Color.Blue,   ' Warna4
        Color.Black,  ' Warna5
        Color.White   ' Warna6
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp

        ' Set warna panel
        Warna1.BackColor = warnaPalet(0)
        Warna2.BackColor = warnaPalet(1)
        Warna3.BackColor = warnaPalet(2)
        Warna4.BackColor = warnaPalet(3)
        Warna5.BackColor = warnaPalet(4)
        Warna6.BackColor = warnaPalet(5)

        BtnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round

    End Sub

    Private Sub RbBebas_CheckedChanged(sender As Object, e As EventArgs) Handles RbBebas.CheckedChanged
        modegambar = "bebas"
    End Sub

    Private Sub RbGaris_CheckedChanged(sender As Object, e As EventArgs) Handles RbGaris.CheckedChanged
        modegambar = "garis"
    End Sub

    Private Sub RbKotak_CheckedChanged(sender As Object, e As EventArgs) Handles RbKotak.CheckedChanged
        modegambar = "kotak"
    End Sub

    Private Sub RbElips_CheckedChanged(sender As Object, e As EventArgs) Handles RbElips.CheckedChanged
        modegambar = "elips"
    End Sub

    Private Sub RbKotakIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RbKotakIsi.CheckedChanged
        modegambar = "kotakisi"
    End Sub

    Private Sub RbElipsIsi_CheckedChanged(sender As Object, e As EventArgs) Handles RbElipsIsi.CheckedChanged
        modegambar = "elipsisi"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        ukurantepi = CSng(NumericUpDown1.Value)
        tepi.Width = ukurantepi
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnatepi
        isian.Color = warnaisian
        titik = e.Location
        dipencet = True
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modegambar
            Case "bebas"
                If dipencet Then
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(tepi, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & Environment.NewLine)
                    TextBox1.AppendText("o garis " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & Environment.NewLine)
                    TextBox1.AppendText("o " + "ukurantepi" + " " + ukurantepi.ToString & Environment.NewLine)
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modegambar
            Case "garis"
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawLine(tepi, titik, e.Location)
                End Using
            Case "kotak"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawRectangle(tepi, rect)
                End Using
            Case "elips"
                Dim rect As New Rectangle(titik.X, titik.Y, e.X - titik.X, e.Y - titik.Y)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawEllipse(tepi, rect)
                End Using
            Case "kotakisi"
                Dim startX As Integer = Math.Min(titik.X, e.X)
                Dim startY As Integer = Math.Min(titik.Y, e.Y)
                Dim width As Integer = Math.Abs(e.X - titik.X)
                Dim height As Integer = Math.Abs(e.Y - titik.Y)

                If width > 0 AndAlso height > 0 Then
                    Dim rect As New Rectangle(startX, startY, width, height)
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                        g.FillRectangle(isian, rect)
                        g.DrawRectangle(tepi, rect)
                    End Using
                End If
            Case "elipsisi"
                Dim startX As Integer = Math.Min(titik.X, e.X)
                Dim startY As Integer = Math.Min(titik.Y, e.Y)
                Dim width As Integer = Math.Abs(e.X - titik.X)
                Dim height As Integer = Math.Abs(e.Y - titik.Y)

                If width > 0 AndAlso height > 0 Then
                    Dim rect As New Rectangle(startX, startY, width, height)
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                        g.FillEllipse(isian, rect)
                        g.DrawEllipse(tepi, rect)
                    End Using
                End If
        End Select

        PictureBox1.Invalidate()
        dipencet = False

        If (titik.X <> e.X And titik.Y <> e.Y) Then
            TextBox1.AppendText("o " + "warnatepi" + " " + warnatepi.R.ToString + " " + warnatepi.G.ToString + " " + warnatepi.B.ToString & Environment.NewLine)
            TextBox1.AppendText("o " + "warnaisian" + " " + warnaisian.R.ToString + " " + warnaisian.G.ToString + " " + warnaisian.B.ToString & Environment.NewLine)
            TextBox1.AppendText("o " + "ukurantepi" + " " + ukurantepi.ToString & Environment.NewLine)
            TextBox1.AppendText("o " + modegambar + " " + titik.X.ToString + " " + titik.Y.ToString + " " + e.X.ToString + " " + e.Y.ToString & Environment.NewLine)
        End If
    End Sub

    ' Event handlers untuk pemilihan warna
    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna1.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna1.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna2.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna2.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna3.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna3.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna4.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna4.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna5.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna5.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnatepi = Warna6.BackColor
            ShapeTepi.BackColor = warnatepi
        Else
            warnaisian = Warna6.BackColor
            ShapeIsian.BackColor = warnaisian
        End If
    End Sub

    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub

    Private Sub BtnGambarUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGambarUlang.Click
        ' Bersihkan canvas terlebih dahulu
        BtnBersihkan.PerformClick()

        ' Inisialisasi variabel untuk properti saat ini
        Dim currentPenColor As Color = Color.Black
        Dim currentBrushColor As Color = Color.White
        Dim currentPenWidth As Single = 3

        ' Loop melalui semua baris di TextBox1
        For i As Integer = 0 To TextBox1.Lines.Length - 1
            Dim line As String = TextBox1.Lines(i)
            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim parts() As String = line.Split(" "c)
            If parts.Length < 2 Then Continue For

            Select Case parts(1)
                Case "warnatepi"
                    If parts.Length >= 5 Then
                        currentPenColor = Color.FromArgb(CInt(parts(2)), CInt(parts(3)), CInt(parts(4)))
                    End If

                Case "warnaisian"
                    If parts.Length >= 5 Then
                        currentBrushColor = Color.FromArgb(CInt(parts(2)), CInt(parts(3)), CInt(parts(4)))
                    End If

                Case "ukurantepi"
                    If parts.Length >= 3 Then
                        currentPenWidth = CSng(parts(2))
                    End If

                Case "garis", "kotak", "elips", "kotakisi", "elipsisi"
                    If parts.Length >= 6 Then
                        ' Update properti drawing
                        Using pen As New Pen(currentPenColor, currentPenWidth)
                            Using brush As New SolidBrush(currentBrushColor)
                                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                                    g.SmoothingMode = SmoothingMode.AntiAlias

                                    Dim x1 As Integer = CInt(parts(2))
                                    Dim y1 As Integer = CInt(parts(3))
                                    Dim x2 As Integer = CInt(parts(4))
                                    Dim y2 As Integer = CInt(parts(5))

                                    Select Case parts(1)
                                        Case "garis"
                                            g.DrawLine(pen, x1, y1, x2, y2)

                                        Case "kotak"
                                            Dim rect As Rectangle = GetRectangle(x1, y1, x2, y2)
                                            g.DrawRectangle(pen, rect)

                                        Case "elips"
                                            Dim rect As Rectangle = GetRectangle(x1, y1, x2, y2)
                                            g.DrawEllipse(pen, rect)

                                        Case "kotakisi"
                                            Dim rect As Rectangle = GetRectangle(x1, y1, x2, y2)
                                            g.FillRectangle(brush, rect)
                                            g.DrawRectangle(pen, rect)

                                        Case "elipsisi"
                                            Dim rect As Rectangle = GetRectangle(x1, y1, x2, y2)
                                            g.FillEllipse(brush, rect)
                                            g.DrawEllipse(pen, rect)
                                    End Select
                                End Using
                            End Using
                        End Using
                    End If
            End Select
        Next

        ' Refresh picture box
        PictureBox1.Invalidate()
    End Sub

    Private Function GetRectangle(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer) As Rectangle
        Dim startX As Integer = Math.Min(x1, x2)
        Dim startY As Integer = Math.Min(y1, y2)
        Dim width As Integer = Math.Abs(x2 - x1)
        Dim height As Integer = Math.Abs(y2 - y1)
        Return New Rectangle(startX, startY, width, height)
    End Function

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        If TextBox1.Lines.Length = 0 Then Exit Sub

        ' Cari aksi terakhir yang lengkap
        Dim lastActionIndex As Integer = TextBox1.Lines.Length - 100
        Dim linesToRemove As Integer = 0

        ' Cari dari baris terakhir ke atas untuk menemukan awal aksi terakhir
        For i As Integer = TextBox1.Lines.Length - 1 To 0 Step -1
            Dim line As String = TextBox1.Lines(i)
            If String.IsNullOrWhiteSpace(line) Then Continue For

            Dim parts() As String = line.Split(" "c)
            If parts.Length < 2 Then Continue For

            If parts(1) = "garis" Then
                ' Untuk garis, hapus 3 baris (warnatepi, ukurantepi, garis)
                linesToRemove = 3
                Exit For
            ElseIf parts(1) = "warnatepi" OrElse parts(1) = "warnaisian" OrElse parts(1) = "ukurantepi" Then
                ' Ini bagian dari aksi shape, lanjutkan mencari
                Continue For
            ElseIf parts(1) = "kotak" OrElse parts(1) = "elips" OrElse
               parts(1) = "kotakisi" OrElse parts(1) = "elipsisi" Then
                ' Untuk shape, hapus 4 baris (warnatepi, warnaisian, ukurantepi, shape)
                linesToRemove = 4
                Exit For
            End If
        Next

        ' Pastikan kita menemukan aksi yang valid
        If linesToRemove = 0 Then
            ' Jika tidak ditemukan aksi yang valid, hapus 1 baris terakhir saja
            linesToRemove = 1
        End If

        ' Pastikan tidak melebihi jumlah baris yang ada
        linesToRemove = Math.Min(linesToRemove, TextBox1.Lines.Length)

        ' Hapus baris-baris terakhir
        Dim newLines As New List(Of String)(TextBox1.Lines)
        newLines.RemoveRange(newLines.Count - linesToRemove, linesToRemove)
        TextBox1.Lines = newLines.ToArray()

        ' Gambar ulang semua
        BtnGambarUlang.PerformClick()
    End Sub

End Class