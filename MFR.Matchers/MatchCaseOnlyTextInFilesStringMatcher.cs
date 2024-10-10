using MFR.Settings.Configuration.Constants;
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
    /// and Match Exact Word is set to <see langword="false" />
    /// for the case when a Replace Text in Files operation is being performed.
    /// </summary>
    public class
        MatchCaseOnlyTextInFilesStringMatcher :
            ReplaceTextInFilesStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseOnlyTextInFilesStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseOnlyTextInFilesStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Matchers.MatchCaseOnlyTextInFilesStringMatcher" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseOnlyTextInFilesStringMatcher Instance
        {
            get;
        } = new MatchCaseOnlyTextInFilesStringMatcher();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchCaseOnly;

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
             * OKAY, for replacing text in a file, and to match case, we
             * simply execute a "Contains" search.
             */

            bool result;

            try
            {
                //result = value.MatchesWithCase(findWhat, replaceWith);

                /*
                 * OKAY, for doing a case-sensitive search to find a match to
                 * the findWhat text in a file, we do not care whether the
                 * match is according to being sensitive to whether the findWhat
                 * value contains replaceWith or vice-versa.  Just do a dumb
                 * "Contains" search on the file's text.
                 */
                
                result = value.Contains(findWhat);
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