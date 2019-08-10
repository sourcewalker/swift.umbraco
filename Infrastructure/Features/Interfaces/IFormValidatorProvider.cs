namespace Swift.Umbraco.Infrastructure.Interfaces
{
    public interface IFormValidatorProvider
    {
        bool ValidateCaptcha(string captchaResponse);
    }
}
