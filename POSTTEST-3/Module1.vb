Module ValidationModule

    Public Function ValidasiTextBox(txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiComboBox(cmb As ComboBox, pesan As String) As Boolean
        If cmb.SelectedIndex = -1 Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmb.Focus()
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiRadioButton(grup() As RadioButton, pesan As String) As Boolean
        For Each rb As RadioButton In grup
            If rb.Checked Then Return True
        Next

        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiCheckBox(grup() As CheckBox, pesan As String) As Boolean
        For Each cb As CheckBox In grup
            If cb.Checked Then Return True
        Next

        MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Public Function ValidasiPictureBox(pic As PictureBox, pesan As String) As Boolean
        If pic.Image Is Nothing Then
            MessageBox.Show(pesan, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Public Function GetSelectedCheckBox(grup() As CheckBox) As String
        Dim hasil As String = ""

        For Each cb As CheckBox In grup
            If cb.Checked Then
                hasil &= cb.Text & ", "
            End If
        Next

        If hasil <> "" Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    Public Function GetSelectedRadioButton(grup() As RadioButton) As String
        For Each rb As RadioButton In grup
            If rb.Checked Then Return rb.Text
        Next
        Return ""
    End Function

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Module