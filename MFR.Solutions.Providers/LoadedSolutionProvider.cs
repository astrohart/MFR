using MFR.Solutions.Providers.Interfaces;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;
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
        /// Reference to an instance of a collection of instances of objects that implement
        /// the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        private readonly IList<IVisualStudioSolution> _loadedSolutions =
            new AdvisableCollection<IVisualStudioSolution>();

        /// <summary>
        /// A <see cref="T:System.String" /> that contains the fully-qualified pathname of
        /// the folder in which the operation(s) that are selected by the user start.
        /// </summary>
        private string _rootDirectoryPath;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static LoadedSolutionProvider() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
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
            => _loadedSolutions;

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder in which the operation(s) that are selected by the user
        /// start.
        /// </summary>
        /// <remarks>
        /// If the value of this property is updated, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        public string RootDirectoryPath
        {
            get => _rootDirectoryPath;
            private set {
                var changed = _rootDirectoryPath != value;
                _rootDirectoryPath = value;
                if (changed) OnRootDirectoryPathChanged();
            }
        }

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPath" />
        /// property is updated.
        /// </summary>
        public event EventHandler RootDirectoryPathChanged;

        /// <summary>
        /// Updates the value of the
        /// <see cref="P:MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPath" />
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
        /// When this method has updated the value of the property, then the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event is raised.
        /// </remarks>
        public void SetRootDirectoryPath(string pathname)
        {
            try
            {
                if (!Does.FolderExist(pathname)) return;

                RootDirectoryPath = pathname;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Solutions.Providers.LoadedSolutionProvider.RootDirectoryPathChanged" />
        /// event.
        /// </summary>
        protected virtual void OnRootDirectoryPathChanged()
            => RootDirectoryPathChanged?.Invoke(this, EventArgs.Empty);
    }
}