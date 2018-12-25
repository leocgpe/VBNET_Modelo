Namespace Events
    Interface IEventStore
        Sub Save(Of T As [Event])(ByVal theEvent As T)
    End Interface
End Namespace

