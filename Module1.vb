Imports System.Data.OleDb
Imports System.Data
Module Module1
    Public conn As OleDbConnection
    Public Sub OpenDB()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='D:\Asmita\Aboli\Medical_system.accdb'")
        conn.Open()
    End Sub
End Module
