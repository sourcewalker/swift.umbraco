namespace Swift.Umbraco.Infrastructure.Features.Interfaces
{
    public interface IFormValidatorProvider
    {
        bool ValidateCaptcha(string captchaResponse);
    }
}
