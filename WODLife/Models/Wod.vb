
Imports System.ComponentModel.DataAnnotations

Public Class Wod
    Private wodIDvalue As Integer
    Public Property wodID() As Integer
        Get
            Return wodIDvalue
        End Get
        Set(ByVal value As Integer)
            wodIDvalue = value
        End Set
    End Property

    Private wodNameValue As String
    <Required(ErrorMessage:="Please enter a anme for this WOD")>
    <Display(Name:="WOD Name")>
    Public Property wodName() As String
        Get
            Return wodNameValue
        End Get
        Set(ByVal value As String)
            wodNameValue = value
        End Set
    End Property

    Private UserValue As ApplicationUser
    Public Overridable Property User() As ApplicationUser
        Get
            Return UserValue
        End Get
        Set(ByVal value As ApplicationUser)
            UserValue = value
        End Set
    End Property

    Private ApplicationUserIDValue As String
    Public Property ApplicationUserID() As String
        Get
            Return ApplicationUserIDValue
        End Get
        Set(ByVal value As String)
            ApplicationUserIDValue = value
        End Set
    End Property
End Class
