using System.Collections.Generic;

namespace SabadinEstoqueApi.Dominio
{
    public class Venda
    {
        public int Id { get; set; }
        public FinalizadorEnum Finalizador { get; set; }
        public int QuatidadeParcelas { get; set; }
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<ProdutoVenda> Produtos { get; set; }
    }
}
