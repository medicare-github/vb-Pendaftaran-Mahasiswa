Imports MySql.Data.MySqlClient

Public Class User
    Dim n As Random = New Random
    Sub Kosongkan()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox1.Focus()

    End Sub

    Sub Databaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox4.Clear()
        ComboBox1.Text = ""
        TextBox2.Focus()
    End Sub

    Sub tampil()
        Call Con()
        DA = New MySqlDataAdapter("select * from user", conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        TextBox1.Focus
        Call tampil()
        TextBox1.Enabled = False
        TextBox1.Text = "USR" & n.Next(1, 100000)



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        TextBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Call Con()
            CMD = New MySqlCommand("select * from user where id_user='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox2.Text = DR.Item("nama_user")
                TextBox3.Text = DR.Item("pass_user")
                ComboBox1.Text = DR.Item("status_user")
            Else
                Call Databaru()

            End If
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs)
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()

        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        TextBox3.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()

        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        TextBox3.MaxLength = 35
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()

        End If
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            CMD = New MySqlCommand("select * from user where id_user='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                Dim simpan As String = "insert into user values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & ComboBox1.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()

            Else

                Call Con()
                Dim edit As String = "update user set nama_user='" & TextBox2.Text & "',pass_user='" & TextBox3.Text & "',Email='" & TextBox5.Text & "',status_user='" & ComboBox1.Text & "' where id_user='" & TextBox1.Text & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
            End If
            Call Kosongkan()
            Call tampil()
            TextBox1.Text = "USR" & n.Next(1, 100000)

        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode User Belum di isi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Hapus Data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Con()
                Dim hapus As String = "delete from user where id_user='" & TextBox1.Text & "'"
                CMD = New MySqlCommand(hapus, conn)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call tampil()

            Else
                Call Kosongkan()

            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Call Kosongkan()
        TextBox1.Text = "USR" & n.Next(1, 100000)
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TextBox5.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(4).Value

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Call Con()
        CMD = New MySqlCommand("select * from user where nama_user like '%" & TextBox4.Text & "%'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call Con()
            DA = New MySqlDataAdapter("select * from user where nama_user like '%" & TextBox4.Text & "%'", conn)
            DS = New DataSet
            DA.Fill(DS)
            DGV.DataSource = DS.Tables(0)
        Else
            MsgBox("Data tidak di temukan")
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        ComboBox1.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        Me.Close()

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False
    End Sub

    Private Sub MAHASISWAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem.Click
        Mahasiswa.Show()
        Me.Visible = False
    End Sub

    Private Sub PRODIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODIToolStripMenuItem.Click
        Prodi.Show()
        Me.Visible = False
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PANITIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANITIAToolStripMenuItem.Click
        Panitia.Show()
        Me.Visible = False

    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        view_data_diri.Show()
        Me.Visible = False
    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Me.Close()

    End Sub
End Class