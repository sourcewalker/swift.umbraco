using System.ComponentModel.DataAnnotations;

namespace Swift.Umbraco.Web.Infrastructure.Validation
{
    public class True : ValidationAttribute
    {
        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult(ErrorMessage);

            return (bool)value ?
                ValidationResult.Success :
                new ValidationResult(ErrorMessage);
        }
    }
}