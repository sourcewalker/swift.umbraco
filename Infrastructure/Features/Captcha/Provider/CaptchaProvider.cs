using Swift.Umbraco.Infrastructure.Captcha.Helper;
using Swift.Umbraco.Infrastructure.Interfaces;

namespace Swift.Umbraco.Infrastructure.Captcha.Provider
{
    public class CaptchaProvider : IFormValidatorProvider
    {
        public bool ValidateCaptcha(string captchaResponse)
        {
            return GoogleRecaptchaHelper.ValidateReCaptchaV2(captchaResponse);
        }
    }
}
