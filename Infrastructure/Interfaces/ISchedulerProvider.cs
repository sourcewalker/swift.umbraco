using Infrastructure.Hangfire;
using Infrastructure.ProCampaign.Models;
using Models.DTO;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
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
