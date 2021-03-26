using System;
using System.Linq;
using xyLOGIX.Core.Debug;

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
        ///     cref="T:MassFileRenamer.Objects.TextExpressionMatcherBase" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        public FolderNameMatcher(IConfiguration configuration) : base(
            configuration
        ) { }

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
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationType" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override OperationType OperationType
        {
            get;
        } = OperationType.RenameSubFolders;

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
        /// <param name="replaceWith">
        /// (Required.) String containing the value that the found text is to be
        /// replaced with. Cannot be blank.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// , <paramref name="findWhat" />, or
        /// <paramref
        ///     name="replaceWith" />
        /// are passed blank or <see langword="null" />
        /// string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true" /> if the <paramref name="value" /> is a
        /// match against the provided <paramref name="findWhat" />;
        /// <see
        ///     langword="false" />
        /// if no matches are found.
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

            var result = false;

            try
            {
                if (!Configuration.MatchWholeWord)
                {
                    if (Configuration.MatchCase)
                        result = value.Contains(findWhat) &&
                                 (findWhat.Contains(replaceWith) ||
                                  !value.Contains(replaceWith));
                    else
                        result = value.ToLowerInvariant()
                                      .Contains(findWhat.ToLowerInvariant()) &&
                                 (findWhat.ToLowerInvariant()
                                          .Contains(
                                              replaceWith.ToLowerInvariant()
                                          ) ||
                                  !value.ToLowerInvariant()
                                        .Contains(
                                            replaceWith.ToLowerInvariant()
                                        ));
                }
                else
                {
                    /*
                     * OKAY, a whole-word search on a folder path is somewhat different
                     * than for a file. For a folder, it's made up of parts, each of which are delimited by a backslash (@'\'). Split the string along the backslashes.
                     * In a whole-word search, if any part matches the pattern exactly,
                     * then we are golden.
                     */

                    var parts = value.Split(
                        new[] {'\\'}, StringSplitOptions.RemoveEmptyEntries
                    );
                    if (!parts.Any())
                        result = false; // obviously no chance of being a match
                    else if (Configuration.MatchCase)
                        result = parts.Any(findWhat.Equals);
                    else
                        result = parts.Select(s => s.ToLowerInvariant())
                                      .Any(
                                          findWhat.ToLowerInvariant()
                                                  .Equals
                                      );
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}