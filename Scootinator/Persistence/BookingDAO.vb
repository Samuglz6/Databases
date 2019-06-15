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
        Return DBBroker.GetBroker.Change("INSERT INTO BOOKINGS(BeginTime, EndTime, Client, BookingDate, TotalPrice)
                                          VALUES(#" & b.BeginTime & "# , #" & b.EndTime & "# , '" & b.Client & "', #" & b.BookingDate.Date & "#," & b.TotalPrice & ");")
    End Function

    Public Sub Read(b As Booking)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM BOOKINGS WHERE Client = '" & b.Client & "';")

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
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM BOOKINGS ORDER BY BookingID;")
        Dim aux As Booking

        While Me._dbReader.Read
            aux = New Booking(Convert.ToString(Me._dbReader(0)), Convert.ToString(Me._dbReader(1)), Convert.ToString(Me._dbReader(2)), Convert.ToString(Me._dbReader(3)), Convert.ToString(Me._dbReader(4)), Convert.ToString(Me._dbReader(5)))
            Me._bookingList.Add(aux)
        End While
    End Sub

    Public Sub FreeScooters(b As Booking, beginTime As DateTime, endTime As DateTime, bookDate As DateTime)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT ScooterID  
                                                From SCOOTERS 
                                                WHERE ScooterID NOT IN (SELECT ScooterID 
                                                                        FROM SCOOTERS, RENTALS, BOOKINGS
                                                                        WHERE ScooterID = Scooter
                                                                        AND BookingID = Booking
                                                                        AND BookingDate = #" & bookDate.Date & "#
                                                                        AND ((BeginTime >= #" & beginTime & "# 
                                                                              AND BeginTime < #" & endTime & "#)   
                                                                        OR (EndTime <= #" & endTime & "#   
                                                                            AND EndTime > #" & beginTime & "#)));")

        While Me._dbReader.Read()
            b.ScooterList.Add(_dbReader(0))
        End While
    End Sub

    Public Sub HistoryScooters(b As Booking, beginTime As DateTime, endTime As DateTime)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT Scooter 
                                                FROM RENTALS 
                                                WHERE Booking IN(SELECT BookingID 
                                                                 FROM BOOKINGS 
                                                                 WHERE BookingDate BETWEEN #" & beginTime.Date & "# AND #" & endTime.Date & "#)
                                                GROUP BY Scooter;")
        While Me._dbReader.Read()
            b.ScooterList.Add(_dbReader(0))
        End While
    End Sub
End Class