Imports MediatR

Namespace Events
    Public Class Message
        Implements IRequest

        Public Property MessageType As String
        Public Property AggregateId As Guid

        Protected Sub New()
            MessageType = [GetType]().Name
        End Sub
    End Class
End Namespace
