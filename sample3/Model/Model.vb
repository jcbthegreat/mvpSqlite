Imports System.Data.SQLite

Module Model

    Public table As DataTable
    Public row As DataRow
    Public column As DataColumn
    Public view As DataView
    Public cmd As SQLiteCommand
    Public query As String
    Public Sqlquery As String
    Public dr As SQLiteDataReader
    Public ConnectionString As String = "Data Source=F:\UserJeremiah\databases\dbSample.db3"


    Public Function loadFunction(ByVal Sqlquery As String) As DataTable

        table = New DataTable

        Dim connect As New SQLiteConnection(ConnectionString)

        Using connect
            query = Sqlquery
            cmd = New SQLiteCommand(query, connect)

            connect.Open()
            Dim dr As SQLiteDataReader = cmd.ExecuteReader()

            table.Load(dr)
            Form1.DataGridView1.DataSource = table

            dr.Close()
        End Using


        Return table

    End Function

End Module
