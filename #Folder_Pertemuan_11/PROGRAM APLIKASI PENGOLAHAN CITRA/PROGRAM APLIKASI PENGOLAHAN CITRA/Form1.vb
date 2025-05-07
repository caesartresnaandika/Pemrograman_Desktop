Public Class Form1

    Dim namafile As String
    Private redBalance As Integer = 100
    Private greenBalance As Integer = 100
    Private blueBalance As Integer = 100

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function GambarTersedia() As Boolean
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Silakan buka gambar terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub BukaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namafile = openFileDialog1.FileName
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim MyPicture As Image
        MyPicture = PictureBox1.Image
        saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If saveFileDialog1.FilterIndex = 1 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Bmp)
            End If
            If saveFileDialog1.FilterIndex = 2 Then
                MyPicture.Save(saveFileDialog1.FileName,
               System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
        End If
    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        MessageBox.Show("Nama File: " + namafile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b, gray As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
            Next
        Next
        'Dim img As Image
        'img = CType(bmp, Image)
        'PictureBox1.Image = img
        PictureBox1.Image = bmp
    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp

    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KurangKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangKontrasToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        ' Solusi 1: Reset dengan memuat ulang dari file asli
        Try
            ' Simpan ukuran asli sebelum reset
            Dim originalWidth = PictureBox1.Image.Width
            Dim originalHeight = PictureBox1.Image.Height

            ' Muat ulang gambar dari file asli
            PictureBox1.Image = Image.FromFile(namafile)

            ' Jika ingin mempertahankan ukuran setelah border (tidak disarankan)
            ' PictureBox1.Image = New Bitmap(Image.FromFile(namafile), originalWidth, originalHeight)

        Catch ex As Exception
            MessageBox.Show("Gagal mereset gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Solusi Alternatif 2: Jika ingin mempertahankan manipulasi piksel
        'Dim originalImage = New Bitmap(namafile)
        'Dim resizedImage = New Bitmap(originalImage, PictureBox1.Image.Width, PictureBox1.Image.Height)
        'PictureBox1.Image = resizedImage
    End Sub

    Private Sub TampilkanHistogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHistogramToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim newForm As New frmHistogram()
        newForm.Show()
    End Sub

    Private Sub TajamkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamkanToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)

        'Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}

        'matriks kernel 3x3'
        Dim kernel As Integer() = {-2, -1, 0, -1, 1, 1, 0, 1, 2}

        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}
        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Putar90DerajatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajatToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    'Private Sub FlipHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
    '    If Not GambarTersedia() Then Exit Sub
    '    Dim bmp = New Bitmap(PictureBox1.Image)
    '    bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
    '    PictureBox1.Image = bmp
    'End Sub

    'Flip Horizontal using pixel manipulation'
    Private Sub FlipHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim original As New Bitmap(PictureBox1.Image)
        Dim flipped As New Bitmap(original.Width, original.Height)

        For y As Integer = 0 To original.Height - 1
            For x As Integer = 0 To original.Width - 1
                Dim pixelColor As Color = original.GetPixel(x, y)
                flipped.SetPixel(original.Width - 1 - x, y, pixelColor)
            Next
        Next

        PictureBox1.Image = flipped
    End Sub

    Private Sub FlipVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVerticalToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TrackBarRed_Scroll(sender As Object, e As EventArgs) Handles TrackBarRed.Scroll
        redBalance = TrackBarRed.Value
        ApplyColorBalance()
    End Sub

    Private Sub TrackBarGreen_Scroll(sender As Object, e As EventArgs) Handles TrackBarGreen.Scroll
        greenBalance = TrackBarGreen.Value
        ApplyColorBalance()
    End Sub

    Private Sub TrackBarBlue_Scroll(sender As Object, e As EventArgs) Handles TrackBarBlue.Scroll
        blueBalance = TrackBarBlue.Value
        ApplyColorBalance()
    End Sub

    Private Sub ApplyColorBalance()
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim r As Integer = bmp.GetPixel(kol, bar).R * redBalance / 100
                Dim g As Integer = bmp.GetPixel(kol, bar).G * greenBalance / 100
                Dim b As Integer = bmp.GetPixel(kol, bar).B * blueBalance / 100

                ' Clipping
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0

                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    ' Implementasi menu-menu baru
    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim r As Integer = bmp.GetPixel(kol, bar).R
                bmp.SetPixel(kol, bar, Color.FromArgb(r, 0, 0))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim g As Integer = bmp.GetPixel(kol, bar).G
                bmp.SetPixel(kol, bar, Color.FromArgb(0, g, 0))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim b As Integer = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(0, 0, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim r As Integer = bmp.GetPixel(kol, bar).R
                Dim g As Integer = bmp.GetPixel(kol, bar).G
                Dim b As Integer = bmp.GetPixel(kol, bar).B

                ' Efek khusus: pertukaran channel warna
                bmp.SetPixel(kol, bar, Color.FromArgb(g, b, r))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterMarkToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Using watermarkForm As New frmWatermark()
            If watermarkForm.ShowDialog() = DialogResult.OK Then
                Dim originalImage As New Bitmap(PictureBox1.Image)
                Dim watermarkedImage As New Bitmap(originalImage)

                Using g As Graphics = Graphics.FromImage(watermarkedImage)
                    ' Set font dan brush
                    Dim font As New Font("Arial", watermarkForm.FontSize, FontStyle.Bold)
                    Dim brush As New SolidBrush(watermarkForm.WatermarkColor)

                    ' Hitung ukuran teks
                    Dim textSize As SizeF = g.MeasureString(watermarkForm.WatermarkText, font)
                    Dim spacingX As Integer = watermarkForm.Spacing + CInt(textSize.Width)
                    Dim spacingY As Integer = watermarkForm.Spacing + CInt(textSize.Height)

                    ' Gambar watermark berulang
                    For y As Integer = 0 To watermarkedImage.Height Step spacingY
                        For x As Integer = 0 To watermarkedImage.Width Step spacingX
                            ' Gambar dengan sudut 45 derajat (opsional)
                            'g.TranslateTransform(x, y)
                            'g.RotateTransform(-45)
                            'g.DrawString(watermarkForm.WatermarkText, font, brush, 0, 0)
                            'g.ResetTransform()

                            ' Gambar lurus
                            g.DrawString(watermarkForm.WatermarkText, font, brush, x, y)
                        Next
                    Next
                End Using

                PictureBox1.Image = watermarkedImage
            End If
        End Using
    End Sub


    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Silakan buka gambar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using borderForm As New frmBorder()
            If borderForm.ShowDialog() = DialogResult.OK Then
                ' Buat bitmap baru dengan border
                Dim originalImage As New Bitmap(PictureBox1.Image)
                Dim borderedImage As New Bitmap(
                originalImage.Width + borderForm.BorderSize * 2,
                originalImage.Height + borderForm.BorderSize * 2)

                Using g As Graphics = Graphics.FromImage(borderedImage)
                    ' Isi seluruh gambar dengan warna border
                    g.Clear(borderForm.BorderColor)

                    ' Gambar gambar asli di tengah
                    g.DrawImage(originalImage,
                           borderForm.BorderSize,
                           borderForm.BorderSize,
                           originalImage.Width,
                           originalImage.Height)
                End Using

                ' Tampilkan hasil
                PictureBox1.Image = borderedImage
            End If
        End Using
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                Dim r As Integer = 255 - bmp.GetPixel(kol, bar).R
                Dim g As Integer = 255 - bmp.GetPixel(kol, bar).G
                Dim b As Integer = 255 - bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub HistogramBalokToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistogramBalokToolStripMenuItem.Click
        If Not GambarTersedia() Then Exit Sub

        Dim histoForm As New frmHistogramBalok()
        histoForm.Show()
    End Sub

End Class
