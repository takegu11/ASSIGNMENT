Imports System.Data.SqlClient
Imports System.IO
Module Module1
    Public User As DataRow

    Public ds As New DataSet()

    'Public ConnectionString As String = "Server=HAU-PC\SQLEXPRESS;Database=HAUNTPS02849_ASM;Integrated Security=True"
    Public ConnectionString As String = "workstation id=hauntps02849.mssql.somee.com;packet size=4096;user id=ps02849_SQLLogin_1;pwd=8b5ony7cn6;data source=hauntps02849.mssql.somee.com;persist security info=False;initial catalog=hauntps02849"
    Public Sub ExecuteNonQuery(Sql As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand(Sql, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Connection.Close()
    End Sub

    Public Sub Fill(Sql As String, TableName As String)
        Dim Connection As New SqlConnection(ConnectionString)
        Dim DataAdapter As New SqlDataAdapter(Sql, Connection)
        If ds.Tables.Contains(TableName) Then
            ds.Tables(TableName).Clear()
        End If
        DataAdapter.Fill(ds, TableName)
        Connection.Close()
    End Sub
End Module
