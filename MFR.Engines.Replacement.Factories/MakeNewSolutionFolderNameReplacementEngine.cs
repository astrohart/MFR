using MFR.Engines.Replacement.Intefaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Engines.Replacement.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
    /// interface that renames solution folders according to the parameters supplied by
    /// the user.
    /// them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewSolutionFolderNameReplacementEngine
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
        /// interface that renames solution folders according to the parameters supplied by
        /// the user.
        /// </returns>
        public static ITextReplacementEngine FromScratch()
            => new SolutionFolderNameReplacementEngine();
    }
}