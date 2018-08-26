Imports System.Web.Mvc

Namespace Models
    Public Class TestController
        Inherits Controller

        ' GET: Test
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Test/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Test/TestCreate
        Function TestCreate() As ActionResult
            Dim vm As New TestViewModel
            vm.Widgets = New List(Of SelectListItem)
            vm.Widgets.Add(New SelectListItem With {.Value = "1", .Text = "Weather"})
            vm.Widgets.Add(New SelectListItem With {.Value = "2", .Text = "Messages"})

            Return View(vm)
        End Function

        ' POST: Test/TestCreate
        <HttpPost()>
        Function TestCreate(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
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

        ' GET: Test/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Test/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Test/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Test/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace