<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtTelp = New System.Windows.Forms.TextBox
        Me.cboDokter = New System.Windows.Forms.ComboBox
        Me.cboJenis = New System.Windows.Forms.ComboBox
        Me.lblInfo = New System.Windows.Forms.Label
        Me.cmdConfirm = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.llbCari = New System.Windows.Forms.LinkLabel
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(91, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(127, 25)
        Me.txtID.TabIndex = 0
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(91, 57)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(177, 25)
        Me.txtNama.TabIndex = 1
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(91, 88)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(177, 63)
        Me.txtAlamat.TabIndex = 2
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(91, 157)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(177, 25)
        Me.txtTelp.TabIndex = 3
        '
        'cboDokter
        '
        Me.cboDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDokter.FormattingEnabled = True
        Me.cboDokter.Location = New System.Drawing.Point(91, 188)
        Me.cboDokter.Name = "cboDokter"
        Me.cboDokter.Size = New System.Drawing.Size(177, 26)
        Me.cboDokter.TabIndex = 4
        '
        'cboJenis
        '
        Me.cboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJenis.FormattingEnabled = True
        Me.cboJenis.Location = New System.Drawing.Point(91, 220)
        Me.cboJenis.Name = "cboJenis"
        Me.cboJenis.Size = New System.Drawing.Size(177, 26)
        Me.cboJenis.TabIndex = 5
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(92, 259)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 18)
        Me.lblInfo.TabIndex = 6
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(12, 303)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(100, 48)
        Me.cmdConfirm.TabIndex = 91
        Me.cmdConfirm.Text = "CONFIRM"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(186, 303)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 48)
        Me.cmdCancel.TabIndex = 92
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "ID Pasien"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 18)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Telp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Dokter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 18)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Jenis"
        '
        'llbCari
        '
        Me.llbCari.AutoSize = True
        Me.llbCari.Location = New System.Drawing.Point(236, 29)
        Me.llbCari.Name = "llbCari"
        Me.llbCari.Size = New System.Drawing.Size(32, 18)
        Me.llbCari.TabIndex = 99
        Me.llbCari.TabStop = True
        Me.llbCari.Text = "Cari"
        '
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(302, 363)
        Me.Controls.Add(Me.llbCari)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.cboJenis)
        Me.Controls.Add(Me.cboDokter)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtID)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTER"
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents cboDokter As System.Windows.Forms.ComboBox
    Friend WithEvents cboJenis As System.Windows.Forms.ComboBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents llbCari As System.Windows.Forms.LinkLabel
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
End Class
