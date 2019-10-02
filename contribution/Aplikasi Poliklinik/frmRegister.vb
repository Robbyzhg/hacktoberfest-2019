Imports System.Data.OleDb
Public Class frmRegister

    Dim ariddok(), aridjenis() As Double
    Dim idpas As Double
    Dim ubah As Boolean
    Dim norut As Double

    Private Sub frmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isicbodokter()
        isicbojenis()
        starter()
    End Sub

    Private Sub starter()
        txtID.Text = ""
        cboDokter.SelectedIndex = 0
        cboJenis.SelectedIndex = 0
    End Sub

    Private Sub isicbodokter()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT iddok, namadok FROM tbldokter ORDER BY namadok ASC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("Tidak ada data dokter, error dalam loading data register")
            conn.Close()
            Me.Close()
        Else
            Dim i As Integer
            i = -1
            cboDokter.Items.Clear()
            Do While reader.Read
                i = i + 1
                ReDim Preserve ariddok(i)
                ariddok(i) = reader.GetValue(0)
                cboDokter.Items.Add(reader.GetValue(1))
            Loop
        End If
        conn.Close()
    End Sub

    Private Sub isicbojenis()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idJenis, namaJenis FROM tblJenis ORDER BY namaJenis ASC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("Tidak ada Jenis, error dalam loading data Daftar")
            conn.Close()
            Me.Close()
        Else
            Dim i As Integer
            i = -1
            cboJenis.Items.Clear()
            Do While reader.Read
                i = i + 1
                ReDim Preserve aridjenis(i)
                aridjenis(i) = reader.GetValue(0)
                cboJenis.Items.Add(reader.GetValue(1))
            Loop
        End If
        conn.Close()
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        caripas()
    End Sub

    Public Sub caripas()
        If IsNumeric(txtID.Text.Trim) = True Then
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT idPasien, namaPas, alamatpas, telppas FROM tblPasien WHERE idPasien = " & txtID.Text.Trim
            reader = comm.ExecuteReader
            If reader.HasRows = False Then
                txtNama.Text = "NO DATA"
                txtAlamat.Text = "NO DATA"
                txtTelp.Text = "NO DATA"
                txtNama.Enabled = False
                txtAlamat.Enabled = False
                txtTelp.Enabled = False
                cmdConfirm.Enabled = False
            Else
                reader.Read()
                idpas = reader.GetValue(0)
                txtNama.Text = reader.GetValue(1)
                txtAlamat.Text = reader.GetValue(2)
                txtTelp.Text = reader.GetValue(3)
                txtNama.Enabled = True
                txtAlamat.Enabled = True
                txtTelp.Enabled = True
                cmdConfirm.Enabled = True
                ubah = False
            End If
            conn.Close()
        Else
            txtNama.Text = "NO DATA"
            txtAlamat.Text = "NO DATA"
            txtTelp.Text = "NO DATA"
            txtNama.Enabled = False
            txtAlamat.Enabled = False
            txtTelp.Enabled = False
            cmdConfirm.Enabled = False
        End If
    End Sub

    Private Sub cboDokter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDokter.SelectedIndexChanged
        Dim hari As Integer
        Dim cekit As Boolean
        cekit = True
        hari = Now.DayOfWeek
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tbljadwal WHERE idDokter = " & ariddok(cboDokter.SelectedIndex) & " AND hariangka = " & Now.DayOfWeek
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            cmdConfirm.Enabled = False
            lblInfo.Text = "Dokter tidak masuk hari ini"
            cekit = False
        End If
        conn.Close()

        If cekit = True Then
            cmdConfirm.Enabled = True
            cekurut()
        End If
    End Sub

    Private Sub cekurut()
        Dim ptgl As New OleDbParameter("@tgl", OleDbType.Date)
        ptgl.Value = Now.Date()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT nourut FROM tblDaftar WHERE idDokter = " & ariddok(cboDokter.SelectedIndex) & " AND tgldaftar = @tgl ORDER BY nourut DESC"
        comm.Parameters.Add(ptgl)
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            norut = 1
        Else
            reader.Read()
            norut = CDbl(reader.GetValue(0)) + 1
        End If
        conn.Close()
        lblInfo.Text = "nomor urut ke " & norut
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim pidd As New OleDbParameter("@idd", OleDbType.Numeric)
        Dim pidp As New OleDbParameter("@idp", OleDbType.Numeric)
        Dim piddo As New OleDbParameter("@iddo", OleDbType.Numeric)
        Dim pidj As New OleDbParameter("@idj", OleDbType.Numeric)
        Dim pidk As New OleDbParameter("@idk", OleDbType.Numeric)
        Dim pnorut As New OleDbParameter("@norut", OleDbType.Numeric)
        Dim ptgl As New OleDbParameter("@tgl", OleDbType.Date)
        Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)
        Dim palamat As New OleDbParameter("@alamat", OleDbType.VarChar, 255)
        Dim ptelp As New OleDbParameter("@telp", OleDbType.VarChar, 255)

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idDaftar FROM tblDaftar ORDER BY idDaftar DESC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            pidd.Value = 1
        Else
            reader.Read()
            pidd.Value = CDbl(reader.GetValue(0)) + 1
        End If
        conn.Close()

        pidp.Value = idpas
        piddo.Value = ariddok(cboDokter.SelectedIndex)
        pidj.Value = aridjenis(cboJenis.SelectedIndex)
        pidk.Value = idlog
        pnorut.Value = norut
        ptgl.Value = Now.Date

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "INSERT INTO tblDaftar VALUES (@idd, @idp, @iddo, @idj, @idk, @norut, @tgl, 'NOPE')"
        With comm.Parameters
            .Add(pidd)
            .Add(pidp)
            .Add(piddo)
            .Add(pidj)
            .Add(pidk)
            .Add(pnorut)
            .Add(ptgl)
        End With
        comm.ExecuteScalar()

        If ubah = True Then
            comm.CommandText = "UPDATE tblPasien SET namaPas = @nama, alamatPas = @alamat, telpPas = @telp WHERE idPasien = @idp"
            With comm.Parameters
                .Clear()
                .Add(pnama)
                .Add(palamat)
                .Add(ptelp)
                .Add(pidp)
            End With
            comm.ExecuteScalar()
        End If
        conn.Close()
        Me.Close()
    End Sub

    Private Sub llbCari_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbCari.LinkClicked
        frmCari.ShowDialog()
    End Sub

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama.TextChanged
        ubah = True
    End Sub

    Private Sub txtAlamat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlamat.TextChanged
        ubah = True
    End Sub

    Private Sub txtTelp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelp.TextChanged
        ubah = True
    End Sub
End Class
