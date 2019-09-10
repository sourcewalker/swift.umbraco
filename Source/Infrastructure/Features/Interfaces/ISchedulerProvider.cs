using Swift.Umbraco.Infrastructure.Features.Hangfire;
using Swift.Umbraco.Infrastructure.Features.ProCampaign.Models;
using Swift.Umbraco.Models.DTO;
using System;
using System.Threading.Tasks;

namespace Swift.Umbraco.Infrastructure.Features.Interfaces
{
    public interface ISchedulerProvider
    {

        Task RetryParticipationSyncRecurrently(
            CrmData data,
            CrmConfiguration requestWideSettings,
            CronEnum occurence,
            bool requestConsumerId = false);


        Task<object> RetryParticipationSyncImmediately(
            CrmData data,
            CrmConfiguration requestWideSettings,
            bool requestConsumerId = false);

        Task DelayedParticipationRetrySync(
            CrmData data,
            CrmConfiguration requestWideSettings,
            TimeSpan delay,
            bool requestConsumerId = false);
    }
}
