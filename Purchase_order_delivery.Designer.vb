<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase_order_delivery
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase_order_delivery))
        Me.lbl_pur_or_deliv = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Btnaddnew = New System.Windows.Forms.Button
        Me.Btnsave = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Btnfind = New System.Windows.Forms.Button
        Me.Btnlast = New System.Windows.Forms.Button
        Me.Btnnext = New System.Windows.Forms.Button
        Me.Btnprevious = New System.Windows.Forms.Button
        Me.Btnfirst = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Btncancel = New System.Windows.Forms.Button
        Me.txt_pay_type = New System.Windows.Forms.ComboBox
        Me.Txt_amount = New System.Windows.Forms.TextBox
        Me.cob_pur_or_no = New System.Windows.Forms.ComboBox
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.txtdeli_rema = New System.Windows.Forms.TextBox
        Me.txtpay_giv = New System.Windows.Forms.TextBox
        Me.txtbalance = New System.Windows.Forms.TextBox
        Me.Lbl_delivery_remark = New System.Windows.Forms.Label
        Me.Lbl_balance = New System.Windows.Forms.Label
        Me.lbl_pay_given = New System.Windows.Forms.Label
        Me.txt_discou = New System.Windows.Forms.TextBox
        Me.txtdiscount = New System.Windows.Forms.Label
        Me.txtoher_charges = New System.Windows.Forms.TextBox
        Me.txtoth_char = New System.Windows.Forms.Label
        Me.lbl_bill_amt = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_bii_amou = New System.Windows.Forms.TextBox
        Me.Lblamount = New System.Windows.Forms.Label
        Me.txtdisti_Name = New System.Windows.Forms.TextBox
        Me.txt_tax = New System.Windows.Forms.TextBox
        Me.txt_disti_id = New System.Windows.Forms.TextBox
        Me.txt_pur_de_no = New System.Windows.Forms.TextBox
        Me.Lbldisti_name = New System.Windows.Forms.Label
        Me.Lbldisti_id = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.pur_or_no = New System.Windows.Forms.Label
        Me.lbl_pur_or_De_no = New System.Windows.Forms.Label
        Me.txtpurc_date = New System.Windows.Forms.Label
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_pur_or_deliv
        '
        Me.lbl_pur_or_deliv.AutoSize = True
        Me.lbl_pur_or_deliv.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_pur_or_deliv.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pur_or_deliv.ForeColor = System.Drawing.Color.SpringGreen
        Me.lbl_pur_or_deliv.Location = New System.Drawing.Point(133, 9)
        Me.lbl_pur_or_deliv.Name = "lbl_pur_or_deliv"
        Me.lbl_pur_or_deliv.Size = New System.Drawing.Size(306, 29)
        Me.lbl_pur_or_deliv.TabIndex = 111
        Me.lbl_pur_or_deliv.Text = "Purchase order Delivery"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Controls.Add(Me.txt_pay_type)
        Me.Panel4.Controls.Add(Me.Txt_amount)
        Me.Panel4.Controls.Add(Me.cob_pur_or_no)
        Me.Panel4.Controls.Add(Me.dtp1)
        Me.Panel4.Controls.Add(Me.txtdeli_rema)
        Me.Panel4.Controls.Add(Me.txtpay_giv)
        Me.Panel4.Controls.Add(Me.txtbalance)
        Me.Panel4.Controls.Add(Me.Lbl_delivery_remark)
        Me.Panel4.Controls.Add(Me.Lbl_balance)
        Me.Panel4.Controls.Add(Me.lbl_pay_given)
        Me.Panel4.Controls.Add(Me.txt_discou)
        Me.Panel4.Controls.Add(Me.txtdiscount)
        Me.Panel4.Controls.Add(Me.txtoher_charges)
        Me.Panel4.Controls.Add(Me.txtoth_char)
        Me.Panel4.Controls.Add(Me.lbl_bill_amt)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txt_bii_amou)
        Me.Panel4.Controls.Add(Me.Lblamount)
        Me.Panel4.Controls.Add(Me.txtdisti_Name)
        Me.Panel4.Controls.Add(Me.txt_tax)
        Me.Panel4.Controls.Add(Me.txt_disti_id)
        Me.Panel4.Controls.Add(Me.txt_pur_de_no)
        Me.Panel4.Controls.Add(Me.Lbldisti_name)
        Me.Panel4.Controls.Add(Me.Lbldisti_id)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.pur_or_no)
        Me.Panel4.Controls.Add(Me.lbl_pur_or_De_no)
        Me.Panel4.Controls.Add(Me.txtpurc_date)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(12, 41)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(540, 503)
        Me.Panel4.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Btnaddnew)
        Me.Panel2.Controls.Add(Me.Btnsave)
        Me.Panel2.Controls.Add(Me.Btnexit)
        Me.Panel2.Controls.Add(Me.Btnfind)
        Me.Panel2.Controls.Add(Me.Btnlast)
        Me.Panel2.Controls.Add(Me.Btnnext)
        Me.Panel2.Controls.Add(Me.Btnprevious)
        Me.Panel2.Controls.Add(Me.Btnfirst)
        Me.Panel2.Controls.Add(Me.Btndelete)
        Me.Panel2.Controls.Add(Me.Btnupdate)
        Me.Panel2.Controls.Add(Me.Btncancel)
        Me.Panel2.Location = New System.Drawing.Point(30, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 126)
        Me.Panel2.TabIndex = 96
        '
        'Btnaddnew
        '
        Me.Btnaddnew.BackColor = System.Drawing.Color.Pink
        Me.Btnaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddnew.ForeColor = System.Drawing.Color.Purple
        Me.Btnaddnew.Location = New System.Drawing.Point(19, 11)
        Me.Btnaddnew.Name = "Btnaddnew"
        Me.Btnaddnew.Size = New System.Drawing.Size(66, 49)
        Me.Btnaddnew.TabIndex = 25
        Me.Btnaddnew.Text = "AddNew"
        Me.Btnaddnew.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.Pink
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Purple
        Me.Btnsave.Location = New System.Drawing.Point(91, 11)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(66, 49)
        Me.Btnsave.TabIndex = 24
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Pink
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.Purple
        Me.Btnexit.Location = New System.Drawing.Point(380, 11)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(46, 104)
        Me.Btnexit.TabIndex = 23
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Btnfind
        '
        Me.Btnfind.BackColor = System.Drawing.Color.Pink
        Me.Btnfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfind.ForeColor = System.Drawing.Color.Purple
        Me.Btnfind.Location = New System.Drawing.Point(308, 66)
        Me.Btnfind.Name = "Btnfind"
        Me.Btnfind.Size = New System.Drawing.Size(66, 49)
        Me.Btnfind.TabIndex = 22
        Me.Btnfind.Text = "Find"
        Me.Btnfind.UseVisualStyleBackColor = False
        '
        'Btnlast
        '
        Me.Btnlast.BackColor = System.Drawing.Color.Pink
        Me.Btnlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlast.ForeColor = System.Drawing.Color.Purple
        Me.Btnlast.Location = New System.Drawing.Point(236, 66)
        Me.Btnlast.Name = "Btnlast"
        Me.Btnlast.Size = New System.Drawing.Size(66, 49)
        Me.Btnlast.TabIndex = 21
        Me.Btnlast.Text = "Last"
        Me.Btnlast.UseVisualStyleBackColor = False
        '
        'Btnnext
        '
        Me.Btnnext.BackColor = System.Drawing.Color.Pink
        Me.Btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnext.ForeColor = System.Drawing.Color.Purple
        Me.Btnnext.Location = New System.Drawing.Point(164, 66)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(66, 49)
        Me.Btnnext.TabIndex = 20
        Me.Btnnext.Text = "Next"
        Me.Btnnext.UseVisualStyleBackColor = False
        '
        'Btnprevious
        '
        Me.Btnprevious.BackColor = System.Drawing.Color.Pink
        Me.Btnprevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprevious.ForeColor = System.Drawing.Color.Purple
        Me.Btnprevious.Location = New System.Drawing.Point(92, 66)
        Me.Btnprevious.Name = "Btnprevious"
        Me.Btnprevious.Size = New System.Drawing.Size(66, 49)
        Me.Btnprevious.TabIndex = 19
        Me.Btnprevious.Text = "Previous"
        Me.Btnprevious.UseVisualStyleBackColor = False
        '
        'Btnfirst
        '
        Me.Btnfirst.BackColor = System.Drawing.Color.Pink
        Me.Btnfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfirst.ForeColor = System.Drawing.Color.Purple
        Me.Btnfirst.Location = New System.Drawing.Point(20, 66)
        Me.Btnfirst.Name = "Btnfirst"
        Me.Btnfirst.Size = New System.Drawing.Size(66, 49)
        Me.Btnfirst.TabIndex = 18
        Me.Btnfirst.Text = "First"
        Me.Btnfirst.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.Pink
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Purple
        Me.Btndelete.Location = New System.Drawing.Point(308, 11)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(66, 49)
        Me.Btndelete.TabIndex = 17
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.Pink
        Me.Btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.ForeColor = System.Drawing.Color.Purple
        Me.Btnupdate.Location = New System.Drawing.Point(236, 11)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(66, 49)
        Me.Btnupdate.TabIndex = 16
        Me.Btnupdate.Text = "update"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Btncancel
        '
        Me.Btncancel.BackColor = System.Drawing.Color.Pink
        Me.Btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Purple
        Me.Btncancel.Location = New System.Drawing.Point(164, 11)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(66, 49)
        Me.Btncancel.TabIndex = 15
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = False
        '
        'txt_pay_type
        '
        Me.txt_pay_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_pay_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pay_type.FormattingEnabled = True
        Me.txt_pay_type.Items.AddRange(New Object() {"CASH", "BANK"})
        Me.txt_pay_type.Location = New System.Drawing.Point(135, 271)
        Me.txt_pay_type.Name = "txt_pay_type"
        Me.txt_pay_type.Size = New System.Drawing.Size(103, 28)
        Me.txt_pay_type.TabIndex = 95
        '
        'Txt_amount
        '
        Me.Txt_amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_amount.Location = New System.Drawing.Point(142, 154)
        Me.Txt_amount.Multiline = True
        Me.Txt_amount.Name = "Txt_amount"
        Me.Txt_amount.ReadOnly = True
        Me.Txt_amount.Size = New System.Drawing.Size(103, 20)
        Me.Txt_amount.TabIndex = 94
        '
        'cob_pur_or_no
        '
        Me.cob_pur_or_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cob_pur_or_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cob_pur_or_no.FormattingEnabled = True
        Me.cob_pur_or_no.Location = New System.Drawing.Point(270, 72)
        Me.cob_pur_or_no.Name = "cob_pur_or_no"
        Me.cob_pur_or_no.Size = New System.Drawing.Size(103, 28)
        Me.cob_pur_or_no.TabIndex = 93
        '
        'dtp1
        '
        Me.dtp1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(406, 22)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(117, 26)
        Me.dtp1.TabIndex = 92
        '
        'txtdeli_rema
        '
        Me.txtdeli_rema.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdeli_rema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdeli_rema.Location = New System.Drawing.Point(417, 311)
        Me.txtdeli_rema.Name = "txtdeli_rema"
        Me.txtdeli_rema.Size = New System.Drawing.Size(100, 26)
        Me.txtdeli_rema.TabIndex = 91
        '
        'txtpay_giv
        '
        Me.txtpay_giv.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtpay_giv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpay_giv.Location = New System.Drawing.Point(417, 269)
        Me.txtpay_giv.Name = "txtpay_giv"
        Me.txtpay_giv.Size = New System.Drawing.Size(100, 26)
        Me.txtpay_giv.TabIndex = 90
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(135, 311)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.ReadOnly = True
        Me.txtbalance.Size = New System.Drawing.Size(100, 26)
        Me.txtbalance.TabIndex = 89
        '
        'Lbl_delivery_remark
        '
        Me.Lbl_delivery_remark.AutoSize = True
        Me.Lbl_delivery_remark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_delivery_remark.ForeColor = System.Drawing.Color.Indigo
        Me.Lbl_delivery_remark.Location = New System.Drawing.Point(279, 312)
        Me.Lbl_delivery_remark.Name = "Lbl_delivery_remark"
        Me.Lbl_delivery_remark.Size = New System.Drawing.Size(132, 18)
        Me.Lbl_delivery_remark.TabIndex = 88
        Me.Lbl_delivery_remark.Text = "Delivery Remark"
        '
        'Lbl_balance
        '
        Me.Lbl_balance.AutoSize = True
        Me.Lbl_balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_balance.ForeColor = System.Drawing.Color.Indigo
        Me.Lbl_balance.Location = New System.Drawing.Point(58, 312)
        Me.Lbl_balance.Name = "Lbl_balance"
        Me.Lbl_balance.Size = New System.Drawing.Size(68, 18)
        Me.Lbl_balance.TabIndex = 87
        Me.Lbl_balance.Text = "Balance"
        '
        'lbl_pay_given
        '
        Me.lbl_pay_given.AutoSize = True
        Me.lbl_pay_given.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pay_given.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_pay_given.Location = New System.Drawing.Point(290, 272)
        Me.lbl_pay_given.Name = "lbl_pay_given"
        Me.lbl_pay_given.Size = New System.Drawing.Size(121, 18)
        Me.lbl_pay_given.TabIndex = 86
        Me.lbl_pay_given.Text = "Payment Given"
        '
        'txt_discou
        '
        Me.txt_discou.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_discou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discou.Location = New System.Drawing.Point(424, 187)
        Me.txt_discou.Name = "txt_discou"
        Me.txt_discou.ReadOnly = True
        Me.txt_discou.Size = New System.Drawing.Size(100, 26)
        Me.txt_discou.TabIndex = 60
        '
        'txtdiscount
        '
        Me.txtdiscount.AutoSize = True
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.ForeColor = System.Drawing.Color.Indigo
        Me.txtdiscount.Location = New System.Drawing.Point(343, 190)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(75, 18)
        Me.txtdiscount.TabIndex = 59
        Me.txtdiscount.Text = "Discount"
        '
        'txtoher_charges
        '
        Me.txtoher_charges.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtoher_charges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoher_charges.Location = New System.Drawing.Point(142, 187)
        Me.txtoher_charges.Name = "txtoher_charges"
        Me.txtoher_charges.ReadOnly = True
        Me.txtoher_charges.Size = New System.Drawing.Size(100, 26)
        Me.txtoher_charges.TabIndex = 58
        '
        'txtoth_char
        '
        Me.txtoth_char.AutoSize = True
        Me.txtoth_char.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoth_char.ForeColor = System.Drawing.Color.Indigo
        Me.txtoth_char.Location = New System.Drawing.Point(18, 190)
        Me.txtoth_char.Name = "txtoth_char"
        Me.txtoth_char.Size = New System.Drawing.Size(115, 18)
        Me.txtoth_char.TabIndex = 57
        Me.txtoth_char.Text = "Other charges"
        '
        'lbl_bill_amt
        '
        Me.lbl_bill_amt.AutoSize = True
        Me.lbl_bill_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bill_amt.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_bill_amt.Location = New System.Drawing.Point(168, 228)
        Me.lbl_bill_amt.Name = "lbl_bill_amt"
        Me.lbl_bill_amt.Size = New System.Drawing.Size(93, 18)
        Me.lbl_bill_amt.TabIndex = 56
        Me.lbl_bill_amt.Text = "Bill Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Indigo
        Me.Label7.Location = New System.Drawing.Point(12, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 18)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Payment Type"
        '
        'txt_bii_amou
        '
        Me.txt_bii_amou.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bii_amou.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bii_amou.Location = New System.Drawing.Point(270, 225)
        Me.txt_bii_amou.Name = "txt_bii_amou"
        Me.txt_bii_amou.ReadOnly = True
        Me.txt_bii_amou.Size = New System.Drawing.Size(100, 26)
        Me.txt_bii_amou.TabIndex = 52
        '
        'Lblamount
        '
        Me.Lblamount.AutoSize = True
        Me.Lblamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblamount.ForeColor = System.Drawing.Color.Indigo
        Me.Lblamount.Location = New System.Drawing.Point(68, 155)
        Me.Lblamount.Name = "Lblamount"
        Me.Lblamount.Size = New System.Drawing.Size(65, 18)
        Me.Lblamount.TabIndex = 51
        Me.Lblamount.Text = "Amount"
        '
        'txtdisti_Name
        '
        Me.txtdisti_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtdisti_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdisti_Name.Location = New System.Drawing.Point(348, 117)
        Me.txtdisti_Name.Multiline = True
        Me.txtdisti_Name.Name = "txtdisti_Name"
        Me.txtdisti_Name.ReadOnly = True
        Me.txtdisti_Name.Size = New System.Drawing.Size(175, 24)
        Me.txtdisti_Name.TabIndex = 38
        '
        'txt_tax
        '
        Me.txt_tax.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tax.Location = New System.Drawing.Point(421, 152)
        Me.txt_tax.Name = "txt_tax"
        Me.txt_tax.ReadOnly = True
        Me.txt_tax.Size = New System.Drawing.Size(103, 26)
        Me.txt_tax.TabIndex = 37
        '
        'txt_disti_id
        '
        Me.txt_disti_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_disti_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_disti_id.Location = New System.Drawing.Point(141, 117)
        Me.txt_disti_id.Name = "txt_disti_id"
        Me.txt_disti_id.ReadOnly = True
        Me.txt_disti_id.Size = New System.Drawing.Size(105, 26)
        Me.txt_disti_id.TabIndex = 36
        '
        'txt_pur_de_no
        '
        Me.txt_pur_de_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_pur_de_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pur_de_no.Location = New System.Drawing.Point(141, 20)
        Me.txt_pur_de_no.Name = "txt_pur_de_no"
        Me.txt_pur_de_no.ReadOnly = True
        Me.txt_pur_de_no.Size = New System.Drawing.Size(105, 26)
        Me.txt_pur_de_no.TabIndex = 35
        '
        'Lbldisti_name
        '
        Me.Lbldisti_name.AutoSize = True
        Me.Lbldisti_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldisti_name.ForeColor = System.Drawing.Color.Indigo
        Me.Lbldisti_name.Location = New System.Drawing.Point(248, 120)
        Me.Lbldisti_name.Name = "Lbldisti_name"
        Me.Lbldisti_name.Size = New System.Drawing.Size(91, 18)
        Me.Lbldisti_name.TabIndex = 33
        Me.Lbldisti_name.Text = "Disti.Name"
        '
        'Lbldisti_id
        '
        Me.Lbldisti_id.AutoSize = True
        Me.Lbldisti_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbldisti_id.ForeColor = System.Drawing.Color.Indigo
        Me.Lbldisti_id.Location = New System.Drawing.Point(67, 120)
        Me.Lbldisti_id.Name = "Lbldisti_id"
        Me.Lbldisti_id.Size = New System.Drawing.Size(65, 18)
        Me.Lbldisti_id.TabIndex = 32
        Me.Lbldisti_id.Text = "Disti. id"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Indigo
        Me.Label11.Location = New System.Drawing.Point(383, 155)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 18)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Tax"
        '
        'pur_or_no
        '
        Me.pur_or_no.AutoSize = True
        Me.pur_or_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pur_or_no.ForeColor = System.Drawing.Color.Indigo
        Me.pur_or_no.Location = New System.Drawing.Point(177, 72)
        Me.pur_or_no.Name = "pur_or_no"
        Me.pur_or_no.Size = New System.Drawing.Size(84, 18)
        Me.pur_or_no.TabIndex = 29
        Me.pur_or_no.Text = "Pur. or.no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lbl_pur_or_De_no
        '
        Me.lbl_pur_or_De_no.AutoSize = True
        Me.lbl_pur_or_De_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pur_or_De_no.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_pur_or_De_no.Location = New System.Drawing.Point(27, 23)
        Me.lbl_pur_or_De_no.Name = "lbl_pur_or_De_no"
        Me.lbl_pur_or_De_no.Size = New System.Drawing.Size(105, 18)
        Me.lbl_pur_or_De_no.TabIndex = 28
        Me.lbl_pur_or_De_no.Text = "Pur.or.De.no"
        '
        'txtpurc_date
        '
        Me.txtpurc_date.AutoSize = True
        Me.txtpurc_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurc_date.ForeColor = System.Drawing.Color.Indigo
        Me.txtpurc_date.Location = New System.Drawing.Point(357, 23)
        Me.txtpurc_date.Name = "txtpurc_date"
        Me.txtpurc_date.Size = New System.Drawing.Size(43, 18)
        Me.txtpurc_date.TabIndex = 27
        Me.txtpurc_date.Text = "Date"
        '
        'Purchase_order_delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(572, 523)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.lbl_pur_or_deliv)
        Me.Name = "Purchase_order_delivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase_order_delivery"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_pur_or_deliv As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtdeli_rema As System.Windows.Forms.TextBox
    Friend WithEvents txtpay_giv As System.Windows.Forms.TextBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_delivery_remark As System.Windows.Forms.Label
    Friend WithEvents Lbl_balance As System.Windows.Forms.Label
    Friend WithEvents lbl_pay_given As System.Windows.Forms.Label
    Friend WithEvents txt_discou As System.Windows.Forms.TextBox
    Friend WithEvents txtdiscount As System.Windows.Forms.Label
    Friend WithEvents txtoher_charges As System.Windows.Forms.TextBox
    Friend WithEvents txtoth_char As System.Windows.Forms.Label
    Friend WithEvents lbl_bill_amt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_bii_amou As System.Windows.Forms.TextBox
    Friend WithEvents Lblamount As System.Windows.Forms.Label
    Friend WithEvents txtdisti_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_tax As System.Windows.Forms.TextBox
    Friend WithEvents txt_disti_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_pur_de_no As System.Windows.Forms.TextBox
    Friend WithEvents Lbldisti_name As System.Windows.Forms.Label
    Friend WithEvents Lbldisti_id As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents pur_or_no As System.Windows.Forms.Label
    Friend WithEvents lbl_pur_or_De_no As System.Windows.Forms.Label
    Friend WithEvents txtpurc_date As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cob_pur_or_no As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_pay_type As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Btnaddnew As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Btnfind As System.Windows.Forms.Button
    Friend WithEvents Btnlast As System.Windows.Forms.Button
    Friend WithEvents Btnnext As System.Windows.Forms.Button
    Friend WithEvents Btnprevious As System.Windows.Forms.Button
    Friend WithEvents Btnfirst As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btncancel As System.Windows.Forms.Button
End Class
