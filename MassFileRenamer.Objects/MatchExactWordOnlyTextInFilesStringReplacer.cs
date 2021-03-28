using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces strings only for the case where Match Exact Word is set to <see langword="true" /> but
    /// Match Case is set to <see langword="false" />, for the Replace Text in Files operation type.
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
        ///     cref="T:MassFileRenamer.Objects.MatchExactWordOnlyTextInFilesStringReplacer" />
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
        ///     cref="T:MassFileRenamer.Objects.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        } = TextMatchingConfiguration.MatchExactWordOnly;

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
            if (string.IsNullOrWhiteSpace(source))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(source)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * OKAY, the source parameter holds the current content of the file in
             * which we are to replace text.  The pattern parameter holds the value
             * to be searched for.  The dest parameter holds the value to replace
             * the pattern with.  We then return the new text that the file is
             * now supposed to have after the operation.  Note that here, a blank
             * value is allowable for the dest parameter, as this merely erases
             * text in the destination file.
             */

            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            string result;

            try
            {
                var regex = $@"\b({Regex.Escape(pattern)})\b";
                result = source.RegexReplaceNoCase(regex, dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}