Public Class ScooterTypeDAO
    Private _scooterTypeList As Collection = New Collection
    Private _dbReader As OleDb.OleDbDataReader

    Public Property ScooterTypeList As Collection
        Get
            Return _scooterTypeList
        End Get
        Set(value As Collection)
            _scooterTypeList = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal list As Collection, ByVal dbReader As OleDb.OleDbDataReader)
        Me._scooterTypeList = list
        Me._dbReader = dbReader
    End Sub

    Public Function Insert(st As ScooterType) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO SCOOT_TYPE VALUES(" & st.TypeID & ",'" & st.Brand & "'," & st.MaxWeight & "," & st.MaxSpeed & "," & st.PricePerHou & ");")
    End Function

    Public Sub Read(st As ScooterType)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM SCOOT_TYPE WHERE TypeID = " & st.TypeID & ";")

        While Me._dbReader.Read
            st.TypeID = Convert.ToInt32(Me._dbReader(0))
            st.Brand = Convert.ToString(Me._dbReader(1))
            st.MaxWeight = Convert.ToInt32(Me._dbReader(2))
            st.MaxSpeed = Convert.ToInt32(Me._dbReader(3))
            st.PricePerHou = Convert.ToInt32(Me._dbReader(4))
        End While
    End Sub

    Public Sub ReadAll()
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM SCOOT_TYPE ORDER BY TypeID;")
        Dim aux As ScooterType

        While Me._dbReader.Read
            aux = New ScooterType(Convert.ToInt32(Me._dbReader(0)), Convert.ToString(Me._dbReader(1)), Convert.ToInt32(Me._dbReader(2)), Convert.ToInt32(Me._dbReader(3)), Convert.ToInt32(Me._dbReader(4)))
            Me._scooterTypeList.Add(aux)
        End While
    End Sub

    Public Function Update(st As ScooterType)
        Return DBBroker.GetBroker.Change("UPDATE SCOOT_TYPE SET Brand = '" & st.Brand & "', MaxWeight = " & st.MaxWeight & ", MaxSpeed = " & st.MaxSpeed & ", PricePerHour = " & st.PricePerHou & "  WHERE typeID = " & st.TypeID & ";")
    End Function

    Public Function Delete(st As ScooterType)
        Return DBBroker.GetBroker.Change("DELETE FROM SCOOT_TYPE WHERE TypeID = " & st.TypeID & ";")
    End Function

    Public Sub Ranking(beginDate As DateTime, endDate As DateTime)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT st.TypeID, SUM(b.TotalPrice) AS 'income'
                                                FROM SCOOT_TYPE st, SCOOTERS s, RENTALS r, BOOKINGS b 
                                                WHERE b.BookingID = r.Booking AND s.ScooterID = r.Scooter AND s.Type = st.TypeID AND b.BookingDate BETWEEN #" & beginDate.Date & "# AND #" & endDate.Date & "#
                                                GROUP BY st.TypeID
                                                ORDER BY 'income';")
        While Me._dbReader.Read
            Me._scooterTypeList.Add(_dbReader(0))
        End While
    End Sub
End Class
