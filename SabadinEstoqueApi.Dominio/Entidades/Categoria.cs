using SabadinEstoqueApi.Dominio.Enums;

namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public SituacaoEnum Situacao { get; private set; }
    }
}
