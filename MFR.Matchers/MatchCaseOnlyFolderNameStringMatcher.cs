using Alphaleonis.Win32.Filesystem;
using MFR.Matchers.Interfaces;
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
    /// but Match Exact Word is set to <see langword="false" />
    /// , for the case when a Rename Sub Folders operation is being performed.
    /// <para />
    /// </summary>
    public class
        MatchCaseOnlyFolderNameStringMatcher : RenameSubFoldersStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseOnlyFolderNameStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseOnlyFolderNameStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that matches
        /// text expressions with a case-sensitive search.
        /// <para />
        /// This object should be used when the <b>Match Case</b> check box is selected by
        /// the user when doing the operations of renaming solution folders or sub folders
        /// of a Solution.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStringMatcher Instance
        {
            get;
        } = new MatchCaseOnlyFolderNameStringMatcher();

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
        public override bool IsMatch(string value, string findWhat,
            string replaceWith = "")
        {
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
             * OKAY, for renaming a sub folder of the root directory,
             * we match whatever part of the path "Contains" the value
             * we are looking for.
             *
             * HOWEVER -- we should only pattern-match against the
             * folder that is on the lowest level of the directory tree.
             * Therefore, we use Path.GetFileName to get the value to be
             * matched against.
             */

            var result = false;

            try
            {
                var lowestLevelFolderName = Path.GetFileName(value);
                if (string.IsNullOrWhiteSpace(lowestLevelFolderName))
                    return result;

                result = lowestLevelFolderName.MatchesWithCase(
                    findWhat
                );
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