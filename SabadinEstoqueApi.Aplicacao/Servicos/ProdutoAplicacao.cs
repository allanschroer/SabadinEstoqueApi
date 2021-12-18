using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoAplicacao : IProdutoAplicacao
    {
        private readonly IProdutoModeloRepository _produtoModeloRepository;

        public ProdutoAplicacao(IProdutoModeloRepository produtoModeloRepository)
        {
            _produtoModeloRepository = produtoModeloRepository;
        }

        public ProdutoModeloRetorno BuscarProdutoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoModeloRetorno BuscarProdutoPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public List<Produto> BuscarProdutos()
        {
            return _produtoModeloRepository.ObterTodosOsProdutos();
        }

        public ProdutoModeloRetorno CadastrarProduto(Produto produto)
        {
            _produtoModeloRepository.Cadastrar(produto);
            return new ProdutoModeloRetorno { Produto = produto, Sucesso = true, Mensagem = "Inserido com sucesso." };
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
