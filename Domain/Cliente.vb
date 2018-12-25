Imports Domain.Core.Models

Namespace Domain
    Public Class Cliente
        Inherits Entity(Of Cliente)

        Private _nome As String
        Private _dataCadastro As Date

        Public Sub New(nome As String)
            Me.Id = Guid.NewGuid()
            Me._nome = nome
            Me._dataCadastro = DateTime.Now
        End Sub

        Public Property Nome As String
            Get
                Return _nome
            End Get
            Private Set(value As String)
                _nome = value
            End Set
        End Property

        Public Property DataCadastro As Date
            Get
                Return _dataCadastro
            End Get
            Private Set(value As Date)
                _dataCadastro = value
            End Set
        End Property

    End Class
End Namespace
