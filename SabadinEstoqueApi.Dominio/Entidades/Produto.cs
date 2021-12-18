using Newtonsoft.Json;
using SabadinEstoqueApi.Dominio.Enums;
using System.Text.Json.Serialization;

namespace SabadinEstoqueApi.Dominio
{
    public class Produto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nome")]
        public string Nome { get; set; }
        [JsonPropertyName("qtdEstoque")]
        public int QtdEstoque { get; set; }
        [JsonPropertyName("qtdEstoqueMinimo")]
        public int QtdEstoqueMinimo { get; set; }
        [JsonPropertyName("valor")]
        public decimal Valor { get; set; }
        [JsonPropertyName("valorPromocao")]
        public decimal ValorPromocao { get; set; }
        [JsonPropertyName("situacao")]
        public SituacaoEnum Situacao { get; set; }
        [JsonPropertyName("categoria")]
        public virtual Categoria Categoria { get; set; }
    }
}
