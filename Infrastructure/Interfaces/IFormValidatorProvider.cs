namespace Infrastructure.Interfaces
{
    public interface IFormValidatorProvider
    {
        bool ValidateCaptcha(string captchaResponse);
    }
}
