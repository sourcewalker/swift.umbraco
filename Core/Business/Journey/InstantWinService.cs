using Swift.Umbraco.Business.Manager.Interfaces;
using Swift.Umbraco.Business.Service.Interfaces;
using Swift.Umbraco.Models.DTO;

namespace Swift.Umbraco.Business.Journey
{
    public class InstantWinService : IInstantWinService
    {
        private static readonly object _instantWinLock = new object();
        private readonly IInstantWinMomentManager _instantWinManager;
        private readonly IPrizeManager _prizeManager;
        private readonly IPublishedContentManager _contentManager;

        public InstantWinService(
            IInstantWinMomentManager instantWinManager,
            IPrizeManager prizeManager,
            IPublishedContentManager contentManager)
        {
            _instantWinManager = instantWinManager;
            _prizeManager = prizeManager;
            _contentManager = contentManager;
        }

        public (bool isWinner, PrizeDto prize, InstantWinMomentDto instantWin) WinCheck()
        {
            PrizeDto prizeDto = null;
            InstantWinMomentDto momentDto = null;
            var isWinner = false;

            lock (_instantWinLock)
            {
                var winMoment = _instantWinManager.CheckAvailableWinningMoment();
                isWinner = winMoment != null;

                if (isWinner)
                {

                    _prizeManager.UpdateRemainingNumber(winMoment.Id, out prizeDto);
                    _instantWinManager.MarkAsWon(winMoment);
                    momentDto = winMoment;
                }
            }

            return (isWinner, prizeDto, momentDto);
        }
    }
}
