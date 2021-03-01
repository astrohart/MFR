using System;
using System.Linq;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Searches for matches to textual-search criteria patterns and regexes in
    /// the pathnames of folders, according to rules specified by configuration
    /// settings.
    /// </summary>
    public class FolderNameMatcher : TextExpressionMatcherBase

    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FolderNameMatcher" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <remarks>
        /// NOTE: This constructor is marked as <c>internal</c>. This is to
        /// limit the scope of invocation to abstract factories only.
        /// <para />
        /// Clients who want to new up an instance of this class directly must
        /// use the <c>public</c> constructor.
        /// </remarks>
        internal FolderNameMatcher()
        {
            // TODO: Add default object initialization code here
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcherBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public FolderNameMatcher(IConfiguration configuration) : base(
            configuration
        ) { }

        /// <summary>
        /// Determines whether a <paramref name="source" /> string is a match
        /// against a <paramref name="pattern" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the value that the found text is to be
        /// replaced with. Cannot be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// are passed blank or <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="source" /> is a match
        /// against the provided <paramref name="pattern" />; <c>false</c> if no
        /// matches are found.
        /// </returns>
        public override bool IsMatch(string source, string pattern,
            string dest = "")
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );
            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            if (!Configuration.MatchWholeWord)
            {
                if (Configuration.MatchCase)
                    return source.Contains(pattern) &&
                           (pattern.Contains(dest) || !source.Contains(dest));

                return source.ToLowerInvariant()
                           .Contains(pattern.ToLowerInvariant()) &&
                       (pattern.ToLowerInvariant()
                            .Contains(dest.ToLowerInvariant()) ||
                        !source.ToLowerInvariant()
                            .Contains(dest.ToLowerInvariant()));
            }

            /*
             * OKAY, a whole-word search on a folder path is somewhat different than for a file.
             * For a folder, it's made up of parts, each of which are delimited by a backslash (@'\').
             * Split the string along the backslashes.  In a whole-word search, if any part matches the
             * pattern exactly, then we are golden.
             */

            var parts = source.Split(
                new[] {'\\'}, StringSplitOptions.RemoveEmptyEntries
            );
            if (!parts.Any())
                return false; // obviously no chance of being a match

            if (Configuration.MatchCase)
                return parts.Any(pattern.Equals);

            return parts.Select(s => s.ToLowerInvariant())
                .Any(pattern.ToLowerInvariant().Equals);
        }
    }
}