﻿using Swift.Umbraco.Models.DTO;
using System.Threading.Tasks;

namespace Swift.Umbraco.Business.Service.Interfaces
{
    public interface ISynchronizationService
    {
        Task<string> GetPrivacyPolicyTextAsync();

        Task<CrmResponse> SendDataToSynchronizeAsync(CrmDto data);
    }
}
