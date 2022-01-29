using AutoMapper;
using Microsoft.Extensions.Logging;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoAplicacao : IProdutoAplicacao
    {
        private readonly IProdutoModeloRepositorio _produtoModeloRepositorio;
        private readonly IMapper _mapper;

        public ProdutoAplicacao(IProdutoModeloRepositorio produtoModeloRepository, IMapper mapper)
        {
            _produtoModeloRepositorio = produtoModeloRepository;
            _mapper = mapper;
        }

        public ResultadoOperacao<ProdutoModelo> BuscarProdutoPorId(int id)
        {
            try
            {
                var produtos = _mapper.Map(_produtoModeloRepositorio.BuscarPorId(id), new ProdutoModelo());

                return new ResultadoOperacao<ProdutoModelo>
                {
                    ModeloRetorno = produtos,
                    Sucesso = true
                };
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<ProdutoModelo>
                {
                    Sucesso = false,
                    Mensagem = "Nao foi possivel obter o produto."
                };
            }
        }

        public ResultadoOperacao<List<ProdutoModelo>> BuscarProdutos()
        {
            try
            {
                var produtos = _mapper.Map(_produtoModeloRepositorio.ObterTodosOsProdutos(), new List<ProdutoModelo>());

                return new ResultadoOperacao<List<ProdutoModelo>>().CriarSucesso(produtos);
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<List<ProdutoModelo>>().CriarFalha("Nao foi possivel obter o produto.");
            }

        }

        public ResultadoOperacao CadastrarProduto(ProdutoModelo produtoModelo)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoModelo);
                _produtoModeloRepositorio.Cadastrar(produto);
                return new ResultadoOperacao().CriarSucesso();
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao().CriarFalha("Nao foi possivel cadastrar o produto.");
            }
        }

        public ResultadoOperacao DeletarProdutoPorId(int id)
        {
            try
            {
                var produto = _produtoModeloRepositorio.BuscarPorId(id);
                ValidarEntidadeNull(produto);
                _produtoModeloRepositorio.DeletarProduto(produto);

                return new ResultadoOperacao().CriarSucesso();
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao().CriarFalha("Nao foi possivel deletar o produto.");
            }
        }

        public ResultadoOperacao EditarProduto(Produto produto)
        {
            throw new NotImplementedException();
        }

        private static T ValidarEntidadeNull<T>(T entidade) where T : class
        {
            if (entidade != null)
                return entidade;

            throw new ArgumentException();
        }

        public ResultadoOperacao<List<ProdutoModelo>> BuscarProdutoPorNome(string nome)
        {
            try
            {
                var produtos = _mapper.Map(_produtoModeloRepositorio.BuscarPorNome(nome), new List<ProdutoModelo>());
                
                return new ResultadoOperacao<List<ProdutoModelo>>().CriarSucesso(produtos);
            }
            catch
            {
                return new ResultadoOperacao<List<ProdutoModelo>>().CriarFalha("Nao foi possivel fazer a consulta.");
            }
        }
    }
}
