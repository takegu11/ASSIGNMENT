Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmSanPham.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmKhachhang.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmHoaDon.Show()
    End Sub

    Private Sub LogoffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoffToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmThongke.Show()

    End Sub
End Class
