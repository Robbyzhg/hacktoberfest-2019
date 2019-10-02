<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserView
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
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmdLast = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdInsert = New System.Windows.Forms.Button
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.cmdFirst = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgData = New System.Windows.Forms.DataGridView
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblJK = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblDOB = New System.Windows.Forms.Label
        Me.lblTelp = New System.Windows.Forms.Label
        Me.lblAlamat = New System.Windows.Forms.Label
        Me.lblNama = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblID = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRole = New System.Windows.Forms.Label
        Me.bscData = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'cmdLast
        '
        Me.cmdLast.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLast.Location = New System.Drawing.Point(103, 12)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(39, 48)
        Me.cmdLast.TabIndex = 21
        Me.cmdLast.Text = ">>"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNext.Location = New System.Drawing.Point(58, 12)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(39, 48)
        Me.cmdNext.TabIndex = 20
        Me.cmdNext.Text = ">"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(129, 332)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(100, 48)
        Me.cmdUpdate.TabIndex = 19
        Me.cmdUpdate.Text = "EDIT"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.Location = New System.Drawing.Point(15, 332)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(100, 48)
        Me.cmdInsert.TabIndex = 18
        Me.cmdInsert.Text = "ADD"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdPrevious)
        Me.Panel5.Controls.Add(Me.cmdFirst)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(142, 75)
        Me.Panel5.TabIndex = 4
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrevious.Location = New System.Drawing.Point(45, 12)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(39, 48)
        Me.cmdPrevious.TabIndex = 20
        Me.cmdPrevious.Text = "<"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFirst.Location = New System.Drawing.Point(0, 12)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(39, 48)
        Me.cmdFirst.TabIndex = 19
        Me.cmdFirst.Text = "<<"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "DOB"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cmdLast)
        Me.Panel6.Controls.Add(Me.cmdNext)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(388, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(142, 75)
        Me.Panel6.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 18)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Telp"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(245, 320)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(530, 75)
        Me.Panel4.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Nama"
        '
        'dgData
        '
        Me.dgData.AllowUserToAddRows = False
        Me.dgData.AllowUserToDeleteRows = False
        Me.dgData.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgData.Location = New System.Drawing.Point(245, 28)
        Me.dgData.Name = "dgData"
        Me.dgData.ReadOnly = True
        Me.dgData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgData.Size = New System.Drawing.Size(530, 292)
        Me.dgData.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ID"
        '
        'lblJK
        '
        Me.lblJK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJK.Location = New System.Drawing.Point(85, 208)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(144, 26)
        Me.lblJK.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(245, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 28)
        Me.Panel3.TabIndex = 23
        '
        'lblDOB
        '
        Me.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDOB.Location = New System.Drawing.Point(85, 177)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(144, 25)
        Me.lblDOB.TabIndex = 9
        '
        'lblTelp
        '
        Me.lblTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelp.Location = New System.Drawing.Point(85, 146)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(144, 25)
        Me.lblTelp.TabIndex = 8
        '
        'lblAlamat
        '
        Me.lblAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAlamat.Location = New System.Drawing.Point(85, 90)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(144, 50)
        Me.lblAlamat.TabIndex = 7
        '
        'lblNama
        '
        Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNama.Location = New System.Drawing.Point(85, 59)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(144, 25)
        Me.lblNama.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(775, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(25, 395)
        Me.Panel2.TabIndex = 22
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(85, 28)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(144, 25)
        Me.lblID.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblRole)
        Me.Panel1.Controls.Add(Me.cmdUpdate)
        Me.Panel1.Controls.Add(Me.cmdInsert)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblJK)
        Me.Panel1.Controls.Add(Me.lblDOB)
        Me.Panel1.Controls.Add(Me.lblTelp)
        Me.Panel1.Controls.Add(Me.lblAlamat)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 395)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Role"
        '
        'lblRole
        '
        Me.lblRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRole.Location = New System.Drawing.Point(85, 240)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(144, 26)
        Me.lblRole.TabIndex = 22
        '
        'frmUserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 395)
        Me.Controls.Add(Me.dgData)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUserView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan"
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents dgData As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdInsert As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblTelp As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents bscData As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
End Class
