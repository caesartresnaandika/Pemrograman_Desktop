Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim sql As String = "select username,password from users where username='" & txtEnterUsername.Text & "' and password='" & txtEnterPassword.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = txtEnterUsername.Text
            ppassword = txtEnterPassword.Text

            FormUtama.lblInfoUser.Text = "Informasi - (User: " & pengguna & ")"
            FormUtama.lblTgl.Text = "Tangggal : " & Now.Day & " - " & Now.Month & " - " & Now.Year
            FormUtama.RefreshGrid()
            FormUtama.HitungJumlah()
            FormUtama.Show()

            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateConnection()
    End Sub
End Class
