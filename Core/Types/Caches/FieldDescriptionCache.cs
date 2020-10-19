using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Core.Types.Caches
{
    public class FieldDescriptionCache<T>
    {
        private static readonly IDictionary<FieldInfo, string> DescriptionCache;

        static FieldDescriptionCache()
        {
            DescriptionCache = new ConcurrentDictionary<FieldInfo, string>();

            var type = typeof(T);
            foreach (var field in type.GetFields())
            {
                var descriptionAttribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (descriptionAttribute != null) DescriptionCache.TryAdd(field, descriptionAttribute.Description);
            }
        }

        public static bool TryGetDescription(FieldInfo fieldInfo, out string description)
        {
            return DescriptionCache.TryGetValue(fieldInfo, out description);
        }

    }
}
