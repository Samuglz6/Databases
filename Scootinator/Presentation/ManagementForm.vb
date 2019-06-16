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
                    If control.Name Like "clientAddress_textbox" Then
                        Return False
                    ElseIf control.Text Like Nothing Then
                        Return True
                    End If
                ElseIf TypeOf control Is RichTextBox Then
                    If control.Text Like Nothing Then
                        Return False
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
            MessageBox.Show("To modify information, all fields except address must be filled.")
        ElseIf clientPhone_textbox.Text.Length <> 9 Or Not IsNumeric(clientPhone_textbox.Text) Then
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
            MessageBox.Show("All fields except address must be filled in order to add a new Client.")
        ElseIf clientID_textbox.Text.Length <> 9 Then
            MessageBox.Show("ID must contains 8 numbers followed by a letter from A to Z.")
        ElseIf clientPhone_textbox.Text.Length <> 9 Or Not IsNumeric(clientPhone_textbox.Text) Then
            MessageBox.Show("Telephon number must cointain 9 digits.")
        ElseIf clientID_textbox.Text.ToUpper Like "########[A-Z]" Then
            client = New Client(clientID_textbox.Text.ToUpper, clientName_textbox.Text, clientPhone_textbox.Text, clientAddress_textbox.Text, clientEmail_textbox.Text)
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
            MessageBox.Show("At least ID field has to be filled in order to delete a client.")
        ElseIf clientID_textbox.Text.ToUpper Like "########[A-Z]" Then
            client.ClientId = clientID_textbox.Text.ToUpper

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

        If IsEmpty(sender) Then
            MessageBox.Show("To modify information, scooter id and scooter type has to be filled.")
        ElseIf Not IsNumeric(scooter_type_textbox.Text) Or Not IsNumeric(scooterID_textbox.Text) Then
            MessageBox.Show("Scooter id nor scooter type can contain characters.")
        ElseIf Not CheckType(scooter_type_textbox.Text) Then
            MessageBox.Show("Scooter type has to be one of the existing types.")
        ElseIf scooterID_textbox.Text Like scooter_listbox.SelectedItem Then
            Try
                scooter = New Scooter(Convert.ToInt32(scooterID_textbox.Text), scooterDescription_textbox.Text, Convert.ToInt32(scooter_type_textbox.Text))
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
        Dim scooter As Scooter

        If IsEmpty(sender) Then
            MessageBox.Show("All fields except description must be filled in order to add a new Scooter.")
        ElseIf Not IsNumeric(scooter_type_textbox.Text) Or Not IsNumeric(scooterID_textbox.Text) Then
            MessageBox.Show("Scooter id nor scooter type can contain characters.")
        ElseIf Not CheckType(scooter_type_textbox.Text) Then
            MessageBox.Show("Scooter type has to be one of the existing types.")
        Else
            scooter = New Scooter(Convert.ToInt32(scooterID_textbox.Text), scooterDescription_textbox.Text, Convert.ToInt32(scooter_type_textbox.Text))
            Try
                scooter.Insert()
                scooter_listbox.Items.Add(scooter.ScooterId)
                MessageBox.Show("The information of that scooter has been added successfully.")
                Scooters_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Scooters_delete_button_Click(sender As Object, e As EventArgs) Handles scooters_delete_button.Click
        Dim scooter As New Scooter

        If scooterID_textbox.Text Like "" Then
            MessageBox.Show("At least ID field has to be filled in order to delete a Scooter.")
        Else
            scooter.ScooterId = Convert.ToInt32(scooterID_textbox.Text)
            Try
                scooter.Delete()
                scooter_listbox.Items.Remove(scooter.ScooterId)
                MessageBox.Show("Successfully deleted")
                Scooters_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub ScooterTypes_add_button_Click(sender As Object, e As EventArgs) Handles scooterTypes_add_button.Click
        Dim scooterType As ScooterType

        If IsEmpty(sender) Then
            MessageBox.Show("All fields except description must be filled in order to add a new Scooter Type.")
        ElseIf Not isNumeric(scooterTypeID_textbox.Text) Or Not IsNumeric(scooterTypeWeight_textbox.Text) Or Not IsNumeric(scooterTypeSpeed_textbox.Text) Or Not IsNumeric(scooterTypePrice_textbox.Text) Then
            MessageBox.Show("ID, Speed, Weight nor Price can contain characters, only numbers")
        Else
            scooterType = New ScooterType(Convert.ToInt32(scooterTypeID_textbox.Text), Convert.ToString(scooterTypeBrand_textbox.Text), Convert.ToInt32(scooterTypeWeight_textbox.Text), Convert.ToInt32(scooterTypeSpeed_textbox.Text), Convert.ToInt32(scooterTypePrice_textbox.Text))

                Try
                    scooterType.Insert()
                    scooterType_listbox.Items.Add(scooterType.TypeID)
                    MessageBox.Show("The information of that Scooter type has been added successfully.")
                    ScooterTypes_clear_button_Click(sender, e)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub ScooterTypes_modify_button_Click(sender As Object, e As EventArgs) Handles scooterTypes_modify_button.Click
        Dim scooterType As ScooterType

        If IsEmpty(sender) Then
            MessageBox.Show("To modify information, scooter id and scooter type has to be filled.")
        ElseIf scooterTypeID_textbox.Text Like scooterType_listbox.SelectedItem Then
            Try
                scooterType = New ScooterType(Convert.ToInt32(scooterTypeID_textbox.Text), Convert.ToString(scooterTypeBrand_textbox.Text), Convert.ToInt32(scooterTypeWeight_textbox.Text), Convert.ToInt32(scooterTypeSpeed_textbox.Text), Convert.ToInt32(scooterTypePrice_textbox.Text))
                scooterType.Update()
                MessageBox.Show("Successfully modified.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        Else
            MessageBox.Show("The ID can't be modified.")
            scooterTypeID_textbox.Text = scooterType_listbox.SelectedItem
        End If
    End Sub

    Private Sub ScooterTypes_delete_button_Click(sender As Object, e As EventArgs) Handles scooterTypes_delete_button.Click
        Dim scooterType As New ScooterType

        If scooterTypeID_textbox.Text Like "" Then
            MessageBox.Show("In order to delete a scooterType id has to be filled")
        Else
            scooterType.TypeID = scooterTypeID_textbox.Text
            Try
                scooterType.Delete()
                scooterType_listbox.Items.Remove(scooterType.TypeID)
                MessageBox.Show("Successfully deleted")
                ScooterTypes_clear_button_Click(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Function CheckType(type As Integer)
        Dim found As Boolean = False

        For Each aux In scooterType_listbox.Items
            If type = aux Then
                found = True
            End If
        Next

        Return found
    End Function
End Class
