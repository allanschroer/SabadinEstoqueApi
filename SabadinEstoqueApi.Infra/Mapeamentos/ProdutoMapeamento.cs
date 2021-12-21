using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoMapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("produto");
            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.Nome).HasColumnName("nome").HasMaxLength(200);
            builder.Property(a => a.QtdEstoque).HasColumnName("qtdestoque").HasColumnType("int");
            builder.Property(a => a.QtdEstoqueMinimo).HasColumnName("qtdestoqueminimo").HasColumnType("int");
            builder.Property(a => a.Situacao).HasColumnName("situacao").HasColumnType("smallint");
            builder.Property(a => a.Valor).HasColumnName("valor").HasColumnType("decimal");
            builder.Property(a => a.ValorPromocao).HasColumnName("valorpromocao").HasColumnType("decimal");
            builder.Property(a => a.Categoria).HasColumnName("idcategoria").HasColumnType("int");
        }
    }
}
