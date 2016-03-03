Public Class frmThongke

    Sub FillSP()
        Dim Sql As String =
            <sql>
                SELECT * FROM SanPham
            </sql>
        Fill(Sql, "SanPham")
        bs.DataSource = ds.Tables("SanPham")
        dgvThongke.DataSource = bs
        bs.ResetBindings(False)
    End Sub
    Sub FillTimSP()
        Dim Sql As String =
              <sql>
                SELECT * FROM SanPham
                where TenSP like N'%{0}%'
            </sql>
        Sql = String.Format(Sql, txtTim.Text)
        Fill(Sql, "SanPham")
        bs.DataSource = ds.Tables("SanPham")
        dgvThongke.DataSource = bs
        bs.ResetBindings(False)
    End Sub

    Private Sub btnTim_Click(sender As Object, e As EventArgs) Handles btnTim.Click
        FillTimSP()
    End Sub

    Private Sub frmThongke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSP()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtTim.Clear()
        FillSP()
    End Sub
End Class