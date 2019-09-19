Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()

        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Con()
        CMD = New mySqlCommand("select * from user where nama_user='" & TextBox1.Text & "' and pass_user='" & TextBox2.Text & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            MsgBox("Username atau Password yang anda masukan salah")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()
        Else
            Me.Visible = False
            Menu_Utama_MHS.Show()
            Call Con()
            Menu_Utama_MHS.p1.Text = DR.Item("id_user")
            Menu_Utama_MHS.p2.Text = DR.Item("nama_user")
            Menu_Utama_MHS.p3.Text = DR.Item("status_user")
            TextBox1.Clear()
            TextBox2.Clear()
            If Menu_Utama_MHS.p3.Text = "MAHASISWA" Then
                Menu_Utama_MHS.DATAMASTERToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.REPORTMASTERToolStripMenuItem.Enabled = False
            ElseIf Menu_Utama_MHS.p3.Text = "ADMIN" Then
                Menu_Utama_MHS.DAFTARToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.PEMILIHANPROGRAMSTUDIToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.USERToolStripMenuItem1.Enabled = False
                Menu_Utama_MHS.PANITIAToolStripMenuItem1.Enabled = False
            ElseIf Menu_Utama_MHS.p3.Text = "OPERATOR" Then
                Menu_Utama_MHS.DAFTARToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.TransaksiToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.PEMILIHANPROGRAMSTUDIToolStripMenuItem.Enabled = False
                Menu_Utama_MHS.REPORTMASTERToolStripMenuItem.Enabled = False

            End If

        End If


    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Visible = False
        register.Show()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class