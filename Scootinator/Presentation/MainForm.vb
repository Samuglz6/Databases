Public Class MainForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim manageForm As New ManagementForm
        manageForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rentForm As New RentingForm
        rentForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectForm As New ConnectionForm
        connectForm.Show()
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