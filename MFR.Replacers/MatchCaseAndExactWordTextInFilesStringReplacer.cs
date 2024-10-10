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
    /// Replaces strings only for the case where both Match Case and Match Whole
    /// Word are set to <see langword="true" />, for the ReplaceTextInFiles
    /// operation type.
    /// </summary>
    public class
        MatchCaseAndExactWordTextInFilesStringReplacer :
            ReplaceTextInfilesStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseAndExactWordTextInFilesStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseAndExactWordTextInFilesStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Replacers.MatchCaseAndExactWordTextInFilesStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseAndExactWordTextInFilesStringReplacer Instance
        {
            get;
        } = new MatchCaseAndExactWordTextInFilesStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values
        /// that corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchCaseAndExactWord;

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
        [return: NotLogged]
        public override string Replace(
            [NotLogged] string value, 
            [NotLogged] string pattern,
            [NotLogged] string dest = "")
        {
            /*
             * OKAY, the source parameter holds the current content of the file in
             * which we are to replace text.  The pattern parameter holds the value
             * to be searched for.  The dest parameter holds the value to replace
             * the pattern with.  We then return the new text that the file is
             * now supposed to have after the operation.  Note that here, a blank
             * value is allowable for the dest parameter, as this merely erases
             * text in the destination file.
             */

            var result = value; // no replacement in the event of an exception

            try
            {
                if (string.IsNullOrEmpty(value))
                    return result;
                if (string.IsNullOrEmpty(pattern))
                    return result;

                result = value.RegexReplaceWithCase(
                    GetRegularExpressionGenerator.For(
                                                     RegularExpressionType
                                                         .MatchExactWordOnly
                                                 )
                                                 .Generate(pattern), dest,
                    RegexOptions.Multiline
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