using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class ParticipationMap : PetaPocoMap<Participation>
    {
        public ParticipationMap()
        {
            TableName("Participation");
            PrimaryKey(x => x.Id, false);
            Columns(x =>
            {
                x.Ignore(y => y.Country);
                x.Ignore(y => y.Prize);
                x.Ignore(y => y.InstantWinMoment);
                x.Ignore(y => y.Participant);
            });
        }
    }
}