Imports System.Threading
Imports MediatR

Namespace Categorias.Events
    Public Class CategoriaEventHandler
        Implements INotificationHandler(Of CategoriaRegistradaEvent)

        Public Function INotificationHandler_Handle(notification As CategoriaRegistradaEvent, cancellationToken As CancellationToken) _
            As Task Implements INotificationHandler(Of CategoriaRegistradaEvent).Handle

            Return Task.CompletedTask
        End Function

    End Class
End Namespace

