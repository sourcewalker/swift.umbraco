using System;
using System.ComponentModel.DataAnnotations;

namespace Trebor.Cash.In.Flash.Infrastructure.Validation
{
    public class RequiredEnum : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            var type = value.GetType();
            return type.IsEnum && Enum.IsDefined(type, value);
        }
    }
}