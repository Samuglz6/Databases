Public Class Client
    Private _clientId As String
    Private _clientName As String
    Private _telephNumber As String
    Private _address As String
    Private _email As String
    Private _daoClient As ClientDAO

    Public Sub Client()
        Me._daoClient = New ClientDAO
    End Sub

    Public Sub Client(clientId As String, clientName As String, telephNumber As String, address As String, email As String)
        Me._clientId = clientId
        Me._clientName = clientName
        Me._telephNumber = telephNumber
        Me._address = address
        Me._email = email
        Me._daoClient = New ClientDAO
    End Sub

    Public Sub Insert()
        Me._daoClient.Insert()
    End Sub

    Public Sub Read()
        Me._daoClient.Read()
    End Sub

    Public Sub ReadAll()
        Me._daoClient.ReadAll()
    End Sub

    Public Sub Update()
        Me._daoClient.Update()
    End Sub

    Public Sub Delete()
        Me._daoClient.Delete()
    End Sub
End Class
