using Swift.Umbraco.Business.Manager.Interfaces;
using Umbraco.Core.Services;

namespace Swift.Umbraco.Infrastructure.DAL.Umbraco
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
