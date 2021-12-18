using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Infra
{
    public class Context : DbContext
    {
            public Context(DbContextOptions<Context> options) : base(options)
            {

            }

            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Produto> Produtos { get; set; }
    }
}
