using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Factory;
using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Model;
using Swift.Umbraco.Infrastructure.InstantWin.Generator.Factory;
using Swift.Umbraco.Infrastructure.Interfaces;
using Swift.Umbraco.Models.Domain;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.InstantWin.Generator
{
    public class InstantWinProvider : IInstantWinMomentProvider
    {
        public IList<DateTime> GenerateWinningMoments()
        {
            var generator = GeneratorFactory.Create(ProviderConfiguration.Generator.algorithm);
            return generator.Generate();
        }

        public IList<(Guid Id, string Name)> AllocatePrizes(IList<Allocable> allocable, int instantWinNumber)
        {
            var allocator = AllocatorFactory.Create(ProviderConfiguration.Allocator.algorithm);
            return allocator.Allocate(allocable, instantWinNumber);
        }
    }
}
