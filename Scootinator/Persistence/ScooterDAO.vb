Public Class ScooterDAO
    Private _scooterList As Collection
    Private _dbReader As OleDb.OleDbDataReader

    Public Sub New()

    End Sub

    Public Sub New(ByVal list As Collection, ByVal dbReader As OleDb.OleDbDataReader)
        Me._scooterList = list
        Me._dbReader = dbReader
    End Sub

    Public Function Insert(s As Scooter) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO SCOOTER VALUES('" & s.ScooterId & "','" & s.Description & "', '" & s.Type & "');")
    End Function

    Public Sub Read(s As Scooter)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM SCOOTER WHERE ScooterID = '" & s.ScooterId & "';")

        While Me._dbReader.Read
            s.ScooterId = Convert.ToInt32(_dbReader(0))
            s.Description = Convert.ToString(_dbReader(1))
            s.Type = Convert.ToInt32(_dbReader(2))
        End While
    End Sub

End Class
