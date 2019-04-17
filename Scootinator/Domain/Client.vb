Public Class Client
    Private _clientId As Integer
    Private _clientName As String
    Private _telephNumber As Integer
    Private _address As String
    Private _email As String
    Private _daoClient As ClientDAO

    Public Property ClientId() As String
        Get
            Return Me._clientId
        End Get
        Set(ByVal value As String)
            Me._clientId = value
        End Set
    End Property

    Public Property ClientName() As String
        Get
            Return Me._clientName
        End Get
        Set(ByVal value As String)
            Me._clientName = value
        End Set
    End Property

    Public Property TelephNumber() As String
        Get
            Return Me._telephNumber
        End Get
        Set(ByVal value As String)
            Me._telephNumber = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return Me._address
        End Get
        Set(ByVal value As String)
            Me._address = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return Me._email
        End Get
        Set(ByVal value As String)
            Me._email = value
        End Set
    End Property

    Public Property ClientDAO As ClientDAO
        Get
            Return Me._daoClient
        End Get
        Set(ByVal value As ClientDAO)
            Me._daoClient = value
        End Set
    End Property

    Public Sub New()
        Me._daoClient = New ClientDAO
    End Sub

    Public Sub New(clientId As String, clientName As String, telephNumber As Integer, address As String, email As String)
        Me._clientId = clientId
        Me._clientName = clientName
        Me._telephNumber = telephNumber
        Me._address = address
        Me._email = email
        Me._daoClient = New ClientDAO
    End Sub

    Public Sub Insert()
        Me._daoClient.Insert(Me)
    End Sub

    Public Sub Read()
        Me._daoClient.Read(Me)
    End Sub

    Public Sub ReadAll()
        Me._daoClient.ReadAll()
    End Sub

    Public Sub Update()
        Me._daoClient.Update(Me)
    End Sub

    Public Sub Delete()
        Me._daoClient.Delete(Me)
    End Sub
End Class
