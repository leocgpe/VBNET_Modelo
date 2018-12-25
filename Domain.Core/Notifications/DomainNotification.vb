Imports Domain.Core.Events

Namespace Notifications
    Public Class DomainNotification
        Inherits [Event]

        Private _domainotificationId As Guid
        Private _key As String
        Private _value As String
        Private _version As Integer

        Public Sub New(ByVal key As String, ByVal value As String)
            Me.DomainotificationId = Guid.NewGuid()
            Me.Key = key
            Me.Value = value
            Me.Version = 1
        End Sub

        Public Property DomainotificationId As Guid
            Get
                Return _domainotificationId
            End Get
            Private Set(value As Guid)
                _domainotificationId = value
            End Set
        End Property

        Public Property Key As String
            Get
                Return _key
            End Get
            Private Set(value As String)
                _key = value
            End Set
        End Property

        Public Property Value As String
            Get
                Return _value
            End Get
            Private Set(value As String)
                _value = value
            End Set
        End Property

        Public Property Version As Integer
            Get
                Return _version
            End Get
            Private Set(value As Integer)
                _version = value
            End Set
        End Property
    End Class
End Namespace

