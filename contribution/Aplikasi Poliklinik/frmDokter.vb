Imports System.Data.OleDb
Public Class frmDokter
    Dim func As String
    Dim aridpoli() As Double
    Dim idjadwal As Double
    Dim jumjad As Double
    Dim arhari(), arjam1(), arjam2(), arhari2() As String

    Private Sub frmDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isicbopoli()
        starter()
    End Sub
    Private Sub isicbopoli()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idpoli, namaPoli FROM tblPoli ORDER BY idpoli ASC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("Tidak ada data poli, error dalam loading data register")
            conn.Close()
            Me.Close()
        Else
            Dim i As Integer
            i = -1
            cbojk.Items.Clear()
            Do While reader.Read
                i = i + 1
                ReDim Preserve aridpoli(i)
                aridpoli(i) = reader.GetValue(0)
                cbojk.Items.Add(reader.GetValue(1))
            Loop
        End If
        conn.Close()
        cbojk.SelectedIndex = 0
    End Sub

    Private Sub starter()
        erperr.Clear()
        txtNama.Visible = False
        txtAlamat.Visible = False
        txtTelp.Visible = False
        llbAddPoli.Visible = False
        cbojk.Visible = False

        lblNama.Visible = True
        lblAlamat.Visible = True
        lblTelp.Visible = True

        lblJK.Visible = True
        grbjadwal.Enabled = False
        cmdInsert.Visible = True
        cmdUpdate.Visible = True
        cmdConfirm.Visible = False
        cmdCancel.Visible = False

        dgJadwal.Visible = True
        dgjadwal2.Visible = False
        cekdata()
    End Sub

    Private Sub cekdata()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT tblDokter.iddok, tblDokter.namadok, tblDokter.alamatdok, tblDokter.telpdok, tblPoli.namaPoli  FROM tblDokter, tblPoli WHERE tblDokter.polidok = tblPoli.idPoli"
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
            dgdata.Columns(1).HeaderText = "Nama Dokter"
            dgdata.Columns(2).HeaderText = "Alamat Dokter"
            dgdata.Columns(3).HeaderText = "Telp Dokter"
            dgdata.Columns(4).HeaderText = "Poli Dokter"


            dgdata.Columns(0).Width = 75
            dgdata.Columns(1).Width = 150
            dgdata.Columns(2).Width = 200
            dgdata.Columns(3).Width = 120
            dgdata.Columns(4).Width = 100
            

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

        lblJK.Text = "NO DATA"

    End Sub

    Private Sub isilbl()
        Try
            cmdUpdate.Enabled = True
            lblID.Text = dgdata.CurrentRow.Cells(0).Value
            lblNama.Text = dgdata.CurrentRow.Cells(1).Value
            lblAlamat.Text = dgdata.CurrentRow.Cells(2).Value
            lblTelp.Text = dgdata.CurrentRow.Cells(3).Value

            lblJK.Text = dgdata.CurrentRow.Cells(4).Value
            isidgjadwal()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub isidgjadwal()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        Try
            comm.CommandText = "SELECT hari, jammulai, jamselesai, idjadwal FROM tblJadwal WHERE tblJadwal.iddokter = " & dgdata.CurrentRow.Cells(0).Value
        Catch ex As Exception
            comm.CommandText = "SELECT hari, jammulai, jamselesai, idjadwal FROM tblJadwal"
        End Try

        adap = New OleDbDataAdapter(comm)
        tabel = New DataTable
        adap.Fill(tabel)
        bscJadwal.DataSource = tabel
        dgJadwal.DataSource = bscJadwal
        dgJadwal.Columns(0).HeaderText = "Hari"
        dgJadwal.Columns(1).HeaderText = "Jam Mulai"
        dgJadwal.Columns(2).HeaderText = "Jam Selesai"
        dgJadwal.Columns(3).HeaderText = ""



        dgJadwal.Columns(0).Width = 150
        dgJadwal.Columns(1).Width = 75
        dgJadwal.Columns(2).Width = 75
        dgJadwal.Columns(3).Width = 0



        conn.Close()
        isilbljadwal()

    End Sub
    Private Sub isilbljadwal()
        Try
            cbohari.Text = dgJadwal.CurrentRow.Cells(0).Value
            cbojam1.Text = dgJadwal.CurrentRow.Cells(1).Value
            cbojam2.Text = dgJadwal.CurrentRow.Cells(2).Value
            idjadwal = dgJadwal.CurrentRow.Cells(3).Value
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

        cbojk.Visible = True
        llbAddPoli.Visible = True
        lblNama.Visible = False
        lblAlamat.Visible = False
        lblTelp.Visible = False

        lblJK.Visible = False
        grbjadwal.Enabled = True
        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True


        txtNama.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        cbojk.SelectedIndex = 0

        func = "I"

        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT iddok FROM tblDokter ORDER BY iddok DESC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            lblID.Text = "1"
        Else
            reader.Read()
            lblID.Text = reader.GetValue(0) + 1
        End If
        conn.Close()
        cbohari.SelectedIndex = 0
        cbojam1.SelectedIndex = 0
        cbojam2.SelectedIndex = 0
        jumjad = -1
        dgjadwal2.Rows.Clear()

        dgJadwal.Visible = False
        dgjadwal2.Visible = True
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        txtNama.Visible = True
        txtAlamat.Visible = True
        txtTelp.Visible = True
        llbAddPoli.Visible = True
        cbojk.Visible = True

        lblNama.Visible = False
        lblAlamat.Visible = False
        lblTelp.Visible = False

        lblJK.Visible = False
        grbjadwal.Enabled = True
        cmdInsert.Visible = False
        cmdUpdate.Visible = False
        cmdConfirm.Visible = True
        cmdCancel.Visible = True

        txtNama.Text = lblNama.Text
        txtAlamat.Text = lblAlamat.Text
        txtTelp.Text = lblTelp.Text

        cbojk.Text = lblJK.Text

        dgJadwal.Visible = False
        dgjadwal2.Visible = True

        jumjad = -1
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        Try
            comm.CommandText = "SELECT hari, jammulai, jamselesai, idjadwal FROM tblJadwal WHERE tblJadwal.iddokter = " & dgdata.CurrentRow.Cells(0).Value
        Catch ex As Exception
            comm.CommandText = "SELECT hari, jammulai, jamselesai, idjadwal FROM tblJadwal"
        End Try

        reader = comm.ExecuteReader
        Do While reader.Read
            jumjad = jumjad + 1
            ReDim Preserve arhari(jumjad)
            ReDim Preserve arjam1(jumjad)
            ReDim Preserve arjam2(jumjad)
            ReDim Preserve arhari2(jumjad)
            arhari(jumjad) = reader.GetValue(0)
            arjam1(jumjad) = reader.GetValue(1)
            arjam2(jumjad) = reader.GetValue(2)
            arhari2(jumjad) = reader.GetValue(3)
        Loop
        setdgjadwal()

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

            Dim pjk As New OleDbParameter("@jk", OleDbType.Numeric)
            
            pid.Value = lblID.Text
            pnama.Value = txtNama.Text.Trim
            palamat.Value = txtAlamat.Text.Trim
            ptelp.Value = txtTelp.Text.Trim

            pjk.Value = aridpoli(cbojk.SelectedIndex)


            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            If func = "I" Then
                comm.CommandText = "INSERT INTO tblDokter VALUES (@id, @nama, @alamat, @telp,@jk)"
                With comm.Parameters
                    .Add(pid)
                    .Add(pnama)
                    .Add(palamat)
                    .Add(ptelp)
                    .Add(pjk)

                End With
            Else
                comm.CommandText = "UPDATE tblDokter SET namadok = @nama, alamatdok = @alamat, telpdok = @telp, polidok = @jk WHERE idDok = @id"
                With comm.Parameters
                    .Add(pnama)
                    .Add(palamat)
                    .Add(ptelp)
                    .Add(pjk)
                    .Add(pid)
                End With
            End If
            comm.ExecuteScalar()
            comm.CommandText = "DELETE FROM tblJadwal WHERE iddokter = @id"
            comm.Parameters.Clear()
            comm.Parameters.Add(pid)
            comm.ExecuteScalar()
            Dim pidj As New OleDbParameter("@idj", OleDbType.Numeric)
            Dim phari1 As New OleDbParameter("@hari1", OleDbType.VarChar, 255)
            Dim phari2 As New OleDbParameter("@hari2", OleDbType.Numeric)
            Dim pjam1 As New OleDbParameter("@jam1", OleDbType.Numeric)
            Dim pjam2 As New OleDbParameter("@jam2", OleDbType.Numeric)
            Dim i As Double
            For i = 0 To jumjad
                comm.CommandText = "SELECT idjadwal from tblJadwal ORDER BY idjadwal DESC"
                reader = comm.ExecuteReader
                If reader.HasRows = False Then
                    pidj.Value = 1
                Else
                    reader.Read()
                    pidj.Value = CDbl(reader.GetValue(0) + 1)
                End If
                reader.Close()
                phari1.Value = arhari(i)
                phari2.Value = arhari2(i)
                pjam1.Value = arjam1(i)
                pjam2.Value = arjam2(i)

                comm.CommandText = "INSERT INTO tblJadwal VALUES(@idj, @id, @hari1, @hari2, @jam1, @jam2 )"
                With comm.Parameters
                    .Clear()
                    .Add(pidj)
                    .Add(pid)
                    .Add(phari1)
                    .Add(phari2)
                    .Add(pjam1)
                    .Add(pjam2)
                End With
                comm.ExecuteScalar()
            Next
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
        If jumjad <= -1 Then
            cekit = False
            erperr.SetError(cbohari, "minimal satu jadwal")
        End If
       
        Return cekit
    End Function


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If cbojam1.SelectedIndex >= cbojam2.SelectedIndex Then
            erperr.SetError(cbojam2, "Salah Jadwal")
        Else

            jumjad = jumjad + 1
            ReDim Preserve arhari(jumjad)
            ReDim Preserve arjam1(jumjad)
            ReDim Preserve arjam2(jumjad)
            ReDim Preserve arhari2(jumjad)
            arhari(jumjad) = cbohari.Text
            arjam1(jumjad) = cbojam1.Text
            arjam2(jumjad) = cbojam2.Text
            arhari2(jumjad) = cbohari.SelectedIndex
            setdgjadwal()
        End If
    End Sub

    Private Sub setdgjadwal()
        If jumjad = -1 Then
            dgjadwal2.Rows.Clear()
        Else

            dgjadwal2.Rows.Clear()

            Dim i As Double
            Dim row As String()

            For i = 0 To jumjad
                row = New String() {arhari(i), arjam1(i), arjam2(i), i}
                dgjadwal2.Rows.Add(row)
            Next
        End If
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        Dim i As Double
        For i = dgjadwal2.CurrentRow.Cells(3).Value To jumjad - 1
            arhari(i) = arhari(i + 1)
            arjam1(i) = arjam1(i + 1)
            arjam2(i) = arjam2(i + 1)
            arhari2(i) = arhari2(i + 1)

        Next
        jumjad = jumjad - 1
        ReDim Preserve arhari(jumjad)
        ReDim Preserve arjam1(jumjad)
        ReDim Preserve arjam2(jumjad)
        ReDim Preserve arhari2(jumjad)

        setdgjadwal()
    End Sub

    Private Sub dgjadwal2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgjadwal2.CellContentClick
        isilbljadwal()
    End Sub

    Private Sub dgjadwal2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgjadwal2.SelectionChanged
        isilbljadwal()
    End Sub
End Class
 