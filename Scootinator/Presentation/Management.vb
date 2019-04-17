Public Class Management
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As Connection = New Connection
        form.ShowDialog(Me)

        Dim client As Client = New Client
        Dim aux_client As Client

        Dim scooter As Scooter = New Scooter
        Dim aux_scooter As Scooter

        Try
            client.ReadAll()
            scooter.ReadAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try

        For Each aux_client In client.ClientDAO.ClientList
            clients_listbox.Items.Add(aux_client.ClientId)
        Next

        For Each aux_scooter In scooter.ScooterDAO.ScooterList
            scooter_listbox.Items.Add(aux_scooter.ScooterId)
        Next
    End Sub

    Private Sub clients_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clients_listbox.SelectedIndexChanged
        Dim client As Client = New Client With {
            .ClientId = clients_listbox.SelectedItem
        }

        client.Read()

        clientID_textbox.Text = client.ClientId
        clientName_textbox.Text = client.ClientName
        clientPhone_textbox.Text = client.TelephNumber
        clientAddress_textbox.Text = client.Address
        clientEmail_textbox.Text = client.Email
    End Sub

    Private Sub scooter_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scooter_listbox.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {
            .ScooterId = scooter_listbox.SelectedItem
        }

        scooter.Read()

        scooterID_textbox.Text = Convert.ToString(scooter.ScooterId)
        scooterDescription_textbox.Text = scooter.Description
        scooterType_textBox.Text = scooter.Type
    End Sub
End Class
