Imports MediatR

Namespace Events
    Public MustInherit Class [Event]
        Inherits Message
        Implements INotification

        Public Property Timestamp As DateTime

        Protected Sub New()
            Timestamp = DateTime.Now
        End Sub
    End Class
End Namespace

