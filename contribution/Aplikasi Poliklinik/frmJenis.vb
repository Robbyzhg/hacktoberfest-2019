Imports System.Data.OleDb
Public Class frmJenis
    Dim func As String
    Dim tempharga As Double

    Private Sub frmJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        starter()
    End Sub

    Private Sub starter()
        erperr.Clear()
        tempharga = 0
        txtNama.Visible = False
        txtTelp.Visible = False

        lblNama.Visible = True
        lblTelp.Visible = True

        cmdInsert.Visible = True
        cmdUpdate.Visible = True
        cmdConfirm.Visible = False
        cmdCancel.Visible = False

        cekdata()
    End Sub

    Private Sub cekdata()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT * FROM tblJenis"
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
            dgdata.DataSource = bscData
            dgdata.Columns(0).HeaderText = "ID"
            dgdata.Columns(1).HeaderText = "Merk Jenis"
            dgdata.Columns(2).HeaderText = "Harga"


            dgdata.Columns(0).Width = 75
            dgdata.Columns(1).Width = 150
            dgdata.Columns(2).Width = 120

            conn.Close()
            isilbl()
            onnavi()
        End If
        conn.Close()
    End Sub

    Private Sub nodata()
        cmdUpdate.Enabled = False
        lblID.Text = "NO DATA"
        lblNama.Text = "NO DATA"
        lblTelp.Text = "NO DATA"
    End Sub

    Private Sub isilbl()
        Try
            cmdUpdate.Enabled = True
            lblID.Text = dgdata.CurrentRow.Cells(0).Value
            lblNama.Text = dgdata.CurrentRow.Cells(1).Value
            lblTelp.Text = dgdata.CurrentRow.Cells(2).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub shutnavi()
        dgdata.Enabled = False
        cmdFirst.Enabled = False
        cmdLast.Enabled = False
        cmdprevious.Enabled = False
        cmdNext.Enabled = False
    End Sub

    Private Sub onnavi()
        dgdata.Enabled = True
        cmdFirst.Enabled = True
        cmdLast.Enabled = True
        cmdprevious.Enabled = True
        cmdNext.Enabled = True
    End Sub

    Private Sub dgdata_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdata.CellContentClick
        isilbl()
    End Sub

    Private Sub dgdata_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgdata.SelectionChanged
        isilbl()
    End Sub

    Private Sub cmdFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.Click
        bscData.MoveFirst()
        isilbl()
    End Sub


    Private Sub cmdprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdprevious.Click
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
        txtNama.Visible = True
        txtTelp.Visible = True

        lblNama.Visible = False
        lblTelp.Visible = False

        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True

        txtNama.Text = ""
        txtTelp.Text = 0

        func = "I"

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idJenis FROM tblJenis ORDER BY idJenis DESC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            lblID.Text = "1"
        Else
            reader.Read()
            lblID.Text = reader.GetValue(0) + 1
        End If
        conn.Close()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        txtNama.Visible = True
        txtTelp.Visible = True

        lblNama.Visible = False
        lblTelp.Visible = False

        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True

        txtNama.Text = lblNama.Text
        txtTelp.Text = lblTelp.Text

        func = "U"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        starter()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If validasi() = True Then
            Dim pid As New OleDbParameter("@id", OleDbType.Numeric)
            Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)
            Dim ptelp As New OleDbParameter("@telp", OleDbType.Numeric)

            pid.Value = lblID.Text
            pnama.Value = txtNama.Text.Trim
            ptelp.Value = tempharga

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            If func = "I" Then
                comm.CommandText = "INSERT INTO tblJenis VALUES (@id, @nama, @telp)"
                With comm.Parameters
                    .Add(pid)
                    .Add(pnama)
                    .Add(ptelp)
                End With
            Else
                comm.CommandText = "UPDATE tblJenis SET namajenis = @nama, biaya = @telp WHERE idJenis = @id"
                With comm.Parameters
                    .Add(pnama)
                    .Add(ptelp)
                    .Add(pid)
                End With
            End If
            comm.ExecuteScalar()
            conn.Close()
            starter()
        End If
    End Sub

    Private Function validasi() As Boolean
        Dim cekit As Boolean
        cekit = True
        erperr.Clear()
        If txtNama.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtNama, "Nama perlu diisi")
        End If
        Return cekit
    End Function

    Private Sub txtTelp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelp.TextChanged
        If txtTelp.Text.Trim = "" Then
            tempharga = 0
            txtTelp.Text = tempharga
        Else
            If IsNumeric(txtTelp.Text.Trim) = False Then
                txtTelp.Text = tempharga
            Else
                tempharga = txtTelp.Text.Trim
            End If
        End If
    End Sub
End Class