Imports System.Data.SqlClient
Imports System.IO
Public Class frmHoaDon
    Private Sub FillHD()
        Dim Sql As String =
            <sql>
                SELECT * FROM HoaDon
            </sql>
        Fill(Sql, "HoaDon")
        BindingSource1.DataSource = ds.Tables("HoaDon")
        dgvHD.DataSource = BindingSource1
        BindingSource1.ResetBindings(False)
    End Sub

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillHD()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub KToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KToolStripMenuItem.Click
        frmSanPham.Show()
        Me.Hide()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmKhachhang.Show()
        Me.Hide()
    End Sub

    Private Sub dgvHD_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHD.SelectionChanged
        Try
            Dim RowView As DataRowView = BindingSource1.Current
            Dim Row As DataRow = RowView.Row

            txt1.Text = Row("MaHD")
            txt2.Text = Row("MaKH")
            txt3.Text = Row("NgayLapHD")
            txt4.Text = Row("NgayNhanHang")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
                    <sql>
                        INSERT INTO HoaDon (MaHD, MaKH, NgayLapHD, NgayNhanHang)
                        VALUES ({0}, {1}, N'{2}', N'{3}')
                    </sql>
        Sql = String.Format(Sql, txt1.Text, txt2.Text, txt3.Text, txt4.Text)
        ExecuteNonQuery(Sql)
        FillHD()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String = "DELETE FROM HoaDon WHERE MaHD = N'{0}'"
        Sql = String.Format(Sql, txt1.Text)

        ExecuteNonQuery(Sql)
        FillHD()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
                    <sql>
                       UPDATE HoaDon
                        SET NgayLapHD = N'{0}', NgayNhanHang = N'{1}'
                        WHERE MaHD = {2} and MaKH = {3}
                    </sql>
        Sql = String.Format(Sql, txt3.Text, txt4.Text, txt1.Text, txt2.Text)
        ExecuteNonQuery(Sql)
        FillHD()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BindingSource1.MoveFirst()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BindingSource1.MovePrevious()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        BindingSource1.MoveLast()
    End Sub
End Class