<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiagnosa
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboDokter = New System.Windows.Forms.ComboBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.dgObat = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblHarga = New System.Windows.Forms.Label
        Me.cmdConfirm = New System.Windows.Forms.Button
        Me.cmdAddObat = New System.Windows.Forms.Button
        Me.cmdRemoveobat = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.txtTind = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPera = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDiag = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKelu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtdias = New System.Windows.Forms.TextBox
        Me.txtsis = New System.Windows.Forms.TextBox
        Me.txtBerat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dgData = New System.Windows.Forms.DataGridView
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.bscData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgObat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(28, 512)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(621, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(28, 512)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cboDokter)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(28, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(593, 39)
        Me.Panel3.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Nama Dokter"
        '
        'cboDokter
        '
        Me.cboDokter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDokter.FormattingEnabled = True
        Me.cboDokter.Location = New System.Drawing.Point(113, 7)
        Me.cboDokter.Name = "cboDokter"
        Me.cboDokter.Size = New System.Drawing.Size(191, 26)
        Me.cboDokter.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgObat)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(28, 181)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(593, 331)
        Me.Panel4.TabIndex = 3
        '
        'dgObat
        '
        Me.dgObat.AllowUserToAddRows = False
        Me.dgObat.AllowUserToDeleteRows = False
        Me.dgObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgObat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Jumlah})
        Me.dgObat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgObat.Location = New System.Drawing.Point(0, 133)
        Me.dgObat.Name = "dgObat"
        Me.dgObat.ReadOnly = True
        Me.dgObat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgObat.Size = New System.Drawing.Size(593, 150)
        Me.dgObat.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "No"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Nama Obat"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dosis"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.ReadOnly = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblHarga)
        Me.Panel6.Controls.Add(Me.cmdConfirm)
        Me.Panel6.Controls.Add(Me.cmdAddObat)
        Me.Panel6.Controls.Add(Me.cmdRemoveobat)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 283)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(593, 48)
        Me.Panel6.TabIndex = 5
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(179, 16)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(0, 18)
        Me.lblHarga.TabIndex = 3
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(0, 0)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(153, 48)
        Me.cmdConfirm.TabIndex = 2
        Me.cmdConfirm.Text = "Confirm"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'cmdAddObat
        '
        Me.cmdAddObat.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAddObat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddObat.Location = New System.Drawing.Point(355, 0)
        Me.cmdAddObat.Name = "cmdAddObat"
        Me.cmdAddObat.Size = New System.Drawing.Size(119, 48)
        Me.cmdAddObat.TabIndex = 1
        Me.cmdAddObat.Text = "Add Obat"
        Me.cmdAddObat.UseVisualStyleBackColor = True
        '
        'cmdRemoveobat
        '
        Me.cmdRemoveobat.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdRemoveobat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveobat.Location = New System.Drawing.Point(474, 0)
        Me.cmdRemoveobat.Name = "cmdRemoveobat"
        Me.cmdRemoveobat.Size = New System.Drawing.Size(119, 48)
        Me.cmdRemoveobat.TabIndex = 0
        Me.cmdRemoveobat.Text = "Remove Obat"
        Me.cmdRemoveobat.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.txtTind)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtPera)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtDiag)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.txtKelu)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.txtdias)
        Me.Panel5.Controls.Add(Me.txtsis)
        Me.Panel5.Controls.Add(Me.txtBerat)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(593, 133)
        Me.Panel5.TabIndex = 4
        '
        'txtTind
        '
        Me.txtTind.Location = New System.Drawing.Point(93, 319)
        Me.txtTind.Multiline = True
        Me.txtTind.Name = "txtTind"
        Me.txtTind.Size = New System.Drawing.Size(467, 88)
        Me.txtTind.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tindakan"
        '
        'txtPera
        '
        Me.txtPera.Location = New System.Drawing.Point(93, 225)
        Me.txtPera.Multiline = True
        Me.txtPera.Name = "txtPera"
        Me.txtPera.Size = New System.Drawing.Size(467, 88)
        Me.txtPera.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Perawatan"
        '
        'txtDiag
        '
        Me.txtDiag.Location = New System.Drawing.Point(93, 131)
        Me.txtDiag.Multiline = True
        Me.txtDiag.Name = "txtDiag"
        Me.txtDiag.Size = New System.Drawing.Size(467, 88)
        Me.txtDiag.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Diagnosa"
        '
        'txtKelu
        '
        Me.txtKelu.Location = New System.Drawing.Point(93, 37)
        Me.txtKelu.Multiline = True
        Me.txtKelu.Name = "txtKelu"
        Me.txtKelu.Size = New System.Drawing.Size(467, 88)
        Me.txtKelu.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Keluhan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Diastole"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sistole"
        '
        'txtdias
        '
        Me.txtdias.Location = New System.Drawing.Point(460, 6)
        Me.txtdias.Name = "txtdias"
        Me.txtdias.Size = New System.Drawing.Size(100, 25)
        Me.txtdias.TabIndex = 3
        '
        'txtsis
        '
        Me.txtsis.Location = New System.Drawing.Point(255, 6)
        Me.txtsis.Name = "txtsis"
        Me.txtsis.Size = New System.Drawing.Size(100, 25)
        Me.txtsis.TabIndex = 2
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(56, 6)
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(100, 25)
        Me.txtBerat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Berat"
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.AllowUserToDeleteRows = False
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(28, 39)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.Size = New System.Drawing.Size(593, 142)
        Me.dgData.TabIndex = 4
        '
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'frmDiagnosa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(649, 512)
        Me.Controls.Add(Me.dgData)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDiagnosa"
        Me.Text = "Diagnosa"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgObat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bscData As System.Windows.Forms.BindingSource
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtTind As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPera As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiag As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKelu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdias As System.Windows.Forms.TextBox
    Friend WithEvents txtsis As System.Windows.Forms.TextBox
    Friend WithEvents txtBerat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboDokter As System.Windows.Forms.ComboBox
    Friend WithEvents dgObat As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdAddObat As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveobat As System.Windows.Forms.Button
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
End Class
