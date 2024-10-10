using MFR.Engines.Matching.Interfaces;

namespace MFR.Engines.Matching.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
    /// interface that searches for matches to textual-search criteria patterns and
    /// regexes in the pathnames of folders that contain Visual Studio Solution (
    /// <c>*.sln</c>) files, according to rules specified by config settings.
    /// </summary>
    public static class MakeNewSolutionFolderNameMatchingEngine
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface that searches for matches to textual-search criteria patterns and
        /// regexes in the pathnames of folders that contain Visual Studio Solution (
        /// <c>*.sln</c>) files, according to rules specified by config settings.
        /// </returns>
        public static ITextExpressionMatchingEngine FromScratch()
            => new SolutionFolderNameMatchingEngine();
    }
}