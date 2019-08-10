using Swift.Umbraco.Infrastructure.LogoGrab.Models;
using System.Threading.Tasks;

namespace Swift.Umbraco.Infrastructure.Interfaces
{
    public interface ILogoValidatorProvider
    {
        Task<bool> ValidateLogoAsync(string base64Image, LogoGrabSettings settings);
    }
}
