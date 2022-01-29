using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoRepositorio : IProdutoModeloRepositorio
    {
        private readonly Context _context;

        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Produto> ObterTodosOsProdutos()
        {
            return _context.Produtos.Include(a => a.Categoria).ToList();
        }

        public void DeletarProduto(Produto produto)
        {
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public List<Produto> BuscarPorNome(string nome)
        {
            return _context.Produtos.Where(a => a.Nome.Contains(nome)).ToList();
        }
    }
}
