<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distributer_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Distributer_Master))
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
        Me.Txt_District = New System.Windows.Forms.TextBox
        Me.txt_address = New System.Windows.Forms.TextBox
        Me.Txt_cont_person = New System.Windows.Forms.TextBox
        Me.TXt_dist_name = New System.Windows.Forms.TextBox
        Me.txt_dist_id = New System.Windows.Forms.TextBox
        Me.lbl_district = New System.Windows.Forms.Label
        Me.lbl_city = New System.Windows.Forms.Label
        Me.lbl_address = New System.Windows.Forms.Label
        Me.lbl_cont_person = New System.Windows.Forms.Label
        Me.lbl_dis_name = New System.Windows.Forms.Label
        Me.lbl_dist_id = New System.Windows.Forms.Label
        Me.lbldist_master = New System.Windows.Forms.Label
        Me.Txt_city = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btnaddnew
        '
        Me.Btnaddnew.BackColor = System.Drawing.Color.Pink
        Me.Btnaddnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnaddnew.ForeColor = System.Drawing.Color.Purple
        Me.Btnaddnew.Location = New System.Drawing.Point(22, 3)
        Me.Btnaddnew.Name = "Btnaddnew"
        Me.Btnaddnew.Size = New System.Drawing.Size(66, 49)
        Me.Btnaddnew.TabIndex = 49
        Me.Btnaddnew.Text = "AddNew"
        Me.Btnaddnew.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.Color.Pink
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.Color.Purple
        Me.Btnsave.Location = New System.Drawing.Point(100, 3)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(66, 49)
        Me.Btnsave.TabIndex = 48
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.Pink
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.ForeColor = System.Drawing.Color.Purple
        Me.Btnexit.Location = New System.Drawing.Point(388, 3)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(42, 104)
        Me.Btnexit.TabIndex = 47
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Btnfind
        '
        Me.Btnfind.BackColor = System.Drawing.Color.Pink
        Me.Btnfind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfind.ForeColor = System.Drawing.Color.Purple
        Me.Btnfind.Location = New System.Drawing.Point(316, 58)
        Me.Btnfind.Name = "Btnfind"
        Me.Btnfind.Size = New System.Drawing.Size(66, 49)
        Me.Btnfind.TabIndex = 46
        Me.Btnfind.Text = "Find"
        Me.Btnfind.UseVisualStyleBackColor = False
        '
        'Btnlast
        '
        Me.Btnlast.BackColor = System.Drawing.Color.Pink
        Me.Btnlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlast.ForeColor = System.Drawing.Color.Purple
        Me.Btnlast.Location = New System.Drawing.Point(244, 58)
        Me.Btnlast.Name = "Btnlast"
        Me.Btnlast.Size = New System.Drawing.Size(66, 49)
        Me.Btnlast.TabIndex = 45
        Me.Btnlast.Text = "Last"
        Me.Btnlast.UseVisualStyleBackColor = False
        '
        'Btnnext
        '
        Me.Btnnext.BackColor = System.Drawing.Color.Pink
        Me.Btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnext.ForeColor = System.Drawing.Color.Purple
        Me.Btnnext.Location = New System.Drawing.Point(172, 58)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(66, 49)
        Me.Btnnext.TabIndex = 44
        Me.Btnnext.Text = "Next"
        Me.Btnnext.UseVisualStyleBackColor = False
        '
        'Btnprevious
        '
        Me.Btnprevious.BackColor = System.Drawing.Color.Pink
        Me.Btnprevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnprevious.ForeColor = System.Drawing.Color.Purple
        Me.Btnprevious.Location = New System.Drawing.Point(100, 58)
        Me.Btnprevious.Name = "Btnprevious"
        Me.Btnprevious.Size = New System.Drawing.Size(66, 49)
        Me.Btnprevious.TabIndex = 43
        Me.Btnprevious.Text = "Previous"
        Me.Btnprevious.UseVisualStyleBackColor = False
        '
        'Btnfirst
        '
        Me.Btnfirst.BackColor = System.Drawing.Color.Pink
        Me.Btnfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnfirst.ForeColor = System.Drawing.Color.Purple
        Me.Btnfirst.Location = New System.Drawing.Point(22, 58)
        Me.Btnfirst.Name = "Btnfirst"
        Me.Btnfirst.Size = New System.Drawing.Size(66, 49)
        Me.Btnfirst.TabIndex = 42
        Me.Btnfirst.Text = "First"
        Me.Btnfirst.UseVisualStyleBackColor = False
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.Pink
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.Color.Purple
        Me.Btndelete.Location = New System.Drawing.Point(316, 3)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(66, 49)
        Me.Btndelete.TabIndex = 41
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnupdate
        '
        Me.Btnupdate.BackColor = System.Drawing.Color.Pink
        Me.Btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnupdate.ForeColor = System.Drawing.Color.Purple
        Me.Btnupdate.Location = New System.Drawing.Point(244, 3)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(66, 49)
        Me.Btnupdate.TabIndex = 40
        Me.Btnupdate.Text = "update"
        Me.Btnupdate.UseVisualStyleBackColor = False
        '
        'Btncancel
        '
        Me.Btncancel.BackColor = System.Drawing.Color.Pink
        Me.Btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancel.ForeColor = System.Drawing.Color.Purple
        Me.Btncancel.Location = New System.Drawing.Point(172, 3)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(66, 49)
        Me.Btncancel.TabIndex = 39
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = False
        '
        'Txt_District
        '
        Me.Txt_District.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_District.Location = New System.Drawing.Point(198, 252)
        Me.Txt_District.Multiline = True
        Me.Txt_District.Name = "Txt_District"
        Me.Txt_District.Size = New System.Drawing.Size(139, 24)
        Me.Txt_District.TabIndex = 38
        '
        'txt_address
        '
        Me.txt_address.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_address.Location = New System.Drawing.Point(198, 159)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(204, 48)
        Me.txt_address.TabIndex = 37
        '
        'Txt_cont_person
        '
        Me.Txt_cont_person.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_cont_person.Location = New System.Drawing.Point(198, 120)
        Me.Txt_cont_person.Name = "Txt_cont_person"
        Me.Txt_cont_person.Size = New System.Drawing.Size(204, 20)
        Me.Txt_cont_person.TabIndex = 36
        '
        'TXt_dist_name
        '
        Me.TXt_dist_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TXt_dist_name.Location = New System.Drawing.Point(198, 79)
        Me.TXt_dist_name.Name = "TXt_dist_name"
        Me.TXt_dist_name.Size = New System.Drawing.Size(158, 20)
        Me.TXt_dist_name.TabIndex = 35
        '
        'txt_dist_id
        '
        Me.txt_dist_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_dist_id.Location = New System.Drawing.Point(198, 39)
        Me.txt_dist_id.Name = "txt_dist_id"
        Me.txt_dist_id.Size = New System.Drawing.Size(98, 20)
        Me.txt_dist_id.TabIndex = 34
        '
        'lbl_district
        '
        Me.lbl_district.AutoSize = True
        Me.lbl_district.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_district.ForeColor = System.Drawing.Color.Navy
        Me.lbl_district.Location = New System.Drawing.Point(23, 252)
        Me.lbl_district.Name = "lbl_district"
        Me.lbl_district.Size = New System.Drawing.Size(66, 20)
        Me.lbl_district.TabIndex = 33
        Me.lbl_district.Text = "District"
        '
        'lbl_city
        '
        Me.lbl_city.AutoSize = True
        Me.lbl_city.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_city.ForeColor = System.Drawing.Color.Navy
        Me.lbl_city.Location = New System.Drawing.Point(23, 218)
        Me.lbl_city.Name = "lbl_city"
        Me.lbl_city.Size = New System.Drawing.Size(39, 20)
        Me.lbl_city.TabIndex = 32
        Me.lbl_city.Text = "City"
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.ForeColor = System.Drawing.Color.Navy
        Me.lbl_address.Location = New System.Drawing.Point(21, 159)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(75, 20)
        Me.lbl_address.TabIndex = 30
        Me.lbl_address.Text = "Address"
        '
        'lbl_cont_person
        '
        Me.lbl_cont_person.AutoSize = True
        Me.lbl_cont_person.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cont_person.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cont_person.Location = New System.Drawing.Point(21, 120)
        Me.lbl_cont_person.Name = "lbl_cont_person"
        Me.lbl_cont_person.Size = New System.Drawing.Size(137, 20)
        Me.lbl_cont_person.TabIndex = 29
        Me.lbl_cont_person.Text = "Contact_person"
        '
        'lbl_dis_name
        '
        Me.lbl_dis_name.AutoSize = True
        Me.lbl_dis_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dis_name.ForeColor = System.Drawing.Color.Navy
        Me.lbl_dis_name.Location = New System.Drawing.Point(23, 79)
        Me.lbl_dis_name.Name = "lbl_dis_name"
        Me.lbl_dis_name.Size = New System.Drawing.Size(141, 20)
        Me.lbl_dis_name.TabIndex = 28
        Me.lbl_dis_name.Text = "Distibuter_name"
        '
        'lbl_dist_id
        '
        Me.lbl_dist_id.AutoSize = True
        Me.lbl_dist_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dist_id.ForeColor = System.Drawing.Color.Navy
        Me.lbl_dist_id.Location = New System.Drawing.Point(23, 39)
        Me.lbl_dist_id.Name = "lbl_dist_id"
        Me.lbl_dist_id.Size = New System.Drawing.Size(111, 20)
        Me.lbl_dist_id.TabIndex = 27
        Me.lbl_dist_id.Text = "Distibuter_id"
        '
        'lbldist_master
        '
        Me.lbldist_master.AutoSize = True
        Me.lbldist_master.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbldist_master.Font = New System.Drawing.Font("Modern No. 20", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldist_master.ForeColor = System.Drawing.Color.SpringGreen
        Me.lbldist_master.Location = New System.Drawing.Point(137, 9)
        Me.lbldist_master.Name = "lbldist_master"
        Me.lbldist_master.Size = New System.Drawing.Size(237, 29)
        Me.lbldist_master.TabIndex = 26
        Me.lbldist_master.Text = "Distibuter_Master"
        '
        'Txt_city
        '
        Me.Txt_city.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_city.Location = New System.Drawing.Point(198, 218)
        Me.Txt_city.Name = "Txt_city"
        Me.Txt_city.Size = New System.Drawing.Size(113, 20)
        Me.Txt_city.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Violet
        Me.Panel1.Controls.Add(Me.Txt_city)
        Me.Panel1.Controls.Add(Me.Txt_District)
        Me.Panel1.Controls.Add(Me.txt_address)
        Me.Panel1.Controls.Add(Me.Txt_cont_person)
        Me.Panel1.Controls.Add(Me.TXt_dist_name)
        Me.Panel1.Controls.Add(Me.txt_dist_id)
        Me.Panel1.Controls.Add(Me.lbl_district)
        Me.Panel1.Controls.Add(Me.lbl_city)
        Me.Panel1.Controls.Add(Me.lbl_address)
        Me.Panel1.Controls.Add(Me.lbl_cont_person)
        Me.Panel1.Controls.Add(Me.lbl_dis_name)
        Me.Panel1.Controls.Add(Me.lbl_dist_id)
        Me.Panel1.Location = New System.Drawing.Point(42, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 305)
        Me.Panel1.TabIndex = 51
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
        Me.Panel2.Location = New System.Drawing.Point(42, 367)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(440, 124)
        Me.Panel2.TabIndex = 52
        '
        'Distributer_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 537)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbldist_master)
        Me.Name = "Distributer_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distributer_Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Txt_District As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cont_person As System.Windows.Forms.TextBox
    Friend WithEvents TXt_dist_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_dist_id As System.Windows.Forms.TextBox
    Friend WithEvents lbl_district As System.Windows.Forms.Label
    Friend WithEvents lbl_city As System.Windows.Forms.Label
    Friend WithEvents lbl_address As System.Windows.Forms.Label
    Friend WithEvents lbl_cont_person As System.Windows.Forms.Label
    Friend WithEvents lbl_dis_name As System.Windows.Forms.Label
    Friend WithEvents lbl_dist_id As System.Windows.Forms.Label
    Friend WithEvents lbldist_master As System.Windows.Forms.Label
    Friend WithEvents Txt_city As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
