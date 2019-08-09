using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Models.Domain
{
    [TableName("Country")]
    [PrimaryKey("Id", autoIncrement = false)]
    public class Country : EntityBase
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }
    }
}
