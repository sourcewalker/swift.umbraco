using Models.DTO;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISynchronizationService
    {
        Task<string> GetPrivacyPolicyTextAsync();

        Task<CrmResponse> SendDataToSynchronizeAsync(CrmDto data);
    }
}
