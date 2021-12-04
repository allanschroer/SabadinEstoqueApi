using Microsoft.EntityFrameworkCore;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoModeloRepository : DbContext
    {
        public ProdutoModeloRepository(DbContextOptions<ProdutoModeloRepository> options) : base(options)
        {

        }
    }
}
