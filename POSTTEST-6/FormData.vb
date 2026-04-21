Public Class FormData
    Private Sub Kosong()
        txtID.Clear()
        txtNama.Clear()
        txtKtg.Clear()
        txtSize.Clear()
        txtStok.Clear()
        txtHarga.Clear()
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtID.Focus()
    End Sub

    Private Sub TampilData()
        dgvBatik.DataSource = GetAllBatik()
    End Sub

    Private Function NormalkanAngka(nilai As String) As String
        Return nilai.Trim().Replace(",", ".")
    End Function

    Private Sub FormData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiBatik(ErrorProvider1, txtID, txtNama, txtKtg, txtSize, txtStok, txtHarga) Then
            Exit Sub
        End If

        Dim id As String = txtID.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim ktg As String = txtKtg.Text.Trim()
        Dim size As String = txtSize.Text.Trim()
        Dim stok As String = NormalkanAngka(txtStok.Text)
        Dim harga As String = NormalkanAngka(txtHarga.Text)

        If IDAda(id) Then
            MessageBox.Show("ID Batik sudah terdaftar, gunakan tombol Edit untuk mengubah data.",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub
        End If

        If SimpanBatik(id, nama, ktg, size, stok, harga) Then
            MessageBox.Show("Data berhasil disimpan.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ErrorProvider1.Clear()

        If Not ValidasiBatik(ErrorProvider1, txtID, txtNama, txtKtg, txtSize, txtStok, txtHarga) Then
            Exit Sub
        End If

        Dim id As String = txtID.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim ktg As String = txtKtg.Text.Trim()
        Dim size As String = txtSize.Text.Trim()
        Dim stok As String = NormalkanAngka(txtStok.Text)
        Dim harga As String = NormalkanAngka(txtHarga.Text)

        If UbahBatik(id, nama, ktg, size, stok, harga) Then
            MessageBox.Show("Data berhasil diubah.", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtID.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult =
            MessageBox.Show("Apakah data dengan ID """ & txtID.Text.Trim() & """ ingin dihapus?",
                            "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusBatik(txtID.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        TampilData()
        Kosong()
    End Sub

    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        Dim frmBarang As New FormBarang()
        frmBarang.Show()
        Me.Close()
    End Sub


    Private Sub dgvBatik_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBatik.CellClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvBatik.Rows(e.RowIndex).Cells("ID").Value.ToString()
            txtNama.Text = dgvBatik.Rows(e.RowIndex).Cells("Motif").Value.ToString()
            txtKtg.Text = dgvBatik.Rows(e.RowIndex).Cells("Kategori").Value.ToString()
            txtSize.Text = dgvBatik.Rows(e.RowIndex).Cells("Ukuran").Value.ToString()
            txtStok.Text = dgvBatik.Rows(e.RowIndex).Cells("Stok").Value.ToString()
            txtHarga.Text = dgvBatik.Rows(e.RowIndex).Cells("Harga").Value.ToString()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvBatik.DataSource = SearchBatik(txtCari.Text.Trim())
        End If
    End Sub
    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetBatikByID(txtID.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNama.Text = dt.Rows(0)("Motif").ToString()
                txtKtg.Text = dt.Rows(0)("Kategori").ToString()
                txtSize.Text = dt.Rows(0)("Ukuran").ToString()
                txtStok.Text = dt.Rows(0)("Stok").ToString()
                txtHarga.Text = dt.Rows(0)("Harga").ToString()
            Else
                txtNama.Clear()
                txtKtg.Clear()
                txtSize.Clear()
                txtStok.Clear()
                txtHarga.Clear()
            End If
            txtNama.Focus()
        End If
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtKtg.Focus()
        End If
    End Sub

    Private Sub txtKtg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKtg.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtSize.Focus()
        End If
    End Sub

    Private Sub txtSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSize.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtStok.Focus()
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtHarga.Focus()
        End If
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
        If IsEnterKey(e) Then
            e.Handled = True
            btnSimpan.Focus()
        End If
    End Sub

End Class