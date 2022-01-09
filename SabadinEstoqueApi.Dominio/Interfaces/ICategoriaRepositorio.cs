using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Dominio
{
    public interface ICategoriaRepositorio
    {
        public ResultadoOperacao Cadastrar(Categoria categoria);
        public List<Categoria> ObterTodasAsCategorias();
        public ResultadoOperacao<Categoria> Atualizar(Categoria categoria);
    }
}
