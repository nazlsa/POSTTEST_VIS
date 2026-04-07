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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        tcData = New TabControl()
        tpData = New TabPage()
        Label6 = New Label()
        rbLk = New RadioButton()
        lbJko = New Label()
        lbJk = New Label()
        lbTgl = New Label()
        lbID = New Label()
        lbNama = New Label()
        cbxK = New ComboBox()
        rbPr = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        tbxId = New TextBox()
        tbxNama = New TextBox()
        tpKontak = New TabPage()
        tbxAlamat = New TextBox()
        cbxGenre = New ComboBox()
        tbxMedsos = New TextBox()
        lbMedsos = New Label()
        lbGf = New Label()
        Label10 = New Label()
        lbAlamat = New Label()
        lbEmail = New Label()
        lbHp = New Label()
        tbxEmail = New TextBox()
        mtbTelp = New MaskedTextBox()
        tpProfil = New TabPage()
        Label13 = New Label()
        gbHobi = New GroupBox()
        cbxKebun = New CheckBox()
        cbxNgoding = New CheckBox()
        cbxGame = New CheckBox()
        cbxOlahraga = New CheckBox()
        cbxMasak = New CheckBox()
        cbxNulis = New CheckBox()
        cbxBaca = New CheckBox()
        cbxFoto = New CheckBox()
        cbxTari = New CheckBox()
        cbxLukis = New CheckBox()
        cbxMancing = New CheckBox()
        cbxNyanyi = New CheckBox()
        btnSimpan = New Button()
        gbPeran = New GroupBox()
        cbxKb = New CheckBox()
        cbxMd = New CheckBox()
        cbxKetua = New CheckBox()
        cbxAdmin = New CheckBox()
        cbxAnggota = New CheckBox()
        btnUp = New Button()
        PictureBox2 = New PictureBox()
        tpStatistik = New TabPage()
        cbxProgres = New ComboBox()
        cbxLevel = New ComboBox()
        tbxTarget = New TextBox()
        tbxTerakhir = New TextBox()
        tbxJumlah = New TextBox()
        lbBt = New Label()
        lbLp = New Label()
        lbPm = New Label()
        lbTm = New Label()
        lbTb = New Label()
        Label14 = New Label()
        tpRiwayat = New TabPage()
        lbEvent = New ListBox()
        btnTambah = New Button()
        DateTimePicker2 = New DateTimePicker()
        tbxEvent = New TextBox()
        Label22 = New Label()
        Label21 = New Label()
        Label20 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        tcData.SuspendLayout()
        tpData.SuspendLayout()
        tpKontak.SuspendLayout()
        tpProfil.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        tpStatistik.SuspendLayout()
        tpRiwayat.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(898, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 26)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(119, 26)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(128, 26)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 26)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(79, 26)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' tcData
        ' 
        tcData.Controls.Add(tpData)
        tcData.Controls.Add(tpKontak)
        tcData.Controls.Add(tpProfil)
        tcData.Controls.Add(tpStatistik)
        tcData.Controls.Add(tpRiwayat)
        tcData.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tcData.Location = New Point(12, 58)
        tcData.Name = "tcData"
        tcData.SelectedIndex = 0
        tcData.Size = New Size(728, 549)
        tcData.TabIndex = 1
        ' 
        ' tpData
        ' 
        tpData.BackgroundImage = CType(resources.GetObject("tpData.BackgroundImage"), Image)
        tpData.BackgroundImageLayout = ImageLayout.Stretch
        tpData.Controls.Add(Label6)
        tpData.Controls.Add(rbLk)
        tpData.Controls.Add(lbJko)
        tpData.Controls.Add(lbJk)
        tpData.Controls.Add(lbTgl)
        tpData.Controls.Add(lbID)
        tpData.Controls.Add(lbNama)
        tpData.Controls.Add(cbxK)
        tpData.Controls.Add(rbPr)
        tpData.Controls.Add(DateTimePicker1)
        tpData.Controls.Add(tbxId)
        tpData.Controls.Add(tbxNama)
        tpData.Location = New Point(4, 31)
        tpData.Name = "tpData"
        tpData.Padding = New Padding(3)
        tpData.Size = New Size(720, 514)
        tpData.TabIndex = 0
        tpData.Text = "Data Utama"
        tpData.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(177, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(327, 32)
        Label6.TabIndex = 11
        Label6.Text = "BOOK CLUB MEMBER"
        ' 
        ' rbLk
        ' 
        rbLk.AutoSize = True
        rbLk.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        rbLk.Location = New Point(466, 293)
        rbLk.Name = "rbLk"
        rbLk.Size = New Size(104, 26)
        rbLk.TabIndex = 10
        rbLk.TabStop = True
        rbLk.Text = "Laki-laki"
        rbLk.UseVisualStyleBackColor = True
        ' 
        ' lbJko
        ' 
        lbJko.AutoSize = True
        lbJko.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbJko.Location = New Point(70, 353)
        lbJko.Name = "lbJko"
        lbJko.Size = New Size(149, 22)
        lbJko.TabIndex = 9
        lbJko.Text = "Jenis Komunitas:"
        ' 
        ' lbJk
        ' 
        lbJk.AutoSize = True
        lbJk.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbJk.Location = New Point(70, 295)
        lbJk.Name = "lbJk"
        lbJk.Size = New Size(129, 22)
        lbJk.TabIndex = 8
        lbJk.Text = "Jenis Kelamin:"
        ' 
        ' lbTgl
        ' 
        lbTgl.AutoSize = True
        lbTgl.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbTgl.Location = New Point(70, 229)
        lbTgl.Name = "lbTgl"
        lbTgl.Size = New Size(96, 22)
        lbTgl.TabIndex = 7
        lbTgl.Text = "Tgl. Lahir:"
        ' 
        ' lbID
        ' 
        lbID.AutoSize = True
        lbID.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbID.Location = New Point(70, 172)
        lbID.Name = "lbID"
        lbID.Size = New Size(107, 22)
        lbID.TabIndex = 6
        lbID.Text = "ID Anggota:"
        ' 
        ' lbNama
        ' 
        lbNama.AutoSize = True
        lbNama.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbNama.Location = New Point(70, 111)
        lbNama.Name = "lbNama"
        lbNama.Size = New Size(135, 22)
        lbNama.TabIndex = 5
        lbNama.Text = "Nama Lengkap:"
        ' 
        ' cbxK
        ' 
        cbxK.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxK.FormattingEnabled = True
        cbxK.Location = New Point(236, 350)
        cbxK.Name = "cbxK"
        cbxK.Size = New Size(322, 30)
        cbxK.TabIndex = 4
        ' 
        ' rbPr
        ' 
        rbPr.AutoSize = True
        rbPr.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        rbPr.Location = New Point(236, 293)
        rbPr.Name = "rbPr"
        rbPr.Size = New Size(125, 26)
        rbPr.TabIndex = 3
        rbPr.TabStop = True
        rbPr.Text = "Perempuan"
        rbPr.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        DateTimePicker1.Location = New Point(236, 229)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(322, 30)
        DateTimePicker1.TabIndex = 2
        ' 
        ' tbxId
        ' 
        tbxId.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxId.Location = New Point(236, 169)
        tbxId.Name = "tbxId"
        tbxId.PlaceholderText = "Id Anggota"
        tbxId.Size = New Size(322, 30)
        tbxId.TabIndex = 1
        ' 
        ' tbxNama
        ' 
        tbxNama.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxNama.Location = New Point(236, 111)
        tbxNama.Name = "tbxNama"
        tbxNama.PlaceholderText = "Nama"
        tbxNama.Size = New Size(322, 30)
        tbxNama.TabIndex = 0
        ' 
        ' tpKontak
        ' 
        tpKontak.BackgroundImage = CType(resources.GetObject("tpKontak.BackgroundImage"), Image)
        tpKontak.Controls.Add(tbxAlamat)
        tpKontak.Controls.Add(cbxGenre)
        tpKontak.Controls.Add(tbxMedsos)
        tpKontak.Controls.Add(lbMedsos)
        tpKontak.Controls.Add(lbGf)
        tpKontak.Controls.Add(Label10)
        tpKontak.Controls.Add(lbAlamat)
        tpKontak.Controls.Add(lbEmail)
        tpKontak.Controls.Add(lbHp)
        tpKontak.Controls.Add(tbxEmail)
        tpKontak.Controls.Add(mtbTelp)
        tpKontak.Location = New Point(4, 32)
        tpKontak.Name = "tpKontak"
        tpKontak.Padding = New Padding(3)
        tpKontak.Size = New Size(720, 513)
        tpKontak.TabIndex = 1
        tpKontak.Text = "Kontak & Info"
        tpKontak.UseVisualStyleBackColor = True
        ' 
        ' tbxAlamat
        ' 
        tbxAlamat.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxAlamat.Location = New Point(272, 231)
        tbxAlamat.Name = "tbxAlamat"
        tbxAlamat.PlaceholderText = "Alamat"
        tbxAlamat.Size = New Size(322, 30)
        tbxAlamat.TabIndex = 13
        ' 
        ' cbxGenre
        ' 
        cbxGenre.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxGenre.FormattingEnabled = True
        cbxGenre.Location = New Point(272, 292)
        cbxGenre.Name = "cbxGenre"
        cbxGenre.Size = New Size(322, 30)
        cbxGenre.TabIndex = 12
        ' 
        ' tbxMedsos
        ' 
        tbxMedsos.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxMedsos.Location = New Point(272, 349)
        tbxMedsos.Name = "tbxMedsos"
        tbxMedsos.PlaceholderText = "Media Sosial"
        tbxMedsos.Size = New Size(322, 30)
        tbxMedsos.TabIndex = 11
        ' 
        ' lbMedsos
        ' 
        lbMedsos.AutoSize = True
        lbMedsos.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbMedsos.Location = New Point(105, 352)
        lbMedsos.Name = "lbMedsos"
        lbMedsos.Size = New Size(117, 22)
        lbMedsos.TabIndex = 8
        lbMedsos.Text = "Media Sosial:"
        ' 
        ' lbGf
        ' 
        lbGf.AutoSize = True
        lbGf.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbGf.Location = New Point(105, 300)
        lbGf.Name = "lbGf"
        lbGf.Size = New Size(139, 22)
        lbGf.TabIndex = 7
        lbGf.Text = "Genre Favorite:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(194, 37)
        Label10.Name = "Label10"
        Label10.Size = New Size(327, 32)
        Label10.TabIndex = 6
        Label10.Text = "BOOK CLUB MEMBER"
        ' 
        ' lbAlamat
        ' 
        lbAlamat.AutoSize = True
        lbAlamat.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbAlamat.Location = New Point(105, 238)
        lbAlamat.Name = "lbAlamat"
        lbAlamat.Size = New Size(75, 22)
        lbAlamat.TabIndex = 5
        lbAlamat.Text = "Alamat:"
        ' 
        ' lbEmail
        ' 
        lbEmail.AutoSize = True
        lbEmail.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbEmail.Location = New Point(105, 181)
        lbEmail.Name = "lbEmail"
        lbEmail.Size = New Size(63, 22)
        lbEmail.TabIndex = 4
        lbEmail.Text = "Email:"
        ' 
        ' lbHp
        ' 
        lbHp.AutoSize = True
        lbHp.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbHp.Location = New Point(105, 116)
        lbHp.Name = "lbHp"
        lbHp.Size = New Size(115, 22)
        lbHp.TabIndex = 3
        lbHp.Text = "No. Telepon:"
        ' 
        ' tbxEmail
        ' 
        tbxEmail.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxEmail.Location = New Point(272, 174)
        tbxEmail.Name = "tbxEmail"
        tbxEmail.PlaceholderText = "Email"
        tbxEmail.Size = New Size(322, 30)
        tbxEmail.TabIndex = 2
        ' 
        ' mtbTelp
        ' 
        mtbTelp.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        mtbTelp.Location = New Point(272, 109)
        mtbTelp.Mask = "000-000-0000"
        mtbTelp.Name = "mtbTelp"
        mtbTelp.Size = New Size(322, 30)
        mtbTelp.TabIndex = 0
        ' 
        ' tpProfil
        ' 
        tpProfil.BackgroundImage = CType(resources.GetObject("tpProfil.BackgroundImage"), Image)
        tpProfil.Controls.Add(Label13)
        tpProfil.Controls.Add(gbHobi)
        tpProfil.Controls.Add(btnSimpan)
        tpProfil.Controls.Add(gbPeran)
        tpProfil.Controls.Add(btnUp)
        tpProfil.Controls.Add(PictureBox2)
        tpProfil.Location = New Point(4, 32)
        tpProfil.Name = "tpProfil"
        tpProfil.Padding = New Padding(3)
        tpProfil.Size = New Size(720, 513)
        tpProfil.TabIndex = 2
        tpProfil.Text = "Profil & Aktivitas"
        tpProfil.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(193, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(327, 32)
        Label13.TabIndex = 15
        Label13.Text = "BOOK CLUB MEMBER"
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(cbxKebun)
        gbHobi.Controls.Add(cbxNgoding)
        gbHobi.Controls.Add(cbxGame)
        gbHobi.Controls.Add(cbxOlahraga)
        gbHobi.Controls.Add(cbxMasak)
        gbHobi.Controls.Add(cbxNulis)
        gbHobi.Controls.Add(cbxBaca)
        gbHobi.Controls.Add(cbxFoto)
        gbHobi.Controls.Add(cbxTari)
        gbHobi.Controls.Add(cbxLukis)
        gbHobi.Controls.Add(cbxMancing)
        gbHobi.Controls.Add(cbxNyanyi)
        gbHobi.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbHobi.Location = New Point(294, 233)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(401, 230)
        gbHobi.TabIndex = 14
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' cbxKebun
        ' 
        cbxKebun.AutoSize = True
        cbxKebun.Location = New Point(265, 176)
        cbxKebun.Name = "cbxKebun"
        cbxKebun.Size = New Size(111, 26)
        cbxKebun.TabIndex = 17
        cbxKebun.Text = "Berkebun"
        cbxKebun.UseVisualStyleBackColor = True
        ' 
        ' cbxNgoding
        ' 
        cbxNgoding.AutoSize = True
        cbxNgoding.Location = New Point(265, 132)
        cbxNgoding.Name = "cbxNgoding"
        cbxNgoding.Size = New Size(100, 26)
        cbxNgoding.TabIndex = 16
        cbxNgoding.Text = "Ngoding"
        cbxNgoding.UseVisualStyleBackColor = True
        ' 
        ' cbxGame
        ' 
        cbxGame.AutoSize = True
        cbxGame.Location = New Point(265, 86)
        cbxGame.Name = "cbxGame"
        cbxGame.Size = New Size(94, 26)
        cbxGame.TabIndex = 15
        cbxGame.Text = "Gamers"
        cbxGame.UseVisualStyleBackColor = True
        ' 
        ' cbxOlahraga
        ' 
        cbxOlahraga.AutoSize = True
        cbxOlahraga.Location = New Point(265, 44)
        cbxOlahraga.Name = "cbxOlahraga"
        cbxOlahraga.Size = New Size(107, 26)
        cbxOlahraga.TabIndex = 14
        cbxOlahraga.Text = "Olahraga"
        cbxOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbxMasak
        ' 
        cbxMasak.AutoSize = True
        cbxMasak.Location = New Point(141, 132)
        cbxMasak.Name = "cbxMasak"
        cbxMasak.Size = New Size(108, 26)
        cbxMasak.TabIndex = 13
        cbxMasak.Text = "Memasak"
        cbxMasak.UseVisualStyleBackColor = True
        ' 
        ' cbxNulis
        ' 
        cbxNulis.AutoSize = True
        cbxNulis.Location = New Point(20, 44)
        cbxNulis.Name = "cbxNulis"
        cbxNulis.Size = New Size(98, 26)
        cbxNulis.TabIndex = 6
        cbxNulis.Text = "Menulis"
        cbxNulis.UseVisualStyleBackColor = True
        ' 
        ' cbxBaca
        ' 
        cbxBaca.AutoSize = True
        cbxBaca.Location = New Point(20, 86)
        cbxBaca.Name = "cbxBaca"
        cbxBaca.Size = New Size(110, 26)
        cbxBaca.TabIndex = 8
        cbxBaca.Text = "Membaca"
        cbxBaca.UseVisualStyleBackColor = True
        ' 
        ' cbxFoto
        ' 
        cbxFoto.AutoSize = True
        cbxFoto.Location = New Point(141, 176)
        cbxFoto.Name = "cbxFoto"
        cbxFoto.Size = New Size(105, 26)
        cbxFoto.TabIndex = 11
        cbxFoto.Text = "Fotografi"
        cbxFoto.UseVisualStyleBackColor = True
        ' 
        ' cbxTari
        ' 
        cbxTari.AutoSize = True
        cbxTari.Location = New Point(141, 44)
        cbxTari.Name = "cbxTari"
        cbxTari.Size = New Size(91, 26)
        cbxTari.TabIndex = 10
        cbxTari.Text = "Menari"
        cbxTari.UseVisualStyleBackColor = True
        ' 
        ' cbxLukis
        ' 
        cbxLukis.AutoSize = True
        cbxLukis.Location = New Point(20, 176)
        cbxLukis.Name = "cbxLukis"
        cbxLukis.Size = New Size(97, 26)
        cbxLukis.TabIndex = 9
        cbxLukis.Text = "Melukis"
        cbxLukis.UseVisualStyleBackColor = True
        ' 
        ' cbxMancing
        ' 
        cbxMancing.AutoSize = True
        cbxMancing.Location = New Point(141, 86)
        cbxMancing.Name = "cbxMancing"
        cbxMancing.Size = New Size(128, 26)
        cbxMancing.TabIndex = 12
        cbxMancing.Text = "Memancing"
        cbxMancing.UseVisualStyleBackColor = True
        ' 
        ' cbxNyanyi
        ' 
        cbxNyanyi.AutoSize = True
        cbxNyanyi.Location = New Point(20, 132)
        cbxNyanyi.Name = "cbxNyanyi"
        cbxNyanyi.Size = New Size(114, 26)
        cbxNyanyi.TabIndex = 7
        cbxNyanyi.Text = "Menyanyi"
        cbxNyanyi.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(20, 478)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(678, 29)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan "
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(cbxKb)
        gbPeran.Controls.Add(cbxMd)
        gbPeran.Controls.Add(cbxKetua)
        gbPeran.Controls.Add(cbxAdmin)
        gbPeran.Controls.Add(cbxAnggota)
        gbPeran.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbPeran.Location = New Point(297, 86)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(398, 141)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Peran"
        ' 
        ' cbxKb
        ' 
        cbxKb.AutoSize = True
        cbxKb.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxKb.Location = New Point(247, 91)
        cbxKb.Name = "cbxKb"
        cbxKb.Size = New Size(145, 26)
        cbxKb.TabIndex = 7
        cbxKb.Text = "Kurator Buku"
        cbxKb.UseVisualStyleBackColor = True
        ' 
        ' cbxMd
        ' 
        cbxMd.AutoSize = True
        cbxMd.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxMd.Location = New Point(17, 91)
        cbxMd.Name = "cbxMd"
        cbxMd.Size = New Size(184, 26)
        cbxMd.TabIndex = 6
        cbxMd.Text = "Moderator Diskusi"
        cbxMd.UseVisualStyleBackColor = True
        ' 
        ' cbxKetua
        ' 
        cbxKetua.AutoSize = True
        cbxKetua.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxKetua.Location = New Point(17, 42)
        cbxKetua.Name = "cbxKetua"
        cbxKetua.Size = New Size(80, 26)
        cbxKetua.TabIndex = 3
        cbxKetua.Text = "Ketua"
        cbxKetua.UseVisualStyleBackColor = True
        ' 
        ' cbxAdmin
        ' 
        cbxAdmin.AutoSize = True
        cbxAdmin.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxAdmin.Location = New Point(138, 42)
        cbxAdmin.Name = "cbxAdmin"
        cbxAdmin.Size = New Size(88, 26)
        cbxAdmin.TabIndex = 4
        cbxAdmin.Text = "Admin"
        cbxAdmin.UseVisualStyleBackColor = True
        ' 
        ' cbxAnggota
        ' 
        cbxAnggota.AutoSize = True
        cbxAnggota.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxAnggota.Location = New Point(262, 42)
        cbxAnggota.Name = "cbxAnggota"
        cbxAnggota.Size = New Size(100, 26)
        cbxAnggota.TabIndex = 5
        cbxAnggota.Text = "Anggota"
        cbxAnggota.UseVisualStyleBackColor = True
        ' 
        ' btnUp
        ' 
        btnUp.Font = New Font("Sylfaen", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUp.Location = New Point(128, 317)
        btnUp.Name = "btnUp"
        btnUp.Size = New Size(94, 29)
        btnUp.TabIndex = 1
        btnUp.Text = "Upload"
        btnUp.UseVisualStyleBackColor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(54, 94)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(234, 210)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' tpStatistik
        ' 
        tpStatistik.BackgroundImage = CType(resources.GetObject("tpStatistik.BackgroundImage"), Image)
        tpStatistik.Controls.Add(cbxProgres)
        tpStatistik.Controls.Add(cbxLevel)
        tpStatistik.Controls.Add(tbxTarget)
        tpStatistik.Controls.Add(tbxTerakhir)
        tpStatistik.Controls.Add(tbxJumlah)
        tpStatistik.Controls.Add(lbBt)
        tpStatistik.Controls.Add(lbLp)
        tpStatistik.Controls.Add(lbPm)
        tpStatistik.Controls.Add(lbTm)
        tpStatistik.Controls.Add(lbTb)
        tpStatistik.Controls.Add(Label14)
        tpStatistik.Location = New Point(4, 32)
        tpStatistik.Name = "tpStatistik"
        tpStatistik.Padding = New Padding(3)
        tpStatistik.Size = New Size(720, 513)
        tpStatistik.TabIndex = 3
        tpStatistik.Text = "Statistik Membaca"
        tpStatistik.UseVisualStyleBackColor = True
        ' 
        ' cbxProgres
        ' 
        cbxProgres.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxProgres.FormattingEnabled = True
        cbxProgres.Location = New Point(317, 236)
        cbxProgres.Name = "cbxProgres"
        cbxProgres.Size = New Size(322, 30)
        cbxProgres.TabIndex = 11
        ' 
        ' cbxLevel
        ' 
        cbxLevel.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        cbxLevel.FormattingEnabled = True
        cbxLevel.Location = New Point(317, 306)
        cbxLevel.Name = "cbxLevel"
        cbxLevel.Size = New Size(322, 30)
        cbxLevel.TabIndex = 10
        ' 
        ' tbxTarget
        ' 
        tbxTarget.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxTarget.Location = New Point(317, 177)
        tbxTarget.Name = "tbxTarget"
        tbxTarget.PlaceholderText = "Target Baca"
        tbxTarget.Size = New Size(322, 30)
        tbxTarget.TabIndex = 9
        ' 
        ' tbxTerakhir
        ' 
        tbxTerakhir.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxTerakhir.Location = New Point(317, 369)
        tbxTerakhir.Name = "tbxTerakhir"
        tbxTerakhir.PlaceholderText = "Buku Terakhir Baca"
        tbxTerakhir.Size = New Size(322, 30)
        tbxTerakhir.TabIndex = 7
        ' 
        ' tbxJumlah
        ' 
        tbxJumlah.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxJumlah.Location = New Point(317, 106)
        tbxJumlah.Name = "tbxJumlah"
        tbxJumlah.PlaceholderText = "Jumlah"
        tbxJumlah.Size = New Size(322, 30)
        tbxJumlah.TabIndex = 6
        ' 
        ' lbBt
        ' 
        lbBt.AutoSize = True
        lbBt.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbBt.Location = New Point(94, 369)
        lbBt.Name = "lbBt"
        lbBt.Size = New Size(197, 22)
        lbBt.TabIndex = 5
        lbBt.Text = "Buku Terakhir Dibaca:"
        ' 
        ' lbLp
        ' 
        lbLp.AutoSize = True
        lbLp.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbLp.Location = New Point(94, 306)
        lbLp.Name = "lbLp"
        lbLp.Size = New Size(137, 22)
        lbLp.TabIndex = 4
        lbLp.Text = "Level Pembaca:"
        ' 
        ' lbPm
        ' 
        lbPm.AutoSize = True
        lbPm.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbPm.Location = New Point(94, 239)
        lbPm.Name = "lbPm"
        lbPm.Size = New Size(160, 22)
        lbPm.TabIndex = 3
        lbPm.Text = "Progres Membaca:"
        ' 
        ' lbTm
        ' 
        lbTm.AutoSize = True
        lbTm.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbTm.Location = New Point(94, 177)
        lbTm.Name = "lbTm"
        lbTm.Size = New Size(152, 22)
        lbTm.TabIndex = 2
        lbTm.Text = "Target Membaca:"
        ' 
        ' lbTb
        ' 
        lbTb.AutoSize = True
        lbTb.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbTb.Location = New Point(94, 109)
        lbTb.Name = "lbTb"
        lbTb.Size = New Size(107, 22)
        lbTb.TabIndex = 1
        lbTb.Text = "Total Buku:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(185, 36)
        Label14.Name = "Label14"
        Label14.Size = New Size(327, 32)
        Label14.TabIndex = 0
        Label14.Text = "BOOK CLUB MEMBER"
        ' 
        ' tpRiwayat
        ' 
        tpRiwayat.BackgroundImage = CType(resources.GetObject("tpRiwayat.BackgroundImage"), Image)
        tpRiwayat.Controls.Add(lbEvent)
        tpRiwayat.Controls.Add(btnTambah)
        tpRiwayat.Controls.Add(DateTimePicker2)
        tpRiwayat.Controls.Add(tbxEvent)
        tpRiwayat.Controls.Add(Label22)
        tpRiwayat.Controls.Add(Label21)
        tpRiwayat.Controls.Add(Label20)
        tpRiwayat.Location = New Point(4, 32)
        tpRiwayat.Name = "tpRiwayat"
        tpRiwayat.Padding = New Padding(3)
        tpRiwayat.Size = New Size(720, 513)
        tpRiwayat.TabIndex = 4
        tpRiwayat.Text = "Riwayat Kegiatan"
        tpRiwayat.UseVisualStyleBackColor = True
        ' 
        ' lbEvent
        ' 
        lbEvent.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        lbEvent.FormattingEnabled = True
        lbEvent.ItemHeight = 22
        lbEvent.Location = New Point(84, 258)
        lbEvent.Name = "lbEvent"
        lbEvent.Size = New Size(540, 224)
        lbEvent.TabIndex = 6
        ' 
        ' btnTambah
        ' 
        btnTambah.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        btnTambah.Location = New Point(84, 212)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(540, 29)
        btnTambah.TabIndex = 7
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        DateTimePicker2.Location = New Point(302, 167)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(322, 30)
        DateTimePicker2.TabIndex = 5
        ' 
        ' tbxEvent
        ' 
        tbxEvent.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        tbxEvent.Location = New Point(302, 107)
        tbxEvent.Name = "tbxEvent"
        tbxEvent.PlaceholderText = "Event"
        tbxEvent.Size = New Size(322, 30)
        tbxEvent.TabIndex = 4
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        Label22.Location = New Point(84, 173)
        Label22.Name = "Label22"
        Label22.Size = New Size(133, 22)
        Label22.TabIndex = 3
        Label22.Text = "Tanggal Event:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Sylfaen", 10.2F, FontStyle.Bold)
        Label21.Location = New Point(84, 107)
        Label21.Name = "Label21"
        Label21.Size = New Size(115, 22)
        Label21.TabIndex = 2
        Label21.Text = "Nama Event:"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Ravie", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(200, 36)
        Label20.Name = "Label20"
        Label20.Size = New Size(327, 32)
        Label20.TabIndex = 1
        Label20.Text = "BOOK CLUB MEMBER"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(898, 639)
        Controls.Add(tcData)
        Controls.Add(MenuStrip1)
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tcData.ResumeLayout(False)
        tpData.ResumeLayout(False)
        tpData.PerformLayout()
        tpKontak.ResumeLayout(False)
        tpKontak.PerformLayout()
        tpProfil.ResumeLayout(False)
        tpProfil.PerformLayout()
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        tpStatistik.ResumeLayout(False)
        tpStatistik.PerformLayout()
        tpRiwayat.ResumeLayout(False)
        tpRiwayat.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tcData As TabControl
    Friend WithEvents tpData As TabPage
    Friend WithEvents tpKontak As TabPage
    Friend WithEvents tpProfil As TabPage
    Friend WithEvents tpStatistik As TabPage
    Friend WithEvents cbxK As ComboBox
    Friend WithEvents rbPr As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents tbxId As TextBox
    Friend WithEvents tbxNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbLk As RadioButton
    Friend WithEvents lbJko As Label
    Friend WithEvents lbJk As Label
    Friend WithEvents lbTgl As Label
    Friend WithEvents lbID As Label
    Friend WithEvents lbNama As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbAlamat As Label
    Friend WithEvents lbEmail As Label
    Friend WithEvents lbHp As Label
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxTarget As TextBox
    Friend WithEvents mtbTelp As MaskedTextBox
    Friend WithEvents tbxMedsos As TextBox
    Friend WithEvents lbMedsos As Label
    Friend WithEvents lbGf As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents cbxMancing As CheckBox
    Friend WithEvents cbxFoto As CheckBox
    Friend WithEvents cbxTari As CheckBox
    Friend WithEvents cbxLukis As CheckBox
    Friend WithEvents cbxBaca As CheckBox
    Friend WithEvents cbxNyanyi As CheckBox
    Friend WithEvents cbxNulis As CheckBox
    Friend WithEvents cbxAnggota As CheckBox
    Friend WithEvents cbxAdmin As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents cbxKetua As CheckBox
    Friend WithEvents btnUp As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents cbxMasak As CheckBox
    Friend WithEvents cbxKb As CheckBox
    Friend WithEvents cbxMd As CheckBox
    Friend WithEvents cbxNgoding As CheckBox
    Friend WithEvents cbxGame As CheckBox
    Friend WithEvents cbxOlahraga As CheckBox
    Friend WithEvents cbxKebun As CheckBox

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lbGf.Click

    End Sub

    Friend WithEvents cbxGenre As ComboBox

    Private Sub gbHobi_Enter(sender As Object, e As EventArgs) Handles gbHobi.Enter

    End Sub

    Friend WithEvents Label13 As Label

    Private Sub tpProfil_Click(sender As Object, e As EventArgs) Handles tpProfil.Click

    End Sub

    Friend WithEvents lbBt As Label
    Friend WithEvents lbLp As Label
    Friend WithEvents lbPm As Label
    Friend WithEvents lbTm As Label
    Friend WithEvents lbTb As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cbxLevel As ComboBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents tbxTerakhir As TextBox
    Friend WithEvents tbxJumlah As TextBox
    Friend WithEvents cbxProgres As ComboBox
    Friend WithEvents tpRiwayat As TabPage
    Friend WithEvents Label20 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents tbxEvent As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents lbEvent As ListBox
    Friend WithEvents tbxAlamat As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
