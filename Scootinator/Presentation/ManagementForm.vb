Public Class ManagementForm
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As Client = New Client
        Dim aux_client As Client

        Dim scooter As Scooter = New Scooter
        Dim aux_scooter As Scooter

        Dim scooterType As ScooterType = New ScooterType
        Dim aux_type As ScooterType

        Try
            client.ReadAll()
            scooter.ReadAll()
            scooterType.ReadAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try

        For Each aux_client In client.ClientDAO.ClientList
            clients_listbox.Items.Add(aux_client.ClientId)
        Next

        For Each aux_scooter In scooter.ScooterDAO.ScooterList
            scooter_listbox.Items.Add(aux_scooter.ScooterId)
        Next

        For Each aux_type In scooterType.ScooterTypeDAO.ScooterTypeList
            scooterType_listbox.Items.Add(aux_type.TypeID)
        Next
    End Sub

    Private Sub Clients_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clients_listbox.SelectedIndexChanged
        Dim client As Client = New Client With {.ClientId = clients_listbox.SelectedItem}
        If clients_listbox.SelectedIndex <> -1 Then
            Try
                client.Read()

                clientID_textbox.Text = client.ClientId
                clientName_textbox.Text = client.ClientName
                clientPhone_textbox.Text = client.TelephNumber
                clientAddress_textbox.Text = client.Address
                clientEmail_textbox.Text = client.Email
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Scooter_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scooter_listbox.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {.ScooterId = scooter_listbox.SelectedItem}
        If scooter_listbox.SelectedIndex <> -1 Then
            Try
                scooter.Read()

                scooterID_textbox.Text = Convert.ToString(scooter.ScooterId)
                scooterDescription_textbox.Text = scooter.Description
                scooter_type_textbox.Text = Convert.ToString(scooter.Type)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub ScooterType_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scooterType_listbox.SelectedIndexChanged
        Dim scooterType As ScooterType = New ScooterType With {.TypeID = scooterType_listbox.SelectedItem}
        If scooterType_listbox.SelectedIndex <> -1 Then
            Try
                scooterType.Read()

                scooterTypeID_textbox.Text = Convert.ToString(scooterType.TypeID)
                scooterTypeBrand_textbox.Text = scooterType.Brand
                scooterTypeWeight_textbox.Text = scooterType.MaxWeight
                scooterTypeSpeed_textbox.Text = scooterType.MaxSpeed
                scooterTypePrice_textbox.Text = scooterType.PricePerHou
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Clear(form As Object)
        If (form.Text = "Clients" Or form.Text = "Scooters" Or form.Text = "ScooterTypes") Then
            For Each control In form.Controls
                If TypeOf control Is TextBox Then
                    control.Text = Nothing
                ElseIf TypeOf control Is ListBox Then
                    control.SelectedItem = Nothing
                End If

                If TypeOf control Is RichTextBox Then
                    control.Text = Nothing
                End If
            Next control
        Else
            Clear(form.Parent)
        End If
    End Sub

    Private Function IsEmpty(form As Object) As Boolean
        Dim vacio As Boolean = False
        If (form.Text = "Clients" Or form.Text = "Scooters" Or form.Text = "ScooterTypes") Then
            For Each control In form.Controls
                If TypeOf control Is TextBox Then
                    If control.Text Like Nothing Then
                        Return True
                    End If
                ElseIf TypeOf control Is RichTextBox Then
                    If control.Text Like Nothing Then
                        Return True
                    End If
                End If
            Next control
        Else
            vacio = IsEmpty(form.Parent)
        End If
        Return vacio
    End Function

    Private Sub Clients_clear_button_Click(sender As Object, e As EventArgs) Handles clients_clear_button.Click
        Clear(sender)
    End Sub

    Private Sub Scooters_clear_button_Click(sender As Object, e As EventArgs) Handles scooters_clear_button.Click
        Clear(sender)
    End Sub

    Private Sub ScooterTypes_clear_button_Click(sender As Object, e As EventArgs) Handles scooterTypes_clear_button.Click
        Clear(sender)
    End Sub

    Private Sub Clients_modify_button_Click(sender As Object, e As EventArgs) Handles clients_modify_button.Click
        Dim client As Client

        If IsEmpty(sender) Then
            MessageBox.Show("To modify information, all fields must be fulfilled.")
        ElseIf clientPhone_textbox.Text.Length <> 9 Then
            MessageBox.Show("Telephon number must cointain 9 digits.")
        ElseIf clientID_textbox.Text Like clients_listbox.SelectedItem Then
            Try
                client = New Client(clientID_textbox.Text, clientName_textbox.Text, clientPhone_textbox.Text, clientAddress_textbox.Text, clientEmail_textbox.Text)
                client.Update()
                MessageBox.Show("Successfully modified.")

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        Else
            MessageBox.Show("The ID can't be modified.")
            clientID_textbox.Text = clients_listbox.SelectedItem
        End If
    End Sub

    Private Sub Clients_add_button_Click(sender As Object, e As EventArgs) Handles clients_add_button.Click
        Dim client As Client

        If IsEmpty(sender) Then
            MessageBox.Show("All fields must be fullfilled in order to add a new Client.")
        ElseIf clientID_textbox.Text.Length <> 9 Then
            MessageBox.Show("ID must contains 8 numbers followed by a letter from A to Z.")
        ElseIf clientPhone_textbox.Text.Length <> 9 Then
            MessageBox.Show("Telephon number must cointain 9 digits.")
        ElseIf clientID_textbox.Text Like "########[A-Z]" Then
            MessageBox.Show(clientEmail_textbox.Text)
            client = New Client(clientID_textbox.Text, clientName_textbox.Text, clientPhone_textbox.Text, clientAddress_textbox.Text, clientEmail_textbox.Text)

            Try
                client.Insert()
                clients_listbox.Items.Add(client.ClientId)
                MessageBox.Show("The information of that client has been added successfully.")
                Clients_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Clients_delete_button_Click(sender As Object, e As EventArgs) Handles clients_delete_button.Click
        Dim client As New Client

        If clientID_textbox.Text Like "" Then
            MessageBox.Show("At least ID field has to be fullfilled in order to delete a client.")
        ElseIf clientID_textbox.Text Like "########[A-Z]" Then
            client.ClientId = clientID_textbox.Text

            Try
                client.Delete()
                clients_listbox.Items.Remove(client.ClientId)
                MessageBox.Show("Successfully deleted")
                Clients_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        ElseIf clientID_textbox.Text.Length <> 9 Then
            MessageBox.Show("ID needs to contains 8 numbers followed by a letter from A to Z")
        End If
    End Sub

    Private Sub Scooters_modify_button_Click(sender As Object, e As EventArgs) Handles scooter_modify_button.Click
        Dim scooter As Scooter

        If scooterID_textbox.Text Like "" Or scooter_type_textbox.Text Like "" Then
            MessageBox.Show("To modify information, scooter id and scooter type has to be fullfilled.")
        ElseIf scooterID_textbox.Text Like scooter_listbox.SelectedItem Then
            Try
                scooter = New Scooter(Convert.ToInt32(scooterID_textbox.Text), Convert.ToString(scooterDescription_textbox.Text), Convert.ToInt32(scooter_type_textbox.Text))
                scooter.Update()
                MessageBox.Show("Successfully modified.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        Else
            MessageBox.Show("The ID can't be modified.")
            clientID_textbox.Text = clients_listbox.SelectedItem
        End If
    End Sub

    Private Sub Scooters_add_button_Click(sender As Object, e As EventArgs) Handles scooters_add_button.Click
        Dim client As Client

        If clientID_textbox.Text Like "" Or clientName_textbox.Text Like "" Then
            MessageBox.Show("All fields must be fullfilled in order to add a new Person.")
        ElseIf clientID_textbox.Text.Length <> 9 Then
            MessageBox.Show("ID must contains 8 numbers followed by a letter from A to Z.")
        ElseIf clientPhone_textbox.Text.Length <> 9 Then
            MessageBox.Show("Telephon number must cointain 9 digits.")
        ElseIf clientID_textbox.Text Like "########[A-Z]" Then
            MessageBox.Show(clientEmail_textbox.Text)
            client = New Client(clientID_textbox.Text, clientName_textbox.Text, clientPhone_textbox.Text, clientAddress_textbox.Text, clientEmail_textbox.Text)

            Try
                client.Insert()
                clients_listbox.Items.Add(client.ClientId)
                MessageBox.Show("The information of that client has been added successfully.")
                Clients_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Scooters_delete_button_Click(sender As Object, e As EventArgs) Handles scooters_delete_button.Click
        Dim client As New Client

        If clientID_textbox.Text Like "" Then
            MessageBox.Show("At least ID field has to be fullfilled in order to delete a client.")
        ElseIf clientID_textbox.Text Like "########[A-Z]" Then
            client.ClientId = clientID_textbox.Text

            Try
                client.Delete()
                clients_listbox.Items.Remove(client.ClientId)
                MessageBox.Show("Successfully deleted")
                Clients_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        ElseIf clientID_textbox.Text.Length <> 9 Then
            MessageBox.Show("ID needs to contains 8 numbers followed by a letter from A to Z")
        End If
    End Sub
End Class
