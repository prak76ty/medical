
Imports System.Data.OleDb
Imports System.Data
Public Class sales_order_master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand
    Dim i, TT As Integer

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select MAX (sales_order_no)from Sales_order_master", conn)
        rdr = cmd.ExecuteReader()

        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_sale_order_no.Text = temp

        Btnaddnew.Enabled = False
        Btnsave.Enabled = True
        Btncancel.Enabled = True
        BtnPrint.Enabled = True
        Btnexit.Enabled = False
    End Sub

    Private Sub sales_order_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()

        cmbDrID.Items.Clear()
        cmd = New OleDbCommand("select Dr_id from Doctor_Master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cmbDrID.Items.Add(rdr.Item(0).ToString)
        End While


        Cob_cust_id.Items.Clear()
        cmd = New OleDbCommand("select CID from Customer_Master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            Cob_cust_id.Items.Add(rdr.Item(0).ToString)
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

    Private Sub Cob_cust_id_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cob_cust_id.SelectedIndexChanged
        cmd = New OleDbCommand("select customer_name from Customer_Master where cid =" & Cob_cust_id.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_cust_name.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub cmbDrID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDrID.SelectedIndexChanged
        cmd = New OleDbCommand("select Dr_name from Doctor_Master where Dr_id =" & cmbDrID.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txtDrName.Text = rdr.Item(0).ToString
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

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        If Cob_cust_id.Text = "" Then
            MessageBox.Show("Fill Customer ID")
            Exit Sub
        End If

        If txt_cust_name.Text = "" Then
            MessageBox.Show("Fill Customer Name")
            Exit Sub
        End If

        If cmbDrID.Text = "" Then
            MessageBox.Show("Select Doctor ID")
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


        cmd = New OleDbCommand("INSERT INTO Sales_order_master VALUES (" & txt_sale_order_no.Text & ",'" & DateTimePicker1.Value & "'," & Cob_cust_id.Text & ",'" & txt_cust_name.Text & "', " & cmbDrID.Text & ",'" & txtDrName.Text & "'," & Txt_amount.Text & "," & txt_tax.Text & ", " & Txt_other_char.Text & "," & Txt_discount.Text & "," & Txt_bill_amt.Text & ")", conn)
        cmd.ExecuteNonQuery()


        cmd = New OleDbCommand("INSERT INTO Sales_order_Details(srno,sales_order_no,Sales_order_date,product_id,product_name,Company,Unit,Mfg_date,Exp_date,Quntity,Rate,Amt) VALUES (@srno,@sales_order_no,@Sales_order_date,@product_id,@product_name,@Company,@Unit,@Mfg_date,@Exp_date,@Quntity,@Rate,@Amt)", conn)

        cmd.Parameters.AddWithValue("@srno", OleDbType.Numeric)         'this code 
        cmd.Parameters.AddWithValue("@sales_order_no", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@Sales_order_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@product_id", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@product_name", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@Company", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@Unit", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@Mfg_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@Exp_date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@Quntity", OleDbType.Numeric)  '9
        cmd.Parameters.AddWithValue("@Rate", OleDbType.Numeric)    '8
        cmd.Parameters.AddWithValue("@Amt", OleDbType.Numeric)   '10

        For j As Integer = 0 To DataGridView1.Rows.Count - 2
            cmd.Parameters(0).Value = DataGridView1.Rows(j).Cells(0).Value
            cmd.Parameters(1).Value = txt_sale_order_no.Text
            cmd.Parameters(2).Value = DateTimePicker1.Value.Date
            cmd.Parameters(3).Value = DataGridView1.Rows(j).Cells(1).Value
            cmd.Parameters(4).Value = DataGridView1.Rows(j).Cells(3).Value   'nm
            cmd.Parameters(5).Value = DataGridView1.Rows(j).Cells(4).Value   ' cmpny
            cmd.Parameters(6).Value = DataGridView1.Rows(j).Cells(5).Value   ' unit
            cmd.Parameters(7).Value = DataGridView1.Rows(j).Cells(6).Value  'mfg
            cmd.Parameters(8).Value = DataGridView1.Rows(j).Cells(7).Value  'exp
            cmd.Parameters(9).Value = DataGridView1.Rows(j).Cells(9).Value
            cmd.Parameters(10).Value = DataGridView1.Rows(j).Cells(8).Value
            cmd.Parameters(11).Value = DataGridView1.Rows(j).Cells(10).Value

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
        txt_sale_order_no.Text = ""
        Cob_cust_id.Text = ""
        cmbDrID.Text = ""
        txt_cust_name.Text = ""
        txtDrName.Text = ""


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
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        rptSaleMasterReport.Show()
    End Sub
End Class