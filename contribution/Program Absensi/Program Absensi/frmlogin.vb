Imports System.Data.OleDb

Public Class frmlogin

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Konek()
        idlog = 0
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim kueri As String
        kueri = "SELECT * FROM tbluser WHERE username = '" & txtusername.Text & "' AND '" & txtpassword.Text & "'"
        cmd = New OleDbCommand(kueri, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If Not reader.HasRows Then
            MessageBox.Show("Username Salah!", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            If reader.Item("password") <> txtpassword.Text Then
                MessageBox.Show("Password Salah!", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            End If

            If reader.Item("lvl") = "Superuser" Then
                lvl = "SU"
            Else
                lvl = "U"
            End If
            idlog = reader.Item("ID")
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
