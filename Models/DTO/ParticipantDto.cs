using Models.Enum;
using System;

namespace Models.DTO
{
    public class ParticipantDto
    {
        public Guid Id { get; set; }

        public string Email { get; set; }

        public Countries Country { get; set; }

        public Guid? ConsumerCrmId { get; set; }

        public string ConsumerId { get; set; }

        public ConsumerDto Consumer { get; set; }

        public DateTime LastWonDate { get; set; }

        public DateTime LastParticipatedDate { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
