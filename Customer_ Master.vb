Imports System.Data.OleDb
Imports System.Data

Public Class Customer_Master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub navg()
        txt_cust_id.Text = ds.Tables("Customer_Master").Rows(recno).Item(0)
        Txt_cust_nam.Text = ds.Tables("Customer_Master").Rows(recno).Item(1)
        TXt_cust_address.Text = ds.Tables("Customer_Master").Rows(recno).Item(2)
        txt_cust_Mo_no.Text = ds.Tables("Customer_Master").Rows(recno).Item(3)
        cobdr_name.Text = ds.Tables("Customer_Master").Rows(recno).Item(4)
    End Sub
    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select MAX(CID) from Customer_Master", conn)
        rdr = cmd.ExecuteReader()

        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_cust_id.Text = temp
        Txt_cust_nam.Text = ""
        TXt_cust_address.Text = ""
        txt_cust_Mo_no.Text = ""
        cobdr_name.Text = ""

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
        If txt_cust_id.Text = "" Then
            MessageBox.Show(" fill the customer id")
            Exit Sub
        End If
        If Txt_cust_nam.Text = "" Then
            MessageBox.Show(" fill the customer name")
            Exit Sub
        End If
        If TXt_cust_address.Text = "" Then
            MessageBox.Show("fill the customer address")
            Exit Sub
        End If
        If txt_cust_Mo_no.Text = "" Then
            MessageBox.Show("fill the customer mobail no")
            Exit Sub
        End If
        If cobdr_name.Text = "" Then
            MessageBox.Show("fill the Dr Name")
            Exit Sub
        End If
        'cmd = New OleDbCommand("insert into Product_master value('" &   "','" &   & "','" &   & "','" &   & "','" &   & "','" &   & "')", conn)
        cmd = New OleDbCommand("insert into Customer_Master values (" & txt_cust_id.Text & ",'" & Txt_cust_nam.Text & "','" & TXt_cust_address.Text & "','" & txt_cust_Mo_no.Text & "','" & cobdr_name.Text & "')", conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")


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
        txt_cust_id.Text = ""
        Txt_cust_nam.Text = ""
        TXt_cust_address.Text = ""
        txt_cust_Mo_no.Text = ""
        cobdr_name.Text = ""

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
            ss = "update Customer_Master set customer_name='" & Txt_cust_nam.Text & "',customer_address='" & TXt_cust_address.Text & "',customer_mob_no='" & txt_cust_Mo_no.Text & "',dr_name='" & cobdr_name.Text & "'where  CID = " & txt_cust_id.Text & ""


            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record updated sucessfully")
            Customer_Master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Customer_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from Customer_Master", conn)
        da.Fill(ds, "Customer_Master")

        cmd = New OleDbCommand("select Dr_name from Doctor_Master", conn)
        rdr = cmd.ExecuteReader

        While rdr.Read
            cobdr_name.Items.Add(rdr.Item(0))
        End While
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = " delete from Customer_Master where cid =" & txt_cust_id.Text & " "
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            OpenDB()
            Customer_Master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfirst.Click
        Try
            recno = 0
            navg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprevious.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("Customer_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If

    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Customer_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If

    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("Customer_Master").Rows.Count - 1
            navg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub cobdr_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cobdr_name.SelectedIndexChanged

    End Sub
End Class