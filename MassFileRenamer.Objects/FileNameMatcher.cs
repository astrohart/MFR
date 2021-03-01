using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Applies criteria to match file names against textual expressions.
    /// </summary>
    public class FileNameMatcher : TextExpressionMatcherBase
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileNameMatcher" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <c>null</c> value.
        /// </exception>
        public FileNameMatcher(IConfiguration configuration) : base(
            configuration
        ) { }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileNameMatcher" />
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
        internal FileNameMatcher()
        {
            // TODO: Add default object initialization code here
        }

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
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <c>null</c> string for values.
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

            /*
             * We could have used the ?: operator here, but a conscious choice has
             * been made to use if/else, because then the code is more readable.
             */

            if (Configuration.MatchCase)
                if (Configuration.MatchWholeWord)
                    return source.Equals(pattern);
                else
                    return source.Contains(pattern) &&
                           (pattern.Contains(dest) || !source.Contains(dest));
            if (Configuration.MatchWholeWord)
                return source.ToLowerInvariant()
                    .Equals(pattern.ToLowerInvariant());
            return source.ToLowerInvariant()
                       .Contains(pattern.ToLowerInvariant()) &&
                   (pattern.ToLowerInvariant()
                        .Contains(dest.ToLowerInvariant()) ||
                    !source.ToLowerInvariant()
                        .Contains(dest.ToLowerInvariant()));
        }
    }
}