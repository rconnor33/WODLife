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

    'remove when finished with
    Function TestCreate() As ActionResult
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

    <HttpPost()>
    Function GetDefault(ByVal val As Integer?) As ActionResult
        If Not IsDBNull(val) Then
            'Values are hard coded for demo. you may replae with values 
            'coming from your db/service based on the passed in value ( val.Value)

            Return Json(New With {.Success = "true", .Data = New With {.Width = 234, .Height = 345}})
        Else
            Return Json(New With {.Success = "false"})
        End If
    End Function
End Class
