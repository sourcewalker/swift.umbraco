using Models.DTO;

namespace Business.Interfaces
{
    public interface IInstantWinService
    {
        (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck();

        int GetCongratulationPageId();

        int GetLosePageId();
    }
}
