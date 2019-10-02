Imports System.Data.OleDb
Public Class frmCariObat
    Dim aridobat() As String
    Dim arharga() As Double
    Dim tempj As Double
    Private Sub frmCariObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isicboobat()
        starter()
    End Sub

    Private Sub isicboobat()
        conn = New OleDbConnection(konek())
        conn.Open()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "SELECT idobat, merk, harga FROM tblObat ORDER BY merk ASC"
        reader = comm.ExecuteReader
        If reader.HasRows = False Then
            MessageBox.Show("Tidak ada data obat, error dalam loading data register")
            conn.Close()
            Me.Close()
        Else
            Dim i As Integer
            i = -1
            cboObat.Items.Clear()
            Do While reader.Read
                i = i + 1
                ReDim Preserve aridobat(i)
                ReDim Preserve arharga(i)
                aridobat(i) = reader.GetValue(0)
                cboObat.Items.Add(reader.GetValue(1))
                arharga(i) = reader.GetValue(2)
            Loop
        End If
        conn.Close()
    End Sub

    Private Sub starter()
        tempj = 1
        cboObat.SelectedIndex = 0
        cboDosis.SelectedIndex = 0
        txtJumlah.Text = 1
    End Sub


    Private Sub txtJumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        If txtJumlah.Text.Trim = "" Then
            tempj = 1
            txtJumlah.Text = tempj
        Else
            If IsNumeric(txtJumlah.Text.Trim) = False Then
                txtJumlah.Text = tempj
            Else
                If txtJumlah.Text.Trim < 1 Then
                    tempj = 1
                    txtJumlah.Text = tempj
                Else
                    tempj = txtJumlah.Text
                End If
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        frmDiagnosa.obatidsend = aridobat(cboObat.SelectedIndex)
        frmDiagnosa.obatnamasend = cboObat.Text
        frmDiagnosa.obatdosissend = cboDosis.Text
        frmDiagnosa.obatjumlahsend = tempj
        frmDiagnosa.obathargasend = arharga(cboObat.SelectedIndex)
        frmDiagnosa.setar()
        Me.Close()
    End Sub
End Class