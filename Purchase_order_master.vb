Imports System.Data.OleDb
Imports System.Data

Public Class Purchase_order_master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand
    Dim i, TT As Integer

    Private Sub Purchase_order_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()


        Cob_distibuter.Items.Clear()
        cmd = New OleDbCommand("select distributer_id from Distributer_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Cob_distibuter.Items.Add(rdr.Item(0).ToString)
        End While

        Cmb_PID.Items.Clear()
        cmd = New OleDbCommand("select product_id from Product_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Cmb_PID.Items.Add(rdr.Item(0).ToString)
        End While
        Btnaddnew.Enabled = True
        Btnsave.Enabled = False
        Btncancel.Enabled = False
        BtnPrint.Enabled = True
        Btnexit.Enabled = True

    End Sub

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select MAX(pur_order_no)from purchase_order_master", conn)
        rdr = cmd.ExecuteReader()

        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If
        txt_purc_order_no.Text = temp

        Btnaddnew.Enabled = False
        Btnsave.Enabled = True
        Btncancel.Enabled = True
        BtnPrint.Enabled = True
        Btnexit.Enabled = False

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        If Cob_distibuter.Text = "" Then
            MessageBox.Show("Select Distributor ID")
            Exit Sub
        End If

        If txt_tax.Text = "" Then
            txt_tax.Text = "0"
        End If
        If Txt_other_char.Text = "" Then
            Txt_other_char.Text = "0"
        End If
        If Txt_discount.Text = "" Then
            Txt_discount.Text = "0"
        End If

        cmd = New OleDbCommand("INSERT INTO Purchase_order_master VALUES (" & txt_purc_order_no.Text & ",'" & DateTimePicker1.Value & "'," & Cob_distibuter.Text & ",'" & txt_dist_name.Text & "'," & Txt_amount.Text & "," & txt_tax.Text & ", " & Txt_other_char.Text & "," & Txt_discount.Text & "," & Txt_bill_amt.Text & ")", conn)
        cmd.ExecuteNonQuery()


        cmd = New OleDbCommand("INSERT INTO Purchase_order_details(srno,pur_order_no,pur_order_date,distributer_id,product_id,product_type,product_name,company,unit,mfg_date,exp_date,quantity,rate,amt) VALUES (@srno,@pur_order_no,@pur_order_date,@distributer_id,@product_id,@product_type,@product_name,@company,@unit,@mfg_date,@exp_date,@quantity,@rate,@amt)", conn)

        cmd.Parameters.AddWithValue("@srno", OleDbType.Numeric)         'this code 
        cmd.Parameters.AddWithValue("@pur_order_no", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@pur_order_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@distributer_id", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@product_id", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@product_type", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@product_name", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@company", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@unit", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@mfg_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@exp_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@quantity", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@rate", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@amt", OleDbType.Numeric)

        For j As Integer = 0 To DataGridView1.Rows.Count - 2
            cmd.Parameters(0).Value = DataGridView1.Rows(j).Cells(0).Value
            cmd.Parameters(1).Value = txt_purc_order_no.Text
            cmd.Parameters(2).Value = DateTimePicker1.Value.Date
            cmd.Parameters(3).Value = Cob_distibuter.Text
            cmd.Parameters(4).Value = DataGridView1.Rows(j).Cells(1).Value
            cmd.Parameters(5).Value = DataGridView1.Rows(j).Cells(2).Value
            cmd.Parameters(6).Value = DataGridView1.Rows(j).Cells(3).Value
            cmd.Parameters(7).Value = DataGridView1.Rows(j).Cells(4).Value
            cmd.Parameters(8).Value = DataGridView1.Rows(j).Cells(5).Value
            cmd.Parameters(9).Value = DataGridView1.Rows(j).Cells(6).Value
            cmd.Parameters(10).Value = DataGridView1.Rows(j).Cells(7).Value
            cmd.Parameters(11).Value = DataGridView1.Rows(j).Cells(9).Value
            cmd.Parameters(12).Value = DataGridView1.Rows(j).Cells(8).Value
            cmd.Parameters(13).Value = DataGridView1.Rows(j).Cells(10).Value

            cmd.ExecuteNonQuery()

        Next
        MessageBox.Show("Saved Successfuly")
        Call clear()

        Btnaddnew.Enabled = True
        Btnsave.Enabled = False
        Btncancel.Enabled = False
        BtnPrint.Enabled = True
        Btnexit.Enabled = True
    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Call clear()


        Btnaddnew.Enabled = True
        Btnsave.Enabled = False
        Btncancel.Enabled = False
        BtnPrint.Enabled = True
        Btnexit.Enabled = True
    End Sub
    Private Sub clear()
        txt_purc_order_no.Text = ""
        Cob_distibuter.Text = ""
        txt_dist_name.Text = ""

        Cmb_PID.Text = ""
        txtPtype.Text = ""
        txtPtype.Text = ""
        Txt_comp.Text = ""
        txtUnit.Text = ""
        Txt_rate.Text = ""
        Txt_qunti.Text = ""
        Txt_amt.Text = ""


        i = 0
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()

        Txt_amount.Text = ""
        txt_tax.Text = ""
        Txt_other_char.Text = ""
        Txt_discount.Text = ""
        Txt_bill_amt.Text = ""
    End Sub

    Private Sub Cob_distibuter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cob_distibuter.SelectedIndexChanged
        cmd = New OleDbCommand("select distributer_name from Distributer_master where distributer_id =" & Cob_distibuter.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_dist_name.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub Cmb_PID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_PID.SelectedIndexChanged
        cmd = New OleDbCommand("select product_type,product_name,company_name,unit from Product_master where product_id =" & Cmb_PID.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtPtype.Text = rdr.Item(0).ToString
            Txt_prod_name.Text = rdr.Item(1).ToString
            Txt_comp.Text = rdr.Item(2).ToString
            txtUnit.Text = rdr.Item(3).ToString
        End If
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
        Txt_amt.Text = Val(Txt_rate.Text) * Val(Txt_qunti.Text)
    End Sub

    Private Sub Txt_qunti_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_qunti.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub Txt_qunti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_qunti.TextChanged
        Txt_amt.Text = Val(Txt_rate.Text) * Val(Txt_qunti.Text)
    End Sub

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        If Cmb_PID.Text = "" Then
            MessageBox.Show("Select Product ID")
            Exit Sub
        End If

        If Txt_rate.Text = "" Then
            MessageBox.Show("Enter Rate")
            Exit Sub
        End If

        If Txt_qunti.Text = "" Then
            MessageBox.Show("Enter Qty")
            Exit Sub
        End If

        DataGridView1.Rows.Add()
        DataGridView1.Item(0, i).Value = (i + 1).ToString
        DataGridView1.Item(1, i).Value = Cmb_PID.Text
        DataGridView1.Item(2, i).Value = txtPtype.Text
        DataGridView1.Item(3, i).Value = Txt_prod_name.Text
        DataGridView1.Item(4, i).Value = Txt_comp.Text
        DataGridView1.Item(5, i).Value = txtUnit.Text
        DataGridView1.Item(6, i).Value = DateTimePicker2.Value.Date
        DataGridView1.Item(7, i).Value = DateTimePicker3.Value.Date
        DataGridView1.Item(8, i).Value = Txt_rate.Text
        DataGridView1.Item(9, i).Value = Txt_qunti.Text
        DataGridView1.Item(10, i).Value = Txt_amt.Text
        i = i + 1

        TT = TT + Val(Txt_amt.Text)
        Txt_amount.Text = TT.ToString
        Cmb_PID.Text = ""
        txtPtype.Text = ""
        txtPtype.Text = ""
        Txt_comp.Text = ""
        txtUnit.Text = ""
        Txt_rate.Text = ""
        Txt_qunti.Text = ""
        Txt_amt.Text = ""
    End Sub

    Private Sub Txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_amount.TextChanged
        Txt_bill_amt.Text = (Val(Txt_amount.Text) + Val(txt_tax.Text) + Val(Txt_other_char.Text)) - Val(Txt_discount.Text)
    End Sub

    Private Sub txt_tax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_tax.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If

    End Sub

    Private Sub txt_tax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tax.TextChanged
        Txt_bill_amt.Text = (Val(Txt_amount.Text) + Val(txt_tax.Text) + Val(Txt_other_char.Text)) - Val(Txt_discount.Text)
    End Sub

    Private Sub Txt_other_char_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_other_char.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub Txt_other_char_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_other_char.TextChanged
        Txt_bill_amt.Text = (Val(Txt_amount.Text) + Val(txt_tax.Text) + Val(Txt_other_char.Text)) - Val(Txt_discount.Text)
    End Sub

    Private Sub Txt_discount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_discount.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub Txt_discount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_discount.TextChanged
        Txt_bill_amt.Text = (Val(Txt_amount.Text) + Val(txt_tax.Text) + Val(Txt_other_char.Text)) - Val(Txt_discount.Text)
    End Sub

    Private Sub Btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        rptPurchaseMasterReport.Show()
    End Sub

End Class