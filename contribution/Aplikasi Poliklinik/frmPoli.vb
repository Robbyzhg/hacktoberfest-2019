Imports System.Data.OleDb
Public Class frmPoli

    Private Sub frmPoli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cekdata()
    End Sub

    Private Sub cekdata()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tblpoli"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            conn.Close()
            cmdUpdate.Enabled = False
        Else
            cmdUpdate.Enabled = True
            reader.Close()
            adap = New OleDbDataAdapter(comm)
            tabel = New DataTable
            adap.Fill(tabel)
            bscData.DataSource = tabel
            dgdata.DataSource = bscData
            dgdata.Columns(0).HeaderText = "ID"
            dgdata.Columns(1).HeaderText = "Nama poli"

            dgdata.Columns(0).Width = 75
            dgdata.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        Dim pid As New OleDbParameter("@id", OleDbType.Numeric)
        Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idpoli FROM tblpoli ORDER BY idpoli DESC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            pid.Value = 1
        Else
            reader.Read()
            pid.Value = reader.GetValue(0) + 1
        End If
        conn.Close()

        pnama.Value = InputBox("Masukkan nama Poli", "POLI", "")
        If pnama.Value = "" Then
            Exit Sub
        Else
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "INSERT INTO tblpoli VALUES (@id, @nama)"
            With comm.Parameters
                .Add(pid)
                .Add(pnama)
            End With
            comm.ExecuteScalar()
            conn.Close()
            cekdata()
        End If
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim pid As New OleDbParameter("@id", OleDbType.Numeric)
        Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)
        pid.Value = dgdata.CurrentRow.Cells(0).Value
        pnama.Value = InputBox("Masukkan nama Poli baru", "POLI BARU", dgdata.CurrentRow.Cells(1).Value)
        If pnama.Value = "" Then
            Exit Sub
        Else
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "UPDATE tblpoli SET namapoli = @nama WHERE idpoli = @id"
            With comm.Parameters
                .Add(pnama)
                .Add(pid)
            End With
            comm.ExecuteScalar()
            conn.Close()
            cekdata()
        End If
    End Sub
End Class