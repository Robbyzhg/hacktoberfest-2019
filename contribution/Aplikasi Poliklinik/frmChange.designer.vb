<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Label5 = New System.Windows.Forms.Label
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtoldpwd = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtpwd2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cborole = New System.Windows.Forms.ComboBox
        Me.txtuid = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtpwd1 = New System.Windows.Forms.TextBox
        Me.txtNIP = New System.Windows.Forms.TextBox
        Me.cmdConfirm = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboJK = New System.Windows.Forms.ComboBox
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker
        Me.txtTelp = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(259, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 36)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Old" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'txtoldpwd
        '
        Me.txtoldpwd.Location = New System.Drawing.Point(332, 58)
        Me.txtoldpwd.Name = "txtoldpwd"
        Me.txtoldpwd.Size = New System.Drawing.Size(129, 25)
        Me.txtoldpwd.TabIndex = 84
        Me.txtoldpwd.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 36)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Retype" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        '
        'txtpwd2
        '
        Me.txtpwd2.Location = New System.Drawing.Point(332, 120)
        Me.txtpwd2.Name = "txtpwd2"
        Me.txtpwd2.Size = New System.Drawing.Size(129, 25)
        Me.txtpwd2.TabIndex = 87
        Me.txtpwd2.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Role"
        '
        'cborole
        '
        Me.cborole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cborole.FormattingEnabled = True
        Me.cborole.Items.AddRange(New Object() {"NON-USER", "ADMIN", "RESEPSIONIS", "DOKTER"})
        Me.cborole.Location = New System.Drawing.Point(332, 160)
        Me.cborole.Name = "cborole"
        Me.cborole.Size = New System.Drawing.Size(129, 26)
        Me.cborole.TabIndex = 88
        '
        'txtuid
        '
        Me.txtuid.Location = New System.Drawing.Point(332, 28)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(129, 25)
        Me.txtuid.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(259, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Username"
        '
        'txtpwd1
        '
        Me.txtpwd1.Location = New System.Drawing.Point(332, 89)
        Me.txtpwd1.Name = "txtpwd1"
        Me.txtpwd1.Size = New System.Drawing.Size(129, 25)
        Me.txtpwd1.TabIndex = 86
        Me.txtpwd1.UseSystemPasswordChar = True
        '
        'txtNIP
        '
        Me.txtNIP.Location = New System.Drawing.Point(74, 28)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(144, 25)
        Me.txtNIP.TabIndex = 67
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(19, 251)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(100, 48)
        Me.cmdConfirm.TabIndex = 89
        Me.cmdConfirm.Text = "CONFIRM"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(361, 251)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 48)
        Me.cmdCancel.TabIndex = 90
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Gender"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 18)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "DOB"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 18)
        Me.Label11.TabIndex = 76
        Me.Label11.Text = "Telp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 18)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "NIP"
        '
        'cboJK
        '
        Me.cboJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJK.FormattingEnabled = True
        Me.cboJK.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cboJK.Location = New System.Drawing.Point(74, 207)
        Me.cboJK.Name = "cboJK"
        Me.cboJK.Size = New System.Drawing.Size(144, 26)
        Me.cboJK.TabIndex = 72
        '
        'dtpDOB
        '
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(74, 176)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(144, 25)
        Me.dtpDOB.TabIndex = 71
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(74, 145)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(144, 25)
        Me.txtTelp.TabIndex = 70
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(74, 89)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(144, 50)
        Me.txtAlamat.TabIndex = 69
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(74, 58)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(144, 25)
        Me.txtNama.TabIndex = 68
        '
        'frmChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(486, 324)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtoldpwd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpwd2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cborole)
        Me.Controls.Add(Me.txtuid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpwd1)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboJK)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmChange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE INFORMATION"
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtoldpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpwd2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cborole As System.Windows.Forms.ComboBox
    Friend WithEvents txtuid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtpwd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboJK As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
End Class
