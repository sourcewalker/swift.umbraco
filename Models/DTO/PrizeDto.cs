using System;

namespace Models.DTO
{
    public class PrizeDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public int TotalNumber { get; set; }

        public int Remaining { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
