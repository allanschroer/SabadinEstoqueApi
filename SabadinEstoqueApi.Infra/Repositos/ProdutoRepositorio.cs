using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System;
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

        public ResultadoOperacao Cadastrar(Produto produto)
        {
            try
            {
                _context.Add(produto);
                _context.SaveChanges();
                return new ResultadoOperacao { Sucesso = true, Mensagem = $"{produto.Nome} inserido com sucesso."};
            }
            catch(Exception e)
            {
                return new ResultadoOperacao { Mensagem = e.Message, Sucesso = false }; 
            }
        }

        public List<Produto> ObterTodosOsProdutos()
        {
            return null; 
        }
    }
}
