using ProjetoSite1.Models;

namespace ProjetoSite1.Data.Interface
{
    public interface IViagemRepository
    {
        ViagemModel Get(int id);
        IEnumerable<ViagemModel> GetAll();
        void Insert(ViagemModel viagem);
        void Update(ViagemModel viagem);
        void Delete(int id);
    }
}
