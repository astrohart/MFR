namespace MFR.Settings.Configuration.Mappers.Constants
{
    /// <summary>
    /// Values that represent the replacement parameter strings in the configuration
    /// setting for the detailed commit message.
    /// </summary>
    /// <remarks>These are the values that are then transformed into format specifiers.</remarks>
    public static class CommitMessageReplacementParameter
    {
        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Find What</c> value.
        /// </summary>
        public const string FindWhat = "{{findWhat}}";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Replace With</c> value.
        /// </summary>
        public const string ReplaceWith = "{{replaceWith}}";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Root Dir</c> value.
        /// </summary>
        public const string RootDir = "{{rootDir}}";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Short Date</c> value.
        /// </summary>
        public const string ShortDate = "{{shortDate}}";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Short Time</c> value.
        /// </summary>
        public const string ShortTime = "{{shortTime}}";

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the replacement parameter for
        /// the <c>Timezone</c> value.
        /// </summary>
        public const string Timezone = "{{timezone}}";
    }
}