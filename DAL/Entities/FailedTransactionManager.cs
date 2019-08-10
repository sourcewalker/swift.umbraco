using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swift.Umbraco.DAL.Interfaces;
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
