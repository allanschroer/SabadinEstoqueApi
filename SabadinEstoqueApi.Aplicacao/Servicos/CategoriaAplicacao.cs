using AutoMapper;
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

        public List<Categoria> ObterTodas()
        {
            try
            {
                return _categoriaRepositorio.ObterTodasAsCategorias().ToList();
            }
            catch (Exception ex)
            {
                return new List<Categoria>();
            }
        }

        public ResultadoOperacao Cadastrar(CategoriaModelo categoriaModelo)
        {
            try
            {
                return _categoriaRepositorio.Cadastrar(_mapper.Map<Categoria>(categoriaModelo));
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao
                {
                    Mensagem = $"Nao foi possivel cadastrar a categoria.",
                    Sucesso = false
                };
            }
        }

        public ResultadoOperacao<Categoria> Atualizar(CategoriaModelo categoriaModelo)
        {
            try
            {
                return _categoriaRepositorio.Atualizar(_mapper.Map<Categoria>(categoriaModelo));
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao<Categoria>
                {
                    Mensagem = "Ocoreu um erro ao atualizar a categoria",
                    Sucesso = false,
                    ObjetoRetorno = null
                };
            }
        }
    }
}
