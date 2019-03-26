Public Class DBBroker

    Private Shared connectionString As String = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared connection As OleDb.OleDbConnection
    Private Shared _Instance As DBBroker

    Public Shared Function GetBroker() As DBBroker
        If _Instance Is Nothing Then
            _Instance = New DBBroker()
        End If
        Return _Instance
    End Function

    Private Sub New()
        DBBroker.connection = New OleDb.OleDbConnection(DBBroker.connectionString)
        DBBroker.connection.Open()
    End Sub

    Public Function Read(sql As String) As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Return com.ExecuteReader
    End Function

    Public Function Change(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Return com.ExecuteNonQuery
    End Function

    Public Shared Function GetBroker(path As String) As DBBroker
        DBBroker.connectionString = DBBroker.connectionString & path
        Return DBBroker.GetBroker
    End Function

    Public Sub DisconnectDB()
        DBBroker.connection.Close()
    End Sub
End Class

