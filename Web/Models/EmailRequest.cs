using System.ComponentModel.DataAnnotations;

namespace Trebor.Cash.In.Flash.Models
{
    public class EmailRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}