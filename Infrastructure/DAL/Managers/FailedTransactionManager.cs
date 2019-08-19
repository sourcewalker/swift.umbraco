using Swift.Umbraco.Business.Manager.Interfaces;
using Swift.Umbraco.Infrastructure.DAL.Petapoco;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.Infrastructure.DAL.Entities
{
    public class FailedTransactionManager : GenericManager<FailedTransaction>, IFailedTransactionManager
    {
        public FailedTransactionManager()
        {

        }
    }
}
