using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    [Service]
    public interface IProdutoAplicacao
    {
        List<Produto> BuscarProdutoPorNome(string nome);
        ProdutoModeloRetorno BuscarProdutoPorId(int id);
        ResultadoOperacao CadastrarProduto(ProdutoModelo produto);
        ProdutoModeloRetorno EditarProduto(Produto produto);
        ResultadoOperacao DeletarProdutoPorId(int id);
        List<Produto> BuscarProdutos();
    }
}
