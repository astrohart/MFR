using MFR.Solutions.Providers.Interfaces;
using System.Collections.Generic;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Solutions.Providers
{
    /// <summary>
    /// Manages the Visual Studio Solution (<c>*.sln</c>) files that are currently
    /// loaded in running instances of Visual Studio.
    /// </summary>
    public class LoadedSolutionProvider : ILoadedSolutionProvider
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static LoadedSolutionProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected LoadedSolutionProvider() { }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider" />
        /// interface.
        /// </summary>
        public static ILoadedSolutionProvider Instance
        {
            get;
        } = new LoadedSolutionProvider();

        /// <summary>
        /// Gets a reference to a collection, each element of which implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Each element of the collection represents a Visual Studio Solution (*.sln) that
        /// is loaded in a running instance of Visual Studio.
        /// </remarks>
        public IList<IVisualStudioSolution> LoadedSolutions
        {
            get;
            set;
        } = new List<IVisualStudioSolution>();
    }
}