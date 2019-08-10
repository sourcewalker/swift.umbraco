using Swift.Umbraco.Infrastructure.InstantWin.Generator.Algorithms;
using Swift.Umbraco.Infrastructure.InstantWin.Interfaces;

namespace Swift.Umbraco.Infrastructure.InstantWin.Generator.Factory
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
