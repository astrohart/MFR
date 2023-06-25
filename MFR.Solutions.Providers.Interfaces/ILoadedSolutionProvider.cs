using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Solutions.Providers.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties of an object that manages
    /// the Visual Studio Solution (<c>*.sln</c>) files that are currently loaded in
    /// running instances of Visual Studio..
    /// </summary>
    public interface ILoadedSolutionProvider
    {
        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Each element of the collection represents a Visual Studio Solution (*.sln) that
        /// is loaded in a running instance of Visual Studio.
        /// </remarks>
        IList<IVisualStudioSolution> LoadedSolutions
        {
            get;
            set;
        }
    }
}