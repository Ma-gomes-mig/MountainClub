using Microsoft.EntityFrameworkCore;
using ProjetoSite1.Data;
using ProjetoSite1.Models;
using ProjetoSite1.Repositories.Interface;

namespace ProjetoSite1.Repositories
{
    public class ViagemRepository : IViagemRepository
    {
        private readonly ApplicationDbContext _context;
        public ViagemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ViagemModel> Viagem => _context.Viagem.Include(c => c.Categoria);

        public ViagemModel GetViagemById(int ViagemId)
        {
            return _context.Viagem.FirstOrDefault(v => v.ViagemId == ViagemId);
        }
    }
}
