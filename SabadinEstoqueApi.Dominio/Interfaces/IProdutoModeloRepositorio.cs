using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepositorio
    {
        void Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
        Produto BuscarPorId(int id);
        void DeletarProduto(Produto produto);
        List<Produto> BuscarPorNome(string nome);
    }
}
