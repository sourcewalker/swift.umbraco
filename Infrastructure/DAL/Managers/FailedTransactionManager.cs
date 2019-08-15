using Swift.Umbraco.Business.Manager.Interfaces;
using Swift.Umbraco.DAL.Petapoco;
using Swift.Umbraco.Models.Domain;

namespace Swift.Umbraco.DAL.Entities
{
    public class FailedTransactionManager : GenericManager<FailedTransaction>, IFailedTransactionManager
    {
        public FailedTransactionManager()
        {

        }
    }
}
