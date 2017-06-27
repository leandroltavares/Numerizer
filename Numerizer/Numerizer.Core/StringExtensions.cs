using System;
using System.Threading;
using System.Text.RegularExpressions;

namespace Numerizer.Core
{
    public static class StringExtensions
    {
        /// <summary>
        /// Dehumanize the specified string
        /// </summary>
        /// <returns>The dehumanize.</returns>
        /// <param name="source">String to be dehumanized</param>
        public static long? Dehumanize(this string source)
        {
            //var currentCulture = Thread.CurrentThread.CurrentCulture;

            source = SanitizeWhiteSpaces(source);

            return new PTBRDehumanizer().DehumanizeCardinal(source);

            return long.MaxValue;
        }

        public static string SanitizeWhiteSpaces(this string source)
        {
            return Regex.Replace(source, @"[\s]+", " ").Trim();
        }

    }
}
