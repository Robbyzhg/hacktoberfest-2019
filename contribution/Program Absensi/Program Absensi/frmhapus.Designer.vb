<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhapus
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
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnresetabsen = New System.Windows.Forms.Button()
        Me.btnresetsiswa = New System.Windows.Forms.Button()
        Me.gbxhapus = New System.Windows.Forms.GroupBox()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnaksihapus = New System.Windows.Forms.Button()
        Me.cmbnama = New System.Windows.Forms.ComboBox()
        Me.cmbkelas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbxhapus.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(24, 19)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(106, 27)
        Me.btnhapus.TabIndex = 0
        Me.btnhapus.Text = "Hapus Siswa"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnresetabsen
        '
        Me.btnresetabsen.Location = New System.Drawing.Point(136, 19)
        Me.btnresetabsen.Name = "btnresetabsen"
        Me.btnresetabsen.Size = New System.Drawing.Size(106, 27)
        Me.btnresetabsen.TabIndex = 1
        Me.btnresetabsen.Text = "Reset Absensi"
        Me.btnresetabsen.UseVisualStyleBackColor = True
        '
        'btnresetsiswa
        '
        Me.btnresetsiswa.Location = New System.Drawing.Point(248, 19)
        Me.btnresetsiswa.Name = "btnresetsiswa"
        Me.btnresetsiswa.Size = New System.Drawing.Size(106, 27)
        Me.btnresetsiswa.TabIndex = 2
        Me.btnresetsiswa.Text = "Reset Siswa"
        Me.btnresetsiswa.UseVisualStyleBackColor = True
        '
        'gbxhapus
        '
        Me.gbxhapus.Controls.Add(Me.btnbatal)
        Me.gbxhapus.Controls.Add(Me.btnaksihapus)
        Me.gbxhapus.Controls.Add(Me.cmbnama)
        Me.gbxhapus.Controls.Add(Me.cmbkelas)
        Me.gbxhapus.Controls.Add(Me.Label2)
        Me.gbxhapus.Controls.Add(Me.Label1)
        Me.gbxhapus.Enabled = False
        Me.gbxhapus.Location = New System.Drawing.Point(13, 65)
        Me.gbxhapus.Name = "gbxhapus"
        Me.gbxhapus.Size = New System.Drawing.Size(360, 123)
        Me.gbxhapus.TabIndex = 3
        Me.gbxhapus.TabStop = False
        Me.gbxhapus.Text = "Hapus Siswa"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(123, 86)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(106, 27)
        Me.btnbatal.TabIndex = 5
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnaksihapus
        '
        Me.btnaksihapus.Location = New System.Drawing.Point(235, 86)
        Me.btnaksihapus.Name = "btnaksihapus"
        Me.btnaksihapus.Size = New System.Drawing.Size(106, 27)
        Me.btnaksihapus.TabIndex = 4
        Me.btnaksihapus.Text = "Hapus Siswa"
        Me.btnaksihapus.UseVisualStyleBackColor = True
        '
        'cmbnama
        '
        Me.cmbnama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbnama.FormattingEnabled = True
        Me.cmbnama.Location = New System.Drawing.Point(90, 59)
        Me.cmbnama.Name = "cmbnama"
        Me.cmbnama.Size = New System.Drawing.Size(251, 21)
        Me.cmbnama.TabIndex = 3
        '
        'cmbkelas
        '
        Me.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas.FormattingEnabled = True
        Me.cmbkelas.Location = New System.Drawing.Point(90, 23)
        Me.cmbkelas.Name = "cmbkelas"
        Me.cmbkelas.Size = New System.Drawing.Size(251, 21)
        Me.cmbkelas.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kelas"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'frmhapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 204)
        Me.Controls.Add(Me.gbxhapus)
        Me.Controls.Add(Me.btnresetsiswa)
        Me.Controls.Add(Me.btnresetabsen)
        Me.Controls.Add(Me.btnhapus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmhapus"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hapus"
        Me.gbxhapus.ResumeLayout(False)
        Me.gbxhapus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnresetabsen As System.Windows.Forms.Button
    Friend WithEvents btnresetsiswa As System.Windows.Forms.Button
    Friend WithEvents gbxhapus As System.Windows.Forms.GroupBox
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnaksihapus As System.Windows.Forms.Button
    Friend WithEvents cmbnama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbkelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
