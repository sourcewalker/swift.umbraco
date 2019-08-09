using DAL.Interfaces;
using Umbraco.Core.Services;

namespace DAL.Umbraco
{
    public class MediaServiceManager : IMediaServiceManager
    {
        private readonly IMediaService _mediaService;

        public MediaServiceManager(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }
    }
}
