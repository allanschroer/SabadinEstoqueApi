using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Infra
{
    public class VendasMapeamento : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("vendas");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(a => a.QuatidadeParcelas).HasColumnName("quantidadeparcelas").HasColumnType("int");
            builder.Property(a => a.Finalizador).HasColumnName("finalizador").HasColumnType("int");

            builder.HasOne(a => a.Cliente).WithMany().HasForeignKey(a => a.IdCliente).HasConstraintName("idcliente");
            builder.HasMany(a => a.Produtos).WithOne(a => a.Venda);
        }
    }
}
