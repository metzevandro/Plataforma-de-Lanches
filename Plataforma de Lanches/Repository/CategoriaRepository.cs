using Plataforma_de_Lanches.Context;
using Plataforma_de_Lanches.Models;
using Plataforma_de_Lanches.Repository.Interfaces;

namespace Plataforma_de_Lanches.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
