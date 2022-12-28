using ProjetoSite1.Models;

namespace ProjetoSite1.Data.Interface
{
    public interface IUsuarioRepository
    {
        UsuarioModel Get(int id);
        IEnumerable<UsuarioModel> GetAll();
        void Insert(UsuarioModel usuario);
        void Update(UsuarioModel usuario);
        void Delete(int id);
    }
}
