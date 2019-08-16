using Models.DTO;
using Swift.Umbraco.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Swift.Umbraco.Business.Service.Interfaces
{
    public interface IInstantWinService
    {
        (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck();

        Task<(bool status, int generatedNumber)> GenerateInstantWinMoments(
            GeneratorConfig config,
            List<Allocable> allocables);

        Task<IEnumerable<PrizeDto>> GetPrizes();

        Task<IEnumerable<string>> GetLimitOptions();
    }
}
