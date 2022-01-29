using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Dominio
{
    public interface ICategoriaRepositorio
    {
        public void Cadastrar(Categoria categoria);
        public List<Categoria> ObterTodasAsCategorias();
        public void Atualizar(Categoria categoria);
        public void Deletar(Categoria categoria);
        public Categoria BuscarPorId(int idCategoria);
    }
}
