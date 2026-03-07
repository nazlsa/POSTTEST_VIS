Public Class Form1
    Public judul As String
    Public genre As String

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        judul = txtJudul.Text
        genre = txtGenre.Text
        If judul = "" And genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            tambahBuku(judul, genre)
            tampilkanData()
            txtJudul.Clear()
            txtGenre.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        judul = txtHapusJudul.Text
        If judul = "" Then
            MessageBox.Show("Judul buku harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Module1.hapusBuku(judul)
            tampilkanData()
            txtHapusJudul.Clear()
        End If
    End Sub

    Private Sub tampilkanData()
        dgvDaftarBuku.Rows.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            dgvDaftarBuku.Rows.Add(daftarBuku(i, 0), daftarBuku(i, 1))
        Next
    End Sub

    Private Sub dgvDaftarBuku_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvDaftarBuku_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class