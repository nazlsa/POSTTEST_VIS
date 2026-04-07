Module validationModule

    ' ====== VALIDASI INPUT KARAKTER ======

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

    ' ====== VALIDASI TEXTBOX ======

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    ' ====== VALIDASI COMBOBOX ======

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    ' ====== VALIDASI RADIO BUTTON ======

    Public Function ValidasiRadioButton(ep As ErrorProvider, rb1 As RadioButton, rb2 As RadioButton, pesan As String) As Boolean
        If Not (rb1.Checked OrElse rb2.Checked) Then
            ep.SetError(rb1, pesan)
            Return False
        Else
            ep.SetError(rb1, "")
            Return True
        End If
    End Function

    ' ====== VALIDASI MASKED TEXTBOX ======

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    ' ====== VALIDASI CHECKBOX (MINIMAL SATU DIPILIH) ======

    Public Function ValidasiCheckBox(ep As ErrorProvider, checkboxes As CheckBox(), pesan As String) As Boolean
        Dim minimal As Boolean = False

        For Each chk In checkboxes
            If chk.Checked Then
                minimal = True
                Exit For
            End If
        Next

        If Not minimal Then
            ep.SetError(checkboxes(0), pesan)
            Return False
        Else
            ep.SetError(checkboxes(0), "")
            Return True
        End If
    End Function

    ' ====== VALIDASI PICTURE BOX ======

    Public Function ValidasiPictureBox(ep As ErrorProvider, pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            ep.SetError(pic, pesan)
            Return False
        Else
            ep.SetError(pic, "")
            Return True
        End If
    End Function

    ' ====== VALIDASI LIST BOX ======

    Public Function ValidasiListBox(ep As ErrorProvider, lb As ListBox, pesan As String) As Boolean
        If lb.Items.Count = 0 Then
            ep.SetError(lb, pesan)
            Return False
        Else
            ep.SetError(lb, "")
            Return True
        End If
    End Function

End Module