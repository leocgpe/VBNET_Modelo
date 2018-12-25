Namespace Categorias.Events
    Public Class CategoriaRegistradaEvent
        Inherits BaseCategoriaEvent

        Public Sub New(ByVal id As Guid, ByVal nome As String)
            id = id
            nome = nome
            AggregateId = id
        End Sub
    End Class
End Namespace

