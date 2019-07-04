Imports System.Data.OleDb
Imports System.Data
Public Class Expanses
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub navg()
        txt_ex_no.Text = ds.Tables("Expanses").Rows(recno).Item(0)
        DateTime1.Text = ds.Tables("Expanses").Rows(recno).Item(1)
        Txt_expa_Discrip.Text = ds.Tables("Expanses").Rows(recno).Item(2)
        txt_ex_amt.Text = ds.Tables("Expanses").Rows(recno).Item(3)
        Txt_ex_bywhom.Text = ds.Tables("Expanses").Rows(recno).Item(4)
    End Sub
    Private Sub Expanses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from Expanses", conn)
        da.Fill(ds, "Expanses")
    End Sub

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select MAX(E_No) from Expanses", conn)
        rdr = cmd.ExecuteReader()

        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_ex_no.Text = temp
        DateTime1.Text = ""
        Txt_expa_Discrip.Text = ""
        txt_ex_amt.Text = ""
        Txt_ex_bywhom.Text = ""

        Btnaddnew.Enabled = False
        Btndelete.Enabled = False
        Btnupdate.Enabled = False
        Btnfirst.Enabled = False
        Btnlast.Enabled = False
        Btnnext.Enabled = False
        Btnprevious.Enabled = False
        Btnfind.Enabled = False
        Btnexit.Enabled = False

        Btnsave.Enabled = True
        Btncancel.Enabled = True

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        If txt_ex_no.Text = "" Then
            MessageBox.Show(" fill the expanses no")
            Exit Sub
        End If
        If DateTime1.Text = "" Then
            MessageBox.Show(" fill the date")
            Exit Sub
        End If
        If Txt_expa_Discrip.Text = "" Then
            MessageBox.Show("fill the expanses discription")
            Exit Sub
        End If
        If txt_ex_amt.Text = "" Then
            MessageBox.Show("fill the expanses amt")
            Exit Sub
        End If
        If Txt_ex_bywhom.Text = "" Then
            MessageBox.Show("fill the expanses bywhom")
            Exit Sub
        End If
        cmd = New OleDbCommand("insert into Expanses values (" & txt_ex_no.Text & ",'" & DateTime1.Text & "','" & Txt_expa_Discrip.Text & "','" & txt_ex_amt.Text & "','" & Txt_ex_bywhom.Text & "')", conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Expanses_Load(sender, e)

        Btnaddnew.Enabled = True
        Btndelete.Enabled = True
        Btnupdate.Enabled = True
        Btnfirst.Enabled = True
        Btnlast.Enabled = True
        Btnnext.Enabled = True
        Btnprevious.Enabled = True
        Btnfind.Enabled = True
        Btnexit.Enabled = True

        Btnsave.Enabled = False
        Btncancel.Enabled = False
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click

        txt_ex_no.Text = ""
        DateTime1.Text = ""
        Txt_expa_Discrip.Text = ""
        txt_ex_amt.Text = ""
        Txt_ex_bywhom.Text = ""
        Btnaddnew.Enabled = True
        Btndelete.Enabled = True
        Btnupdate.Enabled = True
        Btnfirst.Enabled = True
        Btnlast.Enabled = True
        Btnnext.Enabled = True
        Btnprevious.Enabled = True
        Btnfind.Enabled = True
        Btnexit.Enabled = True

        Btnsave.Enabled = False
        Btncancel.Enabled = False

    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        Try
            ss = "update Expanses set E_Rate= '" & DateTime1.Value & "' , E_Discription= '" & Txt_expa_Discrip.Text & "' , E_amt= " & txt_ex_amt.Text & " ,E_bywhom= '" & Txt_ex_bywhom.Text & "'where  E_No = " & txt_ex_no.Text & ""

            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record updated sucessfully")
            Expanses_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = "delete from Expanses where E_No =" & txt_ex_no.Text & " "
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            Expanses_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfirst.Click
        Try
            recno = 0
            navg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprevious.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("Expanses").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Expanses").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If

    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("Expanses").Rows.Count - 1
            navg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub txt_ex_amt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ex_amt.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub txt_ex_amt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ex_amt.TextChanged

    End Sub
End Class