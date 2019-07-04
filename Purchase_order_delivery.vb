Imports System.Data.OleDb
Imports System.Data
Public Class Purchase_order_delivery
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub Purchase_order_delivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from purchase_order_delivery", conn)
        da.Fill(ds, "purchase_order_delivery")

        cob_pur_or_no.Items.Clear()
        cmd = New OleDbCommand("select distinct(pur_order_no) from Purchase_order_master", conn)
        rdr = cmd.ExecuteReader()
        While rdr.Read()
            cob_pur_or_no.Items.Add(rdr.Item(0).ToString)
        End While

    End Sub

    Private Sub navg()
        txt_pur_de_no.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(0)
        dtp1.Value = ds.Tables("purchase_order_delivery").Rows(recno).Item(1)
        cob_pur_or_no.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(2)
        txt_disti_id.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(3)
        txtdisti_Name.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(4)
        Txt_amount.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(5)
        txt_tax.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(6)
        txtoher_charges.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(7)
        txt_discou.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(8)
        txt_bii_amou.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(9)
        txt_pay_type.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(10)
        txtpay_giv.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(11)
        txtbalance.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(12)
        txtdeli_rema.Text = ds.Tables("purchase_order_delivery").Rows(recno).Item(13)

    End Sub

    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max(pur_order_deli_no)from purchase_order_delivery", conn)
        rdr = cmd.ExecuteReader
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If
        txt_pur_de_no.Text = temp

        cob_pur_or_no.Text = ""
        txt_disti_id.Text = ""
        txtdisti_Name.Text = ""
        Txt_amount.Text = ""
        txt_tax.Text = ""
        txtoher_charges.Text = ""
        txt_discou.Text = ""
        txt_bii_amou.Text = ""
        txt_pay_type.Text = ""
        txtpay_giv.Text = ""
        txtbalance.Text = ""
        txtdeli_rema.Text = ""

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
        If cob_pur_or_no.Text = "" Then
            MessageBox.Show("Select Purchase Order Number")
            Exit Sub
        End If

        If txt_pay_type.Text = "" Then
            MessageBox.Show("Select Payment Type")
            Exit Sub
        End If

        If txtpay_giv.Text = "" Then
            MessageBox.Show("Enter Payment Given")
            Exit Sub
        End If

        If txtdeli_rema.Text = "" Then
            txtdeli_rema.Text = "Nil"
        End If

        cmd = New OleDbCommand("insert into purchase_order_delivery values (" & txt_pur_de_no.Text & ",'" & dtp1.Value.Date & "'," & cob_pur_or_no.Text & "," & txt_disti_id.Text & ",'" & txtdisti_Name.Text & "'," & Txt_amount.Text & "," & txt_tax.Text & "," & txtoher_charges.Text & "," & txt_discou.Text & "," & txt_bii_amou.Text & ",'" & txt_pay_type.Text & "'," & txtpay_giv.Text & "," & txtbalance.Text & ",'" & txtdeli_rema.Text & "')", conn)



        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Purchase_order_delivery_Load(sender, e)

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
        txt_pur_de_no.Text = ""

        txt_pur_de_no.Text = ""
        cob_pur_or_no.Text = ""
        txt_disti_id.Text = ""
        txtdisti_Name.Text = ""
        Txt_amount.Text = ""
        txt_tax.Text = ""
        txtoher_charges.Text = ""
        txt_discou.Text = ""
        txt_bii_amou.Text = ""
        txt_pay_type.Text = ""
        txtpay_giv.Text = ""
        txtbalance.Text = ""
        txtdeli_rema.Text = ""

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
            ss = "update purchase_order_delivery set pur_order_date='" & dtp1.Value & "', pur_order_no=" & cob_pur_or_no.Text & ",  distributer_id=" & txt_disti_id.Text & ", distributer_name='" & txtdisti_Name.Text & "', amount=" & Txt_amount.Text & ", tax=" & txt_tax.Text & ", other_charges=" & txtoher_charges.Text & ", Disconut=" & txt_discou.Text & ", bill_amt=" & txt_bii_amou.Text & ", payment_type='" & txt_pay_type.Text & "', payment_given=" & txtpay_giv.Text & ", balance_amt=" & txtbalance.Text & ", delivery_remark = '" & txtdeli_rema.Text & "' where pur_order_deli_no = " & txt_pur_de_no.Text & " "

            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Record updated sucessfully")
            Purchase_order_delivery_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = "delete from purchase_order_delivery where pur_order_deli_no =" & txt_pur_de_no.Text & ""
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            OpenDB()
            Purchase_order_delivery_Load(sender, e)

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
        If (recno >= 0 And recno < ds.Tables("purchase_order_delivery").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("purchase_order_delivery").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If
    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("purchase_order_delivery").Rows.Count - 1
            navg()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cob_pur_or_no_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cob_pur_or_no.SelectedIndexChanged
        cmd = New OleDbCommand("select distributer_id,distributer_name,amount,tax,other_charges,discount,bill_amt from Purchase_order_master where pur_order_no =" & cob_pur_or_no.Text & "", conn)
        rdr = cmd.ExecuteReader()
        If rdr.Read() Then
            txt_disti_id.Text = rdr.Item(0).ToString
            txtdisti_Name.Text = rdr.Item(1).ToString
            Txt_amount.Text = rdr.Item(2).ToString
            txt_tax.Text = rdr.Item(3).ToString
            txtoher_charges.Text = rdr.Item(4).ToString
            txt_discou.Text = rdr.Item(5).ToString
            txt_bii_amou.Text = rdr.Item(6).ToString

        End If
    End Sub

    Private Sub txtpay_giv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpay_giv.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If e.KeyChar = "" Then
                Exit Sub
            End If
        Else
            e.KeyChar = ""
            MsgBox("Only Numbers")
        End If
    End Sub

    Private Sub txtpay_giv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpay_giv.TextChanged
        txtbalance.Text = Val(txt_bii_amou.Text) - Val(txtpay_giv.Text)
    End Sub

    Private Sub txt_bii_amou_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_bii_amou.TextChanged
        txtbalance.Text = Val(txt_bii_amou.Text) - Val(txtpay_giv.Text)
    End Sub

    Private Sub txtbalance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbalance.TextChanged

    End Sub

    Private Sub Txt_amount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_amount.TextChanged

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub
End Class