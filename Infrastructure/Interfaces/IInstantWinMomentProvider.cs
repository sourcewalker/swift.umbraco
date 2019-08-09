using Infrastructure.InstantWin.Allocator.Model;
using Models.Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.Interfaces
{
    public interface IInstantWinMomentProvider
    {
        IList<DateTime> GenerateWinningMoments();

        IList<(Guid Id, string Name)> AllocatePrizes(IList<Allocable> allocable, int instantWinNumber);
    }
}
