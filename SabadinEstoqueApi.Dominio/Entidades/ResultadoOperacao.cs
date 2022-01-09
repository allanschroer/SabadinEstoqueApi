using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Dominio
{
    public class ResultadoOperacao <T>
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T ObjetoRetorno { get; set; }
    }

    public class ResultadoOperacao
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}
