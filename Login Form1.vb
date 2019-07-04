Public Class Login_Form1
    Private Sub But_OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_OK.Click
        If (Txtuname.Text = "1" And txtpw.Text = "1") Then
            MDI.Show()
            Me.Hide()
        Else
            MessageBox.Show("login failed")
        End If
    End Sub

    Private Sub But_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles But_exit.Click
        Me.Close()
    End Sub

    Private Sub Btncancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancle.Click
        Txtuname.Text = ""
        txtpw.Text = ""
    End Sub
End Class