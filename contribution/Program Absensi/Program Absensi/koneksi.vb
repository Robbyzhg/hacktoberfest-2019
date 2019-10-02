Imports System.Data.OleDb
Module koneksi
    Public conn As OleDbConnection
    Public adapter As OleDbDataAdapter
    Public reader As OleDbDataReader
    Public ds As New DataSet
    Public cmd As OleDbCommand
    Public table As DataTable
    Public idlog As Integer
    Public lvl As String
    Public db = "provider=microsoft.ace.oledb.12.0;data source=db.accdb"

    Public Sub Konek()
        conn = New OleDbConnection(db)
        conn.Open()
    End Sub
End Module