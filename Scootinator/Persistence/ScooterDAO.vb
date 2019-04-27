Public Class ScooterDAO
    Private _scooterList As Collection = New Collection
    Private _dbReader As OleDb.OleDbDataReader

    Public Property ScooterList() As Collection
        Get
            Return Me._scooterList
        End Get
        Set(ByVal value As Collection)
            Me._scooterList = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal list As Collection, ByVal dbReader As OleDb.OleDbDataReader)
        Me._scooterList = list
        Me._dbReader = dbReader
    End Sub

    Public Function Insert(s As Scooter) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO SCOOTERS VALUES(" & s.ScooterId & ",'" & s.Description & "'," & s.Type & ");")
    End Function

    Public Sub Read(s As Scooter)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM SCOOTERS WHERE ScooterID = " & s.ScooterId & ";")

        While Me._dbReader.Read
            s.ScooterId = Convert.ToInt32(Me._dbReader(0))
            s.Description = Convert.ToString(Me._dbReader(1))
            s.Type = Convert.ToInt32(Me._dbReader(2))
        End While
    End Sub

    Public Sub ReadAll()
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM SCOOTERS ORDER BY ScooterId;")
        Dim aux As Scooter

        While Me._dbReader.Read
            aux = New Scooter(Convert.ToString(Me._dbReader(0)), Convert.ToString(Me._dbReader(1)), Convert.ToInt32(Me._dbReader(2)))
            Me._scooterList.Add(aux)
        End While
    End Sub

    Public Function Update(s As Scooter)
        Return DBBroker.GetBroker.Change("UPDATE SCOOTERS SET Description = '" & s.Description & "', Type = " & s.Type & " WHERE ScooterId = " & s.ScooterId & ";")
    End Function

    Public Function Delete(s As Scooter)
        Return DBBroker.GetBroker.Change("DELETE FROM SCOOTERS WHERE ScooterId = " & s.ScooterId & ";")
    End Function
End Class
