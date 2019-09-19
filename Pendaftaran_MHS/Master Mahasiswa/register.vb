Imports MySql.Data.MySqlClient
Public Class register
    Dim n As Random = New Random
    Sub Kosongkan()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()

    End Sub

    Sub Databaru()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Kosongkan()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Belum Lengkap")
            Exit Sub
        Else
            Call Con()
            Dim simpan As String = "insert into user values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            CMD = New MySqlCommand(simpan, conn)
            CMD.ExecuteNonQuery()
            TextBox1.Text = "USR" & n.Next(1, 100000)

        End If
        Login.Show()
        Me.Visible = False



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        TextBox1.MaxLength = 10
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
        TextBox3.MaxLength = 15
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()

        End If
    End Sub
    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        TextBox3.MaxLength = 35
        If e.KeyChar = Chr(13) Then
            Button1.Focus()

        End If
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Con()
        TextBox1.Enabled = False
        TextBox1.Text = "USR" & n.Next(1, 100000)
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Visible = False
        Login.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class