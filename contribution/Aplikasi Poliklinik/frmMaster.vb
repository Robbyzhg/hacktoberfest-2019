Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class frmMaster

    Private Sub frmMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idlog = 0
        loginin()
    End Sub

    Public Sub loginin()
        If idlog = 0 Then
            mnuLogin.Enabled = True
            mnuLogout.Enabled = False
            mnuChange.Visible = False
            mnuAdmin.Visible = False
            mnuRes.Visible = False
            mnuDok.Visible = False
        Else
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT roleuser FROM tblKaryawan WHERE idkar = " & idlog
            reader = comm.ExecuteReader
            reader.Read()
            If reader.GetValue(0) = "ADMIN" Then
                mnuLogin.Enabled = False
                mnuLogout.Enabled = True
                mnuChange.Visible = True
                mnuAdmin.Visible = True
                mnuRes.Visible = False
                mnuDok.Visible = False
            ElseIf reader.GetValue(0) = "RESEPSIONIS" Then
                mnuLogin.Enabled = False
                mnuLogout.Enabled = True
                mnuChange.Visible = True
                mnuAdmin.Visible = False
                mnuRes.Visible = True
                mnuDok.Visible = False
            ElseIf reader.GetValue(0) = "DOKTER" Then
                mnuLogin.Enabled = False
                mnuLogout.Enabled = True
                mnuChange.Visible = True
                mnuAdmin.Visible = False
                mnuRes.Visible = False
                mnuDok.Visible = True
            End If
            conn.Close()
        End If
    End Sub

    Private Sub mnuLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogout.Click
        idlog = 0
        loginin()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ManajemenDokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenDokterToolStripMenuItem.Click
        frmDokter.MdiParent = Me
        frmDokter.Show()
    End Sub

    Private Sub ManajemenPoliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenPoliToolStripMenuItem.Click
        frmPoli.MdiParent = Me
        frmPoli.Show()
    End Sub

    Private Sub ManajemenJenisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenJenisToolStripMenuItem.Click
        frmJenis.MdiParent = Me
        frmJenis.Show()
    End Sub

    Private Sub ManajemenUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenUserToolStripMenuItem.Click
        frmUserView.MdiParent = Me
        frmUserView.Show()
    End Sub

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        frmPasien.MdiParent = Me
        frmPasien.Show()
    End Sub

    Private Sub mnuLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogin.Click
        frmLogin.ShowDialog()
    End Sub

    Private Sub mnuChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChange.Click
        frmChange.MdiParent = Me
        frmChange.Show()
    End Sub

    Private Sub ManajemenObatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManajemenObatToolStripMenuItem.Click
        frmObat.MdiParent = Me
        frmObat.Show()
    End Sub

    Private Sub DaftarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaftarToolStripMenuItem.Click
        frmRegister.MdiParent = Me
        frmRegister.Show()
    End Sub

    Private Sub DiagnosaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiagnosaToolStripMenuItem.Click
        frmDiagnosa.MdiParent = Me
        frmDiagnosa.Show()
    End Sub
End Class
