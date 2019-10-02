Imports System.Data.OleDb
Public Class frmChange

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        Call Konek()
        Dim kueri As String
        kueri = "SELECT * FROM tblUser WHERE ID = " & idlog & ""
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            txtID.Text = reader.Item("ID")
            txtNama.Text = reader.Item("nama")
            txtUsername.Text = reader.Item("username")
            txtPassword.Text = reader.Item("password")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtNama.Text = "" Or txtPassword.Text = "" Or txtUsername.Text = "" Then
            MessageBox.Show("Isi Seluruh Data!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Call Konek()
            Dim query, kueri As String
            query = "SELECT username FROM tblUser WHERE username = '" & txtUsername.Text & "'"
            cmd = New OleDbCommand(query, conn)
            reader = cmd.ExecuteReader
            reader.Read()
            If reader.HasRows Then
                MessageBox.Show("Username sudah ada!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                kueri = "UPDATE tblUser SET [username] = '" & txtUsername.Text & "',[password] = '" & txtPassword.Text & "',[nama] = '" & txtNama.Text & "' WHERE [ID] = " & txtID.Text & " "
                cmd = New OleDbCommand(kueri, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Info akun berhasil di Edit!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class