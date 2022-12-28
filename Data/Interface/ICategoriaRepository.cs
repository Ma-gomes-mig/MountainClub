using ProjetoSite1.Models;
using System.Collections.Generic;

namespace ProjetoSite1.Data.Interface
{
    public interface ICategoriaRepository
    {
        CategoriaModel Get(int id);
        IEnumerable<CategoriaModel> GetAll();
    }
}
