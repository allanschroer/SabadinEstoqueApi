using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public interface IVendaAplicacao
    {
        public ResultadoOperacao Vender(VendaModelo venda);
    }
}
