using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepository
    {
        void Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
        Produto ObterProdutoPorNome(string nome);
        Produto ObterProdutoPorId(int id);
        string DeletarProduto(Produto produto);
        Produto EditarProduto(Produto produto);
    }
}
