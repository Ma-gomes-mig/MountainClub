using ProjetoSite1.Data.Interface;
using ProjetoSite1.Models;

namespace ProjetoSite1.Data.Repositories
{
    public class UsuarioRepository :EfRepository<UsuarioModel>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
