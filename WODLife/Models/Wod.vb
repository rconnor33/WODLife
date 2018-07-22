
Imports System.ComponentModel.DataAnnotations

Public Class Wod
    Private wodIDvalue As Integer
    <Key>
    Public Property wodID() As Integer
        Get
            Return wodIDvalue
        End Get
        Set(ByVal value As Integer)
            wodIDvalue = value
        End Set
    End Property

    Private wodNameValue As String
    '<Required(ErrorMessage:="Please enter a name for this WOD")>
    <Display(Name:="WOD Name")>
    Public Property wodName() As String
        Get
            Return wodNameValue
        End Get
        Set(ByVal value As String)
            wodNameValue = value
        End Set
    End Property

    Private wodDescriptionValue As String
    '<Required(ErrorMessage:="You must provide details of the WOD")>
    <Display(Name:="WOD Details")>
    Public Property wodDescription() As String
        Get
            Return wodDescriptionValue
        End Get
        Set(ByVal value As String)
            wodDescriptionValue = value
        End Set
    End Property

    Private wodNotesValue As String
    <Display(Name:="Extra Notes")>
    Public Property wodNotes() As String
        Get
            Return wodNotesValue
        End Get
        Set(ByVal value As String)
            wodNotesValue = value
        End Set
    End Property

    Private wodTypeIDValue As Integer
    <Display(Name:="WOD Type ID")>
    Public Property wodTypeID() As Integer
        Get
            Return wodTypeIDValue
        End Get
        Set(ByVal value As Integer)
            wodTypeIDValue = value
        End Set
    End Property

    Private wodTypeValue As WodType
    ' <Required(ErrorMessage:="Is this WOD an AMRAP, RFT or Strength type?")>
    <Display(Name:="WOD Type")>
    Public Property wodType() As WodType
        Get
            Return wodTypeValue
        End Get
        Set(ByVal value As WodType)
            wodTypeValue = value
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
