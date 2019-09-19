Imports MySql.Data.MySqlClient
Public Class Mahasiswa
    Sub tampil()
        Call Con()
        DA = New MySqlDataAdapter("select * from mahasiswa", conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Mahasiswa_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        Call tampil()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Call Con()
        CMD = New MySqlCommand("select * from mahasiswa where nama_mahasiswa like '%" & TextBox1.Text & "%'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call Con()
            DA = New MySqlDataAdapter("select * from mahasiswa where nama_mahasiswa like '%" & TextBox1.Text & "%'", conn)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data tidak di temukan")
        End If
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub MAHASISWAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub PRODIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODIToolStripMenuItem.Click
        Prodi.Show()
        Me.Visible = False
    End Sub

    Private Sub PANITIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANITIAToolStripMenuItem.Click
        Panitia.Show()
        Me.Visible = False
    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        User.Show()
        Me.Visible = False
    End Sub

    
    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        view_data_diri.Show()
        Me.Visible = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class