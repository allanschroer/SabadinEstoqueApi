using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.Id);

            builder.ToTable("cliente");

            builder.Property(a => a.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(a => a.Telefone).HasColumnName("telefone").HasColumnType("text");
            builder.Property(a => a.Nome).HasColumnName("nome").HasColumnType("text");
            builder.Property(a => a.Cpf).HasColumnName("cpf").HasColumnType("text");
        }
    }
}
