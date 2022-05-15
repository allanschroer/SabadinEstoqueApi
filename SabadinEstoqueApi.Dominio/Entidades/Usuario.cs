namespace SabadinEstoqueApi.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public NivelAcesso NivelAcesso { get; set; }
        public Situacao Situacao { get; set; }
    }
}
