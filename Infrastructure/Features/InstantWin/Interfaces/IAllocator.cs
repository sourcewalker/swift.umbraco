using Models.DTO;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.InstantWin.Interfaces
{
    public interface IAllocator
    {
        IList<(Guid Id, string Name)> Allocate(IList<Allocable> allocable, int instantWinNumber);
    }
}
