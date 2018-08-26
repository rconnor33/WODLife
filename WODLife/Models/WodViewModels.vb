Imports System.ComponentModel.DataAnnotations
Public Class WodViewModel
    Private wodListValue As List(Of Wod)
    Public Property WodList() As List(Of Wod)
        Get
            Return wodListValue
        End Get
        Set(ByVal value As List(Of Wod))
            wodListValue = value
        End Set
    End Property

    Private wodTypeListValue As List(Of WodType)
    Public Property WodTypeList() As List(Of WodType)
        Get
            Return wodTypeListValue
        End Get
        Set(ByVal value As List(Of WodType))
            wodTypeListValue = value
        End Set
    End Property

    Private wodScoreListValue As List(Of Score)
    Public Property wodScoreList() As List(Of Score)
        Get
            Return wodScoreListValue
        End Get
        Set(ByVal value As List(Of Score))
            wodScoreListValue = value
        End Set
    End Property
End Class
