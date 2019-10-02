Imports System.Data.OleDb

Public Class frmabsen
    Dim count, counter As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()
        txttanggal.Text = Format(Now, "dd")
        txtbulan.Text = Format(Now, "MM")
        txttahun.Text = Format(Now, "yyyy")

        'list kelas yang ada
        Dim kueri As String
        kueri = "SELECT * FROM tblsiswa"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        While reader.Read
            If Not cmbkelas.Items.Contains(reader.Item("kelas")) Then
                cmbkelas.Items.Add(reader.Item("kelas"))
            End If
        End While

        btnsubmit.Enabled = False
        cmbabsen.Enabled = False
    End Sub

    Private Sub cmbkelas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbkelas.SelectedIndexChanged
        Dim kueri As String
        txtnama.Clear()
        cmbabsen.Enabled = True
        If cmbkelas.Text = "" Then
            Exit Sub
        Else
            'list nomor absen yang ada di dalam kelas
            kueri = "SELECT absen FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "'"
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            cmbabsen.Items.Clear()
            While reader.Read
                cmbabsen.Items.Add(reader.Item("absen"))
            End While
        End If

        kueri = "SELECT absen FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "' ORDER BY absen DESC"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        counter = reader.Item("absen")
    End Sub

    Private Sub cmbabsen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbabsen.SelectedIndexChanged
        btnsubmit.Enabled = True
        Timer1.Enabled = True
        If cmbkelas.Text = "" Then
            MessageBox.Show("Pilih Kelas Terlebih Dahulu!", "Kelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbabsen.Text = "" Then
            Exit Sub
        Else
            Dim kueri As String
            kueri = "SELECT * FROM tblsiswa WHERE kelas = '" & cmbkelas.Text & "' AND absen = " & cmbabsen.Text & ""
            cmd = New OleDbCommand(kueri, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                txtnama.Text = reader.Item("nama")
            End If
        End If
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Dim keterangan, kueri As String

        If opthadir.Checked = True Then _
            keterangan = "Hadir"
        If optizin.Checked = True Then keterangan = "Izin"
        If optsakit.Checked = True Then keterangan = "Sakit"
        If optalfa.Checked = True Then keterangan = "Tanpa Keterangan"

        If cmbkelas.Text = "" Then
            MessageBox.Show("Pilih Kelas Terlebih Dahulu!", "Kelas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbabsen.Text = "" Then
            MessageBox.Show("Pilih Nomor Absen Terlebih Dahulu!", "No.Absen", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            kueri = "INSERT INTO tblabsen VALUES ('" & cmbkelas.Text & "', " & cmbabsen.Text & ", '" & txtnama.Text & "', " & txttanggal.Text & ", " & txtbulan.Text & ", " & txttahun.Text & ", '" & keterangan & "')"
            cmd = New OleDbCommand(kueri, conn)
            cmd.ExecuteNonQuery()
            cmbabsen.Text = cmbabsen.Text + +1
            cmbabsen.Focus()
        End If
        count = count + 1
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If count = counter Then
            btnsubmit.Enabled = False
            Timer1.Enabled = False
        Else
            btnsubmit.Enabled = True
            Timer1.Enabled = True
        End If
    End Sub
End Class
