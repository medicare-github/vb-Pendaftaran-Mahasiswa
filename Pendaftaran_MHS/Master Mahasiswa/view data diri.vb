Imports MySql.Data.MySqlClient
Public Class view_data_diri


    Sub Kosongkan()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox13.Text = Nothing
        TextBox14.Text = Nothing
        TextBox15.Text = Nothing
        TextBox16.Text = Nothing


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        Pendaftaran.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Con()
        CMD = New MySqlCommand("select * from mahasiswa where nis='" & TextBox1.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox2.Text = DR.Item("nama_mahasiswa")
            TextBox3.Text = DR.Item("tempat_lahir")
            TextBox4.Text = DR.Item("tgl_lahir")
            TextBox8.Text = DR.Item("alamat")
            TextBox9.Text = DR.Item("asal_sekolah")
            TextBox10.Text = DR.Item("telp_mahasiswa")
            TextBox11.Text = DR.Item("email")
            TextBox5.Text = DR.Item("jk_mahasiswa")
            TextBox6.Text = DR.Item("agama")
            TextBox7.Text = DR.Item("gol_darah")

            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
            TextBox8.Enabled = False
            TextBox9.Enabled = False
            TextBox10.Enabled = False
            TextBox11.Enabled = False
        Else
            MsgBox("NIS YANG ANDA MASUKAN SALAH")
        End If
        DR.Close()
        Call Con()
        CMD = New MySqlCommand("select * from pendaftaran where nis='" & TextBox1.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox12.Text = DR.Item("id_pendaftaran")
            TextBox14.Text = DR.Item("kode_prodi")
            TextBox12.Enabled = False
            TextBox13.Enabled = False
            TextBox14.Enabled = False
        Else
        End If
        DR.Close()
        DR.Close()
        Call Con()
        CMD = New MySqlCommand("select * from prodi where kdpro='" & TextBox14.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox15.Text = DR.Item("nama_prodi")
            TextBox13.Text = DR.Item("biaya")
            TextBox15.Enabled = False
            
        Else
        End If
        DR.Close()
        DR.Close()
        Call Con()
        CMD = New MySqlCommand("select * from transaksi where id_pendaftaran='" & TextBox12.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            TextBox16.Text = DR.Item("status_bayar")
            TextBox16.Enabled = False

        Else

        End If
        DR.Close()

    End Sub


    Private Sub FORMDAFTARDATADIRIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORMDAFTARDATADIRIToolStripMenuItem.Click
        Pendaftaran.Show()
        Me.Visible = False
    End Sub

    Private Sub PEMILIHANPROGRAMSTUDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMILIHANPROGRAMSTUDIToolStripMenuItem.Click
        Pendaftaran2.Show()
        Me.Visible = False

    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        Transaksi.Show()
        Me.Visible = False

    End Sub

    
    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        Call Con()
    End Sub

    Private Sub view_data_diri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox16.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Kosongkan()

    End Sub
End Class