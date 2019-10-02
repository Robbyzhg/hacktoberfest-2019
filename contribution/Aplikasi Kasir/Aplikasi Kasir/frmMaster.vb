Imports System.Data.OleDb
Public Class frmMaster
    Dim nama As String

    Public Sub loginin()
        If idlog = 0 Then
            menuLogin.Enabled = True
            menuLogout.Enabled = False
            menuKeluar.Enabled = True
            menuAdmin.Visible = False
            menuKasir.Visible = False
            menuSupplier.Visible = False
        Else
            conn = New OleDbConnection(db)
            conn.Open()
            cmd = New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = ("SELECT lvl FROM tblUser WHERE ID = " & idlog)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.GetValue(0) = "ADMIN" Then
                menuLogin.Enabled = False
                menuLogout.Enabled = True
                menuAdmin.Visible = True
                menuKasir.Visible = False
                menuSupplier.Visible = False
            ElseIf reader.GetValue(0) = "SUPPLIER" Then
                menuLogin.Enabled = False
                menuLogout.Enabled = True
                menuAdmin.Visible = False
                menuKasir.Visible = False
                menuSupplier.Visible = True
            ElseIf reader.GetValue(0) = "KASIR" Then
                menuLogin.Enabled = False
                menuLogout.Enabled = True
                menuAdmin.Visible = False
                menuKasir.Visible = True
                menuSupplier.Visible = False
            End If
            conn.Close()
        End If
    End Sub

    Sub namauser()
        conn = New OleDbConnection(db)
        conn.Open()
        cmd = New OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = ("SELECT nama FROM tblUser WHERE ID = " & idlog)
        reader = cmd.ExecuteReader
        reader.Read()
        nama = reader.Item("Nama")
    End Sub

    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idlog = 0
        Call loginin()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not idlog = 0 Then
            Timer1.Enabled = False
            Call namauser()
            MessageBox.Show("Selamat bekerja, " + nama, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub menuLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLogin.Click
        frmLogin.Show()
    End Sub

    Private Sub menuKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuKeluar.Click
        End
    End Sub

    Private Sub menuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLogout.Click
        idlog = 0
        Call loginin()
        frmKasir.Close()
        frmChange.Close()
        frmShortcut.Close()
        frmTambah.Close()
        frmTambahUser.Close()
        Timer1.Enabled = True
    End Sub

    Private Sub menuAppKasir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAppKasir.Click
        frmKasir.Show()
    End Sub

    Private Sub menuTambahBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTambahBarang.Click
        frmTambah.Show()
    End Sub

    Private Sub menuManageBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuManageBarang.Click
        frmTambah.Show()
    End Sub

    Private Sub menuManageUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuManageUser.Click
        frmTambahUser.Show()
    End Sub

    Private Sub menuChangeAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuChangeAdmin.Click
        frmChange.Show()
    End Sub

    Private Sub menuChangeKasir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuChangeKasir.Click
        frmChange.Show()
    End Sub

    Private Sub menuChangeSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuChangeSupplier.Click
        frmChange.Show()
    End Sub

    Private Sub ShortcutKeyboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuShortcutKeyboard.Click
        frmShortcut.Show()
    End Sub
End Class