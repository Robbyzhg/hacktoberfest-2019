Imports System.Data.OleDb
Module koneksi
    Public conn As OleDbConnection
    Public adapter As OleDbDataAdapter
    Public reader As OleDbDataReader
    Public ds As New DataSet
    Public cmd As OleDbCommand
    Public table As DataTable
    Public query As String
    Public iduser As Double
    Public idlog As Integer
    Public db = "provider=microsoft.ace.oledb.12.0;data source=db.accdb"

    Public Sub Konek()
        Try
            conn = New OleDbConnection(db)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Module
