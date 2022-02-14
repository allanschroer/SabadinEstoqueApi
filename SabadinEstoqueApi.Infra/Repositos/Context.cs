using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Infra
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMapeamento());
            modelBuilder.ApplyConfiguration(new CategoriaMapeamento());
            modelBuilder.ApplyConfiguration(new VendasMapeamento());
            modelBuilder.ApplyConfiguration(new ProdutoVendaMapeamento());
            modelBuilder.ApplyConfiguration(new ClienteMapeamento());

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ProdutoVenda> ProdutoVenda { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
