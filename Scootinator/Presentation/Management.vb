Public Class Management
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim form As Connection = New Connection
        form.ShowDialog(Me)

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
                scooterType_textBox.Text = Convert.ToString(scooter.Type)
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
            MessageBox.Show(form.ToString)
            For Each control In form.Controls
                MessageBox.Show(form.ToString)
                If TypeOf control Is TextBox Then
                    If control.Text = Nothing Then
                        MessageBox.Show(control.ToString)
                        vacio = True
                    End If
                ElseIf TypeOf control Is RichTextBox Then
                    If control.Text = Nothing Then
                        MessageBox.Show(control.ToString)
                        vacio = True
                    End If
                End If
            Next control
        Else
            Clear(form.Parent)
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

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        DBBroker.GetBroker.DisconnectDB()
        MessageBox.Show("Disconected from the database.")
        MessageBox.Show("See you soon!")
    End Sub

    Private Sub Clients_modify_button_Click(sender As Object, e As EventArgs) Handles clients_modify_button.Click
        Dim client As Client

        'IsEmpty(sender)
        'MessageBox.Show("To modify information, all fields must be fulfilled.")
        'ElseIf personId_txt.Text Like listbox_1.SelectedItem Then
        '   Try
        '  client = New Client()
        ' client.Update()
        'MessageBox.Show("Successfully modified.")
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, ex.Source)
        'End Try
        'Else
        ' MessageBox.Show("The ID can't be modified.")
        'personId_txt.Text = listbox_1.SelectedItem
        ' Else
        'MessageBox.Show("Success")
        'End If
    End Sub


End Class
