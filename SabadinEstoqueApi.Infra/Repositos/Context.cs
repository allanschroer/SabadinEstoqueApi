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
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
