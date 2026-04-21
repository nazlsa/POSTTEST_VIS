Public Class FormLogin

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            MessageBox.Show("Username tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txtPw.Text) Then
            MessageBox.Show("Password tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPw.Focus()
            Exit Sub
        End If

        Dim frmData As New FormData()
        frmData.Show()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?",
                                                         "Konfirmasi Keluar",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtPw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPw.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnMasuk.PerformClick()
        End If
    End Sub

End Class