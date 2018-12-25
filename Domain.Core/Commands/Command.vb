Imports Domain.Core.Events
Imports FluentValidation.Results

Namespace Commands
    Public MustInherit Class Command
        Inherits Message

        Private _timeStamp As DateTime
        Private _validationResult As ValidationResult

        Public Sub New()
            TimeStamp = DateTime.Now
        End Sub

        Public Property TimeStamp As Date
            Get
                Return _timeStamp
            End Get
            Set(value As Date)
                _timeStamp = value
            End Set
        End Property

        Public Property ValidationResult As ValidationResult
            Get
                Return _validationResult
            End Get
            Set(value As ValidationResult)
                _validationResult = value
            End Set
        End Property

        Public MustOverride Function IsValid() As Boolean
    End Class
End Namespace
