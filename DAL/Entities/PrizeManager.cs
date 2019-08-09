using DAL.Interfaces;
using Models.Domain;
using Models.DTO;
using Models.Mapping.Helper;
using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class PrizeManager : GenericManager<Prize>, IPrizeManager
    {
        private readonly IInstantWinMomentManager _instantMomentManager;

        public PrizeManager(IInstantWinMomentManager instantMomentManager)
        {
            _instantMomentManager = instantMomentManager;
        }

        public IEnumerable<PrizeDto> FindAll()
        {
            return GetAll().toDtos();
        }

        public PrizeDto FindById(Guid id)
        {
            return GetById(id).toDto();
        }

        public bool UpdateRemainingNumber(Guid instantMomentId, out PrizeDto prizeDto)
        {
            var instantMoment = _instantMomentManager.FindById(instantMomentId);
            var prize = GetById(instantMoment.PrizeId);
            prize.Remaining -= 1;

            prizeDto = prize.toDto();

            return Update(prize);
        }
    }
}
