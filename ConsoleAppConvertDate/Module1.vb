Module Module1
  Sub Main()
    Dim prj_date_deb_from_db As String = "03-01-2000"
    Dim prj_date_deb_as_date As Date
    Dim allDateAreOk As Boolean = True
    Dim finalDate As Date
    Dim formatDate() As String = {"dd/MM/yyyy", "dd-MM-yyyy"}
    If prj_date_deb_from_db = "unknown" Or prj_date_deb_from_db.StartsWith("ko") Then
      allDateAreOk = False
    Else
      If Date.TryParseExact(prj_date_deb_from_db, formatDate, Globalization.CultureInfo.GetCultureInfo("fr-FR"), Globalization.DateTimeStyles.AssumeLocal, prj_date_deb_as_date) Then
        finalDate = prj_date_deb_as_date
      Else
        allDateAreOk = False
      End If
    End If

    Console.WriteLine($"La date finale est : {finalDate.ToShortDateString()}")
    Console.WriteLine("Appuyez sur une touche pour continuer...")
    Console.ReadKey()
  End Sub
End Module
