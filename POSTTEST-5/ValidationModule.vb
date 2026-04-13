Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Function ValidasiTextBox(ep As ErrorProvider,
                                    txt As TextBox,
                                    pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiBatik(ep As ErrorProvider,
                                  txtID As TextBox,
                                  txtNama As TextBox,
                                  txtKtg As TextBox,
                                  txtSize As TextBox,
                                  txtStok As TextBox,
                                  txtHarga As TextBox) As Boolean
        Dim idValid As Boolean = ValidasiTextBox(ep, txtID, "ID Batik tidak boleh kosong")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Motif tidak boleh kosong")
        Dim ktgValid As Boolean = ValidasiTextBox(ep, txtKtg, "Kategori tidak boleh kosong")
        Dim sizeValid As Boolean = ValidasiTextBox(ep, txtSize, "Ukuran tidak boleh kosong")
        Dim stokValid As Boolean = ValidasiTextBox(ep, txtStok, "Stok tidak boleh kosong")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga tidak boleh kosong")
        Return idValid And namaValid And ktgValid And sizeValid And stokValid And hargaValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module