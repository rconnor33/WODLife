Public Class TestViewModel
    Private widthValue As Integer
    Public Property Width() As Integer
        Get
            Return widthValue
        End Get
        Set(ByVal value As Integer)
            widthValue = value
        End Set
    End Property

    Private heightValue As Integer
    Public Property Height() As Integer
        Get
            Return heightValue
        End Get
        Set(ByVal value As Integer)
            heightValue = value
        End Set
    End Property

    Private widgetsValue As List(Of SelectListItem)
    Public Property Widgets() As List(Of SelectListItem)
        Get
            Return widgetsValue
        End Get
        Set(ByVal value As List(Of SelectListItem))
            widgetsValue = value
        End Set
    End Property

    Private selectedWidgetValue As Integer?
    Public Property SelectedWidget() As Integer?
        Get
            Return selectedWidgetValue
        End Get
        Set(ByVal value As Integer?)
            selectedWidgetValue = value
        End Set
    End Property

End Class
