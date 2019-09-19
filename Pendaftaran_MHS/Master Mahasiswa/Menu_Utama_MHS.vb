Public Class Menu_Utama_MHS


    Private Sub LOGOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem1.Click
        Login.Show()
        Me.Close()


    End Sub

    Private Sub DAFTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAFTARToolStripMenuItem.Click
        Pendaftaran.Show()
        Me.Visible = False

    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()

    End Sub

    Private Sub PEMILIHANPROGRAMSTUDIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMILIHANPROGRAMSTUDIToolStripMenuItem.Click
        Pendaftaran2.Show()
        Me.Close()
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
        Panitia.Show()
        Me.Visible = False
    End Sub

    Private Sub USERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles USERToolStripMenuItem1.Click
        User.Show()
        Me.Visible = False
    End Sub

    Private Sub MAHASISWAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
        Transaksi.Show()
        Me.Visible = False
    End Sub

    Private Sub LIHATPROFILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIHATPROFILEToolStripMenuItem.Click
        view_data_diri.Show()
        Me.Visible = False
    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub REPORTMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTMASTERToolStripMenuItem.Click
        Report.Show()
        Me.Visible = False
    End Sub
End Class
