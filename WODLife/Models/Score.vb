Imports System.ComponentModel.DataAnnotations
Public Class Score
    Private scoreIDValue As Integer
    <Key>
    Public Property scoreID() As Integer
        Get
            Return scoreIDValue
        End Get
        Set(ByVal value As Integer)
            scoreIDValue = value
        End Set
    End Property

    Private UserValue As ApplicationUser
    Public Property User() As ApplicationUser
        Get
            Return UserValue
        End Get
        Set(ByVal value As ApplicationUser)
            UserValue = value
        End Set
    End Property

    Private userIDValue As Integer
    Public Property userID() As Integer
        Get
            Return userIDValue
        End Get
        Set(ByVal value As Integer)
            userIDValue = value
        End Set
    End Property

    Private wodValue As Wod
    Public Property Wod() As Wod
        Get
            Return wodValue
        End Get
        Set(ByVal value As Wod)
            wodValue = value
        End Set
    End Property

    Private wodIDValue As Integer
    Public Property wodID() As Integer
        Get
            Return wodIDValue
        End Get
        Set(ByVal value As Integer)
            wodIDValue = value
        End Set
    End Property

    Private scalingNotesValue As String
    Public Property scalingNotes() As String
        Get
            Return scalingNotesValue
        End Get
        Set(ByVal value As String)
            scalingNotesValue = value
        End Set
    End Property

    Private scoreDateValue As Date
    <Required>
    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}")>
    Public Property scoreDate() As Date
        Get
            Return scoreDateValue
        End Get
        Set(ByVal value As Date)
            scoreDateValue = value
        End Set
    End Property

    'Score for AMRAPS = Rounds and Reps
    Private scoreRoundsValue As Integer
    Public Property scoreRounds() As Integer
        Get
            Return scoreRoundsValue
        End Get
        Set(ByVal value As Integer)
            scoreRoundsValue = value
        End Set
    End Property

    Private scoreRepsValue As Integer
    Public Property scoreReps() As Integer
        Get
            Return scoreRepsValue
        End Get
        Set(ByVal value As Integer)
            scoreRepsValue = value
        End Set
    End Property

    Private scoreTimeValue As DateTime
    Public Property scoreTime() As DateTime
        Get
            Return scoreTimeValue
        End Get
        Set(ByVal value As DateTime)
            scoreTimeValue = value
        End Set
    End Property

    Private scoreWeightValue As Decimal
    Public Property scoreWeight() As Decimal
        Get
            Return scoreWeightValue
        End Get
        Set(ByVal value As Decimal)
            scoreWeightValue = value
        End Set
    End Property
End Class
