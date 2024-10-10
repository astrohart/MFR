using PostSharp.Patterns.Threading;
using System.ComponentModel;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>ClosingSolution</c> event handlers.
    /// </summary>
    /// <remarks>
    /// Callers can set the value of the
    /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
    /// <see langword="true" /> as a means of stopping the operation from proceeding.
    /// </remarks>
[ExplicitlySynchronized]
    public class ClosingSolutionEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.ClosingSolutionEventArgs" /> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Visual Studio Solution (<c>*.sln</c>) file that
        /// is about to be closed/unloaded in a running Visual Studio instance.
        /// </param>
        public ClosingSolutionEventArgs(IVisualStudioSolution solution)
        {
            Solution = solution;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Visual Studio Solution (<c>*.sln</c>) file that
        /// is about to be closed/unloaded in a running Visual Studio instance.
        /// </summary>
        public IVisualStudioSolution Solution
        {
            get;
        }
    }
}