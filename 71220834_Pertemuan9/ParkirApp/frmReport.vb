Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReport

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet1
        Dim myAdapter As New MySqlDataAdapter
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        myAdapter.SelectCommand = New MySqlCommand("SELECT * FROM tblparkir", myConn)
        myAdapter.Fill(ds.Tables(0))
        ReportViewer1.Reset()
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1_LapParkir", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        frmUtama.Show()
        Me.Hide()
    End Sub

    ' Tombol btnLaporan sekarang bisa dihapus atau dibiarkan kosong
    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        ' Tidak diperlukan lagi jika sudah otomatis
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
    End Sub

End Class
