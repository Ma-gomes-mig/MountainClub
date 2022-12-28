using ProjetoSite1.Data.Interface;
using ProjetoSite1.Models;

namespace ProjetoSite1.Data.Repositories
{
    public class CategoriaRepository : EfRepository<CategoriaModel>, ICategoriaRepository

    {
        public CategoriaRepository(ApplicationDbContext dbContext) : base(dbContext) { }

    }
}
