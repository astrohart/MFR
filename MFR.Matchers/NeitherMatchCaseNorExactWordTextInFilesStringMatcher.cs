using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Matchers
{
    /// <summary>
    /// Matches strings only for the case where Match Case is set to <see
    /// langword="false"/> and Match Exact Word is set to <see langword="false"/>,
    /// for the case when a Replace Text in Files operation is being performed.
    /// </summary>
    public class
        NeitherMatchCaseNorExactWordTextInFilesStringMatcher : ReplaceTextInFilesStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static NeitherMatchCaseNorExactWordTextInFilesStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected NeitherMatchCaseNorExactWordTextInFilesStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Matchers.NeitherMatchCaseNorExactWordTextInFilesStringMatcher" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static NeitherMatchCaseNorExactWordTextInFilesStringMatcher Instance
        {
            get;
        } = new NeitherMatchCaseNorExactWordTextInFilesStringMatcher();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.NeitherMatchCaseNorExactWord;

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
        public override bool IsMatch(
            [NotLogged] string value, 
            string findWhat,
            string replaceWith = "")
        {
            base.IsMatch(value, findWhat, replaceWith);

            /*
             * OKAY, for replacing text in a file where we do not care
             * about upper or lower case, nor do we care about matching
             * exact words, then the thing to do is run a "Contains"
             * search without regards to case.
             */

            bool result;

            try
            {
                //result = value.MatchesNoCase(findWhat, replaceWith);

                /*
                 * For locating text in files, just do a dumb 'contains' search.
                 */

                result = value.ContainsNoCase(findWhat);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;         // no match found in the event of an exception
            }

            return result;
        }
    }
}