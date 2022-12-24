using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoSite1.Models;

namespace ProjetoSite1.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<ViagemModel> Viagem { get; set; }
        public DbSet<CategoriaModel> Categoria { get; set; }
    }
}