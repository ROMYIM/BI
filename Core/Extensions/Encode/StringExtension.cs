using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions.Encode
{
    public static class StringExtension
    {
        public static string ToUTF8(this string originalString)
        {
            if (string.IsNullOrWhiteSpace(originalString))
            {
                return originalString;
            }

            if (originalString.AsSpan().Contains('\u0000'))
            {
                originalString = originalString.Replace("\u0000", string.Empty);
            }
                
            var encoding = Encoding.UTF8;
            return encoding.GetString(encoding.GetBytes(originalString));
        }
    }
}
