using Microsoft.AspNetCore.Mvc;
using SabadinEstoqueApi.Aplicacao;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Controllers
{
    public class ProdutoController
    {
        [Route("api/[Controller]")]
        [ApiController]
        public class CategoriaController : ControllerBase
        {
            public ProdutoAplicacao ProdutoAplicacao = new();

            [HttpPost("CadastrarProduto")]
        public IActionResult CadastrarProduto(ProdutoModelo produto)
            {
                return Ok();
            }

        }
    }
}
