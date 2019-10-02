<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmaster
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menulogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menulogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuabsen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.menutambah = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuhapus = New System.Windows.Forms.ToolStripMenuItem()
        Me.menutambahuser = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.menuabsen, Me.menuhistory, Me.menutambah, Me.menuhapus, Me.menutambahuser})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(770, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menulogin, Me.menulogout, Me.ToolStripSeparator1, Me.KeluarToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'menulogin
        '
        Me.menulogin.Name = "menulogin"
        Me.menulogin.Size = New System.Drawing.Size(112, 22)
        Me.menulogin.Text = "Login"
        '
        'menulogout
        '
        Me.menulogout.Name = "menulogout"
        Me.menulogout.Size = New System.Drawing.Size(112, 22)
        Me.menulogout.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'menuabsen
        '
        Me.menuabsen.Name = "menuabsen"
        Me.menuabsen.Size = New System.Drawing.Size(52, 20)
        Me.menuabsen.Text = "Absen"
        '
        'menuhistory
        '
        Me.menuhistory.Name = "menuhistory"
        Me.menuhistory.Size = New System.Drawing.Size(93, 20)
        Me.menuhistory.Text = "History Absen"
        '
        'menutambah
        '
        Me.menutambah.Name = "menutambah"
        Me.menutambah.Size = New System.Drawing.Size(94, 20)
        Me.menutambah.Text = "Tambah Siswa"
        '
        'menuhapus
        '
        Me.menuhapus.Name = "menuhapus"
        Me.menuhapus.Size = New System.Drawing.Size(53, 20)
        Me.menuhapus.Text = "Hapus"
        '
        'menutambahuser
        '
        Me.menutambahuser.Name = "menutambahuser"
        Me.menutambahuser.Size = New System.Drawing.Size(108, 20)
        Me.menutambahuser.Text = "Manajemen User"
        '
        'frmmaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(770, 451)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmmaster"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Program Absen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menulogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menulogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuabsen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menutambah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuhapus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menutambahuser As System.Windows.Forms.ToolStripMenuItem
End Class
