using SabadinEstoqueApi.Dominio.Enums;

namespace SabadinEstoqueApi.Dominio
{
    public class Produto
    {
        public int Id { get; private set; }

        public int CategoriaId { get; private set; }

        public string Nome { get; private set; }

        public int QtdEstoque { get; private set; }

        public int QtdEstoqueMinimo { get; private set; }

        public decimal Valor { get; private set; }

        public decimal ValorPromocao { get; private set; }

        public SituacaoEnum Situacao { get; private set; }

        public virtual Categoria Categoria { get; private set; }

        public void AtivarProduto(int idProduto)
        {
            //TODO
        }

        public void InativarProduto(int idProduto)
        {
            //TODO
        }

        public string ValidarEstoque()
        {
            if (QtdEstoque <= QtdEstoqueMinimo)
                return "Estoque abaixo do mínimo aceito.";

            return string.Empty;
        }
    }
}
