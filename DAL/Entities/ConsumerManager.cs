using DAL.Interfaces;
using Models.Domain;
using Models.Enum;
using System;
using System.Linq;
using Umbraco.Core.Persistence;

namespace DAL.Entities
{
    public class ConsumerManager : GenericManager<Consumer>, IConsumerManager
    {
        private readonly ICountryManager _countryManager;

        public ConsumerManager(ICountryManager countryManager)
        {
            _countryManager = countryManager;
        }

        public Guid GetOrCreateConsumerId(string consumerId, Countries country, string emailHash)
        {

            var countryDto = _countryManager.GetCountryByCode(country);

            if (IsAlreadyExistingConsumerId(country, emailHash, out var consumerCrmId))
            {
                return consumerCrmId;
            }

            var consumer = new Consumer
            {
                CountryId = countryDto.Id,
                ConsumerId = consumerId,
                EmailHash = emailHash
            };
            return Create(consumer);
        }

        public bool IsAlreadyExistingConsumerId(Countries country, string emailHash, out Guid consumerCrmId)
        {
            consumerCrmId = default;

            var countryDto = _countryManager.GetCountryByCode(country);

            //var query = new Sql()
            //                .Select("*")
            //                .From<Consumer>(_sqlProvider)
            //                .Where<Consumer>(consumer =>
            //                            consumer.CountryId == countryDto.Id &&
            //                            consumer.EmailHash == emailHash, _sqlProvider);
            var sqlQuery = "SELECT * FROM Consumer WHERE CountryId = @0 AND EmailHash = @1";
            var result = _database.FirstOrDefault<Consumer>(sqlQuery, countryDto.Id, emailHash);

            if (result == null)
            {
                return false;
            }

            consumerCrmId = result.Id;
            return true;
        }
    }
}
