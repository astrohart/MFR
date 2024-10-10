using PostSharp.Patterns.Threading;
using MFR.Harnesses.LoadedSolutions.Interfaces;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions.Factories
{
    /// <summary>
    /// This creates instances of objects that implement the
    /// <see cref="T:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness" />
    /// interface by converting them from objects of other types, or that implement
    /// different (yet compatible) interfaces.
    /// </summary>
    [ExplicitlySynchronized]
    public static class Convert
    {
        /// <summary>
        /// Creates a new instance of an object implementing the
        /// <see cref="T:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness" />
        /// interface that wraps an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the object that is to be wrapped by the newly-created
        /// harness object.
        /// </param>
        /// <returns>
        /// If successful, a new instance of an object that implements the
        /// <see cref="T:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness" />
        /// interface
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// parameter, <paramref name="solution" />, is passed a <see langword="null" />
        /// value.
        /// </exception>
        public static ILoadedSolutionHarness ToLoadedSolutionHanress(
            this IVisualStudioSolution solution
        )
            => new LoadedSolutionHarness(solution);
    }
}