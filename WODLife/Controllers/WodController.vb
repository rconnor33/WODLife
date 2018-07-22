Imports System.Web.Mvc
Imports Microsoft.AspNet.Identity

Namespace Controllers
    Public Class WodController
        Inherits Controller

        ' GET: Wod
        Function Index() As ActionResult

            Return View()
        End Function

        ' GET: Wod/Details
        Function Details() As ActionResult
            Dim db As New ApplicationDbContext
            'Dim wodObj As New Wod
            'wodObj.wodID = 1
            'wodObj.wodName = "Helen"
            Return View(db.Wods)
        End Function

        ' GET: Wod/Create
        Function Create() As ActionResult
            Dim db As New ApplicationDbContext()
            'ViewBag.wodTypeID = New SelectList(db.WodTypes, "WodTypeID", "WodType")
            Dim Items As IEnumerable(Of SelectListItem)
            Items = db.WodTypes.Select(Function(c) New SelectListItem() With {.Value = c.wodTypeID, .Text = c.wodType})
            'ViewBag.WodTypeItems = Items
            ViewBag.WodTypeItems = New SelectList(db.WodTypes, "wodTypeID", "wodType")
            Return View()
        End Function

        ' POST: Wod/Create
        'Function Create(ByVal collection As FormCollection) As ActionResult
        <HttpPost>
        Function Create(ByVal model As Wod) As ActionResult
            Try
                ' TODO: Add insert logic here
                'initialise the DB connection
                Dim db As New ApplicationDbContext()
                'get Uer object for ID
                Dim userId = User.Identity.GetUserId()
                'create WOD object to send to DB
                Dim wod As New Wod()
                wod.wodName = model.wodName
                wod.ApplicationUserID = userId
                wod.wodDescription = model.wodDescription
                'ViewBag.GenderID = New SelectList(db.Genders, "GenderID", "GenderName")
                wod.wodTypeID = model.wodTypeID
                ' wod.wodType = model.wodType
                wod.wodNotes = model.wodNotes
                db.Wods.Add(wod)
                db.SaveChanges()

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