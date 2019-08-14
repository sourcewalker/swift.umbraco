using Models.DTO;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.Interfaces
{
    public interface IInstantWinMomentProvider
    {
        IList<DateTimeOffset> GenerateWinningMoments(GeneratorConfig config);

        IList<(Guid Id, string Name)> AllocatePrizes(IList<Allocable> allocable, int instantWinNumber);
    }
}
