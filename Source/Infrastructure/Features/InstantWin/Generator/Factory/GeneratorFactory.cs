using Swift.Umbraco.Infrastructure.Features.InstantWin.Generator.Algorithms;
using Swift.Umbraco.Infrastructure.Features.InstantWin.Interfaces;

namespace Swift.Umbraco.Infrastructure.Features.InstantWin.Generator.Factory
{
    public static class GeneratorFactory
    {
        public static IGenerator Create(GeneratorAlgorithms algorithm)
        {
            switch (algorithm)
            {
                case GeneratorAlgorithms.DivideAndConquer:
                default:
                    return new DivideAndConquerAlgorithm();
            }
        }
    }
}
