using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public class CategoriaAplicacao : ICategoriaAplicacao
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaAplicacao(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public List<Categoria> ObterTodas()
        {
            var categorias = _categoriaRepositorio.ObterTodasAsCategorias().ToList();

        }
    }
}
