Imports System.Text
Imports Domain.Categorias
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class CategoriaTests

    <TestMethod()> Public Sub DeveCriarCategoria()
        Const nomeCategoria As String = "Show"

        Dim categoria = New Categoria(nomeCategoria)

        Assert.AreEqual(nomeCategoria, categoria.Nome)

    End Sub

    <TestMethod()> Public Sub DeveAlterarCategoria()
        Const antigoNomeCategoria As String = "Show"
        Const novoNomeCategoria As String = "Exibição"
        Dim categoriaExistente = New Categoria(antigoNomeCategoria)

        categoriaExistente.AlterarNome(novoNomeCategoria)

        Assert.AreEqual(novoNomeCategoria, categoriaExistente.Nome)
    End Sub

    <TestMethod()> Public Sub QuandoInativado_UmaCategoriaAtiva_CampoAtivoDeveSerFalse()
        Dim categoria = New Categoria("Show")

        categoria.Inativar()

        Assert.IsFalse(categoria.Ativo)
    End Sub

End Class