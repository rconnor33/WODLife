Public Class HomeController
    Inherits System.Web.Mvc.Controller

    'GET /home/index
    Function Index() As ActionResult
        Return View()
    End Function

    'GET /home/about
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        'ViewData("Message") = "Your contact page."
        ViewBag.TheMessage = "Having trouble? Send us a message."

        Return View()
    End Function
    <HttpPost>
    Function Contact(message As String) As ActionResult
        ViewBag.TheMessage = "Thank you for your message."

        Return View()
    End Function

    Function Serial(letterCase As String) As ActionResult
        Dim serialNo As String = "MVCSTR2345"
        If letterCase = "lower" Then
            Return Content(serialNo.ToLower())
        Else
            Return Content(serialNo)
        End If

    End Function
End Class
