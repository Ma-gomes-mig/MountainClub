using ProjetoSite1.Data.Interface;
using ProjetoSite1.Models;

namespace ProjetoSite1.Data.Repositories
{
    public class ViagemRepository : EfRepository<ViagemModel>, IViagemRepository
    {
        public ViagemRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
