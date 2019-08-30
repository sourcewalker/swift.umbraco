using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class InstantWinMomentMap : PetaPocoMap<InstantWinMoment>
    {
        public InstantWinMomentMap()
        {
            TableName("InstantWinMoment");
            PrimaryKey(x => x.Id, false);
            Columns(x =>
            {
                x.Ignore(y => y.Prize);
            });
        }
    }
}
