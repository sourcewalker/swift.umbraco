using Swift.Umbraco.DAL.Interfaces;
using Umbraco.Core.Services;

namespace Swift.Umbraco.DAL.Umbraco
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
