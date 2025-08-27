using Microsoft.EntityFrameworkCore;
using Plataforma_de_Lanches.Context;
using Plataforma_de_Lanches.Models;
using Plataforma_de_Lanches.Repository.Interfaces;

namespace Plataforma_de_Lanches.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
                                                        .Where(l => l.IsLanchePreferido)
                                                        .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.Id == lancheId);
        }
    }
}
