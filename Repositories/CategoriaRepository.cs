using ProjetoSite1.Data;
using ProjetoSite1.Models;
using ProjetoSite1.Repositories.Interface;

namespace ProjetoSite1.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriaRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CategoriaModel> Categoria => _context.Categoria ;
    }
}
