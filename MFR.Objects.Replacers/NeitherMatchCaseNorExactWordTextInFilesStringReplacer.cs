using System;

namespace MFR.Objects.Replacers
{
    /// <summary>
    /// Replaces strings only for the case where neither Match Case nor Match
    /// Exact Word is set to <see langword="true" />, for the Rename Sub Folders operation type.
    /// </summary>
    public class
        NeitherMatchCaseNorExactWordTextInFilesStringReplacer :
            ReplaceTextInfilesStringReplacerBase
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static NeitherMatchCaseNorExactWordTextInFilesStringReplacer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected NeitherMatchCaseNorExactWordTextInFilesStringReplacer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:MFR.Objects.Replacers.NeitherMatchCaseNorExactWordTextInFilesStringReplacer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static NeitherMatchCaseNorExactWordTextInFilesStringReplacer
            Instance
        {
            get;
        } = new NeitherMatchCaseNorExactWordTextInFilesStringReplacer();

        /// <summary>
        /// Gets one of the
        /// <see
        ///     cref="T:MFR.Objects.TextMatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        [Log(AttributeExclude = true)]
        public override TextMatchingConfiguration TextMatchingConfiguration
        {
            get;
        } = TextMatchingConfiguration.NeitherMatchCaseNorExactWord;

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

            var result = source;    // no replacement in the event of an exception

            try
            {
                result = source.ReplaceNoCase(pattern, dest);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = source;    // no replacement in the event of an exception
            }

            return result;
        }
    }
}