<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnMulai = New System.Windows.Forms.Button()
        Me.btnAturan = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.judul = New System.Windows.Forms.Label()
        Me.subjudul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMulai
        '
        Me.btnMulai.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMulai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMulai.Font = New System.Drawing.Font("Futura Heavy", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulai.ForeColor = System.Drawing.SystemColors.Control
        Me.btnMulai.Location = New System.Drawing.Point(33, 316)
        Me.btnMulai.Name = "btnMulai"
        Me.btnMulai.Size = New System.Drawing.Size(248, 48)
        Me.btnMulai.TabIndex = 0
        Me.btnMulai.Text = "Mulai Bermain"
        Me.btnMulai.UseVisualStyleBackColor = False
        '
        'btnAturan
        '
        Me.btnAturan.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAturan.Font = New System.Drawing.Font("Futura Heavy", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAturan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAturan.Location = New System.Drawing.Point(33, 370)
        Me.btnAturan.Name = "btnAturan"
        Me.btnAturan.Size = New System.Drawing.Size(248, 48)
        Me.btnAturan.TabIndex = 1
        Me.btnAturan.Text = "Aturan Bermain"
        Me.btnAturan.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Futura Heavy", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(83, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'judul
        '
        Me.judul.AutoSize = True
        Me.judul.BackColor = System.Drawing.Color.Transparent
        Me.judul.Font = New System.Drawing.Font("Futura Heavy", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judul.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.judul.Location = New System.Drawing.Point(8, 186)
        Me.judul.Name = "judul"
        Me.judul.Size = New System.Drawing.Size(302, 62)
        Me.judul.TabIndex = 3
        Me.judul.Text = "Maze Runner"
        '
        'subjudul
        '
        Me.subjudul.AutoSize = True
        Me.subjudul.BackColor = System.Drawing.Color.Transparent
        Me.subjudul.Font = New System.Drawing.Font("Futura Heavy", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjudul.ForeColor = System.Drawing.SystemColors.Window
        Me.subjudul.Location = New System.Drawing.Point(137, 172)
        Me.subjudul.Name = "subjudul"
        Me.subjudul.Size = New System.Drawing.Size(33, 14)
        Me.subjudul.TabIndex = 4
        Me.subjudul.Text = "scary"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(322, 522)
        Me.Controls.Add(Me.subjudul)
        Me.Controls.Add(Me.judul)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAturan)
        Me.Controls.Add(Me.btnMulai)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maze Runner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMulai As System.Windows.Forms.Button
    Friend WithEvents btnAturan As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents judul As System.Windows.Forms.Label
    Friend WithEvents subjudul As System.Windows.Forms.Label
End Class
