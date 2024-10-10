using MFR.Services.Solutions.Interfaces;
using PostSharp.Patterns.Diagnostics;

namespace MFR.Services.Solutions.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
    /// interface.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class GetVisualStudioSolutionService
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if the object type requested is not supported.
        /// </exception>
        public static IVisualStudioSolutionService SoleInstance()
            => VisualStudioSolutionService.Instance;
    }
}