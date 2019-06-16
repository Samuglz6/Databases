Public Class ScooterTypeDAO
    Private _scooterTypeList As Collection = New Collection
    Private _dbReader As OleDb.OleDbDataReader
    Private _dictionary As New Dictionary(Of String, Integer)

    Public Property Dict As Dictionary(Of String, Integer)
        Get
            Return _dictionary
        End Get
        Set(value As Dictionary(Of String, Integer))
            _dictionary = value
        End Set
    End Property

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

    Public Sub Ranking(beginDate As Date, endDate As Date)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT TypeID, SUM(PricePerHour*DATEDIFF(""h"", beginTime, endTime))
                                                FROM SCOOT_TYPE, SCOOTERS, RENTALS, BOOKINGS
                                                WHERE BookingID = Booking 
                                                AND Scooter = ScooterID 
                                                AND Type = TypeID 
                                                AND BookingDate BETWEEN #" & beginDate.Date.ToString("MM/dd/yyyy") & "# AND #" & endDate.Date.ToString("MM/dd/yyyy") & "# 
                                                GROUP BY TypeID
                                                ORDER BY 2 DESC")

        While Me._dbReader.Read
            Me._scooterTypeList.Add(_dbReader(0))
            Me._dictionary.Add(_dbReader(0), _dbReader(1))
        End While
    End Sub
End Class
