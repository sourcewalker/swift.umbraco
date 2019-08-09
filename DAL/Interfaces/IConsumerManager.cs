using Models.Enum;
using System;

namespace DAL.Interfaces
{
    public interface IConsumerManager
    {
        Guid GetOrCreateConsumerId(string consumerId, Countries country, string EmailHash);

        bool IsAlreadyExistingConsumerId(Countries country, string emailHash, out Guid consumerCrmId);
    }
}
