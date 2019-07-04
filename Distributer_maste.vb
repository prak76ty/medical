Imports System.Data.OleDb
Imports System.Data
Public Class Distributer_Master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand
    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub
    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("Distributer_master").Rows.Count - 1
            navg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Distributer_master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If
    End Sub


    Private Sub Btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprevious.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("Distributer_master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub


    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfirst.Click
        Try
            recno = 0
            navg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click

        Try
            ss = "update Distributer_master set distributer_name='" & TXt_dist_name.Text & "',contact_person='" & Txt_cont_person.Text & "',address='" & txt_address.Text & "',city='" & Txt_city.Text & "',district='" & Txt_District.Text & "' where distributer_id = " & txt_dist_id.Text & ""
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox(" Record updated sucessfully")
            Dtributer_master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = " delete from Distributer_master where distributer_id =" & txt_dist_id.Text & ""
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            OpenDB()
            Dtributer_master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        txt_dist_id.Text = ""
        TXt_dist_name.Text = ""
        Txt_cont_person.Text = ""
        txt_address.Text = ""
        Txt_city.Text = ""
        Txt_District.Text = ""


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


    Private Sub Dtributer_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from Distributer_master", conn)
        da.Fill(ds, "Distributer_master")
    End Sub

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click

        Dim temp As Integer
        cmd = New OleDbCommand("select max(distributer_id)from Distributer_master", conn)
        rdr = cmd.ExecuteReader
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_dist_id.Text = temp
        TXt_dist_name.Text = ""
        Txt_cont_person.Text = ""
        txt_address.Text = ""
        Txt_city.Text = ""
        Txt_District.Text = ""


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

        If TXt_dist_name.Text = "" Then
            MessageBox.Show(" fill the Distributer name")
            Exit Sub
        End If
        If Txt_cont_person.Text = "" Then
            MessageBox.Show("fill the contact person")
            Exit Sub
        End If
        If txt_address.Text = "" Then
            MessageBox.Show("fill the address name")
            Exit Sub
        End If
        If Txt_city.Text = "" Then
            MessageBox.Show("fill the city")
            Exit Sub
        End If
        If Txt_District.Text = "" Then
            MessageBox.Show("fill the District")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into Distributer_master values ('" & txt_dist_id.Text & "','" & TXt_dist_name.Text & "','" & Txt_cont_person.Text & "','" & txt_address.Text & "','" & Txt_city.Text & "','" & Txt_District.Text & "')", conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Dtributer_master_Load(sender, e)

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
    Private Sub navg()
        txt_dist_id.Text = ds.Tables("Distributer_master").Rows(recno).Item(0)
        TXt_dist_name.Text = ds.Tables("Distributer_master").Rows(recno).Item(1)
        Txt_cont_person.Text = ds.Tables("Distributer_master").Rows(recno).Item(2)
        txt_address.Text = ds.Tables("Distributer_master").Rows(recno).Item(3)
        Txt_city.Text = ds.Tables("Distributer_master").Rows(recno).Item(4)
        Txt_District.Text = ds.Tables("Distributer_master").Rows(recno).Item(5)

    End Sub

    Private Sub txt_dist_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_dist_id.TextChanged

    End Sub
End Class
