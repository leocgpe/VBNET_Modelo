Namespace Interfaces
    Interface IRepository(Of TEntity)
        Sub Add(ByVal obj As TEntity)
        Function GetById(ByVal id As Guid) As TEntity
        Function GetAll() As IQueryable(Of TEntity)
        Sub Update(ByVal obj As TEntity)
        Sub Remove(ByVal id As Guid)
        Function SaveChanges() As Integer
    End Interface
End Namespace
