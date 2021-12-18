using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoRepositorio :  IProdutoModeloRepository
    {
        private Context _context;

        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public void Cadastrar(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
        }

        public List<Produto> ObterTodosOsProdutos()
        {
            return null; 
        }
    }
}
