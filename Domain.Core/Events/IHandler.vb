Namespace Events
    Interface IHandler(Of T)
        Sub Handle(ByVal message As T)
    End Interface
End Namespace
