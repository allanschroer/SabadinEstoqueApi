using Newtonsoft.Json;
using SabadinEstoqueApi.Dominio.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SabadinEstoqueApi.Dominio
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QtdEstoque { get; set; }
        public int QtdEstoqueMinimo { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorPromocao { get; set; }
        public SituacaoEnum Situacao { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
