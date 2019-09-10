using PetaPoco.FluentMappings;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Mapping
{
    public class ParticipantMap : PetaPocoMap<Participant>
    {
        public ParticipantMap()
        {
            TableName("Participant");
            PrimaryKey(x => x.Id, false);
            Columns(x =>
            {
                x.Ignore(y => y.Consumer);
            });
        }
    }
}