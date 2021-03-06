using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Aplicacao
{
    [Service]
    public interface IProdutoAplicacao
    {
        ProdutoModeloRetorno BuscarProdutoPorNome(string nome);
        ProdutoModeloRetorno BuscarProdutoPorId(int id);
        ProdutoModeloRetorno CadastrarProduto(Produto produto);
        ProdutoModeloRetorno EditarProduto(Produto produto);
        string DeletarProdutoPorId(int id);
    }
}
