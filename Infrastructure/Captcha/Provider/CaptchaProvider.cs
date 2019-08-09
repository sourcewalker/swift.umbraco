using Infrastructure.Captcha.Helper;
using Infrastructure.Interfaces;

namespace Infrastructure.Captcha.Provider
{
    public class CaptchaProvider : IFormValidatorProvider
    {
        public bool ValidateCaptcha(string captchaResponse)
        {
            return GoogleRecaptchaHelper.ValidateReCaptchaV2(captchaResponse);
        }
    }
}
