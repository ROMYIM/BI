using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Core.Extensions.Annotation
{
    public static class DescriptionExtension
    {
        public static string GetDescription(this Enum @enum)
        {
            Type enumType = @enum.GetType();

            var fieldName = Enum.GetName(enumType, @enum);
            if (fieldName != null)
            {
                var field = enumType.GetField(fieldName);
                var description = field.GetCustomAttribute<DescriptionAttribute>()?.Description;
                if (string.IsNullOrWhiteSpace(description))
                {
                    description = fieldName;
                }
                return description;
            }
            return fieldName;
        }
    }
}
