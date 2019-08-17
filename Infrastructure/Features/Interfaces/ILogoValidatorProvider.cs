using Swift.Umbraco.Infrastructure.Features.LogoGrab.Models;
using System.Threading.Tasks;

namespace Swift.Umbraco.Infrastructure.Features.Interfaces
{
    public interface ILogoValidatorProvider
    {
        Task<bool> ValidateLogoAsync(string base64Image, LogoGrabSettings settings);
    }
}
