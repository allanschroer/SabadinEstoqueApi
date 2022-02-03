using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    public interface ICategoriaAplicacao
    {
        public ResultadoOperacao<List<Categoria>> ObterTodas();
        public ResultadoOperacao Cadastrar(CategoriaModelo categoriaModelo);
        public ResultadoOperacao Atualizar(CategoriaModelo categoriaModelo);
        public ResultadoOperacao Deletar(int idCategoria);
    }
}
