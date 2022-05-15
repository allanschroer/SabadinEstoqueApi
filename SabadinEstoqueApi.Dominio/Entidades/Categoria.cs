using System;

namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Situacao Situacao { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public int IdUsuarioAtualizacao { get; set; }
        public DateTime DataHoraAtualizacao { get; set; }
        public virtual Usuario UsuarioCadastro { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }

        public void Atualizar(string nome, Situacao situacao, int idUsuarioAlteracao)
        {
            Nome = nome;
            Situacao = situacao;
            DataHoraAtualizacao = DateTime.Now;
            IdUsuarioAtualizacao = idUsuarioAlteracao;
        }
    }
}
