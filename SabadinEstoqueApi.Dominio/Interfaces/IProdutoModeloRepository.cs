using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepository
    {
        void Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
    }
}
