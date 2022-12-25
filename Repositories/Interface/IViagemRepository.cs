using ProjetoSite1.Models;

namespace ProjetoSite1.Repositories.Interface
{
    public interface IViagemRepository
    {
        IEnumerable<ViagemModel> Viagem { get; }
        ViagemModel GetViagemById(int ViagemId);
    }
}
