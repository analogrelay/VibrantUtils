using System.Globalization;

namespace System
{
    public static class StringExtensions
    {
        public static string Fi(this string self, params object[] args) { return FormatInvariant(self, args); }
        public static string FormatInvariant(this string self, params object[] args)
        {
            return Format(self, CultureInfo.InvariantCulture, args);
        }

        public static string F(this string self, params object[] args) { return Format(self, args); }
        public static string Format(this string self, params object[] args)
        {
            return Format(self, CultureInfo.CurrentUICulture, args);
        }

        public static string F(this string self, IFormatProvider formatProvider, params object[] args) { return Format(self, formatProvider, args); }
        public static string Format(this string self, IFormatProvider formatProvider, params object[] args)
        {
            return String.Format(formatProvider, self, args);
        }
    }
}
