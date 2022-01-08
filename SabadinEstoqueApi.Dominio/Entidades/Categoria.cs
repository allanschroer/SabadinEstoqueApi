namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public SituacaoEnum Situacao { get; private set; }

        public Categoria()
        {
        }

        public Categoria(int id, string nome, SituacaoEnum situacao)
        {
            Id = id;
            Nome = nome;
            Situacao = situacao;
        }
    }
}
