using Models.DTO;
using Swift.Umbraco.Business.Manager.Interfaces;
using Swift.Umbraco.Business.Service.Interfaces;
using Swift.Umbraco.Infrastructure.Interfaces;
using Swift.Umbraco.Models.DTO;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Business.Journey
{
    public class InstantWinService : IInstantWinService
    {
        private static readonly object _instantWinLock = new object();
        private readonly IInstantWinMomentManager _instantWinManager;
        private readonly IPrizeManager _prizeManager;
        private readonly IInstantWinMomentProvider _instantWinProvider;

        public InstantWinService(
            IInstantWinMomentManager instantWinManager,
            IInstantWinMomentProvider instantWinProvider,
            IPrizeManager prizeManager)
        {
            _instantWinManager = instantWinManager;
            _instantWinProvider = instantWinProvider;
            _prizeManager = prizeManager;
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

        public (bool status, int generatedNumber) GenerateInstantWinMoments(GeneratorConfig config, List<Allocable> allocables)
        {
            var instantList = _instantWinProvider.GenerateWinningMoments(config);

            var allocatedPrizes = _instantWinProvider.AllocatePrizes(allocables, instantList.Count);

            var counter = 0;
            for (var index = 0; index < instantList.Count; index++)
            {
                var instantWin = new InstantWinMomentDto
                {
                    Id = Guid.NewGuid(),
                    PrizeId = allocatedPrizes[index].Id,
                    IsWon = false,
                    CreatedOn = DateTimeOffset.UtcNow,
                    ActivationDate = instantList[index]
                };
                _instantWinManager.Create(instantWin);
                counter++;
            }

            return (counter == instantList.Count, counter);
        }
    }
}
