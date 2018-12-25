Imports Domain.Interfaces

Namespace Categorias.Repository
    Interface ICategoriaRepository
        Inherits IRepository(Of Categoria)

        Function ObterPorNome(ByVal nome As String) As IEnumerable(Of Categoria)
    End Interface
End Namespace

