Public Class Management
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As Connection = New Connection
        form.ShowDialog(Me)

        Dim client As Client = New Client
        Dim aux As Client

        Try
            client.ReadAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try

        For Each aux In client.ClientDAO.ClientList
            clients_listbox.Items.Add(aux.ClientId)
        Next
    End Sub

    Private Sub clients_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clients_listbox.SelectedIndexChanged
        Dim client As Client = New Client()
        client.ClientId = clients_listbox.SelectedItem

        client.Read()

        clientID_textbox.Text = client.ClientId
        clientName_textbox.Text = client.ClientName
        clientPhone_textbox.Text = client.TelephNumber
        clientAddress_textbox.Text = client.Address
        clientEmail_textbox.Text = client.Email
    End Sub
End Class
