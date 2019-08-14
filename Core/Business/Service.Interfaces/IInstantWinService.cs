using Models.DTO;
using Swift.Umbraco.Models.DTO;
using System.Collections.Generic;

namespace Swift.Umbraco.Business.Service.Interfaces
{
    public interface IInstantWinService
    {
        (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck();

        (bool status, int generatedNumber) GenerateInstantWinMoments(
            GeneratorConfig config,
            List<Allocable> allocables);
    }
}
