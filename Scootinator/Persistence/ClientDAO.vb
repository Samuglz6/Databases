Public Class ClientDAO
    Public Function Insert()
        Return DBBroker.GetBroker.Change("")
    End Function

    Public Sub Read()
        DBBroker.GetBroker.Read("")
    End Sub

    Public Sub ReadAll()

    End Sub

    Public Sub Update()

    End Sub

    Public Sub Delete()

    End Sub
End Class
