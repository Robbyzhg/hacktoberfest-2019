Imports System.Data.OleDb
Public Class frmUserView

    Private Sub frmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        starter()
    End Sub

    Private Sub starter()
        cekdata()
    End Sub

    Public Sub cekdata()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT NIP, namaKar, alamatKar, telpKar, dobKar, JKKar, roleuser, idKar FROM tblkaryawan"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            conn.Close()
            nodata()
            shutnavi()
        Else
            reader.Close()
            adap = New OleDbDataAdapter(comm)
            tabel = New DataTable
            adap.Fill(tabel)
            bscData.DataSource = tabel
            dgData.DataSource = bscData

            dgData.Columns(0).HeaderText = "NIP"
            dgData.Columns(1).HeaderText = "Nama"
            dgData.Columns(2).HeaderText = "Alamat"
            dgData.Columns(3).HeaderText = "Telp/HP"
            dgData.Columns(4).HeaderText = "DOB"
            dgData.Columns(5).HeaderText = "Gender"
            dgData.Columns(6).HeaderText = "Role User"


            dgData.Columns(0).Width = 70
            dgData.Columns(1).Width = 120
            dgData.Columns(2).Width = 200
            dgData.Columns(3).Width = 100
            dgData.Columns(4).Width = 100
            dgData.Columns(5).Width = 70
            dgData.Columns(6).Width = 100
            dgData.Columns(7).Width = 0

            conn.Close()
            isilbl()
            onnavi()
        End If
    End Sub

    Private Sub nodata()
        cmdUpdate.Enabled = False
        lblID.Text = "NO DATA"
        lblNama.Text = "NO DATA"
        lblAlamat.Text = "NO DATA"
        lblTelp.Text = "NO DATA"
        lblDOB.Text = "NO DATA"
        lblJK.Text = "NO DATA"
        lblRole.Text = "NO DATA"
    End Sub

    Private Sub isilbl()
        Try
            cmdUpdate.Enabled = True
            lblID.Text = dgData.CurrentRow.Cells(0).Value
            lblNama.Text = dgData.CurrentRow.Cells(1).Value
            lblAlamat.Text = dgData.CurrentRow.Cells(2).Value
            lblTelp.Text = dgData.CurrentRow.Cells(3).Value
            lblDOB.Text = dgData.CurrentRow.Cells(4).FormattedValue
            lblJK.Text = dgData.CurrentRow.Cells(5).Value
            lblRole.Text = dgData.CurrentRow.Cells(6).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub shutnavi()
        dgData.Enabled = False
        cmdFirst.Enabled = False
        cmdLast.Enabled = False
        cmdPrevious.Enabled = False
        cmdNext.Enabled = False
    End Sub

    Private Sub onnavi()
        dgData.Enabled = True
        cmdFirst.Enabled = True
        cmdLast.Enabled = True
        cmdPrevious.Enabled = True
        cmdNext.Enabled = True
    End Sub

    Private Sub dgData_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgData.CellContentClick
        isilbl()
    End Sub

    Private Sub dgData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgData.SelectionChanged
        isilbl()
    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        bscData.MoveFirst()
        isilbl()
    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        bscData.MovePrevious()
        isilbl()
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        bscData.MoveNext()
        isilbl()
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        bscData.MoveLast()
        isilbl()
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        frmUserAdd.ShowDialog()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        iduser = dgData.CurrentRow.Cells(7).Value
        frmUserEdit.ShowDialog()
    End Sub

    
End Class
