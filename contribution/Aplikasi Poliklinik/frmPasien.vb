Imports System.Data.OleDb
Public Class frmPasien
    Dim func As String
    Private Sub frmPasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        starter()
    End Sub

    Private Sub starter()
        erperr.Clear()
        txtNama.Visible = False
        txtAlamat.Visible = False
        txtTelp.Visible = False
        dtpdob.Visible = False
        cbojk.Visible = False

        lblNama.Visible = True
        lblAlamat.Visible = True
        lblTelp.Visible = True
        lblDOB.Visible = True
        lblJK.Visible = True

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
        comm.CommandText = "SELECT * FROM tblPasien"
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
            isilbl()
            onnavi()
        End If
        conn.Close()
    End Sub

    Private Sub nodata()
        cmdUpdate.Enabled = False
        lblID.Text = "NO DATA"
        lblNama.Text = "NO DATA"
        lblAlamat.Text = "NO DATA"
        lblTelp.Text = "NO DATA"
        lblDOB.Text = "NO DATA"
        lblJK.Text = "NO DATA"
        lblReg.Text = ""
    End Sub

    Private Sub isilbl()
        Try
            cmdUpdate.Enabled = True
            lblID.Text = dgdata.CurrentRow.Cells(0).Value
            lblNama.Text = dgdata.CurrentRow.Cells(1).Value
            lblAlamat.Text = dgdata.CurrentRow.Cells(2).Value
            lblTelp.Text = dgdata.CurrentRow.Cells(3).Value
            lblDOB.Text = dgdata.CurrentRow.Cells(4).FormattedValue
            lblJK.Text = dgdata.CurrentRow.Cells(5).Value
            lblReg.Text = "Register : " & dgdata.CurrentRow.Cells(6).Value
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
        txtAlamat.Visible = True
        txtTelp.Visible = True
        dtpdob.Visible = True
        cbojk.Visible = True

        lblNama.Visible = False
        lblAlamat.Visible = False
        lblTelp.Visible = False
        lblDOB.Visible = False
        lblJK.Visible = False

        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True

        lblReg.Text = ""
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        cbojk.SelectedIndex = 0

        func = "I"

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idPasien FROM tblPasien ORDER BY idPasien DESC"
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
        txtAlamat.Visible = True
        txtTelp.Visible = True
        dtpdob.Visible = True
        cbojk.Visible = True

        lblNama.Visible = False
        lblAlamat.Visible = False
        lblTelp.Visible = False
        lblDOB.Visible = False
        lblJK.Visible = False

        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True

        txtNama.Text = lblNama.Text
        txtAlamat.Text = lblAlamat.Text
        txtTelp.Text = lblTelp.Text
        dtpdob.Text = lblDOB.Text
        cbojk.Text = lblJK.Text

        func = "U"
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        starter()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If validasi() = True Then
            Dim pid As New OleDbParameter("@id", OleDbType.Numeric)
            Dim pnama As New OleDbParameter("@nama", OleDbType.VarChar, 255)
            Dim palamat As New OleDbParameter("@alamat", OleDbType.VarChar, 255)
            Dim ptelp As New OleDbParameter("@telp", OleDbType.VarChar, 255)
            Dim pdob As New OleDbParameter("@dob", OleDbType.Date)
            Dim pjk As New OleDbParameter("@jk", OleDbType.VarChar, 255)
            Dim ptgl As New OleDbParameter("@tgl", OleDbType.Date)

            pid.Value = lblID.Text
            pnama.Value = txtNama.Text.Trim
            palamat.Value = txtAlamat.Text.Trim
            ptelp.Value = txtTelp.Text.Trim
            pdob.Value = dtpdob.Text
            pjk.Value = cbojk.Text
            ptgl.Value = Now.Date

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            If func = "I" Then
                comm.CommandText = "INSERT INTO tblPasien VALUES (@id, @nama, @alamat, @telp, @dob, @jk, @tgl)"
                With comm.Parameters
                    .Add(pid)
                    .Add(pnama)
                    .Add(palamat)
                    .Add(ptelp)
                    .Add(pdob)
                    .Add(pjk)
                    .Add(ptgl)
                End With
            Else
                comm.CommandText = "UPDATE tblPasien SET namapas = @nama, alamatpas = @alamat, telppas = @telp, dobpas =@dob, jkpas = @jk WHERE idpasien = @id"
                With comm.Parameters
                    .Add(pnama)
                    .Add(palamat)
                    .Add(ptelp)
                    .Add(pdob)
                    .Add(pjk)
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

        If txtAlamat.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtAlamat, "Alamat perlu diisi")
        End If

        If txtTelp.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtTelp, "Telp perlu diisi")
        End If
        Return cekit
    End Function
End Class