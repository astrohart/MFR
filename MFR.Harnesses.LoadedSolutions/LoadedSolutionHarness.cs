using MFR.Harnesses.LoadedSolutions.Interfaces;
using System;
using System.ComponentModel;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions
{
    public class LoadedSolutionHarness : ILoadedSolutionHarness
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        public string FileName
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the Visual Studio Solution (
        /// <c>*.sln</c>) file managed by the target instance of Visual Studio is in the
        /// directory tree of the current Project File Renamer operation or not.
        /// </summary>
        /// <remarks>
        /// This is important because it may very well be the case that there may be
        /// running instances of Visual Studio lying about, that have Visual Studio
        /// Solution (<c>*.sln</c>) file(s) loaded, and these particular files are not
        /// underneath the starting folder selected by the user in the Project File
        /// Renamer.
        /// </remarks>
        public bool IsInRootDirectoryTree
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value that indicates whether the target Visual Studio Solution (
        /// <c>*.sln</c>) file is loaded in a running instance of Visual Studio.
        /// </summary>
        public bool IsLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Such an object is utilized to automate the instance of Visual Studio that
        /// controls the particular Visual Studio Solution (<c>*.sln</c>) file.
        /// </remarks>
        public IVisualStudioSolution SolutionObject
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has finished loading
        /// the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        public event EventHandler Loaded;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio is about to begin
        /// loading the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        /// <remarks>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" /> property to
        /// <see langword="true" /> to prevent the operation from being carried out.
        /// </remarks>
        public event CancelEventHandler Loading;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has been exited.
        /// </summary>
        public event EventHandler Quitted;

        /// <summary>
        /// Occurs when we are about to shut down the target running instance of Visual
        /// Studio.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        public event CancelEventHandler Quitting;

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// opened using the Windows Shell.
        /// </summary>
        public event EventHandler ShellOpened;

        /// <summary>
        /// Occurs when we are about to open the target Visual Studio Solution (
        /// <c>*.sln</c>) file using the Windows Shell.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        public event CancelEventHandler ShellOpening;

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// unloaded from the target running instance of Visual Studio.
        /// </summary>
        public event EventHandler Unloaded;

        /// <summary>
        /// Occurs when we are about to unload the target Visual Studio Solution (
        /// <c>*.sln</c>) file from the target running instance of Visual Studio.
        /// </summary>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" />
        /// property to
        /// <see langword="true" />
        /// to prevent the operation from being carried out.
        /// </remarks>
        public event CancelEventHandler Unloading;

        /// <summary>
        /// Opens the target Visual Studio Solution (<c>*.sln</c>) file in the target
        /// running instance of Visual Studio.
        /// </summary>
        public void Load()
            => throw new NotImplementedException();

        /// <summary>
        /// Exits the running instance of Visual Studio that has the target Visual Studio
        /// Solution (<c>*.sln</c>) file open.
        /// </summary>
        public void Quit()
            => throw new NotImplementedException();

        /// <summary>
        /// Open the target Visual Studio Solution (<c>*.sln</c>) file (if it exists) using
        /// the Windows Shell.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise, or if the operation is cancelled.
        /// </returns>
        public bool ShellOpen()
            => throw new NotImplementedException();

        /// <summary>
        /// Unloads the target Visual Studio Solution (<c>*.sln</c>) file from the running
        /// instance of Visual Studio that has it open.
        /// </summary>
        public void Unload()
            => throw new NotImplementedException();
    }
}