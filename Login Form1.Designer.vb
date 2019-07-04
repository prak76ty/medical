<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form1))
        Me.But_exit = New System.Windows.Forms.Button
        Me.But_OK = New System.Windows.Forms.Button
        Me.lbl_com_me_sys = New System.Windows.Forms.Label
        Me.txtpw = New System.Windows.Forms.TextBox
        Me.lbl_password = New System.Windows.Forms.Label
        Me.lbl_user_name = New System.Windows.Forms.Label
        Me.Lbl_login_form = New System.Windows.Forms.Label
        Me.Txtuname = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Btncancle = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'But_exit
        '
        Me.But_exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_exit.Location = New System.Drawing.Point(218, 398)
        Me.But_exit.Name = "But_exit"
        Me.But_exit.Size = New System.Drawing.Size(80, 49)
        Me.But_exit.TabIndex = 14
        Me.But_exit.Text = "Exit"
        Me.But_exit.UseVisualStyleBackColor = False
        '
        'But_OK
        '
        Me.But_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But_OK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_OK.Location = New System.Drawing.Point(104, 398)
        Me.But_OK.Name = "But_OK"
        Me.But_OK.Size = New System.Drawing.Size(79, 49)
        Me.But_OK.TabIndex = 13
        Me.But_OK.Text = "OK"
        Me.But_OK.UseVisualStyleBackColor = False
        '
        'lbl_com_me_sys
        '
        Me.lbl_com_me_sys.AutoSize = True
        Me.lbl_com_me_sys.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_com_me_sys.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_com_me_sys.ForeColor = System.Drawing.Color.Lime
        Me.lbl_com_me_sys.Location = New System.Drawing.Point(170, 9)
        Me.lbl_com_me_sys.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_com_me_sys.Name = "lbl_com_me_sys"
        Me.lbl_com_me_sys.Size = New System.Drawing.Size(386, 39)
        Me.lbl_com_me_sys.TabIndex = 12
        Me.lbl_com_me_sys.Text = "Computerized Medical System"
        '
        'txtpw
        '
        Me.txtpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpw.Location = New System.Drawing.Point(274, 338)
        Me.txtpw.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpw.Size = New System.Drawing.Size(260, 20)
        Me.txtpw.TabIndex = 11
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(270, 296)
        Me.lbl_password.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(99, 24)
        Me.lbl_password.TabIndex = 10
        Me.lbl_password.Text = "Psssword"
        '
        'lbl_user_name
        '
        Me.lbl_user_name.AutoSize = True
        Me.lbl_user_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user_name.Location = New System.Drawing.Point(270, 200)
        Me.lbl_user_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(109, 24)
        Me.lbl_user_name.TabIndex = 9
        Me.lbl_user_name.Text = "user name"
        '
        'Lbl_login_form
        '
        Me.Lbl_login_form.AutoSize = True
        Me.Lbl_login_form.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lbl_login_form.Font = New System.Drawing.Font("Jokerman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_login_form.Location = New System.Drawing.Point(281, 73)
        Me.Lbl_login_form.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_login_form.Name = "Lbl_login_form"
        Me.Lbl_login_form.Size = New System.Drawing.Size(171, 39)
        Me.Lbl_login_form.TabIndex = 8
        Me.Lbl_login_form.Text = "Login form"
        '
        'Txtuname
        '
        Me.Txtuname.Location = New System.Drawing.Point(274, 249)
        Me.Txtuname.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtuname.Name = "Txtuname"
        Me.Txtuname.Size = New System.Drawing.Size(234, 20)
        Me.Txtuname.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 172)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Btncancle
        '
        Me.Btncancle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btncancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancle.Location = New System.Drawing.Point(335, 398)
        Me.Btncancle.Name = "Btncancle"
        Me.Btncancle.Size = New System.Drawing.Size(73, 49)
        Me.Btncancle.TabIndex = 25
        Me.Btncancle.Text = "Cancle"
        Me.Btncancle.UseVisualStyleBackColor = False
        '
        'Login_Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(569, 491)
        Me.Controls.Add(Me.Btncancle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txtuname)
        Me.Controls.Add(Me.But_exit)
        Me.Controls.Add(Me.But_OK)
        Me.Controls.Add(Me.lbl_com_me_sys)
        Me.Controls.Add(Me.txtpw)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_user_name)
        Me.Controls.Add(Me.Lbl_login_form)
        Me.Name = "Login_Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents But_exit As System.Windows.Forms.Button
    Friend WithEvents But_OK As System.Windows.Forms.Button
    Friend WithEvents lbl_com_me_sys As System.Windows.Forms.Label
    Friend WithEvents txtpw As System.Windows.Forms.TextBox
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents lbl_user_name As System.Windows.Forms.Label
    Friend WithEvents Lbl_login_form As System.Windows.Forms.Label
    Friend WithEvents Txtuname As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Btncancle As System.Windows.Forms.Button
End Class
