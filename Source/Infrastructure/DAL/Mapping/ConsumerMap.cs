using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class ConsumerMap : PetaPocoMap<Consumer>
    {
        public ConsumerMap()
        {
            TableName("Consumer");
            PrimaryKey(x => x.Id, false);
            Columns(x => 
            {
                x.Ignore(y => y.Country);
            });
        }
    }
}
