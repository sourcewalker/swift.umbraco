using System;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Swift.Umbraco.Models.Domain
{
    public class EntityBase
    {
        //[PrimaryKeyColumn(AutoIncrement = false)]
        public Guid Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        //[NullSetting(NullSetting = NullSettings.Null)]
        public DateTimeOffset UpdatedOn { get; set; }
    }
}
