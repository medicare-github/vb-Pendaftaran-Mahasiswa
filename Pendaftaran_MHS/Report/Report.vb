Imports MySql.Data.MySqlClient
Public Class Report

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.ReportSource = "report MHS2.rpt"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.ReportSource = "report prodi2.rpt"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.ReportSource = "report panitia.rpt"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CRV.ReportSource = Nothing
        CRV.RefreshReport()
        CRV.ReportSource = "report dfrulg2.rpt"
    End Sub

    Private Sub REPORTMASTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REPORTMASTERToolStripMenuItem.Click
        Me.Show()

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click
        Menu_Utama_MHS.Show()
        Me.Visible = False

    End Sub

    Private Sub TransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiToolStripMenuItem.Click
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

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Visible = False

    End Sub
End Class