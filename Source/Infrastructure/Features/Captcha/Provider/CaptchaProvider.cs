using Swift.Umbraco.Infrastructure.Features.Captcha.Helper;
using Swift.Umbraco.Infrastructure.Features.Interfaces;

namespace Swift.Umbraco.Infrastructure.Features.Captcha.Provider
{
    public class CaptchaProvider : IFormValidatorProvider
    {
        public bool ValidateCaptcha(string captchaResponse)
        {
            return GoogleRecaptchaHelper.ValidateReCaptchaV2(captchaResponse);
        }
    }
}
