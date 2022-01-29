using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    public interface IProdutoAplicacao
    {
        ResultadoOperacao<List<ProdutoModelo>> BuscarProdutoPorNome(string nome);
        ResultadoOperacao<ProdutoModelo> BuscarProdutoPorId(int id);
        ResultadoOperacao CadastrarProduto(ProdutoModelo produto);
        ResultadoOperacao EditarProduto(Produto produto);
        ResultadoOperacao DeletarProdutoPorId(int id);
        ResultadoOperacao<List<ProdutoModelo>> BuscarProdutos();
    }
}
