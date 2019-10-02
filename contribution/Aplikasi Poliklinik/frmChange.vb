Imports System.Data.OleDb
Public Class frmChange
    Dim noid As Double
    Dim passold As String

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        noid = idlog

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tblkaryawan WHERE idkar = " & noid
        reader = comm.ExecuteReader
        reader.Read()
        txtNIP.Text = reader.GetValue(1)
        txtNama.Text = reader.GetValue(2)
        txtTelp.Text = reader.GetValue(4)
        txtAlamat.Text = reader.GetValue(3)
        dtpDOB.Text = reader.GetValue(5)
        cboJK.Text = reader.GetValue(6)
        txtuid.Text = reader.GetValue(7)
        passold = reader.GetValue(8)
        txtpwd1.Text = ""
        txtpwd2.Text = ""
        cborole.Text = reader.GetValue(9)
        conn.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If validasi() = True Then
            Dim pid As New OleDbParameter("@id", OleDbType.Numeric)
            Dim pnip As New OleDbParameter("@nip", OleDbType.VarChar, 255)
            Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)
            Dim palamat As New OleDbParameter("@alamat", OleDbType.VarChar, 255)
            Dim ptelp As New OleDbParameter("@telp", OleDbType.VarChar, 255)
            Dim pdob As New OleDbParameter("@dob", OleDbType.Date)
            Dim pjk As New OleDbParameter("@jk", OleDbType.VarChar, 255)
            Dim puid As New OleDbParameter("@uid", OleDbType.VarChar, 255)
            Dim ppwd As New OleDbParameter("@pwd", OleDbType.VarChar, 255)
            Dim prole As New OleDbParameter("@role", OleDbType.VarChar, 255)

            pid.Value = noid
            pnip.Value = txtNIP.Text
            pnama.Value = txtNama.Text.Trim
            palamat.Value = txtAlamat.Text.Trim
            ptelp.Value = txtTelp.Text.Trim
            pdob.Value = dtpDOB.Text
            pjk.Value = cboJK.Text
            puid.Value = txtuid.Text
            ppwd.Value = txtpwd1.Text
            prole.Value = cborole.Text

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "UPDATE tblKaryawan SET NIP = @nip, namakar = @nama, alamatkar = @alamat, telpkar = @telp, dobkar = @dob, jkkar = @jk, uname = @uid, ppwd = @pwd, roleuser = @role WHERE idkar = @id"
            With comm.Parameters
                .Add(pnip)
                .Add(pnama)
                .Add(palamat)
                .Add(ptelp)
                .Add(pdob)
                .Add(pjk)
                .Add(puid)
                .Add(ppwd)
                .Add(prole)
                .Add(pid)
            End With

            comm.ExecuteScalar()
            conn.Close()
            Me.Close()
        End If
    End Sub

    Private Function validasi() As Boolean
        Dim cekit As Boolean
        cekit = True
        erperr.Clear()
        If txtNIP.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtNIP, "NIP Harus Diisi!")
        End If
        If txtNama.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtNama, "Nama Harus Diisi!")
        End If
        If txtAlamat.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtAlamat, "Alamat Harus Diisi!")
        End If
        If txtTelp.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtTelp, "Telp/HP Harus Diisi!")
        End If
        If txtuid.Text.Trim = "" And cborole.SelectedIndex > 0 Then
            cekit = False
            erperr.SetError(txtuid, "username Harus Diisi!")
        ElseIf txtuid.Text.Trim <> "" And cborole.SelectedIndex > 0 Then
            Dim puid As New OleDbParameter("@uid", OleDbType.VarChar, 255)
            puid.Value = txtuid.Text
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT uname FROM tblKaryawan WHERE uname = @uid AND idkar <> " & noid
            comm.Parameters.Add(puid)
            reader = comm.ExecuteReader
            If reader.HasRows = True Then
                cekit = False
                erperr.SetError(txtuid, "username sudah ada!")
            End If
            conn.Close()
        End If
        If txtoldpwd.Text.Trim = "" And txtpwd1.Text.Trim = "" And txtpwd2.Text.Trim = "" Then
        Else
            If txtoldpwd.Text.Trim <> passold And cborole.SelectedIndex > 0 Then
                cekit = False
                erperr.SetError(txtpwd1, "password Lama salah")
            End If
            If txtpwd1.Text.Trim = "" And cborole.SelectedIndex > 0 Then
                cekit = False
                erperr.SetError(txtpwd1, "password Harus Diisi!")
            End If
            If txtpwd1.Text.Trim <> "" And txtpwd1.Text <> txtpwd2.Text And cborole.SelectedIndex > 0 Then
                cekit = False
                txtpwd1.Text = ""
                txtpwd2.Text = ""
                erperr.SetError(txtpwd2, "password Harus sama!")
            End If
        End If

        Return cekit
    End Function

    Private Sub cborole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cborole.SelectedIndexChanged
        testcbo()
    End Sub

    Private Sub testcbo()
        If cborole.SelectedIndex = 0 Then
            txtuid.Enabled = False
            txtoldpwd.Enabled = False
            txtpwd1.Enabled = False
            txtpwd2.Enabled = False
            txtuid.Text = ""
            txtoldpwd.Text = ""
            txtpwd1.Text = ""
            txtpwd2.Text = ""
        Else
            txtuid.Enabled = True
            txtoldpwd.Enabled = True
            txtpwd1.Enabled = True
            txtpwd2.Enabled = True
        End If
    End Sub
End Class