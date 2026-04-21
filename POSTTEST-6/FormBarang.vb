Public Class FormBarang
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatDropdownBatik()
        TampilData()
        KosongkanForm()
    End Sub

    Private Sub TampilData()
        dgvBarang.DataSource = GetAllBatik()
    End Sub

    Private Sub MuatDropdownBatik()
        Dim dt As DataTable = GetAllBatik()
        cbxIdBatik.DataSource = dt
        cbxIdBatik.DisplayMember = "ID"
        cbxIdBatik.ValueMember = "ID"
        cbxIdBatik.SelectedIndex = -1
    End Sub

    Private Sub KosongkanForm()

        cbxIdBatik.DataSource = Nothing
        cbxIdBatik.Text = ""
        cbxNamaMotif.Text = ""
        cbxKategori.Text = ""
        cbxUkuran.Text = ""
        cbxHarga.Text = ""
        cbxStok.Text = ""
        txtJumlah.Clear()
        txtCari.Clear()
        ErrorProvider1.Clear()
        MuatDropdownBatik()
    End Sub

    Private Sub IsiDariID(id As String)
        Dim dt As DataTable = GetBatikByID(id)
        If dt.Rows.Count > 0 Then
            cbxNamaMotif.Text = dt.Rows(0)("Motif").ToString()
            cbxKategori.Text = dt.Rows(0)("Kategori").ToString()
            cbxUkuran.Text = dt.Rows(0)("Ukuran").ToString()
            cbxHarga.Text = dt.Rows(0)("Harga").ToString()
            cbxStok.Text = dt.Rows(0)("Stok").ToString()
        End If
    End Sub

    Private Function ValidasiForm() As Boolean
        ErrorProvider1.Clear()
        Dim ok As Boolean = True

        If String.IsNullOrWhiteSpace(cbxIdBatik.Text) Then
            ErrorProvider1.SetError(cbxIdBatik, "ID Batik tidak boleh kosong")
            ok = False
        End If
        If String.IsNullOrWhiteSpace(cbxNamaMotif.Text) Then
            ErrorProvider1.SetError(cbxNamaMotif, "Nama Motif tidak boleh kosong")
            ok = False
        End If
        If String.IsNullOrWhiteSpace(cbxKategori.Text) Then
            ErrorProvider1.SetError(cbxKategori, "Kategori tidak boleh kosong")
            ok = False
        End If
        If String.IsNullOrWhiteSpace(cbxUkuran.Text) Then
            ErrorProvider1.SetError(cbxUkuran, "Ukuran tidak boleh kosong")
            ok = False
        End If
        If String.IsNullOrWhiteSpace(cbxStok.Text) OrElse Not IsNumeric(cbxStok.Text) Then
            ErrorProvider1.SetError(cbxStok, "Stok harus berupa angka")
            ok = False
        End If
        If String.IsNullOrWhiteSpace(cbxHarga.Text) OrElse Not IsNumeric(cbxHarga.Text) Then
            ErrorProvider1.SetError(cbxHarga, "Harga harus berupa angka")
            ok = False
        End If

        Return ok
    End Function

    Private Sub cbxIdBatik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIdBatik.SelectedIndexChanged
        If cbxIdBatik.SelectedValue IsNot Nothing AndAlso
           Not String.IsNullOrWhiteSpace(cbxIdBatik.SelectedValue.ToString()) Then
            IsiDariID(cbxIdBatik.SelectedValue.ToString())
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiForm() Then Exit Sub

        Dim id As String = cbxIdBatik.Text.Trim()

        If IDAda(id) Then
            MessageBox.Show("ID Batik sudah terdaftar." & vbNewLine &
                            "Gunakan tombol Edit untuk mengubah data yang sudah ada.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbxIdBatik.Focus()
            Exit Sub
        End If

        If SimpanBatik(id, cbxNamaMotif.Text.Trim(), cbxKategori.Text.Trim(),
                        cbxUkuran.Text.Trim(), cbxStok.Text.Trim(), cbxHarga.Text.Trim()) Then
            MessageBox.Show("Data berhasil disimpan.", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Not ValidasiForm() Then Exit Sub

        Dim id As String = cbxIdBatik.Text.Trim()

        If Not IDAda(id) Then
            MessageBox.Show("ID Batik tidak ditemukan di database." & vbNewLine &
                            "Pilih data dari tabel atau masukkan ID yang benar.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If UbahBatik(id, cbxNamaMotif.Text.Trim(), cbxKategori.Text.Trim(),
                      cbxUkuran.Text.Trim(), cbxStok.Text.Trim(), cbxHarga.Text.Trim()) Then
            MessageBox.Show("Data berhasil diubah.", "Sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongkanForm()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If String.IsNullOrWhiteSpace(cbxIdBatik.Text) Then
            MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As String = cbxIdBatik.Text.Trim()

        Dim konfirmasi As DialogResult =
            MessageBox.Show("Apakah data dengan ID """ & id & """ ingin dihapus?",
                            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusBatik(id) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
    End Sub
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim frmData As New FormData()
        frmData.Show()
        Me.Close()
    End Sub


    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If String.IsNullOrWhiteSpace(txtCari.Text) Then
            TampilData()
        Else
            dgvBarang.DataSource = SearchBatik(txtCari.Text.Trim())
        End If
    End Sub


    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex < 0 Then Exit Sub

        Dim idDipilih As String = dgvBarang.Rows(e.RowIndex).Cells("ID").Value.ToString()

        For i As Integer = 0 To cbxIdBatik.Items.Count - 1
            Dim row As DataRowView = CType(cbxIdBatik.Items(i), DataRowView)
            If row("ID").ToString() = idDipilih Then
                cbxIdBatik.SelectedIndex = i
                Exit For
            End If
        Next

        cbxNamaMotif.Text = dgvBarang.Rows(e.RowIndex).Cells("Motif").Value.ToString()
        cbxKategori.Text = dgvBarang.Rows(e.RowIndex).Cells("Kategori").Value.ToString()
        cbxUkuran.Text = dgvBarang.Rows(e.RowIndex).Cells("Ukuran").Value.ToString()
        cbxHarga.Text = dgvBarang.Rows(e.RowIndex).Cells("Harga").Value.ToString()
        cbxStok.Text = dgvBarang.Rows(e.RowIndex).Cells("Stok").Value.ToString()
    End Sub
    Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class