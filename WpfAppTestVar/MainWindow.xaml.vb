Imports ClassLibraryModel

Class MainWindow
  Private Sub ClickMeButton_Click(sender As Object, e As RoutedEventArgs)
    Application.startDate = New Date(2000, 1, 1)
    Application.endDate = New Date(2099, 12, 31)
    Class1.startDate = Application.startDate
    Class1.endDate = Application.endDate
    Dim c1 As New Class1()
    StartDate.Content = Class1.startDate.ToShortDateString()
    EndDate.Content = Class1.endDate.ToShortDateString()
    Forms.Application.DoEvents()

    MessageBox.Show($"La start date de la classe1 est : {Class1.startDate.ToShortDateString()} et {Environment.NewLine}la end date de la classe1 est {Class1.endDate.ToShortDateString}")
  End Sub
End Class
