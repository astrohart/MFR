using System;
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
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder in which the operation(s) that are selected by the user
        /// start.
        /// </summary>
        /// <remarks>
        /// If the value of this property is updated, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        string RootDirectoryPath
        {
            get;
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property is updated.
        /// </summary>
        event EventHandler RootDirectoryPathChanged;

        /// <summary>
        /// Updates the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property with the specified folder <paramref name="pathname" />.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the folder that should be set as the
        /// new root directory value.
        /// </param>
        /// <remarks>
        /// The term "root directory" pertains to the folder in which the operation(s)
        /// specified by the user for this application to execute, start.
        /// <para />
        /// If the argument of the <paramref name="pathname" /> parameter does not refer to
        /// a folder that exists on the file system, then this method does nothing.
        /// <para />
        /// When this method has updated the value of the
        /// <see
        ///     cref="P:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPath" />
        /// property, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        void SetRootDirectoryPath(string pathname);
    }
}