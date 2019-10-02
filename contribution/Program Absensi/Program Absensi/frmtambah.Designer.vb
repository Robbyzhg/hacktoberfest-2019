<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtambah
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
        Me.dgvuser = New System.Windows.Forms.DataGridView()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.gbxtambah = New System.Windows.Forms.GroupBox()
        Me.cmblevel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxedit = New System.Windows.Forms.GroupBox()
        Me.cmblevel2 = New System.Windows.Forms.ComboBox()
        Me.txtid2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncancel2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsubmit2 = New System.Windows.Forms.Button()
        Me.txtusername2 = New System.Windows.Forms.TextBox()
        Me.txtpassword2 = New System.Windows.Forms.TextBox()
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxtambah.SuspendLayout()
        Me.gbxedit.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvuser
        '
        Me.dgvuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvuser.Location = New System.Drawing.Point(8, 6)
        Me.dgvuser.Name = "dgvuser"
        Me.dgvuser.Size = New System.Drawing.Size(474, 432)
        Me.dgvuser.TabIndex = 0
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(499, 13)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(105, 44)
        Me.btntambah.TabIndex = 1
        Me.btntambah.Text = "Tambah User"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(610, 13)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(105, 44)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit User"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(721, 13)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(105, 44)
        Me.btnhapus.TabIndex = 3
        Me.btnhapus.Text = "Hapus User"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'gbxtambah
        '
        Me.gbxtambah.Controls.Add(Me.cmblevel)
        Me.gbxtambah.Controls.Add(Me.Label3)
        Me.gbxtambah.Controls.Add(Me.btncancel)
        Me.gbxtambah.Controls.Add(Me.btnsubmit)
        Me.gbxtambah.Controls.Add(Me.txtid)
        Me.gbxtambah.Controls.Add(Me.txtpassword)
        Me.gbxtambah.Controls.Add(Me.txtusername)
        Me.gbxtambah.Controls.Add(Me.Label2)
        Me.gbxtambah.Controls.Add(Me.Label1)
        Me.gbxtambah.Location = New System.Drawing.Point(501, 71)
        Me.gbxtambah.Name = "gbxtambah"
        Me.gbxtambah.Size = New System.Drawing.Size(324, 179)
        Me.gbxtambah.TabIndex = 4
        Me.gbxtambah.TabStop = False
        Me.gbxtambah.Text = "Tambah User"
        '
        'cmblevel
        '
        Me.cmblevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblevel.FormattingEnabled = True
        Me.cmblevel.Items.AddRange(New Object() {"User", "Superuser"})
        Me.cmblevel.Location = New System.Drawing.Point(71, 121)
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Size = New System.Drawing.Size(246, 21)
        Me.cmblevel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Level"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(162, 150)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(243, 150)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 5
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(70, 20)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(98, 20)
        Me.txtid.TabIndex = 4
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(70, 88)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(248, 20)
        Me.txtpassword.TabIndex = 3
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(70, 54)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(248, 20)
        Me.txtusername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'gbxedit
        '
        Me.gbxedit.Controls.Add(Me.cmblevel2)
        Me.gbxedit.Controls.Add(Me.txtid2)
        Me.gbxedit.Controls.Add(Me.Label4)
        Me.gbxedit.Controls.Add(Me.Label6)
        Me.gbxedit.Controls.Add(Me.btncancel2)
        Me.gbxedit.Controls.Add(Me.Label5)
        Me.gbxedit.Controls.Add(Me.btnsubmit2)
        Me.gbxedit.Controls.Add(Me.txtusername2)
        Me.gbxedit.Controls.Add(Me.txtpassword2)
        Me.gbxedit.Location = New System.Drawing.Point(502, 256)
        Me.gbxedit.Name = "gbxedit"
        Me.gbxedit.Size = New System.Drawing.Size(324, 182)
        Me.gbxedit.TabIndex = 5
        Me.gbxedit.TabStop = False
        Me.gbxedit.Text = "Edit User"
        '
        'cmblevel2
        '
        Me.cmblevel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblevel2.FormattingEnabled = True
        Me.cmblevel2.Items.AddRange(New Object() {"User", "Superuser"})
        Me.cmblevel2.Location = New System.Drawing.Point(70, 120)
        Me.cmblevel2.Name = "cmblevel2"
        Me.cmblevel2.Size = New System.Drawing.Size(246, 21)
        Me.cmblevel2.TabIndex = 17
        '
        'txtid2
        '
        Me.txtid2.Location = New System.Drawing.Point(69, 19)
        Me.txtid2.Name = "txtid2"
        Me.txtid2.ReadOnly = True
        Me.txtid2.Size = New System.Drawing.Size(98, 20)
        Me.txtid2.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Username"
        '
        'btncancel2
        '
        Me.btncancel2.Location = New System.Drawing.Point(161, 149)
        Me.btncancel2.Name = "btncancel2"
        Me.btncancel2.Size = New System.Drawing.Size(75, 23)
        Me.btncancel2.TabIndex = 15
        Me.btncancel2.Text = "Cancel"
        Me.btncancel2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Password"
        '
        'btnsubmit2
        '
        Me.btnsubmit2.Location = New System.Drawing.Point(242, 149)
        Me.btnsubmit2.Name = "btnsubmit2"
        Me.btnsubmit2.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit2.TabIndex = 14
        Me.btnsubmit2.Text = "Submit"
        Me.btnsubmit2.UseVisualStyleBackColor = True
        '
        'txtusername2
        '
        Me.txtusername2.Location = New System.Drawing.Point(69, 53)
        Me.txtusername2.Name = "txtusername2"
        Me.txtusername2.Size = New System.Drawing.Size(248, 20)
        Me.txtusername2.TabIndex = 11
        '
        'txtpassword2
        '
        Me.txtpassword2.Location = New System.Drawing.Point(69, 87)
        Me.txtpassword2.Name = "txtpassword2"
        Me.txtpassword2.Size = New System.Drawing.Size(248, 20)
        Me.txtpassword2.TabIndex = 12
        '
        'frmtambah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 450)
        Me.Controls.Add(Me.gbxedit)
        Me.Controls.Add(Me.gbxtambah)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.dgvuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmtambah"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen User"
        CType(Me.dgvuser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxtambah.ResumeLayout(False)
        Me.gbxtambah.PerformLayout()
        Me.gbxedit.ResumeLayout(False)
        Me.gbxedit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvuser As System.Windows.Forms.DataGridView
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents gbxtambah As System.Windows.Forms.GroupBox
    Friend WithEvents gbxedit As System.Windows.Forms.GroupBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmblevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmblevel2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtid2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncancel2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnsubmit2 As System.Windows.Forms.Button
    Friend WithEvents txtusername2 As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword2 As System.Windows.Forms.TextBox
End Class
