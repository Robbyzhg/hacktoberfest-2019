Imports System.Data.OleDb
Module koneksi
    Public conn As New OleDbConnection
    Public comm As New OleDbCommand
    Public adap As New OleDbDataAdapter
    Public reader As OleDbDataReader
    Public tabel As New DataTable

    Public iduser As Double
    Public idlog As Integer
    Public Function konek() As String
        Return "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " & Application.StartupPath & "\dbData.accdb"
    End Function
End Module
