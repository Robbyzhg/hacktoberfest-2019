Imports System.Data.OleDb
Public Class frmKasir

    Function namahari(ByVal tgl As String)
        Return Replace(Replace(Replace(Replace(Replace(Replace(Replace(tgl, "Sunday", "Minggu"), "Monday", "Senin"), "Tuesday", "Selasa"), "Wednesday", "Rabu"), "Thursday", "Kamis"), "Friday", "Jumat"), "Saturday", "Sabtu")
    End Function

    Sub tampilkode()
        Call Konek()
        adapter = New OleDbDataAdapter("SELECT kode FROM tblBarang", conn)
        ds = New DataSet
        adapter.Fill(ds)
        dgvKode.DataSource = ds.Tables(0)
        dgvKode.ReadOnly = True
    End Sub

    Private Sub frmKasir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert Then
            btnTambah.PerformClick()
        ElseIf e.KeyCode = Keys.Enter Then
            btnCari.PerformClick()
        ElseIf e.KeyCode = Keys.Delete Then
            btnKurang.PerformClick()
        ElseIf e.KeyCode = Keys.End Then
            btnHitung.PerformClick()
        ElseIf e.KeyCode = Keys.Q Then
            cmbKode.Focus()
        ElseIf e.KeyCode = Keys.W Then
            txtQty.Focus()
        ElseIf e.KeyCode = Keys.E Then
            dgvBarang.Focus()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Call Konek()
        Call tampilkode()
        query = "SELECT * FROM tblBarang"
        cmd = New OleDbCommand(query, conn)
        reader = cmd.ExecuteReader
        cmbKode.Items.Clear()
        While reader.Read
            cmbKode.Items.Add(reader.Item("kode"))
        End While
        dgvBarang.RowsDefaultCellStyle.BackColor = Color.FloralWhite
        dgvBarang.AlternatingRowsDefaultCellStyle.BackColor = Color.ForestGreen
    End Sub

    Private Sub cmbKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbKode.KeyPress, txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKode.SelectedIndexChanged
        Call Konek()
        query = "SELECT * FROM tblBarang WHERE kode = " & cmbKode.Text
        cmd = New OleDbCommand(query, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            txtNama.Text = reader.Item("nama")
            txtHarga.Text = reader.Item("harga")
        End If
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If cmbKode.Text = "" Or cmbKode.Text = " " Or IsNumeric(cmbKode.Text) = False Then
            MessageBox.Show("Masukkan Kode dengan Benar!", "Masukkan Kode!")
        Else
            If Not cmbKode.Text <> dgvKode.Columns(0).Displayed Then
                Call Konek()
                query = "SELECT * FROM tblBarang WHERE kode = " & cmbKode.Text
                cmd = New OleDbCommand(query, conn)
                reader = cmd.ExecuteReader
                reader.Read()
                If reader.HasRows Then
                    txtNama.Text = reader.Item("nama")
                    txtHarga.Text = reader.Item("harga")
                Else
                    MessageBox.Show("Kode Barang Tidak Ada!", "Kode Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblJam.Text = Format(Now, "HH:mm:ss")
        lblTanggal.Text = namahari(Format(CDate(Now.Date), "dddd, dd/M/yyyy"))
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Dim data As String()
        Dim harga, qty As Integer
        
        If cmbKode.Text = "" Then
            MessageBox.Show("Masukkan Kode Dengan Benar!", "Kode Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtHarga.Text = "" Then
            MessageBox.Show("Klik Tombol Cari atau Teka Enter Terlebih Dahulu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf txtQty.Text = "" Then
            txtQty.Text = 1
        End If

        harga = txtHarga.Text
        qty = txtQty.Text
        harga = harga * qty
        data = New String() {cmbKode.Text, txtNama.Text, txtQty.Text, harga}
        dgvBarang.Rows.Add(data)
    End Sub

    Private Sub btnKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKurang.Click
        dgvBarang.Rows.Remove(dgvBarang.CurrentRow)
    End Sub

    Private Sub dgvBarang_RowsAdded() Handles dgvBarang.RowsAdded, dgvBarang.RowsRemoved
        Dim total As Integer
        For i As Integer = 0 To dgvBarang.Rows.Count - 1
            total = total + Val(dgvBarang.Rows(i).Cells(3).Value)
        Next
        lblTotal.Text = FormatNumber(total, 0)
        If lblTotal.Text = 0 Then
            btnKurang.Enabled = False
            btnHitung.Enabled = False
        Else
            btnKurang.Enabled = True
            btnHitung.Enabled = True
        End If
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim bayar As String
        Dim kembali, total As Integer
        total = lblTotal.Text
        bayar = InputBox("Masukkan nominal uang yang dibayar", "Bayar")
        If bayar = "" Or bayar = " " Or IsNumeric(bayar) = False Then
            MessageBox.Show("Isikan dengan benar", "Error")
        ElseIf bayar < total Then
            MessageBox.Show("Uang tidak cukup", "Tidak Cukup")
        Else
            bayar = CInt(bayar)
            kembali = bayar - lblTotal.Text
            If kembali = 0 Then
                MessageBox.Show("Total harga Rp." + FormatNumber(lblTotal.Text, 0) + ",-" + vbCrLf +
                    "Terima Kasih.", "Terima Kasih :)")
            ElseIf kembali > 0 Then
                MessageBox.Show("Total harga Rp." + FormatNumber(lblTotal.Text, 0) + ",-" + vbCrLf +
                    "Kembalian Rp." + FormatNumber(kembali, 0) + ",-" + vbCrLf + _
                    "Terima Kasih.", "Terima Kasih :)")
            End If
            cmbKode.Text = ""
            txtNama.Text = ""
            txtHarga.Text = ""
            txtQty.Text = ""
            dgvBarang.Rows.Clear()
            cmbKode.Focus()
        End If
    End Sub
    
End Class
