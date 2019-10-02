Imports System.Data.OleDb

Public Class frmhapus

    Sub kelas()
        Dim kueri As String
        kueri = "SELECT * FROM tblsiswa"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        While reader.Read
            If Not cmbkelas.Items.Contains(reader.Item("kelas")) Then
                cmbkelas.Items.Add(reader.Item("kelas"))
            End If
        End While
    End Sub

    Private Sub frmhapus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        gbxhapus.Enabled = True
        Call Konek()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        gbxhapus.Enabled = False
        cmbkelas.SelectedIndex = -1
        cmbnama.SelectedIndex = -1
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If gbxhapus.Enabled Then
            Call kelas()
        End If
    End Sub

    Private Sub cmbkelas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkelas.SelectedIndexChanged
        cmbnama.Items.Clear()
        If cmbkelas.Text = "" Then
            Exit Sub
        Else
            Dim kueri As String
            kueri = "SELECT * FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                If Not cmbnama.Items.Contains(reader.Item("nama")) Then
                    cmbnama.Items.Add(reader.Item("nama"))
                End If
            End While
        End If
    End Sub

    Private Sub btnaksihapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaksihapus.Click
        If cmbnama.Text = "" Then
            MessageBox.Show("Pilih Nama Siswa Terlebih Dahulu !", "Nama Siswa", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If MessageBox.Show("Yakin ingin di hapus ?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim kueri As String
                kueri = "DELETE FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "' AND nama = '" & cmbnama.Text & "'"
                cmd = New OleDbCommand(kueri, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Siswa Bernama " + cmbnama.Text + " Berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmbnama.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub btnresetabsen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresetabsen.Click
        If MessageBox.Show("Yakin ingin me-reset absen ?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim kueri As String
            kueri = "DELETE FROM tblabsen"
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Absen Berhasil di reset", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnresetsiswa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresetsiswa.Click
        If MessageBox.Show("Yakin ingin me-reset siswa ?", "Yakin?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim kueri As String
            kueri = "DELETE FROM tblsiswa"
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Daftar Siswa berhasil di Reset", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class