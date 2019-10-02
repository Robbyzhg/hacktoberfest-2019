<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminsert
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
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.cmbkelas = New System.Windows.Forms.ComboBox()
        Me.txtabsen = New System.Windows.Forms.TextBox()
        Me.dgvsiswa = New System.Windows.Forms.DataGridView()
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(30, 370)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(373, 34)
        Me.btnkeluar.TabIndex = 4
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Location = New System.Drawing.Point(30, 330)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(373, 34)
        Me.btnsubmit.TabIndex = 3
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nama Siswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nomor Absen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Kelas"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(86, 123)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(317, 20)
        Me.txtnama.TabIndex = 2
        '
        'cmbkelas
        '
        Me.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas.FormattingEnabled = True
        Me.cmbkelas.Items.AddRange(New Object() {"7A", "7B", "7C", "8A", "8B", "8C", "9A", "9B", "9C"})
        Me.cmbkelas.Location = New System.Drawing.Point(86, 40)
        Me.cmbkelas.Name = "cmbkelas"
        Me.cmbkelas.Size = New System.Drawing.Size(317, 21)
        Me.cmbkelas.TabIndex = 1
        '
        'txtabsen
        '
        Me.txtabsen.Location = New System.Drawing.Point(86, 83)
        Me.txtabsen.Name = "txtabsen"
        Me.txtabsen.ReadOnly = True
        Me.txtabsen.Size = New System.Drawing.Size(69, 20)
        Me.txtabsen.TabIndex = 30
        Me.txtabsen.TabStop = False
        '
        'dgvsiswa
        '
        Me.dgvsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsiswa.Location = New System.Drawing.Point(30, 171)
        Me.dgvsiswa.Name = "dgvsiswa"
        Me.dgvsiswa.Size = New System.Drawing.Size(373, 150)
        Me.dgvsiswa.TabIndex = 31
        '
        'frminsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 414)
        Me.Controls.Add(Me.dgvsiswa)
        Me.Controls.Add(Me.txtabsen)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.cmbkelas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frminsert"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Siswa"
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents cmbkelas As System.Windows.Forms.ComboBox
    Friend WithEvents txtabsen As System.Windows.Forms.TextBox
    Friend WithEvents dgvsiswa As System.Windows.Forms.DataGridView
End Class
