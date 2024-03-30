using MFR.Matchers.Interfaces;

namespace MFR.Matchers.Factories
{
    /// <summary>
    /// Provides access to the one and only instance of the object that implements the
    /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that matches
    /// BOTH on character casing AND on the exact string that is supplied for the
    /// text-replacement specification provided by the user in the <b>Find What</b> box
    /// in the user interface.
    /// <para />
    /// This the Mass File Renamer analogy of the user placing check marks in both
    /// the <b>Match Case</b> and the <b>Match Whole Word</b> checkbox in, say, the
    /// <b>Edit</b>, <b>Find</b> dialog box in most text-editing applications.
    /// </summary>
    public static class GetMatchCaseAndExactWordFolderNameStringMatcher
    {
        /// <summary>
        /// Obtains access to the sole instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface, and returns
        /// a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to the one, and only, instance of the object that implements the
        /// <see cref="T:MFR.Matchers.Interfaces.IStringMatcher" /> interface that matches
        /// BOTH on character casing AND on the exact string that is supplied for the
        /// text-replacement specification provided by the user in the <b>Find What</b> box
        /// in the user interface.
        /// <para />
        /// This the Mass File Renamer analogy of the user placing check marks in both
        /// the <b>Match Case</b> and the <b>Match Whole Word</b> checkbox in, say, the
        /// <b>Edit</b>, <b>Find</b> dialog box in most text-editing applications.
        /// </returns>
        public static IStringMatcher SoleInstance()
            => MatchCaseAndExactWordFolderNameStringMatcher.Instance;
    }
}