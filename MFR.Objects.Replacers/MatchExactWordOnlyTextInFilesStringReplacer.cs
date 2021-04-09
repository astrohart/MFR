using MFR.Objects.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Objects.Replacers
{
    /// <summary>
    /// Replaces strings only for the case where Match Exact Word is set to
    /// <see
    ///     langword="true" />
    /// but Match Case is set to <see langword="false" />, for
    /// the Replace Text in Files operation type.
    /// </summary>
    public class
        MatchExactWordOnlyTextInFilesStringReplacer :
            ReplaceTextInfilesStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchExactWordOnlyTextInFilesStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchExactWordOnlyTextInFilesStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Objects.Replacers.MatchExactWordOnlyTextInFilesStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchExactWordOnlyTextInFilesStringReplacer Instance
        {
            get;
        } = new MatchExactWordOnlyTextInFilesStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchExactWordOnly;

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="expression" />. Returns a string
        /// </summary>
        /// <param name="source">
        /// (Required.) String containing the data upon which the replacement
        /// operation is to be carried out.
        /// </param>
        /// <param name="pattern">
        /// (Required.) String containing the pattern that allows us to match
        /// the data to be replaced.
        /// </param>
        /// <param name="dest">
        /// (Required.) String containing the new data that should be
        /// substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="source" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        public override string Replace(string source, string pattern,
            string dest = "")
        {
            if (string.IsNullOrEmpty(source))
                throw new ArgumentException(
                    "Source cannot be null or the empty string.  It CAN be whitespace, however.",
                    nameof(source)
                );

            if (string.IsNullOrEmpty(pattern))
                throw new ArgumentException(
                    "The pattern cannot be null or the empty string.  It CAN be whitespace, however.",
                    nameof(pattern)
                );

            var result = source; // no replacement in the event of an exception

            try
            {
                result = source.RegexReplaceNoCase(
                    $@"{Regex.Escape(pattern)}(?=[a-z.]*[^A-Z.])", dest,
                    RegexOptions.Multiline
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = source; // no replacement in the event of an exception
            }

            return result;
        }
    }
}