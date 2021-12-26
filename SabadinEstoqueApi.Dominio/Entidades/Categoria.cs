using SabadinEstoqueApi.Dominio.Enums;

namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public SituacaoEnum Situacao { get; set; }
    }
}
