using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public interface IFinalizador
    {
        public void ProcessarPagamento(VendaModelo venda);
        public void ProcessarEstoque(VendaModelo venda);
    }
}
