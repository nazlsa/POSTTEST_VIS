Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpTgl.Format = DateTimePickerFormat.Custom
        dtpTgl.CustomFormat = "dd/MM/yyyy"

        PicProfil.SizeMode = PictureBoxSizeMode.StretchImage
        PicProfil.BorderStyle = BorderStyle.FixedSingle

        cbxAgama.Items.Clear()
        cbxAgama.Items.AddRange({"Islam", "Kristen", "Katolik", "Hindu", "Buddha", "Konghucu"})
        cbxAgama.SelectedIndex = -1

        grupHobi = {
            cbGaming, cbCoding, cbTraveling, cbGambar, cbNulis,
            cbMancing, cbBaca, cbOlahraga, cbNyanyi, cbFilm,
            cbNari, cbKebun, cbMusik, cbFoto, cbBuku
        }

        grupJK = {rbLaki, rbPerempuan}

    End Sub

    Private Function ValidasiInput() As Boolean

        If txtNama.Text.Trim = "" Then
            MessageBox.Show("Nama tidak boleh kosong")
            txtNama.Focus()
            Return False
        End If

        If txtUmur.Text.Trim = "" Then
            MessageBox.Show("Umur tidak boleh kosong")
            txtUmur.Focus()
            Return False
        End If

        If txtTelp.Text.Trim = "" Then
            MessageBox.Show("No Telp tidak boleh kosong")
            txtTelp.Focus()
            Return False
        End If

        If cbxAgama.SelectedIndex = -1 Then
            MessageBox.Show("Agama harus dipilih")
            cbxAgama.Focus()
            Return False
        End If

        If txtAlamat.Text.Trim = "" Then
            MessageBox.Show("Alamat tidak boleh kosong")
            txtAlamat.Focus()
            Return False
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Return False
        End If

        If Not AdaHobiDipilih() Then
            MessageBox.Show("Pilih minimal 1 hobi")
            Return False
        End If

        If PicProfil.Image Is Nothing Then
            MessageBox.Show("Foto belum dipilih")
            Return False
        End If

        Return True

    End Function

    Private Function AmbilHobi() As String

        Dim hasil As String = ""

        For Each cb As CheckBox In grupHobi
            If cb.Checked Then
                hasil &= cb.Text & ", "
            End If
        Next

        If hasil <> "" Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil

    End Function

    Private Function AdaHobiDipilih() As Boolean

        For Each cb As CheckBox In grupHobi
            If cb.Checked Then
                Return True
            End If
        Next

        Return False

    End Function

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profil"

        If ofd.ShowDialog = DialogResult.OK Then

            Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If

            Dim ekstensi As String = Path.GetExtension(ofd.FileName)
            Dim fileName As String = txtNama.Text & ekstensi
            Dim tujuan As String = Path.Combine(folderPath, fileName)

            File.Copy(ofd.FileName, tujuan, True)

            PicProfil.Image = Image.FromFile(tujuan)
            DataModule.Foto = tujuan

        End If

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Dim f As New formOutput

        f.lblNama.Text = txtNama.Text
        f.lblUmur.Text = txtUmur.Text
        f.lblTglLhr.Text = dtpTgl.Value
        f.lblTlp.Text = txtTelp.Text
        f.lblAgama.Text = cbxAgama.Text
        f.lblAlamat.Text = txtAlamat.Text
        f.lblHobi.Text = AmbilHobi()
        f.lblJK.Text = JK

        If rbLaki.Checked Then
            f.lblJK.Text = "Laki-Laki"
        Else
            f.lblJK.Text = "Perempuan"

        End If


        f.PictureBox1.Image = PicProfil.Image
        f.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        f.Show()

    End Sub

End Class