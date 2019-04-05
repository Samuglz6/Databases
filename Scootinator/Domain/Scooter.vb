Public Class Scooter
    Private _ScooterId As Integer
    Private _Description As String
    Private _Type As Integer

    Public Sub New()
    End Sub

    Public Sub New(ScooterId As Integer, Description As String, Type As Integer)
        Me._ScooterId = ScooterId
        Me._Description = Description
        Me._Type = Type
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
End Class
