Public Class ConnectionForm
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try


        Dispose()
    End Sub

    Private Sub SetConnected()
        MainForm.Button1.Enabled = False
        MainForm.Button1.Visible = False
        MainForm.Button2.Enabled = True
        MainForm.Button3.Enabled = True
        MainForm.Label2.Text = "Connected"
        MainForm.Label2.ForeColor = Color.Green
    End Sub
End Class