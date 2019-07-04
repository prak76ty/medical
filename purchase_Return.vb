Imports System.Data.OleDb
Imports System.Data
Public Class purchase_Return
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub Btn_addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_addnew.Click
        Btnprevious.Enabled = False
        Btnsave.Enabled = True
        Dim temp As Integer
        cmd = New OleDbCommand("select max(pur_rate_no)from purchase_return", conn)
        rdr = cmd.ExecuteReader
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If
        txt_pur_re_no.Text = temp

        Txt_pur_or_date.Text = ""
        Cob_pur_or_no.Text = ""
        txtDistID.Text = ""
        Txt_dis_name.Text = ""
        cmbPID.Text = ""
        txt_prod_name.Text = ""
        Txt_pro_type.Text = ""
        Txt_rate.Text = ""
        Txt_pro_qun.Text = ""
        txtAmt.Text = ""


        Btn_addnew.Enabled = False
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
        If Cob_pur_or_no.Text = "" Then
            MessageBox.Show("Select Purchase Order Number")
            Exit Sub
        End If

        If cmbPID.Text = "" Then
            MessageBox.Show("Select Product ID")
            Exit Sub
        End If

        If Txt_pro_qun.Text = "" Then
            MessageBox.Show("Enter Qty")
            Exit Sub
        End If

        If Txt_rate.Text = "" Then
            MessageBox.Show("Enter Rate")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into purchase_return values (" & txt_pur_re_no.Text & ",'" & DateTimePicker1.Value.Date & "'," & Cob_pur_or_no.Text & ",'" & Txt_pur_or_date.Text & "'," & txtDistID.Text & ",'" & Txt_dis_name.Text & "'," & cmbPID.Text & ",'" & txt_prod_name.Text & "','" & Txt_pro_type.Text & "'," & Txt_pro_qun.Text & "," & Txt_rate.Text & ")", conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        purchase_Return_Load(sender, e)

        Btn_addnew.Enabled = True
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

    Private Sub purchase_Return_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from purchase_return", conn)
        da.Fill(ds, "purchase_return")

        Cob_pur_or_no.Items.Clear()
        cmd = New OleDbCommand("select pur_order_no from Purchase_order_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Cob_pur_or_no.Items.Add(rdr.Item(0).ToString)
        End While

    End Sub
    Private Sub navg()
        txt_pur_re_no.Text = ds.Tables("purchase_return").Rows(recno).Item(0)
        DateTimePicker1.Value = ds.Tables("purchase_return").Rows(recno).Item(1)
        Cob_pur_or_no.Text = ds.Tables("purchase_return").Rows(recno).Item(2)
        Txt_pur_or_date.Text = ds.Tables("purchase_return").Rows(recno).Item(3)
        txtDistID.Text = ds.Tables("purchase_return").Rows(recno).Item(4)
        Txt_dis_name.Text = ds.Tables("purchase_return").Rows(recno).Item(5)
        cmbPID.Text = ds.Tables("purchase_return").Rows(recno).Item(6)
        txt_prod_name.Text = ds.Tables("purchase_return").Rows(recno).Item(7)
        Txt_pro_type.Text = ds.Tables("purchase_return").Rows(recno).Item(8)
        Txt_pro_qun.Text = ds.Tables("purchase_return").Rows(recno).Item(9)
        Txt_rate.Text = ds.Tables("purchase_return").Rows(recno).Item(10)
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click

        txt_pur_re_no.Text = ""
        Txt_pur_or_date.Text = ""
        Cob_pur_or_no.Text = ""
        txtDistID.Text = ""
        Txt_dis_name.Text = ""
        cmbPID.Text = ""
        txt_prod_name.Text = ""
        Txt_pro_type.Text = ""
        Txt_rate.Text = ""
        Txt_pro_qun.Text = ""
        txtAmt.Text = ""


        Btn_addnew.Enabled = True
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
            ss = "update purchase_return set pur_rate_date='" & DateTimePicker1.Value & "',pur_or_no=" & Cob_pur_or_no.Text & ",pur_order_date='" & Txt_pur_or_date.Text & "',distributer_id=" & txtDistID.Text & ",distributer_name='" & Txt_dis_name.Text & "',product_id=" & cmbPID.Text & ",product_name='" & txt_prod_name.Text & "',product_type='" & Txt_pro_type.Text & "',product_quntity=" & Txt_pro_qun.Text & ",rate=" & Txt_rate.Text & " where pur_rate_no=" & txt_pur_re_no.Text & ""

            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox(" Record updated sucessfully")
            purchase_Return_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = " delete from purchase_return where pur_rate_no =" & txt_pur_re_no.Text & " "
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            purchase_Return_Load(sender, e)

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
        If (recno >= 0 And recno < ds.Tables("purchase_return").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("purchase_return").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If
    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("purchase_return").Rows.Count - 1
            navg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub Btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfind.Click

    End Sub


    Private Sub Cob_pur_or_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cob_pur_or_no.SelectedIndexChanged
        cmd = New OleDbCommand("select pur_order_date,distributer_id, distributer_name from Purchase_order_master where pur_order_no =" & Cob_pur_or_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            Txt_pur_or_date.Text = rdr.Item(0).ToString
            txtDistID.Text = rdr.Item(1).ToString
            Txt_dis_name.Text = rdr.Item(2).ToString
        End If

        cmbPID.Items.Clear()
        cmd = New OleDbCommand("select product_id from Purchase_order_details where pur_order_no =" & Cob_pur_or_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cmbPID.Items.Add(rdr.Item(0).ToString)
        End While
    End Sub

    Private Sub cmbPID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPID.SelectedIndexChanged

        cmd = New OleDbCommand("select product_name,product_type from Product_master where product_id =" & cmbPID.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_prod_name.Text = rdr.Item(0).ToString
            Txt_pro_type.Text = rdr.Item(1).ToString
        End If

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub

    Private Sub Txt_pro_qun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_pro_qun.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub Txt_pro_qun_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_pro_qun.TextChanged
        txtAmt.Text = Val(Txt_pro_qun.Text) * Val(Txt_rate.Text)
    End Sub

    Private Sub Txt_rate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rate.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub Txt_rate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_rate.TextChanged
        txtAmt.Text = Val(Txt_pro_qun.Text) * Val(Txt_rate.Text)
    End Sub
End Class