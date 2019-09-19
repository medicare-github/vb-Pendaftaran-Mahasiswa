Imports MySql.Data.MySqlClient
Public Class Prodi
    Sub tampil()
        Call Con()
        DA = New MySqlDataAdapter("select * from prodi", conn)
        DS = New DataSet
        DA.Fill(DS)
        DGV.DataSource = DS.Tables(0)
        DGV.ReadOnly = True


    End Sub
    Sub Databaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox2.Focus()
    End Sub
    Sub Kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub Prodi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampil()

    End Sub

   
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 5
        If e.KeyChar = Chr(13) Then
            Call Con()
            CMD = New MySqlCommand("select * from prodi where kdpro='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                TextBox2.Text = DR.Item("nama_prodi")
                TextBox3.Text = DR.Item("biaya")
            Else
                Call Databaru()

            End If
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox2.MaxLength = 35
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()

        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        TextBox3.MaxLength = 10
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            CMD = New MySqlCommand("select * from prodi where kdpro='" & TextBox1.Text & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Call Con()
                Dim simpan As String = "insert into prodi values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                CMD = New MySqlCommand(simpan, conn)
                CMD.ExecuteNonQuery()

            Else
                Call Con()
                Dim edit As String = "update prodi set nama_prodi='" & TextBox2.Text & "',biaya='" & TextBox3.Text & "' where kdpro='" & TextBox1.Text & "'"
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
                Dim hapus As String = "delete from prodi where kdpro='" & TextBox1.Text & "'"
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

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()

    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick
        TextBox1.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = DGV.Rows(e.RowIndex).Cells(2).Value
    End Sub

    
    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False

    End Sub

    Private Sub MAHASISWAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem.Click
        Transaksi.Show()
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

    Private Sub MAHASISWAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MAHASISWAToolStripMenuItem1.Click
        Mahasiswa.Show()
        Me.Visible = False
    End Sub

    Private Sub PRODIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODIToolStripMenuItem.Click
    End Sub

    Private Sub PANITIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANITIAToolStripMenuItem.Click
        Panitia.Show()
        Me.Visible = False

    End Sub

    Private Sub USERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem.Click
        User.Show()
        Me.Visible = False
    End Sub
End Class