Imports System.Data.OleDb
Imports System.Data

Public Class Dr_Master
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim ds As DataSet
    Dim da As OleDbDataAdapter
    Dim recno As Integer
    Dim ss As String
    Dim com As OleDbCommand

    Private Sub navg()
        txt_dr_id.Text = ds.Tables("Doctor_Master").Rows(recno).Item(0)
        Txt_drname.Text = ds.Tables("Doctor_Master").Rows(recno).Item(1)
        cob_qualification.Text = ds.Tables("Doctor_Master").Rows(recno).Item(2)
        Cob_specialization.Text = ds.Tables("Doctor_Master").Rows(recno).Item(3)
        Txt_address.Text = ds.Tables("Doctor_Master").Rows(recno).Item(4)
        Txt_contac_no.Text = ds.Tables("Doctor_Master").Rows(recno).Item(5)
    End Sub


    Private Sub Btnaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnaddnew.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select MAX(Dr_id) from Doctor_Master", conn)
        rdr = cmd.ExecuteReader()

        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then

            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        txt_dr_id.Text = temp
        Txt_drname.Text = ""
        cob_qualification.Text = ""
        Cob_specialization.Text = ""
        Txt_address.Text = ""
        Txt_contac_no.Text = ""

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

    Private Sub Dr_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDB()
        ds = New DataSet
        da = New OleDbDataAdapter("select * from Doctor_Master", conn)
        da.Fill(ds, "Doctor_Master")
    End Sub


    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        If Txt_drname.Text = "" Then
            MessageBox.Show(" fill the Dr.name")
            Exit Sub
        End If
        If cob_qualification.Text = "" Then
            MessageBox.Show("fill the Dr.Qualification")
            Exit Sub
        End If
        If Cob_specialization.Text = "" Then
            MessageBox.Show("fill the specialization ")
            Exit Sub
        End If
        If Txt_address.Text = "" Then
            MessageBox.Show("fill the Dr  address")
            Exit Sub
        End If
        If Txt_contac_no.Text = "" Then
            MessageBox.Show("fill the Dr contact No")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into  Doctor_Master values (" & txt_dr_id.Text & ",'" & Txt_drname.Text & "','" & cob_qualification.Text & "','" & Cob_specialization.Text & "','" & Txt_address.Text & "','" & Txt_contac_no.Text & "')", conn)

        cmd.ExecuteNonQuery()


        MessageBox.Show("saved successfully")
        Dr_Master_Load(sender, e)
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
            ss = "update  Doctor_Master set Dr_name='" & Txt_drname.Text & "' ,Qualification='" & cob_qualification.Text & "' ,specializatic= '" & Cob_specialization.Text & "',address= '" & Txt_address.Text & "',contact_no= '" & Txt_contac_no.Text & "'where Dr_id = " & txt_dr_id.Text & ""

            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox(" Record updated sucessfully")
            Dr_Master_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btndelete.Click
        Try
            ss = " delete from Doctor_Master where Dr_id=" & txt_dr_id.Text & " "
            cmd = New OleDbCommand(ss, conn)
            cmd.ExecuteNonQuery()
            MsgBox("record Deleted successfully")
            Dr_Master_Load(sender, e)

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
        If (recno >= 0 And recno < ds.Tables("Doctor_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("first record")
        End If
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Doctor_Master").Rows.Count) Then
            navg()
        Else
            MessageBox.Show("last record")
        End If

    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Try
            recno = ds.Tables("Doctor_Master").Rows.Count - 1
            navg()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        txt_dr_id.Text = ""
        Txt_drname.Text = ""
        cob_qualification.Text = ""
        Cob_specialization.Text = ""
        Txt_address.Text = ""
        Txt_contac_no.Text = ""

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

    Private Sub Btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfind.Click

    End Sub
End Class