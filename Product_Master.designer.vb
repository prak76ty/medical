<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Master))
        Me.lbl_pro_mst = New System.Windows.Forms.Label
        Me.lbl_pro_id = New System.Windows.Forms.Label
        Me.lbl_Pro_typ = New System.Windows.Forms.Label
        Me.lbl_pro_nam = New System.Windows.Forms.Label
        Me.lbl_com_na = New System.Windows.Forms.Label
        Me.cob_unit = New System.Windows.Forms.ComboBox
        Me.lbl_Unit = New System.Windows.Forms.Label
        Me.lblDiscription = New System.Windows.Forms.Label
        Me.txt_pro_id = New System.Windows.Forms.TextBox
        Me.Txt_pro_nam = New System.Windows.Forms.TextBox
        Me.TXt_com_nam = New System.Windows.Forms.TextBox
        Me.Txt_Discription = New System.Windows.Forms.TextBox
        Me.Btncancel = New System.Windows.Forms.Button
        Me.Btnupdate = New System.Windows.Forms.Button
        Me.Btndelete = New System.Windows.Forms.Button
        Me.Btnfirst = New System.Windows.Forms.Button
        Me.Btnprevious = New System.Windows.Forms.Button
        Me.Btnnext = New System.Windows.Forms.Button
        Me.Btnlast = New System.Windows.Forms.Button
        Me.Btnfind = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        Me.Btnsave = New System.Windows.Forms.Button
        Me.Btnaddnew = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cobpro_type = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_pro_mst
        '
        Me.lbl_pro_mst.AutoSize = True
        Me.lbl_pro_mst.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_pro_mst.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro_mst.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.lbl_pro_mst.Location = New System.Drawing.Point(149, 29)
        Me.lbl_pro_mst.Name = "lbl_pro_mst"
        Me.lbl_pro_mst.Size = New System.Drawing.Size(208, 29)
        Me.lbl_pro_mst.TabIndex = 0
        Me.lbl_pro_mst.Text = "Product_Master"
        '
        'lbl_pro_id
        '
        Me.lbl_pro_id.AutoSize = True
        Me.lbl_pro_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro_id.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pro_id.Location = New System.Drawing.Point(6, 13)
        Me.lbl_pro_id.Name = "lbl_pro_id"
        Me.lbl_pro_id.Size = New System.Drawing.Size(95, 20)
        Me.lbl_pro_id.TabIndex = 1
        Me.lbl_pro_id.Text = "Product_id"
        '
        'lbl_Pro_typ
        '
        Me.lbl_Pro_typ.AutoSize = True
        Me.lbl_Pro_typ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Pro_typ.ForeColor = System.Drawing.Color.Navy
        Me.lbl_Pro_typ.Location = New System.Drawing.Point(6, 52)
        Me.lbl_Pro_typ.Name = "lbl_Pro_typ"
        Me.lbl_Pro_typ.Size = New System.Drawing.Size(115, 20)
        Me.lbl_Pro_typ.TabIndex = 2
        Me.lbl_Pro_typ.Text = "Product_type"
        '
        'lbl_pro_nam
        '
        Me.lbl_pro_nam.AutoSize = True
        Me.lbl_pro_nam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pro_nam.ForeColor = System.Drawing.Color.Navy
        Me.lbl_pro_nam.Location = New System.Drawing.Point(6, 101)
        Me.lbl_pro_nam.Name = "lbl_pro_nam"
        Me.lbl_pro_nam.Size = New System.Drawing.Size(125, 20)
        Me.lbl_pro_nam.TabIndex = 3
        Me.lbl_pro_nam.Text = "Product_name"
        '
        'lbl_com_na
        '
        Me.lbl_com_na.AutoSize = True
        Me.lbl_com_na.BackColor = System.Drawing.Color.Violet
        Me.lbl_com_na.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_com_na.ForeColor = System.Drawing.Color.Navy
        Me.lbl_com_na.Location = New System.Drawing.Point(6, 149)
        Me.lbl_com_na.Name = "lbl_com_na"
        Me.lbl_com_na.Size = New System.Drawing.Size(137, 20)
        Me.lbl_com_na.TabIndex = 4
        Me.lbl_com_na.Text = "Company_name"
        '
        'cob_unit
        '
        Me.cob_unit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cob_unit.FormattingEnabled = True
        Me.cob_unit.Items.AddRange(New Object() {"Strip", "Box", "Bottle", "Piece", "Unit"})
        Me.cob_unit.Location = New System.Drawing.Point(184, 187)
        Me.cob_unit.Name = "cob_unit"
        Me.cob_unit.Size = New System.Drawing.Size(128, 21)
        Me.cob_unit.TabIndex = 5
        '
        'lbl_Unit
        '
        Me.lbl_Unit.AutoSize = True
        Me.lbl_Unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Unit.ForeColor = System.Drawing.Color.Navy
        Me.lbl_Unit.Location = New System.Drawing.Point(6, 187)
        Me.lbl_Unit.Name = "lbl_Unit"
        Me.lbl_Unit.Size = New System.Drawing.Size(42, 20)
        Me.lbl_Unit.TabIndex = 6
        Me.lbl_Unit.Text = "Unit"
        '
        'lblDiscription
        '
        Me.lblDiscription.AutoSize = True
        Me.lblDiscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscription.ForeColor = System.Drawing.Color.Navy
        Me.lblDiscription.Location = New System.Drawing.Point(6, 244)
        Me.lblDiscription.Name = "lblDiscription"
        Me.lblDiscription.Size = New System.Drawing.Size(94, 20)
        Me.lblDiscription.TabIndex = 7
        Me.lblDiscription.Text = "Discription"
        '
        'txt_pro_id
        '
        Me.txt_pro_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_pro_id.Location = New System.Drawing.Point(183, 13)
        Me.txt_pro_id.Name = "txt_pro_id"
        Me.txt_pro_id.ReadOnly = True
        Me.txt_pro_id.Size = New System.Drawing.Size(98, 20)
        Me.txt_pro_id.TabIndex = 8
        '
        'Txt_pro_nam
        '
        Me.Txt_pro_nam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_pro_nam.Location = New System.Drawing.Point(183, 106)
        Me.Txt_pro_nam.Name = "Txt_pro_nam"
        Me.Txt_pro_nam.Size = New System.Drawing.Size(252, 20)
        Me.Txt_pro_nam.TabIndex = 10
        '
        'TXt_com_nam
        '
        Me.TXt_com_nam.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXt_com_nam.Location = New System.Drawing.Point(183, 149)
        Me.TXt_com_nam.Name = "TXt_com_nam"
        Me.TXt_com_nam.Size = New System.Drawing.Size(252, 20)
        Me.TXt_com_nam.TabIndex = 11
        '
        'Txt_Discription
        '
        Me.Txt_Discription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Discription.Location = New System.Drawing.Point(183, 244)
        Me.Txt_Discription.Multiline = True
        Me.Txt_Discription.Name = "Txt_Discription"
        Me.Txt_Discription.Size = New System.Drawing.Size(252, 62)
        Me.Txt_Discription.TabIndex = 12
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
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Pink
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.Purple
        Me.Btnexit.Location = New System.Drawing.Point(380, 11)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(55, 104)
        Me.Btnexit.TabIndex = 23
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Violet
        Me.Panel1.Controls.Add(Me.Cobpro_type)
        Me.Panel1.Controls.Add(Me.Txt_Discription)
        Me.Panel1.Controls.Add(Me.TXt_com_nam)
        Me.Panel1.Controls.Add(Me.Txt_pro_nam)
        Me.Panel1.Controls.Add(Me.txt_pro_id)
        Me.Panel1.Controls.Add(Me.lblDiscription)
        Me.Panel1.Controls.Add(Me.lbl_Unit)
        Me.Panel1.Controls.Add(Me.cob_unit)
        Me.Panel1.Controls.Add(Me.lbl_com_na)
        Me.Panel1.Controls.Add(Me.lbl_pro_nam)
        Me.Panel1.Controls.Add(Me.lbl_Pro_typ)
        Me.Panel1.Controls.Add(Me.lbl_pro_id)
        Me.Panel1.Location = New System.Drawing.Point(36, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 314)
        Me.Panel1.TabIndex = 26
        '
        'Cobpro_type
        '
        Me.Cobpro_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cobpro_type.FormattingEnabled = True
        Me.Cobpro_type.Items.AddRange(New Object() {"Tablet", "Capsule", "Syrup", "Cosmetics"})
        Me.Cobpro_type.Location = New System.Drawing.Point(181, 54)
        Me.Cobpro_type.Name = "Cobpro_type"
        Me.Cobpro_type.Size = New System.Drawing.Size(121, 21)
        Me.Cobpro_type.TabIndex = 13
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
        Me.Panel2.Location = New System.Drawing.Point(36, 402)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 128)
        Me.Panel2.TabIndex = 27
        '
        'Product_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(521, 595)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_pro_mst)
        Me.Name = "Product_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_pro_mst As System.Windows.Forms.Label
    Friend WithEvents lbl_pro_id As System.Windows.Forms.Label
    Friend WithEvents lbl_Pro_typ As System.Windows.Forms.Label
    Friend WithEvents lbl_pro_nam As System.Windows.Forms.Label
    Friend WithEvents lbl_com_na As System.Windows.Forms.Label
    Friend WithEvents cob_unit As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Unit As System.Windows.Forms.Label
    Friend WithEvents lblDiscription As System.Windows.Forms.Label
    Friend WithEvents txt_pro_id As System.Windows.Forms.TextBox
    Friend WithEvents Txt_pro_nam As System.Windows.Forms.TextBox
    Friend WithEvents TXt_com_nam As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Discription As System.Windows.Forms.TextBox
    Friend WithEvents Btncancel As System.Windows.Forms.Button
    Friend WithEvents Btnupdate As System.Windows.Forms.Button
    Friend WithEvents Btndelete As System.Windows.Forms.Button
    Friend WithEvents Btnfirst As System.Windows.Forms.Button
    Friend WithEvents Btnprevious As System.Windows.Forms.Button
    Friend WithEvents Btnnext As System.Windows.Forms.Button
    Friend WithEvents Btnlast As System.Windows.Forms.Button
    Friend WithEvents Btnfind As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Btnaddnew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Cobpro_type As System.Windows.Forms.ComboBox
End Class
