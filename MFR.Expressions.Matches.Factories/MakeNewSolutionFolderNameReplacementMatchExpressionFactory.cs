using MFR.Expressions.Matches.Factories.Interfaces;

namespace MFR.Expressions.Matches.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory" />
    /// interface that generates a matching expression for the renaming of file folders
    /// that contain Visual Studio Solution (<c>*.sln</c>) files according to what the
    /// user specified to search for in the filename and what to replace it with.
    /// </summary>
    public static class
        MakeNewSolutionFolderNameReplacementMatchExpressionFactory
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Expressions.Matches.Factories.Interfaces.IMatchExpressionFactory" />
        /// interface that generates a matching expression for the renaming of file folders
        /// that contain Visual Studio Solution (<c>*.sln</c>) files according to what the
        /// user specified to search for in the filename and what to replace it with.
        /// </returns>
        public static IMatchExpressionFactory FromScratch()
            => new SolutionFolderNameReplacementMatchExpressionFactory();
    }
}