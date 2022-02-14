using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public class FinalizadorPix : IFinalizador
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
