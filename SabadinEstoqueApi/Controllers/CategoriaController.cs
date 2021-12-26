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

        [HttpGet]
        public IEnumerable<Categoria> ObterCategorias()
        {
            return _categoriaAplicacao.ObterTodas();
        }
    }
}
