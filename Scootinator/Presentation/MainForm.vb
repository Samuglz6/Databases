Public Class MainForm
    Private Sub SelectPath_button_Click(sender As Object, e As EventArgs) Handles selectPath_button.Click
        Dim browser As New OpenFileDialog
        browser.Filter = "AccessFile|*.accdb"

        If (browser.ShowDialog() = DialogResult.OK) Then
            dbPath_Text.Text = browser.FileName
            connect_button.Enabled = True
        End If
    End Sub

    Private Sub Connect_button_Click(sender As Object, e As EventArgs) Handles connect_button.Click
        Try
            DBBroker.GetBroker(dbPath_Text.Text)
            SetConnected()
            selectPath_button.Enabled = False
            connect_button.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try
    End Sub

    Private Sub SetConnected()
        Button2.Enabled = True
        Button3.Enabled = True
        Label2.Text = "Connected"
        Label2.ForeColor = Color.Green
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim manageForm As New ManagementForm
        manageForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rentForm As New RentingForm
        rentForm.Show()
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            DBBroker.GetBroker.DisconnectDB()
            MessageBox.Show("Disconected from the database.")
        Catch
        End Try
        MessageBox.Show("See you soon!")
    End Sub
End Class