using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepositorio
    {
        ResultadoOperacao Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
        Produto BuscarPorId(int id);
        ResultadoOperacao DeletarProduto(Produto produto);
        List<Produto> BuscarPorNome(string nome);
    }
}
