using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    public class VendaModelo
    {
        public double ValorFinal { get; set; }
        public double ValorBruto { get; set; }
        public double ValorDesconto { get; set; }
        public FinalizadorEnum Finalizador { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public List<ProdutoVendaModelo> Produtos { get; set; }
    }
}
