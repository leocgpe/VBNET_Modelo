Imports Domain.Core.Commands
Imports Domain.Core.Events

Namespace Bus
    Interface IMediatorHandler
        Function SendCommand(Of T As Command)(ByVal theCommand As T) As Task
        Function [RaiseEvent](Of T As [Event])(ByVal theEvent As T) As Task
    End Interface
End Namespace

