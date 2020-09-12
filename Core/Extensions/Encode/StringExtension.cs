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

            var encoding = Encoding.GetEncoding(originalString);
            if (encoding == Encoding.UTF8)
            {
                return originalString;
            }

            return Encoding.UTF8.GetString(encoding.GetBytes(originalString));
        }
    }
}
