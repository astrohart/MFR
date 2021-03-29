using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Matches strings only for the case where Match Case is set to <see
    /// langword="false"/> and Match Exact Word is set to <see langword="true"/>,
    /// for the case when a Rename Files in Folder operation is being performed.
    /// </summary>
    public class
        MatchExactWordOnlyFileNameStringMatcher :
            RenameFilesInFolderStringMatcherBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchExactWordOnlyFileNameStringMatcher()
        {
        }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchExactWordOnlyFileNameStringMatcher()
        {
        }

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MassFileRenamer.Objects.MatchExactWordOnlyFileNameStringMatcher"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchExactWordOnlyFileNameStringMatcher Instance
        {
            get;
        } = new MatchExactWordOnlyFileNameStringMatcher();

        /// <summary>
        /// Gets one of the <see
        /// cref="T:MassFileRenamer.Objects.TextMatchingConfiguration"/> values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        } = TextMatchingConfiguration.MatchExactWordOnly;

        /// <summary>
        /// Determines whether a <paramref name="value"/> string is a match
        /// against a <paramref name="findWhat"/>, according to how the
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
        /// <paramref name="findWhat"/> in <paramref name="value"/> are to be
        /// replaced with.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters, <paramref
        /// name="value"/> or <paramref name="findWhat"/>, are passed blank or
        /// <see langword="null"/> string for values.
        /// </exception>
        /// <returns>
        /// Returns <see langword="true"/> if the <paramref name="value"/> is a
        /// match against the provided <paramref name="findWhat"/>; <see
        /// langword="false"/> if no matches are found.
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
             * OKAY, for renaming a file in a folder, and to match the exact word, we
             * simply execute a "Equals No Case" match.
             */

            bool result;

            try
            {
                result = value.EqualsNoCase(findWhat);
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