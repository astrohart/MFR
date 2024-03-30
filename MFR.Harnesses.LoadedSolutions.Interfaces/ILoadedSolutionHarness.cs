using System;
using System.ComponentModel;
using xyLOGIX.VisualStudio.Solutions.Interfaces;

namespace MFR.Harnesses.LoadedSolutions.Interfaces
{
    public interface ILoadedSolutionHarness
    {
        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the folder that the target Solution is located in.
        /// </summary>
        /// <remarks>
        /// This property returns the <see cref="F:System.String.Empty" /> value
        /// in the case that the value cannot be determined.
        /// </remarks>
        string ContainingFolder
        {
            get;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        string FullName
        {
            get;
        }

        /// <summary>
        /// Gets or sets a value that indicates whether the Visual Studio Solution (
        /// <c>*.sln</c>) file managed by the target instance of Visual Studio is in the
        /// directory tree of the current Project File Renamer operation or not.
        /// </summary>
        /// <remarks>
        /// This important because it may very well be the case that there may be
        /// running instances of Visual Studio lying about, that have Visual Studio
        /// Solution (<c>*.sln</c>) file(s) loaded, and these particular files are not
        /// underneath the starting folder selected by the user in the Project File
        /// Renamer.
        /// </remarks>
        bool IsInRootDirectoryTree
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value that indicates whether the target Visual Studio Solution (
        /// <c>*.sln</c>) file is loaded in a running instance of Visual Studio.
        /// </summary>
        bool IsLoaded
        {
            get;
        }

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// Such an object is utilized to automate the instance of Visual Studio that
        /// controls the particular Visual Studio Solution (<c>*.sln</c>) file.
        /// <para />
        /// When the value of this property is updated, the
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolutionChanged" />
        /// event is raised.
        /// </remarks>
        IVisualStudioSolution TargetSolution
        {
            get;
            set;
        }

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has finished loading
        /// the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        event EventHandler Loaded;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio is about to begin
        /// loading the target Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        /// <remarks>
        /// The handler can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventHandler.Cancel" /> property to
        /// <see langword="true" /> to prevent the operation from being carried out.
        /// </remarks>
        event CancelEventHandler Loading;

        /// <summary>
        /// Occurs when the target running instance of Visual Studio has been exited.
        /// </summary>
        event EventHandler Quitted;

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
        event CancelEventHandler Quitting;

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// opened using the Windows Shell.
        /// </summary>
        event EventHandler ShellOpened;

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
        event CancelEventHandler ShellOpening;

        /// <summary>
        /// Occurs when the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.LoadedSolutionHarness.TargetSolution" />
        /// property is changed.
        /// </summary>
        event EventHandler TargetSolutionChanged;

        /// <summary>
        /// Occurs when the target Visual Studio Solution (<c>*.sln</c>) file has been
        /// unloaded from the target running instance of Visual Studio.
        /// </summary>
        event EventHandler Unloaded;

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
        event CancelEventHandler Unloading;

        /// <summary>
        /// Opens the target Visual Studio Solution (<c>*.sln</c>) file in the target
        /// running instance of Visual Studio.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise or if the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution" />
        /// property is <see langword="null" />.
        /// </returns>
        bool Load();

        /// <summary>
        /// Exits the running instance of Visual Studio that has the target Visual Studio
        /// Solution (<c>*.sln</c>) file open.
        /// </summary>
        void Quit();

        /// <summary>
        /// Updates the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.FullName" />
        /// property.
        /// </summary>
        /// <param name="fullName">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the Visual Studio Solution (<c>*.sln</c>) file
        /// that is represented by the target solution.
        /// </param>
        /// <remarks>
        /// This method is used when the Project File Renamer algorithms have
        /// renamed the Visual Studio Solution (<c>*.sln</c>) file that corresponds to the
        /// Solution that is currently loaded in the target running instance of Visual
        /// Studio.
        /// </remarks>
        void SetFullName(string fullName);

        /// <summary>
        /// Open the target Visual Studio Solution (<c>*.sln</c>) file (if it exists) using
        /// the Windows Shell.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise, or if the operation is cancelled.
        /// </returns>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpening" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.ShellOpened" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        bool ShellOpen();

        /// <summary>
        /// Unloads the target Visual Studio Solution (<c>*.sln</c>) file from the running
        /// instance of Visual Studio that has it open.
        /// </summary>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise or if the value of the
        /// <see
        ///     cref="P:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.TargetSolution" />
        /// property is <see langword="null" />.
        /// </returns>
        /// <remarks>
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloading" />
        /// event is raised before the operation is carried out.  Handlers have a chance to
        /// request that the operation be cancelled.
        /// <para />
        /// The
        /// <see
        ///     cref="E:MFR.Harnesses.LoadedSolutions.Interfaces.ILoadedSolutionHarness.Unloaded" />
        /// event is raised when this method has completed executing the requested
        /// operations.
        /// </remarks>
        bool Unload();
    }
}