using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Applies criteria to match file names against textual expressions.
    /// </summary>
    public class FileNameMatcher : IFileNameMatcher
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
        public FileNameMatcher(IConfiguration configuration)
        {
            Configuration = configuration ??
                            throw new ArgumentNullException(
                                nameof(configuration)
                            );
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IConfiguration" /> interface.
        /// </summary>
        public IConfiguration Configuration
        {
            get;
            set;
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
        /// or <paramref name="pattern" />, are passed blank or
        /// <c>null</c> string for values.
        /// </exception>
        /// <returns>
        /// Returns <c>true</c> if the <paramref name="source" /> is a match
        /// against the provided <paramref name="pattern" />; <c>false</c> if no
        /// matches are found.
        /// </returns>
        public bool IsMatch(string source, string pattern)
        {
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * We could have used the ?: operator here, but a conscious choice has
             * been made to use if/else, because then the code is more readable.
             */

            if (Configuration.MatchCase)
                if (Configuration.MatchWholeWord)
                    return source.Equals(pattern);
                else
                    return source.Contains(pattern);
            if (Configuration.MatchWholeWord)
                return source.ToLowerInvariant()
                    .Equals(pattern.ToLowerInvariant());
            return source.ToLowerInvariant()
                .Contains(pattern.ToLowerInvariant());
        }
    }
}