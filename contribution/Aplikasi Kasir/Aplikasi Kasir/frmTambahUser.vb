Imports System.Data.OleDb

Public Class frmTambahUser

    Sub tampildata()
        Call Konek()
        adapter = New OleDbDataAdapter("SELECT * FROM tblUser ORDER BY id DESC", conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvUser.DataSource = ds.Tables(0)
        dgvUser.ReadOnly = True
    End Sub

    Sub dgv()
        dgvUser.Columns(0).HeaderText = "ID"
        dgvUser.Columns(1).HeaderText = "Username"
        dgvUser.Columns(2).HeaderText = "Password"
        dgvUser.Columns(3).HeaderText = "Nama"
        dgvUser.Columns(4).HeaderText = "Level"
        dgvUser.Columns("ID").Width = 40
        dgvUser.Columns("username").Width = 60
        dgvUser.Columns("password").Width = 60
        dgvUser.Columns("nama").Width = 130
        dgvUser.Columns("lvl").Width = 100
        dgvUser.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgvUser.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Sub autoincrement()
        Dim id As Integer
        id = 1 + Val(dgvUser.Rows(0).Cells(0).Value)
        txtID.Text = id
    End Sub

    Private Sub frmTambahUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlTambah.Enabled = False
        pnlEdit.Visible = False
        Call tampildata()
        Call dgv()
        Call autoincrement()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        pnlTambah.Enabled = True
        pnlTambah.Visible = True
        pnlEdit.Visible = False
        txtNama.Focus()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim user As String
        user = InputBox("Masukkan username yang akan di Ganti!")
        If user = "" Or user = " " Then
            MessageBox.Show("Masukkan Username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Konek()
            Dim kueri As String
            kueri = "SELECT * FROM tblUser WHERE username = '" & user & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                pnlEdit.Visible = True
                pnlEdit.Enabled = True
                pnlTambah.Enabled = True
                txtIDE.Text = reader.Item("ID")
                txtNamaE.Text = reader.Item("nama")
                txtUsernameE.Text = reader.Item("username")
                txtPasswordE.Text = reader.Item("password")
                cmbLevelE.Text = reader.Item("lvl")
            Else
                MessageBox.Show("Username tidak tersedia!", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim user As String
        user = InputBox("Masukkan username yang akan dihapus")
        If user = "" Or user = " " Then
            MessageBox.Show("Masukkan username!", "Username!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            Call Konek()
            kueri = "SELECT * FROM tblUser WHERE username = '" & user & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Yakin akan dihapus?", "Hapus", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    kueri = "DELETE FROM tblUser WHERE username = '" & user & "'"
                    cmd = New OleDbCommand(kueri, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User berhasil dihapus!")
                    Call tampildata()
                End If
            Else
                MessageBox.Show("Username Tidak ada!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        pnlTambah.Enabled = False
        txtNama.Clear()
        txtPassword.Clear()
        txtUsername.Clear()
        cmbLevel.SelectedIndex = -1
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtNama.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or cmbLevel.Text = "" Then
            MessageBox.Show("Masukkan data dengan Benar!", "ERROR!")
        Else
            Call Konek()
            Dim kuerival
            kuerival = "SELECT * FROM tblUser WHERE username = '" & txtUsername.Text & "'"
            cmd = New OleDbCommand(kuerival, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If Not reader.HasRows Then
                Dim kueri As String
                kueri = "INSERT INTO tblUser VALUES ('" & txtID.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "','" & txtNama.Text & "', '" & cmbLevel.Text & "')"
                cmd = New OleDbCommand(kueri, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input data berhasil", "Sukses")
                txtID.Text = txtID.Text + 1
                Call tampildata()
            Else
                MessageBox.Show("Username Sudah ada", "Error")
            End If
        End If
    End Sub
    
    Private Sub btnCancelE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelE.Click
        txtIDE.Clear()
        txtNamaE.Clear()
        txtPasswordE.Clear()
        txtUsernameE.Clear()
        cmbLevelE.SelectedIndex = -1
        pnlEdit.Enabled = False
        pnlEdit.Visible = False
        pnlTambah.Enabled = False
    End Sub

    Private Sub btnSubmitE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitE.Click
        Dim kueri As String
        If txtNamaE.Text = "" Or txtPasswordE.Text = "" Or txtUsernameE.Text = "" Or cmbLevelE.Text = "" Then
            MessageBox.Show("Isikan semua data!")
        Else
            Call Konek()
            kueri = "UPDATE tblUser SET [username] = '" & txtUsernameE.Text & "',[password] = '" & txtPasswordE.Text & "',[nama] = '" & txtNamaE.Text & "',[lvl] = '" & cmbLevelE.Text & "' WHERE [ID] = " & txtIDE.Text & " "
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User berhasil di Edit!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampildata()
            btnCancelE.PerformClick()
        End If
    End Sub
End Class