using System.ComponentModel.DataAnnotations;

namespace Swift.Umbraco.Web.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}