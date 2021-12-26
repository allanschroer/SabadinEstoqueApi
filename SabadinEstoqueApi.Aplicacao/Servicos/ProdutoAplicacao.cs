using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoAplicacao : IProdutoAplicacao
    {
        private readonly IProdutoModeloRepositorio _produtoModeloRepositorio;

        public ProdutoAplicacao(IProdutoModeloRepositorio produtoModeloRepository)
        {
            _produtoModeloRepositorio = produtoModeloRepository;
        }

        public ProdutoModeloRetorno BuscarProdutoPorId(int id)
        {
            try
            {
                return new ProdutoModeloRetorno
                {
                    Produto = _produtoModeloRepositorio.BuscarPorId(id)
                };
            }
            catch (Exception e)
            {
                return new ProdutoModeloRetorno
                {
                    Mensagem = e.Message,
                    Sucesso = false
                };
            }
        }

        public ProdutoModeloRetorno BuscarProdutoPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public List<Produto> BuscarProdutos()
        {
            return _produtoModeloRepositorio.ObterTodosOsProdutos();
        }

        public ResultadoOperacao CadastrarProduto(Produto produto)
        {
            return _produtoModeloRepositorio.Cadastrar(produto);
        }

        public string DeletarProdutoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoModeloRetorno EditarProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }
    }
}
