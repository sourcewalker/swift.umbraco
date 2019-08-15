using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class FailedTransactionMap : PetaPocoMap<FailedTransaction>
    {
        public FailedTransactionMap()
        {
            TableName("FailedTransaction");
            PrimaryKey(x => x.Id, false);
            Columns(x =>
            {
                x.Ignore(y => y.Participation);
            });
        }
    }
}
