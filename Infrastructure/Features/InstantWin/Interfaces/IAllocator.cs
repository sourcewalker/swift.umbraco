using Swift.Umbraco.Infrastructure.InstantWin.Allocator.Model;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.InstantWin.Interfaces
{
    public interface IAllocator
    {
        IList<(Guid Id, string Name)> Allocate(IList<Allocable> allocable, int instantWinNumber);
    }
}
