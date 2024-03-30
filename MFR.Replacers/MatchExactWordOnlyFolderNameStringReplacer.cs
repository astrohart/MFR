using MFR.Settings.Configuration.Constants;
using MFR.Generators.RegularExpressions.Constants;
using MFR.Generators.RegularExpressions.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Text.RegularExpressions;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;

namespace MFR.Replacers
{
    /// <summary>
    /// Replaces strings only for the case where Match Exact Word is set to
    /// <see
    ///     langword="true" />
    /// but Match Case is set to <see langword="false" />, for
    /// the Rename Sub Folders operation type.
    /// </summary>
    public class
        MatchExactWordOnlyFolderNameStringReplacer :
            RenameSubFoldersStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchExactWordOnlyFolderNameStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchExactWordOnlyFolderNameStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Replacers.MatchExactWordOnlyFolderNameStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchExactWordOnlyFolderNameStringReplacer Instance
        {
            get;
        } = new MatchExactWordOnlyFolderNameStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchExactWordOnly;

        /// <summary>
        /// Carries out the replacement operation using the values specified by
        /// the provided <paramref name="value" />. Returns a string
        /// </summary>
        /// <param name="value">
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
        ///     name="value" />
        /// , <paramref name="pattern" />, or
        /// <paramref
        ///     name="dest" />
        /// , are passed blank or <see langword="null" /> string
        /// for values.
        /// </exception>
        public override string Replace(string value, string pattern,
            string dest = "")
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(value)
                );
            if (string.IsNullOrWhiteSpace(pattern))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(pattern)
                );

            /*
             * Normally, the 'dest' parameter is optional for this method.
             * However, in the case of replacing text in the names of files,
             * it's mandatory.  This because, if 'dest' is blank or the
             * empty string, we run the risk of trying to create a file that
             * has no name, which is in violation of OS rules.  Therefore,
             * we enforce that the dest parameter should have a value.
             */

            if (string.IsNullOrWhiteSpace(dest))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(dest)
                );

            var result = value; // no replacement in the event of an exception

            try
            {
                /* NOTE: Here, the value of 'source' is always the name of the
                   folder that is furthest down the directory tree.
                */
                result = value.RegexReplaceNoCase(
                    GetRegularExpressionGenerator.For(
                        RegularExpressionType.MatchWholeLine)
                                                 .Generate(pattern), dest
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = value; // no replacement in the event of an exception
            }

            return result;
        }
    }
}
