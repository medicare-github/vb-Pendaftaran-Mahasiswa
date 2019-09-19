Imports MySql.Data.MySqlClient
Public Class Pendaftaran
    Dim n As Random = New Random
    Sub Kosongkan()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

    End Sub

    Private Sub Label18_Click_1(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Pendaftaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub

        Else
            Call Con()
            CMD = New MySqlCommand("select * from mahasiswa where nis='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                Dim simpan As String = "insert into mahasiswa values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & Format(dt.Value, "yyyy/MM/dd") & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                Call Kosongkan()

            Else
                Call Con()
                Dim edit As String = "update mahasiswa set nama_mahasiswa='" & TextBox3.Text & "',tempat_lahir='" & TextBox4.Text & "',tgl_lahir='" & Format(dt.Value, "yyyy/MM/dd") & "',jk_mahasiswa='" & ComboBox1.Text & "',agama='" & ComboBox2.Text & "',gol_darah='" & ComboBox3.Text & "',alamat='" & TextBox5.Text & "',asal_sekolah='" & TextBox6.Text & "',telp_mahasiswa='" & TextBox7.Text & "',email='" & TextBox8.Text & "' where nis='" & TextBox2.Text & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()

            End If
        End If
        Me.Visible = False
        Pendaftaran2.Show()

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Call Con()
            CMD = New MySqlCommand("select * from mahasiswa where nis='" & TextBox2.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                MsgBox("NIS ANDA SUDAH TERDAPTAR")
                view_data_diri.Show()
                Me.Visible = False

            Else
            End If
        End If
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        Transaksi.Show()
        Me.Visible = False
    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()

        Me.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Kosongkan()
    End Sub
End Class