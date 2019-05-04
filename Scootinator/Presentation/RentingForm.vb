Public Class RentingForm

    Private total As Integer

    Private Sub RentingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim client As Client = New Client
        Dim aux_client As Client

        Try
            client.ReadAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try

        For Each aux_client In client.ClientDAO.ClientList
            clients_listbox.Items.Add(aux_client.ClientId)
        Next
    End Sub

    Private Sub Clients_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clients_listbox.SelectedIndexChanged
        Dim client As Client = New Client With {.ClientId = clients_listbox.SelectedItem}
        If clients_listbox.SelectedIndex <> -1 Then
            Try
                client.Read()

                client_id.Text = client.ClientId
                client_name.Text = client.ClientName
                client_phone.Text = client.TelephNumber
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try

            DateTimePicker1.Enabled = True
            end_dateTime.Enabled = True
            begin_dateTime.Enabled = True
            check_scooters_button.Enabled = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        scooter_available_listbox.Enabled = False
        scooter_renting_listbox.Enabled = False
        add_scooter.Enabled = False
        remove_scooter.Enabled = False
        rent_button.Enabled = False
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles begin_dateTime.ValueChanged
        scooter_available_listbox.Enabled = False
        scooter_renting_listbox.Enabled = False
        add_scooter.Enabled = False
        remove_scooter.Enabled = False
        rent_button.Enabled = False
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles end_dateTime.ValueChanged
        scooter_available_listbox.Enabled = True
        scooter_renting_listbox.Enabled = True
        add_scooter.Enabled = True
        remove_scooter.Enabled = True
        rent_button.Enabled = True
    End Sub

    Private Sub Scooter_available_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scooter_available_listbox.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {.ScooterId = Convert.ToInt32(scooter_available_listbox.SelectedItem)}
        Dim scooterType As ScooterType



        If scooter_available_listbox.SelectedIndex <> -1 Then
            scooter_renting_listbox.SelectedIndex = -1
            Try
                scooter.Read()

                scooterType = New ScooterType With {.TypeID = scooter.Type}
                scooterType.Read()

                scooter_brand.Text = scooterType.Brand
                scooter_price.Text = Convert.ToString(scooterType.PricePerHou)
                scooter_speed.Text = Convert.ToString(scooterType.MaxSpeed)
                scooter_weight.Text = Convert.ToString(scooterType.MaxWeight)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Scooter_renting_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles scooter_renting_listbox.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {.ScooterId = Convert.ToInt32(scooter_renting_listbox.SelectedItem)}
        Dim scooterType As ScooterType

        If scooter_renting_listbox.SelectedIndex <> -1 Then
            scooter_available_listbox.SelectedIndex = -1
            Try
                scooter.Read()

                scooterType = New ScooterType With {.TypeID = scooter.Type}
                scooterType.Read()

                scooter_brand.Text = scooterType.Brand
                scooter_price.Text = Convert.ToString(scooterType.PricePerHou)
                scooter_speed.Text = Convert.ToString(scooterType.MaxSpeed)
                scooter_weight.Text = Convert.ToString(scooterType.MaxWeight)

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Add_scooter_Click(sender As Object, e As EventArgs) Handles add_scooter.Click
        Dim scooter As Scooter = New Scooter With {.ScooterId = Convert.ToInt32(scooter_available_listbox.SelectedItem)}
        Dim scooterType As ScooterType

        If scooter_available_listbox.SelectedIndex <> -1 Then
            Try
                scooter.Read()

                scooterType = New ScooterType With {.TypeID = scooter.Type}
                scooterType.Read()

                scooter_renting_listbox.Items.Add(scooter_available_listbox.SelectedItem)
                scooter_available_listbox.Items.Remove(scooter_available_listbox.SelectedItem)

                total = total + scooterType.PricePerHou * (end_dateTime.Value.Hour - begin_dateTime.Value.Hour)

                total_price.Text = Convert.ToString(total)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        Else
            MessageBox.Show("Select an available scooter in order to rent it.")
        End If
    End Sub

    Private Sub Remove_scooter_Click(sender As Object, e As EventArgs) Handles remove_scooter.Click
        Dim scooter As Scooter = New Scooter With {.ScooterId = Convert.ToInt32(scooter_renting_listbox.SelectedItem)}
        Dim scooterType As ScooterType

        If scooter_renting_listbox.SelectedIndex <> -1 Then
            Try
                scooter.Read()

                scooterType = New ScooterType With {.TypeID = scooter.Type}
                scooterType.Read()

                scooter_available_listbox.Items.Add(scooter_renting_listbox.SelectedItem)
                scooter_renting_listbox.Items.Remove(scooter_renting_listbox.SelectedItem)

                total = total - scooterType.PricePerHou * (end_dateTime.Value.Hour - begin_dateTime.Value.Hour)

                total_price.Text = Convert.ToString(total)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        Else
            MessageBox.Show("Select a rented scooter in order to remove it.")
        End If
    End Sub

    Private Sub Rent_button_Click(sender As Object, e As EventArgs) Handles rent_button.Click
        Dim booking As Booking
        Dim aux As Scooter = New Scooter

        If scooter_renting_listbox.Items.Count = 0 Then
            MessageBox.Show("In order to book scooters, at least one scooter has to be rented.")
        Else
            booking = New Booking(begin_dateTime.Value, end_dateTime.Value, client_id.Text, DateTimePicker1.Value, Convert.ToInt32(total_price.Text))

            Try
                booking.Insert()

                booking.Read()
                For Each scooterID In scooter_renting_listbox.Items
                    aux.ScooterId = scooterID
                    aux.CreateRental(booking)
                Next

                MessageBox.Show("Booking successfully done.")
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try

            scooter_available_listbox.Items.Clear()
            scooter_renting_listbox.Items.Clear()
            scooter_brand.Text = Nothing
            scooter_price.Text = Nothing
            scooter_speed.Text = Nothing
            scooter_weight.Text = Nothing
            total_price.Text = 0
            scooter_available_listbox.Enabled = False
            scooter_renting_listbox.Enabled = False
            add_scooter.Enabled = False
            remove_scooter.Enabled = False
            rent_button.Enabled = False
        End If
    End Sub

    Private Sub Clear(form As Object)
        If form.Text = "Renting" Then
            For Each control In form.Controls
                If TypeOf control Is TextBox Then
                    control.Text = Nothing
                ElseIf TypeOf control Is ListBox Then
                    control.SelectedItem = Nothing
                End If
            Next control
        Else
            Clear(form.Parent)
        End If
    End Sub

    Private Sub Check_scooters_Click(sender As Object, e As EventArgs) Handles check_scooters_button.Click
        Dim aux As Booking = New Booking

        scooter_available_listbox.Items.Clear()
        scooter_renting_listbox.Items.Clear()

        If begin_dateTime.Value <= tab_endDate.Value Then
            MessageBox.Show("Beginning hour cannot be equals or above the ending hour.")
        Else
            Try
                aux.FreeScooters(begin_dateTime.Value, end_dateTime.Value, DateTimePicker1.Value)

                scooter_available_listbox.Enabled = True
                scooter_renting_listbox.Enabled = True
                add_scooter.Enabled = True
                remove_scooter.Enabled = True
                rent_button.Enabled = True

                For Each scooter In aux.ScooterList
                    scooter_available_listbox.Items.Add(scooter)
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tab_panel.SelectedTab.Text Like "Clients" Then
            tab_clients_listbox.Items.Clear()
            Dim client As Client = New Client
            Try
                client.ClientsHistory(tab_beginDate.Value, tab_endDate.Value)

                For Each aux In client.ClientDAO.ClientList
                    tab_clients_listbox.Items.Add(aux.ClientID)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        ElseIf tab_panel.SelectedTab.Text Like "Scooters" Then
            Dim aux As Booking = New Booking
            tab_scooters_listbox.Items.Clear()
            Try
                aux.HistoryScooters(tab_beginDate.Value, tab_endDate.Value)

                For Each scooter In aux.ScooterList
                    tab_scooters_listbox.Items.Add(scooter)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        ElseIf tab_panel.SelectedTab.Text Like "Ranking" Then
            Dim aux As ScooterType = New ScooterType

            Try
                aux.Ranking(tab_beginDate.Value, tab_endDate.Value)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try

            For Each scooterType In aux.ScooterTypeDAO.ScooterTypeList
                ranking_listbox.Items.Add(scooterType)
            Next


        End If
    End Sub

    Private Sub Tab_scooters_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tab_scooters_listbox.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {.ScooterId = Convert.ToInt32(tab_scooters_listbox.SelectedItem)}
        Dim scooterType As ScooterType
        Dim client As Client = New Client

        ListBox2.Items.Clear()
        Label27.Text = Nothing
        Label28.Text = Nothing

        If tab_scooters_listbox.SelectedIndex <> -1 Then
            Try
                scooter.Read()

                tab_scooterID.Text = Convert.ToString(scooter.ScooterId)
                tab_scooterDescription.Text = scooter.Description

                scooterType = New ScooterType With {.TypeID = scooter.Type}
                scooterType.Read()

                tab_scooterBrand.Text = scooterType.Brand
                tab_scooterPrice.Text = Convert.ToString(scooterType.PricePerHou)
                tab_scooterSpeed.Text = Convert.ToString(scooterType.MaxSpeed)
                tab_scooterWeight.Text = Convert.ToString(scooterType.MaxWeight)
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try

            Try
                client.ClientsRentedScooter(scooter, tab_beginDate.Value, tab_endDate.Value)

                For Each aux In client.ClientDAO.ClientList
                    ListBox2.Items.Add(aux.ClientID)
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Tab_Scooters_Selection()

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim client As Client = New Client With {.ClientId = ListBox2.SelectedItem}

        If ListBox2.SelectedIndex <> -1 Then
            Try
                client.Read()

                Label28.Text = client.ClientId
                Label27.Text = client.ClientName
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub tab_clients_listbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tab_clients_listbox.SelectedIndexChanged
        Dim client As Client = New Client With {.ClientId = tab_clients_listbox.SelectedItem}
        Dim scooter As Scooter = New Scooter

        ListBox3.Items.Clear()
        Label24.Text = Nothing
        Label25.Text = Nothing
        RichTextBox2.Text = Nothing

        If tab_clients_listbox.SelectedIndex <> -1 Then
            Try
                client.Read()

                tab_clientId.Text = client.ClientId
                tab_clientName.Text = client.ClientName
                tab_clientEmail.Text = client.Email
                tab_clientPhone.Text = client.TelephNumber
                tab_clientAddress.Text = client.Address
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try

            Try
                scooter.ScooterRented(client, tab_beginDate.Value, tab_endDate.Value)

                For Each aux In scooter.ScooterDAO.ScooterList
                    ListBox3.Items.Add(aux.scooterId)
                Next
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim scooter As Scooter = New Scooter With {.ScooterId = ListBox3.SelectedItem}

        If ListBox3.SelectedIndex <> -1 Then
            Try
                scooter.Read()

                Label24.Text = scooter.ScooterId
                Label25.Text = scooter.Type
                RichTextBox2.Text = scooter.Description
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub

    Private Sub Ranking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ranking_listbox.SelectedIndexChanged
        Dim scooter_type As ScooterType = New ScooterType With {.TypeID = ranking_listbox.SelectedItem}

        If ranking_listbox.SelectedIndex <> -1 Then
            Try
                scooter_type.Read()

                Label57.Text = scooter_type.TypeID
                Label61.Text = scooter_type.Brand
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source)
            End Try
        End If
    End Sub
End Class