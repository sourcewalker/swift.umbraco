using System;

namespace Models.DTO
{
    public class CountryDto
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Culture { get; set; }
    }
}
