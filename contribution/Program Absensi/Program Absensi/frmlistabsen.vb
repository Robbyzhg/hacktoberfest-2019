Imports System.Data.OleDb

Public Class frmlistabsen

    Private Sub frmlistabsen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()

        'Menampilkan List Kelas yang Ada
        Dim kueri As String
        kueri = "SELECT * FROM tblsiswa"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        While reader.Read
            If Not cmbkelas.Items.Contains(reader.Item("kelas")) Then
                cmbkelas.Items.Add(reader.Item("kelas"))
            End If
        End While
    End Sub

    Private Sub cmbformat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbformat.SelectedIndexChanged
        If cmbkelas.Text = "" Then
            MessageBox.Show("Pilih Kelas terlebih Dahulu!", "Pilih Kelas!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cmbformat.SelectedIndex = 0 Then
            lbltanggal.Visible = False
            cmbtanggal.Visible = False
            lblbulan.Visible = False
            cmbbulan.Visible = False
            lbltahun.Visible = True
            cmbtahun.Visible = True
        ElseIf cmbformat.SelectedIndex = 1 Then
            lbltanggal.Visible = False
            cmbtanggal.Visible = False
            lblbulan.Visible = True
            cmbbulan.Visible = True
            lbltahun.Visible = True
            cmbtahun.Visible = True
        ElseIf cmbformat.SelectedIndex = 2 Then
            lbltanggal.Visible = True
            cmbtanggal.Visible = True
            lblbulan.Visible = True
            cmbbulan.Visible = True
            lbltahun.Visible = True
            cmbtahun.Visible = True
        End If

        Dim kueri As String

        If cmbtanggal.Visible = True Then
            'Menampilkan Tanggal
            kueri = "SELECT * FROM tblabsen"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                If Not cmbtanggal.Items.Contains(reader.Item("tanggal")) Then
                    cmbtanggal.Items.Add(reader.Item("tanggal"))
                End If
            End While
        End If
        If cmbbulan.Visible = True Then
            'Menampilkan Bulan
            kueri = "SELECT * FROM tblabsen"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                If Not cmbbulan.Items.Contains(reader.Item("bulan")) Then
                    cmbbulan.Items.Add(reader.Item("bulan"))
                End If
            End While
        End If
        If cmbtahun.Visible = True Then
            'Menampilkan Tahun
            kueri = "SELECT * FROM tblabsen"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            While reader.Read
                If Not cmbtahun.Items.Contains(reader.Item("tahun")) Then
                    cmbtahun.Items.Add(reader.Item("tahun"))
                End If
            End While
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcarisiswa.SelectedIndexChanged
        If cmbcarisiswa.Text = "" Then
            Exit Sub
        ElseIf cmbformat.Text = "" Then
            MessageBox.Show("Pilih Tampil Berdasarkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbtanggal.Visible And cmbtanggal.Text = "" Then
            MessageBox.Show("Pilih Tanggal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbbulan.Visible And cmbbulan.Text = "" Then
            MessageBox.Show("Pilih Bulan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbtahun.Visible And cmbtahun.Text = "" Then
            MessageBox.Show("Pilih Tahun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            If cmbcarisiswa.SelectedIndex = 0 Then
                cmbabsen.Visible = True
                kueri = "SELECT * FROM tblsiswa WHERE kelas='" & cmbkelas.Text & "'"
                cmd = New OleDbCommand(kueri, conn)
                reader = cmd.ExecuteReader
                cmbabsen.Items.Clear()
                While reader.Read
                    If Not cmbabsen.Items.Contains(reader.Item("nama")) Then
                        cmbabsen.Items.Add(reader.Item("nama"))
                    End If
                End While
            ElseIf cmbcarisiswa.SelectedIndex = 1 Then
                cmbabsen.Visible = True
                kueri = "SELECT * FROM tblsiswa WHERE kelas='" & cmbkelas.Text & "'"
                cmd = New OleDbCommand(kueri, conn)
                reader = cmd.ExecuteReader
                cmbabsen.Items.Clear()
                While reader.Read
                    If Not cmbabsen.Items.Contains(reader.Item("absen")) Then
                        cmbabsen.Items.Add(reader.Item("absen"))
                    End If
                End While
            End If
        End If
    End Sub

    Private Sub cmbabsen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbabsen.SelectedIndexChanged
        Dim kueri As String
        If cmbabsen.Text = "" Or cmbcarisiswa.Text = "" Then
            Exit Sub
        ElseIf cmbcarisiswa.SelectedIndex = 0 Then
            If cmbtanggal.Visible And cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND nama = '" & cmbabsen.Text & "' AND tanggal = " & cmbtanggal.Text & " AND bulan = " & cmbbulan.Text & " AND tahun = " & cmbtahun.Text & ""
            ElseIf cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND nama = '" & cmbabsen.Text & "' AND bulan = " & cmbbulan.Text & " AND tahun = " & cmbtahun.Text & ""
            ElseIf cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND nama = '" & cmbabsen.Text & "' AND tahun = " & cmbtahun.Text & ""
            Else
                Exit Sub
                Return
            End If
        ElseIf cmbcarisiswa.SelectedIndex = 1 Then
            If cmbtanggal.Visible And cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND absen = " & cmbabsen.Text & " AND tanggal = " & cmbtanggal.Text & " AND bulan = " & cmbbulan.Text & " AND tahun = " & cmbtahun.Text & ""
            ElseIf cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND absen = " & cmbabsen.Text & " AND bulan = " & cmbbulan.Text & " AND tahun = " & cmbtahun.Text & ""
            ElseIf cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas ='" & cmbkelas.Text & "' AND absen = " & cmbabsen.Text & " AND tahun = " & cmbtahun.Text & ""
            Else
                Exit Sub
                Return
            End If            
        End If

        adapter = New OleDbDataAdapter(kueri, conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvsiswa.DataSource = ds.Tables(0)
        dgvsiswa.ReadOnly = True
    End Sub

    Private Sub lbltampil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltampil.Click
        If cmbformat.Text = "" Then
            MessageBox.Show("Pilih Tampil Berdasarkan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbtanggal.Visible And cmbtanggal.Text = "" Then
            MessageBox.Show("Pilih Tanggal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbbulan.Visible And cmbbulan.Text = "" Then
            MessageBox.Show("Pilih Bulan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbtahun.Visible And cmbtahun.Text = "" Then
            MessageBox.Show("Pilih Tahun!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim kueri As String
            If cmbtanggal.Visible And cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas = '" & cmbkelas.Text & "' And tanggal = " & cmbtanggal.Text & " And bulan = " & cmbbulan.Text & " And tahun = " & cmbtahun.Text & ""
            ElseIf cmbbulan.Visible And cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas = '" & cmbkelas.Text & "' And bulan = " & cmbbulan.Text & " And tahun = " & cmbtahun.Text & ""
            ElseIf cmbtahun.Visible Then
                kueri = "SELECT * FROM tblabsen WHERE kelas = '" & cmbkelas.Text & "' And tahun = " & cmbtahun.Text & ""
            End If

            adapter = New OleDbDataAdapter(kueri, conn)
            ds = New DataSet
            adapter.Fill(ds)
            dgvsiswa.DataSource = ds.Tables(0)
            dgvsiswa.ReadOnly = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim izin As Integer = 0
        Dim sakit As Integer = 0
        Dim alfa As Integer = 0
        For i = 0 To dgvsiswa.Rows.Count - 1
            If dgvsiswa.Rows(i).Cells(6).Value = "Izin" Then
                izin = izin + 1
            Else
                izin = izin
            End If
            lblizin.Text = "Izin: " + CStr(izin)
        Next
        For i = 0 To dgvsiswa.Rows.Count - 1
            If dgvsiswa.Rows(i).Cells(6).Value = "Sakit" Then
                sakit = sakit + 1
            Else
                sakit = sakit
            End If
            lblsakit.Text = "Sakit: " + CStr(sakit)
        Next
        For i = 0 To dgvsiswa.Rows.Count - 1
            If dgvsiswa.Rows(i).Cells(6).Value = "Tanpa Keterangan" Then
                alfa = alfa + 1
            Else
                alfa = alfa
            End If
            lblalfa.Text = "Tanpa Keterangan: " + CStr(alfa)
        Next
    End Sub

    Private Sub cmbkelas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkelas.SelectedIndexChanged
        cmbabsen.SelectedIndex = -1
        cmbformat.SelectedIndex = -1
        cmbbulan.SelectedIndex = -1
        cmbtanggal.SelectedIndex = -1
        cmbtahun.SelectedIndex = -1
        cmbcarisiswa.SelectedIndex = -1
    End Sub
End Class