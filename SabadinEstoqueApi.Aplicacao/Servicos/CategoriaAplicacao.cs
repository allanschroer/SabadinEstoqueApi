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
            }
        }
        public Dominio.ResultadoOperacao Deletar(int idCategoria)
        {
            try
            {
                var categoria = _categoriaRepositorio.BuscarPorId(idCategoria);

                if (categoria != null)
                    return _categoriaRepositorio.Deletar(categoria);

                return new Dominio.ResultadoOperacao { Mensagem = "Produto nao existente na base de dados.", Sucesso = false };
            }
            catch (Exception ex)
            {
                return new Dominio.ResultadoOperacao
                {
                    Mensagem = $"Ocoreu um erro ao deletar a categoria.",
                    Sucesso = false,
                };
            }
        }
    }
}
