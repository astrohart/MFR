using System;
using System.Text.RegularExpressions;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Helper methods for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the
        /// <paramref
        ///     name="value" />
        /// . The <paramref name="search" /> parameter may contain
        /// a Regular Expression (regex). Case is ignored.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search and
        /// replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the string.
        /// May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any found occurrences of
        /// <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns>
        /// String containing the result.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required parameters, <paramref name="value" />,
        /// <paramref name="search" />, or <paramref name="replacement" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public static string RegexReplaceNoCase(this string value,
            string search, string replacement)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replacement)
                );

            return Regex.Replace(
                value, search, replacement, RegexOptions.IgnoreCase
            );
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the
        /// <paramref
        ///     name="value" />
        /// . The <paramref name="search" /> parameter may contain
        /// a Regular Expression (regex).
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search and
        /// replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the string.
        /// May contain a regular expression.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any found occurrences of
        /// <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns>
        /// String containing the result.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required parameters, <paramref name="value" />,
        /// <paramref name="search" />, or <paramref name="replacement" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public static string RegexReplaceWithCase(this string value,
            string search, string replacement)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replacement)
                );

            return Regex.Replace(value, search, replacement);
        }

        /// <summary>
        /// Replaces the string specified by <paramref name="search" /> by the
        /// <paramref name="replacement" /> string in the
        /// <paramref
        ///     name="value" />
        /// , ignoring case.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the data in which the search and
        /// replace operation is to be performed.
        /// </param>
        /// <param name="search">
        /// (Required.) String containing the data to be found in the string.
        /// </param>
        /// <param name="replacement">
        /// (Required.) String containing the data that any found occurrences of
        /// <paramref name="search" /> are to be substituted with.
        /// </param>
        /// <returns>
        /// String containing the result.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if any of the required parameters, <paramref name="value" />,
        /// <paramref name="search" />, or <paramref name="replacement" />, are
        /// passed blank or <see langword="null" /> strings for values.
        /// </exception>
        public static string ReplaceNoCase(this string value, string search,
            string replacement)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(search))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(search)
                );
            if (string.IsNullOrWhiteSpace(replacement))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replacement)
                );

            return Regex.Replace(
                value, Regex.Escape(search), replacement.Replace("$", "$$"),
                RegexOptions.IgnoreCase
            );
        }

        /// <summary>
        /// Splits a string <paramref name="value" /> on a provided
        /// <paramref name="delimiter" />.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to be tokenized.
        /// </param>
        /// <param name="delimiter">
        /// (Required.) String containing the delimiter on which the
        /// <paramref
        ///     name="value" />
        /// should be split.
        /// </param>
        /// <returns>
        /// An array whose elements contain the substrings that were split on
        /// the provided <paramref name="delimiter" />.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="delimiter" />, are passed blank or
        /// <see langword="null" /> strings for values.
        /// </exception>
        public static string[] SplitOn(this string value, string delimiter)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(delimiter))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(delimiter)
                );

            return value.Split(
                new[] {delimiter}, StringSplitOptions.RemoveEmptyEntries
            );
        }
    }
}