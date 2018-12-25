Imports MediatR
Imports System.Threading

Namespace Notifications
    Public Class DomainNotificationHandler
        Implements INotificationHandler(Of DomainNotification)

        Private _notifications As List(Of DomainNotification)

        Public Sub New()
            _notifications = New List(Of DomainNotification)()
        End Sub

        Public Overridable Function GetNotifications() As List(Of DomainNotification)
            Return _notifications
        End Function

        Public Overridable Function HasNotifications() As Boolean
            Return _notifications.Any()
        End Function

        Public Sub Dispose()
            _notifications = New List(Of DomainNotification)()
        End Sub

        Public Function Handle(notification As DomainNotification, cancellationToken As CancellationToken) As Task Implements INotificationHandler(Of DomainNotification).Handle
            _notifications.Add(notification)
            Return Task.CompletedTask
        End Function
    End Class
End Namespace

