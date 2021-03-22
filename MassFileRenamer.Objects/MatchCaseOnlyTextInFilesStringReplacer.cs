using PostSharp.Patterns.Diagnostics;
using System;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Replaces text in strings when Match Case is set to
    /// <see
    ///     langword="true" />
    /// but Match Whole Word is set to
    /// <see
    ///     langword="false" />
    /// , for the Replace Text in Files operation type.
    /// </summary>
    public class
        MatchCaseOnlyTextInFilesStringReplacer :
            ReplaceTextInfilesStringReplacerBase
    {
        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:MassFileRenamer.Objects.MatchCaseOnlyTextInFilesStringReplacer"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static MatchCaseOnlyTextInFilesStringReplacer Instance
        {
            get;
        } = new MatchCaseOnlyTextInFilesStringReplacer();

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
        /// Gets one of the
        /// <see
        ///     cref="T:MassFileRenamer.Objects.MatchingConfiguration" />
        /// values that
        /// corresponds to the type of operation being performed.
        /// </summary>
        public override MatchingConfiguration MatchingConfiguration
        {
            get;
        } = MatchingConfiguration.MatchCaseOnly;

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
        /// (Optional.) Default is blank. String containing the new data that
        /// should be substituted for the replaced text.
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
            => throw new NotImplementedException();
    }
}