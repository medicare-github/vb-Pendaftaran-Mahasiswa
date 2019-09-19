Imports MySql.Data.MySqlClient
Public Class Transaksi
    Dim n As Random = New Random
    Sub Kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox1.Text = ""

    End Sub

    Sub tampil()
        Call Con()
        DA = New MySqlDataAdapter("select * from transaksi", conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True


    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
        
    End Sub

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        TextBox1.Focus()
        Call tampil()
        TextBox1.Enabled = False
        TextBox1.Text = "TRS" & n.Next(1, 100000)
        CMD = New MySqlCommand("select * from panitia", conn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(0))
        Loop
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
            Call Con()
            CMD = New MySqlCommand("select * from pendaftaran where id_pendaftaran='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox9.Text = DR.Item("kode_prodi")

                TextBox3.Enabled = False
            Else
                MsgBox("ID PENDAFTARAN")
            End If
            DR.Close()
            Call Con()
            CMD = New MySqlCommand("select * from prodi where kdpro='" & TextBox9.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox3.Text = DR.Item("biaya")
                TextBox3.Enabled = False
            Else
            End If
            DR.Close()

        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 13
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()

        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()

        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        TextBox5.MaxLength = 13
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()

        End If
    End Sub
    

   
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            'Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or TextBox7.Text = "
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            CMD = New MySqlCommand("select * from transaksi where id_transaksi='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                If TextBox4.Text >= TextBox3.Text Then
                    TextBox7.Text = "LUNAS"
                Else
                    TextBox7.Text = "TIDAK LUNAS"
                End If
                Call Con()
                TextBox5.Text = TextBox3.Text - TextBox4.Text
                'CMD = New MySqlCommand("select * from transaksi where id_transaksi='" & TextBox1.Text & "'", conn)
                'DR = CMD.ExecuteReader
                'DR.Read()
                'TextBox5.Text = DR.Item("sisa_pembayaran")
                Dim simpan As String = "insert into transaksi values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & Format(dt.Value, "yyyy/MM/dd") & "','" & TextBox7.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()

            Else
                'Call Con()
                'Dim edit As String = "update transaksi set pembayaran='" & TextBox4.Text & "',sisa_pembayaran='" & TextBox5.Text & "',tgl_pembayaran= '" & Format(dt.Value, "yyyy/MM/dd") & "',status_bayar='" & TextBox7.Text & "' where id_pendaftaran='" & TextBox2.Text & "'"
                'CMD = New MySqlCommand(edit, conn)
                'CMD.ExecuteNonQuery()
            End If
            Call Kosongkan()
            Call tampil()
            TextBox1.Text = "USR" & n.Next(1, 100000)

        End If
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub MAHASISWAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        view_data_diri.Show()
        Me.Visible = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Me.Close()


    End Sub

    Private Sub Label9_Click_1(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub REPORTMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTMASTERToolStripMenuItem.Click
        Report.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Call Con()
        CMD = New MySqlCommand("select * from transaksi where id_pendaftaran like '%" & TextBox8.Text & "%'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call Con()
            DA = New MySqlDataAdapter("select * from transaksi where id_pendaftaran like '%" & TextBox8.Text & "%'", conn)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data tidak di temukan")
        End If
    End Sub
End Class