Imports System.Data.SqlClient
Imports System.IO
Public Class frmSanPham
    Private Sub FillSP()
        Dim Sql4 As String =
            <sql>
                SELECT * FROM SanPham
            </sql>
        Fill(Sql4, "SanPham")
        BindingSource1.DataSource = ds.Tables("SanPham")
        dgvSanpham.DataSource = BindingSource1
        BindingSource1.ResetBindings(False)
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim Sql As String =
                    <sql>
                        INSERT INTO SanPham (MaSp, TenSP, DonGia, MaLoai) 
                        VALUES ({0}, N'{1}', N'{2}', {3})
                    </sql>
        Sql = String.Format(Sql, txt1.Text, txt2.Text, txt3.Text, cbo1.SelectedValue)
        ExecuteNonQuery(Sql)
        FillSP()

    End Sub

    Private Sub Sanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillSP()
        Fillcbo1()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim Sql As String = "DELETE FROM SanPham WHERE MaSP = N'{0}'"
        Sql = String.Format(Sql, txt1.Text)

        ExecuteNonQuery(Sql)
        FillSP()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
    End Sub

    Private Sub dgvSanpham_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSanpham.SelectionChanged
        Try
            Dim RowView As DataRowView = BindingSource1.Current
            Dim Row As DataRow = RowView.Row

            txt1.Text = Row("MaSP")
            txt2.Text = Row("TenSP")
            txt3.Text = Row("DonGia")
            cbo1.Text = Row("MaLoai")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim Sql As String =
                    <sql>
                       UPDATE SanPham 
                        SET TenSP = N'{0}', DonGia = N'{1}'
                        WHERE MaSp = {2} and MaLoai = {3}
                    </sql>
        Sql = String.Format(Sql, txt2.Text, txt3.Text, txt1.Text, cbo1.SelectedValue)
        ExecuteNonQuery(Sql)
        FillSP()
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

    Private Sub KToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KToolStripMenuItem.Click
        frmKhachhang.Show()
        Me.Hide()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frmMain.Show()
        Me.Hide()
    End Sub
    Sub Fillcbo1()
        Dim Sql As String = "SELECT * FROM SanPham"

        Fill(Sql, "SanPham")

        cbo1.DataSource = ds.Tables("SanPham")
        cbo1.DisplayMember = "MaLoai"
        cbo1.ValueMember = "MaLoai"
    End Sub
End Class