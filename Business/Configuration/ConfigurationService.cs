using Business.Interfaces;
using DAL.Interfaces;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using Business.Helper;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Business.Configuration
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IPublishedContentManager _contentManager;

        public ConfigurationService(IPublishedContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public CampaignConfiguration GetCampaignConfiguration()
        {
            var configContent = _contentManager.GetTypedContentSingleAtXPath("//configurationContainer/activations");
            return new CampaignConfiguration
            {
                StartDate = configContent.GetPropertyValue<DateTime>("campaignStartData"),
                EndDate = configContent.GetPropertyValue<DateTime>("campaignEndDate")
            };
        }

        public string GetStaticPagePathByName(string name)
        {
            var staticPage = _contentManager.GetTypedContentAtXPath("//specificStaticPage")
                                            .First(c => c.Name == name);
            return staticPage.GetPath();
        }

        public string GetPageUrlByName(string name)
        {
            var staticPage = _contentManager.GetTypedContentAtXPath("//homepage")
                                            .First()
                                            .Descendants()
                                            .First(c => c.Name == name);
            return staticPage.GetPath();
        }

        public IEnumerable<IPublishedContent> GetNotRedirectedPages()
        {
            return _contentManager.GetTypedContentSingleAtXPath("//configurationContainer/activations")
                                                   .GetPropertyValue<IEnumerable<IPublishedContent>>("notRedirectedPages");
        }
    }
}
