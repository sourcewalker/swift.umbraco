using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class PrizeMap : PetaPocoMap<Prize>
    {
        public PrizeMap()
        {
            TableName("Prize");
            PrimaryKey(x => x.Id, false);
        }
    }
}