Public Class ClientDAO

    Private _clientList As Collection = New Collection
    Private _dbReader As OleDb.OleDbDataReader

    Public Property ClientList() As Collection
        Get
            Return Me._clientList
        End Get
        Set(ByVal value As Collection)
            Me._clientList = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal list As Collection, ByVal dbReader As OleDb.OleDbDataReader)
        Me._clientList = list
        Me._dbReader = dbReader
    End Sub

    Public Function Insert(c As Client) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO CLIENTS VALUES('" & c.ClientId & "','" & c.ClientName & "','" & c.TelephNumber & "','" & c.Address & "','" & c.Email & "');")
    End Function

    Public Sub Read(c As Client)
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM CLIENTS WHERE ClientID = '" & c.ClientId & "';")

        While Me._dbReader.Read
            c.ClientId = Convert.ToString(Me._dbReader(0))
            c.ClientName = Convert.ToString(Me._dbReader(1))
            c.TelephNumber = Convert.ToInt32(Me._dbReader(2))
            c.Address = Convert.ToString(Me._dbReader(3))
            c.Email = Convert.ToString(Me._dbReader(4))
        End While
    End Sub

    Public Sub ReadAll()
        Me._dbReader = DBBroker.GetBroker.Read("SELECT * FROM CLIENTS ORDER BY ClientId;")
        Dim aux As Client

        While Me._dbReader.Read
            aux = New Client(Convert.ToString(Me._dbReader(0)), Convert.ToString(Me._dbReader(1)), Convert.ToInt32(Me._dbReader(2)), Convert.ToString(Me._dbReader(3)), Convert.ToString(Me._dbReader(4)))
            Me._clientList.Add(aux)
        End While
    End Sub

    Public Function Update(c As Client)
        Return DBBroker.GetBroker.Change("UPDATE CLIENTS SET ClientName = '" & c.ClientName & "', TelephNumber = '" & c.TelephNumber & "', Address = '" & c.Address & "', Email = '" & c.Email & "' WHERE ClientId = '" & c.ClientId & "';")
    End Function

    Public Function Delete(c As Client)
        Return DBBroker.GetBroker.Change("DELETE FROM CLIENTS WHERE ClientId = '" & c.ClientId & "';")
    End Function

    Public Sub ClientsRentedScooter(s As Scooter, beginDate As Date, endDate As Date)
        Dim aux As Client
        Me._dbReader = DBBroker.GetBroker.Read("SELECT Client
                                                FROM RENTALS, BOOKINGS
                                                WHERE BookingID = Booking 
                                                AND Scooter = " & s.ScooterId & "
                                                AND BookingDate BETWEEN #" & beginDate.ToString("MM/dd/yyyy") & "# AND #" & endDate.ToString("MM/dd/yyyy") & "#
                                                GROUP BY Client;")
        While Me._dbReader.Read
            aux = New Client With {.ClientId = Me._dbReader(0)}
            Me._clientList.Add(aux)
        End While
    End Sub

    Public Sub ClientsHistory(beginDate As Date, endDate As Date)
        Dim aux As Client
        Me._dbReader = DBBroker.GetBroker.Read("SELECT Client 
                                                FROM BOOKINGS
                                                WHERE BookingDate BETWEEN  #" & beginDate.ToString("MM/dd/yyyy") & "# AND #" & endDate.ToString("MM/dd/yyyy") & "#
                                                GROUP BY Client;")
        While Me._dbReader.Read
            aux = New Client With {.ClientId = Me._dbReader(0)}
            Me._clientList.Add(aux)
        End While

    End Sub
End Class
