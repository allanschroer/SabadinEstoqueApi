using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public class FinalizadorCartaoCredito : IFinalizador
    {
        public void ProcessarEstoque(VendaModelo venda)
        {

        }

        public void ProcessarPagamento(VendaModelo venda)
        {
            throw new NotImplementedException();
        }
    }
}
