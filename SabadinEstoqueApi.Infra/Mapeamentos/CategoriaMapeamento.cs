using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class CategoriaMapeamento : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria");
            builder.HasKey(x => x.Id);
            builder.Property(a => a.Situacao).HasColumnName("situacao").HasColumnType("smallint");
            builder.Property(a => a.Nome).HasColumnName("nome").HasColumnType("varchar").HasMaxLength(200);
        }
    }
}
