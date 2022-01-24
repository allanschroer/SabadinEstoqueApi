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
        private readonly ILogger _logger;

        public ProdutoAplicacao(IProdutoModeloRepositorio produtoModeloRepository, IMapper mapper, ILogger logger)
        {
            _produtoModeloRepositorio = produtoModeloRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public ProdutoModeloRetorno BuscarProdutoPorId(int id)
        {
            try
            {
                return ConverterRetorno(_produtoModeloRepositorio.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                return new ProdutoModeloRetorno
                {
                    Produto = new ProdutoModelo(),
                    Sucesso = false,
                    Mensagem = "Nao foi possivel obter o produto."
                };
            }
        }

        public List<Produto> BuscarProdutos()
        {
            return _produtoModeloRepositorio.ObterTodosOsProdutos();
        }

        public ResultadoOperacao CadastrarProduto(ProdutoModelo produtoModelo)
        {
            var produto = _mapper.Map<Produto>(produtoModelo);
            return _produtoModeloRepositorio.Cadastrar(produto);
        }

        public ResultadoOperacao DeletarProdutoPorId(int id)
        {
            try
            {
                var produto = _produtoModeloRepositorio.BuscarPorId(id);
                ValidarEntidadeNull(produto);
                return _produtoModeloRepositorio.DeletarProduto(produto);
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao
                {
                    Mensagem = ex.Message,
                    Sucesso = false
                };
            }
        }

        public ProdutoModeloRetorno EditarProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        private ProdutoModeloRetorno ConverterRetorno(Produto produto)
        {
            return new ProdutoModeloRetorno
            {
                Produto = _mapper.Map<ProdutoModelo>(produto),
                Sucesso = true
            };
        }

        private static T ValidarEntidadeNull<T>(T entidade) where T : class
        {
            if (entidade != null)
                return entidade;

            throw new Exception("Entidade não existe.");
        }

        public List<Produto> BuscarProdutoPorNome(string nome)
        {
            try
            {
                return _produtoModeloRepositorio.BuscarPorNome(nome);
            }
            catch
            {
                return null;
            }
        }
    }
}
