Public Class Form1

    Dim totalIPS As Double = 0
    Dim jumlahSemester As Integer = 0
    Dim sudahTambah As Boolean = False

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ips As Double
        Dim ipk As Double
        Dim inputText As String = txt1.Text.Trim().Replace(".", ",")

        If Double.TryParse(inputText, ips) Then

            If ips < 0 Or ips > 4 Then
                MessageBox.Show("IPS harus berada di antara 0.00 - 4.00")
                Exit Sub
            End If

            totalIPS = totalIPS + ips
            jumlahSemester = jumlahSemester + 1
            ipk = totalIPS / jumlahSemester

            txt1.Text = Format(ips, "0.00").Replace(",", ".")
            txt2.Text = Format(ipk, "0.00").Replace(",", ".")

            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If

            sudahTambah = True

        Else
            MessageBox.Show("Masukkan IP Semester berupa angka (contoh: 3.75 atau 3,75)")
        End If

    End Sub

    Private Sub txt1_Enter(sender As Object, e As EventArgs) Handles txt1.Enter

        If sudahTambah Then
            txt1.Text = ""
            sudahTambah = False
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles Button2.Click

        totalIPS = 0
        jumlahSemester = 0
        sudahTambah = False
        txt1.Text = ""
        txt2.Text = ""
        lblPredikat.Text = ""
        txt1.Focus()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class