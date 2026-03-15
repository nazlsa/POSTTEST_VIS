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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PicProfil = New PictureBox()
        btnBrowse = New Button()
        lblNama = New Label()
        lblUmur = New Label()
        lblTglLhr = New Label()
        lblTlp = New Label()
        lblAgama = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelp = New TextBox()
        gbHobi = New GroupBox()
        cbBuku = New CheckBox()
        cbFoto = New CheckBox()
        cbMusik = New CheckBox()
        cbKebun = New CheckBox()
        cbGaming = New CheckBox()
        cbCoding = New CheckBox()
        cbTraveling = New CheckBox()
        cbGambar = New CheckBox()
        cbNari = New CheckBox()
        cbNulis = New CheckBox()
        cbFilm = New CheckBox()
        cbMancing = New CheckBox()
        cbNyanyi = New CheckBox()
        cbBaca = New CheckBox()
        cbOlahraga = New CheckBox()
        btnCetak = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        cbxAgama = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbJK = New GroupBox()
        PictureBox1 = New PictureBox()
        dtpTgl = New DateTimePicker()
        CType(PicProfil, ComponentModel.ISupportInitialize).BeginInit()
        gbHobi.SuspendLayout()
        gbJK.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicProfil
        ' 
        PicProfil.Location = New Point(90, 60)
        PicProfil.Name = "PicProfil"
        PicProfil.Size = New Size(324, 506)
        PicProfil.SizeMode = PictureBoxSizeMode.StretchImage
        PicProfil.TabIndex = 0
        PicProfil.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = SystemColors.ActiveCaption
        btnBrowse.Location = New Point(190, 572)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(98, 43)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(478, 69)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 23)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Location = New Point(478, 112)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(53, 23)
        lblUmur.TabIndex = 3
        lblUmur.Text = "Umur"
        ' 
        ' lblTglLhr
        ' 
        lblTglLhr.AutoSize = True
        lblTglLhr.BackColor = Color.Transparent
        lblTglLhr.Location = New Point(478, 156)
        lblTglLhr.Name = "lblTglLhr"
        lblTglLhr.Size = New Size(111, 23)
        lblTglLhr.TabIndex = 4
        lblTglLhr.Text = "Tanggal Lahir"
        ' 
        ' lblTlp
        ' 
        lblTlp.AutoSize = True
        lblTlp.BackColor = Color.Transparent
        lblTlp.Location = New Point(479, 207)
        lblTlp.Name = "lblTlp"
        lblTlp.RightToLeft = RightToLeft.Yes
        lblTlp.Size = New Size(96, 23)
        lblTlp.TabIndex = 5
        lblTlp.Text = "No.Telepon"
        ' 
        ' lblAgama
        ' 
        lblAgama.AutoSize = True
        lblAgama.BackColor = Color.Transparent
        lblAgama.Location = New Point(482, 256)
        lblAgama.Name = "lblAgama"
        lblAgama.Size = New Size(64, 23)
        lblAgama.TabIndex = 6
        lblAgama.Text = "Agama"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = SystemColors.ActiveCaption
        txtNama.Location = New Point(708, 69)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(383, 30)
        txtNama.TabIndex = 7
        ' 
        ' txtUmur
        ' 
        txtUmur.BackColor = SystemColors.ActiveCaption
        txtUmur.Location = New Point(708, 105)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(383, 30)
        txtUmur.TabIndex = 8
        ' 
        ' txtTelp
        ' 
        txtTelp.BackColor = SystemColors.ActiveCaption
        txtTelp.Location = New Point(708, 200)
        txtTelp.Name = "txtTelp"
        txtTelp.Size = New Size(383, 30)
        txtTelp.TabIndex = 9
        ' 
        ' gbHobi
        ' 
        gbHobi.BackColor = Color.AntiqueWhite
        gbHobi.BackgroundImage = CType(resources.GetObject("gbHobi.BackgroundImage"), Image)
        gbHobi.Controls.Add(cbBuku)
        gbHobi.Controls.Add(cbFoto)
        gbHobi.Controls.Add(cbMusik)
        gbHobi.Controls.Add(cbKebun)
        gbHobi.Controls.Add(cbGaming)
        gbHobi.Controls.Add(cbCoding)
        gbHobi.Controls.Add(cbTraveling)
        gbHobi.Controls.Add(cbGambar)
        gbHobi.Controls.Add(cbNari)
        gbHobi.Controls.Add(cbNulis)
        gbHobi.Controls.Add(cbFilm)
        gbHobi.Controls.Add(cbMancing)
        gbHobi.Controls.Add(cbNyanyi)
        gbHobi.Controls.Add(cbBaca)
        gbHobi.Controls.Add(cbOlahraga)
        gbHobi.Location = New Point(756, 379)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(496, 235)
        gbHobi.TabIndex = 12
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbBuku
        ' 
        cbBuku.AutoSize = True
        cbBuku.BackColor = Color.Transparent
        cbBuku.Location = New Point(327, 168)
        cbBuku.Name = "cbBuku"
        cbBuku.Size = New Size(127, 27)
        cbBuku.TabIndex = 29
        cbBuku.Text = "Koleksi Buku"
        cbBuku.UseVisualStyleBackColor = False
        ' 
        ' cbFoto
        ' 
        cbFoto.AutoSize = True
        cbFoto.BackColor = Color.Transparent
        cbFoto.Location = New Point(327, 137)
        cbFoto.Name = "cbFoto"
        cbFoto.Size = New Size(100, 27)
        cbFoto.TabIndex = 28
        cbFoto.Text = "Fotografi"
        cbFoto.UseVisualStyleBackColor = False
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.BackColor = Color.Transparent
        cbMusik.Location = New Point(327, 101)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(169, 27)
        cbMusik.TabIndex = 27
        cbMusik.Text = "Mendengar Musik"
        cbMusik.UseVisualStyleBackColor = False
        ' 
        ' cbKebun
        ' 
        cbKebun.AutoSize = True
        cbKebun.BackColor = Color.Transparent
        cbKebun.Location = New Point(327, 68)
        cbKebun.Name = "cbKebun"
        cbKebun.Size = New Size(104, 27)
        cbKebun.TabIndex = 26
        cbKebun.Text = "Berkebun"
        cbKebun.UseVisualStyleBackColor = False
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.BackColor = Color.Transparent
        cbGaming.Location = New Point(15, 34)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(92, 27)
        cbGaming.TabIndex = 15
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = False
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.BackColor = Color.Transparent
        cbCoding.Location = New Point(15, 67)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(87, 27)
        cbCoding.TabIndex = 16
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = False
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.BackColor = Color.Transparent
        cbTraveling.Location = New Point(15, 101)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(100, 27)
        cbTraveling.TabIndex = 17
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = False
        ' 
        ' cbGambar
        ' 
        cbGambar.AutoSize = True
        cbGambar.BackColor = Color.Transparent
        cbGambar.Location = New Point(15, 135)
        cbGambar.Name = "cbGambar"
        cbGambar.Size = New Size(135, 27)
        cbGambar.TabIndex = 18
        cbGambar.Text = "Menggambar"
        cbGambar.UseVisualStyleBackColor = False
        ' 
        ' cbNari
        ' 
        cbNari.AutoSize = True
        cbNari.BackColor = Color.Transparent
        cbNari.Location = New Point(327, 35)
        cbNari.Name = "cbNari"
        cbNari.Size = New Size(85, 27)
        cbNari.TabIndex = 25
        cbNari.Text = "Menari"
        cbNari.UseVisualStyleBackColor = False
        ' 
        ' cbNulis
        ' 
        cbNulis.AutoSize = True
        cbNulis.BackColor = Color.Transparent
        cbNulis.Location = New Point(15, 168)
        cbNulis.Name = "cbNulis"
        cbNulis.Size = New Size(91, 27)
        cbNulis.TabIndex = 19
        cbNulis.Text = "Menulis"
        cbNulis.UseVisualStyleBackColor = False
        ' 
        ' cbFilm
        ' 
        cbFilm.AutoSize = True
        cbFilm.BackColor = Color.Transparent
        cbFilm.Location = New Point(173, 168)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(148, 27)
        cbFilm.TabIndex = 24
        cbFilm.Text = "Menonton Film"
        cbFilm.UseVisualStyleBackColor = False
        ' 
        ' cbMancing
        ' 
        cbMancing.AutoSize = True
        cbMancing.BackColor = Color.Transparent
        cbMancing.Location = New Point(172, 35)
        cbMancing.Name = "cbMancing"
        cbMancing.Size = New Size(122, 27)
        cbMancing.TabIndex = 20
        cbMancing.Text = "Memancing"
        cbMancing.UseVisualStyleBackColor = False
        ' 
        ' cbNyanyi
        ' 
        cbNyanyi.AutoSize = True
        cbNyanyi.BackColor = Color.Transparent
        cbNyanyi.Location = New Point(172, 134)
        cbNyanyi.Name = "cbNyanyi"
        cbNyanyi.Size = New Size(105, 27)
        cbNyanyi.TabIndex = 23
        cbNyanyi.Text = "Menyanyi"
        cbNyanyi.UseVisualStyleBackColor = False
        ' 
        ' cbBaca
        ' 
        cbBaca.AutoSize = True
        cbBaca.BackColor = Color.Transparent
        cbBaca.Location = New Point(172, 68)
        cbBaca.Name = "cbBaca"
        cbBaca.Size = New Size(107, 27)
        cbBaca.TabIndex = 21
        cbBaca.Text = "Membaca"
        cbBaca.UseVisualStyleBackColor = False
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.BackColor = Color.Transparent
        cbOlahraga.Location = New Point(172, 101)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(102, 27)
        cbOlahraga.TabIndex = 22
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = False
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = SystemColors.ActiveCaption
        btnCetak.Location = New Point(443, 620)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(809, 29)
        btnCetak.TabIndex = 27
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Location = New Point(482, 311)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(64, 23)
        lblAlamat.TabIndex = 28
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = SystemColors.ActiveCaption
        txtAlamat.Location = New Point(708, 304)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(383, 30)
        txtAlamat.TabIndex = 29
        ' 
        ' cbxAgama
        ' 
        cbxAgama.BackColor = SystemColors.ActiveCaption
        cbxAgama.FormattingEnabled = True
        cbxAgama.Items.AddRange(New Object() {"Islam", "Kristen ", "Katolik", "Hindu", "Buddha", "Konghucu"})
        cbxAgama.Location = New Point(708, 248)
        cbxAgama.Name = "cbxAgama"
        cbxAgama.Size = New Size(383, 31)
        cbxAgama.TabIndex = 30
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(28, 67)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(118, 27)
        rbPerempuan.TabIndex = 14
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(28, 34)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(96, 27)
        rbLaki.TabIndex = 13
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbJK
        ' 
        gbJK.BackColor = Color.Transparent
        gbJK.BackgroundImage = CType(resources.GetObject("gbJK.BackgroundImage"), Image)
        gbJK.Controls.Add(rbLaki)
        gbJK.Controls.Add(rbPerempuan)
        gbJK.Location = New Point(443, 379)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(291, 235)
        gbJK.TabIndex = 11
        gbJK.TabStop = False
        gbJK.Text = "Jenis Kelamin"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1127, 60)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 127)
        PictureBox1.TabIndex = 31
        PictureBox1.TabStop = False
        ' 
        ' dtpTgl
        ' 
        dtpTgl.Location = New Point(708, 149)
        dtpTgl.Name = "dtpTgl"
        dtpTgl.Size = New Size(383, 30)
        dtpTgl.TabIndex = 32
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1350, 746)
        Controls.Add(dtpTgl)
        Controls.Add(PictureBox1)
        Controls.Add(cbxAgama)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(btnCetak)
        Controls.Add(gbHobi)
        Controls.Add(gbJK)
        Controls.Add(txtTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(lblAgama)
        Controls.Add(lblTlp)
        Controls.Add(lblTglLhr)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(btnBrowse)
        Controls.Add(PicProfil)
        Name = "Form1"
        Text = "Form1"
        CType(PicProfil, ComponentModel.ISupportInitialize).EndInit()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTglLhr As Label
    Friend WithEvents lblTlp As Label
    Friend WithEvents lblAgama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbGambar As CheckBox
    Friend WithEvents cbNulis As CheckBox
    Friend WithEvents cbMancing As CheckBox
    Friend WithEvents cbBaca As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbNyanyi As CheckBox
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents cbNari As CheckBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cbBuku As CheckBox
    Friend WithEvents cbFoto As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbKebun As CheckBox
    Friend WithEvents cbxAgama As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpTgl As DateTimePicker

End Class
