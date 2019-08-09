using Infrastructure.InstantWin.Allocator.Model;
using System;
using System.Collections.Generic;

namespace Infrastructure.InstantWin.Interfaces
{
    public interface IAllocator
    {
        IList<(Guid Id, string Name)> Allocate(IList<Allocable> allocable, int instantWinNumber);
    }
}
