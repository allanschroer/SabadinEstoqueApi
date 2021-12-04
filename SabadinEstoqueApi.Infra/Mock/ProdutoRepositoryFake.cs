using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoRepositoryFake : IProdutoModeloRepository
    {
        private readonly List<Produto> produtos;
        public void Cadastrar(Produto produto)
        {
            produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodosOsProdutos()
        {
            return produtos;
        }
    }
}
