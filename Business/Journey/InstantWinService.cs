using Business.Interfaces;
using DAL.Interfaces;
using Models.DTO;
using System.Linq;

namespace Business.Journey
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

        public int GetCongratulationPageId()
        {
            var congratsPage = _contentManager.GetTypedContentAtXPath("//congratulations")
                                            .First(c => c.Name == "Congratulations");
            return congratsPage.Id;
        }

        public int GetLosePageId()
        {
            var lostPage = _contentManager.GetTypedContentAtXPath("//lost")
                                            .First(c => c.Name == "Lose");
            return lostPage.Id;
        }
    }
}
