Public Class ScooterType
    Private _typeID As Integer
    Private _brand As String
    Private _maxWeight As Integer
    Private _maxSpeed As Integer
    Private _pricePerHou As Integer
    Private _daoScooterType As ScooterTypeDAO

    Public Property TypeID As Integer
        Get
            Return Me._typeID
        End Get
        Set(ByVal value As Integer)
            Me._typeID = value
        End Set
    End Property

    Public Property Brand As String
        Get
            Return Me._brand
        End Get
        Set(ByVal value As String)
            Me._brand = value
        End Set
    End Property

    Public Property MaxWeight As Integer
        Get
            Return Me._maxWeight
        End Get
        Set(ByVal value As Integer)
            Me._maxWeight = value
        End Set
    End Property

    Public Property MaxSpeed As Integer
        Get
            Return Me._maxSpeed
        End Get
        Set(ByVal value As Integer)
            Me._maxSpeed = value
        End Set
    End Property

    Public Property PricePerHou As Integer
        Get
            Return Me._pricePerHou
        End Get
        Set(ByVal value As Integer)
            Me._pricePerHou = value
        End Set
    End Property

    Public Property ScooterTypeDAO As ScooterTypeDAO
        Get
            Return Me._daoScooterType
        End Get
        Set(value As ScooterTypeDAO)
            Me._daoScooterType = value
        End Set
    End Property

    Public Sub New()
        Me._daoScooterType = New ScooterTypeDAO
    End Sub

    Public Sub New(typeID As Integer, brand As String, maxWeight As Integer, maxSpeed As Integer, pricePerHou As Integer)
        Me._typeID = typeID
        Me._brand = brand
        Me._maxWeight = maxWeight
        Me._maxSpeed = maxSpeed
        Me._pricePerHou = pricePerHou
        Me._daoScooterType = New ScooterTypeDAO
    End Sub

    Public Sub Insert()
        Me._daoScooterType.Insert(Me)
    End Sub

    Public Sub Read()
        Me._daoScooterType.Read(Me)
    End Sub

    Public Sub ReadAll()
        Me._daoScooterType.ReadAll()
    End Sub

    Public Sub Update()
        Me._daoScooterType.Update(Me)
    End Sub

    Public Sub Delete()
        Me._daoScooterType.Delete(Me)
    End Sub
End Class
