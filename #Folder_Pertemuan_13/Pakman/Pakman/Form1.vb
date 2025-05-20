Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    'map (peta papan permainan)
    Dim map = {
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    }

    'kumpulan variabel
    Dim tsz As Integer = 40 'tile size (ukuran grid/tilenya)
    Dim pacx As Integer = 1 'pakman itu di petak x mana sekarang
    Dim pacy As Integer = 1 ' petak y
    Dim pacArah As Integer = 1 ' 0=atas, 1=kanan, 2=bawah, 3=kiri
    Dim enmx As Integer = 13 'musuh itu di petak x berapa
    Dim enmy As Integer = 9 ' petak y
    Dim enm2x As Integer = 5 ' musuh kedua
    Dim enm2y As Integer = 5
    Dim enm3x As Integer = 7 ' musuh ketiga
    Dim enm3y As Integer = 9
    Dim goalx As Integer = 1 'goal (pintu keluar pakman di petak x brp
    Dim goaly As Integer = 9 'goal di petak y berapa
    Dim bmp As Bitmap
    Dim oldpacx As Integer = 0
    Dim oldpacy As Integer = 0
    Dim nyawa As Integer = 3
    Dim isPaused As Boolean = False
    Dim pauseButtonRect As Rectangle
    Dim refreshButtonRect As Rectangle
    Dim buttonSize As Integer = 30

    'deklarasi sprite citra yang digunakan
    Dim folder As String = Application.StartupPath
    Dim wall As Image = Image.FromFile(folder + "\bata.png")
    Dim way As Image = Image.FromFile(folder + "\rumput.png")
    Dim pac As Image = Image.FromFile(folder + "\pakman.png")
    Dim pacAtas As Image = Image.FromFile(folder + "\pakman4.png")
    Dim pacBawah As Image = Image.FromFile(folder + "\pakman2.png")
    Dim pacKiri As Image = Image.FromFile(folder + "\pakman3.png")
    Dim enm As Image = Image.FromFile(folder + "\hantu3.png")
    Dim enm2 As Image = Image.FromFile(folder + "\hantu1.png")
    Dim enm3 As Image = Image.FromFile(folder + "\hantu2.png")
    Dim goal As Image = Image.FromFile(folder + "\rumah.jpg")
    Dim heart As Image = Image.FromFile(folder + "\heart.png")
    Dim pauseImg As Image = Image.FromFile(folder + "\pause.png")
    Dim playImg As Image = Image.FromFile(folder + "\continue.png")
    Dim refreshImg As Image = Image.FromFile(folder + "\refresh.png")

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(PictureBox1.Image)
        ' Dapatkan ukuran map secara dinamis
        Dim rows As Integer = map.GetLength(0)
        Dim cols As Integer = map.GetLength(1)

        'gambarkan background (jalan dan tembok)
        For y = 0 To rows - 1
            For x = 0 To cols - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        'gambarkan pacman dengan arah yang sesuai
        Select Case pacArah
            Case 0
                g.DrawImage(pacAtas, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 1
                g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 2
                g.DrawImage(pacBawah, pacx * tsz, pacy * tsz, tsz, tsz)
            Case 3
                g.DrawImage(pacKiri, pacx * tsz, pacy * tsz, tsz, tsz)
        End Select

        'gambarkan musuh
        If Not isPaused Then ' Hanya gambar musuh jika game tidak pause
            g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
            g.DrawImage(enm2, enm2x * tsz, enm2y * tsz, tsz, tsz)
            g.DrawImage(enm3, enm3x * tsz, enm3y * tsz, tsz, tsz)
        End If

        'gambarkan goal
        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)

        'gambarkan nyawa hanya jika nyawa > 0
        If nyawa > 0 Then
            For i As Integer = 1 To nyawa
                g.DrawImage(heart, (i - 1) * tsz, 0, tsz, tsz)
            Next
        End If

        'gambarkan tombol refresh di kanan atas (sebelah kiri pause)
        Dim refreshButtonX As Integer = PictureBox1.Width - (buttonSize * 2) - 20
        Dim refreshButtonY As Integer = 10
        refreshButtonRect = New Rectangle(refreshButtonX, refreshButtonY, buttonSize, buttonSize)
        g.DrawImage(refreshImg, refreshButtonRect)

        'gambarkan tombol pause/play di kanan atas
        Dim pauseButtonX As Integer = PictureBox1.Width - buttonSize - 10
        Dim pauseButtonY As Integer = 10
        pauseButtonRect = New Rectangle(pauseButtonX, pauseButtonY, buttonSize, buttonSize)

        If isPaused Then
            g.DrawImage(playImg, pauseButtonRect)
            ' Gambar overlay semi-transparan saat pause
            Dim semiTransBrush As New SolidBrush(Color.FromArgb(128, 0, 0, 0))
            g.FillRectangle(semiTransBrush, 0, 0, PictureBox1.Width, PictureBox1.Height)

            ' Perbaikan: Konversi eksplisit ke Single atau gunakan CSng()
            Dim xPos As Single = CSng(PictureBox1.Width / 2 - 70)
            Dim yPos As Single = CSng(PictureBox1.Height / 2 - 20)
            g.DrawString("PAUSED", New Font("Arial", 24, FontStyle.Bold), Brushes.White, xPos, yPos)
        Else
            g.DrawImage(pauseImg, pauseButtonRect)
        End If

        PictureBox1.Refresh()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If isPaused Then Exit Sub ' Abaikan input keyboard jika game pause

        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pacy = pacy - 1
                    pacArah = 0
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pacy = pacy + 1
                    pacArah = 2
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pacx = pacx + 1
                    pacArah = 1
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pacx = pacx - 1
                    pacArah = 3
                End If
            Case Keys.P ' Tambahkan shortcut keyboard P untuk pause/unpause
                TogglePause()
            Case Keys.R ' Tambahkan shortcut keyboard R untuk restart
                RestartGame()
        End Select
        Redraw()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sesuaikan dulu ukuran picturebox dan form
        Dim cols As Integer = map.GetLength(1)
        Dim rows As Integer = map.GetLength(0)

        PictureBox1.Width = cols * tsz
        PictureBox1.Height = rows * tsz
        Me.Width = PictureBox1.Width + tsz
        Me.Height = PictureBox1.Height + tsz
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp

        ' Atur posisi tombol
        Dim refreshButtonX As Integer = PictureBox1.Width - (buttonSize * 2) - 20
        Dim refreshButtonY As Integer = 10
        refreshButtonRect = New Rectangle(refreshButtonX, refreshButtonY, buttonSize, buttonSize)

        Dim pauseButtonX As Integer = PictureBox1.Width - buttonSize - 10
        Dim pauseButtonY As Integer = 10
        pauseButtonRect = New Rectangle(pauseButtonX, pauseButtonY, buttonSize, buttonSize)

        Redraw()
    End Sub

    Private Sub GerakanHantu(ByRef enmx As Integer, ByRef enmy As Integer)
        ' Cari jalur terpendek menggunakan algoritma sederhana
        Dim directions As New List(Of Point)

        ' Cek arah yang mungkin
        If map(enmy - 1, enmx) = 1 Then directions.Add(New Point(0, -1)) ' Atas
        If map(enmy + 1, enmx) = 1 Then directions.Add(New Point(0, 1))  ' Bawah
        If map(enmy, enmx - 1) = 1 Then directions.Add(New Point(-1, 0)) ' Kiri
        If map(enmy, enmx + 1) = 1 Then directions.Add(New Point(1, 0))   ' Kanan

        ' Jika tidak ada arah yang mungkin, tetap di tempat
        If directions.Count = 0 Then Return

        ' Pilih arah yang mengurangi jarak ke Pakman
        Dim bestDir As Point = directions(0)
        Dim minDist As Integer = Integer.MaxValue

        For Each dir As Point In directions
            Dim newX As Integer = enmx + dir.X
            Dim newY As Integer = enmy + dir.Y
            Dim dist As Integer = Math.Abs(newX - pacx) + Math.Abs(newY - pacy)

            If dist < minDist Then
                minDist = dist
                bestDir = dir
            End If
        Next

        ' Gerakkan hantu
        enmx += bestDir.X
        enmy += bestDir.Y
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isPaused Then Exit Sub ' Jangan lakukan apa-apa jika game pause

        ' Gerakkan semua hantu
        GerakanHantu(enmx, enmy)
        GerakanHantu(enm2x, enm2y)
        GerakanHantu(enm3x, enm3y)

        oldpacx = pacx
        oldpacy = pacy
        Redraw()

        'cek apakah posisi pakman sama dengan salah satu hantu
        If (pacx = enmx And pacy = enmy) Or
           (pacx = enm2x And pacy = enm2y) Or
           (pacx = enm3x And pacy = enm3y) Then
            nyawa = nyawa - 1
            Redraw() ' Perbarui tampilan nyawa sebelum pengecekan

            If nyawa <= 0 Then
                Timer1.Enabled = False
                ' Tidak langsung keluar, biarkan player memilih restart
            Else
                ' Reset posisi Pakman dan musuh
                pacx = 1
                pacy = 1
                enmx = 13
                enmy = 9
                enm2x = 5
                enm2y = 5
                enm3x = 7
                enm3y = 9
            End If
        End If

        'cek apakah posisi pakman sama dg rumah
        If (pacx = goalx) And (pacy = goaly) Then
            Timer1.Enabled = False
            MsgBox("Pakman safe at Home!")
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        ' Cek apakah klik berada di area tombol pause
        If pauseButtonRect.Contains(e.Location) Then
            TogglePause()
        End If

        ' Cek apakah klik berada di area tombol refresh
        If refreshButtonRect.Contains(e.Location) Then
            RestartGame()
        End If
    End Sub

    Private Sub TogglePause()
        isPaused = Not isPaused
        If isPaused Then
            ' Game di-pause
            Timer1.Enabled = False
        Else
            ' Game dilanjutkan
            Timer1.Enabled = True
        End If
        Redraw()
    End Sub

    Private Sub RestartGame()
        ' Reset semua variabel ke kondisi awal
        pacx = 1
        pacy = 1
        pacArah = 1
        enmx = 13
        enmy = 9
        enm2x = 5
        enm2y = 5
        enm3x = 7
        enm3y = 9
        nyawa = 3
        isPaused = False

        ' Mulai kembali timer
        Timer1.Enabled = True

        ' Redraw tampilan
        Redraw()
    End Sub

End Class