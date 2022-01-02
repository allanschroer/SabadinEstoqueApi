using SabadinEstoqueApi.Dominio;
using System;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ProdutoModeloRetorno
    {
        public Produto Produto { get; set; }
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
