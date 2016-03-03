Imports System.Data.SqlClient
Imports System.IO
Public Class frmKhachhang
    Private Sub FillKH()
        Dim Sql As String =
            <sql>
                SELECT * FROM KHACHHANG
            </sql>
        Fill(Sql, "KHACHHANG")
        BindingSource1.DataSource = ds.Tables("KHACHHANG")
        dgvKH.DataSource = BindingSource1
        BindingSource1.ResetBindings(False)
    End Sub
    Private Sub frmKhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillKH()
    End Sub

    Private Sub dgvKH_SelectionChanged(sender As Object, e As EventArgs) Handles dgvKH.SelectionChanged
        Try
            Dim RowView As DataRowView = BindingSource1.Current
            Dim Row As DataRow = RowView.Row

            txt1.Text = Row("MaKH")
            txt2.Text = Row("HoTenKH")
            txt3.Text = Row("DiaChi")
            txt4.Text = Row("DienThoai")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql1 As String =
                    <sql>
                        INSERT INTO KHACHHANG (MaKH, HoTenKH, DiaChi, DienThoai)
                        VALUES ({0}, N'{1}', N'{2}', {3})
                    </sql>
        Sql1 = String.Format(Sql1, txt1.Text, txt2.Text, txt3.Text, txt4.Text)
        ExecuteNonQuery(Sql1)
        FillKH()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String = "DELETE FROM KHACHHANG WHERE MaKH = N'{0}'"
        Sql = String.Format(Sql, txt1.Text)

        ExecuteNonQuery(Sql)
        FillKH()
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
                    <sql>
                       UPDATE KHACHHANG
                        SET HoTenKH = N'{0}', DiaChi = N'{1}',DienThoai = {2}
                        WHERE MaKH = {3} 
                    </sql>
        Sql = String.Format(Sql, txt2.Text, txt3.Text, txt4.Text, txt1.Text)
        ExecuteNonQuery(Sql)
        FillKH()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub KToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KToolStripMenuItem.Click
        frmSanPham.Show()
        Me.Hide()
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

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
        Me.Hide()
    End Sub
End Class