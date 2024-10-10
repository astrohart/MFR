using PostSharp.Patterns.Threading;
using System;

namespace MFR.Renamers.Files.Events
{
    /// <summary>
    /// Provides information for <c>SolutionClosed</c> event handlers.
    /// </summary>
    /// <remarks>
    /// The <c>SolutionClosed</c> event is used to indicate that a running
    /// instance of Visual Studio has just finished closing/unloading a Visual Studio
    /// Solution (<c>*.sln</c>) file.
    /// </remarks>
[ExplicitlySynchronized]
    public class SolutionClosedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionClosedEventArgs" /> and returns
        /// a reference to it.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a Visual Studio Solution (<c>*.sln</c>) file that has just been
        /// unloaded by a running instance of Visual Studio.
        /// </param>
        public SolutionClosedEventArgs(string pathname)
        {
            Pathname = pathname;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the Visual Studio Solution (<c>*.sln</c>) file that was most
        /// recently closed/unloaded by a running instance of Visual Studio.
        /// </summary>
        public string Pathname
        {
            get;
        }
    }
}