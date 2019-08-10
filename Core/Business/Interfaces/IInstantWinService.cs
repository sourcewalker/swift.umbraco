using Swift.Umbraco.Models.DTO;

namespace Swift.Umbraco.Business.Interfaces
{
    public interface IInstantWinService
    {
        (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck();

        int GetCongratulationPageId();

        int GetLosePageId();
    }
}
