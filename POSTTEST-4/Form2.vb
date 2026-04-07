Public Class Form2

    Public Nama As String
    Public ID As String
    Public TglLahir As String
    Public JenisKelamin As String
    Public Komunitas As String
    Public NoHP As String
    Public Email As String
    Public Hobi As String
    Public Peran As String
    Public JumlahBuku As String
    Public Level As String
    Public MediaSosial As String
    Public TargetBaca As String
    Public Genre As String
    Public BukuTerakhir As String
    Public Alamat As String
    Public Foto As Image

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbNama.Text = Nama
        lbID.Text = ID
        lbTgl.Text = TglLahir
        lbJk.Text = JenisKelamin
        lbJKO.Text = Komunitas
        lbHp.Text = NoHP
        lbEmail.Text = Email
        lbHobi.Text = Hobi
        lbTb.Text = JumlahBuku
        lbLp.Text = Level
        lbMedsos.Text = MediaSosial
        lbTm.Text = TargetBaca
        lbGf.Text = Genre
        lbBt.Text = BukuTerakhir
        lbAlamat.Text = Alamat
        If Not String.IsNullOrWhiteSpace(Peran) Then
            Dim daftarPeran() As String = Peran.Split(","c)
            For i As Integer = 0 To daftarPeran.Length - 1
                daftarPeran(i) = daftarPeran(i).Trim()
            Next
            lbPeran.Text = "- " & String.Join(vbCrLf & "- ", daftarPeran)
        Else
            lbPeran.Text = "-"
        End If

        If Foto IsNot Nothing Then
            PictureBox1.Image = Foto
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub



End Class

