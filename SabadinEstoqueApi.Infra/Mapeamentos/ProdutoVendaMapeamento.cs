using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Infra.Mapeamentos
{
    public class ProdutoVendaMapeamento : IEntityTypeConfiguration<ProdutoVenda>
    {
        public void Configure(EntityTypeBuilder<ProdutoVenda> builder)
        {
            builder.ToTable("produtovenda");

            builder.HasKey(x => x.Id);

            builder.Property(a => a.Id).HasColumnName("Id").HasColumnType("int");
            builder.Property(a => a.QuantidadeVenda).HasColumnName("quantidadevenda").HasColumnType("int");
            builder.Property(a => a.ValorBruto).HasColumnName("valorbruto").HasColumnType("decimal(18,2)");
            builder.Property(a => a.ValorDesconto).HasColumnName("valordesconto").HasColumnType("decimal(18,2)");
            builder.Property(a => a.ValorFinal).HasColumnName("valorfinal").HasColumnType("decimal(18,2)");
            builder.Property(a => a.IdProduto).HasColumnName("Id").HasColumnType("int");
            builder.HasOne(a => a.Produto).WithMany().HasForeignKey(a => a.IdProduto);
        }
    }
}
