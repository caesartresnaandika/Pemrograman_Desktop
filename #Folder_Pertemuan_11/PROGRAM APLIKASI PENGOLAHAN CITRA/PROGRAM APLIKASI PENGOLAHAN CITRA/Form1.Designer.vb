<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        BukaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        SimpanToolStripMenuItem = New ToolStripMenuItem()
        PropertiToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        HistogramToolStripMenuItem = New ToolStripMenuItem()
        GreyscaleToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        CerahkanToolStripMenuItem = New ToolStripMenuItem()
        GelapkanToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        TambahKontrasToolStripMenuItem = New ToolStripMenuItem()
        KurangKontrasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        TampilkanHistogramToolStripMenuItem = New ToolStripMenuItem()
        EffectsToolStripMenuItem = New ToolStripMenuItem()
        TajamkanToolStripMenuItem = New ToolStripMenuItem()
        KaburkanToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        Putar90DerajatToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        FlipHorizontalToolStripMenuItem = New ToolStripMenuItem()
        FlipVerticalToolStripMenuItem = New ToolStripMenuItem()
        Tugas3ToolStripMenuItem = New ToolStripMenuItem()
        BorderToolStripMenuItem = New ToolStripMenuItem()
        WaterMarkToolStripMenuItem = New ToolStripMenuItem()
        InversiWarnaToolStripMenuItem = New ToolStripMenuItem()
        RonaMerahToolStripMenuItem = New ToolStripMenuItem()
        RonaHijauToolStripMenuItem = New ToolStripMenuItem()
        RonaBiruToolStripMenuItem = New ToolStripMenuItem()
        RonaSpesialToolStripMenuItem = New ToolStripMenuItem()
        HistogramBalokToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TrackBarBlue = New TrackBar()
        TrackBarGreen = New TrackBar()
        TrackBarRed = New TrackBar()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(TrackBarBlue, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBarGreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBarRed, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HistogramToolStripMenuItem, EffectsToolStripMenuItem, Tugas3ToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BukaToolStripMenuItem, ToolStripSeparator6, SimpanToolStripMenuItem, PropertiToolStripMenuItem, ToolStripSeparator5, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' BukaToolStripMenuItem
        ' 
        BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        BukaToolStripMenuItem.Size = New Size(116, 22)
        BukaToolStripMenuItem.Text = "Buka"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(113, 6)
        ' 
        ' SimpanToolStripMenuItem
        ' 
        SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        SimpanToolStripMenuItem.Size = New Size(116, 22)
        SimpanToolStripMenuItem.Text = "Simpan"
        ' 
        ' PropertiToolStripMenuItem
        ' 
        PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        PropertiToolStripMenuItem.Size = New Size(116, 22)
        PropertiToolStripMenuItem.Text = "Properti"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(113, 6)
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(116, 22)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' HistogramToolStripMenuItem
        ' 
        HistogramToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {GreyscaleToolStripMenuItem, ToolStripSeparator1, CerahkanToolStripMenuItem, GelapkanToolStripMenuItem, ToolStripSeparator2, TambahKontrasToolStripMenuItem, KurangKontrasToolStripMenuItem, ToolStripSeparator3, ResetToolStripMenuItem, ToolStripSeparator4, TampilkanHistogramToolStripMenuItem})
        HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        HistogramToolStripMenuItem.Size = New Size(75, 20)
        HistogramToolStripMenuItem.Text = "Histogram"
        ' 
        ' GreyscaleToolStripMenuItem
        ' 
        GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        GreyscaleToolStripMenuItem.Size = New Size(187, 22)
        GreyscaleToolStripMenuItem.Text = "Greyscale"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(184, 6)
        ' 
        ' CerahkanToolStripMenuItem
        ' 
        CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        CerahkanToolStripMenuItem.Size = New Size(187, 22)
        CerahkanToolStripMenuItem.Text = "Cerahkan"
        ' 
        ' GelapkanToolStripMenuItem
        ' 
        GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        GelapkanToolStripMenuItem.Size = New Size(187, 22)
        GelapkanToolStripMenuItem.Text = "Gelapkan"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(184, 6)
        ' 
        ' TambahKontrasToolStripMenuItem
        ' 
        TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        TambahKontrasToolStripMenuItem.Size = New Size(187, 22)
        TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        ' 
        ' KurangKontrasToolStripMenuItem
        ' 
        KurangKontrasToolStripMenuItem.Name = "KurangKontrasToolStripMenuItem"
        KurangKontrasToolStripMenuItem.Size = New Size(187, 22)
        KurangKontrasToolStripMenuItem.Text = "Kurang Kontras"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(184, 6)
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(187, 22)
        ResetToolStripMenuItem.Text = "Reset"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(184, 6)
        ' 
        ' TampilkanHistogramToolStripMenuItem
        ' 
        TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        TampilkanHistogramToolStripMenuItem.Size = New Size(187, 22)
        TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        ' 
        ' EffectsToolStripMenuItem
        ' 
        EffectsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TajamkanToolStripMenuItem, KaburkanToolStripMenuItem, ToolStripSeparator8, Putar90DerajatToolStripMenuItem, ToolStripSeparator7, FlipHorizontalToolStripMenuItem, FlipVerticalToolStripMenuItem})
        EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        EffectsToolStripMenuItem.Size = New Size(54, 20)
        EffectsToolStripMenuItem.Text = "Effects"
        ' 
        ' TajamkanToolStripMenuItem
        ' 
        TajamkanToolStripMenuItem.Name = "TajamkanToolStripMenuItem"
        TajamkanToolStripMenuItem.Size = New Size(157, 22)
        TajamkanToolStripMenuItem.Text = "Tajamkan"
        ' 
        ' KaburkanToolStripMenuItem
        ' 
        KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        KaburkanToolStripMenuItem.Size = New Size(157, 22)
        KaburkanToolStripMenuItem.Text = "Kaburkan"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(154, 6)
        ' 
        ' Putar90DerajatToolStripMenuItem
        ' 
        Putar90DerajatToolStripMenuItem.Name = "Putar90DerajatToolStripMenuItem"
        Putar90DerajatToolStripMenuItem.Size = New Size(157, 22)
        Putar90DerajatToolStripMenuItem.Text = "Putar 90 Derajat"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(154, 6)
        ' 
        ' FlipHorizontalToolStripMenuItem
        ' 
        FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        FlipHorizontalToolStripMenuItem.Size = New Size(157, 22)
        FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        ' 
        ' FlipVerticalToolStripMenuItem
        ' 
        FlipVerticalToolStripMenuItem.Name = "FlipVerticalToolStripMenuItem"
        FlipVerticalToolStripMenuItem.Size = New Size(157, 22)
        FlipVerticalToolStripMenuItem.Text = "Flip  Vertical"
        ' 
        ' Tugas3ToolStripMenuItem
        ' 
        Tugas3ToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BorderToolStripMenuItem, WaterMarkToolStripMenuItem, InversiWarnaToolStripMenuItem, RonaMerahToolStripMenuItem, RonaHijauToolStripMenuItem, RonaBiruToolStripMenuItem, RonaSpesialToolStripMenuItem, HistogramBalokToolStripMenuItem})
        Tugas3ToolStripMenuItem.Name = "Tugas3ToolStripMenuItem"
        Tugas3ToolStripMenuItem.Size = New Size(59, 20)
        Tugas3ToolStripMenuItem.Text = "Tugas 3"
        ' 
        ' BorderToolStripMenuItem
        ' 
        BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        BorderToolStripMenuItem.Size = New Size(180, 22)
        BorderToolStripMenuItem.Text = "Border"
        ' 
        ' WaterMarkToolStripMenuItem
        ' 
        WaterMarkToolStripMenuItem.Name = "WaterMarkToolStripMenuItem"
        WaterMarkToolStripMenuItem.Size = New Size(180, 22)
        WaterMarkToolStripMenuItem.Text = "WaterMark"
        ' 
        ' InversiWarnaToolStripMenuItem
        ' 
        InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        InversiWarnaToolStripMenuItem.Size = New Size(180, 22)
        InversiWarnaToolStripMenuItem.Text = "Inversi Warna"
        ' 
        ' RonaMerahToolStripMenuItem
        ' 
        RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        RonaMerahToolStripMenuItem.Size = New Size(180, 22)
        RonaMerahToolStripMenuItem.Text = "Rona Merah"
        ' 
        ' RonaHijauToolStripMenuItem
        ' 
        RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        RonaHijauToolStripMenuItem.Size = New Size(180, 22)
        RonaHijauToolStripMenuItem.Text = "Rona  Hijau"
        ' 
        ' RonaBiruToolStripMenuItem
        ' 
        RonaBiruToolStripMenuItem.Name = "RonaBiruToolStripMenuItem"
        RonaBiruToolStripMenuItem.Size = New Size(180, 22)
        RonaBiruToolStripMenuItem.Text = "Rona Biru "
        ' 
        ' RonaSpesialToolStripMenuItem
        ' 
        RonaSpesialToolStripMenuItem.Name = "RonaSpesialToolStripMenuItem"
        RonaSpesialToolStripMenuItem.Size = New Size(180, 22)
        RonaSpesialToolStripMenuItem.Text = "Rona Spesial"
        ' 
        ' HistogramBalokToolStripMenuItem
        ' 
        HistogramBalokToolStripMenuItem.Name = "HistogramBalokToolStripMenuItem"
        HistogramBalokToolStripMenuItem.Size = New Size(180, 22)
        HistogramBalokToolStripMenuItem.Text = "Histogram Balok"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 367)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TrackBarBlue)
        Panel1.Controls.Add(TrackBarGreen)
        Panel1.Controls.Add(TrackBarRed)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 390)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 60)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(685, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 5
        Label3.Text = "Blue"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(386, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 4
        Label2.Text = "Green"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 15)
        Label1.TabIndex = 3
        Label1.Text = "Red"
        ' 
        ' TrackBarBlue
        ' 
        TrackBarBlue.Location = New Point(596, 8)
        TrackBarBlue.Maximum = 100
        TrackBarBlue.Name = "TrackBarBlue"
        TrackBarBlue.Size = New Size(192, 45)
        TrackBarBlue.TabIndex = 2
        TrackBarBlue.Value = 100
        ' 
        ' TrackBarGreen
        ' 
        TrackBarGreen.Location = New Point(304, 8)
        TrackBarGreen.Maximum = 100
        TrackBarGreen.Name = "TrackBarGreen"
        TrackBarGreen.Size = New Size(192, 45)
        TrackBarGreen.TabIndex = 1
        TrackBarGreen.Value = 100
        ' 
        ' TrackBarRed
        ' 
        TrackBarRed.Location = New Point(12, 8)
        TrackBarRed.Maximum = 100
        TrackBarRed.Name = "TrackBarRed"
        TrackBarRed.Size = New Size(192, 45)
        TrackBarRed.TabIndex = 0
        TrackBarRed.Value = 100
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(TrackBarBlue, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBarGreen, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBarRed, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents Putar90DerajatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tugas3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WaterMarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBiruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpesialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramBalokToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TrackBarRed As TrackBar
    Friend WithEvents TrackBarBlue As TrackBar
    Friend WithEvents TrackBarGreen As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
