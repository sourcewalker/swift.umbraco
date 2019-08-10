using System.Collections.Generic;
using Umbraco.Core.Models;

namespace Swift.Umbraco.DAL.Interfaces
{
    public interface IPublishedContentManager
    {
        IEnumerable<IPublishedContent> GetTypedContentAtXPath(string path);

        IPublishedContent GetTypedContentById(int id);

        IPublishedContent GetTypedContentSingleAtXPath(string xpath);

        IPublishedContent GetTypedMediaById(int id);

        IEnumerable<IPublishedContent> GetTypedSearch(string term);

        IEnumerable<IPublishedContent> GetTypedContentAtRoot();
    }
}
