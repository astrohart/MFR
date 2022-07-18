using MFR.Settings.Configuration.Constants;
using MFR.Generators.RegularExpressions.Constants;
using MFR.Generators.RegularExpressions.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Matchers
{
    /// <summary>
    /// Matches strings only for the case where Match Case is set to
    /// <see
    ///     langword="true" />
    /// and Match Exact Word is set to <see langword="true" />
    /// for the case when a Replace Text in Files operation is being performed.
    /// </summary>
    public class
        MatchCaseAndExactWordTextInFilesStringMatcher :
            ReplaceTextInFilesStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseAndExactWordTextInFilesStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseAndExactWordTextInFilesStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Matchers.MatchCaseAndExactWordTextInFilesStringMatcher" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseAndExactWordTextInFilesStringMatcher Instance
        {
            get;
        } = new MatchCaseAndExactWordTextInFilesStringMatcher();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchCaseAndExactWord;

        /// <summary>
        /// Determines whether a <paramref name="value" /> string is a match
        /// against a <paramref name="findWhat" />, according to how the
        /// application is configured.
        /// </summary>
        /// <param name="value">
        /// (Required.) String containing the value to check for matches.
        /// </param>
        /// <param name="findWhat">
        /// (Optional.) String containing the pattern that specifies the search criteria.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the data that all instances of
        /// <paramref name="findWhat" /> in <paramref name="value" /> are to be
        /// replaced with.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="findWhat" />, are passed blank or
        /// <see langword="null" /> string for values.
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
            // Call the base class here since it provides default
            base.IsMatch(value, findWhat, replaceWith);

            bool result;

            try
            {
                var regex = GetRegularExpressionGenerator
                            .For(RegularExpressionType.MatchExactWordOnly)
                            .Generate(findWhat);

                result = value.RegexMatchesWithCase(regex);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false; // no match found in the event of an exception
            }

            return result;
        }
    }
}
