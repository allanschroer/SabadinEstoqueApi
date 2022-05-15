using AutoMapper;
using Microsoft.Extensions.Logging;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SabadinEstoqueApi.Aplicacao
{
    public class CategoriaAplicacao : ICategoriaAplicacao
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;

        public CategoriaAplicacao(ICategoriaRepositorio categoriaRepositorio, IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }

        public ResultadoOperacao<List<Categoria>> ObterTodas()
        {
            try
            {
                var categorias = _categoriaRepositorio.ObterTodasAsCategorias().ToList();
                return new ResultadoOperacao<List<Categoria>>().CriarSucesso(categorias);
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<List<Categoria>>().CriarFalha("Nao foi possivel obter as categorias.");
            }
        }

        public ResultadoOperacao Cadastrar(CategoriaModelo categoriaModelo)
        {
            try
            {
                _categoriaRepositorio.Cadastrar(_mapper.Map<Categoria>(categoriaModelo));
                return new ResultadoOperacao().CriarSucesso();
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao().CriarFalha("Nao foi possivel cadastrar a categoria.");
            }
        }

        public ResultadoOperacao Atualizar(CategoriaModelo categoriaModelo)
        {
            try
            {
                var categoria = _mapper.Map<Categoria>(categoriaModelo);
                _categoriaRepositorio.Atualizar(categoria);
                return new ResultadoOperacao().CriarSucesso();
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao().CriarFalha("Nao foi possivel atualizar o produto.");
            }
        }
        public ResultadoOperacao Deletar(int idCategoria)
        {
            try
            {
                var categoria = _categoriaRepositorio.BuscarPorId(idCategoria);

                if (categoria != null)
                {
                    _categoriaRepositorio.Deletar(categoria);
                    return new ResultadoOperacao().CriarSucesso();
                }

                return new ResultadoOperacao().CriarFalha("Produto nao existente na base de dados.");
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao().CriarFalha("Ocoreu um erro ao deletar a categoria.");
            }
        }
    }
}
