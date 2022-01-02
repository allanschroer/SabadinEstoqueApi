using Microsoft.EntityFrameworkCore;
using SabadinEstoqueApi.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabadinEstoqueApi.Infra
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Context _context;

        public CategoriaRepositorio(Context context)
        {
            _context = context;
        }

        public ResultadoOperacao Cadastrar(Categoria categoria)
        {
            try
            {
                _context.Add(categoria);
                _context.SaveChanges();
                return new ResultadoOperacao { Mensagem = "Inserido com sucesso.", Sucesso = true };
            }
            catch (Exception ex)
            {
                return new ResultadoOperacao { Sucesso = false, Mensagem = ex.Message };
            }
        }

        public List<Categoria> ObterTodasAsCategorias()
        {
            try
            {
                return _context.Categorias.ToList();
            }
            catch
            {
                return new List<Categoria>();
            }
        }
    }
}
