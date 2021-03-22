namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Values that specify whether we are matching case, matching whole word,
    /// or both, or neither.
    /// </summary>
    public enum MatchingConfiguration
    {
        /// <summary>
        /// The user has toggled Match Case to true and Match Whole Word to false.
        /// </summary>
        MatchCaseOnly,

        /// <summary>
        /// The user has toggled Match Whole Word to true and Match Case to false.
        /// </summary>
        MatchWholeWordOnly,

        /// <summary>
        /// Both Match Case and Match Whole Word are toggled.
        /// </summary>
        MatchCaseAndWholeWord,

        /// <summary>
        /// Match Case is set to false, and so is Match Whole Word.
        /// </summary>
        NeitherMatchCaseNorWholeWord,

        /// <summary>
        /// We do not know what type of configuration is set.
        /// </summary>
        Unknown = -1
    }
}