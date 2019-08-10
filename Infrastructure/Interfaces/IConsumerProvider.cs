﻿using Swift.Umbraco.Infrastructure.ProCampaign.Models;
using Swift.Umbraco.Models.DTO;
using System.Threading.Tasks;

namespace Swift.Umbraco.Infrastructure.Interfaces
{
    public interface ICrmConsumerProvider
    {
        CrmConfiguration Configuration { get; set; }

        Task<CrmData> CreateParticipationAsync(
            CrmData data,
            CrmConfiguration requestWideSettings,
            bool requestConsumerId = false);

        Task<CrmData> ReadTextDocumentAsync();
    }
}
