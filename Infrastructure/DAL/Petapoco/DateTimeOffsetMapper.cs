using System;
using System.Reflection;
using Umbraco.Core.Persistence;

namespace Swift.Umbraco.DAL.Petapoco
{
    public class DateTimeOffsetMapper : IMapper
    {
        public Func<object, object> GetFromDbConverter(PropertyInfo pi, Type SourceType)
        {
            throw new NotImplementedException();
        }

        public void GetTableInfo(Type t, TableInfo ti)
        {
            throw new NotImplementedException();
        }

        public Func<object, object> GetToDbConverter(Type SourceType)
        {
            throw new NotImplementedException();
        }

        public bool MapPropertyToColumn(Type t, PropertyInfo pi, ref string columnName, ref bool resultColumn)
        {
            throw new NotImplementedException();
        }
    }
}
