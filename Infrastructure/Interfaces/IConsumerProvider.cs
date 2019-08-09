using Infrastructure.ProCampaign.Models;
using Models.DTO;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ICrmConsumerProvider
    {
        CrmConfiguration Configuration { get; set; }

        Task<CrmData> CreateParticipationAsync(
            CrmData data,
            CrmConfiguration requestWideSettings,
            bool requestConsumerId = false);

        Task<CrmData> ReadTextDocumentAsync();
    }
}
