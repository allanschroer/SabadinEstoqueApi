using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produtos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Nome).HasColumnName("nome").HasColumnType("varchar").HasMaxLength(200);
            builder.Property(a => a.QtdEstoque).HasColumnName("qtdestoque").HasColumnType("int");
            builder.Property(a => a.QtdEstoqueMinimo).HasColumnName("qtdestoqueminimo").HasColumnType("int");
            builder.Property(a => a.Situacao).HasColumnName("situacao").HasColumnType("smallint");
            builder.Property(a => a.Valor).HasColumnName("valor").HasColumnType("decimal");
            builder.Property(a => a.ValorPromocao).HasColumnName("valorpromocao").HasColumnType("decimal");
            builder.Property(a => a.IdCategoria).HasColumnName("idcategoria").HasColumnType("int");
            builder.Property(a => a.IdUsuarioAtualizacao).HasColumnName("idusuarioalteracao").HasColumnType("int");
            builder.Property(a => a.IdUsuarioCadastro).HasColumnName("idusuariocadastro").HasColumnType("int");
            builder.Property(a => a.DataHoraAtualizacao).HasColumnName("dataatualizacao").HasColumnType("timestamp");
            builder.Property(a => a.DataHoraCadastro).HasColumnType("datacadastro").HasColumnType("timestamp");

            builder.HasOne(a => a.Categoria).WithMany().HasForeignKey(a => a.IdCategoria);
            builder.HasOne(a => a.UsuarioAlteracao).WithMany().HasForeignKey(a => a.IdUsuarioAtualizacao);
            builder.HasOne(a => a.UsuarioCadastro).WithMany().HasForeignKey(a => a.IdUsuarioCadastro);
        }
    }
}
