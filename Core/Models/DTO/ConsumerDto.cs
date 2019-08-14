using Swift.Umbraco.Models.Enum;
using System;

namespace Swift.Umbraco.Models.DTO
{
    public class ConsumerDto
    {
        public Guid Id { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset UpdatedOn { get; set; }

        public Guid CountryId { get; set; }

        public CountryDto Country { get; set; }

        public Countries CountryEnum { get; set; }

        public string EmailHash { get; set; }

        public string ConsumerId { get; set; }
    }
}
