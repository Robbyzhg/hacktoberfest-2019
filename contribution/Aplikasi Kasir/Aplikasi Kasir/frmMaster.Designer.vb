<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaster))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuManageUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuManageBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuChangeAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuKasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAppKasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuChangeKasir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuTambahBarang = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuChangeSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.menuShortcutKeyboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.menuAdmin, Me.menuKasir, Me.menuSupplier})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(812, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuLogin, Me.menuLogout, Me.ToolStripSeparator1, Me.menuKeluar})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'menuLogin
        '
        Me.menuLogin.Name = "menuLogin"
        Me.menuLogin.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.menuLogin.Size = New System.Drawing.Size(131, 22)
        Me.menuLogin.Text = "Login"
        '
        'menuLogout
        '
        Me.menuLogout.Name = "menuLogout"
        Me.menuLogout.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.menuLogout.Size = New System.Drawing.Size(131, 22)
        Me.menuLogout.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'menuKeluar
        '
        Me.menuKeluar.Name = "menuKeluar"
        Me.menuKeluar.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.menuKeluar.Size = New System.Drawing.Size(131, 22)
        Me.menuKeluar.Text = "Keluar"
        '
        'menuAdmin
        '
        Me.menuAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuManageUser, Me.menuManageBarang, Me.ToolStripSeparator2, Me.menuChangeAdmin})
        Me.menuAdmin.Name = "menuAdmin"
        Me.menuAdmin.Size = New System.Drawing.Size(55, 20)
        Me.menuAdmin.Text = "Admin"
        '
        'menuManageUser
        '
        Me.menuManageUser.Name = "menuManageUser"
        Me.menuManageUser.Size = New System.Drawing.Size(186, 22)
        Me.menuManageUser.Text = "Manajemen User"
        '
        'menuManageBarang
        '
        Me.menuManageBarang.Name = "menuManageBarang"
        Me.menuManageBarang.Size = New System.Drawing.Size(186, 22)
        Me.menuManageBarang.Text = "Manajemen Barang"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'menuChangeAdmin
        '
        Me.menuChangeAdmin.Name = "menuChangeAdmin"
        Me.menuChangeAdmin.Size = New System.Drawing.Size(186, 22)
        Me.menuChangeAdmin.Text = "Ganti Informasi Akun"
        '
        'menuKasir
        '
        Me.menuKasir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAppKasir, Me.menuShortcutKeyboard, Me.ToolStripSeparator3, Me.menuChangeKasir})
        Me.menuKasir.Name = "menuKasir"
        Me.menuKasir.Size = New System.Drawing.Size(44, 20)
        Me.menuKasir.Text = "Kasir"
        '
        'menuAppKasir
        '
        Me.menuAppKasir.Name = "menuAppKasir"
        Me.menuAppKasir.Size = New System.Drawing.Size(186, 22)
        Me.menuAppKasir.Text = "Aplikasi Kasir"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(183, 6)
        '
        'menuChangeKasir
        '
        Me.menuChangeKasir.Name = "menuChangeKasir"
        Me.menuChangeKasir.Size = New System.Drawing.Size(186, 22)
        Me.menuChangeKasir.Text = "Ganti Informasi Akun"
        '
        'menuSupplier
        '
        Me.menuSupplier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuTambahBarang, Me.ToolStripSeparator4, Me.menuChangeSupplier})
        Me.menuSupplier.Name = "menuSupplier"
        Me.menuSupplier.Size = New System.Drawing.Size(62, 20)
        Me.menuSupplier.Text = "Supplier"
        '
        'menuTambahBarang
        '
        Me.menuTambahBarang.Name = "menuTambahBarang"
        Me.menuTambahBarang.Size = New System.Drawing.Size(186, 22)
        Me.menuTambahBarang.Text = "Tambah Barang"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(183, 6)
        '
        'menuChangeSupplier
        '
        Me.menuChangeSupplier.Name = "menuChangeSupplier"
        Me.menuChangeSupplier.Size = New System.Drawing.Size(186, 22)
        Me.menuChangeSupplier.Text = "Ganti Informasi Akun"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'menuShortcutKeyboard
        '
        Me.menuShortcutKeyboard.Name = "menuShortcutKeyboard"
        Me.menuShortcutKeyboard.Size = New System.Drawing.Size(186, 22)
        Me.menuShortcutKeyboard.Text = "Shortcut Keyboard"
        '
        'frmMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(812, 431)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuManageUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuManageBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuChangeAdmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuKasir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAppKasir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuChangeKasir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuTambahBarang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuChangeSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents menuShortcutKeyboard As System.Windows.Forms.ToolStripMenuItem
End Class
