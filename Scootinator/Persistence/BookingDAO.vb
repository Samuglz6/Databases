Public Class BookingDAO
    Private _bookingList As Collection = New Collection
    Private _dbReader As OleDb.OleDbDataReader


    Public Property ClienBookingListtList() As Collection
        Get
            Return Me._bookingList
        End Get
        Set(ByVal value As Collection)
            Me._bookingList = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal list As Collection, ByVal dbReader As OleDb.OleDbDataReader)
        Me._bookingList = list
        Me._dbReader = dbReader
    End Sub

    Public Function Insert(b As Booking) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO BOOKING VALUES('" & b.BookingId & "','" & b.BeginTime & "','" & b.EndTime & "','" & b.Client & "','" & b.BookingDate & "','" & b.TotalPrice & "');")
    End Function

    Public Sub Read(b As Booking)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM CLIENTS WHERE BookingID = '" & b.BookingId & "';")

        While Me._dbReader.Read
            b.BookingId = Convert.ToString(Me._dbReader(0))
            b.BeginTime = Convert.ToString(Me._dbReader(1))
            b.EndTime = Convert.ToString(Me._dbReader(2))
            b.Client = Convert.ToString(Me._dbReader(3))
            b.BookingDate = Convert.ToString(Me._dbReader(4))
            b.TotalPrice = Convert.ToString(Me._dbReader(5))
        End While
    End Sub

    Public Sub ReadAll()
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM CLIENTS ORDER BY BookingID;")
        Dim aux As Booking

        While Me._dbReader.Read
            aux = New Booking(Convert.ToString(Me._dbReader(0)), Convert.ToString(Me._dbReader(1)), Convert.ToString(Me._dbReader(2)), Convert.ToString(Me._dbReader(3)), Convert.ToString(Me._dbReader(4)), Convert.ToString(Me._dbReader(5)))
            Me._bookingList.Add(aux)
        End While
    End Sub

    Public Function Update(b As Booking)
        Return DBBroker.GetBroker.Change("UPDATE BOOKING SET BeginTime = '" & b.BeginTime & "', EndTime = '" & b.EndTime & "', Client = '" & b.Client & "', BookingDate = '" & b.BookingDate & "', TotalPrice = '" & b.TotalPrice & "' WHERE BookingID = '" & b.BookingId & "';")
    End Function

    Public Function Delete(b As Booking)
        Return DBBroker.GetBroker.Change("DELETE FROM CLIENTS WHERE BookingID = '" & b.BookingId & "';")
    End Function
End Class