using Models.Enum;
using System;

namespace Models.DTO
{
    public class ConsumerDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public Guid CountryId { get; set; }

        public CountryDto Country { get; set; }

        public Countries CountryEnum { get; set; }

        public string EmailHash { get; set; }

        public string ConsumerId { get; set; }
    }
}
