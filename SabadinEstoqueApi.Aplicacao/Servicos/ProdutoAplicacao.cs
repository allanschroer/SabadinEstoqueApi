using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoAplicacao : IProdutoAplicacao
    {
        public ProdutoModeloRetorno BuscarProdutoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoModeloRetorno BuscarProdutoPorNome(string nome)
        {
            throw new System.NotImplementedException();
        }

        public ProdutoModeloRetorno CadastrarProduto(Produto produto)
        {
            return new ProdutoModeloRetorno
            {
                Produto = produto,
                Sucesso = true,
                Mensagem = "Inserido com sucesso."
            };
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
