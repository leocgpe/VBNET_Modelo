Imports Domain.Categorias.Validations

Namespace Categorias.Commands
    Public Class RegistrarCategoriaCommand
        Inherits BaseCategoriaCommand

        Public Sub New(ByVal nome As String)
            Me.Nome = nome
        End Sub

        Public Overrides Function IsValid() As Boolean
            ValidationResult = New RegistrarCategoriaCommandValidation().Validate(Me)
            Return ValidationResult.IsValid
        End Function
    End Class
End Namespace

