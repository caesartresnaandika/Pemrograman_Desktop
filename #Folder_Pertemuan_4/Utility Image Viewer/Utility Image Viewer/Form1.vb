Imports System.IO
Imports System.Drawing.Imaging
Imports gma.Drawing.ImageInfo

Public Class Form1

    Private Function FormatFileSize(ByVal FileSizeBytes As Long) As String
        Dim sizeTypes() As String = {"b", "Kb", "Mb", "Gb"}
        Dim Len As Decimal = FileSizeBytes
        Dim sizeType As Integer = 0
        Do While Len > 1024
            Len = Decimal.Round(Len / 1024, 2)
            sizeType += 1
            If sizeType >= sizeTypes.Length - 1 Then Exit Do
        Loop
        Return Len.ToString & " " & sizeTypes(sizeType)
    End Function

    Private Sub GetFiles(ByVal PathName As String)
        Try
            ' Cek apakah path valid
            If Not Directory.Exists(PathName) Then
                MessageBox.Show("Path tidak valid: " & PathName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            LvImage.Items.Clear()
            LvImage.BeginUpdate()

            For Each nFile As String In Directory.GetFiles(PathName)
                Dim sExtension As String = Path.GetExtension(nFile).ToLower()

                ' Filter hanya file gambar
                If Not (sExtension = ".bmp" Or sExtension = ".jpg" Or sExtension = ".jpeg" Or sExtension = ".gif" Or sExtension = ".png") Then
                    Continue For
                End If

                Dim f As New FileInfo(nFile)
                Dim LItem As New ListViewItem(Path.GetFileNameWithoutExtension(nFile))
                LItem.SubItems.Add(sExtension)
                LItem.SubItems.Add(FormatFileSize(f.Length))
                LItem.SubItems.Add(f.LastWriteTime.ToString())
                LItem.SubItems.Add(f.LastAccessTime.ToString())
                LItem.SubItems.Add(f.CreationTime.ToString())
                LItem.SubItems.Add(f.Attributes.ToString())
                LItem.Tag = nFile

                ' Menambahkan ikon jika belum ada
                If Not ImageList1.Images.ContainsKey(sExtension) Then
                    Dim iconForFile As Icon = System.Drawing.Icon.ExtractAssociatedIcon(nFile)
                    ImageList1.Images.Add(sExtension, iconForFile)
                End If
                LItem.ImageKey = sExtension
                LvImage.Items.Add(LItem)
            Next

            LvImage.EndUpdate()
            LvImage.Columns(0).Width = -2

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengambil file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GetFolders(ByVal PathName As TreeNode)
        Try
            PathName.Nodes.Clear()
            Dim di As New DirectoryInfo(PathName.Tag.ToString())

            For Each nFolder In di.GetDirectories()
                If (nFolder.Attributes And FileAttributes.Hidden) = False Then
                    Dim tNode As New TreeNode(nFolder.Name) With {
                        .ImageIndex = 1,
                        .SelectedImageIndex = 1,
                        .Tag = nFolder.FullName
                    }
                    tNode.Nodes.Add("") ' Placeholder untuk ekspansi
                    PathName.Nodes.Add(tNode)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetDrives()
        For Each Drive In DriveInfo.GetDrives()
            If Drive.IsReady Then
                Dim dName As String = If(String.IsNullOrEmpty(Drive.VolumeLabel), Drive.Name, Drive.VolumeLabel)
                Dim tNode As New TreeNode(dName) With {
                    .ImageIndex = 0,
                    .SelectedImageIndex = 0,
                    .Tag = Drive.Name
                }
                tNode.Nodes.Add("") ' Placeholder untuk ekspansi
                TvDrive.Nodes.Add(tNode)
            End If
        Next
    End Sub

    Function GetRaw(ByVal imgf As ImageFormat) As String
        Select Case True
            Case imgf.Equals(ImageFormat.Bmp) : Return "Bitmap"
            Case imgf.Equals(ImageFormat.Jpeg) : Return "Jpeg"
            Case imgf.Equals(ImageFormat.Png) : Return "PNG"
            Case imgf.Equals(ImageFormat.Tiff) : Return "TIFF"
            Case imgf.Equals(ImageFormat.Gif) : Return "GIF"
            Case imgf.Equals(ImageFormat.Icon) : Return "ICON"
            Case Else : Return "Unknown"
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDrives()
        LvImage.Columns(0).Width = -2
        SplitContainerBawah2.Panel2.AutoScroll = True
    End Sub

    Private Sub TvDrive_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TvDrive.BeforeExpand
        GetFolders(e.Node)
    End Sub

    Private Sub TvDrive_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TvDrive.AfterSelect
        If e.Node.Tag IsNot Nothing Then
            GetFiles(e.Node.Tag.ToString()) ' Pastikan ini String
        End If
    End Sub

    Private Sub LvImage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvImage.SelectedIndexChanged
        lvExif.Items.Clear()
        If LvImage.SelectedItems.Count > 0 Then
            Dim filePath As String = LvImage.SelectedItems(0).Tag.ToString()
            PictureBox1.Image = Image.FromFile(filePath)
            toolStripStatusReady.Text = filePath
            toolStripStatusDimension.Text = "Dimension: " & PictureBox1.Image.Width & " px X " & PictureBox1.Image.Height & " px"
            toolStripStatusBits.Text = "Depth: " & PictureBox1.Image.PixelFormat.ToString()
            toolStripStatusResolution.Text = "Resolution: " & PictureBox1.Image.HorizontalResolution & " dpi X " & PictureBox1.Image.VerticalResolution & " dpi"
            toolStripStatusRawFormat.Text = "Compression: " & GetRaw(PictureBox1.Image.RawFormat)

            ' Menampilkan properti EXIF
            Dim _exif As New Info(filePath)
            PropertyGrid1.SelectedObject = _exif
            For Each propertyName As String In _exif.PropertyItems.Keys
                Try
                    Dim LItem As New ListViewItem(propertyName)
                    LItem.SubItems.Add(_exif.PropertyItems(propertyName).ToString())
                    lvExif.Items.Add(LItem)
                Catch ex As Exception
                End Try
            Next
        End If
        LvImage.Columns(0).Width = -2
        lvExif.Columns(0).Width = -2
    End Sub

    Private Sub LvImage_DoubleClick(sender As Object, e As EventArgs) Handles LvImage.DoubleClick
        Process.Start(LvImage.SelectedItems(0).Tag.ToString())
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        Dim pb As New PictureBox With {
            .Image = Image.FromFile(toolStripStatusReady.Text),
            .SizeMode = PictureBoxSizeMode.AutoSize
        }
        Dim pnl As New Panel With {
            .AutoScroll = True,
            .Dock = DockStyle.Fill
        }
        pnl.Controls.Add(pb)
        Dim f As New Form With {
            .WindowState = FormWindowState.Maximized
        }
        f.Controls.Add(pnl)
        f.Show()
    End Sub
End Class