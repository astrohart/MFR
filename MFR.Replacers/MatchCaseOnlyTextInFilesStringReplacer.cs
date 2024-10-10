using MFR.Settings.Configuration.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Replacers
{
    /// <summary>
    /// Replaces text in strings when Match Case is set to
    /// <see
    ///     langword="true" />
    /// but Match Exact Word is set to <see langword="false" />
    /// , for the Replace Text in Files operation type.
    /// </summary>
    public class
        MatchCaseOnlyTextInFilesStringReplacer :
            ReplaceTextInfilesStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static MatchCaseOnlyTextInFilesStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected MatchCaseOnlyTextInFilesStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Replacers.MatchCaseOnlyTextInFilesStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseOnlyTextInFilesStringReplacer Instance
        {
            get;
        } = new MatchCaseOnlyTextInFilesStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override TextMatchingConfiguration TextMatchingConfiguration
            => TextMatchingConfiguration.MatchCaseOnly;

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
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
        /// </param>
        /// <returns>
        /// String containing the new data.
        /// <para />
        /// For this style of searching ONLY, the <paramref name="dest" />
        /// parameter can be passed a blank value.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either of the required parameters,
        /// <paramref
        ///     name="value" />
        /// or <paramref name="pattern" />, are passed blank or
        /// <see langword="null" /> strings for values.
        /// <para />
        /// <b>NOTE:</b> For this search, a blank value is allowed for the
        /// <paramref name="dest" /> parameter.
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

                result = value.Replace(pattern, dest);
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