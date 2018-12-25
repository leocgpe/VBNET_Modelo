Namespace Events
    Public Class StoredEvent
        Inherits [Event]

        Public Property Id As Guid
        Public Property Data As String
        Public Property User As String

        Public Sub New(theEvent As [Event], data As String, user As String)
            Id = Guid.NewGuid()
            AggregateId = theEvent.AggregateId
            MessageType = theEvent.MessageType
            data = data
            user = user
        End Sub

        Protected Sub New()
        End Sub

    End Class
End Namespace

