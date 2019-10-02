<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistabsen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbformat = New System.Windows.Forms.ComboBox()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.cmbtanggal = New System.Windows.Forms.ComboBox()
        Me.lblbulan = New System.Windows.Forms.Label()
        Me.cmbbulan = New System.Windows.Forms.ComboBox()
        Me.lbltahun = New System.Windows.Forms.Label()
        Me.cmbtahun = New System.Windows.Forms.ComboBox()
        Me.dgvsiswa = New System.Windows.Forms.DataGridView()
        Me.cmbcarisiswa = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbabsen = New System.Windows.Forms.ComboBox()
        Me.lblizin = New System.Windows.Forms.Label()
        Me.lblsakit = New System.Windows.Forms.Label()
        Me.lblalfa = New System.Windows.Forms.Label()
        Me.lbltampil = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbkelas
        '
        Me.cmbkelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbkelas.FormattingEnabled = True
        Me.cmbkelas.Location = New System.Drawing.Point(72, 12)
        Me.cmbkelas.Name = "cmbkelas"
        Me.cmbkelas.Size = New System.Drawing.Size(121, 21)
        Me.cmbkelas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kelas :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tampil Berdasarkan :"
        '
        'cmbformat
        '
        Me.cmbformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbformat.FormattingEnabled = True
        Me.cmbformat.Items.AddRange(New Object() {"Tahun", "Bulan - Tahun", "Tanggal - Bulan - Tahun"})
        Me.cmbformat.Location = New System.Drawing.Point(140, 50)
        Me.cmbformat.Name = "cmbformat"
        Me.cmbformat.Size = New System.Drawing.Size(121, 21)
        Me.cmbformat.TabIndex = 3
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Location = New System.Drawing.Point(27, 87)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(52, 13)
        Me.lbltanggal.TabIndex = 5
        Me.lbltanggal.Text = "Tanggal :"
        Me.lbltanggal.Visible = False
        '
        'cmbtanggal
        '
        Me.cmbtanggal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtanggal.FormattingEnabled = True
        Me.cmbtanggal.Location = New System.Drawing.Point(85, 84)
        Me.cmbtanggal.Name = "cmbtanggal"
        Me.cmbtanggal.Size = New System.Drawing.Size(52, 21)
        Me.cmbtanggal.TabIndex = 4
        Me.cmbtanggal.Visible = False
        '
        'lblbulan
        '
        Me.lblbulan.AutoSize = True
        Me.lblbulan.Location = New System.Drawing.Point(148, 87)
        Me.lblbulan.Name = "lblbulan"
        Me.lblbulan.Size = New System.Drawing.Size(40, 13)
        Me.lblbulan.TabIndex = 7
        Me.lblbulan.Text = "Bulan :"
        Me.lblbulan.Visible = False
        '
        'cmbbulan
        '
        Me.cmbbulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbulan.FormattingEnabled = True
        Me.cmbbulan.Location = New System.Drawing.Point(194, 84)
        Me.cmbbulan.Name = "cmbbulan"
        Me.cmbbulan.Size = New System.Drawing.Size(52, 21)
        Me.cmbbulan.TabIndex = 6
        Me.cmbbulan.Visible = False
        '
        'lbltahun
        '
        Me.lbltahun.AutoSize = True
        Me.lbltahun.Location = New System.Drawing.Point(258, 87)
        Me.lbltahun.Name = "lbltahun"
        Me.lbltahun.Size = New System.Drawing.Size(44, 13)
        Me.lbltahun.TabIndex = 9
        Me.lbltahun.Text = "Tahun :"
        Me.lbltahun.Visible = False
        '
        'cmbtahun
        '
        Me.cmbtahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtahun.FormattingEnabled = True
        Me.cmbtahun.Location = New System.Drawing.Point(308, 84)
        Me.cmbtahun.Name = "cmbtahun"
        Me.cmbtahun.Size = New System.Drawing.Size(99, 21)
        Me.cmbtahun.TabIndex = 8
        Me.cmbtahun.Visible = False
        '
        'dgvsiswa
        '
        Me.dgvsiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsiswa.Location = New System.Drawing.Point(10, 125)
        Me.dgvsiswa.Name = "dgvsiswa"
        Me.dgvsiswa.Size = New System.Drawing.Size(823, 241)
        Me.dgvsiswa.TabIndex = 10
        '
        'cmbcarisiswa
        '
        Me.cmbcarisiswa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcarisiswa.FormattingEnabled = True
        Me.cmbcarisiswa.Items.AddRange(New Object() {"Nama", "Nomor Absen"})
        Me.cmbcarisiswa.Location = New System.Drawing.Point(712, 15)
        Me.cmbcarisiswa.Name = "cmbcarisiswa"
        Me.cmbcarisiswa.Size = New System.Drawing.Size(121, 21)
        Me.cmbcarisiswa.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(581, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cari Siswa Berdasarkan :"
        '
        'cmbabsen
        '
        Me.cmbabsen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbabsen.FormattingEnabled = True
        Me.cmbabsen.Location = New System.Drawing.Point(567, 50)
        Me.cmbabsen.Name = "cmbabsen"
        Me.cmbabsen.Size = New System.Drawing.Size(267, 21)
        Me.cmbabsen.TabIndex = 15
        Me.cmbabsen.Visible = False
        '
        'lblizin
        '
        Me.lblizin.AutoSize = True
        Me.lblizin.Location = New System.Drawing.Point(27, 378)
        Me.lblizin.Name = "lblizin"
        Me.lblizin.Size = New System.Drawing.Size(38, 13)
        Me.lblizin.TabIndex = 16
        Me.lblizin.Text = "Izin : 0"
        '
        'lblsakit
        '
        Me.lblsakit.AutoSize = True
        Me.lblsakit.Location = New System.Drawing.Point(137, 378)
        Me.lblsakit.Name = "lblsakit"
        Me.lblsakit.Size = New System.Drawing.Size(46, 13)
        Me.lblsakit.TabIndex = 17
        Me.lblsakit.Text = "Sakit : 0"
        '
        'lblalfa
        '
        Me.lblalfa.AutoSize = True
        Me.lblalfa.Location = New System.Drawing.Point(258, 378)
        Me.lblalfa.Name = "lblalfa"
        Me.lblalfa.Size = New System.Drawing.Size(111, 13)
        Me.lblalfa.TabIndex = 18
        Me.lblalfa.Text = "Tanpa Keterangan : 0"
        '
        'lbltampil
        '
        Me.lbltampil.AutoSize = True
        Me.lbltampil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbltampil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltampil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltampil.Location = New System.Drawing.Point(741, 87)
        Me.lbltampil.Name = "lbltampil"
        Me.lbltampil.Size = New System.Drawing.Size(92, 13)
        Me.lbltampil.TabIndex = 19
        Me.lbltampil.Text = "Tampilkan Semua"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'frmlistabsen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 408)
        Me.Controls.Add(Me.lbltampil)
        Me.Controls.Add(Me.lblalfa)
        Me.Controls.Add(Me.lblsakit)
        Me.Controls.Add(Me.lblizin)
        Me.Controls.Add(Me.cmbabsen)
        Me.Controls.Add(Me.cmbcarisiswa)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvsiswa)
        Me.Controls.Add(Me.lbltahun)
        Me.Controls.Add(Me.cmbtahun)
        Me.Controls.Add(Me.lblbulan)
        Me.Controls.Add(Me.cmbbulan)
        Me.Controls.Add(Me.lbltanggal)
        Me.Controls.Add(Me.cmbtanggal)
        Me.Controls.Add(Me.cmbformat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbkelas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmlistabsen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Absensi Siswa"
        CType(Me.dgvsiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbkelas As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbformat As System.Windows.Forms.ComboBox
    Friend WithEvents lbltanggal As System.Windows.Forms.Label
    Friend WithEvents cmbtanggal As System.Windows.Forms.ComboBox
    Friend WithEvents lblbulan As System.Windows.Forms.Label
    Friend WithEvents cmbbulan As System.Windows.Forms.ComboBox
    Friend WithEvents lbltahun As System.Windows.Forms.Label
    Friend WithEvents cmbtahun As System.Windows.Forms.ComboBox
    Friend WithEvents dgvsiswa As System.Windows.Forms.DataGridView
    Friend WithEvents cmbcarisiswa As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbabsen As System.Windows.Forms.ComboBox
    Friend WithEvents lblizin As System.Windows.Forms.Label
    Friend WithEvents lblsakit As System.Windows.Forms.Label
    Friend WithEvents lblalfa As System.Windows.Forms.Label
    Friend WithEvents lbltampil As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
