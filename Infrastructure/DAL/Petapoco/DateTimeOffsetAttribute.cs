using PetaPoco;
using System;

namespace Swift.Umbraco.DAL.Petapoco
{
    public class DateTimeOffsetAttribute : ValueConverterAttribute
    {
        public override object ConvertFromDb(object value)
        {
            if (!(value is DateTimeOffset))
                return DateTimeOffset.Parse(Convert.ToString(value));
            return value;
        }

        public override object ConvertToDb(object value)
        {
            if (!(value is DateTimeOffset)) return null;
            return (DateTimeOffset)value;
        }
    }
}
