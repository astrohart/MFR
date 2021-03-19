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
        /// is passed a <see langword="null" /> value.
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
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="findWhat" />, or
        /// <paramref
        ///     name="replaceWith" />
        /// , are passed blank or <see langword="null" /> string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a match
        /// against the provided <paramref name="findWhat" />; <see langword="false" /> if no
        /// matches are found.
        /// </returns>
        public override bool IsMatch(string value, string findWhat,
            string replaceWith = "")
        {
            base.IsMatch(value, findWhat, replaceWith);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            /*
             * We could have used the ?: operator here, but a conscious choice has
             * been made to use if/else, because then the code is more readable.
             */

            if (Configuration.MatchCase)
                if (Configuration.MatchWholeWord)
                    return value.Equals(findWhat);
                else
                    return value.Contains(findWhat) &&
                           (findWhat.Contains(replaceWith) || !value.Contains(replaceWith));
            if (Configuration.MatchWholeWord)
                return value.ToLowerInvariant()
                    .Equals(findWhat.ToLowerInvariant());
            return value.ToLowerInvariant()
                       .Contains(findWhat.ToLowerInvariant()) &&
                   (findWhat.ToLowerInvariant()
                        .Contains(replaceWith.ToLowerInvariant()) ||
                    !value.ToLowerInvariant()
                        .Contains(replaceWith.ToLowerInvariant()));
        }

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameFilesInFolder;
    }
}