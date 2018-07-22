Imports System.Data.Entity
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin

' You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
Public Class ApplicationUser
    Inherits IdentityUser
    Public Async Function GenerateUserIdentityAsync(manager As UserManager(Of ApplicationUser)) As Task(Of ClaimsIdentity)
        ' Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        Dim userIdentity = Await manager.CreateIdentityAsync(Me, DefaultAuthenticationTypes.ApplicationCookie)
        ' Add custom user claims here
        Return userIdentity
    End Function
End Class

Public Class ApplicationDbContext
    Inherits IdentityDbContext(Of ApplicationUser)
    Public Sub New()
        MyBase.New("DefaultConnection", throwIfV1Schema:=False)
    End Sub

    Public Shared Function Create() As ApplicationDbContext
        Return New ApplicationDbContext()
    End Function

    Private WodsValue As DbSet(Of Wod)
    Public Property Wods() As DbSet(Of Wod)
        Get
            Return WodsValue
        End Get
        Set(ByVal value As DbSet(Of Wod))
            WodsValue = value
        End Set
    End Property

    Private wodTypesValue As DbSet(Of WodType)
    Public Property WodTypes() As DbSet(Of WodType)
        Get
            Return wodTypesValue
        End Get
        Set(ByVal value As DbSet(Of WodType))
            wodTypesValue = value
        End Set
    End Property

    Private wodScoresValue As DbSet(Of Score)
    Public Property wodScores() As DbSet(Of Score)
        Get
            Return wodScoresValue
        End Get
        Set(ByVal value As DbSet(Of Score))
            wodScoresValue = value
        End Set
    End Property

End Class
