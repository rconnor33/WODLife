Imports System.ComponentModel.DataAnnotations
Public Class WodType
    Private wodTypeValue As String
    Public Property wodType() As String
        Get
            Return wodTypeValue
        End Get
        Set(ByVal value As String)
            wodTypeValue = value
        End Set
    End Property

    Private wodTypeIDValue As Integer
    <Key>
    Public Property wodTypeID() As Integer
        Get
            Return wodTypeIDValue
        End Get
        Set(ByVal value As Integer)
            wodTypeIDValue = value
        End Set
    End Property
End Class
