using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class CountryMap : PetaPocoMap<Country>
    {
        public CountryMap()
        {
            TableName("Country");
            PrimaryKey(x => x.Id, false);
        }
    }
}
