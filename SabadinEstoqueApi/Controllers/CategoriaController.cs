using Microsoft.AspNetCore.Mvc;
using SabadinEstoqueApi.Aplicacao;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CategriaController : ControllerBase
    {
        private readonly ICategoriaAplicacao _categoriaAplicacao;

        public CategriaController(ICategoriaAplicacao categoriaAplicacao) 
            => _categoriaAplicacao = categoriaAplicacao ??
            throw new ArgumentNullException(nameof(categoriaAplicacao));

        [HttpGet, Route("ObterTodas")]
        public IEnumerable<Categoria> ObterCategorias() 
            => _categoriaAplicacao.ObterTodas();

        [HttpPost, Route("Cadastrar")]
        public ResultadoOperacao CadastrarCategoria(CategoriaModelo categoriaModelo) 
            => _categoriaAplicacao.Cadastrar(categoriaModelo);

        [HttpPost, Route("Atualizar")]
        public ResultadoOperacao<Categoria> Atualizar(CategoriaModelo categoriaModelo)
            => _categoriaAplicacao.Atualizar(categoriaModelo);
    }
}
