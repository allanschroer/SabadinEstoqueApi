using SabadinEstoqueApi.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Dominio
{
    public class CategoriaModelo
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public SituacaoEnum Situacao { get; private set; }

        public List<ProdutoModelo> Produtos { get; private set; }

        public CategoriaModelo(string nome, SituacaoEnum situacao, List<ProdutoModelo> produtos)
        {
            Nome = nome;
            Situacao = situacao;
            Produtos = produtos;
        }

        public CategoriaModelo(int id, string nome, SituacaoEnum situacao, List<ProdutoModelo> produtos)
        {
            Id = id;
            Nome = nome;
            Situacao = situacao;
            Produtos = produtos;
        }
    }
}
