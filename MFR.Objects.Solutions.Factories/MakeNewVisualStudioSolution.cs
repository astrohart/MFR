using MFR.Objects.Solutions.Interfaces;

namespace MFR.Objects.Solutions.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the <see cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" /> interface, and returns references to them.
    /// </summary>
    public static class MakeNewVisualStudioSolution
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" /> interface and returns a reference to it.
        /// </summary>
        /// <returns>Reference to an instance of an object that implements the <see cref="T:MFR.Objects.Solutions.Interfaces.IVisualStudioSolution" /> interface.</returns>
        public static IVisualStudioSolution FromScratch()
            => new VisualStudioSolution();
    }
}