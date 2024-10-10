namespace MFR.Generators.RegularExpressions.Constants
{
    /// <summary>
    /// Types of regular expressions (e.g., for matching email addresses, phone
    /// numbers, exact words etc.)
    /// </summary>
    public enum RegularExpressionType
    {
        /// <summary>
        /// Matches an exact word only, whether surrounded by other text or not.
        /// </summary>
        MatchExactWordOnly,

        /// <summary>
        /// Matches an entire line from beginning to end.
        /// </summary>
        MatchWholeLine,

        /// <summary>
        /// Unknown regular expression type.
        /// </summary>
        Unknown = -1
    }
}