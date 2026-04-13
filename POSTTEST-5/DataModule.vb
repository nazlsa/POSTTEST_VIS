Imports MySqlConnector

Module DataModule

    Private Function ParseAngka(nilai As String) As Integer
        Return Convert.ToInt32(nilai.Trim().Replace(".", "").Replace(",", ""))
    End Function

    Public Function GetAllBatik() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT ID, Motif, Kategori, Ukuran, Stok, Harga " &
                "FROM dbbatik ORDER BY ID ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchBatik(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT ID, Motif, Kategori, Ukuran, Stok, Harga " &
                "FROM dbbatik " &
                "WHERE ID LIKE @keyword OR Motif LIKE @keyword " &
                "ORDER BY ID ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetBatikByID(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT ID, Motif, Kategori, Ukuran, Stok, Harga " &
                "FROM dbbatik WHERE ID = @ID"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@ID", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function IDAda(id As String) As Boolean
        Try
            Dim query As String =
                "SELECT COUNT(*) FROM dbbatik WHERE ID = @ID"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanBatik(id As String, nama As String, kategori As String,
                                ukuran As String, stok As String, harga As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO dbbatik (ID, Motif, Kategori, Ukuran, Stok, Harga) " &
                "VALUES (@ID, @Motif, @Kategori, @Ukuran, @Stok, @Harga)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Motif", nama)
                    cmd.Parameters.AddWithValue("@Kategori", kategori)
                    cmd.Parameters.AddWithValue("@Ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@Stok", ParseAngka(stok))
                    cmd.Parameters.AddWithValue("@Harga", ParseAngka(harga))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahBatik(id As String, nama As String, kategori As String,
                              ukuran As String, stok As String, harga As String) As Boolean
        Try
            Dim query As String =
                "UPDATE dbbatik SET Motif = @Motif, Kategori = @Kategori, " &
                "Ukuran = @Ukuran, Stok = @Stok, Harga = @Harga " &
                "WHERE ID = @ID"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    cmd.Parameters.AddWithValue("@Motif", nama)
                    cmd.Parameters.AddWithValue("@Kategori", kategori)
                    cmd.Parameters.AddWithValue("@Ukuran", ukuran)
                    cmd.Parameters.AddWithValue("@Stok", ParseAngka(stok))
                    cmd.Parameters.AddWithValue("@Harga", ParseAngka(harga))
                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    Return rows > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusBatik(id As String) As Boolean
        Try
            Dim query As String =
                "DELETE FROM dbbatik WHERE ID = @ID"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module