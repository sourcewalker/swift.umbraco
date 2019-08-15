using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Swift.Umbraco.Models.Domain
{
    //[TableName("Prize")]
    //[PrimaryKey("Id", autoIncrement = false)]
    public class Prize : EntityBase
    {
        public string Name { get; set; }

        public int Value { get; set; }

        public int TotalNumber { get; set; }

        public int Remaining { get; set; }
    }
}
