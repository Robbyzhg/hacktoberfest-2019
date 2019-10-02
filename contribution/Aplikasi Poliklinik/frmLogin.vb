Imports System.Data.OleDb
Public Class frmLogin

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        If validasi() = True Then
            Dim puid As New OleDbParameter("@uid", OleDbType.VarChar, 255)
            Dim ppwd As New OleDbParameter("@pwd", OleDbType.VarChar, 255)
            puid.Value = TextBox1.Text
            ppwd.Value = TextBox2.Text
            conn = New OleDbConnection(konek())
            conn.Open()
            comm = New OleDbCommand
            comm.Connection = conn
            comm.CommandText = "SELECT idkar FROM tblKaryawan WHERE uname = @uid AND ppwd = @pwd"
            comm.Parameters.Add(puid)
            comm.Parameters.Add(ppwd)
            reader = comm.ExecuteReader
            If reader.HasRows = False Then
                TextBox1.Text = ""
                TextBox2.Text = ""
                erperr.SetError(TextBox1, "login information salah!")
                conn.Close()
            Else
                reader.Read()
                idlog = reader.GetValue(0)
                frmMaster.loginin()
                MessageBox.Show("Welcome")
                Me.Close()
                conn.Close()
            End If
        End If
    End Sub

    Private Function validasi() As Boolean
        Dim cekit As Boolean
        cekit = True
        erperr.Clear()
        If TextBox1.Text.Trim = "" Then
            cekit = False
            erperr.SetError(TextBox1, "Username harus diisi!")
        End If
        If TextBox2.Text.Trim = "" Then
            cekit = False
            erperr.SetError(TextBox2, "Password harus diisi!")
        End If
        Return cekit
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class