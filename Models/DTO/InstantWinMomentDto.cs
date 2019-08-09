using System;

namespace Models.DTO
{
    public class InstantWinMomentDto
    {
        public Guid Id { get; set; }

        public Guid PrizeId { get; set; }

        public PrizeDto Prize { get; set; }

        public DateTime ActivationDate { get; set; }

        public bool IsWon { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
