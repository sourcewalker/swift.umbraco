using System;
using System.Web;

namespace Trebor.Cash.In.Flash.Models
{
    public class LogoWinRequest
    {
        public HttpPostedFile PhotoInput { get; set; }

        public Guid ParticipationId { get; set; }

        public Guid ParticipantId { get; set; }
    }
}