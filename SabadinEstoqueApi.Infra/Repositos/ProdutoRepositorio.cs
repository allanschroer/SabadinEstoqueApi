using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabadinEstoqueApi.Infra
{
    public class ProdutoRepositorio :  IProdutoModeloRepositorio
    {
        private readonly Context _context;

        public ProdutoRepositorio(Context context)
        {
            _context = context;
        }

        public ResultadoOperacao Cadastrar(Produto produto)
        {
            try
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();
                return new ResultadoOperacao { Sucesso = true, Mensagem = $"{produto.Nome} inserido com sucesso."};
            }
            catch(Exception e)
            {
                return new ResultadoOperacao { Mensagem = e.Message, Sucesso = false }; 
            }
        }

        public Produto BuscarPorId(int id)
        {
            try
            {
                return _context.Produtos.Where(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Produto> ObterTodosOsProdutos()
        {
            return _context.Produtos.Include(a => a.Categoria).ToList();
        }
    }
}
