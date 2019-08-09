using Infrastructure.InstantWin.Allocator.Factory;
using Infrastructure.InstantWin.Allocator.Model;
using Infrastructure.InstantWin.Generator.Factory;
using Infrastructure.Interfaces;
using Models.Domain;
using System;
using System.Collections.Generic;

namespace Infrastructure.InstantWin.Generator
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
