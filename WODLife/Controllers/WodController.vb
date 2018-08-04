Imports System.Data.Entity
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
            Dim wodObjs = db.Wods.ToList
            Dim wodTypes = db.WodTypes.ToList

            Dim vmWod = New WodViewModel()
            vmWod.WodList = wodObjs
            vmWod.WodTypeList = wodTypes

            Return View(vmWod)
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
            Dim db As New ApplicationDbContext
            Dim editWodObj As Wod = db.Wods.Find(id)

            'get and populate the dropdown list for WOD types from the DB
            Dim Items As IEnumerable(Of SelectListItem)
            Items = db.WodTypes.Select(Function(c) New SelectListItem() With {.Value = c.wodTypeID, .Text = c.wodType})
            ViewBag.WodTypeItems = New SelectList(db.WodTypes, "wodTypeID", "wodType")

            Return View(editWodObj)
        End Function

        ' POST: Wod/Edit/5

        'Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        <HttpPost()>
        Function Edit(<Bind(Include:="wodID,ApplicationUserID,wodName,wodTypeID,wodDescription,wodNotes")> ByVal wod As Wod) As ActionResult
            Try
                ' TODO: Add update logic here
                'initialise the DB connection
                Dim db As New ApplicationDbContext()
                'get Uer object for ID
                'Dim editWodObj As Wod = db.Wods.Find(id)
                'create WOD object to send to DB
                'editWodObj.wodName = collection.Item.
                'editWodObj.ApplicationUserID = userId
                'editWodObj.wodDescription = model.wodDescription
                'ViewBag.GenderID = New SelectList(db.Genders, "GenderID", "GenderName")
                'editWodObj.wodTypeID = model.wodTypeID
                ' wod.wodType = model.wodType
                'editWodObj.wodNotes = model.wodNotes
                db.Entry(wod).State = EntityState.Modified

                db.SaveChanges()


                Return RedirectToAction("Details")
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