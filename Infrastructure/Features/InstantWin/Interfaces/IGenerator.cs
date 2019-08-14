using Models.DTO;
using System;
using System.Collections.Generic;

namespace Swift.Umbraco.Infrastructure.InstantWin.Interfaces
{
    public interface IGenerator
    {
        IList<DateTimeOffset> Generate(GeneratorConfig config);
    }
}
