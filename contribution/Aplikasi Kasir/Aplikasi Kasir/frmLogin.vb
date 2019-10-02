Imports System.Data.OleDb

Public Class frmLogin
    Dim nama As String

    Private Function validasi() As Boolean
        Dim cek As Boolean
        cek = True
        err.Clear()
        If txtUname.Text.Trim = "" Then
            cek = False
            err.SetError(txtUname, "Username harus diisi!")
        ElseIf txtPass.Text.Trim = "" Then
            cek = False
            err.SetError(txtPass, "Password harus diisi!")
        End If
        Return cek
    End Function

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If validasi() = True Then
            Dim user As New OleDbParameter("@username", OleDbType.VarChar, 255)
            Dim pass As New OleDbParameter("@password", OleDbType.VarChar, 255)
            user.Value = txtUname.Text
            pass.Value = txtPass.Text
            conn = New OleDbConnection(db)
            conn.Open()
            cmd = New OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "SELECT ID FROM tblUser WHERE username = @username AND password = @password"
            cmd.Parameters.Add(user)
            cmd.Parameters.Add(pass)
            reader = cmd.ExecuteReader
            If reader.HasRows = False Then
                txtUname.Text = ""
                txtPass.Text = ""
                err.SetError(txtUname, "Username / Password salah")
                conn.Close()
            Else
                reader.Read()
                idlog = reader.GetValue(0)
                frmMaster.loginin()
                Me.Close()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUname.Focus()
        txtUname.Clear()
        txtPass.Clear()
    End Sub
End Class
