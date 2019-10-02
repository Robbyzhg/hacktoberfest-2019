<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabsen
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbkelas = New System.Windows.Forms.ComboBox()
        Me.cmbabsen = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.TextBox()
        Me.txtbulan = New System.Windows.Forms.TextBox()
        Me.txttahun = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbxket = New System.Windows.Forms.GroupBox()
        Me.optalfa = New System.Windows.Forms.RadioButton()
        Me.optsakit = New System.Windows.Forms.RadioButton()
        Me.optizin = New System.Windows.Forms.RadioButton()
        Me.opthadir = New System.Windows.Forms.RadioButton()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxket.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbkelas
        '
        Me.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas.FormattingEnabled = True
        Me.cmbkelas.Location = New System.Drawing.Point(92, 23)
        Me.cmbkelas.Name = "cmbkelas"
        Me.cmbkelas.Size = New System.Drawing.Size(181, 21)
        Me.cmbkelas.TabIndex = 0
        '
        'cmbabsen
        '
        Me.cmbabsen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbabsen.FormattingEnabled = True
        Me.cmbabsen.Location = New System.Drawing.Point(92, 66)
        Me.cmbabsen.Name = "cmbabsen"
        Me.cmbabsen.Size = New System.Drawing.Size(181, 21)
        Me.cmbabsen.TabIndex = 1
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(92, 128)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.ReadOnly = True
        Me.txtnama.Size = New System.Drawing.Size(181, 20)
        Me.txtnama.TabIndex = 2
        Me.txtnama.TabStop = False
        '
        'txttanggal
        '
        Me.txttanggal.Location = New System.Drawing.Point(92, 168)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.ReadOnly = True
        Me.txttanggal.Size = New System.Drawing.Size(48, 20)
        Me.txttanggal.TabIndex = 4
        Me.txttanggal.TabStop = False
        '
        'txtbulan
        '
        Me.txtbulan.Location = New System.Drawing.Point(146, 168)
        Me.txtbulan.Name = "txtbulan"
        Me.txtbulan.ReadOnly = True
        Me.txtbulan.Size = New System.Drawing.Size(48, 20)
        Me.txtbulan.TabIndex = 5
        Me.txtbulan.TabStop = False
        '
        'txttahun
        '
        Me.txttahun.Location = New System.Drawing.Point(200, 168)
        Me.txttahun.Name = "txttahun"
        Me.txttahun.ReadOnly = True
        Me.txttahun.Size = New System.Drawing.Size(73, 20)
        Me.txttahun.TabIndex = 6
        Me.txttahun.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nomor Absen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama Siswa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tanggal"
        '
        'gbxket
        '
        Me.gbxket.Controls.Add(Me.optalfa)
        Me.gbxket.Controls.Add(Me.optsakit)
        Me.gbxket.Controls.Add(Me.optizin)
        Me.gbxket.Controls.Add(Me.opthadir)
        Me.gbxket.Location = New System.Drawing.Point(36, 217)
        Me.gbxket.Name = "gbxket"
        Me.gbxket.Size = New System.Drawing.Size(236, 91)
        Me.gbxket.TabIndex = 12
        Me.gbxket.TabStop = False
        Me.gbxket.Text = "Keterangan"
        '
        'optalfa
        '
        Me.optalfa.AutoSize = True
        Me.optalfa.Location = New System.Drawing.Point(98, 52)
        Me.optalfa.Name = "optalfa"
        Me.optalfa.Size = New System.Drawing.Size(114, 17)
        Me.optalfa.TabIndex = 3
        Me.optalfa.TabStop = True
        Me.optalfa.Text = "Tanpa Keterangan"
        Me.optalfa.UseVisualStyleBackColor = True
        '
        'optsakit
        '
        Me.optsakit.AutoSize = True
        Me.optsakit.Location = New System.Drawing.Point(98, 29)
        Me.optsakit.Name = "optsakit"
        Me.optsakit.Size = New System.Drawing.Size(49, 17)
        Me.optsakit.TabIndex = 2
        Me.optsakit.TabStop = True
        Me.optsakit.Text = "Sakit"
        Me.optsakit.UseVisualStyleBackColor = True
        '
        'optizin
        '
        Me.optizin.AutoSize = True
        Me.optizin.Location = New System.Drawing.Point(28, 52)
        Me.optizin.Name = "optizin"
        Me.optizin.Size = New System.Drawing.Size(41, 17)
        Me.optizin.TabIndex = 1
        Me.optizin.TabStop = True
        Me.optizin.Text = "Izin"
        Me.optizin.UseVisualStyleBackColor = True
        '
        'opthadir
        '
        Me.opthadir.AutoSize = True
        Me.opthadir.Checked = True
        Me.opthadir.Location = New System.Drawing.Point(28, 29)
        Me.opthadir.Name = "opthadir"
        Me.opthadir.Size = New System.Drawing.Size(50, 17)
        Me.opthadir.TabIndex = 0
        Me.opthadir.TabStop = True
        Me.opthadir.Text = "Hadir"
        Me.opthadir.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(36, 333)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(237, 23)
        Me.btnsubmit.TabIndex = 13
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(36, 362)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(237, 23)
        Me.btnkeluar.TabIndex = 14
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'frmabsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 415)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.gbxket)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttahun)
        Me.Controls.Add(Me.txtbulan)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.cmbabsen)
        Me.Controls.Add(Me.cmbkelas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmabsen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Absen"
        Me.gbxket.ResumeLayout(False)
        Me.gbxket.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbkelas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbabsen As System.Windows.Forms.ComboBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.TextBox
    Friend WithEvents txtbulan As System.Windows.Forms.TextBox
    Friend WithEvents txttahun As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbxket As System.Windows.Forms.GroupBox
    Friend WithEvents optalfa As System.Windows.Forms.RadioButton
    Friend WithEvents optsakit As System.Windows.Forms.RadioButton
    Friend WithEvents optizin As System.Windows.Forms.RadioButton
    Friend WithEvents opthadir As System.Windows.Forms.RadioButton
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
