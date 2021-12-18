using SabadinEstoqueApi.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Dominio
{
    public class Categoria
    {
        public int Id { get; private set; }

        public string Nome { get; private set; }

        public SituacaoEnum Situacao { get; private set; }
    }
}
