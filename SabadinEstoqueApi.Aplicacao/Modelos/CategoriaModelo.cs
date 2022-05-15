using SabadinEstoqueApi.Dominio;
using System.ComponentModel.DataAnnotations;

namespace SabadinEstoqueApi.Aplicacao
{
    public class CategoriaModelo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar o nome.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a situação.")]
        public Situacao Situacao { get; set; }
    }
}
