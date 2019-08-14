using Swift.Umbraco.Models.DTO;

namespace Swift.Umbraco.Business.Service.Interfaces
{
    public interface IInstantWinService
    {
        (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck();
    }
}
