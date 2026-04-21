Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication

        ' Saat aplikasi mulai, jalankan FormLogin terlebih dahulu
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim frmLogin As New FormLogin()
            frmLogin.ShowDialog()
        End Sub

    End Class
End Namespace