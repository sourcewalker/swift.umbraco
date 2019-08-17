using Swift.Umbraco.Infrastructure.Features.Interfaces;
using Swift.Umbraco.Infrastructure.Features.LogoGrab.Helper;
using Swift.Umbraco.Infrastructure.Features.LogoGrab.Models;
using System.Threading.Tasks;

namespace Swift.Umbraco.Infrastructure.Features.LogoGrab.Provider
{
    public class LogoGrabProvider : ILogoValidatorProvider
    {
        public async Task<bool> ValidateLogoAsync(string imageFilePath, LogoGrabSettings settings)
        {
            var response = await ServiceHelper.ValidateAsync(settings, imageFilePath);

            if (response.Data.Detections[0].ConfidenceALE != null &&
                response.Data.Detections[0].ConfidenceALE > 0.5)
            {
                return true;
            }

            if (response.Data.Detections[0].ValidationFlags[0] != null &&
                response.Data.Detections[0].ValidationFlags[0] > 0.2)
            {
                return true;
            }

            return false;
        }
    }
}
