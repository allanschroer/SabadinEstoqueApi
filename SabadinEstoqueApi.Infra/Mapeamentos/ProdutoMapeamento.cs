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
            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Nome).HasColumnName("nome").HasColumnType("varchar").HasMaxLength(200);
            builder.Property(a => a.QtdEstoque).HasColumnName("qtdestoque").HasColumnType("int");
            builder.Property(a => a.QtdEstoqueMinimo).HasColumnName("qtdestoqueminimo").HasColumnType("int");
            builder.Property(a => a.Situacao).HasColumnName("situacao").HasColumnType("smallint");
            builder.Property(a => a.Valor).HasColumnName("valor").HasColumnType("decimal");
            builder.Property(a => a.ValorPromocao).HasColumnName("valorpromocao").HasColumnType("decimal");
            builder.HasOne(a => a.Categoria).WithMany().HasForeignKey(a => a.IdCategoria);
        }
    }
}
