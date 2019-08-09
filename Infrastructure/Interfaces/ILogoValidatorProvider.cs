using Infrastructure.LogoGrab.Models;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface ILogoValidatorProvider
    {
        Task<bool> ValidateLogoAsync(string base64Image, LogoGrabSettings settings);
    }
}
