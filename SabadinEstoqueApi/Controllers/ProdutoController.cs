using Microsoft.AspNetCore.Mvc;
using SabadinEstoqueApi.Aplicacao;
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
            => _produtoAplicacao = produtoAplicacao ??
            throw new ArgumentNullException(nameof(produtoAplicacao));

        [HttpPost("CadastrarProduto")]
        public IActionResult CadastrarProduto(ProdutoModelo produtoModelo) 
            => Ok(_produtoAplicacao.CadastrarProduto(produtoModelo));

        [HttpGet("ObterProdutos")]
        public ResultadoOperacao<List<ProdutoModelo>> ObterProdutos() 
            => _produtoAplicacao.BuscarProdutos();

        [HttpGet("ObterPorId")]
        public ResultadoOperacao ObterPorId(int id)
            => _produtoAplicacao.BuscarProdutoPorId(id);

        [HttpDelete("DeletarProduto")]
        public ResultadoOperacao DeletarProduto(int id)
            => _produtoAplicacao.DeletarProdutoPorId(id);
    }
}
