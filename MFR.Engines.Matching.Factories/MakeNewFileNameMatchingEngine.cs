using MFR.Engines.Matching.Interfaces;

namespace MFR.Engines.Matching.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
    /// interface that applies criteria to match file names against textual expressions.
    /// </summary>
    public static class MakeNewFileNameMatchingEngine
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface that applies criteria to match file names against textual expressions.
        /// </returns>
        public static ITextExpressionMatchingEngine FromScratch()
            => new FileNameMatchingEngine();
    }
}