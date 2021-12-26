using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public interface IProdutoModeloRepositorio
    {
        ResultadoOperacao Cadastrar(Produto produto);
        List<Produto> ObterTodosOsProdutos();
        Produto BuscarPorId(int id);
    }
}
