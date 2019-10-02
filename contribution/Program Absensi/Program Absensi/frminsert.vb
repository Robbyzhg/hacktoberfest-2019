Imports System.Data.OleDb
Public Class frminsert
    Dim absen As Integer

    Sub tampildata()
        adapter = New OleDbDataAdapter("SELECT * FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "' ORDER BY absen DESC", conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvsiswa.DataSource = ds.Tables(0)
        dgvsiswa.ReadOnly = True

        absen = 1 + Val(dgvsiswa.Rows(0).Cells(0).Value)
        txtabsen.Text = absen
    End Sub

    Private Sub frminsert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()
        cmbkelas.Focus()
    End Sub

    Private Sub cmbkelas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbkelas.SelectedIndexChanged
        If cmbkelas.Text = "" Then
            Exit Sub
            Return
        End If
        Call tampildata()
    End Sub


    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If cmbkelas.Text = "" Then
            MessageBox.Show("Pilih Kelas Terlebih Dahulu!", "Kelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtnama.Text = "" Then
            MessageBox.Show("Masukkan Nama Siswa!", "Nama", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            kueri = "INSERT INTO tblsiswa VALUES (" & txtabsen.Text & ", '" & txtnama.Text & "', '" & cmbkelas.Text & "')"
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Siswa Baru berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            absen = absen + 1
            Call tampildata()
            txtnama.Clear()
        End If
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    
    Private Sub txtnama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtnama.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnsubmit.PerformClick()
        End If
    End Sub
End Class