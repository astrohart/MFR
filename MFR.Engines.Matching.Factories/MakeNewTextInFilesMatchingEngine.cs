using MFR.Engines.Matching.Interfaces;

namespace MFR.Engines.Matching.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
    /// interface that matches text in a file that is to be (eventually) replaced.
    /// </summary>
    public static class MakeNewTextInFilesMatchingEngine
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:MFR.Engines.Matching.Interfaces.ITextExpressionMatchingEngine" />
        /// interface that matches text in a file that is to be (eventually) replaced.
        /// </returns>
        public static ITextExpressionMatchingEngine FromScratch()
            => new TextInFilesMatchingEngine();
    }
}