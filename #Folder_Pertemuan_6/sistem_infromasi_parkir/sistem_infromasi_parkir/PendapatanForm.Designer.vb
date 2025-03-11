<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendapatanForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        cbBulanPendapatan = New ComboBox()
        Label3 = New Label()
        btnTampilkanPendapatan = New Button()
        DataGridView1 = New DataGridView()
        btnTutupPendapatanForm = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F)
        Label2.Location = New Point(43, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 4
        Label2.Text = "Periode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F)
        Label1.Location = New Point(43, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 5
        Label1.Text = "Laporan"
        ' 
        ' cbBulanPendapatan
        ' 
        cbBulanPendapatan.FormattingEnabled = True
        cbBulanPendapatan.Location = New Point(108, 42)
        cbBulanPendapatan.Name = "cbBulanPendapatan"
        cbBulanPendapatan.Size = New Size(121, 23)
        cbBulanPendapatan.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F)
        Label3.Location = New Point(244, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 7
        Label3.Text = "Tahun"
        ' 
        ' btnTampilkanPendapatan
        ' 
        btnTampilkanPendapatan.AutoSize = True
        btnTampilkanPendapatan.Font = New Font("Segoe UI", 11F)
        btnTampilkanPendapatan.Location = New Point(310, 42)
        btnTampilkanPendapatan.Name = "btnTampilkanPendapatan"
        btnTampilkanPendapatan.Size = New Size(86, 31)
        btnTampilkanPendapatan.TabIndex = 8
        btnTampilkanPendapatan.Text = "Tampilkan"
        btnTampilkanPendapatan.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(721, 271)
        DataGridView1.TabIndex = 9
        ' 
        ' btnTutupPendapatanForm
        ' 
        btnTutupPendapatanForm.AutoSize = True
        btnTutupPendapatanForm.Font = New Font("Segoe UI", 11F)
        btnTutupPendapatanForm.Location = New Point(678, 390)
        btnTutupPendapatanForm.Name = "btnTutupPendapatanForm"
        btnTutupPendapatanForm.Size = New Size(86, 31)
        btnTutupPendapatanForm.TabIndex = 10
        btnTutupPendapatanForm.Text = "Tutup"
        btnTutupPendapatanForm.UseVisualStyleBackColor = True
        ' 
        ' PendapatanForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTutupPendapatanForm)
        Controls.Add(DataGridView1)
        Controls.Add(btnTampilkanPendapatan)
        Controls.Add(Label3)
        Controls.Add(cbBulanPendapatan)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Name = "PendapatanForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PendapatanForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbBulanPendapatan As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTampilkanPendapatan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnTutupPendapatanForm As Button
End Class
