Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Setup_InitialForm()
    End Sub

    Private Sub Setup_InitialForm()
        tcData.SelectedIndex = 0

        With mtbTelp
            .Mask = "000-000-0000"
            .BeepOnError = True
        End With

        Setup_ComboBox()
    End Sub

    Private Sub Setup_ComboBox()
        cbxK.Items.Clear()
        cbxK.Items.AddRange(New Object() {"Club Baca", "Komunitas Penulis", "Komunitas Teknologi", "Book Club"})

        cbxGenre.Items.Clear()
        cbxGenre.Items.AddRange(New Object() {"Fiksi", "Non-Fiksi", "Romance", "Thriller", "Fantasy", "Mystery"})

        cbxProgres.Items.Clear()
        cbxProgres.Items.AddRange(New Object() {"Belum Mulai", "Sedang Membaca", "Hampir Selesai", "Selesai"})

        cbxLevel.Items.Clear()
        cbxLevel.Items.AddRange(New Object() {"Pemula", "Pembaca Aktif", "Kutu Buku"})
    End Sub

    Private Sub tbxNama_TextChanged(sender As Object, e As EventArgs) Handles tbxNama.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub tbxId_TextChanged(sender As Object, e As EventArgs) Handles tbxId.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxId, "ID Anggota tidak boleh kosong")
    End Sub

    Private Sub rbLk_CheckedChanged(sender As Object, e As EventArgs) Handles rbLk.CheckedChanged, rbPr.CheckedChanged
        ValidasiRadioButton(ErrorProvider1, rbLk, rbPr, "Jenis kelamin harus dipilih")
    End Sub

    Private Sub cbxK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxK.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cbxK, "Komunitas harus dipilih")
    End Sub

    Private Sub mtbTelp_TextChanged(sender As Object, e As EventArgs) Handles mtbTelp.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, mtbTelp, "Nomor HP belum lengkap (format: xxx-xxx-xxxx)")
    End Sub

    Private Sub tbxEmail_TextChanged(sender As Object, e As EventArgs) Handles tbxEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxEmail, "Email tidak boleh kosong")
    End Sub

    Private Sub cbxGenre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGenre.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cbxGenre, "Genre harus dipilih")
    End Sub

    Private Sub tbxMedsos_TextChanged(sender As Object, e As EventArgs) Handles tbxMedsos.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxMedsos, "Media Sosial tidak boleh kosong")
    End Sub

    Private Sub Peran_CheckedChanged(sender As Object, e As EventArgs) Handles cbxKetua.CheckedChanged, cbxAdmin.CheckedChanged, cbxAnggota.CheckedChanged, cbxMd.CheckedChanged, cbxKb.CheckedChanged
        Dim peranChecks As CheckBox() = {cbxKetua, cbxAdmin, cbxAnggota, cbxMd, cbxKb}
        ValidasiCheckBox(ErrorProvider1, peranChecks, "Pilih minimal satu peran")
    End Sub

    Private Sub Hobi_CheckedChanged(sender As Object, e As EventArgs) Handles cbxNulis.CheckedChanged, cbxNyanyi.CheckedChanged, cbxBaca.CheckedChanged, cbxLukis.CheckedChanged, cbxTari.CheckedChanged, cbxFoto.CheckedChanged, cbxMancing.CheckedChanged, cbxMasak.CheckedChanged, cbxOlahraga.CheckedChanged, cbxGame.CheckedChanged, cbxNgoding.CheckedChanged, cbxKebun.CheckedChanged
        Dim hobiChecks As CheckBox() = {cbxNulis, cbxNyanyi, cbxBaca, cbxLukis, cbxTari, cbxFoto, cbxMancing, cbxMasak, cbxOlahraga, cbxGame, cbxNgoding, cbxKebun}
        ValidasiCheckBox(ErrorProvider1, hobiChecks, "Pilih minimal satu hobi")
    End Sub

    Private Sub tbxJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbxJumlah.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxJumlah, "Jumlah Buku tidak boleh kosong")
    End Sub

    Private Sub tbxTarget_TextChanged(sender As Object, e As EventArgs) Handles tbxTarget.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxTarget, "Target Membaca tidak boleh kosong")
    End Sub

    Private Sub cbxProgres_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProgres.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cbxProgres, "Progres harus dipilih")
    End Sub

    Private Sub cbxLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLevel.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, cbxLevel, "Level harus dipilih")
    End Sub

    Private Sub tbxTerakhir_TextChanged(sender As Object, e As EventArgs) Handles tbxTerakhir.TextChanged
        ValidasiTextBox(ErrorProvider1, tbxTerakhir, "Buku Terakhir tidak boleh kosong")
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Proses_UploadFoto()
    End Sub

    Private Sub Proses_UploadFoto()
        With OpenFileDialog1
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
            .Title = "Pilih Foto"
            If .ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(.FileName)
                ValidasiPictureBox(ErrorProvider1, PictureBox2, "")
                MessageBox.Show("Foto berhasil dimuat!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End With
    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Proses_TambahEvent()
    End Sub

    Private Sub Proses_TambahEvent()
        If String.IsNullOrWhiteSpace(tbxEvent.Text) Then
            MessageBox.Show("Event tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxEvent.Focus()
            Exit Sub
        End If

        Dim eventText = DateTimePicker2.Value.ToString("yyyy-MM-dd") & " - " & tbxEvent.Text
        lbEvent.Items.Add(eventText)
        ValidasiListBox(ErrorProvider1, lbEvent, "")

        tbxEvent.Text = ""
        DateTimePicker2.Value = Now

        MessageBox.Show("Event berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Proses_SimpanData()
    End Sub

    Private Sub Proses_SimpanData()
        If Not Validasi_SemuaInput() Then Exit Sub

        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "Konfirmasi Simpan",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

        If hasil = DialogResult.Yes Then
            Simpan_KeFile()
        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Data tidak jadi disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function Validasi_SemuaInput() As Boolean
        Dim peranChecks As CheckBox() = {cbxKetua, cbxAdmin, cbxAnggota, cbxMd, cbxKb}
        Dim hobiChecks As CheckBox() = {cbxNulis, cbxNyanyi, cbxBaca, cbxLukis, cbxTari, cbxFoto, cbxMancing, cbxMasak, cbxOlahraga, cbxGame, cbxNgoding, cbxKebun}

        Dim namaValid = ValidasiTextBox(ErrorProvider1, tbxNama, "Nama tidak boleh kosong")
        Dim idValid = ValidasiTextBox(ErrorProvider1, tbxId, "ID Anggota tidak boleh kosong")
        Dim jkValid = ValidasiRadioButton(ErrorProvider1, rbLk, rbPr, "Jenis kelamin harus dipilih")
        Dim komunValid = ValidasiComboBox(ErrorProvider1, cbxK, "Komunitas harus dipilih")
        Dim hpValid = ValidasiMaskedTextBox(ErrorProvider1, mtbTelp, "Nomor HP belum lengkap")
        Dim emailValid = ValidasiTextBox(ErrorProvider1, tbxEmail, "Email tidak boleh kosong")
        Dim genreValid = ValidasiComboBox(ErrorProvider1, cbxGenre, "Genre harus dipilih")
        Dim sosialValid = ValidasiTextBox(ErrorProvider1, tbxMedsos, "Media Sosial tidak boleh kosong")
        Dim peranValid = ValidasiCheckBox(ErrorProvider1, peranChecks, "Pilih minimal satu peran")
        Dim hobiValid = ValidasiCheckBox(ErrorProvider1, hobiChecks, "Pilih minimal satu hobi")
        Dim fotoValid = ValidasiPictureBox(ErrorProvider1, PictureBox2, "Foto harus diupload")
        Dim jumlahValid = ValidasiTextBox(ErrorProvider1, tbxJumlah, "Jumlah Buku tidak boleh kosong")
        Dim targetValid = ValidasiTextBox(ErrorProvider1, tbxTarget, "Target Membaca tidak boleh kosong")
        Dim progresValid = ValidasiComboBox(ErrorProvider1, cbxProgres, "Progres harus dipilih")
        Dim levelValid = ValidasiComboBox(ErrorProvider1, cbxLevel, "Level harus dipilih")
        Dim bukuValid = ValidasiTextBox(ErrorProvider1, tbxTerakhir, "Buku Terakhir tidak boleh kosong")
        Dim eventValid = ValidasiListBox(ErrorProvider1, lbEvent, "Minimal ada satu event")

        If Not (namaValid AndAlso idValid AndAlso jkValid AndAlso komunValid AndAlso
                hpValid AndAlso emailValid AndAlso genreValid AndAlso sosialValid AndAlso
                peranValid AndAlso hobiValid AndAlso fotoValid AndAlso jumlahValid AndAlso
                targetValid AndAlso progresValid AndAlso levelValid AndAlso bukuValid AndAlso eventValid) Then

            Dim pesanError As String = "Field yang belum valid:" & Environment.NewLine
            If Not namaValid Then pesanError &= "- Nama belum diisi" & Environment.NewLine
            If Not idValid Then pesanError &= "- ID Anggota belum diisi" & Environment.NewLine
            If Not jkValid Then pesanError &= "- Jenis Kelamin belum dipilih" & Environment.NewLine
            If Not komunValid Then pesanError &= "- Komunitas belum dipilih" & Environment.NewLine
            If Not hpValid Then pesanError &= "- No. HP belum lengkap" & Environment.NewLine
            If Not emailValid Then pesanError &= "- Email belum diisi" & Environment.NewLine
            If Not genreValid Then pesanError &= "- Genre belum dipilih" & Environment.NewLine
            If Not sosialValid Then pesanError &= "- Media Sosial belum diisi" & Environment.NewLine
            If Not peranValid Then pesanError &= "- Peran belum dipilih" & Environment.NewLine
            If Not hobiValid Then pesanError &= "- Hobi belum dipilih" & Environment.NewLine
            If Not fotoValid Then pesanError &= "- Foto belum diupload" & Environment.NewLine
            If Not jumlahValid Then pesanError &= "- Jumlah Buku belum diisi" & Environment.NewLine
            If Not targetValid Then pesanError &= "- Target Membaca belum diisi" & Environment.NewLine
            If Not progresValid Then pesanError &= "- Progres belum dipilih" & Environment.NewLine
            If Not levelValid Then pesanError &= "- Level belum dipilih" & Environment.NewLine
            If Not bukuValid Then pesanError &= "- Buku Terakhir belum diisi" & Environment.NewLine
            If Not eventValid Then pesanError &= "- Event belum ditambahkan" & Environment.NewLine

            MessageBox.Show(pesanError, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub Simpan_KeFile()
        Dim hobiChecks As CheckBox() = {
            cbxNulis, cbxNyanyi, cbxBaca, cbxLukis, cbxTari,
            cbxFoto, cbxMancing, cbxMasak, cbxOlahraga,
            cbxGame, cbxNgoding, cbxKebun
        }

        Dim jenisKelamin As String = If(rbLk.Checked, "Laki-laki", "Perempuan")

        Dim isi As String = BuatIsiFile(
            tbxNama.Text,
            mtbTelp.Text,
            tbxAlamat.Text,
            cbxK.Text,
            AmbilYangDipilih(hobiChecks),
            jenisKelamin,
            DateTimePicker1.Value.ToString("yyyy-MM-dd"),
            cbxGenre.Text,
            tbxMedsos.Text,
            tbxJumlah.Text,
            tbxTarget.Text,
            cbxProgres.Text,
            cbxLevel.Text,
            tbxTerakhir.Text
        )

        If SimpanDataKeFile(SaveFileDialog1, isi, "data_anggota.txt") Then
            KosongkanForm()
            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KosongkanForm()
        tbxNama.Clear()
        tbxId.Clear()
        DateTimePicker1.Value = Now
        rbLk.Checked = False
        rbPr.Checked = False
        cbxK.SelectedIndex = -1

        mtbTelp.Clear()
        tbxEmail.Clear()
        cbxGenre.SelectedIndex = -1
        tbxMedsos.Clear()
        tbxTarget.Clear()

        Dim allChecks As CheckBox() = {cbxKetua, cbxAdmin, cbxAnggota, cbxMd, cbxKb,
                                       cbxNulis, cbxNyanyi, cbxBaca, cbxLukis, cbxTari,
                                       cbxFoto, cbxMancing, cbxMasak, cbxOlahraga, cbxGame,
                                       cbxNgoding, cbxKebun}

        For Each chk In allChecks
            chk.Checked = False
        Next

        PictureBox2.Image = Nothing
        tbxJumlah.Clear()
        cbxProgres.SelectedIndex = -1
        cbxLevel.SelectedIndex = -1
        tbxTerakhir.Clear()

        lbEvent.Items.Clear()
        tbxEvent.Clear()

        ErrorProvider1.Clear()
        tcData.SelectedIndex = 0
        tbxNama.Focus()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If String.IsNullOrWhiteSpace(tbxNama.Text) Then
            MessageBox.Show("Isi data dulu sebelum melihat kartu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim peranChecks As CheckBox() = {cbxKetua, cbxAdmin, cbxAnggota, cbxMd, cbxKb}
        Dim hobiChecks As CheckBox() = {cbxNulis, cbxNyanyi, cbxBaca, cbxLukis, cbxTari, cbxFoto, cbxMancing, cbxMasak, cbxOlahraga, cbxGame, cbxNgoding, cbxKebun}

        Dim form2 As New Form2

        form2.Nama = tbxNama.Text
        form2.ID = tbxId.Text
        form2.TglLahir = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        form2.JenisKelamin = If(rbLk.Checked, "Laki-laki", "Perempuan")
        form2.Komunitas = cbxK.Text
        form2.NoHP = mtbTelp.Text
        form2.Email = tbxEmail.Text
        form2.Hobi = AmbilYangDipilih(hobiChecks)
        form2.Peran = AmbilYangDipilih(peranChecks)
        form2.JumlahBuku = tbxJumlah.Text
        form2.Level = cbxLevel.Text
        form2.MediaSosial = tbxMedsos.Text
        form2.TargetBaca = tbxTarget.Text
        form2.Genre = cbxGenre.Text
        form2.BukuTerakhir = tbxTerakhir.Text
        form2.Alamat = tbxAlamat.Text

        If PictureBox2.Image IsNot Nothing Then
            form2.Foto = PictureBox2.Image
        End If

        form2.ShowDialog()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        btnSimpan_Click(Nothing, Nothing)
    End Sub
    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        OpenFileDialog1.Title = "Buka Data Anggota"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If File.Exists(OpenFileDialog1.FileName) Then
                Dim isi As String = File.ReadAllText(OpenFileDialog1.FileName)
                MessageBox.Show(isi, "Isi Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("File tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        tcData.SelectedIndex = 0
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah yakin ingin keluar?", "Konfirmasi Keluar",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Function AmbilYangDipilih(checks As CheckBox()) As String
        Dim list As New List(Of String)

        For Each chk In checks
            If chk.Checked Then
                If Not list.Contains(chk.Text) Then
                    list.Add(chk.Text)
                End If
            End If
        Next

        Return String.Join(", ", list)
    End Function
End Class