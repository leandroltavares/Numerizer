using System;
using System.Threading;
using System.Text.RegularExpressions;
using System.Collections.Generic;

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

        public static IEnumerable<string> SplitAndKeep(this string s, string[] delimiters)
        {
            var currentString = s;

            foreach (var delimiter in delimiters)
            {
                int index = currentString.IndexOf(delimiter, StringComparison.Ordinal);

                if (index != -1)
                {
                    var part = currentString.Substring(0, index + delimiter.Length);

                    yield return part;

                    currentString = currentString.Substring(part.Length, currentString.Length - part.Length);
                }
            }

            if (currentString.Length > 0)
                yield return currentString;

        }
    }
}
