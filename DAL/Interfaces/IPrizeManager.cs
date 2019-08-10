﻿using Swift.Umbraco.Models.DTO;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.DAL.Interfaces
{
    public interface IPrizeManager
    {
        IEnumerable<PrizeDto> FindAll();

        PrizeDto FindById(Guid id);

        bool UpdateRemainingNumber(Guid instantMomentId, out PrizeDto prize);
    }
}
