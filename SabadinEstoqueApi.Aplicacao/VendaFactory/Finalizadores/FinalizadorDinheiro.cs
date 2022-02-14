using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    internal class FinalizadorDinheiro : IFinalizador
    {
        public void ProcessarEstoque(VendaModelo venda)
        {
            throw new NotImplementedException();
        }

        public void ProcessarPagamento(VendaModelo venda)
        {
            throw new NotImplementedException();
        }
    }
}
