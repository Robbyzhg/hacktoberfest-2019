<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObat
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
        Me.cmdNext = New System.Windows.Forms.Button
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.cmdLast = New System.Windows.Forms.Button
        Me.erperr = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.cmdprevious = New System.Windows.Forms.Button
        Me.cmdFirst = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdConfirm = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdInsert = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dgdata = New System.Windows.Forms.DataGridView
        Me.lblJK = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblTelp = New System.Windows.Forms.Label
        Me.lblNama = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.cbojk = New System.Windows.Forms.ComboBox
        Me.txtTelp = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.bscData = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel6.SuspendLayout()
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel6.Location = New System.Drawing.Point(179, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(148, 55)
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
        'erperr
        '
        Me.erperr.ContainerControl = Me
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.cmdprevious)
        Me.Panel5.Controls.Add(Me.cmdFirst)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(148, 55)
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
        Me.Panel3.Location = New System.Drawing.Point(268, 250)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 55)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(595, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(23, 305)
        Me.Panel2.TabIndex = 6
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(153, 171)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(100, 41)
        Me.cmdCancel.TabIndex = 20
        Me.cmdCancel.Text = "CANCEL"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(12, 171)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(100, 41)
        Me.cmdConfirm.TabIndex = 19
        Me.cmdConfirm.Text = "CONFIRM"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(268, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(327, 28)
        Me.Panel4.TabIndex = 8
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(153, 171)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(100, 41)
        Me.cmdUpdate.TabIndex = 18
        Me.cmdUpdate.Text = "EDIT"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.Location = New System.Drawing.Point(12, 171)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(100, 41)
        Me.cmdInsert.TabIndex = 17
        Me.cmdInsert.Text = "ADD"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Satuan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Harga"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Merk"
        '
        'dgdata
        '
        Me.dgdata.AllowUserToAddRows = False
        Me.dgdata.AllowUserToDeleteRows = False
        Me.dgdata.BackgroundColor = System.Drawing.Color.Honeydew
        Me.dgdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdata.Location = New System.Drawing.Point(268, 28)
        Me.dgdata.Name = "dgdata"
        Me.dgdata.ReadOnly = True
        Me.dgdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdata.Size = New System.Drawing.Size(327, 222)
        Me.dgdata.TabIndex = 9
        '
        'lblJK
        '
        Me.lblJK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblJK.Location = New System.Drawing.Point(82, 92)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(159, 26)
        Me.lblJK.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.cmdConfirm)
        Me.Panel1.Controls.Add(Me.cmdUpdate)
        Me.Panel1.Controls.Add(Me.cmdInsert)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblJK)
        Me.Panel1.Controls.Add(Me.lblTelp)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.cbojk)
        Me.Panel1.Controls.Add(Me.txtTelp)
        Me.Panel1.Controls.Add(Me.txtNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 305)
        Me.Panel1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ID"
        '
        'lblTelp
        '
        Me.lblTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelp.Location = New System.Drawing.Point(82, 121)
        Me.lblTelp.Name = "lblTelp"
        Me.lblTelp.Size = New System.Drawing.Size(159, 25)
        Me.lblTelp.TabIndex = 8
        '
        'lblNama
        '
        Me.lblNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNama.Location = New System.Drawing.Point(82, 64)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(159, 25)
        Me.lblNama.TabIndex = 6
        '
        'lblID
        '
        Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblID.Location = New System.Drawing.Point(82, 36)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(159, 25)
        Me.lblID.TabIndex = 5
        '
        'cbojk
        '
        Me.cbojk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojk.FormattingEnabled = True
        Me.cbojk.Items.AddRange(New Object() {"Tablet/Kapsul", "Strip", "Botol", "Bungkus"})
        Me.cbojk.Location = New System.Drawing.Point(82, 92)
        Me.cbojk.Name = "cbojk"
        Me.cbojk.Size = New System.Drawing.Size(159, 26)
        Me.cbojk.TabIndex = 3
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(82, 121)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(159, 25)
        Me.txtTelp.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(82, 64)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(159, 25)
        Me.txtNama.TabIndex = 0
        '
        'frmObat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 305)
        Me.Controls.Add(Me.dgdata)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmObat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "OBAT"
        Me.Panel6.ResumeLayout(False)
        CType(Me.erperr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bscData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents erperr As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cmdprevious As System.Windows.Forms.Button
    Friend WithEvents cmdFirst As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgdata As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdConfirm As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents cmdInsert As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblJK As System.Windows.Forms.Label
    Friend WithEvents lblTelp As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents cbojk As System.Windows.Forms.ComboBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents bscData As System.Windows.Forms.BindingSource
End Class
