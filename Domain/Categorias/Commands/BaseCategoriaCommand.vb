Imports Domain.Core.Commands

Namespace Categorias.Commands
    Public MustInherit Class BaseCategoriaCommand
        Inherits Command

        Public Property Id As Guid
        Public Property Nome As String
    End Class
End Namespace

