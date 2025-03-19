Imports MySql.Data.MySqlClient


Public Class ProfileForm
    Private Sub ProfileForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtUsername.Text = pengguna
        txtPassword.Text = ppassword
    End Sub

    Private Sub ProfileForm_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If txtPassword.Text = txtRetype.Text Then
            Dim sql As String = "update users set password='" & txtPassword.Text & "'where username='" & pengguna & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            If myCommand.ExecuteNonQuery = 1 Then
                MsgBox("Password berhasil diganti, silahkan login ulang!")
                LoginForm.txtEnterPassword.Clear()
                LoginForm.txtEnterUsername.Clear()
                Me.Close()
                FormUtama.Close()
                LoginForm.txtEnterUsername.Focus()
                LoginForm.ShowDialog()
            End If
        ElseIf txtRetype.Text <> "" Then
            MsgBox("Password tidak sama!")
        End If
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtRetype.PasswordChar = ControlChars.NullChar ' Menampilkan teks biasa
            txtPassword.PasswordChar = ControlChars.NullChar ' Menampilkan teks biasa
        Else
            txtRetype.PasswordChar = "*" ' Menyembunyikan password dengan karakter bintang
            txtPassword.PasswordChar = "*" ' Menyembunyikan password dengan karakter bintang
        End If
    End Sub

End Class