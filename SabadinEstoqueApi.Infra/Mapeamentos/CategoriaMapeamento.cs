using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class CategoriaMapeamento : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categorias");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(a => a.Situacao).HasColumnName("situacao").HasColumnType("smallint");
            builder.Property(a => a.Nome).HasColumnName("nome").HasColumnType("varchar").HasMaxLength(200);
            builder.Property(a => a.IdUsuarioAtualizacao).HasColumnName("idusuarioalteracao").HasColumnType("int");
            builder.Property(a => a.IdUsuarioCadastro).HasColumnName("idusuariocadastro").HasColumnType("int");
            builder.Property(a => a.DataHoraAtualizacao).HasColumnName("dataatualizacao").HasColumnType("timestamp");
            builder.Property(a => a.DataHoraCadastro).HasColumnType("datacadastro").HasColumnType("timestamp");

            builder.HasOne(a => a.UsuarioAlteracao).WithMany().HasForeignKey(a => a.IdUsuarioAtualizacao);
            builder.HasOne(a => a.UsuarioCadastro).WithMany().HasForeignKey(a => a.IdUsuarioCadastro);
        }
    }
}
