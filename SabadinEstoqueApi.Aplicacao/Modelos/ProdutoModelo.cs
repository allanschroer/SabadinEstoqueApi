using SabadinEstoqueApi.Dominio;
using System.ComponentModel.DataAnnotations;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoModelo
    {
        [Required(ErrorMessage = "Necessário informar nome.")]
        public string Nome { get; set; }
        public int QtdEstoque { get; set; }
        public int QtdEstoqueMinimo { get; set; }
        [Required(ErrorMessage = "Necessário informar o valor.")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Necessário informar o valor em promoção.")]
        public decimal ValorPromocao { get; set; }
        [Required(ErrorMessage = "Necessário infomar a situação do produto.")]
        public Situacao Situacao { get; set; }
        [Required(ErrorMessage = "Necessário informar uma categoria para o produto.")]
        public int IdCategoria { get; set; }
    }
}
