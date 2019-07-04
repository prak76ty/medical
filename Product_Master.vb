
Imports System.Data.OleDb
Imports System.Data

Public Class Product_Master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click

        txt_pro_id.Text = ""
        Cobpro_type.Text = ""
        Txt_pro_nam.Text = ""
        TXt_com_nam.Text = ""
        cob_unit.Text = ""
        Txt_Discription.Text = ""

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

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Btnprevious.Enabled = False
        Btnsave.Enabled = True
        Dim temp As Integer
        cmd = New OleDbCommand("select max(product_id)from product_master", conn)
        rdr = cmd.ExecuteReader
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_pro_id.Text = temp
        Cobpro_type.Text = ""
        Txt_pro_nam.Text = ""
        TXt_com_nam.Text = ""
        cob_unit.Text = ""
        Txt_Discription.Text = ""

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

    Private Sub Product_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from product_Master", conn)
        da.Fill(ds, "product_master")
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click

        If txt_pro_id.Text = "" Then
            MessageBox.Show("fill the product id")
            Exit Sub
        End If
        If Cobpro_type.Text = "" Then
            MessageBox.Show(" fill the product type")
            Exit Sub
        End If
        If Txt_pro_nam.Text = "" Then
            MessageBox.Show("fill the product name")
            Exit Sub
        End If
        If TXt_com_nam.Text = "" Then
            MessageBox.Show("fill the company Name")
            Exit Sub
        End If
        If cob_unit.Text = "" Then
            MessageBox.Show("fill the unit")
            Exit Sub
        End If
        If Txt_Discription.Text = "" Then
            MessageBox.Show("fill the  Discription")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into Product_master values (" & txt_pro_id.Text & ",'" & Cobpro_type.Text & "','" & Txt_pro_nam.Text & "','" & TXt_com_nam.Text & "','" & cob_unit.Text & "','" & Txt_Discription.Text & "')", conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Product_Master_Load(sender, e)

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
        txt_pro_id.Text = ds.Tables("product_Master").Rows(recno).Item(0)
        Cobpro_type.Text = ds.Tables("Product_Master").Rows(recno).Item(1)
        Txt_pro_nam.Text = ds.Tables("product_Master").Rows(recno).Item(2)
        TXt_com_nam.Text = ds.Tables("product_Master").Rows(recno).Item(3)
        cob_unit.Text = ds.Tables("product_Master").Rows(recno).Item(4)
        Txt_Discription.Text = ds.Tables("product_Master").Rows(recno).Item(5)
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
        If (recno >= 0 And recno < ds.Tables("product_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Product_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If
    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("Product_Master").Rows.Count - 1
            navg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
 
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        Try
            ss = "update product_master set product_type='" & Cobpro_type.Text & "',product_name='" & Txt_pro_nam.Text & "',company_name='" & TXt_com_nam.Text & "',unit='" & cob_unit.Text & "',discription='" & Txt_Discription.Text & "' where product_id = " & txt_pro_id.Text & ""

            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox(" Record updated sucessfully")
            Product_Master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = "delete from product_master where product_id =" & txt_pro_id.Text & " "
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            Product_Master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

End Class