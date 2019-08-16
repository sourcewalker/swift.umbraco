using System;
using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Swift.Umbraco.Models.Domain
{
    [TableName("Participant")]
    [PrimaryKey("Id", autoIncrement = false)]
    public class Participant : EntityBase
    {
        public string Email { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        [ForeignKey(typeof(Consumer), Name = "FK_Participant_Consumer")]
        public Guid? ConsumerCrmId { get; set; }

        [ResultColumn]
        public Consumer Consumer { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        public DateTimeOffset LastWonDate { get; set; }

        [NullSetting(NullSetting = NullSettings.Null)]
        public DateTimeOffset LastParticipatedDate { get; set; }
    }
}
