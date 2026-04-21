Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

    ' ================== VALIDASI DENGAN ERRORPROVIDER ==================
    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If String.IsNullOrWhiteSpace(txt.Text) Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiBatik(ep As ErrorProvider,
                                  txtID As TextBox, txtNama As TextBox, txtKtg As TextBox,
                                  txtSize As TextBox, txtStok As TextBox, txtHarga As TextBox) As Boolean

        Dim valid As Boolean = True

        valid = valid And ValidasiTextBox(ep, txtID, "ID Batik tidak boleh kosong")
        valid = valid And ValidasiTextBox(ep, txtNama, "Nama Motif tidak boleh kosong")
        valid = valid And ValidasiTextBox(ep, txtKtg, "Kategori tidak boleh kosong")
        valid = valid And ValidasiTextBox(ep, txtSize, "Ukuran tidak boleh kosong")
        valid = valid And ValidasiTextBox(ep, txtStok, "Stok tidak boleh kosong")
        valid = valid And ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")

        ' Validasi tambahan tipe data
        If Not String.IsNullOrWhiteSpace(txtStok.Text) AndAlso Not IsNumeric(txtStok.Text) Then
            ep.SetError(txtStok, "Stok harus berupa angka")
            valid = False
        End If

        If Not String.IsNullOrWhiteSpace(txtHarga.Text) AndAlso Not IsNumeric(txtHarga.Text) Then
            ep.SetError(txtHarga, "Harga harus berupa angka")
            valid = False
        End If

        Return valid
    End Function

End Module