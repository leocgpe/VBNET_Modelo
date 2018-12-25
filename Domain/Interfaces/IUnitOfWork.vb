Namespace Interfaces
    Interface IUnitOfWork
        Inherits IDisposable

        Function Commit() As Boolean
    End Interface
End Namespace

