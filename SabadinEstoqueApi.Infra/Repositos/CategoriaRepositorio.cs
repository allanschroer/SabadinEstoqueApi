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

        public ResultadoOperacao<Categoria> Atualizar(Categoria categoria)
        {
            var consulta = _context.Categorias.Where(a => a.Id == categoria.Id).FirstOrDefault();
            consulta.Atualizar(categoria.Nome, categoria.Situacao);
            _context.SaveChanges();
            return new ResultadoOperacao<Categoria>
            {
                Mensagem = "Atualizado com sucesso.",
                Sucesso = true,
                ObjetoRetorno = consulta
            };
        }

        public ResultadoOperacao Cadastrar(Categoria categoria)
        {
            _context.Add(categoria);
            _context.SaveChanges();
            return new ResultadoOperacao { Mensagem = "Inserido com sucesso.", Sucesso = true };
        }

        public ResultadoOperacao Deletar(Categoria categoria)
        {
            _context.Remove(categoria);
            _context.SaveChanges();
            return new ResultadoOperacao { Mensagem = "Removido com sucesso.", Sucesso = true };
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
