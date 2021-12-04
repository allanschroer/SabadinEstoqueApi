using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepository
    {
        void Cadastrar(Produto produto);
        IEnumerable<Produto> ObterTodosOsProdutos();
    }
}
