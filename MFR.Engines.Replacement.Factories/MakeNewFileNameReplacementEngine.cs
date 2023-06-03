using MFR.Engines.Replacement.Intefaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Engines.Replacement.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
    /// interface that replaces the names of files with content identified by a
    /// user-directed search.
    /// them.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class MakeNewFileNameReplacementEngine
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Replacement.Intefaces.ITextReplacementEngine" />
        /// interface that replaces the names of files with content identified by a
        /// user-directed search.
        /// </returns>
        public static ITextReplacementEngine FromScratch()
            => new FileNameReplacementEngine();
    }
}