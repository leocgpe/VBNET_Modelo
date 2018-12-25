Imports Domain.Categorias.Commands

Namespace Categorias.Validations
    Public Class RegistrarCategoriaCommandValidation
        Inherits CategoriaValidation(Of RegistrarCategoriaCommand)

        Public Sub New()
            ValidarNome()
        End Sub
    End Class
End Namespace
