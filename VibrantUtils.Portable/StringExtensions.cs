using System.Globalization;

namespace System
{
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// Uses the <see cref="CultureInfo.InvariantCulture"/> format provider
        /// </summary>
        /// <remarks>This is an alias for <see cref="StringExtensions.FormatInvariant"/></remarks>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string Fi(this string self, params object[] args) { return FormatInvariant(self, args); }

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// Uses the <see cref="CultureInfo.InvariantCulture"/> format provider
        /// </summary>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string FormatInvariant(this string self, params object[] args)
        {
            return Format(self, CultureInfo.InvariantCulture, args);
        }

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// Uses the <see cref="CultureInfo.CurrentUICulture"/> format provider
        /// </summary>
        /// <remarks>This is an alias for <see cref="StringExtensions.Format(string, object[])"/></remarks>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string F(this string self, params object[] args) { return Format(self, args); }

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// Uses the <see cref="CultureInfo.CurrentUICulture"/> format provider
        /// </summary>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string Format(this string self, params object[] args)
        {
            return Format(self, CultureInfo.CurrentUICulture, args);
        }

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// A specified parameter supplies culture-specific formatting information.
        /// </summary>
        /// <remarks>This is an alias for <see cref="StringExtensions.Format(string, IFormatProvider, object[])"/></remarks>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string F(this string self, IFormatProvider formatProvider, params object[] args) { return Format(self, formatProvider, args); }

        /// <summary>
        /// Replaces each format item in a specified string with the text equivalent of a corresponding object's value.
        /// A specified parameter supplies culture-specific formatting information.
        /// </summary>
        /// <param name="self">A composite format string (see <see cref="String.Format"/>).</param>
        /// <param name="formatProvider">An object that supplies culture-specific formatting information.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <returns>A copy of <see cref="self"/> in which the format items have been replaced by the string representation of the corresponding objects in <see cref="args"/>.</returns>
        public static string Format(this string self, IFormatProvider formatProvider, params object[] args)
        {
            return String.Format(formatProvider, self, args);
        }
    }
}
