using EnvDTE;
using MFR.Solutions.Interfaces;

namespace MFR.Solutions.Factories
{
    /// <summary>
    /// Creates new instances of objects that implement the
    /// <see
    ///     cref="T:MFR.VisualStudioSolutions" />
    /// interface, and returns
    /// references to them.
    /// </summary>
    public static class MakeNewVisualStudioSolution
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:MFR.VisualStudioSolutions" />
        /// interface and returns a
        /// reference to it.
        /// </summary>
        /// <param name="dte">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:EnvDTE.DTE" /> interface.
        /// </param>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.VisualStudioSolutions" />
        /// interface.
        /// </returns>
        public static IVisualStudioSolution AndAttachDTE(DTE dte)
            => new VisualStudioSolution(dte);
    }
}