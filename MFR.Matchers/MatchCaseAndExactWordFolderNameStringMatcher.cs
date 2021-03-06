using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using Alphaleonis.Win32.Filesystem;
using xyLOGIX.Core.Debug;

namespace MFR.Matchers
{
    /// <summary>
    /// Matches strings only for the case where Match Case is set to
    /// <see
    ///     langword="true" />
    /// and Match Exact Word is set to <see langword="true" />
    /// for the case when a Rename Sub Folders operation is being performed.
    /// </summary>
    public class
        MatchCaseAndExactWordFolderNameStringMatcher :
            RenameSubFoldersStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseAndExactWordFolderNameStringMatcher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseAndExactWordFolderNameStringMatcher() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Matchers.MatchCaseAndExactWordFolderNameStringMatcher" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseAndExactWordFolderNameStringMatcher Instance
        {
            get;
        } = new MatchCaseAndExactWordFolderNameStringMatcher();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
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
             * OKAY, an exact-word search on a folder path is somewhat different
             * than for a file.  For a folder, it's made up of parts, each of
             * which are delimited by a backslash ('\').   We just want to perform
             * a search on the folder farthest down the directory tree of the given
             * path.
             *
             * For example, if we have the path 'C:\I\am\a\folder', we just want
             * to match on the word 'folder'.   Assuming the 'value' parameter is a
             * fully-qualified, absolute pathname to a folder, we call System.IO.
             * Path.GetFileName(value) to get the folder furthest down the
             * directory tree, and then do an "Equals" search on it against the
             * value of the 'findWhat' parameter.             *
             */

            bool result;

            try
            {
                result = Path.GetFileName(value)
                             .Equals(findWhat);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;         // no match in the event of an exception
            }

            return result;
        }
    }
}
