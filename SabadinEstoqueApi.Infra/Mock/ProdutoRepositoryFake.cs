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
        private List<Produto> _produtos = new()
        {
            new Produto()
            {
                Id = 1,
                CategoriaId = 1,
                Situacao = 0,
                Nome = "Produto 1",
                QtdEstoque = 100,
                QtdEstoqueMinimo = 20,
                Valor = 1199.90m,
                ValorPromocao = 999.90m
            },
            new Produto()
            {
                Id = 2,
                CategoriaId = 2,
                Situacao = 0,
                Nome = "Produto 2",
                QtdEstoque = 100,
                QtdEstoqueMinimo = 20,
                Valor = 1599.90m,
                ValorPromocao = 1299.90m
            }
        };

        public void Cadastrar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public IEnumerable<Produto> ObterTodosOsProdutos()
        {
            return _produtos;
        }
    }
}
