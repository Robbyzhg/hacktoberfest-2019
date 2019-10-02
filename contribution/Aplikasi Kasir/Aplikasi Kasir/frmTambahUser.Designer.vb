<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTambahUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTambahUser))
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.pnlTambah = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.pnlEdit = New System.Windows.Forms.Panel()
        Me.btnCancelE = New System.Windows.Forms.Button()
        Me.txtIDE = New System.Windows.Forms.TextBox()
        Me.btnSubmitE = New System.Windows.Forms.Button()
        Me.cmbLevelE = New System.Windows.Forms.ComboBox()
        Me.txtPasswordE = New System.Windows.Forms.TextBox()
        Me.txtUsernameE = New System.Windows.Forms.TextBox()
        Me.txtNamaE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTambah.SuspendLayout()
        Me.pnlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(7, 9)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(437, 296)
        Me.dgvUser.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Level :"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(78, 37)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(199, 20)
        Me.txtNama.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(78, 65)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(199, 20)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(78, 91)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(199, 20)
        Me.txtPassword.TabIndex = 7
        '
        'cmbLevel
        '
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"ADMIN", "SUPPLIER", "KASIR"})
        Me.cmbLevel.Location = New System.Drawing.Point(79, 116)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(197, 21)
        Me.cmbLevel.TabIndex = 8
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(201, 152)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'pnlTambah
        '
        Me.pnlTambah.Controls.Add(Me.pnlEdit)
        Me.pnlTambah.Controls.Add(Me.btnCancel)
        Me.pnlTambah.Controls.Add(Me.txtID)
        Me.pnlTambah.Controls.Add(Me.btnSubmit)
        Me.pnlTambah.Controls.Add(Me.cmbLevel)
        Me.pnlTambah.Controls.Add(Me.txtPassword)
        Me.pnlTambah.Controls.Add(Me.txtUsername)
        Me.pnlTambah.Controls.Add(Me.txtNama)
        Me.pnlTambah.Controls.Add(Me.Label4)
        Me.pnlTambah.Controls.Add(Me.Label3)
        Me.pnlTambah.Controls.Add(Me.Label2)
        Me.pnlTambah.Controls.Add(Me.Label1)
        Me.pnlTambah.Location = New System.Drawing.Point(468, 91)
        Me.pnlTambah.Name = "pnlTambah"
        Me.pnlTambah.Size = New System.Drawing.Size(301, 181)
        Me.pnlTambah.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 152)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(77, 11)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(64, 20)
        Me.txtID.TabIndex = 10
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(468, 32)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(98, 41)
        Me.btnHapus.TabIndex = 11
        Me.btnHapus.Text = "Hapus User"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(569, 32)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(98, 41)
        Me.btnTambah.TabIndex = 12
        Me.btnTambah.Text = "Tambah User"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(671, 32)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 41)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit User"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'pnlEdit
        '
        Me.pnlEdit.Controls.Add(Me.btnCancelE)
        Me.pnlEdit.Controls.Add(Me.txtIDE)
        Me.pnlEdit.Controls.Add(Me.btnSubmitE)
        Me.pnlEdit.Controls.Add(Me.cmbLevelE)
        Me.pnlEdit.Controls.Add(Me.txtPasswordE)
        Me.pnlEdit.Controls.Add(Me.txtUsernameE)
        Me.pnlEdit.Controls.Add(Me.txtNamaE)
        Me.pnlEdit.Controls.Add(Me.Label5)
        Me.pnlEdit.Controls.Add(Me.Label6)
        Me.pnlEdit.Controls.Add(Me.Label7)
        Me.pnlEdit.Controls.Add(Me.Label8)
        Me.pnlEdit.Enabled = False
        Me.pnlEdit.Location = New System.Drawing.Point(0, 0)
        Me.pnlEdit.Name = "pnlEdit"
        Me.pnlEdit.Size = New System.Drawing.Size(301, 181)
        Me.pnlEdit.TabIndex = 12
        '
        'btnCancelE
        '
        Me.btnCancelE.Location = New System.Drawing.Point(120, 152)
        Me.btnCancelE.Name = "btnCancelE"
        Me.btnCancelE.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelE.TabIndex = 11
        Me.btnCancelE.Text = "Cancel"
        Me.btnCancelE.UseVisualStyleBackColor = True
        '
        'txtIDE
        '
        Me.txtIDE.Location = New System.Drawing.Point(77, 11)
        Me.txtIDE.Name = "txtIDE"
        Me.txtIDE.ReadOnly = True
        Me.txtIDE.Size = New System.Drawing.Size(64, 20)
        Me.txtIDE.TabIndex = 10
        '
        'btnSubmitE
        '
        Me.btnSubmitE.Location = New System.Drawing.Point(201, 152)
        Me.btnSubmitE.Name = "btnSubmitE"
        Me.btnSubmitE.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitE.TabIndex = 9
        Me.btnSubmitE.Text = "Submit"
        Me.btnSubmitE.UseVisualStyleBackColor = True
        '
        'cmbLevelE
        '
        Me.cmbLevelE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevelE.FormattingEnabled = True
        Me.cmbLevelE.Items.AddRange(New Object() {"ADMIN", "SUPPLIER", "KASIR"})
        Me.cmbLevelE.Location = New System.Drawing.Point(79, 116)
        Me.cmbLevelE.Name = "cmbLevelE"
        Me.cmbLevelE.Size = New System.Drawing.Size(197, 21)
        Me.cmbLevelE.TabIndex = 8
        '
        'txtPasswordE
        '
        Me.txtPasswordE.Location = New System.Drawing.Point(78, 91)
        Me.txtPasswordE.Name = "txtPasswordE"
        Me.txtPasswordE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordE.Size = New System.Drawing.Size(199, 20)
        Me.txtPasswordE.TabIndex = 7
        '
        'txtUsernameE
        '
        Me.txtUsernameE.Location = New System.Drawing.Point(78, 65)
        Me.txtUsernameE.Name = "txtUsernameE"
        Me.txtUsernameE.Size = New System.Drawing.Size(199, 20)
        Me.txtUsernameE.TabIndex = 6
        '
        'txtNamaE
        '
        Me.txtNamaE.Location = New System.Drawing.Point(78, 37)
        Me.txtNamaE.Name = "txtNamaE"
        Me.txtNamaE.Size = New System.Drawing.Size(199, 20)
        Me.txtNamaE.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Level :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Password :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Username :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama :"
        '
        'frmTambahUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(781, 324)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.pnlTambah)
        Me.Controls.Add(Me.dgvUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmTambahUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen User"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTambah.ResumeLayout(False)
        Me.pnlTambah.PerformLayout()
        Me.pnlEdit.ResumeLayout(False)
        Me.pnlEdit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents pnlTambah As System.Windows.Forms.Panel
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents pnlEdit As System.Windows.Forms.Panel
    Friend WithEvents btnCancelE As System.Windows.Forms.Button
    Friend WithEvents txtIDE As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmitE As System.Windows.Forms.Button
    Friend WithEvents cmbLevelE As System.Windows.Forms.ComboBox
    Friend WithEvents txtPasswordE As System.Windows.Forms.TextBox
    Friend WithEvents txtUsernameE As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
