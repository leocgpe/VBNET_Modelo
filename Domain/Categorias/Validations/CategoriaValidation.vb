Imports Domain.Categorias.Commands
Imports FluentValidation

Namespace Categorias.Validations
    Public MustInherit Class CategoriaValidation(Of T As BaseCategoriaCommand)
        Inherits AbstractValidator(Of T)

        Protected Sub ValidarNome()
            RuleFor(Function(x) x.Nome) _
            .NotEmpty() _
            .WithMessage("O {PropertyName} precisa ser preenchido") _
            .Length(2, 100) _
            .WithMessage("O {PropertyName} precisa ter entre 2 e 100 caracteres")
        End Sub
    End Class
End Namespace

