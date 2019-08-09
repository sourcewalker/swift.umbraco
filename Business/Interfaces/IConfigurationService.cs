using System.Collections.Generic;
using Models.DTO;
using Umbraco.Core.Models;

namespace Business.Interfaces
{
    public interface IConfigurationService
    {
        CampaignConfiguration GetCampaignConfiguration();

        string GetStaticPagePathByName(string name);

        string GetPageUrlByName(string name);

        IEnumerable<IPublishedContent> GetNotRedirectedPages();

    }
}
