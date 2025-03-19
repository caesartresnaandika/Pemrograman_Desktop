Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class PendapatanForm
    Dim myConn As New MySqlConnection("server=localhost;user id=root;password=;database=db_si_parkir")
    Dim myCommand As MySqlCommand
    Dim myDataReader As MySqlDataReader

    ' Fungsi untuk menampilkan data ke DataGridView
    Private Sub RefreshGrid()
        Try
            DataGridView1.Rows.Clear()
            Dim sql As String = "SELECT * FROM tbllangganan"

            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            myCommand = New MySqlCommand(sql, myConn)
            myDataReader = myCommand.ExecuteReader()

            While myDataReader.Read()
                DataGridView1.Rows.Add(myDataReader("id"), myDataReader("no_plat"), myDataReader("nama"),
                                       myDataReader("jenis"), myDataReader("biaya"), myDataReader("expired"))
            End While

            myDataReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If myConn.State = ConnectionState.Open Then myConn.Close()
        End Try
    End Sub

    ' Event saat form pertama kali dibuka
    Private Sub KendaraanLanggananForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    ' Event saat tombol Tambah diklik
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            txtNoPlat.Clear()
            txtNama.Clear()
            txtBiaya.Clear()
            cmbJenis.Text = ""
        ElseIf btnTambah.Text = "Simpan" Then
            Try
                Dim waktu As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
                Dim sql As String = "INSERT INTO tbllangganan (no_plat, nama, jenis, biaya, expired) VALUES (@no_plat, @nama, @jenis, @biaya, @expired)"

                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If

                myCommand = New MySqlCommand(sql, myConn)
                myCommand.Parameters.AddWithValue("@no_plat", txtNoPlat.Text)
                myCommand.Parameters.AddWithValue("@nama", txtNama.Text)
                myCommand.Parameters.AddWithValue("@jenis", cmbJenis.Text)
                myCommand.Parameters.AddWithValue("@biaya", txtBiaya.Text)
                myCommand.Parameters.AddWithValue("@expired", waktu)
                myCommand.ExecuteNonQuery()

                MessageBox.Show("Data berhasil ditambahkan!")
                btnTambah.Text = "Tambah"
                txtNoPlat.Enabled = False
                txtNama.Enabled = False
                txtBiaya.Enabled = False
                cmbJenis.Enabled = False
                DateTimePicker1.Enabled = False
                btnCancel.Visible = False
                btnEdit.Enabled = True
                btnHapus.Enabled = True
                RefreshGrid()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If myConn.State = ConnectionState.Open Then myConn.Close()
            End Try
        End If
    End Sub

    ' Event saat tombol Edit diklik
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            txtNoPlat.Enabled = True
            txtNama.Enabled = True
            txtBiaya.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Try
                Dim waktu As String = DateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")
                Dim sql As String = "UPDATE tbllangganan SET no_plat = @no_plat, nama = @nama, jenis = @jenis, biaya = @biaya, expired = @expired WHERE id = @id"

                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If

                myCommand = New MySqlCommand(sql, myConn)
                myCommand.Parameters.AddWithValue("@no_plat", txtNoPlat.Text)
                myCommand.Parameters.AddWithValue("@nama", txtNama.Text)
                myCommand.Parameters.AddWithValue("@jenis", cmbJenis.Text)
                myCommand.Parameters.AddWithValue("@biaya", txtBiaya.Text)
                myCommand.Parameters.AddWithValue("@expired", waktu)
                myCommand.Parameters.AddWithValue("@id", lblId.Text)
                myCommand.ExecuteNonQuery()

                MessageBox.Show("Data berhasil diperbarui!")
                btnEdit.Text = "Edit"
                txtNoPlat.Enabled = False
                txtNama.Enabled = False
                txtBiaya.Enabled = False
                cmbJenis.Enabled = False
                DateTimePicker1.Enabled = False
                btnCancel.Visible = False
                btnTambah.Enabled = True
                btnHapus.Enabled = True
                RefreshGrid()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If myConn.State = ConnectionState.Open Then myConn.Close()
            End Try
        End If
    End Sub

    ' Event saat tombol Hapus diklik
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow IsNot Nothing AndAlso DataGridView1.CurrentRow.Cells(0).Value IsNot Nothing Then
            If MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    Dim sql As String = "DELETE FROM tbllangganan WHERE id = @id"

                    If myConn.State = ConnectionState.Closed Then
                        myConn.Open()
                    End If

                    myCommand = New MySqlCommand(sql, myConn)
                    myCommand.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value.ToString())
                    myCommand.ExecuteNonQuery()

                    MessageBox.Show("Data berhasil dihapus!")
                    RefreshGrid()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    If myConn.State = ConnectionState.Open Then myConn.Close()
                End Try
            End If
        Else
            MessageBox.Show("Pilih data yang akan dihapus!")
        End If
    End Sub

    ' Event saat tombol Cancel diklik
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnTambah.Text = "Tambah"
        btnEdit.Text = "Edit"
        txtNoPlat.Enabled = False
        txtNama.Enabled = False
        txtBiaya.Enabled = False
        cmbJenis.Enabled = False
        DateTimePicker1.Enabled = False
        btnCancel.Visible = False
        btnTambah.Enabled = True
        btnHapus.Enabled = True
    End Sub
End Class
