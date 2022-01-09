using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Aplicacao
{
    [Service]
    public interface ICategoriaAplicacao
    {
        public List<Categoria> ObterTodas();
        public ResultadoOperacao Cadastrar(CategoriaModelo categoriaModelo);
        public ResultadoOperacao<Categoria> Atualizar(CategoriaModelo categoriaModelo);
    }
}
