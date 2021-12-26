using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    [Service]
    public interface IProdutoAplicacao
    {
        ProdutoModeloRetorno BuscarProdutoPorNome(string nome);
        ProdutoModeloRetorno BuscarProdutoPorId(int id);
        ResultadoOperacao CadastrarProduto(Produto produto);
        ProdutoModeloRetorno EditarProduto(Produto produto);
        string DeletarProdutoPorId(int id);
        List<Produto> BuscarProdutos();
    }
}
