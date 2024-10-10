namespace MFR.Settings.Configuration.Constants
{
    /// <summary>
    /// Values that specify whether we are matching case, matching whole word,
    /// or both, or neither.
    /// </summary>
    public enum TextMatchingConfiguration
    {
        /// <summary>
        /// The user has toggled Match Case to true and Match Exact Word to false.
        /// </summary>
        MatchCaseOnly,

        /// <summary>
        /// The user has toggled Match Exact Word to true and Match Case to false.
        /// </summary>
        MatchExactWordOnly,

        /// <summary>
        /// Both Match Case and Match Exact Word are toggled.
        /// </summary>
        MatchCaseAndExactWord,

        /// <summary>
        /// Match Case is set to false, and so is Match Exact Word.
        /// </summary>
        NeitherMatchCaseNorExactWord,

        /// <summary>
        /// We do not know what type of configuration is set.
        /// </summary>
        Unknown = -1
    }
}