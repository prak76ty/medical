﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_order_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase_order_master))
        Me.Btncancel = New System.Windows.Forms.Button
        Me.txt_dist_name = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cob_distibuter = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txt_purc_order_no = New System.Windows.Forms.TextBox
        Me.lbl_dist_name = New System.Windows.Forms.Label
        Me.lbl_dist_id = New System.Windows.Forms.Label
        Me.lbl_purc_or_date = New System.Windows.Forms.Label
        Me.lblpurc_or_no = New System.Windows.Forms.Label
        Me.Btnaddnew = New System.Windows.Forms.Button
        Me.lblpurc_or_master = New System.Windows.Forms.Label
        Me.Btnsave = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Txt_bill_amt = New System.Windows.Forms.TextBox
        Me.lbl_bill_amount = New System.Windows.Forms.Label
        Me.lbl_discount = New System.Windows.Forms.Label
        Me.Txt_other_char = New System.Windows.Forms.TextBox
        Me.lbl_oth_charg = New System.Windows.Forms.Label
        Me.txt_tax = New System.Windows.Forms.TextBox
        Me.lbl_tax = New System.Windows.Forms.Label
        Me.Txt_amount = New System.Windows.Forms.TextBox
        Me.Txt_discount = New System.Windows.Forms.TextBox
        Me.lbl_amt = New System.Windows.Forms.Label
        Me.Txt_amt = New System.Windows.Forms.TextBox
        Me.lbl_amou = New System.Windows.Forms.Label
        Me.Txt_rate = New System.Windows.Forms.TextBox
        Me.lbl_rate = New System.Windows.Forms.Label
        Me.Txt_qunti = New System.Windows.Forms.TextBox
        Me.lbl_quntity = New System.Windows.Forms.Label
        Me.lbl_exp_da = New System.Windows.Forms.Label
        Me.lbl_mfg_date = New System.Windows.Forms.Label
        Me.Cmb_PID = New System.Windows.Forms.ComboBox
        Me.lbl_unit = New System.Windows.Forms.Label
        Me.Txt_prod_name = New System.Windows.Forms.TextBox
        Me.Txt_comp = New System.Windows.Forms.TextBox
        Me.lbl_comp = New System.Windows.Forms.Label
        Me.lbl_prod_nam = New System.Windows.Forms.Label
        Me.lbl_prod_id = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ptype = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Company = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MFGDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EXPDT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Amt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtUnit = New System.Windows.Forms.TextBox
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.txtPtype = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btncancel
        '
        Me.Btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Purple
        Me.Btncancel.Location = New System.Drawing.Point(356, 28)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(78, 39)
        Me.Btncancel.TabIndex = 39
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = False
        '
        'txt_dist_name
        '
        Me.txt_dist_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dist_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dist_name.Location = New System.Drawing.Point(431, 53)
        Me.txt_dist_name.Multiline = True
        Me.txt_dist_name.Name = "txt_dist_name"
        Me.txt_dist_name.ReadOnly = True
        Me.txt_dist_name.Size = New System.Drawing.Size(355, 26)
        Me.txt_dist_name.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Cob_distibuter)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txt_dist_name)
        Me.Panel1.Controls.Add(Me.txt_purc_order_no)
        Me.Panel1.Controls.Add(Me.lbl_dist_name)
        Me.Panel1.Controls.Add(Me.lbl_dist_id)
        Me.Panel1.Controls.Add(Me.lbl_purc_or_date)
        Me.Panel1.Controls.Add(Me.lblpurc_or_no)
        Me.Panel1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(15, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(811, 99)
        Me.Panel1.TabIndex = 54
        '
        'Cob_distibuter
        '
        Me.Cob_distibuter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cob_distibuter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cob_distibuter.FormattingEnabled = True
        Me.Cob_distibuter.Location = New System.Drawing.Point(125, 54)
        Me.Cob_distibuter.Name = "Cob_distibuter"
        Me.Cob_distibuter.Size = New System.Drawing.Size(121, 24)
        Me.Cob_distibuter.TabIndex = 59
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(654, 11)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 22)
        Me.DateTimePicker1.TabIndex = 58
        '
        'txt_purc_order_no
        '
        Me.txt_purc_order_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_purc_order_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_purc_order_no.Location = New System.Drawing.Point(125, 11)
        Me.txt_purc_order_no.Name = "txt_purc_order_no"
        Me.txt_purc_order_no.Size = New System.Drawing.Size(111, 22)
        Me.txt_purc_order_no.TabIndex = 34
        '
        'lbl_dist_name
        '
        Me.lbl_dist_name.AutoSize = True
        Me.lbl_dist_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dist_name.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_dist_name.Location = New System.Drawing.Point(287, 58)
        Me.lbl_dist_name.Name = "lbl_dist_name"
        Me.lbl_dist_name.Size = New System.Drawing.Size(119, 16)
        Me.lbl_dist_name.TabIndex = 30
        Me.lbl_dist_name.Text = "Distibuter Name"
        '
        'lbl_dist_id
        '
        Me.lbl_dist_id.AutoSize = True
        Me.lbl_dist_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dist_id.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_dist_id.Location = New System.Drawing.Point(12, 58)
        Me.lbl_dist_id.Name = "lbl_dist_id"
        Me.lbl_dist_id.Size = New System.Drawing.Size(89, 16)
        Me.lbl_dist_id.TabIndex = 29
        Me.lbl_dist_id.Text = "DistibuterID"
        '
        'lbl_purc_or_date
        '
        Me.lbl_purc_or_date.AutoSize = True
        Me.lbl_purc_or_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_purc_or_date.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_purc_or_date.Location = New System.Drawing.Point(607, 14)
        Me.lbl_purc_or_date.Name = "lbl_purc_or_date"
        Me.lbl_purc_or_date.Size = New System.Drawing.Size(41, 16)
        Me.lbl_purc_or_date.TabIndex = 28
        Me.lbl_purc_or_date.Text = "Date"
        '
        'lblpurc_or_no
        '
        Me.lblpurc_or_no.AutoSize = True
        Me.lblpurc_or_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurc_or_no.ForeColor = System.Drawing.Color.Indigo
        Me.lblpurc_or_no.Location = New System.Drawing.Point(13, 14)
        Me.lblpurc_or_no.Name = "lblpurc_or_no"
        Me.lblpurc_or_no.Size = New System.Drawing.Size(65, 16)
        Me.lblpurc_or_no.TabIndex = 27
        Me.lblpurc_or_no.Text = "P.O. No."
        '
        'Btnaddnew
        '
        Me.Btnaddnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddnew.ForeColor = System.Drawing.Color.Purple
        Me.Btnaddnew.Location = New System.Drawing.Point(125, 28)
        Me.Btnaddnew.Name = "Btnaddnew"
        Me.Btnaddnew.Size = New System.Drawing.Size(78, 39)
        Me.Btnaddnew.TabIndex = 49
        Me.Btnaddnew.Text = "AddNew"
        Me.Btnaddnew.UseVisualStyleBackColor = False
        '
        'lblpurc_or_master
        '
        Me.lblpurc_or_master.AutoSize = True
        Me.lblpurc_or_master.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblpurc_or_master.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurc_or_master.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblpurc_or_master.Location = New System.Drawing.Point(318, 9)
        Me.lblpurc_or_master.Name = "lblpurc_or_master"
        Me.lblpurc_or_master.Size = New System.Drawing.Size(194, 29)
        Me.lblpurc_or_master.TabIndex = 53
        Me.lblpurc_or_master.Text = "Purchase order"
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Purple
        Me.Btnsave.Location = New System.Drawing.Point(239, 28)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(78, 39)
        Me.Btnsave.TabIndex = 48
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.Purple
        Me.Btnexit.Location = New System.Drawing.Point(590, 28)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(78, 39)
        Me.Btnexit.TabIndex = 47
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Purple
        Me.BtnPrint.Location = New System.Drawing.Point(473, 28)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(78, 39)
        Me.BtnPrint.TabIndex = 46
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnOK
        '
        Me.BtnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.ForeColor = System.Drawing.Color.Purple
        Me.BtnOK.Location = New System.Drawing.Point(771, 150)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(53, 58)
        Me.BtnOK.TabIndex = 43
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnaddnew)
        Me.Panel2.Controls.Add(Me.Btnsave)
        Me.Panel2.Controls.Add(Me.Btnexit)
        Me.Panel2.Controls.Add(Me.BtnPrint)
        Me.Panel2.Controls.Add(Me.Btncancel)
        Me.Panel2.Location = New System.Drawing.Point(15, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 98)
        Me.Panel2.TabIndex = 55
        '
        'Txt_bill_amt
        '
        Me.Txt_bill_amt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_bill_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bill_amt.ForeColor = System.Drawing.Color.Indigo
        Me.Txt_bill_amt.Location = New System.Drawing.Point(716, 414)
        Me.Txt_bill_amt.Name = "Txt_bill_amt"
        Me.Txt_bill_amt.ReadOnly = True
        Me.Txt_bill_amt.Size = New System.Drawing.Size(96, 22)
        Me.Txt_bill_amt.TabIndex = 67
        '
        'lbl_bill_amount
        '
        Me.lbl_bill_amount.AutoSize = True
        Me.lbl_bill_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bill_amount.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_bill_amount.Location = New System.Drawing.Point(625, 417)
        Me.lbl_bill_amount.Name = "lbl_bill_amount"
        Me.lbl_bill_amount.Size = New System.Drawing.Size(85, 16)
        Me.lbl_bill_amount.TabIndex = 66
        Me.lbl_bill_amount.Text = "Bill Amount"
        '
        'lbl_discount
        '
        Me.lbl_discount.AutoSize = True
        Me.lbl_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_discount.Location = New System.Drawing.Point(472, 417)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(68, 16)
        Me.lbl_discount.TabIndex = 65
        Me.lbl_discount.Text = "Discount"
        '
        'Txt_other_char
        '
        Me.Txt_other_char.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_other_char.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_other_char.ForeColor = System.Drawing.Color.Indigo
        Me.Txt_other_char.Location = New System.Drawing.Point(390, 414)
        Me.Txt_other_char.MaxLength = 8
        Me.Txt_other_char.Name = "Txt_other_char"
        Me.Txt_other_char.Size = New System.Drawing.Size(76, 22)
        Me.Txt_other_char.TabIndex = 64
        '
        'lbl_oth_charg
        '
        Me.lbl_oth_charg.AutoSize = True
        Me.lbl_oth_charg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_oth_charg.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_oth_charg.Location = New System.Drawing.Point(279, 417)
        Me.lbl_oth_charg.Name = "lbl_oth_charg"
        Me.lbl_oth_charg.Size = New System.Drawing.Size(105, 16)
        Me.lbl_oth_charg.TabIndex = 63
        Me.lbl_oth_charg.Text = "Other charges"
        '
        'txt_tax
        '
        Me.txt_tax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.Location = New System.Drawing.Point(202, 414)
        Me.txt_tax.MaxLength = 8
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.Size = New System.Drawing.Size(71, 22)
        Me.txt_tax.TabIndex = 62
        '
        'lbl_tax
        '
        Me.lbl_tax.AutoSize = True
        Me.lbl_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tax.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_tax.Location = New System.Drawing.Point(160, 417)
        Me.lbl_tax.Name = "lbl_tax"
        Me.lbl_tax.Size = New System.Drawing.Size(34, 16)
        Me.lbl_tax.TabIndex = 61
        Me.lbl_tax.Text = "Tax"
        '
        'Txt_amount
        '
        Me.Txt_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_amount.Location = New System.Drawing.Point(77, 414)
        Me.Txt_amount.Name = "Txt_amount"
        Me.Txt_amount.ReadOnly = True
        Me.Txt_amount.Size = New System.Drawing.Size(77, 22)
        Me.Txt_amount.TabIndex = 60
        '
        'Txt_discount
        '
        Me.Txt_discount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_discount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_discount.ForeColor = System.Drawing.Color.Indigo
        Me.Txt_discount.Location = New System.Drawing.Point(546, 413)
        Me.Txt_discount.MaxLength = 8
        Me.Txt_discount.Multiline = True
        Me.Txt_discount.Name = "Txt_discount"
        Me.Txt_discount.Size = New System.Drawing.Size(73, 24)
        Me.Txt_discount.TabIndex = 59
        '
        'lbl_amt
        '
        Me.lbl_amt.AutoSize = True
        Me.lbl_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amt.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_amt.Location = New System.Drawing.Point(12, 417)
        Me.lbl_amt.Name = "lbl_amt"
        Me.lbl_amt.Size = New System.Drawing.Size(59, 16)
        Me.lbl_amt.TabIndex = 58
        Me.lbl_amt.Text = "Amount"
        '
        'Txt_amt
        '
        Me.Txt_amt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_amt.Location = New System.Drawing.Point(688, 191)
        Me.Txt_amt.Name = "Txt_amt"
        Me.Txt_amt.ReadOnly = True
        Me.Txt_amt.Size = New System.Drawing.Size(77, 22)
        Me.Txt_amt.TabIndex = 85
        '
        'lbl_amou
        '
        Me.lbl_amou.AutoSize = True
        Me.lbl_amou.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amou.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_amou.Location = New System.Drawing.Point(622, 194)
        Me.lbl_amou.Name = "lbl_amou"
        Me.lbl_amou.Size = New System.Drawing.Size(59, 16)
        Me.lbl_amou.TabIndex = 84
        Me.lbl_amou.Text = "Amount"
        '
        'Txt_rate
        '
        Me.Txt_rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rate.Location = New System.Drawing.Point(459, 191)
        Me.Txt_rate.MaxLength = 5
        Me.Txt_rate.Name = "Txt_rate"
        Me.Txt_rate.Size = New System.Drawing.Size(62, 22)
        Me.Txt_rate.TabIndex = 83
        '
        'lbl_rate
        '
        Me.lbl_rate.AutoSize = True
        Me.lbl_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rate.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_rate.Location = New System.Drawing.Point(411, 194)
        Me.lbl_rate.Name = "lbl_rate"
        Me.lbl_rate.Size = New System.Drawing.Size(41, 16)
        Me.lbl_rate.TabIndex = 82
        Me.lbl_rate.Text = "Rate"
        '
        'Txt_qunti
        '
        Me.Txt_qunti.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_qunti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_qunti.Location = New System.Drawing.Point(564, 191)
        Me.Txt_qunti.MaxLength = 5
        Me.Txt_qunti.Name = "Txt_qunti"
        Me.Txt_qunti.Size = New System.Drawing.Size(52, 22)
        Me.Txt_qunti.TabIndex = 81
        '
        'lbl_quntity
        '
        Me.lbl_quntity.AutoSize = True
        Me.lbl_quntity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quntity.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_quntity.Location = New System.Drawing.Point(527, 194)
        Me.lbl_quntity.Name = "lbl_quntity"
        Me.lbl_quntity.Size = New System.Drawing.Size(31, 16)
        Me.lbl_quntity.TabIndex = 80
        Me.lbl_quntity.Text = "Qty"
        '
        'lbl_exp_da
        '
        Me.lbl_exp_da.AutoSize = True
        Me.lbl_exp_da.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exp_da.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_exp_da.Location = New System.Drawing.Point(213, 194)
        Me.lbl_exp_da.Name = "lbl_exp_da"
        Me.lbl_exp_da.Size = New System.Drawing.Size(69, 16)
        Me.lbl_exp_da.TabIndex = 79
        Me.lbl_exp_da.Text = "Exp date"
        '
        'lbl_mfg_date
        '
        Me.lbl_mfg_date.AutoSize = True
        Me.lbl_mfg_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mfg_date.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_mfg_date.Location = New System.Drawing.Point(15, 194)
        Me.lbl_mfg_date.Name = "lbl_mfg_date"
        Me.lbl_mfg_date.Size = New System.Drawing.Size(70, 16)
        Me.lbl_mfg_date.TabIndex = 77
        Me.lbl_mfg_date.Text = "Mfg Date"
        '
        'Cmb_PID
        '
        Me.Cmb_PID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmb_PID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_PID.FormattingEnabled = True
        Me.Cmb_PID.Location = New System.Drawing.Point(54, 157)
        Me.Cmb_PID.Name = "Cmb_PID"
        Me.Cmb_PID.Size = New System.Drawing.Size(68, 24)
        Me.Cmb_PID.TabIndex = 76
        '
        'lbl_unit
        '
        Me.lbl_unit.AutoSize = True
        Me.lbl_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_unit.Location = New System.Drawing.Point(605, 161)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(35, 16)
        Me.lbl_unit.TabIndex = 74
        Me.lbl_unit.Text = "Unit"
        '
        'Txt_prod_name
        '
        Me.Txt_prod_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_prod_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_prod_name.Location = New System.Drawing.Point(340, 158)
        Me.Txt_prod_name.Name = "Txt_prod_name"
        Me.Txt_prod_name.ReadOnly = True
        Me.Txt_prod_name.Size = New System.Drawing.Size(87, 22)
        Me.Txt_prod_name.TabIndex = 73
        '
        'Txt_comp
        '
        Me.Txt_comp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_comp.Location = New System.Drawing.Point(507, 159)
        Me.Txt_comp.Multiline = True
        Me.Txt_comp.Name = "Txt_comp"
        Me.Txt_comp.ReadOnly = True
        Me.Txt_comp.Size = New System.Drawing.Size(87, 20)
        Me.Txt_comp.TabIndex = 72
        '
        'lbl_comp
        '
        Me.lbl_comp.AutoSize = True
        Me.lbl_comp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_comp.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_comp.Location = New System.Drawing.Point(430, 161)
        Me.lbl_comp.Name = "lbl_comp"
        Me.lbl_comp.Size = New System.Drawing.Size(73, 16)
        Me.lbl_comp.TabIndex = 70
        Me.lbl_comp.Text = "Company"
        '
        'lbl_prod_nam
        '
        Me.lbl_prod_nam.AutoSize = True
        Me.lbl_prod_nam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod_nam.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_prod_nam.Location = New System.Drawing.Point(271, 161)
        Me.lbl_prod_nam.Name = "lbl_prod_nam"
        Me.lbl_prod_nam.Size = New System.Drawing.Size(63, 16)
        Me.lbl_prod_nam.TabIndex = 69
        Me.lbl_prod_nam.Text = "P Name"
        '
        'lbl_prod_id
        '
        Me.lbl_prod_id.AutoSize = True
        Me.lbl_prod_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prod_id.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_prod_id.Location = New System.Drawing.Point(17, 161)
        Me.lbl_prod_id.Name = "lbl_prod_id"
        Me.lbl_prod_id.Size = New System.Drawing.Size(33, 16)
        Me.lbl_prod_id.TabIndex = 68
        Me.lbl_prod_id.Text = "PID"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.PID, Me.ptype, Me.PName, Me.Company, Me.Unit, Me.MFGDT, Me.EXPDT, Me.Rate, Me.QTY, Me.Amt})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 218)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(829, 177)
        Me.DataGridView1.TabIndex = 86
        '
        'srno
        '
        Me.srno.HeaderText = "No"
        Me.srno.Name = "srno"
        Me.srno.Width = 40
        '
        'PID
        '
        Me.PID.HeaderText = "PID"
        Me.PID.Name = "PID"
        Me.PID.Width = 50
        '
        'ptype
        '
        Me.ptype.HeaderText = "Type"
        Me.ptype.Name = "ptype"
        Me.ptype.Width = 80
        '
        'PName
        '
        Me.PName.HeaderText = "Name"
        Me.PName.Name = "PName"
        Me.PName.Width = 80
        '
        'Company
        '
        Me.Company.HeaderText = "Company"
        Me.Company.Name = "Company"
        Me.Company.Width = 80
        '
        'Unit
        '
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.Width = 60
        '
        'MFGDT
        '
        Me.MFGDT.HeaderText = "MFGDT"
        Me.MFGDT.Name = "MFGDT"
        Me.MFGDT.Width = 90
        '
        'EXPDT
        '
        Me.EXPDT.HeaderText = "EXPDT"
        Me.EXPDT.Name = "EXPDT"
        Me.EXPDT.Width = 90
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.Width = 70
        '
        'QTY
        '
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.Width = 50
        '
        'Amt
        '
        Me.Amt.HeaderText = "Amt"
        Me.Amt.Name = "Amt"
        Me.Amt.Width = 75
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(657, 158)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(77, 22)
        Me.txtUnit.TabIndex = 87
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(296, 192)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker3.TabIndex = 123
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(99, 192)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker2.TabIndex = 122
        '
        'txtPtype
        '
        Me.txtPtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtype.Location = New System.Drawing.Point(191, 158)
        Me.txtPtype.Name = "txtPtype"
        Me.txtPtype.ReadOnly = True
        Me.txtPtype.Size = New System.Drawing.Size(80, 22)
        Me.txtPtype.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(130, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "P Type"
        '
        'Purchase_order_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(849, 557)
        Me.Controls.Add(Me.txtPtype)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Txt_rate)
        Me.Controls.Add(Me.Txt_amt)
        Me.Controls.Add(Me.lbl_amou)
        Me.Controls.Add(Me.lbl_rate)
        Me.Controls.Add(Me.lbl_exp_da)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.lbl_mfg_date)
        Me.Controls.Add(Me.Txt_qunti)
        Me.Controls.Add(Me.lbl_unit)
        Me.Controls.Add(Me.Cmb_PID)
        Me.Controls.Add(Me.lbl_quntity)
        Me.Controls.Add(Me.Txt_prod_name)
        Me.Controls.Add(Me.Txt_comp)
        Me.Controls.Add(Me.lbl_comp)
        Me.Controls.Add(Me.lbl_prod_nam)
        Me.Controls.Add(Me.lbl_prod_id)
        Me.Controls.Add(Me.Txt_bill_amt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblpurc_or_master)
        Me.Controls.Add(Me.lbl_bill_amount)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_amt)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.Txt_discount)
        Me.Controls.Add(Me.Txt_amount)
        Me.Controls.Add(Me.Txt_other_char)
        Me.Controls.Add(Me.lbl_tax)
        Me.Controls.Add(Me.txt_tax)
        Me.Controls.Add(Me.lbl_oth_charg)
        Me.Name = "Purchase_order_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase_master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btncancel As System.Windows.Forms.Button
    Friend WithEvents txt_dist_name As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_purc_order_no As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dist_name As System.Windows.Forms.Label
    Friend WithEvents lbl_dist_id As System.Windows.Forms.Label
    Friend WithEvents lbl_purc_or_date As System.Windows.Forms.Label
    Friend WithEvents lblpurc_or_no As System.Windows.Forms.Label
    Friend WithEvents Btnaddnew As System.Windows.Forms.Button
    Friend WithEvents lblpurc_or_master As System.Windows.Forms.Label
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Txt_bill_amt As System.Windows.Forms.TextBox
    Friend WithEvents Cob_distibuter As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_bill_amount As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_discount As System.Windows.Forms.Label
    Friend WithEvents Txt_other_char As System.Windows.Forms.TextBox
    Friend WithEvents lbl_oth_charg As System.Windows.Forms.Label
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tax As System.Windows.Forms.Label
    Friend WithEvents Txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents Txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_amt As System.Windows.Forms.Label
    Friend WithEvents Txt_amt As System.Windows.Forms.TextBox
    Friend WithEvents lbl_amou As System.Windows.Forms.Label
    Friend WithEvents Txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_rate As System.Windows.Forms.Label
    Friend WithEvents Txt_qunti As System.Windows.Forms.TextBox
    Friend WithEvents lbl_quntity As System.Windows.Forms.Label
    Friend WithEvents lbl_exp_da As System.Windows.Forms.Label
    Friend WithEvents lbl_mfg_date As System.Windows.Forms.Label
    Friend WithEvents Cmb_PID As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_unit As System.Windows.Forms.Label
    Friend WithEvents Txt_prod_name As System.Windows.Forms.TextBox
    Friend WithEvents Txt_comp As System.Windows.Forms.TextBox
    Friend WithEvents lbl_comp As System.Windows.Forms.Label
    Friend WithEvents lbl_prod_nam As System.Windows.Forms.Label
    Friend WithEvents lbl_prod_id As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPtype As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ptype As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MFGDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Amt As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
