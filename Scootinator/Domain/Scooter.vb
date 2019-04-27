Public Class Scooter
    Private _ScooterId As Integer
    Private _Description As String
    Private _Type As Integer
    Private _daoScooter As ScooterDAO

    Public Sub New()
        Me._daoScooter = New ScooterDAO
    End Sub

    Public Sub New(ScooterId As Integer, Description As String, Type As Integer)
        Me._ScooterId = ScooterId
        Me._Description = Description
        Me._Type = Type
        Me._daoScooter = New ScooterDAO
    End Sub


    Public Property ScooterId() As Integer
        Get
            Return Me._ScooterId
        End Get
        Set(ByVal value As Integer)
            Me._ScooterId = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me._Description
        End Get
        Set(ByVal value As String)
            Me._Description = value
        End Set
    End Property

    Public Property Type() As Integer
        Get
            Return Me._Type
        End Get
        Set(ByVal value As Integer)
            Me._Type = value
        End Set
    End Property

    Public Property ScooterDAO() As ScooterDAO
        Get
            Return Me._daoScooter
        End Get
        Set(value As ScooterDAO)
            Me._daoScooter = value
        End Set
    End Property


    Public Sub Insert()
        Me._daoScooter.Insert(Me)
    End Sub

    Public Sub Read()
        Me._daoScooter.Read(Me)
    End Sub

    Public Sub ReadAll()
        Me._daoScooter.ReadAll()
    End Sub

    Public Sub Update()
        Me._daoScooter.Update(Me)
    End Sub

    Public Sub Delete()
        Me._daoScooter.Delete(Me)
    End Sub

End Class
