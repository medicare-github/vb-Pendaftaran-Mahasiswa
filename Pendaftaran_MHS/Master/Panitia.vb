Imports MySql.Data.MySqlClient
Public Class Panitia
    'Dim n As Random = New Random
    Sub Kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Focus()

    End Sub

    Sub tampil()
        Call Con()
        DA = New MySqlDataAdapter("select * from panitia", conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True


    End Sub

    Private Sub Panitia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        Call tampil()

    End Sub
    
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 13
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()

        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox2.MaxLength = 30
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()

        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 25
        If e.KeyChar = Chr(13) Then
            ComboBox1.Focus()

        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        ComboBox1.MaxLength = 1
        If e.KeyChar = Chr(13) Then
            ComboBox2.Focus()

        End If
    End Sub
    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        ComboBox2.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            ComboBox3.Focus()

        End If
    End Sub
    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        ComboBox3.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        TextBox4.MaxLength = 35
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()

        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        TextBox5.MaxLength = 15
        If e.KeyChar = Chr(13) Then
            TextBox6.Focus()

        End If
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        TextBox6.MaxLength = 25
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox1.Text = "" Or ComboBox2.Text = "" Or ComboBox3.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            CMD = New MySqlCommand("select * from panitia where id_panitia='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                Dim simpan As String = "insert into panitia values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & Format(dt.Value, "yyyy/MM/dd") & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()

            Else
                Call Con()
                Dim edit As String = "update user set nama_panitia='" & TextBox2.Text & "',Tempat_Lahir='" & TextBox3.Text & "',tgl_lahir='" & Format(dt.Value, "yyyy/MM/dd") & "',jk_panitia='" & ComboBox1.Text & "',Agama'" & ComboBox2.Text & "',Gol_darah='" & ComboBox3.Text & "',alamat='" & TextBox4.Text & "',Telp_panitia='" & TextBox5.Text & "',Email='" & TextBox5.Text & "' where id_panitia='" & TextBox1.Text & "'"
                CMD = New MySqlCommand(edit, conn)
                CMD.ExecuteNonQuery()
            End If
            Call Kosongkan()
            Call tampil()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Kode User Belum di isi")
            TextBox1.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Hapus Data ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Con()
                Dim hapus As String = "delete from panitia where id_panitia='" & TextBox1.Text & "'"
                CMD = New MySqlCommand(hapus, conn)
                CMD.ExecuteNonQuery()
                Call Kosongkan()
                Call tampil()

            Else
                Call Kosongkan()

            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call Kosongkan()

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        Me.Close()

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        On Error Resume Next
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        ComboBox2.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        ComboBox3.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        TextBox4.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        TextBox5.Text = DGV.Rows(e.RowIndex).Cells(8).Value
        TextBox6.Text = DGV.Rows(e.RowIndex).Cells(9).Value
        TextBox7.Text = DGV.Rows(e.RowIndex).Cells(10).Value
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Call Con()
        CMD = New MySqlCommand("select * from panitia where nama_panitia like '%" & TextBox7.Text & "%'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Call Con()
            DA = New MySqlDataAdapter("select * from panitia where nama_panitia like '%" & TextBox7.Text & "%'", conn)
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

    Private Sub MAHASISWAToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem2.Click
        Mahasiswa.Show()
        Me.Visible = False
    End Sub

    Private Sub PRODIToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PRODIToolStripMenuItem1.Click
        Prodi.Show()
        Me.Visible = False
    End Sub

    Private Sub PANITIAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PANITIAToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub USERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem1.Click
        User.Show()
        Me.Visible = False
    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        view_data_diri.Show()
        Me.Close()

    End Sub

    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Me.Close()

    End Sub
End Class