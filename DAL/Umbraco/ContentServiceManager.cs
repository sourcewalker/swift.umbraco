using DAL.Interfaces;
using Umbraco.Core.Services;

namespace DAL.Umbraco
{
    public class ContentServiceManager : IContentServiceManager
    {
        private readonly IContentService _contentService;

        public ContentServiceManager(IContentService contentService)
        {
            _contentService = contentService;
        }
    }
}
