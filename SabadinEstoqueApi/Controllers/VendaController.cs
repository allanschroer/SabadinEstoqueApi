using Microsoft.AspNetCore.Mvc;
using SabadinEstoqueApi.Aplicacao;
using SabadinEstoqueApi.Dominio;

namespace SabadinEstoqueApi.Controllers
{
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        [HttpPost("VenderProduto")]
        public ResultadoOperacao Vender(VendaModelo venda)
        {
            return null;
        }
    }
}
