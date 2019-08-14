using Models.DTO;
using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Factory;
using Swift.Umbraco.Infrastructure.InstantWin.Generator.Factory;
using Swift.Umbraco.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.InstantWin.Generator
{
    public class InstantWinProvider : IInstantWinMomentProvider
    {
        public IList<DateTimeOffset> GenerateWinningMoments(GeneratorConfig config)
        {
            var generator = GeneratorFactory.Create(ProviderConfiguration.Generator.algorithm);
            return generator.Generate(config);
        }

        public IList<(Guid Id, string Name)> AllocatePrizes(IList<Allocable> allocable, int instantWinNumber)
        {
            var allocator = AllocatorFactory.Create(ProviderConfiguration.Allocator.algorithm);
            return allocator.Allocate(allocable, instantWinNumber);
        }
    }
}
