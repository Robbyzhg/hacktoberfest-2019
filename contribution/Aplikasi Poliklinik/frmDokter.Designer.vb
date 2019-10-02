<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokter
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.dgdata = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmdprevious = New System.Windows.Forms.Button()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grbjadwal = New System.Windows.Forms.GroupBox()
        Me.cmdremove = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cbojam2 = New System.Windows.Forms.ComboBox()
        Me.cbojam1 = New System.Windows.Forms.ComboBox()
        Me.cbohari = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.llbAddPoli = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTelp = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.cbojk = New System.Windows.Forms.ComboBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.bscData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.dgjadwal2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgJadwal = New System.Windows.Forms.DataGridView()
        Me.bscJadwal = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel6.SuspendLayout()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grbjadwal.SuspendLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.dgjadwal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bscJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(48, 7)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(47, 41)
        Me.cmdNext.TabIndex = 23
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdLast)
        Me.Panel6.Controls.Add(Me.cmdNext)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(342, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(148, 62)
        Me.Panel6.TabIndex = 4
        '
        'cmdLast
        '
        Me.cmdLast.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast.Location = New System.Drawing.Point(101, 7)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(47, 41)
        Me.cmdLast.TabIndex = 24
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'dgdata
        '
        Me.dgdata.AllowUserToAddRows = False
        Me.dgdata.AllowUserToDeleteRows = False
        Me.dgdata.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdata.Location = New System.Drawing.Point(319, 28)
        Me.dgdata.Name = "dgdata"
        Me.dgdata.ReadOnly = True
        Me.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdata.Size = New System.Drawing.Size(490, 240)
        Me.dgdata.TabIndex = 9
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdprevious)
        Me.Panel5.Controls.Add(Me.cmdFirst)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(148, 62)
        Me.Panel5.TabIndex = 3
        '
        'cmdprevious
        '
        Me.cmdprevious.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprevious.Location = New System.Drawing.Point(53, 7)
        Me.cmdprevious.Name = "cmdprevious"
        Me.cmdprevious.Size = New System.Drawing.Size(47, 41)
        Me.cmdprevious.TabIndex = 22
        Me.cmdprevious.Text = "<"
        Me.cmdprevious.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirst.Location = New System.Drawing.Point(0, 7)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(47, 41)
        Me.cmdFirst.TabIndex = 21
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(319, 474)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(490, 62)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(809, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(23, 508)
        Me.Panel2.TabIndex = 6
        '
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(200, 481)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 41)
        Me.cmdCancel.TabIndex = 46
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(19, 481)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(100, 41)
        Me.cmdConfirm.TabIndex = 45
        Me.cmdConfirm.Text = "CONFIRM"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(319, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(513, 28)
        Me.Panel4.TabIndex = 8
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(200, 481)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(100, 41)
        Me.cmdUpdate.TabIndex = 18
        Me.cmdUpdate.Text = "EDIT"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.Location = New System.Drawing.Point(19, 481)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(100, 41)
        Me.cmdInsert.TabIndex = 17
        Me.cmdInsert.Text = "ADD"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 186)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Poli"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Telp"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nama"
        '
        'lblJK
        '
        Me.lblJK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJK.Location = New System.Drawing.Point(82, 183)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(208, 26)
        Me.lblJK.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grbjadwal)
        Me.Panel1.Controls.Add(Me.llbAddPoli)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.cmdConfirm)
        Me.Panel1.Controls.Add(Me.cmdUpdate)
        Me.Panel1.Controls.Add(Me.cmdInsert)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblTelp)
        Me.Panel1.Controls.Add(Me.lblAlamat)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.cbojk)
        Me.Panel1.Controls.Add(Me.txtTelp)
        Me.Panel1.Controls.Add(Me.txtAlamat)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Controls.Add(Me.lblJK)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 536)
        Me.Panel1.TabIndex = 5
        '
        'grbjadwal
        '
        Me.grbjadwal.Controls.Add(Me.cmdremove)
        Me.grbjadwal.Controls.Add(Me.cmdsave)
        Me.grbjadwal.Controls.Add(Me.cbojam2)
        Me.grbjadwal.Controls.Add(Me.cbojam1)
        Me.grbjadwal.Controls.Add(Me.cbohari)
        Me.grbjadwal.Controls.Add(Me.Label3)
        Me.grbjadwal.Controls.Add(Me.Label2)
        Me.grbjadwal.Controls.Add(Me.Label1)
        Me.grbjadwal.Location = New System.Drawing.Point(19, 242)
        Me.grbjadwal.Name = "grbjadwal"
        Me.grbjadwal.Size = New System.Drawing.Size(281, 205)
        Me.grbjadwal.TabIndex = 47
        Me.grbjadwal.TabStop = False
        Me.grbjadwal.Text = "Jadwal"
        '
        'cmdremove
        '
        Me.cmdremove.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdremove.Location = New System.Drawing.Point(171, 141)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(100, 41)
        Me.cmdremove.TabIndex = 53
        Me.cmdremove.Text = "REMOVE"
        Me.cmdremove.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(18, 141)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(100, 41)
        Me.cmdsave.TabIndex = 48
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cbojam2
        '
        Me.cbojam2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojam2.FormattingEnabled = True
        Me.cbojam2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbojam2.Location = New System.Drawing.Point(93, 95)
        Me.cbojam2.Name = "cbojam2"
        Me.cbojam2.Size = New System.Drawing.Size(178, 26)
        Me.cbojam2.TabIndex = 52
        '
        'cbojam1
        '
        Me.cbojam1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojam1.FormattingEnabled = True
        Me.cbojam1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbojam1.Location = New System.Drawing.Point(93, 56)
        Me.cbojam1.Name = "cbojam1"
        Me.cbojam1.Size = New System.Drawing.Size(178, 26)
        Me.cbojam1.TabIndex = 51
        '
        'cbohari
        '
        Me.cbohari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohari.FormattingEnabled = True
        Me.cbohari.Items.AddRange(New Object() {"MINGGU", "SENIN", "SELASA", "RABU", "KAMIS", "JUMAT", "SABTU"})
        Me.cbohari.Location = New System.Drawing.Point(93, 23)
        Me.cbohari.Name = "cbohari"
        Me.cbohari.Size = New System.Drawing.Size(178, 26)
        Me.cbohari.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Jam Selesai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Jam Mulai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Hari"
        '
        'llbAddPoli
        '
        Me.llbAddPoli.AutoSize = True
        Me.llbAddPoli.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llbAddPoli.Location = New System.Drawing.Point(271, 183)
        Me.llbAddPoli.Name = "llbAddPoli"
        Me.llbAddPoli.Size = New System.Drawing.Size(19, 23)
        Me.llbAddPoli.TabIndex = 10
        Me.llbAddPoli.TabStop = True
        Me.llbAddPoli.Text = "+"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ID"
        '
        'lblTelp
        '
        Me.lblTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelp.Location = New System.Drawing.Point(82, 155)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(208, 25)
        Me.lblTelp.TabIndex = 8
        '
        'lblAlamat
        '
        Me.lblAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlamat.Location = New System.Drawing.Point(82, 87)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(208, 62)
        Me.lblAlamat.TabIndex = 7
        '
        'lblNama
        '
        Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNama.Location = New System.Drawing.Point(82, 56)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(208, 25)
        Me.lblNama.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(82, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(208, 25)
        Me.lblID.TabIndex = 5
        '
        'cbojk
        '
        Me.cbojk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojk.FormattingEnabled = True
        Me.cbojk.Location = New System.Drawing.Point(82, 183)
        Me.cbojk.Name = "cbojk"
        Me.cbojk.Size = New System.Drawing.Size(178, 26)
        Me.cbojk.TabIndex = 4
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(82, 155)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(208, 25)
        Me.txtTelp.TabIndex = 2
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(82, 87)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(208, 62)
        Me.txtAlamat.TabIndex = 1
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(82, 56)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(208, 25)
        Me.txtNama.TabIndex = 0
        '
        'bscData
        '
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.dgjadwal2)
        Me.Panel7.Controls.Add(Me.dgJadwal)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(319, 268)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(490, 206)
        Me.Panel7.TabIndex = 10
        '
        'dgjadwal2
        '
        Me.dgjadwal2.AllowUserToAddRows = False
        Me.dgjadwal2.AllowUserToDeleteRows = False
        Me.dgjadwal2.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgjadwal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgjadwal2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgjadwal2.Location = New System.Drawing.Point(0, 30)
        Me.dgjadwal2.Name = "dgjadwal2"
        Me.dgjadwal2.ReadOnly = True
        Me.dgjadwal2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgjadwal2.Size = New System.Drawing.Size(490, 176)
        Me.dgjadwal2.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Hari"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = " Jam Mulai"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jam Selesai"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 5
        '
        'dgJadwal
        '
        Me.dgJadwal.AllowUserToAddRows = False
        Me.dgJadwal.AllowUserToDeleteRows = False
        Me.dgJadwal.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJadwal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgJadwal.Location = New System.Drawing.Point(0, 30)
        Me.dgJadwal.Name = "dgJadwal"
        Me.dgJadwal.ReadOnly = True
        Me.dgJadwal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgJadwal.Size = New System.Drawing.Size(490, 176)
        Me.dgJadwal.TabIndex = 10
        '
        'frmDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 536)
        Me.Controls.Add(Me.dgdata)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokter"
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grbjadwal.ResumeLayout(False)
        Me.grbjadwal.PerformLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.dgjadwal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bscJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents dgdata As System.Windows.Forms.DataGridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdprevious As System.Windows.Forms.Button
    Friend WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdInsert As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents lblTelp As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbojk As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents bscData As System.Windows.Forms.BindingSource
    Friend WithEvents llbAddPoli As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents dgJadwal As System.Windows.Forms.DataGridView
    Friend WithEvents grbjadwal As System.Windows.Forms.GroupBox
    Friend WithEvents cbohari As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bscJadwal As System.Windows.Forms.BindingSource
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cbojam2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbojam1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdremove As System.Windows.Forms.Button
    Friend WithEvents dgjadwal2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
