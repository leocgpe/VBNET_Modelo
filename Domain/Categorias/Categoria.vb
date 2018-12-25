Imports Domain.Core.Models

Namespace Categorias
    Public Class Categoria
        Inherits Entity(Of Categoria)

        Private _nome As String
        Private _ativo As Boolean

        Public Property Nome As String
            Get
                Return _nome
            End Get
            Set(value As String)
                _nome = value
            End Set
        End Property

        Public Property Ativo As Boolean
            Get
                Return _ativo
            End Get
            Set(value As Boolean)
                _ativo = value
            End Set
        End Property

        Protected Sub New()
        End Sub

        Public Sub New(nome As String)
            Id = Guid.NewGuid()
            Me._nome = nome
            Me.Ativo = True
        End Sub

        Public Sub AlterarNome(nome As String)
            Me._nome = nome
        End Sub

        Public Sub Inativar()
            Me._ativo = False
        End Sub

        Public Sub Ativar()
            Me._ativo = True
        End Sub

    End Class
End Namespace

