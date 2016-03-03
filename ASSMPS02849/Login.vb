Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim U As String
        Dim P As String
        U = txt1.Text
        P = txt2.Text
        If U = "" Then
            MsgBox("Bạn chưa nhập User", MsgBoxStyle.OkOnly, "Lỗi")
            txt1.Focus()
            Return
        End If
        If P = "" Then
            MsgBox("Bạn chưa nhập Pass", MsgBoxStyle.OkOnly, "Lỗi")
            txt2.Focus()
            Return
        End If
        If U = "ps02849" And P = "123456" Then
            frmMain.Show()
            Me.Hide()
        Else
            MsgBox("User or password không đúng", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
