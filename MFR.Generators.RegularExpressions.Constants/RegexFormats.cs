namespace MFR.Generators.RegularExpressions.Constants
{
    /// <summary>
    /// Substitution formats for regular expressions.
    /// </summary>
    public static class RegexFormats
    {
        /// <summary>
        /// Regular expression that matches an entire line from beginning to end.
        /// </summary>
        public const string MatchWholeLine = @"^{0}$";

        /// <summary>
        /// Regular expression that matches an exact word.
        /// </summary>
        /// <remarks>
        /// This sensitive to dot-delimited names such as those which may
        /// appear in Visual Studio solution, project, and source files.
        /// <para />
        /// Substitute, into this format, the escaped version of the search
        /// phrase.
        /// <para />
        /// <b>NOTE:</b> If the text <c>.Properties</c> follows the text to be
        /// matched, even in the case of an exact-word match, it is included 
        /// with an atomic group.
        /// <para />
        /// The idea being to fix namespaces when renaming projects to ensure
        /// that <c>using</c> statements bringing in Resources will still work.
        /// </remarks>
        public const string MatchExactWord =
            @"(?<![\w]){0}(?(?=\S)(?=(?>\.Properties)|[a-z.]*[^A-Z.])|(?(?![\w])))";
    }
}
