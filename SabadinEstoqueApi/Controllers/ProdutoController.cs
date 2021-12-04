using Microsoft.AspNetCore.Mvc;
using SabadinEstoqueApi.Aplicacao;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;

namespace SabadinEstoqueApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoAplicacao _produtoAplicacao;
        public ProdutoController(IProdutoAplicacao produtoAplicacao)
        {
            _produtoAplicacao = produtoAplicacao ??
            throw new ArgumentNullException(nameof(produtoAplicacao));
        }

        [HttpPost("CadastrarProduto")]
        public IActionResult CadastrarProduto([FromBody]Produto produto)
        {
            return Ok(_produtoAplicacao.CadastrarProduto(produto));
        }

        [HttpGet("ObterProdutos")]
        public IEnumerable<Produto> ObterProdutos()
        {
            return _produtoAplicacao.BuscarProdutos();
        }
    }
}
