Imports System.Data.OleDb
Public Class frmTambah

    Function nomorID() As Integer
        Using conn As New OleDb.OleDbConnection(db)
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select COUNT(*) FROM tblBarang", conn)
            Return cmd.ExecuteScalar()
        End Using
    End Function

    Function namahari(ByVal tgl As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(tgl, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function

    Sub tampilData()
        Call Konek()
        adapter = New OleDbDataAdapter("SELECT * FROM tblBarang ORDER BY id DESC", conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvBarang.DataSource = ds.Tables(0)
        dgvBarang.ReadOnly = True
    End Sub

    Sub penomoran()
        Dim id As Integer
        id = 1 + Val(dgvBarang.Rows(0).Cells(0).Value)
        txtID.Text = id
    End Sub

    Sub dgv()
        dgvBarang.Columns(0).HeaderText = "#"
        dgvBarang.Columns(1).HeaderText = "Kode"
        dgvBarang.Columns(2).HeaderText = "Nama Barang"
        dgvBarang.Columns(3).HeaderText = "Harga"
        dgvBarang.Columns("ID").Width = 50
        dgvBarang.Columns("kode").Width = 80
        dgvBarang.Columns("nama").Width = 500
        dgvBarang.Columns("harga").Width = 100
        dgvBarang.RowsDefaultCellStyle.BackColor = Color.LightBlue
        dgvBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub frmTambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tampilData()
        Call penomoran()
        Call dgv()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim cmd As OleDbCommand
        If txtKode.Text = "" Or txtNama.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Silahkan Isi Semua Form", "Error")
        ElseIf IsNumeric(txtKode.Text) = False Or IsNumeric(txtHarga.Text) = False Then
            MessageBox.Show("Isi Kode atau Harga hanya dengan angka")
        Else
            Call Konek()
            Dim kuerival
            kuerival = "SELECT * FROM tblBarang WHERE kode = " & txtKode.Text & ""
            cmd = New OleDbCommand(kuerival, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If Not reader.HasRows Then
                Dim kueri As String
                kueri = "INSERT INTO tblBarang VALUES ('" & txtID.Text & "','" & txtKode.Text & "','" & txtNama.Text & "','" & txtHarga.Text & "')"
                cmd = New OleDbCommand(kueri, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Input data berhasil", "Sukses")
                txtID.Text = txtID.Text + 1
                Call tampilData()
            Else
                MessageBox.Show("Kode Sudah ada", "Error")
            End If
        End If
    End Sub
    
    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        Dim kode As String
        kode = InputBox("Masukkan Kode barang yang akan dihapus", "Hapus Barang")
        If kode = "" Or kode = " " Then
            MessageBox.Show("Masukkan Kode dengan Benar!", "Masukkan Kode")
        Else
            If kode <> dgvBarang.Columns(1).Displayed Then
                MessageBox.Show("Kode tidak tersedia!", "Error")
            Else
                Call Konek()
                Dim kueri As String
                kode = CInt(kode)
                kueri = "DELETE FROM tblBarang WHERE kode = " & kode & ""
                cmd = New OleDbCommand(kueri, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Menghapus barang dengan Kode " + CStr(kode) + ", BERHASIL")
                Call penomoran()
                Call tampilData()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblJam.Text = Format(Now, "HH:mm:ss")
        lblTanggal.Text = namahari(Format(CDate(Now.Date), "dddd, dd/M/yyyy"))
    End Sub
End Class