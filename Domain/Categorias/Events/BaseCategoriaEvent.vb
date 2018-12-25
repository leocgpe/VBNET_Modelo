Imports Domain.Core.Events

Namespace Categorias.Events
    Public MustInherit Class BaseCategoriaEvent
        Inherits [Event]

        Public Property Id As Guid
        Public Property Nome As String
    End Class
End Namespace

