Imports MySql.Data.MySqlClient
Module Koneksi
    Public conn As MySqlConnection 'untuk mengkoneksikan ke db
    Public CMD As MySqlCommand 'mengirim command ke db
    Public DR As MySqlDataReader 'mengambil data ke db
    Public DA As MySqlDataAdapter 'menampilkan data dari db
    Public DS As DataSet 'tool dari vb yang mengubah tabel menjadi variabel array
    Public user As String


    Sub Con()
        Try
            Dim query As String = "server=localhost;Uid=root;Pwd=;Database=pdfmhs;Port=3306"
            conn = New MySqlConnection(query)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Sub crud(ByVal q As String)
    '    Try
    '        Dim query As String = q
    '        CMD = New MySqlCommand(query, conn)
    '        cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "error")
    '    End Try

    'End Sub
End Module
