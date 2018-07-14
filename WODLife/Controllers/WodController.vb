Imports System.Web.Mvc

Namespace Controllers
    Public Class WodController
        Inherits Controller

        ' GET: Wod
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Wod/Details
        Function Details() As ActionResult
            Dim wodObj As New Wod
            wodObj.wodID = 1
            wodObj.wodName = "Helen"
            Return View(wodObj)
        End Function

        ' GET: Wod/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Wod/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Wod/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Wod/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Wod/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Wod/Delete/5
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