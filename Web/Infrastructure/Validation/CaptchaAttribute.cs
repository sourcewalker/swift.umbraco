using Business.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;

namespace Trebor.Cash.In.Flash.Infrastructure.Validation
{
    public class Captcha : ValidationAttribute
    {

        protected override ValidationResult IsValid(
            object value,
            ValidationContext validationContext)
        {
            var dependencyResolver = GlobalConfiguration.Configuration.DependencyResolver;
            var validationService = (IValidationService)dependencyResolver.GetService(typeof(IValidationService));

            return validationService.ValidateCaptcha((string)value) ?
                        ValidationResult.Success :
                        new ValidationResult(ErrorMessage);
        }
    }
}