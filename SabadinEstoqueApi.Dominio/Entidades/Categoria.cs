namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public SituacaoEnum Situacao { get; set; }

        public void Atualizar(string nome, SituacaoEnum situacao)
        {
            Nome = nome;
            Situacao = situacao;
        }
    }
}
