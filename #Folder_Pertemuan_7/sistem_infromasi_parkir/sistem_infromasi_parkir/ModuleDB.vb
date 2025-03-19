Imports MySql.Data.MySqlClient

Namespace sistem_informasi_parkir
    Module ModuleDB

        Public pengguna As String = "dika"
        Public password As String = "dika"
        Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
        Public myConn As MySqlConnection
        Public myCommand As MySqlCommand
        Public myDataReader As MySqlDataReader
        Public myDataAdapter As MySqlDataAdapter
        Public jns As String = String.Empty
        Public tbluser As String = "users"
        Public ltb As Integer = 5

        Public Sub CreateConnection()
            myStrCon.UserID = "root"
            myStrCon.Server = "localhost"
            myStrCon.Password = ""
            myStrCon.Database = "db_si_parkir" ' Sesuaikan nama database
            myConn = New MySqlConnection(myStrCon.ToString())
        End Sub

    End Module
End Namespace
