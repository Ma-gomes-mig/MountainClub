using ProjetoSite1.Models;

namespace ProjetoSite1.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<CategoriaModel> Categoria { get; }
    }
}
