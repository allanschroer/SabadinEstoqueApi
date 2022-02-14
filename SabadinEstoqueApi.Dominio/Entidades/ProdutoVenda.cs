namespace SabadinEstoqueApi.Dominio
{
    public class ProdutoVenda
    {
        public int Id { get; set; }
        public int QuantidadeVenda { get; set; }
        public double ValorFinal { get; set; }
        public double ValorBruto { get; set; }
        public double ValorDesconto { get; set; }
        public int IdProduto { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
