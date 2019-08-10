using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Algorithms;
using Swift.Umbraco.Infrastructure.InstantWin.Interfaces;

namespace Swift.Umbraco.Infrastructure.InstantWin.Allocator.Factory
{
    public static class AllocatorFactory
    {
        public static IAllocator Create(AllocatorAlgorithms algorithm)
        {
            switch (algorithm)
            {
                case AllocatorAlgorithms.Blind:
                    return new BlindAlgorithm();
                case AllocatorAlgorithms.Weighted:
                    return new WeightedAlgorithm();
                case AllocatorAlgorithms.Fair:
                default:
                    return new FairAlgorithm();
            }
        }
    }
}
