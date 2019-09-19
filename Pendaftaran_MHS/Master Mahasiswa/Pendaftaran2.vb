Imports MySql.Data.MySqlClient

Public Class Pendaftaran2

    Dim n As Random = New Random
   

    Private Sub Pendaftaran2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        TextBox1.Enabled = False
        TextBox1.Text = "DFL" & n.Next(1, 100000)
        CMD = New MySqlCommand("select * from prodi", conn)
        DR = CMD.ExecuteReader
        Do While DR.Read
            ComboBox1.Items.Add(DR.Item(1))
        Loop

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            CMD = New MySqlCommand("select * from pendaftaran where nis='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                Dim simpan As String = "insert into pendaftaran values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & Format(dt.Value, "yyyy/MM/dd") & "','" & TextBox4.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()

            Else
                Call Con()
                Dim edit As String = "update pendaftaran set kode_prodi='" & TextBox4.Text & "' where nis='" & TextBox2.Text & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
            End If
            DR.Close()
        End If
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Call Con()
            CMD = New MySqlCommand("select * from mahasiswa where nis='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox3.Text = DR.Item("nama_mahasiswa")
            Else
                MsgBox("NOMOR INDUK SISWA YANG ANDA MASUKAN SALAH")

            End If
            DR.Close()
            Call Con()
            CMD = New MySqlCommand("select * from pendaftaran where nis='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox1.Text = DR.Item("id_pendaftaran")
            Else

            End If
            DR.Close()

        End If
    End Sub
    
     
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Con()
        CMD = New MySqlCommand("select * from prodi where nama_prodi='" & ComboBox1.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        TextBox4.Text = DR.Item("kdpro")
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        Me.Visible = False
        view_data_diri.Show()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False

    End Sub

    Private Sub PENDAFTARANDATADIRIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PENDAFTARANDATADIRIToolStripMenuItem.Click
        Pendaftaran.Show()
        Me.Visible = False

    End Sub

    Private Sub PEMILIHAMPROGRAMSTUDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMILIHAMPROGRAMSTUDIToolStripMenuItem.Click
        Me.Show()
        Me.Visible = False
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        Transaksi.Show()
        Me.Visible = False
    End Sub


    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()


        
    End Sub
End Class