Imports System.Data.OleDb

Public Class frmtambah
    Public id As Integer

    Sub tampiluser()
        Dim kueri As String
        kueri = "SELECT * FROM tbluser ORDER BY ID DESC"
        adapter = New OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvuser.DataSource = ds.Tables(0)
        dgvuser.ReadOnly = True
    End Sub

    Sub nomor()
        id = 1 + Val(dgvuser.Rows(0).Cells(0).Value)
    End Sub

    Private Sub frmtambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()
        Call tampiluser()
        Call nomor()

        txtid.Text = id

        gbxtambah.Enabled = False
        gbxedit.Enabled = False
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        gbxtambah.Enabled = True
        gbxedit.Enabled = False
    End Sub

    Private Sub btnedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedit.Click
        gbxtambah.Enabled = False
        gbxedit.Enabled = True

        Dim input, kueri As String
        input = InputBox("Masukkan username yang akan di edit")

        If input = "" Or input = " " Then
            MessageBox.Show("Masukkan username!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            gbxedit.Enabled = False
        Else
            kueri = "SELECT * FROM tbluser WHERE username = '" & input & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                txtid2.Text = reader.Item("ID")
                txtusername2.Text = reader.Item("username")
                txtpassword2.Text = reader.Item("password")
                cmblevel2.Text = reader.Item("lvl")
            Else
                MessageBox.Show("Username tidak ada!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                gbxedit.Enabled = False
            End If
        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        gbxtambah.Enabled = False
        cmblevel.SelectedIndex = -1
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtid.Text = "" Or txtusername.Text = "" Or txtpassword.Text = "" Or cmblevel.Text = "" Then
            MessageBox.Show("Isi Semua Data!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim kueri As String
        kueri = "SELECT * FROM tbluser WHERE username = '" & txtusername.Text & "'"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            kueri = "INSERT INTO tbluser VALUES (" & id & ", '" & txtusername.Text & "', '" & txtpassword.Text & "', '" & cmblevel.Text & "')"
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User dengan username " + txtusername.Text + " Berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call tampiluser()
            txtid.Text = txtid.Text + 1
            txtusername.Clear()
            txtpassword.Clear()
            cmblevel.SelectedIndex = -1
        Else
            MessageBox.Show("Username sudah ada!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Dim input As String
        input = InputBox("Masukkan Username yang akan dihapus!")
        If input = "" Or input = " " Then
            MessageBox.Show("Masukkan Username!", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            kueri = "SELECT * FROM tbluser WHERE username = '" & input & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                If MessageBox.Show("Apakah user " + input + " Akan dihapus ?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    kueri = "DELETE FROM tbluser WHERE username = '" & input & "'"
                    cmd = New OleDbCommand(kueri, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Call tampiluser()
                Else
                    Exit Sub
                End If
            Else
                MessageBox.Show("User tidak ada!", "User tidak ada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btncancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel2.Click
        gbxedit.Enabled = False
        txtid2.Clear()
        txtusername2.Clear()
        txtpassword2.Clear()
        cmblevel2.SelectedIndex = -1
    End Sub

    Private Sub btnsubmit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit2.Click
        If txtusername2.Text = "" Or txtpassword2.Text = "" Or cmblevel2.Text = "" Then
            MessageBox.Show("Isikan Semua Data!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            kueri = "UPDATE tbluser SET [username] = '" & txtusername2.Text & "', [password] = '" & txtpassword2.Text & "', [lvl] = '" & cmblevel2.Text & "' WHERE id = " & txtid2.Text & ""
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("User berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btncancel2.PerformClick()
            Call tampiluser()
        End If
    End Sub
End Class