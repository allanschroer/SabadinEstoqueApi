using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepository
    {
        ResultadoOperacao Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
    }
}
