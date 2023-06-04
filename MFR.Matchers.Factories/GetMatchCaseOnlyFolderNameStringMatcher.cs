using MFR.Matchers.Interfaces;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that matches
    /// text expressions with a case-sensitive search.
    /// <para />
    /// This object should be used when the <b>Match Case</b> check box is selected by
    /// the user when doing the operations of renaming solution folders or sub folders
    /// of a Solution.
    /// </summary>
    public static class GetMatchCaseOnlyFolderNameStringMatcher
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface, and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that matches
        /// text expressions with a case-sensitive search.
        /// <para />
        /// This object should be used when the <b>Match Case</b> check box is selected by
        /// the user when doing the operations of renaming solution folders or sub folders
        /// of a Solution.
        /// </returns>
        public static IStringMatcher SoleInstance()
            => MatchCaseOnlyFolderNameStringMatcher.Instance;
    }
}