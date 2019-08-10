using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Model;
using Swift.Umbraco.Models.Domain;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.Interfaces
{
    public interface IInstantWinMomentProvider
    {
        IList<DateTime> GenerateWinningMoments();

        IList<(Guid Id, string Name)> AllocatePrizes(IList<Allocable> allocable, int instantWinNumber);
    }
}
