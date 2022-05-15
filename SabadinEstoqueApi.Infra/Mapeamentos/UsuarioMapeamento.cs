using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnType("int").HasColumnName("id");
            builder.Property(x => x.NivelAcesso).HasColumnType("tinyint").HasColumnName("nivelacesso");
            builder.Property(x => x.Senha).HasColumnType("varchar").HasMaxLength(20).HasColumnName("senha");
            builder.Property(x => x.Nome).HasColumnType("varchar").HasMaxLength(50).HasColumnName("nome");
            builder.Property(x => x.Codigo).HasColumnType("varchar").HasMaxLength(20).HasColumnName("codigo");
            builder.Property(x => x.Email).HasColumnType("varchar").HasMaxLength(50).HasColumnName("email");
            builder.Property(x => x.Situacao).HasColumnType("tinyint").HasColumnName("situacao");
        }
    }
}
