﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Models.Domain;

namespace DAL.Entities
{
    public class FailedTransactionManager : GenericManager<FailedTransaction>, IFailedTransactionManager
    {
        public FailedTransactionManager()
        {
            
        }
    }
}
