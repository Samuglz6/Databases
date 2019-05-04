Public Class Booking
    Private _bookingId As Integer
    Private _beginTime As DateTime
    Private _endTime As DateTime
    Private _client As String
    Private _bookingDate As DateTime
    Private _totalPrice As Integer
    Private _daoBooking As BookingDAO
    Private _scooterList As Collection = New Collection

    Public Property BookingId() As Integer
        Get
            Return Me._bookingId
        End Get
        Set(value As Integer)
            Me._bookingId = value
        End Set
    End Property

    Public Property Client() As String
        Get
            Return Me._client
        End Get
        Set(value As String)
            Me._client = value
        End Set
    End Property

    Public Property ScooterList() As Collection
        Get
            Return Me._scooterList
        End Get
        Set(value As Collection)
            Me._scooterList = value
        End Set
    End Property

    Public Property BeginTime() As DateTime
        Get
            Return Me._beginTime
        End Get
        Set(value As DateTime)
            Me._beginTime = value
        End Set
    End Property

    Public Property TotalPrice() As Integer
        Get
            Return Me._totalPrice
        End Get
        Set(value As Integer)
            Me._totalPrice = value
        End Set
    End Property

    Public Property BookingDate() As DateTime
        Get
            Return Me._bookingDate
        End Get
        Set(value As DateTime)
            Me._bookingDate = value
        End Set
    End Property

    Public Property EndTime() As DateTime
        Get
            Return Me._endTime
        End Get
        Set(value As DateTime)
            Me._endTime = value
        End Set
    End Property

    Public Sub New()
        Me._daoBooking = New BookingDAO
    End Sub

    Public Sub New(beginTime As DateTime, endTime As DateTime, client As String, bookingDate As DateTime, totalPrice As Integer)
        Me._beginTime = beginTime
        Me._endTime = endTime
        Me._client = client
        Me._bookingDate = bookingDate
        Me._totalPrice = totalPrice
        Me._daoBooking = New BookingDAO
    End Sub

    Public Sub New(bookingId As Integer, beginTime As DateTime, endTime As DateTime, client As String, bookingDate As DateTime, totalPrice As Integer)
        Me._bookingId = bookingId
        Me._beginTime = beginTime
        Me._endTime = endTime
        Me._client = client
        Me._bookingDate = bookingDate
        Me._totalPrice = totalPrice
        Me._daoBooking = New BookingDAO
    End Sub

    Public Sub Insert()
        Me._daoBooking.Insert(Me)
    End Sub

    Public Sub Read()
        Me._daoBooking.Read(Me)
    End Sub

    Public Sub ReadAll()
        Me._daoBooking.ReadAll()
    End Sub

    Public Sub FreeScooters(beginTime As DateTime, endTime As DateTime, bookDate As DateTime)
        Me._daoBooking.FreeScooters(Me, beginTime, endTime, bookDate)
    End Sub

    Public Sub HistoryScooters(beginTime As DateTime, endTime As DateTime)
        Me._daoBooking.HistoryScooters(Me, beginTime, endTime)
    End Sub
End Class
