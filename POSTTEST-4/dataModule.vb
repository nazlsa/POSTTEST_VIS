Imports System.IO
Imports System.Text

Module dataModule

    ' ====== FUNGSI MEMBUAT RINGKASAN ======

    Public Function BuatRingkasan(
        nama As String,
        noHp As String,
        alamat As String,
        komunitas As String,
        hobi As String
    ) As String

        Return "Nama            : " & nama & Environment.NewLine &
               "Nomor HP        : " & noHp & Environment.NewLine &
               "Alamat          : " & alamat & Environment.NewLine &
               "Komunitas       : " & komunitas & Environment.NewLine &
               "Hobi            : " & hobi
    End Function

    ' ====== FUNGSI MEMBUAT ISI FILE ======

    Public Function BuatIsiFile(
        nama As String,
        noHp As String,
        alamat As String,
        komunitas As String,
        hobi As String,
        jenisKelamin As String,
        tglLahir As String,
        genre As String,
        mediaSosial As String,
        jumlahBuku As String,
        target As String,
        progres As String,
        level As String,
        bukuTerakhir As String
    ) As String

        Dim sb As New StringBuilder()

        sb.AppendLine("=== DATA ANGGOTA ===")
        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("NoHP=" & noHp.Trim())
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Komunitas=" & komunitas.Trim())
        sb.AppendLine("Hobi=" & hobi.Trim())
        sb.AppendLine("JenisKelamin=" & jenisKelamin.Trim())
        sb.AppendLine("TglLahir=" & tglLahir.Trim())
        sb.AppendLine("Genre=" & genre.Trim())
        sb.AppendLine("MediaSosial=" & mediaSosial.Trim())
        sb.AppendLine("JumlahBuku=" & jumlahBuku.Trim())
        sb.AppendLine("TargetBaca=" & target.Trim())
        sb.AppendLine("Progres=" & progres.Trim())
        sb.AppendLine("Level=" & level.Trim())
        sb.Append("BukuTerakhir=" & bukuTerakhir.Trim())

        Return sb.ToString()
    End Function

    ' ====== FUNGSI SIMPAN DATA KE FILE ======

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean

        sfd.Filter = "Text File|*.txt|CSV File|*.csv|All Files|*.*"
        sfd.Title = "Simpan Data Anggota"
        sfd.FileName = namaFileDefault

        Try
            If sfd.ShowDialog() = DialogResult.OK Then
                File.WriteAllText(sfd.FileName, isi, Encoding.UTF8)
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return False
    End Function

    ' ====== FUNGSI BUKA DATA DARI FILE ======

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv|All Files|*.*"
        ofd.Title = "Buka Data Anggota"

        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Try
            Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            Dim barisFile() As String = File.ReadAllLines(ofd.FileName, Encoding.UTF8)

            For Each baris As String In barisFile
                If String.IsNullOrWhiteSpace(baris) OrElse baris.StartsWith("===") Then
                    Continue For
                End If

                Dim bagian() As String = baris.Split(New Char() {"="c}, 2)

                If bagian.Length = 2 Then
                    hasil(bagian(0).Trim()) = bagian(1).Trim()
                End If
            Next

            Return hasil

        Catch ex As Exception
            MessageBox.Show("Error saat membuka: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' ====== FUNGSI AMBIL NILAI DARI DICTIONARY ======

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If
        Return ""
    End Function

    ' ====== FUNGSI AMBIL CHECKBOX YANG DIPILIH ======

    Public Function AmbilCheckboxYangDipilih(checkboxes As CheckBox()) As String
        Dim hasil As String = ""

        For Each chk In checkboxes
            If chk.Checked Then
                hasil &= chk.Text & ", "
            End If
        Next

        If hasil.Length > 2 Then
            hasil = hasil.Substring(0, hasil.Length - 2)
        End If

        Return hasil
    End Function

    ' ====== FUNGSI CEK MINIMAL SATU CHECKBOX ======

    Public Function IsAtLeastOneCheckboxChecked(checkboxes As CheckBox()) As Boolean
        For Each chk In checkboxes
            If chk.Checked Then
                Return True
            End If
        Next
        Return False
    End Function

End Module