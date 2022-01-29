using SabadinEstoqueApi.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace SabadinEstoqueApi.Infra
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly Context _context;

        public CategoriaRepositorio(Context context)
        {
            _context = context;
        }

        public void Atualizar(Categoria categoria)
        {
            var consulta = _context.Categorias.Where(a => a.Id == categoria.Id).FirstOrDefault();
            consulta.Atualizar(categoria.Nome, categoria.Situacao);
            _context.SaveChanges();
        }

        public void Cadastrar(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
        }

        public void Deletar(Categoria categoria)
        {
            _context.Remove(categoria);
            _context.SaveChanges();
        }

        public List<Categoria> ObterTodasAsCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Categoria BuscarPorId(int idCategoria)
        {
            return _context.Set<Categoria>().Where(a => a.Id == idCategoria).FirstOrDefault();
        }
    }
}
