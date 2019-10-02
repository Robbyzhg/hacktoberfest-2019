Imports System.Data.OleDb
Public Class frmDiagnosa
    Dim ariddok() As Double

    Dim tempb, temps, tempd As Double

    Dim arobatid(), arobatnama(), arobatdosis(), arobatjumlah(), arobatharga() As String
    Dim total As Double
    Public obatidsend, obatnamasend, obatdosissend, obatjumlahsend, obathargasend As String
    Dim jumbat As Double

    Private Sub frmDiagnosa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempb = 0
        temps = 0
        tempd = 0
        isicbodokter()
        setdg()
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
        cboDokter.SelectedIndex = 0
    End Sub

    Private Sub setdg()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT tbldaftar.idDaftar, tblpasien.namapas FROM tbldaftar, tblpasien WHERE tblDaftar.idPasien = tblPasien.idPasien AND tblDaftar.status = 'NOPE' AND idDokter = " & ariddok(cboDokter.SelectedIndex) & " ORDER BY nourut ASC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("Tidak ada registrasi")
            Panel4.Enabled = False
            dgData.Columns.Clear()
        Else
            Panel4.Enabled = True
            reader.Close()
            adap = New OleDbDataAdapter(comm)
            tabel = New DataTable
            adap.Fill(tabel)
            bscData.DataSource = tabel
            dgData.DataSource = bscData

            dgData.Columns(0).HeaderText = "No"
            dgData.Columns(1).HeaderText = "Nama Pasien"

            dgdata.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
        conn.Close()
    End Sub

    Private Sub dgData_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgData.SelectionChanged
        Reset()
    End Sub

    Private Sub reset()
        txtBerat.Text = 0
        txtsis.Text = 0
        txtdias.Text = 0
        txtKelu.Text = ""
        txtDiag.Text = ""
        txtPera.Text = ""
        txtTind.Text = ""
        jumbat = -1
        ReDim arobatid(0)
        ReDim arobatnama(0)
        ReDim arobatdosis(0)
        ReDim arobatjumlah(0)
        ReDim arobatharga(0)
        lblHarga.Text = ""
        dgObat.Rows.Clear()
    End Sub

    Private Sub txtBerat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBerat.TextChanged
        If txtBerat.Text.Trim = "" Then
            tempb = 0
        Else
            If IsNumeric(txtBerat.Text.Trim) = False Then
                txtBerat.Text = tempb
            Else
                tempb = txtBerat.Text
            End If
        End If
    End Sub

    Private Sub txtsis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsis.TextChanged
        If txtsis.Text.Trim = "" Then
            temps = 0
        Else
            If IsNumeric(txtsis.Text.Trim) = False Then
                txtsis.Text = temps
            Else
                temps = txtsis.Text
            End If
        End If
    End Sub

    Private Sub txtdias_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdias.TextChanged
        If txtdias.Text.Trim = "" Then
            tempd = 0
        Else
            If IsNumeric(txtdias.Text.Trim) = False Then
                txtdias.Text = tempd
            Else
                tempd = txtdias.Text
            End If
        End If
    End Sub

    Public Sub setar()
        Dim cekit As Boolean
        cekit = True
        If jumbat > -1 Then
            Dim i As Double
            For i = 0 To jumbat
                If arobatid(i) = obatidsend Then
                    arobatdosis(i) = obatdosissend
                    arobatjumlah(i) = CDbl(arobatjumlah(i)) + CDbl(obatjumlahsend)
                    cekit = False
                    Exit For
                End If
            Next
        End If
        If cekit = True Then
            jumbat = jumbat + 1
            ReDim Preserve arobatid(jumbat)
            ReDim Preserve arobatnama(jumbat)
            ReDim Preserve arobatdosis(jumbat)
            ReDim Preserve arobatjumlah(jumbat)
            ReDim Preserve arobatharga(jumbat)

            arobatid(jumbat) = obatidsend
            arobatnama(jumbat) = obatnamasend
            arobatdosis(jumbat) = obatdosissend
            arobatjumlah(jumbat) = obatjumlahsend
            arobatharga(jumbat) = obathargasend
        End If
        setdgobat()
    End Sub

    Private Sub setdgobat()
        If jumbat = -1 Then
            dgObat.Rows.Clear()
        Else
            dgObat.Rows.Clear()
            Dim i As Double
            Dim row As String()
            total = 0
            For i = 0 To jumbat
                row = New String() {arobatid(i), arobatnama(i), arobatdosis(i), arobatjumlah(i)}
                dgObat.Rows.Add(row)
                total = total + (CDbl(arobatjumlah(i)) * CDbl(arobatharga(i)))
                lblHarga.Text = FormatNumber(total, 0)
            Next
        End If
    End Sub

    Private Sub cboDokter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDokter.SelectedIndexChanged
        setdg()
    End Sub

    Private Sub cmdAddObat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddObat.Click
        frmCariObat.ShowDialog()
    End Sub

    Private Sub cmdRemoveobat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveobat.Click
        Dim i, j As Double
        For i = 0 To jumbat
            If arobatid(i) = dgObat.CurrentRow.Cells(0).Value Then
                Exit For
            End If
        Next
        For j = i To jumbat - 1
            arobatid(i) = arobatid(i + 1)
            arobatnama(i) = arobatnama(i + 1)
            arobatdosis(i) = arobatdosis(i + 1)
            arobatjumlah(i) = arobatjumlah(i + 1)
            arobatharga(i) = arobatharga(i + 1)
        Next
        jumbat = jumbat - 1
        ReDim Preserve arobatid(jumbat)
        ReDim Preserve arobatnama(jumbat)
        ReDim Preserve arobatdosis(jumbat)
        ReDim Preserve arobatjumlah(jumbat)
        ReDim Preserve arobatharga(jumbat)
        setdgobat()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        If validasi() = True Then
            Dim piddi As New OleDbParameter("@iddi", OleDbType.Numeric)
            Dim pidda As New OleDbParameter("@idda", OleDbType.Numeric)
            Dim piddr As New OleDbParameter("@iddr", OleDbType.Numeric)
            Dim piddo As New OleDbParameter("@iddo", OleDbType.Numeric)
            Dim pkelu As New OleDbParameter("@kelu", OleDbType.VarChar, 255)
            Dim pdiag As New OleDbParameter("@diag", OleDbType.VarChar, 255)
            Dim ppera As New OleDbParameter("@pera", OleDbType.VarChar, 255)
            Dim ptind As New OleDbParameter("@tind", OleDbType.VarChar, 255)
            Dim pberat As New OleDbParameter("@berat", OleDbType.Numeric)
            Dim psis As New OleDbParameter("@sis", OleDbType.Numeric)
            Dim pdias As New OleDbParameter("@dias", OleDbType.Numeric)
            Dim ptotal As New OleDbParameter("@total", OleDbType.Numeric)
            Dim pdosis As New OleDbParameter("@dosis", OleDbType.VarChar, 255)
            Dim pjumlah As New OleDbParameter("@jumlah", OleDbType.Numeric)

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT iddiagnosa FROM tbldiagnosa ORDER BY iddiagnosa DESC"
            reader = comm.ExecuteReader
            If reader.HasRows = False Then
                piddi.Value = 1
            Else
                reader.Read()
                piddi.Value = CDbl(reader.GetValue(0)) + 1
            End If
            conn.Close()

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT idresep FROM tblresep ORDER BY idresep DESC"
            reader = comm.ExecuteReader
            If reader.HasRows = False Then
                piddr.Value = 1
            Else
                reader.Read()
                piddr.Value = CDbl(reader.GetValue(0)) + 1
            End If
            conn.Close()

            pidda.Value = dgData.CurrentRow.Cells(0).Value
            pkelu.Value = txtKelu.Text.Trim
            pdiag.Value = txtDiag.Text.Trim
            ppera.Value = txtPera.Text.Trim
            ptind.Value = txtTind.Text.Trim
            pberat.Value = tempb
            psis.Value = temps
            pdias.Value = tempd

            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "INSERT INTO tblDiagnosa VALUES(@iddi, @idda, @kelu, @diag, @pera, @tind, @berat, @sis, @dias)"
            With comm.Parameters
                .Add(piddi)
                .Add(pidda)
                .Add(pkelu)
                .Add(pdiag)
                .Add(ppera)
                .Add(ptind)
                .Add(pberat)
                .Add(psis)
                .Add(pdias)
            End With
            comm.ExecuteScalar()

            comm.CommandText = "UPDATE tblDaftar SET status = 'OK' WHERE idDaftar = @idda"
            comm.Parameters.Clear()
            comm.Parameters.Add(pidda)
            comm.ExecuteScalar()

            If jumbat > -1 Then
                ptotal.Value = total
                comm.CommandText = "INSERT INTO tblResep VALUES (@iddr, @iddi, @total)"
                With comm.Parameters
                    .Clear()
                    .Add(piddr)
                    .Add(piddi)
                    .Add(ptotal)
                End With
                comm.ExecuteScalar()

                Dim i As Double
                For i = 0 To jumbat
                    piddo.Value = arobatid(i)
                    pdosis.Value = arobatdosis(i)
                    pjumlah.Value = arobatjumlah(i)
                    comm.CommandText = "INSERT INTO tblDetailResep VALUES (@iddr, @iddo, @dosis, @jumlah)"
                    With comm.Parameters
                        .Clear()
                        .Add(piddr)
                        .Add(piddo)
                        .Add(pdosis)
                        .Add(pjumlah)
                    End With
                    comm.ExecuteScalar()
                Next
            End If

            conn.Close()
            setdg()
        End If
    End Sub

    Private Function validasi() As Boolean
        Dim cekit As Boolean
        cekit = True
        erperr.Clear()
        If txtKelu.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtKelu, "Keluhan harus diisi")
        End If
        If txtDiag.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtDiag, "Diagnosa harus diisi")
        End If
        If txtPera.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtPera, "Perawatan harus diisi")
        End If
        If txtTind.Text.Trim = "" Then
            cekit = False
            erperr.SetError(txtTind, "Tindakan harus diisi")
        End If
        Return cekit
    End Function
End Class
