using System;

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
        public Situacao Situacao { get; set; }
        public int IdCategoria { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime DataHoraCadastro { get; set; }
        public int IdUsuarioAtualizacao { get; set; }
        public DateTime DataHoraAtualizacao { get; set; }
        public virtual Usuario UsuarioCadastro { get; set; }
        public virtual Usuario UsuarioAlteracao { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
