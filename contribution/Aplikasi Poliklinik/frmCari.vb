Imports System.Data.OleDb
Public Class frmCari

    Private Sub frmCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        starter()
    End Sub

    Private Sub starter()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tblPasien"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            conn.Close()
        Else
            reader.Close()
            adap = New OleDbDataAdapter(comm)
            tabel = New DataTable
            adap.Fill(tabel)
            bscData.DataSource = tabel
            dgdata.DataSource = bscData
            dgdata.Columns(0).HeaderText = "ID"
            dgdata.Columns(1).HeaderText = "Nama Pasien"
            dgdata.Columns(2).HeaderText = "Alamat Pasien"
            dgdata.Columns(3).HeaderText = "Telp Pasien"
            dgdata.Columns(4).HeaderText = "DOB Pasien"
            dgdata.Columns(5).HeaderText = "Gender"
            dgdata.Columns(6).HeaderText = "Tgl Reg."

            dgdata.Columns(0).Width = 75
            dgdata.Columns(1).Width = 150
            dgdata.Columns(2).Width = 200
            dgdata.Columns(3).Width = 120
            dgdata.Columns(4).Width = 100
            dgdata.Columns(5).Width = 100
            dgdata.Columns(6).Width = 100

            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub dtpDOB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDOB.ValueChanged
        Dim pdob As New OleDbParameter("@dob", OleDbType.Date)
        pdob.Value = dtpDOB.Text
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tblPasien WHERE DOBpas = @dob"
        comm.Parameters.Add(pdob)
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            conn.Close()
            dgdata.Columns.Clear()
        Else
            reader.Close()
            adap = New OleDbDataAdapter(comm)
            tabel = New DataTable
            adap.Fill(tabel)
            bscData.DataSource = tabel
            dgdata.DataSource = bscData
            dgdata.Columns(0).HeaderText = "ID"
            dgdata.Columns(1).HeaderText = "Nama Pasien"
            dgdata.Columns(2).HeaderText = "Alamat Pasien"
            dgdata.Columns(3).HeaderText = "Telp Pasien"
            dgdata.Columns(4).HeaderText = "DOB Pasien"
            dgdata.Columns(5).HeaderText = "Gender"
            dgdata.Columns(6).HeaderText = "Tgl Reg."

            dgdata.Columns(0).Width = 75
            dgdata.Columns(1).Width = 150
            dgdata.Columns(2).Width = 200
            dgdata.Columns(3).Width = 120
            dgdata.Columns(4).Width = 100
            dgdata.Columns(5).Width = 100
            dgdata.Columns(6).Width = 100

            conn.Close()
        End If
        conn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        starter()
    End Sub

    Private Sub dgdata_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdata.CellDoubleClick
        frmRegister.txtID.Text = dgdata.CurrentRow.Cells(0).Value
        frmRegister.caripas()
        Me.Close()
    End Sub
End Class