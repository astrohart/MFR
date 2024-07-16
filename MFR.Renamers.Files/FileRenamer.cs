using MFR.Constants;
using MFR.Directories.Managers.Factories;
using MFR.Directories.Managers.Interfaces;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.Engines.Replacement.Factories;
using MFR.Engines.Replacement.Intefaces;
using MFR.Events;
using MFR.Events.Common;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Factories;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Operations.Exceptions;
using MFR.Renamers.Files.Actions;
using MFR.Renamers.Files.Constants;
using MFR.Renamers.Files.Events;
using MFR.Renamers.Files.Interfaces;
using MFR.Renamers.Files.Properties;
using MFR.Services.Solutions.Factories;
using MFR.Services.Solutions.Interfaces;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Mappers;
using MFR.Settings.Configuration.Mappers.Constants;
using MFR.Settings.Configuration.Mappers.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.Solutions.Providers.Factories;
using MFR.Solutions.Providers.Interfaces;
using MFR.TextValues.Retrievers.Factories;
using PostSharp.Patterns.Collections;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Files.Actions;
using xyLOGIX.Files.MemoryMapped.Factories;
using xyLOGIX.Interop.Git.Factories;
using xyLOGIX.Interop.Git.Interfaces;
using xyLOGIX.Interop.Processes.Actions;
using xyLOGIX.Pools.Tasks.Factories;
using xyLOGIX.Pools.Tasks.Interfaces;
using xyLOGIX.Queues.Messages.Senders;
using xyLOGIX.VisualStudio.Providers.Factories;
using xyLOGIX.VisualStudio.Providers.Interfaces;
using xyLOGIX.VisualStudio.Solutions.Interfaces;
using xyLOGIX.Win32.Interact;
using Delete = MFR.Renamers.Files.Actions.Delete;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using Formulate = MFR.Renamers.Files.Actions.Formulate;
using Get = MFR.Services.Solutions.Actions.Get;
using Is = xyLOGIX.VisualStudio.Actions.Is;
using Path = Alphaleonis.Win32.Filesystem.Path;
using Process = System.Diagnostics.Process;
using Should = MFR.Renamers.Files.Actions.Should;
using Thread = System.Threading.Thread;

namespace MFR.Renamers.Files
{
    /// <summary>
    /// Provides file- and folder-rename services.
    /// </summary>
    /// <remarks>
    /// NOTE: Instances of this class must be composed with an instance of an
    /// object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
    /// interface.
    /// <para />
    /// Such an object is necessary because it provides settings specified by
    /// the user that change the behavior of this object.
    /// </remarks>
    public class FileRenamer : ConfigurationComposedObjectBase, IFileRenamer
    {
        /// <summary>
        /// A <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration value
        /// that describes what operation is currently being performed by the application.
        /// </summary>
        private OperationType _currentOperation;

        /// <summary>
        /// A <see cref="T:System.String" /> containing the full pathname of the folder
        /// where all operations start.
        /// </summary>
        private string _rootDirectoryPath;

        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static FileRenamer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected FileRenamer()
        {
            IsBusy = false;
        }

        /// <summary>
        /// Gets a value that indicates whether an abort of the current
        /// operation has been requested.
        /// </summary>
        public bool AbortRequested
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Mappers.Interfaces.IConfigurationStringMapper" />
        /// interface for commit messages.
        /// </summary>
        private static IConfigurationStringMapper CommitMessageMapper
        {
            get;
        } = GetConfigurationStringMapper.OfType(
            ConfigurationStringMapperType.CommitMessage
        );

        /// <summary>
        /// Gets a reference to the sole instance of the object that implements the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user config and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigProvider ConfigProvider
            => GetProjectFileRenamerConfigProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfig" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfig CurrentConfiguration
        {
            get;
            set;
        } = ConfigProvider.CurrentConfiguration;

        /// <summary>
        /// Gets or sets the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration value that indicates which operation is currently being performed.
        /// </summary>
        public OperationType CurrentOperation
        {
            get => _currentOperation;
            set {
                var changed = _currentOperation != value;
                _currentOperation = value;
                if (changed)
                    OnCurrentOperationChanged(
                        new CurrentOperationChangedEventArgs(value)
                    );
            }
        }

        /// <summary>
        /// Gets a reference to a collection of the
        /// <see
        ///     cref="T:MFR.Operations.Constants.OperationType" />
        /// values.
        /// </summary>
        /// <remarks>
        /// All the values in this collection identify operations that the user
        /// wishes to perform.
        /// <para />
        /// This list should be cleared after every run.
        /// <para />
        /// If the list is empty when the
        /// <see
        ///     cref="M:MFR.FileRenamer.ProcessAll" />
        /// method is called, do
        /// nothing or throw an exception.
        /// </remarks>
        protected IList<OperationType> EnabledOperations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of the object that implements the
        /// <see cref="T:MFR.Renamers.Files.Interfaces.IFileRenamer" /> interface.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IFileRenamer Instance
        {
            get;
        } = new FileRenamer();

        /// <summary>
        /// Gets a value that indicates whether this component is currently processing
        /// operation(s).
        /// </summary>
        public bool IsBusy
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value that indicates whether this component is currently processing
        /// operation(s).
        /// </summary>
        public bool IsStarted
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the path to the folder in which last Visual Studio Solution that
        /// we have worked with most recently resides.
        /// </summary>
        public string LastSolutionFolderPath
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Solutions.Providers.Interfaces.ILoadedSolutionProvider" />
        /// interface.
        /// </summary>
        private static ILoadedSolutionProvider LoadedSolutionProvider
        {
            get;
        } = GetLoadedSolutionProvider.SoleInstance();

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
            => LoadedSolutionProvider?.LoadedSolutions;

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.Git.Interfaces.ILocalGitInteropProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object provides access to Git functionality on the local machine.
        /// </remarks>
        private ILocalGitInteropProvider LocalGitInteropProvider
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the fully-qualified pathname
        /// of the folder where all operations start.
        /// </summary>
        /// <remarks>
        /// This property raises the
        /// <see cref="E:MFR.Renamers.Files.FileRenamer.RootDirectoryPathChanged" /> event
        /// when its value is updated.
        /// </remarks>
        public string RootDirectoryPath
        {
            get => _rootDirectoryPath;
            private set {
                var formerValue = _rootDirectoryPath;
                var changed = _rootDirectoryPath != value;
                _rootDirectoryPath = value;
                if (changed)
                    OnRootDirectoryPathChanged(
                        new RootDirectoryPathChangedEventArgs(
                            formerValue, value
                        )
                    );
            }
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Validators.Interfaces.IRootDirectoryPathValidator" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object runs validation rules to ensure, among other things, that the
        /// pathname passed to it is that of a folder that exists on disk, and that
        /// contains a <c>.sln</c> file.
        /// </remarks>
        private static IRootDirectoryPathValidator RootDirectoryPathValidator
        {
            get;
        } = GetRootDirectoryPathValidator.SoleInstance();

        /// <summary>
        /// Gets a collection of fully-qualified pathnames of folders found by this object,
        /// that
        /// should be searched for projects, files, and folders whose names should be
        /// changed.
        /// </summary>
        private IList<string> SearchDirectories
            => SearchDirectoryManager.SearchDirectories;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Directories.Managers.Interfaces.ISearchDirectoryManager" />
        /// interface.
        /// </summary>
        private static ISearchDirectoryManager SearchDirectoryManager
        {
            get;
        } = GetSearchDirectoryManager.SoleInstance();

        /// <summary>
        /// Gets a value determining whether the currently-open solution
        /// in Visual Studio should be closed and then re-opened at the
        /// completion of the operation.
        /// </summary>
        public bool ShouldReOpenSolutions
        {
            get;
            private set;
        }

        /// <summary>
        /// Synchronization root object for creating critical sections.
        /// </summary>
        private static object SyncRoot
        {
            get;
        } = new object();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Pools.Tasks.Interfaces.ITaskPool" /> interface.
        /// </summary>
        private static ITaskPool TaskPool
        {
            get;
        } = GetTaskPool.SoleInstance();

        /// <summary>
        /// Gets or sets a <see cref="T:System.Int32" /> with the total changes pending
        /// prior to the attempt to commit them.
        /// </summary>
        /// <remarks>
        /// This count refers to the count of pending changes in local Git repo(s)
        /// that existed PRIOR TO the file-renaming operations taking place.
        /// <para />
        /// The default value of this property is <c>-1</c>.  This indicates the property's
        /// value has not been computed yet, or that we've begun a new round of processing.
        /// </remarks>
        private int TotalReposWithPendingChanges
        {
            get;
            set;
        } = -1;

        private static IVisualStudioInstanceProvider
            VisualStudioInstanceProvider
        {
            get;
        } = GetVisualStudioInstanceProvider.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Services.Solutions.Interfaces.IVisualStudioSolutionService" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This property allows access to an object that helps us manage the Visual Studio
        /// Solution(s) that may be in the starting folder, and to track which running
        /// instance(s), if any, have said Solution(s) open, and to command the instance(s)
        /// to load/unload the Solution(s).
        /// </remarks>
        private static IVisualStudioSolutionService VisualStudioSolutionService
            => GetVisualStudioSolutionService.SoleInstance();

        /// <summary>
        /// Occurs when the value of the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.CurrentOperation" /> property is
        /// updated.
        /// </summary>
        public event CurrentOperationChangedEventHandler
            CurrentOperationChanged;

        /// <summary>
        /// Occurs when an exception is thrown from an operation.
        /// </summary>
        public event ExceptionRaisedEventHandler ExceptionRaised;

        /// <summary>
        /// Occurs when a file has been renamed.
        /// </summary>
        public event FileRenamedEventHandler FileRenamed;

        /// <summary>
        /// Occurs when files to be renamed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler FilesToBeRenamedCounted;

        /// <summary>
        /// Occurs when files to be processed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            FilesToHaveTextReplacedCounted;

        /// <summary>
        /// Occurs when the processing is completely finished.
        /// </summary>
        public event EventHandler Finished;

        /// <summary>
        /// Occurs when a folder has been renamed.
        /// </summary>
        public event FolderRenamedEventHandler FolderRenamed;

        /// <summary>
        /// Occurs when an operation has completed.
        /// </summary>
        public event OperationFinishedEventHandler OperationFinished;

        /// <summary>
        /// Occurs when an operation has commenced.
        /// </summary>
        public event OperationStartedEventHandler OperationStarted;

        /// <summary>
        /// Occurs when the pending changes to be committed to Git have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            PendingChangesToBeCommittedCounted;

        /// <summary>
        /// Occurs when an operation is about to be processed for a file or a folder.
        /// </summary>
        public event ProcessingOperationEventHandler ProcessingOperation;

        /// <summary>
        /// Occurs when the results that are to be committed to Git have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            ResultsToBeCommittedToGitCounted;

        /// <summary>
        /// Occurs if the value of the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.RootDirectoryPath" /> property is
        /// changed.
        /// </summary>
        public event RootDirectoryPathChangedEventHandler
            RootDirectoryPathChanged;

        /// <summary>
        /// Occurs when an attempt to close a Visual Studio Solution (<c>*.sln</c>)  that
        /// has been loaded into a running instance of Visual Studio has failed.
        /// </summary>
        public event SolutionCloseFailedEventHandler SolutionCloseFailed;

        /// <summary>
        /// Occurs when a folder that contains a Visual Studio Solution (<c>*.sln</c>) file
        /// has been renamed.
        /// </summary>
        public event FolderRenamedEventHandler SolutionFolderRenamed;

        /// <summary>
        /// Occurs when an attempt to open a Visual Studio Solution (<c>*.sln</c>) file in
        /// a running instance of Visual Studio has failed.
        /// </summary>
        public event SolutionOpenFailedEventHandler SolutionOpenFailed;

        /// <summary>
        /// Occurs when the processing has started.
        /// </summary>
        public event EventHandler Started;

        /// <summary>
        /// Occurs just before the processing has started.
        /// </summary>
        public event EventHandler Starting;

        /// <summary>
        /// Occurs when a textual status message is available for display.
        /// </summary>
        public event StatusUpdateEventHandler StatusUpdate;

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname stored in the
        /// <see
        ///     cref="P:MFR.FileRenamer.RootDirectoryPath" />
        /// property.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        public bool ProcessAll(
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] Predicate<string> pathFilter = null
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(RootDirectoryPath))
                    return result;
                if (!Directory.Exists(RootDirectoryPath))
                    return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (string.IsNullOrWhiteSpace(replaceWith))
                    return result;

                TotalReposWithPendingChanges =
                    -1; // reset the TotalReposWithPendingChanges property

                if (CurrentConfiguration.ShouldCommitPendingChanges &&
                    !CommitPendingChanges(
                        RootDirectoryPath, findWhat, replaceWith
                    ) &&
                    TotalReposWithPendingChanges >
                    0 /* don't show the commit failure warning if there were no pending changes to start with */
                    && !CurrentConfiguration
                        .AutoStart /* don't show the message box if we're automatically started */
                   )
                    Messages.ShowWarning(
                        Resources.Warning_FailedCommitPendingChanges
                    );

                var renameFilesInFolderResult = true;
                if (CurrentConfiguration.RenameFilesInFolder)
                    renameFilesInFolderResult = RenameFilesInFolder(
                        RootDirectoryPath, findWhat, replaceWith, pathFilter
                    );

                var renameSubFoldersResult = true;
                if (CurrentConfiguration.RenameSubFolders)
                    renameSubFoldersResult = RenameSubFoldersOf(
                        RootDirectoryPath, findWhat, replaceWith, pathFilter
                    );

                var replaceTextInFilesResult = true;
                if (CurrentConfiguration.ReplaceTextInFiles)
                    replaceTextInFilesResult = ReplaceTextInFiles(
                        RootDirectoryPath, findWhat,
                        replaceWith /* filtering paths (besides the default) makes no sense for this operation */
                    );

                var renameSolutionFoldersResult = true;
                if (CurrentConfiguration.RenameSolutionFolders)
                    renameSolutionFoldersResult = RenameSolutionFolders(
                        RootDirectoryPath, findWhat, replaceWith
                    );

                var commitResultsToGitResult = true;
                if (CurrentConfiguration.ShouldCommitPostOperationChanges)
                    commitResultsToGitResult = CommitResultsToGit(
                        RootDirectoryPath, findWhat, replaceWith
                    );

                result = renameFilesInFolderResult && renameSubFoldersResult &&
                         replaceTextInFilesResult &&
                         renameSolutionFoldersResult &&
                         commitResultsToGitResult;
            }
            catch (OperationAbortedException ex)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR *** The user has requested that the operation(s) be aborted immediately."
                );

                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                //Ignored.

                result = true;
            }
            finally
            {
                LocalGitInteropProvider?.Dispose();
                LocalGitInteropProvider = null;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info, $"FileRenamer.ProcessAll: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// (Required.) FullName to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the value of the
        /// <see
        ///     cref="P:MFR.Settings.Configuration.ConfigurationComposedObjectBase.CurrentConfiguration" />
        /// property has not been set prior to calling this method.
        /// <para />
        /// Call the
        /// <see
        ///     cref="M:MFR.Settings.Configuration.ConfigurationComposedObjectBase.UpdateConfiguration" />
        /// method on this object prior to calling this method.
        /// </exception>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="rootDirectoryPath" />
        /// , is passed a blank or
        /// <see
        ///     langword="null" />
        /// string for a value.
        /// </exception>
        public void ProcessAll(
            [NotLogged] string rootDirectoryPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] Predicate<string> pathFilter = null
        )
        {
            if (CurrentConfiguration == null)
                throw new InvalidOperationException(
                    "The config has not been initialized."
                );
            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootDirectoryPath)
                );

            try
            {
                /*
                 * OKAY, so the path parameter is understood to contain
                 * the pathname of the folder that is filled in by the user in the
                 * Starting Folder text box.
                 *
                 * In prior versions of this app, that folder was where we would simply
                 * start our file and folder enumerations.  The primary use case of
                 * this software is to be installed into the 'Tools' menu of Visual
                 * Studio as an External Tool and to be configured to have the
                 * folder containing the currently-opened solution inside its
                 * Starting Folder text box.  The thinking is that the user wants
                 * to call up this tool from within Visual Studio in order to do
                 * project-renaming on the currently open solution.
                 *
                 * However, there is a secondary use case: that of launching the tool
                 * from the Start menu, with the option to specify whatever folder
                 * we like in the Starting Folder text box.  Such a folder may, or
                 * may not, contain a single .sln file.  It may be the root of a
                 * whole directory TREE of solutions, that ALL need name changes.
                 * Say, for instance, we have a bunch of projects with the name
                 * of the company, XYZCorp, in them.  Say XYZCorp now goes through
                 * a re-brand and becomes ABCorp.  So, perhaps the user may want
                 * to launch this tool in their main dev folder, and specify that
                 * the rename XYZCorp -> ABCorp has to happen for ALL the solutions
                 * in ALL the subfolders of the folder specified.
                 */

                SearchDirectoryManager.Clear();

                SearchDirectoryManager.Search(
                    rootDirectoryPath,
                    file => !Services.Solutions.Actions.Should.SkipSolutionFile(
                        file
                    )
                );

                foreach (var folder in SearchDirectories)
                    DoProcessAll(folder, findWhat, replaceWith, pathFilter);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Renames all the files in the all the subfolders etc., recursively,
        /// of the folder whose pathname is specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation was successful;
        /// <see langword="false" /> if the operation failed or if the user cancelled the
        /// operation.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" />,
        /// <paramref
        ///     name="findWhat" />
        /// , or <paramref name="replaceWith" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        public bool RenameFilesInFolder(
            [NotLogged] string rootFolderPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] Predicate<string> pathFilter = null
        )
        {
            var result = false;

            // write the name of the current class and method we are now
            if (string.IsNullOrWhiteSpace(rootFolderPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootFolderPath)
                );
            if (!Directory.Exists(rootFolderPath))
                throw new DirectoryNotFoundException(
                    $"The specified folder, with pathname '{rootFolderPath}', could not be located on the file system."
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            try
            {
                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.CalculateListOfFilesToBeRenamed
                    )
                );

                /*
                 * First, we obtain the set of all files that need to be
                 * renamed.  Rules, that the user can define, are used to
                 * narrow the search.
                 */

                IFileSystemEntryListRetriever retriever =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameFilesInFolder)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (retriever == null)
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.CalculateListOfFilesToBeRenamed
                            )
                        );
                        return result;
                    }

                var entryCollection = retriever.UsingSearchPattern("*")
                                               .WithSearchOption(
                                                   SearchOption.AllDirectories
                                               )
                                               .ToFindWhat(findWhat)
                                               .AndReplaceItWith(replaceWith)
                                               .GetMatchingFileSystemPaths(
                                                   RootDirectoryPath, pathFilter
                                               );
                if (entryCollection == null || !entryCollection.Any())
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.CalculateListOfFilesToBeRenamed
                            )
                        );
                        return result;
                    }

                var fileSystemEntries = entryCollection.ToList();
                if (fileSystemEntries == null || !fileSystemEntries.Any())
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.CalculateListOfFilesToBeRenamed
                            )
                        );
                        return result;
                    }

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.CalculateListOfFilesToBeRenamed
                    )
                );

                OnFilesToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        fileSystemEntries.Count,
                        OperationType.RenameFilesInFolder
                    )
                );

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.RenameFilesInFolder
                    )
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        string.Format(
                            Resources.StatusUpdate_RenamingFilesInFolders,
                            RootDirectoryPath, findWhat, replaceWith
                        ), CurrentOperation
                    )
                );

                result = fileSystemEntries.TakeWhile(entry => !AbortRequested)
                                          .All(
                                              entry
                                                  => RenameFileInFolderForEntry(
                                                      findWhat, replaceWith,
                                                      entry
                                                  )
                                          );

                result &= !AbortRequested;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;
                return result;
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(
                    OperationType.RenameFilesInFolder
                )
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"*** Finished renaming files in subfolders of '{RootDirectoryPath}'.",
                    CurrentOperation, true /* operation finished */
                )
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFilesInFolder: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Iterates through the directory tree that is topped by the folder having the
        /// specified <paramref name="rootFolderPath" />, and, for all Visual Studio
        /// Solution (<c>*.sln</c>) file(s) found in the directory tree, renames them
        /// according to the text-replacement pattern specified by the arguments of the
        /// <paramref name="findWhat" /> and <paramref name="replaceWith" /> parameters.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a folder in which the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" /> containing the text that the text
        /// specified by the argument of the <paramref name="findWhat" /> parameter is to
        /// be replaced with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" /> or the
        /// <paramref name="findWhat" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        public bool RenameSolutionFolders(
            [NotLogged] string rootFolderPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] Predicate<string> pathFilter = null
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(rootFolderPath)) return result;
                if (!Directory.Exists(rootFolderPath)) return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;

                // for a folder rename operation the replaceWith must be filled in
                // however, if the replaceWith is blank, then return true regardless,
                // so that this operation is merely skipped without the entire sequence
                // of operations being deemed a failure
                if (string.IsNullOrWhiteSpace(replaceWith)) return true;

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.RenameSolutionFolders
                    )
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        string.Format(
                            Resources
                                .StatusUpdate_AttemptingRenameSolutionFolders,
                            rootFolderPath
                        ), CurrentOperation
                    )
                );

                IFileSystemEntryListRetriever retriever =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameSolutionFolders)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (retriever == null) return result;

                // build a list of solution folders to be processed
                var fileSystemEntries = retriever.UsingSearchPattern("*")
                                                 .WithSearchOption(
                                                     SearchOption.AllDirectories
                                                 )
                                                 .ToFindWhat(findWhat)
                                                 .AndReplaceItWith(replaceWith)
                                                 .GetMatchingFileSystemPaths(
                                                     RootDirectoryPath,
                                                     pathFilter
                                                 )
                                                 .ToList();

                // NOTE: There is a chance that this particular operation will
                // alter the pathname that is stored in the value of the
                // RootDirectoryPath property.  We should make sure to take this
                // into account.

                if (!fileSystemEntries.Any() && !AbortRequested)
                {
                    /*
                     * If we are here, then no folders that contain Visual Studio Solution (<c>*.sln</c>)
                     * were found whose names also match the user's search criteria, and the user has not
                     * clicked the Cancel button in the progress dialog.  Therefore, just report
                     * this operation as being finished, and then exit this method.
                     */
                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.RenameSolutionFolders
                        )
                    );

                    return result;
                }

                /*
                 * If, at this point, the AbortRequested property is true,
                 * then the user must have cancelled the progress dialog.
                 *
                 * This indicates that the user wishes us to stop the operation
                 * at this point.
                 */

                if (AbortRequested)
                    throw new OperationAbortedException(
                        Resources.Error_OperationAborted
                    );

                /*
                 * Inform the user (and other parts of the application, such as the
                 * progress dialog) of the count of folders that have been obtained.
                 */

                OnSolutionFoldersToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        fileSystemEntries.Count,
                        OperationType.RenameSolutionFolders
                    )
                );

                // Quit ALL of the instance(s) of Visual Studio that formerly had any of the
                // Solution(s) anywhere in the directory tree of the 'source' folder open
                // NOTE: We only get here if a particular Solution's folder needs renaming

                /*
                 * NOTE: This not good enough.  EVERY running instance of Visual Studio, regardless of
                 * whether they have Solution(s) loaded or not, must be closed in order for
                 * this operation to succeed.
                 */
                foreach (var solution in LoadedSolutions)
                    solution.Quit();

                /*
                 * OKAY, this the loop over the list of the folders that we've found
                 * underneath the Root Directory, that contain Visual Studio Solution (<c>*.sln</c>)
                 * files, and whose names match the search criteria that was specified
                 * by the user.  For each folder, rename it according to the settings
                 * specified by the user.  NOTE: The method called must return TRUE for ALL
                 * the folders, in order for this operation to be considered a success.
                 */

                VisualStudioInstanceProvider.QuitAll();

                result = fileSystemEntries.TakeWhile(entry => !AbortRequested)
                                          .All(
                                              entry
                                                  => RenameSolutionFolderForEntry(
                                                      findWhat, replaceWith,
                                                      entry
                                                  )
                                          );

                if (!AbortRequested)
                    VisualStudioInstanceProvider.LaunchAll();

                /*
                 * If we are here, then the operation succeeded -- EXCEPT if the
                 * AbortRequested property is set to TRUE.
                 */

                result &= !AbortRequested;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                throw; // just bubble the exception up to the next level
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                result = false;
            }

            /*
             * We do a check of the AbortRequested property's value, and
             * a subsequent throw of OperationAbortedException if the
             * property is set to true, here.
             *
             * We do this in case a different thread set the property
             * before we got here.
             */

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(
                    OperationType.RenameSolutionFolders
                )
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    string.Format(
                        Resources.StatusUpdate_FinishedRenamingSolutionFolders,
                        rootFolderPath
                    ), CurrentOperation, true /* operation finished */
                )
            );

            return result;
        }

        /// <summary>
        /// Recursively renames all the subfolders in the folder having a
        /// pathname specified by <paramref name="rootFolderPath" />, replacing
        /// any occurrences of the text in the <paramref name="findWhat" />
        /// parameter with the values in the <paramref name="replaceWith" /> parameter.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) String containing the full pathname of an existing
        /// directory on the computer that is to be where the operation is started.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" />,
        /// <paramref
        ///     name="findWhat" />
        /// , or <paramref name="replaceWith" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        public bool RenameSubFoldersOf(
            [NotLogged] string rootFolderPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] Predicate<string> pathFilter = null
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(rootFolderPath))
                    return result;
                if (!Directory.Exists(rootFolderPath))
                    return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (string.IsNullOrWhiteSpace(replaceWith))
                    return result;

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.RenameSubFolders
                    )
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        string.Format(
                            Resources.Info_AttemptingToRenameSubFolders,
                            RootDirectoryPath, findWhat, replaceWith
                        ), CurrentOperation
                    )
                );

                IFileSystemEntryListRetriever retriever =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameSubFolders)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (retriever == null) return result;

                // Build list of folders to be processed
                var fileSystemEntries = retriever.UsingSearchPattern("*")
                                                 .WithSearchOption(
                                                     SearchOption.AllDirectories
                                                 )
                                                 .ToFindWhat(findWhat)
                                                 .AndReplaceItWith(replaceWith)
                                                 .GetMatchingFileSystemPaths(
                                                     RootDirectoryPath,
                                                     pathFilter
                                                 )
                                                 .ToList();

                if (!fileSystemEntries.Any() && !AbortRequested)
                {
                    /*
                     * If we are here, then no subfolders were found that match
                     * the user's search criteria, and the user has not clicked
                     * the Cancel button in the progress dialog.  Therefore,
                     * just report this operation as being finished, and then
                     * exit this method.
                     */

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.RenameSubFolders
                        )
                    );
                    return result;
                }

                /*
                 * If, at this point, the AbortRequested property is true,
                 * then the user must have cancelled the progress dialog.
                 *
                 * Therefore, we should throw OperationAbortedException.
                 */

                if (AbortRequested)
                    throw new OperationAbortedException(
                        Resources.Error_OperationAborted
                    );

                OnSubfoldersToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        fileSystemEntries.Count, OperationType.RenameSubFolders
                    )
                );

                /*
                 * OKAY, this the loop over the list of the subfolders
                 * whose pathnames match the search criteria specified by
                 * the user.  For each folder, rename it according to the
                 * settings specified by the user.
                 */

                result = fileSystemEntries.TakeWhile(entry => !AbortRequested)
                                          .All(
                                              entry => RenameSubFolderForEntry(
                                                  findWhat, replaceWith, entry
                                              )
                                          );

                /* if we are here, then the operation succeeded -- EXCEPT if the AbortRequested property is set to TRUE */
                result &= !AbortRequested;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                throw; // just bubble the exception up to the next level
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            /*
             * We do a check of the AbortRequested property's value, and
             * a subsequent throw of OperationAbortedException if the
             * property is set to true, here.
             *
             * We do this in case a different thread set the property
             * before we got here.
             */

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(OperationType.RenameSubFolders)
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"*** Finished processing subfolders of '{RootDirectoryPath}'.",
                    CurrentOperation, true /* operation finished */
                )
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFoldersOf: Result = {result}"
            );

            return result; /* result should be set to TRUE at this point */
        }

        /// <summary>
        /// Iterates recursively through a directory tree, starting at the
        /// folder with pathname <paramref name="rootFolderPath" /> and replacing
        /// every occurrence of the text specified by the
        /// <paramref
        ///     name="findWhat" />
        /// parameter with the text specified by the
        /// <paramref
        ///     name="replaceWith" />
        /// parameter. A case-sensitive, not-in-exact-word
        /// search is performed.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) Pathname of the folder where the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Optional.) Text to replace all the instances of
        /// <paramref
        ///     name="findWhat" />
        /// with. If this parameter is blank (the default),
        /// then the text is deleted.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation succeeded;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath" /> or the
        /// <paramref name="findWhat" /> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the
        /// <paramref
        ///     name="rootFolderPath" />
        /// does not exist.
        /// </exception>
        /// <exception cref="T:System.IO.IOException">
        /// Thrown if a file operation does not succeed.
        /// </exception>
        public bool ReplaceTextInFiles(
            string rootFolderPath,
            string findWhat,
            string replaceWith = "",
            Predicate<string> pathFilter = null
        )
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(rootFolderPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootFolderPath)
                );
            if (!Directory.Exists(rootFolderPath))
                throw new DirectoryNotFoundException(
                    $"The specified folder, with pathname '{rootFolderPath}', could not be located on the file system."
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );

            OnOperationStarted(
                new OperationStartedEventArgs(OperationType.ReplaceTextInFiles)
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"Replacing text in files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'...",
                    CurrentOperation
                )
            );

            IFileSystemEntryListRetriever retriever =
                GetFileSystemEntryListRetriever
                    .For(OperationType.ReplaceTextInFiles)
                    .AndAttachConfiguration(CurrentConfiguration);
            if (retriever == null) return result;

            IList<IFileSystemEntry> fileSystemEntries = retriever
                .UsingSearchPattern("*")
                .WithSearchOption(SearchOption.AllDirectories)
                .ToFindWhat(findWhat)
                .AndReplaceItWith(replaceWith)
                .GetMatchingFileSystemPaths(RootDirectoryPath, pathFilter)
                .ToList();

            if (fileSystemEntries == null) return result;

            var totalFileCount = fileSystemEntries.Count;

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.ReplaceTextInFiles: {totalFileCount} file(s) found to move forward on."
            );

            if (totalFileCount == 0 && !AbortRequested)
            {
                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"*** Finished replacing text in files contained inside subfolders of '{RootDirectoryPath}'.",
                        CurrentOperation, true /* operation finished */
                    )
                );

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.ReplaceTextInFiles
                    )
                );
                return result;
            }

            OnFilesToHaveTextReplacedCounted(
                new FilesOrFoldersCountedEventArgs(
                    totalFileCount, OperationType.ReplaceTextInFiles
                )
            );

            try
            {
                var executionResults = new ConcurrentBag<bool>();

                Parallel.ForEach(
                    fileSystemEntries, (entry, state) =>
                    {
                        if (AbortRequested)
                        {
                            state.Stop();
                            return;
                        }

                        executionResults.Add(
                            ReplaceTextInFileForEntry(
                                findWhat, replaceWith, entry
                            )
                        );
                    }
                );

                foreach (var executionResult in executionResults.ToArray())
                    if (!executionResult)
                    {
                        result = false;
                        break;
                    }
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                result = false;

                throw;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"*** Finished replacing text in files contained inside subfolders of '{RootDirectoryPath}'.",
                    CurrentOperation, true /* operation finished */
                )
            );

            OnOperationFinished(
                new OperationFinishedEventArgs(OperationType.ReplaceTextInFiles)
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.ReplaceTextInFiles: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Called to ask the <c>File Renamer</c> object to stop operations.
        /// </summary>
        public void RequestAbort()
            => AbortRequested = true;

        /// <summary>
        /// Sets the new root directory path from which searches should be started.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the folder from
        /// which searches should be started.
        /// <para />
        /// The fully-qualified pathname passed must reference a folder that currently
        /// exists on the file system; otherwise,
        /// <see cref="T:System.IO.DirectoryNotFoundException" /> is thrown.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose fully-qualified pathname is passed in the
        /// <paramref name="path" /> parameter cannot be located on the file system.
        /// </exception>
        /// <remarks>
        /// Upon successful validation of the fully-qualified folder pathname that is
        /// specified as the value of the <paramref name="path" /> parameter, assigns the
        /// value to the <see cref="P:MFR.Renamers.Files.FileRenamer.RootDirectoryPath" />
        /// property.
        /// </remarks>
        [Log(AttributeExclude = true)]
        public IFileRenamer StartingFrom(string path)
        {
            /*
             * We do not perform any input validation here.  This because
             * this value may be being initialized from a default (blank)
             * config.   the config may be blank for a number of
             * reasons, but one of these is the issue that the config
             * file on the file system may have gotten corrupted or erased.
             */

            RootDirectoryPath = path;

            return this;
        }

        /// <summary>
        /// Occurs when a Solution is about to be closed/unloaded from a running instance
        /// of Visual Studio.
        /// </summary>
        public event ClosingSolutionEventHandler ClosingSolution;

        /// <summary>
        /// Occurs when a running instance of Visual Studio has just closed/unloaded a
        /// Visual Studio Solution (<c>*.sln</c>) file.
        /// </summary>
        public event SolutionClosedEventHandler SolutionClosed;

        /// <summary>
        /// Occurs when solution folders that are to be renamed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            SolutionFoldersToBeRenamedCounted;

        /// <summary>
        /// Occurs when subfolders to be renamed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            SubfoldersToBeRenamedCounted;

        /// <summary>
        /// Enables this object to perform some or all of the operations specified.
        /// </summary>
        /// <param name="operations">
        /// </param>
        [Log(AttributeExclude = true)]
        public void EnableOperations(params OperationType[] operations)
        {
            if (!operations.Any())
                return;

            EnabledOperations = operations.ToList();
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.ExceptionRaised" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.ExceptionRaisedEventArgs" /> that contains
        /// the event data.
        /// </param>
        [Log(AttributeExclude = true)]
        public virtual void OnExceptionRaised(ExceptionRaisedEventArgs e)
        {
            ExceptionRaised?.Invoke(this, e);
            SendMessage<ExceptionRaisedEventArgs>.Having.Args(this, e)
                                                 .ForMessageId(
                                                     FileRenamerMessages
                                                         .FRM_EXCEPTION_RAISED
                                                 );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.ClosingSolution" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Renamers.Files.Events.ClosingSolutionEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// Handlers of this event can set the value of the
        /// <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property to
        /// <see langword="true" /> to stop the operation from proceeding.
        /// </remarks>
        protected virtual void OnClosingSolution(ClosingSolutionEventArgs e)
            => ClosingSolution?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Renamers.Files.FileRenamer.CurrentOperationChanged" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Renamers.Files.Events.CurrentOperationChangedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnCurrentOperationChanged(
            CurrentOperationChangedEventArgs e
        )
        {
            CurrentOperationChanged?.Invoke(this, e);
            SendMessage<CurrentOperationChangedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_CURRENT_OPERATION_CHANGED
                );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.FileRenamed" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Renamers.Files.FileRenamer.FileRenamed" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnFileRenamed(FileRenamedEventArgs e)
        {
            FileRenamed?.Invoke(this, e);
            SendMessage<FileRenamedEventArgs>.Having.Args(this, e)
                                             .ForMessageId(
                                                 FileRenamerMessages
                                                     .FRM_FILE_RENAMED
                                             );

            /*
             * custom processing.
             *
             * Sometimes, .sln files (the ones we close and then open before and after the
             * operations) are renamed by the operations.
             *
             * We check if this so.  If so, then we update the FullName property of
             * the LoadedSolutions if we find one that matches, so that when we reload the
             * solution, we open the correct file.
             */

            UpdateLoadedSolutionPaths(e);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.FolderRenamed" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FolderRenamedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnFolderRenamed(FolderRenamedEventArgs e)
        {
            FolderRenamed?.Invoke(this, e);
            SendMessage<FileRenamedEventArgs>.Having.Args(this, e)
                                             .ForMessageId(
                                                 FileRenamerMessages
                                                     .FRM_FOLDER_RENAMED
                                             );
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:MFR.Renamers.Files.FileRenamer.RootDirectoryPathChanged" /> event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.Renamers.Files.Events.RootDirectoryPathChangedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnRootDirectoryPathChanged(
            RootDirectoryPathChangedEventArgs e
        )
        {
            RootDirectoryPathChanged?.Invoke(this, e);

            // Dump the variable e.OldPath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.OnRootDirectoryPathChanged: e.OldPath = '{e.OldPath}'"
            );

            // Dump the variable e.NewPath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.OnRootDirectoryPathChanged: e.NewPath = '{e.NewPath}'"
            );

            if (CurrentConfiguration == null) return;
            if (string.IsNullOrWhiteSpace(CurrentConfiguration.StartingFolder))
                return;
            if (e == null) return;
            if (string.IsNullOrWhiteSpace(e.OldPath)) return;
            if (!e.OldPath.Equals(CurrentConfiguration.StartingFolder)) return;
            if (!Does.FolderExist(e.NewPath)) return;

            /*
             * If the root directory path's old value coincides with the
             * current setting of the StartingFolder property in the
             * Current Configuration, then update the StartingFolder property
             * of the Current Configuration to match the new value of the
             * Root Directory Path.
             *
             * NOTE: This not trivial, since we can process more than
             * one .sln in a directory tree -- this means that this renamer
             * might not necessarily be operating on the starting folder set
             * by the user in the application config.
             */
            CurrentConfiguration.StartingFolder = e.NewPath;

            LoadedSolutionProvider.SetRootDirectoryPath(e.NewPath);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.SolutionClosed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionClosedEventArgs" /> that
        /// contains the event data.
        /// </param>
        /// <remarks>
        /// The <see cref="E:MFR.Renamers.Files.FileRenamer.SolutionClosed" /> event is
        /// used to indicate that a running instance of Visual Studio has just finished
        /// closing/unloading a Visual Studio Solution (<c>*.sln</c>) file.
        /// </remarks>
        protected virtual void OnSolutionClosed(SolutionClosedEventArgs e)
            => SolutionClosed?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.SolutionCloseFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionCloseFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnSolutionCloseFailed(
            SolutionCloseFailedEventArgs e
        )
        {
            SolutionCloseFailed?.Invoke(this, e);
            SendMessage<SolutionCloseFailedEventArgs>.Having.Args(this, e)
                .ForMessageId(FileRenamerMessages.FRM_SOLUTION_CLOSE_FAILED);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.FolderRenamed" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FolderRenamedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnSolutionFolderRenamed(FolderRenamedEventArgs e)
        {
            SearchForRenamedSolution(e.Source, e.Destination);

            SolutionFolderRenamed?.Invoke(this, e);
            SendMessage<FolderRenamedEventArgs>.Having.Args(this, e)
                                               .ForMessageId(
                                                   FileRenamerMessages
                                                       .FRM_SOLUTION_FOLDER_RENAMED
                                               );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.SolutionOpenFailed" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// (Required.) A
        /// <see cref="T:MFR.Renamers.Files.Events.SolutionOpenFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnSolutionOpenFailed(
            SolutionOpenFailedEventArgs e
        )
        {
            SolutionOpenFailed?.Invoke(this, e);
            SendMessage<SolutionOpenFailedEventArgs>.Having.Args(this, e)
                                                    .ForMessageId(
                                                        FileRenamerMessages
                                                            .FRM_SOLUTION_OPEN_FAILED
                                                    );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.Starting" /> event.
        /// </summary>
        protected virtual void OnStarting()
        {
            lock (SyncRoot)
                IsBusy = true;

            Starting?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(FileRenamerMessages.FRM_STARTING);
        }

        private static void AttemptToKillProcessesLockingFolder(string pathname)
        {
            TaskKillProcess(FileRenamingBlockingProcessName.PerfWatson2);

            if (!Does.FolderExist(pathname)) return;

            var procs = List.ProcessesLockingFileSystemEntry(pathname);
            if (procs == null || !procs.Any()) return;

            try
            {
                foreach (var proc in procs)
                    try
                    {
                        proc.Kill();
                    }
                    finally
                    {
                        proc?.Dispose();
                    }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private static void TaskKillProcess(string filename)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(filename)) return;
                if (!".exe".Equals(Path.GetExtension(filename))) return;

                Run.SystemCommand($"taskkill /IM {filename} /F /T");

                Thread.Sleep(5 * 500);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private void CloseActiveSolutions()
        {
            try
            {
                if (!LoadedSolutions.Any())
                    return;

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.CloseActiveSolutions
                    )
                );

                var numFailed = 0;

                foreach (var solution in LoadedSolutions)
                {
                    if (solution == null) continue;
                    if (!Does.FileExist(solution.FullName)) continue;

                    if (CloseSolution(solution)) continue;

                    Interlocked.Increment(ref numFailed);
                    ReportSolutionCloseFailed(solution.FullName);
                }

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.CloseActiveSolutions
                    )
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }
        }

        /// <summary>
        /// Calls upon the running Visual Studio instance (if any) that currently has the
        /// specified <paramref name="solution" /> loaded, to close it.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Solution.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation was successful;
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If the specified <paramref name="solution" /> object does not contain
        /// enough information to use to close the Solution, or if the Solution isn't
        /// loaded in any of the currently-running instances of Visual Studio, then this
        /// method returns <see langword="false" />.
        /// <para />
        /// This method also returns <see langword="false" /> if the Visual Studio Solution
        /// (<c>*.sln</c>) file corresponding to the specified <paramref name="solution" />
        /// object does not exist on the user's hard disk.
        /// <para />
        /// This method raises the
        /// <see cref="E:MFR.Renamers.Files.FileRenamer.ClosingSolution" /> event before it
        /// performs the requested operation.  The specified <paramref name="solution" />
        /// is included in the event data.  The handler(s) of this event may set the value
        /// of the <see cref="P:System.ComponentModel.CancelEventArgs.Cancel" /> property
        /// to <see langword="true" /> to block this operation from proceeding, but only
        /// for the currently-specified <paramref name="solution" />.
        /// </remarks>
        private bool CloseSolution(IVisualStudioSolution solution)
        {
            var result = false;

            try
            {
                if (solution == null) return result;
                if (!Is.SolutionOpen(solution)) return result;
                if (!Does.FileExist(solution.FullName)) return result;

                var ce = new ClosingSolutionEventArgs(solution);
                OnClosingSolution(ce);
                if (ce.Cancel) return result;

                UpdateStatus(
                    $"Closing solution '{solution.FullName}'...",
                    CurrentOperation
                );

                result = solution.Unload();

                OnSolutionClosed(
                    new SolutionClosedEventArgs(solution.FullName)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        private bool CommitPendingChanges(
            [NotLogged] string rootFolderPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith
        )
        {
            var result = false;

            try
            {
                if (!Does.FolderExist(rootFolderPath))
                    return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (CurrentConfiguration.AutoStart &&
                    !CurrentConfiguration.UpdateGitOnAutoStart)
                    return
                        result; /* let the user decide if Git is updated on auto start */

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.CommitPendingChanges
                    )
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        Resources.Info_CommittingPendingChangesToGit,
                        OperationType.CommitPendingChanges
                    )
                );

                IFileSystemEntryListRetriever retriever =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.CommitPendingChanges)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (retriever == null) return result;

                // Build list of folders to be processed
                var fileSystemEntries = retriever.UsingSearchPattern(".git")
                                                 .WithSearchOption(
                                                     SearchOption.AllDirectories
                                                 )
                                                 .GetMatchingFileSystemPaths(
                                                     RootDirectoryPath
                                                 )
                                                 .ToList();

                if (!fileSystemEntries.Any() && !AbortRequested)
                {
                    /*
                     * If we are here, then no subfolders were found that match
                     * the user's search criteria, and the user has not clicked
                     * the Cancel button in the progress dialog.  Therefore,
                     * just report this operation as being finished, and then
                     * exit this method.
                     */

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.CommitPendingChanges
                        )
                    );
                    return result;
                }

                /*
                 * If, at this point, the AbortRequested property is true,
                 * then the user must have cancelled the progress dialog.
                 *
                 * Therefore, we should throw OperationAbortedException.
                 */

                if (AbortRequested)
                    throw new OperationAbortedException(
                        Resources.Error_OperationAborted
                    );

                /*
                 * Assuming that there are multiple local Git repositories in
                 * the directory tree of the root folder, count how many of them
                 * have pending changes.
                 */

                // Use a dictionary to track whether the repos have pending changes,
                // so we do not have to search for pending changes over and over again.
                var pendingChangesTracker =
                    new AdvisableDictionary<IFileSystemEntry, bool>();

                var totalPendingChanges = 0;

                TotalReposWithPendingChanges = 0;
                foreach (var entry in fileSystemEntries)
                {
                    if (entry == null) continue;
                    if (!entry.Exists) continue;

                    var hasPendingChanges = HasPendingChanges(entry);
                    pendingChangesTracker.Add(entry, hasPendingChanges);

                    if (!pendingChangesTracker[entry]) continue;

                    TotalReposWithPendingChanges++;
                    totalPendingChanges += (int)entry.UserState;
                }

                // Dump the value of the property, TotalReposWithPendingChanges, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Total repository(ies) having pending changes = {TotalReposWithPendingChanges}"
                );

                // Dump the variable totalPendingChanges to the log
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Total pending change(s) across all repository(ies) = {totalPendingChanges}"
                );

                /*
                 * If the TotalReposWithPendingChanges property is set equal to
                 * zero at this point, or is a negative number, then none of the
                 * local Git repos in the root folder, if any are there, have pending
                 * changes.
                 *
                 * Therefore, in that event, return false from this method as it makes
                 * no sense to proceed.
                 */

                if (TotalReposWithPendingChanges <= 0)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.CommitPendingChanges *** INFO: Zero local Git repo(s) in the folder '{rootFolderPath}' have pending changes; stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.CommitPendingChanges: Result = {result}"
                    );

                    return result;
                }

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        string.Format(
                            Resources
                                .Info_CommittingPendingChangesToGit_WithStats,
                            totalPendingChanges, TotalReposWithPendingChanges
                        ), CurrentOperation
                    )
                );

                /*
                 * The Pending Changes to be Committed event really is meant
                 * to report 4 x the number of local Git repos having pending
                 * changes.
                 */

                OnPendingChangesToBeCommittedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        TotalReposWithPendingChanges *
                        4, // there are 4 git operations performed per folder
                        OperationType.CommitPendingChanges
                    )
                );

                /*
                 * OKAY, this the loop over the list of the subfolders
                 * whose pathnames match the search criteria specified by
                 * the user.  For each folder, commit any pending change(s)
                 * inside of it to the local Git repository that the folder
                 * is likely to contain.
                 */

                var succeeded = true;
                foreach (var entry in fileSystemEntries)
                {
                    if (AbortRequested) break;

                    if (entry == null) continue;
                    if (!entry.Exists) continue;
                    if (!pendingChangesTracker.TryGetValue(
                            entry, out var value
                        )) continue;

                    if (!value) continue;

                    /*
                     * It's good enough for just one of the calls to
                     * commit the repository(ies) to Git succeeds.
                     */

                    succeeded |= CommitPendingChangesForEntry(
                        rootFolderPath, findWhat, replaceWith, entry
                    );
                }

                pendingChangesTracker.Clear();

                /* if we are here, then the operation succeeded -- EXCEPT
                 if the AbortRequested property is set to TRUE */
                result = succeeded && !AbortRequested;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                throw; // just bubble the exception up to the next level
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            /*
             * We do a check of the AbortRequested property's value, and
             * a subsequent throw of OperationAbortedException if the
             * property is set to true, here.
             *
             * We do this in case a different thread set the property
             * before we got here.
             */

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(
                    OperationType.CommitPendingChanges
                )
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"*** Finished processing subfolders of '{RootDirectoryPath}'.",
                    CurrentOperation, true /* operation finished */
                )
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.CommitPendingChanges: Result = {result}"
            );

            return result; /* result should be set to TRUE at this point */
        }

        private bool CommitPendingChangesForEntry(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            if (!Does.FolderExist(rootFolderPath))
                return result;
            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (entry == null || !entry.Exists || !entry.IsFolder)
                return result;
            if (!Does.FolderContainLocalGitRepo(entry.Path))
                return true; /* just silently "succeed" */
            if (AbortRequested) return false;

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitPendingChanges
                    )
                );

                ConnectToLocalGitRepoFor(entry);

                if (LocalGitInteropProvider == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Unable to connect to the local Git repository in the folder '{entry.Path}'.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.CommitPendingChangesForEntry: Result = {false}"
                    );

                    return false;
                }

                /*
                 * Here is where we actually perform the indicated operations.
                 *
                 * First, we stage all unstaged changes in the repository, and then
                 * we commit locally.  We do not do pulls or pushes or fetches because
                 * we have no clue what branch the repo is on, or even if a remote
                 * is configured.  The thinking is that the interactive user can
                 * always pull or push as needed later.
                 *
                 * We're only concerned with committing here.
                 *
                 * DO NOT commit anything if the repo has no pending changes!
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.CommitPendingChangesForEntry: Checking whether the local Git repository in '{entry.Path}' has any pending changes..."
                );

                if (!LocalGitInteropProvider.IsDirty)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"*** INFO: The repository '{entry.Path}' has zero pending changes.  Not committing anything."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.CommitPendingChangesForEntry: Result = {true}"
                    );

                    return true;
                }

                LocalGitInteropProvider.Stage();

                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitPendingChanges
                    )
                );

                LocalGitInteropProvider.Commit(
                    Formulate.CommitMessage(
                        CommitMessageMapper.Map(
                            CurrentConfiguration
                                .PendingChangesCommitMessageFormat
                        ), rootFolderPath, findWhat, replaceWith
                    ), CurrentConfiguration.CommitAuthorName,
                    CurrentConfiguration.CommitAuthorEmail,
                    Formulate.CommitMessage(
                        CommitMessageMapper.Map(
                            CurrentConfiguration
                                .PendingChangesDetailedCommitMessageFormat
                        ), rootFolderPath, findWhat, replaceWith
                    )
                );

                /*
                 * Pull from the remote branch just in case the remote had changes that
                 * need to be merged.  Assume that a remote is currently configured and that
                 * it has the label 'origin'.
                 */
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitPendingChanges
                    )
                );

                result = true; /* succeeded */
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.CommitPendingChangesForEntry: Result = {result}"
            );

            return result;
        }

        private bool CommitResultsToGit(
            [NotLogged] string rootFolderPath,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith
        )
        {
            var result = false;

            try
            {
                if (!Does.FolderExist(rootFolderPath))
                    return result;
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (CurrentConfiguration.AutoStart &&
                    !CurrentConfiguration.UpdateGitOnAutoStart)
                    return
                        result; /* let the user decide if Git is updated on auto start */

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.CommitResultsToGit
                    )
                );

                IFileSystemEntryListRetriever retriever =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.CommitResultsToGit)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (retriever == null) return result;

                // Build list of folders to be processed
                var fileSystemEntries = retriever.UsingSearchPattern(".git")
                                                 .WithSearchOption(
                                                     SearchOption.AllDirectories
                                                 )
                                                 .GetMatchingFileSystemPaths(
                                                     RootDirectoryPath
                                                 )
                                                 .ToList();

                if (!fileSystemEntries.Any() && !AbortRequested)
                {
                    /*
                     * If we are here, then no subfolders were found that match
                     * the user's search criteria, and the user has not clicked
                     * the Cancel button in the progress dialog.  Therefore,
                     * just report this operation as being finished, and then
                     * exit this method.
                     */

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.CommitResultsToGit
                        )
                    );
                    return result;
                }

                /*
                 * If, at this point, the AbortRequested property is true,
                 * then the user must have cancelled the progress dialog.
                 *
                 * Therefore, we should throw OperationAbortedException.
                 */

                if (AbortRequested)
                    throw new OperationAbortedException(
                        Resources.Error_OperationAborted
                    );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        Resources.Info_CommittingResultsToGit, CurrentOperation
                    )
                );

                /*
                 * Let's not just ASSUME that more than zero changes were
                 * made when the operations were processed -- CHECK.
                 */

                /*
                 * Assuming that there are multiple local Git repositories in
                 * the directory tree of the root folder, count how many of them
                 * have pending changes.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.CommitResultsToGit: Counting pending changes..."
                );

                // Use a dictionary to track whether the repos have pending changes,
                // so we do not have to search for pending changes over and over again.
                var pendingChangesTracker =
                    new AdvisableDictionary<IFileSystemEntry, bool>();

                var totalPendingChanges = 0;

                TotalReposWithPendingChanges = 0;
                foreach (var entry in fileSystemEntries)
                {
                    if (entry == null) continue;
                    if (!entry.Exists) continue;

                    pendingChangesTracker.Add(entry, HasPendingChanges(entry));

                    if (!pendingChangesTracker[entry]) continue;

                    TotalReposWithPendingChanges++;
                    totalPendingChanges += (int)entry.UserState;
                }

                // Dump the value of the property, TotalReposWithPendingChanges, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Total repository(ies) having pending changes = {TotalReposWithPendingChanges}"
                );

                // Dump the variable totalPendingChanges to the log
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"Total pending change(s) across all repository(ies) = {totalPendingChanges}"
                );

                /*
                 * If the TotalReposWithPendingChanges property is set equal to
                 * zero at this point, or is a negative number, then none of the
                 * local Git repos in the root folder, if any are there, have pending
                 * changes.
                 *
                 * Therefore, in that event, return false from this method as it makes
                 * no sense to proceed.
                 */

                if (TotalReposWithPendingChanges <= 0)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.CommitPendingChanges *** INFO: Zero local Git repo(s) in the folder '{rootFolderPath}' have pending changes; stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.CommitPendingChanges: Result = {result}"
                    );

                    return result;
                }

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        string.Format(
                            Resources.Info_CommittingResultsToGit_WithStats,
                            totalPendingChanges, TotalReposWithPendingChanges
                        ), CurrentOperation
                    )
                );

                OnSubfoldersToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        fileSystemEntries.Count * 3,
                        OperationType.CommitResultsToGit
                    )
                );

                /*
                 * OKAY, this the loop over the list of the subfolders
                 * whose pathnames match the search criteria specified by
                 * the user.  For each folder, commit any pending change(s)
                 * that may have resulted of the file-rename operation(s)
                 * requested by the user inside of it to the corresponding
                 * local Git repository that the folder is likely to contain.
                 */

                var succeeded = true;
                foreach (var entry in fileSystemEntries)
                {
                    if (AbortRequested) break;

                    if (entry == null) continue;
                    if (!entry.Exists) continue;
                    if (!pendingChangesTracker.TryGetValue(
                            entry, out var value
                        )) continue;

                    if (!value) continue;

                    /*
                     * It's good enough for just one of the calls to
                     * commit the repository(ies) to Git succeed.
                     */

                    succeeded |= CommitResultsToGitForEntry(
                        rootFolderPath, findWhat, replaceWith, entry
                    );
                }

                pendingChangesTracker.Clear(); // free up memory

                result = succeeded;

                /*
                 * Do a push to the remote branch.  Only do this if a remote called 'origin' is
                 * configured.  Not all local Git repos have remotes, and not all of those remotes
                 * have to be called 'origin'.
                 *
                 * NOTE: There is a new config property, PushChangesToRemoteWhenDone.
                 * The value of this property is changeable at runtime by the user via the Git
                 * tab on the Options dialog box.  Setting the property to false should suppress
                 * this operation.
                 *
                 * We added this option since, as of 2.42.0, git for windows' ability to push has
                 * vastly increased in the amount of time taken to do a push --- at least, on a
                 * subjective basis.  Allowing the user to turn pushing off may save the user time,
                 * especially when the user is working on a very large software system.
                 */

                if (succeeded && LocalGitInteropProvider.HasRemoteOrigin &&
                    LocalGitInteropProvider.HasCurrentBranch &&
                    CurrentConfiguration.PushChangesToRemoteWhenDone)
                {
                    OnStatusUpdate(
                        new StatusUpdateEventArgs(
                            "Pushing changes to the remote...", CurrentOperation
                        )
                    );

                    LocalGitInteropProvider.Push();
                }

                /* if we are here, then the operation succeeded -- EXCEPT if the AbortRequested property is set to TRUE */
                result &= !AbortRequested;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                throw; // just bubble the exception up to the next level
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            /*
             * We do a check of the AbortRequested property's value, and
             * a subsequent throw of OperationAbortedException if the
             * property is set to true, here.
             *
             * We do this in case a different thread set the property
             * before we got here.
             */

            if (AbortRequested)
                throw new OperationAbortedException(
                    Resources.Error_OperationAborted
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(OperationType.CommitResultsToGit)
            );

            OnStatusUpdate(
                new StatusUpdateEventArgs(
                    $"*** Finished processing subfolders of '{RootDirectoryPath}'.",
                    CurrentOperation, true /* operation finished */
                )
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.CommitResultsToGit: Result = {result}"
            );

            return result; /* result should be set to TRUE at this point */
        }

        private bool CommitResultsToGitForEntry(
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            if (!Does.FolderExist(rootFolderPath))
                return result;
            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (entry == null || !entry.Exists || !entry.IsFolder)
                return result;
            if (!Does.FolderContainLocalGitRepo(entry.Path))
                return true; /* just silently "succeed" */
            if (AbortRequested) return false;

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitResultsToGit
                    )
                );

                /*
                 * Here is where we actually perform the indicated operations.
                 *
                 * First, we stage all unstaged changes in the repository, and then
                 * we commit locally.  We do not do pulls or pushes or fetches because
                 * we have no clue what branch the repo is on, or even if a remote
                 * is configured.  The thinking is that the interactive user can
                 * always pull or push as needed later.
                 *
                 * We're only concerned with committing here.
                 */

                ConnectToLocalGitRepoFor(entry);

                LocalGitInteropProvider.Stage();

                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitResultsToGit
                    )
                );

                LocalGitInteropProvider.Commit(
                    Formulate.CommitMessage(
                        CommitMessageMapper.Map(
                            CurrentConfiguration
                                .PostOperationCommitMessageFormat
                        ), rootFolderPath, findWhat, replaceWith
                    ), CurrentConfiguration.CommitAuthorName,
                    CurrentConfiguration.CommitAuthorEmail,
                    Formulate.CommitMessage(
                        CommitMessageMapper.Map(
                            CurrentConfiguration
                                .PostOperationDetailedCommitMessageFormat
                        ), rootFolderPath, findWhat, replaceWith
                    )
                );

                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.CommitResultsToGit
                    )
                );

                /*
                 * If we are here, then the operation succeeded.  Make sure we
                 * return TRUE.
                 */

                result = true;
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.CommitResultsToGitForEntry: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Called to determine whether the <c>Local Git Interop Provider</c> object has
        /// already been initialized for the current <paramref name="entry" />, or if a new
        /// instance needs to be initialized for the specified <paramref name="entry" />.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface that
        /// represents a folder containing the local Git repository with which to
        /// interoperate.
        /// </param>
        /// <remarks>
        /// This method does nothing if a <see langword="null" /> reference is
        /// passed for the argument of the <paramref name="entry" /> parameter, the
        /// <paramref name="entry" /> represents a file, or if the
        /// <paramref name="entry" /> does not refer to a folder that exists in the file
        /// system.
        /// <para />
        /// This method also does nothing if the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.LocalGitInteropProvider" />
        /// property already refers to a <c>Local Git Interop Provider</c> that is focused
        /// on the specified <paramref name="entry" />, except that it does re-scan that
        /// repository for changes.
        /// </remarks>
        private void ConnectToLocalGitRepoFor(IFileSystemEntry entry)
        {
            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ConnectToLocalGitRepoFor: Checking whether the 'entry' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, entry, is null. If it is, send an
                // error to the log file and quit, returning from this method.
                if (entry == null)
                {
                    // the parameter entry is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FileRenamer.ConnectToLocalGitRepoFor: *** ERROR *** A null reference was passed for the 'entry' method parameter.  Stopping."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ConnectToLocalGitRepoFor: *** SUCCESS *** We have been passed a valid object reference for the 'entry' method parameter."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** FileRenamer.ConnectToLocalGitRepoFor: Checking whether the 'entry.Exists' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, entry.Exists, evaluates to TRUE.  If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!entry.Exists)
                {
                    // the Boolean expression, entry.Exists, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: The Boolean expression, 'entry.Exists', evaluated to FALSE.  Stopping."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ConnectToLocalGitRepoFor: *** SUCCESS *** The Boolean expression, 'entry.Exists', evaluated to TRUE.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.ConnectToLocalGitRepoFor: Attempting to connect to the local Git repository in the folder '{entry.Path}'..."
                );

                /*
                 * ASSUME that the specified File System Entry represents
                 * a folder on the file system that contains a local Git
                 * repository.  We must check those conditions prior to calling
                 * this method.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.ConnectToLocalGitRepoFor: Checking whether we're already connected to the local Git repository in the folder '{entry.Path}'..."
                );

                if (IsRepositoryConnected(entry.Path))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.ConnectToLocalGitRepoFor: *** SUCCESS *** We're connected to the local Git repository in the folder '{entry.Path}'."
                    );

                    LocalGitInteropProvider.ScanForRepoChanges();

                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.ConnectToLocalGitRepoFor: We're not yet connected to the local Git repository in the folder '{entry.Path}'.  Connecting to it..."
                );

                LocalGitInteropProvider =
                    MakeNewLocalGitInteropProvider
                        .ForLocalGitFolder(entry.Path);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.ConnectToLocalGitRepoFor: *** SUCCESS *** CONNECTED to the local Git repository in the folder '{entry.Path}'."
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Provides the rename-processing services for just one out of potentially several
        /// root directories.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// (Required.) FullName to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="rootDirectoryPath" />
        /// , is passed a blank or
        /// <see
        ///     langword="null" />
        /// string for a value.
        /// </exception>
        private void DoProcessAll(
            string rootDirectoryPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter
        )
        {
            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootDirectoryPath)
                );

            try
            {
                OnStarting(); // before we even check the root directory path

                /*
                 * Set the RootDirectoryPath property to the
                 * value that is passed in.
                 */

                RootDirectoryPath = rootDirectoryPath;

                if (!RootDirectoryPathValidator.Validate(rootDirectoryPath))
                    return;

                OnStarted();

                if (!SearchForLoadedSolutions())
                    return;

                CloseActiveSolutions();

                if (!InvokeProcessing(findWhat, replaceWith, pathFilter))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The InvokeProcessing method returned FALSE."
                    );

                    ReopenActiveSolutions();

                    OnFinished();

                    return;
                }

                ReopenActiveSolutions();
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
            finally
            {
                OnFinished();
            }
        }

        private string GetReplacementFileName(
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (string.IsNullOrWhiteSpace(replaceWith)) return result;
            if (entry == null || string.IsNullOrWhiteSpace(entry.Path) ||
                !Does.FileExist(entry.Path)) return result;
            if (AbortRequested) return result;

            try
            {
                result = GetTextReplacementEngine.For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     CurrentConfiguration
                                                 )
                                                 .Replace(
                                                     GetMatchExpressionFactory
                                                         .For(
                                                             OperationType
                                                                 .RenameFilesInFolder
                                                         )
                                                         .AndAttachConfiguration(
                                                             CurrentConfiguration
                                                         )
                                                         .ForTextValue(
                                                             GetTextValueRetriever
                                                                 .For(
                                                                     OperationType
                                                                         .RenameFilesInFolder
                                                                 )
                                                                 .GetTextValue(
                                                                     entry
                                                                 )
                                                         )
                                                         .ToFindWhat(findWhat)
                                                         .AndReplaceItWith(
                                                             replaceWith
                                                         )
                                                 );
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                result = string.Empty;

                throw;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.GetReplacementFileName: Result = '{result}'"
            );

            return result;
        }

        [return: NotLogged]
        private string GetTextInFileReplacementData(
            [NotLogged] IFileSystemEntry entry,
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith
        )
        {
            var result = string.Empty;

            try
            {
                if (entry == null) return result;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.GetTextInFileReplacementData: Attempting to get the replace-text-in-file data for file '{entry.Path}'..."
                );

                if (string.IsNullOrWhiteSpace(entry.Path))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': The pathname is blank."
                    );

                    return result;
                }

                if (!Does.FileSystemEntryExist(entry.Path))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': The file was not found on the file system."
                    );

                    return result;
                }

                if (string.IsNullOrWhiteSpace(findWhat))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': The 'Find What' value is blank."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.GetTextInFileReplacementData: Getting access to the replace-text-in-file engine..."
                );

                ITextReplacementEngine engine = GetTextReplacementEngine
                                                .For(
                                                    OperationType
                                                        .ReplaceTextInFiles
                                                )
                                                .AndAttachConfiguration(
                                                    CurrentConfiguration
                                                );
                if (engine == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': Could not initialize the text-replacement engine."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.GetTextInFileReplacementData: Attempting to get the match expression factory..."
                );

                IMatchExpressionFactory matchExpressionFactory =
                    GetMatchExpressionFactory
                        .For(OperationType.ReplaceTextInFiles)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (matchExpressionFactory == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': Could not initialize the match-expression factory."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.GetTextInFileReplacementData: Attempting to read the text to be searched from the file, '{entry.Path}'..."
                );

                var textToBeSearched = GetTextValueRetriever.For(
                        OperationType.ReplaceTextInFiles
                    )
                    .GetTextValue(entry);
                if (string.IsNullOrWhiteSpace(textToBeSearched))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': No text was retrieved from the file."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.GetTextInFileReplacementData: *** SUCCESS *** {textToBeSearched.Length} B of data were retrieved from the file, '{entry.Path}' to be searched."
                );

                /*
                 * NOTE: We ASSUME that the ITextValueRetriever.GetTextValueAsync
                 * method called above for the Replace Text in Files operation
                 * also called IFileHostProvider.DisposeObject on the
                 * file stream after it obtained the text to be searched.
                 *
                 * Search for control characters to determine whether the
                 * text to be searched is from a binary file or an ASCII
                 * one.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.GetTextInFileReplacementData: Scanning the data retrieved from the file, '{entry.Path}', for control characters..."
                );

                if (Scan.FileDataForBinaryControlCharacters(textToBeSearched))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** ASCII control characters were found in the file, '{entry.Path}'.  Marking it as a file to be skipped..."
                    );

                    return SpecializedFileData.BinaryFileSkipped;
                }

                /*
                 * If we are still here, then the textToBeSearched is really
                 * from an ASCII text file.  We can proceed with the Replace
                 * Text in Files operation on this file.
                 *
                 * The whole point of doing the scan above is to weed out files
                 * that somehow made it past our initial set of filters, but
                 * who obviously should not have text replacement done in them
                 * because they are images, videos, or other media, or because they
                 * are dll and exe files and/or other types of compiler and/or linker
                 * output.
                 *
                 * We are primarily focused on performing text replacement in
                 * project files, config files, solution files, and source
                 * code files here.
                 *
                 * This weeding out process makes the application more scalable.
                 */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.GetTextInFileReplacementData: Attempting to get a match expression for the file, '{entry.Path}'..."
                );

                IMatchExpression expression = matchExpressionFactory
                                              .ForTextValue(textToBeSearched)
                                              .AndAttachConfiguration(
                                                  CurrentConfiguration
                                              )
                                              .ToFindWhat(findWhat)
                                              .AndReplaceItWith(replaceWith);
                if (expression == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': Could not obtain a match expression object for it."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.GetTextInFileReplacementData: Attempting to replace the text to be searched with the replacement value(s)..."
                );

                result = engine.Replace(expression);

                /*
                 * OKAY, if the text to be searched and the result of the "replacement"
                 * operation are identical, then nothing was actually replaced in the
                 * file, and we should instead return the specialized GUID indicating so --
                 * this way, the file will be skipped and not overwritten, but also
                 * a Boolean true value will be returned so as to not indicate an error
                 * occurred.
                 */

                if (textToBeSearched.Equals(result))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Can't get the text-replace data for file '{entry.Path}': No data was replaced."
                    );

                    result = SpecializedFileData.NoChange;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            DebugUtils.WriteLine(
                !string.IsNullOrWhiteSpace(result) &&
                !SpecializedFileData.BinaryFileSkipped.Equals(result) &&
                !SpecializedFileData.NoChange.Equals(result)
                    ? DebugLevel.Info
                    : DebugLevel.Error,
                !string.IsNullOrWhiteSpace(result)
                    ? $"*** SUCCESS *** {result.Length} B of replacement data were obtained.  Proceeding..."
                    : "*** ERROR *** Zero bytes of replacement data were obtained.  Stopping..."
            );

            return result;
        }

        /// <summary>
        /// Determines if there are any pending Git changes in the repository having the
        /// home folder corresponding to the file-system <paramref name="entry" />
        /// specified.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:MFR.FileSystem.Interfaces.IFileSystemEntry" /> interface.
        /// <para />
        /// This object must correspond to a folder that contains a Git repository.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the local Git repository contained by the
        /// folder corresponding to the specified file-system <paramref name="entry" /> has
        /// greater than zero pending changes; <see langword="false" /> otherwise.
        /// </returns>
        private bool HasPendingChanges(IFileSystemEntry entry)
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'entry' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, entry, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (entry == null)
                {
                    // the parameter entry is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FileRenamer.HasPendingChanges: *** ERROR *** A null reference was passed for the 'entry' method parameter.  Stopping."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** We have been passed a valid object reference for the 'entry' method parameter."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.HasPendingChanges: Checking whether the local Git repository in the folder '{entry.Path}' has pending changes..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'entry.Exists' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, entry.Exists, evaluates to TRUE.
                // If it does not, log an error message to the log file and then terminate the
                // execution of this method.
                if (!entry.Exists)
                {
                    // the Boolean expression, entry.Exists, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Boolean expression, 'entry.Exists', evaluated to FALSE.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.HasPendingChanges: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** The Boolean expression, 'entry.Exists', evaluated to TRUE.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.HasPendingChanges: Detecting whether the Git repository(ies) in '{entry.Path}' have any pending changes..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** INFO: Checking whether the local Git interop provider object has been initialized..."
                );

                if (LocalGitInteropProvider == null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.HasPendingChanges: Initializing the local Git interop provider object for the folder '{entry.Path}'..."
                    );

                    LocalGitInteropProvider =
                        MakeNewLocalGitInteropProvider.ForLocalGitFolder(
                            entry.Path
                        );
                }
                else if (!entry.Path.Equals(
                             LocalGitInteropProvider.RepositoryFolder
                         ))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.HasPendingChanges: Resetting the local Git interop provider to point at the folder '{entry.Path}'..."
                    );

                    LocalGitInteropProvider.SetRepositoryFolder(entry.Path);
                }

                // Dump the value of the property, LocalGitInteropProvider.HasCurrentBranch, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.HasCurrentBranch = {LocalGitInteropProvider.HasCurrentBranch}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'LocalGitInteropProvider.HasCurrentBranch' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, LocalGitInteropProvider.HasCurrentBranch, evaluates to TRUE.
                // If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!LocalGitInteropProvider.HasCurrentBranch)
                {
                    // the Boolean expression, LocalGitInteropProvider.HasCurrentBranch, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Boolean expression, 'LocalGitInteropProvider.HasCurrentBranch', evaluated to FALSE.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.HasPendingChanges: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** The Boolean expression, 'LocalGitInteropProvider.HasCurrentBranch', evaluated to TRUE.  Proceeding..."
                );

                // Dump the value of the property, LocalGitInteropProvider.HasRemoteOrigin, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.HasRemoteOrigin = {LocalGitInteropProvider.HasRemoteOrigin}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'LocalGitInteropProvider.HasRemoteOrigin' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, LocalGitInteropProvider.HasRemoteOrigin, evaluates to TRUE.
                // If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!LocalGitInteropProvider.HasRemoteOrigin)
                {
                    // the Boolean expression, LocalGitInteropProvider.HasRemoteOrigin, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Boolean expression, 'LocalGitInteropProvider.HasRemoteOrigin', evaluated to FALSE.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.HasPendingChanges: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** The Boolean expression, 'LocalGitInteropProvider.HasRemoteOrigin', evaluated to TRUE.  Proceeding..."
                );

                // Dump the value of the property, LocalGitInteropProvider.HasRemotes, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.HasRemotes = {LocalGitInteropProvider.HasRemotes}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'LocalGitInteropProvider.HasRemotes' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, LocalGitInteropProvider.HasRemotes, evaluates to TRUE.
                // If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!LocalGitInteropProvider.HasRemotes)
                {
                    // the Boolean expression, LocalGitInteropProvider.HasRemotes, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Boolean expression, 'LocalGitInteropProvider.HasRemotes', evaluated to FALSE.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.HasPendingChanges: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** The Boolean expression, 'LocalGitInteropProvider.HasRemotes', evaluated to TRUE.  Proceeding..."
                );

                // Dump the value of the property, LocalGitInteropProvider.IsRepositoryOpen, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.IsRepositoryOpen = {LocalGitInteropProvider.IsRepositoryOpen}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: Checking whether the 'LocalGitInteropProvider.IsRepositoryOpen' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, LocalGitInteropProvider.IsRepositoryOpen, evaluates to TRUE.
                // If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!LocalGitInteropProvider.IsRepositoryOpen)
                {
                    // the Boolean expression, LocalGitInteropProvider.IsRepositoryOpen, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The Boolean expression, 'LocalGitInteropProvider.IsRepositoryOpen', evaluated to FALSE.  Stopping."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.HasPendingChanges: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.HasPendingChanges: *** SUCCESS *** The Boolean expression, 'LocalGitInteropProvider.IsRepositoryOpen', evaluated to TRUE.  Proceeding..."
                );

                // Dump the value of the property, LocalGitInteropProvider.IsDirty, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.IsDirty = {LocalGitInteropProvider.IsDirty}"
                );

                result = LocalGitInteropProvider.IsDirty;

                // Dump the value of the property, LocalGitInteropProvider.PendingChangesCount, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.HasPendingChanges: LocalGitInteropProvider.PendingChangesCount = {LocalGitInteropProvider.PendingChangesCount}"
                );

                // tag the file-system entry's UserState with the count of pending
                // changes
                entry.UserState = LocalGitInteropProvider.PendingChangesCount;

                if (result)
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.HasPendingChanges: *** SUCCESS *** {LocalGitInteropProvider.PendingChangesCount} pending change(s) found in repository '{LocalGitInteropProvider.RepositoryFolder}'."
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.HasPendingChanges: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Invokes the core processing of this file-renamer object.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file
        /// should be included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method
        /// should return <see langword="true" /> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path
        /// filtering is done.
        /// </param>
        private bool InvokeProcessing(
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter
        )
        {
            var result = false;

            try
            {
                /*
                 * OKAY, check whether Find What and Replace With are the same,
                 * apart from case.  This means that the user wants to use the same
                 * name for a component(s), but with different letters capitalized.
                 * If this is so, then we cannot have two files and/or
                 * folders in the same parent folder with both names (per operating
                 * system rules).  So in that event, we will need to do findWhat = old
                 * name, replaceWith = guid, and then another process with findWhat = guid
                 * and replaceWith = destination.
                 */

                if (!findWhat.EqualsNoCase(replaceWith))
                    result = ProcessAll(findWhat, replaceWith, pathFilter);
                else
                {
                    var guid = Guid.NewGuid()
                                   .ToString("N");

                    result = ProcessAll(findWhat, guid, pathFilter) &&
                             ProcessAll(guid, replaceWith, pathFilter);
                }
            }
            catch (OperationAbortedException ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                //Ignored.
                result = true;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.InvokeProcessing: Result = {result}"
            );

            return result;
        }

        private bool IsRepositoryConnected(string folder)
        {
            var result = false;

            try
            {
                // Dump the parameter folder to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.IsRepositoryConnected: folder = '{folder}'"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected *** INFO: Checking whether the folder with path '{folder}' exists on the file system..."
                );

                if (!Does.FolderExist(folder))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"FileRenamer.IsRepositoryConnected: *** ERROR *** The system could not locate the folder having the path '{folder}' on the file system.  This folder is required to exist in order for us to proceed."
                    );

                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected: *** SUCCESS *** The folder with path '{folder}' was found on the file system.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.IsRepositoryConnected: Checking whether the 'LocalGitInteropProvider' property has a null reference for a value..."
                );

                // Check to see if the required property, LocalGitInteropProvider, is null. If it is, send an
                // error to the log file and quit, returning the default value of the result
                // variable.
                if (LocalGitInteropProvider == null)
                {
                    // the property LocalGitInteropProvider is required.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FileRenamer.IsRepositoryConnected: *** ERROR *** The 'LocalGitInteropProvider' property has a null reference.  Stopping."
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.IsRepositoryConnected: *** SUCCESS *** The 'LocalGitInteropProvider' property has a valid object reference for its value."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected: Checking whether the local Git interop provider object is already pointed at the folder '{folder}'..."
                );

                // Check to see whether the Boolean expression, folder.Equals(LocalGitInteropProvider.RepositoryFolder), evaluates to TRUE.  If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!folder.Equals(LocalGitInteropProvider.RepositoryFolder))
                {
                    // the Boolean expression, folder.Equals(LocalGitInteropProvider.RepositoryFolder), evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The local Git interop provider object isn't pointed at the folder '{folder}'.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.IsRepositoryConnected: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected: *** SUCCESS *** The local Git interop provider object is already pointed at the folder '{folder}'."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected: Checking whether the local Git repository in the folder '{folder}' already has a branch checked out..."
                );

                // Check to see whether the Boolean expression, LocalGitInteropProvider.HasCurrentBranch, evaluates to TRUE.  If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!LocalGitInteropProvider.HasCurrentBranch)
                {
                    // the Boolean expression, LocalGitInteropProvider.HasCurrentBranch, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** The local Git repository in the folder '{folder}' is not currently on a branch."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.IsRepositoryConnected: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.IsRepositoryConnected: *** SUCCESS *** The local Git repository in the folder '{folder}' is on a branch."
                );

                result = true; /* connected */
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.IsRepositoryConnected: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.FilesToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnFilesToBeRenamedCounted(FilesOrFoldersCountedEventArgs e)
        {
            FilesToBeRenamedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_FILES_TO_BE_RENAMED_COUNTED
                );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.FilesToHaveTextReplacedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnFilesToHaveTextReplacedCounted(
            FilesOrFoldersCountedEventArgs e
        )
        {
            FilesToHaveTextReplacedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_FILES_TO_HAVE_TEXT_REPLACED_COUNTED
                );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.Finished" />
        /// event.
        /// </summary>
        private void OnFinished()
        {
            IsBusy = false;
            IsStarted = false;

            /*
             * If the user has requested that we rename the Solution's
             * folder, here is the time to do it.
             */

            Finished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.NoArgs()
                       .ForMessageId(FileRenamerMessages.FRM_FINISHED);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.OperationFinished" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:MFR.Operations.Events.OperationFinishedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnOperationFinished(OperationFinishedEventArgs e)
        {
            CurrentOperation = e.OperationType;

            OperationFinished?.Invoke(this, e);
            SendMessage<OperationFinishedEventArgs>.Having.Args(this, e)
                                                   .ForMessageId(
                                                       FileRenamerMessages
                                                           .FRM_OPERATION_FINISHED
                                                   );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.OperationStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Operations.Events.OperationStartedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnOperationStarted(OperationStartedEventArgs e)
        {
            CurrentOperation = e.OperationType;

            OperationStarted?.Invoke(this, e);
            SendMessage<OperationStartedEventArgs>.Having.Args(this, e)
                                                  .ForMessageId(
                                                      FileRenamerMessages
                                                          .FRM_OPERATION_STARTED
                                                  );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.PendingChangesToBeCommittedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnPendingChangesToBeCommittedCounted(
            FilesOrFoldersCountedEventArgs e
        )
        {
            PendingChangesToBeCommittedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages
                        .FRM_PENDING_CHANGES_TO_BE_COMMITTED_COUNTED
                );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.ProcessingOperation" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.ProcessingOperationEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnProcessingOperation(ProcessingOperationEventArgs e)
        {
            ProcessingOperation?.Invoke(this, e);
            SendMessage<ProcessingOperationEventArgs>.Having.Args(this, e)
                .ForMessageId(FileRenamerMessages.FRM_PROCESSING_OPERATION);
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.ResultsToBeCommittedToGitCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnResultsToBeCommittedToGitCounted(
            FilesOrFoldersCountedEventArgs e
        )
        {
            ResultsToBeCommittedToGitCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages
                        .FRM_RESULTS_TO_BE_COMMITTED_TO_GIT_COUNTED
                );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.SolutionFoldersToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnSolutionFoldersToBeRenamedCounted(
            FilesOrFoldersCountedEventArgs e
        )
        {
            SolutionFoldersToBeRenamedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages
                        .FRM_SOLUTION_FOLDERS_TO_BE_RENAMED_COUNTED
                );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.Started" />
        /// event.
        /// </summary>
        private void OnStarted()
        {
            lock (SyncRoot)
                IsStarted = true;

            Started?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(FileRenamerMessages.FRM_STARTED);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.StatusUpdate" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.StatusUpdateEventArgs" /> that contains
        /// the event data.
        /// </param>
        [Log(AttributeExclude = true)]
        private void OnStatusUpdate(StatusUpdateEventArgs e)
        {
            StatusUpdate?.Invoke(this, e);
            SendMessage<StatusUpdateEventArgs>.Having.Args(this, e)
                                              .ForMessageId(
                                                  FileRenamerMessages
                                                      .FRM_STATUS_UPDATE
                                              );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.SubfoldersToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Events.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnSubfoldersToBeRenamedCounted(
            FilesOrFoldersCountedEventArgs e
        )
        {
            SubfoldersToBeRenamedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED
                );
        }

        /// <summary>
        /// Renames a file for the specified file system <paramref name="entry" />.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the data for which to search in the name of the target file of the specified
        /// <paramref name="entry" />.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the data to replace the found search text with in the name of the
        /// target file of the specified <paramref name="entry" />.
        /// </param>
        /// <param name="entry"></param>
        /// <returns></returns>
        [Log(AttributeExclude = true)]
        private bool RenameFileInFolderForEntry(
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            /* validate inputs */

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileRenamer.RenameFileInFolderForEntry: Validating inputs..."
            );

            // Dump the variable findWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: findWhat = '{findWhat}'"
            );

            // Dump the variable replaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: replaceWith = '{replaceWith}'"
            );

            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (string.IsNullOrWhiteSpace(replaceWith)) return result;
            if (entry == null || string.IsNullOrWhiteSpace(entry.Path) ||
                !Does.FileExist(entry.Path)) return result;

            // Dump the variable entry.FullName to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: entry.FullName = '{entry.Path}'"
            );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "FileRenamer.RenameFileInFolderForEntry: Checking the value of the AbortRequested property...  If it is set to true, we'll stop and return false."
            );

            // Dump the variable AbortRequested to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: AbortRequested = {AbortRequested}"
            );

            if (AbortRequested) return false;

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.RenameFilesInFolder
                    )
                );

                var source = entry.Path;
                if (string.IsNullOrWhiteSpace(source)) return result;
                if (!Does.FileExist(source)) return result;

                /*
                 * OKAY, the code below is going to actually figure
                 * out the new name of the file.  Not the entire new
                 * PATH to the file...just the new NAME for the FILE
                 * ITSELF.
                 *
                 * Since the FileInfoExtensions.RenameTo() method must
                 * be passed the destination file as a fully-qualified,
                 * absolute pathname, we do the combination with the
                 * ContainingFolder property of the current
                 * FileSystemEntry we are processing.  (The Containing
                 * Folder property is filled during its construction.)
                 *
                 * This done because we are operating under the assumption
                 * that the file to be renamed should be left in the same
                 * folder that we found it in.
                 */

                var newFileName = GetReplacementFileName(
                    findWhat, replaceWith, entry
                );

                var destination = Path.Combine(
                    entry.ContainingFolder, newFileName
                );

                if (entry.ToFileInfo()
                         .RenameTo(destination))
                    /*
                     * Raise an event to let other parts of the application
                     * know that a file has been renamed successfully.
                     *
                     * The RenameTo method above returns true if the rename
                     * operation succeeded.
                     */
                {
                    result = true; /* succeeded */
                    OnFileRenamed(
                        new FileRenamedEventArgs(source, destination)
                    );
                }
            }
            catch (OperationAbortedException)
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    "*** ERROR *** OperationAbortedException caught.  Setting AbortRequested to true."
                );

                AbortRequested = true;
                return false;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                return true; /* okay, an exception was caught, but
                              * we want to barrel through the remainder
                              * of the operation, so we can process any other
                              * files that may need to be operated on.
                              * So, we return true here.*/
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: Result = {result}"
            );

            return result;
        }

        private bool RenameSolutionFolderForEntry(
            [NotLogged] string findWhat,
            [NotLogged] string replaceWith,
            [NotLogged] IFileSystemEntry entry
        )
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (string.IsNullOrWhiteSpace(replaceWith))
                return result;
            if (entry == null || !Directory.Exists(entry.Path))
                return result;
            if (AbortRequested) return result;

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.RenameSolutionFolders
                    )
                );

                var destination =
                    string.Empty; // new name for the solution folder

                /*
                 * This the thing that actually does the replacement.
                 */

                ITextReplacementEngine engine = GetTextReplacementEngine
                                                .For(
                                                    OperationType
                                                        .RenameSolutionFolders
                                                )
                                                .AndAttachConfiguration(
                                                    CurrentConfiguration
                                                );
                if (engine == null) return result;

                /*
                 * This combines the value to be replaced, with the search pattern in
                 * the findWhat parameter, and the replaceWith parameter's text-replacement
                 * parameter into a neat little package that can be then handed off
                 * to the text-replacement engine object.
                 */

                IMatchExpressionFactory matchExpressionFactory =
                    GetMatchExpressionFactory.For(
                                                 OperationType
                                                     .RenameSolutionFolders
                                             )
                                             .AndAttachConfiguration(
                                                 CurrentConfiguration
                                             );
                if (matchExpressionFactory == null) return result;

                /*
                 * The text retriever object actually scans the folder pathname
                 * and determines what text is to be targeted for the find-and-
                 * replace operation.
                 */

                var retriever = GetTextValueRetriever.For(
                    OperationType.RenameSolutionFolders
                );
                if (retriever == null) return result;

                /*
                 * Obtain the textual data to be targeted for the find-and-
                 * replace operation.
                 */

                var source =
                    retriever.GetTextValue(
                        entry
                    ); // target of the find-and-replace
                if (string.IsNullOrWhiteSpace(source))
                    return result;
                if (!Directory.Exists(source)) return result;

                /*
                 * OKAY, now we use the MatchExpressionFactory object to
                 * create a match expression object for our text-replacement
                 * task.
                 *
                 * NOTE: We need a match expression factory that selects a
                 * different means of creating match expressions depending on
                 * the type of operation.
                 */

                var expression = matchExpressionFactory.ForTextValue(source)
                    .ToFindWhat(findWhat)
                    .AndReplaceItWith(replaceWith);
                if (expression == null) return result;

                /*
                 * Actually carry out the find-and-replace operation and
                 * produce the new pathname (if any) of the Visual Studio
                 * Solution (<c>*.sln</c>) folder.
                 */

                destination = engine.Replace(expression);
                if (string.IsNullOrWhiteSpace(destination))
                    return result;
                if (destination.Equals(
                        source, StringComparison.OrdinalIgnoreCase
                    ))
                    return
                        result; // no change, so do not proceed with the Rename operation

                /*
                 * Actually perform the directory move operation.
                 *
                 * We avoid using a DirectoryInfo object here, since
                 * it could open handles on the folder that we wish to
                 * work on.
                 *
                 * We just try over and over again to rename the directory
                 * until it works.
                 */

                if (!Does.FolderExist(source)) return result;

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Waiting for the Solution folder '{source}' to become available for renaming...",
                        OperationType.RenameSolutionFolders
                    )
                );

                Wait.ForFolderToBecomeWriteable(source);

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Attempting to rename Solution folder '{source}' -> '{destination}'...",
                        OperationType.RenameSolutionFolders
                    )
                );

                do

                    // ReSharper disable once RemoveRedundantBraces
                {
                    try
                    {
                        Directory.Move(source, destination);
                    }
                    catch
                    {
                        //Ignored.
                    }
                    finally
                    {
                        Thread.Sleep(500);
                    }
                } while (Directory.Exists(source));

                result = Does.FolderExist(destination);

                /*
                 * OKAY, if we get here, then we ASSUME that the folder-rename
                 * operation took place.
                 */

                if (result)
                    OnSolutionFolderRenamed(
                        new FolderRenamedEventArgs(source, destination)
                    );
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameSolutionFolderForEntry: Result = {result}"
            );

            return result;
        }

        [Log(AttributeExclude = true)]
        private bool RenameSubFolderForEntry(
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            // Dump the variable findWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFolderForEntry: findWhat = '{findWhat}'"
            );

            // Dump the variable replaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFolderForEntry: replaceWith = '{replaceWith}'"
            );

            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (string.IsNullOrWhiteSpace(replaceWith))
                return result;
            if (entry == null || !Directory.Exists(entry.Path))
                return result;
            if (AbortRequested) return false;

            // Dump the variable entry.FullName to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFolderForEntry: entry.FullName = '{entry.Path}'"
            );

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.RenameSubFolders
                    )
                );

                var destination = string.Empty;

                ITextReplacementEngine engine = GetTextReplacementEngine
                                                .For(
                                                    OperationType
                                                        .RenameSubFolders
                                                )
                                                .AndAttachConfiguration(
                                                    CurrentConfiguration
                                                );
                if (engine == null) return result;

                IMatchExpressionFactory matchExpressionFactory =
                    GetMatchExpressionFactory.For(
                                                 OperationType.RenameSubFolders
                                             )
                                             .AndAttachConfiguration(
                                                 CurrentConfiguration
                                             );
                if (matchExpressionFactory == null) return result;

                var retriever = GetTextValueRetriever.For(
                    OperationType.RenameSubFolders
                );
                if (retriever == null) return result;

                var source = retriever.GetTextValue(entry);
                if (string.IsNullOrWhiteSpace(source))
                    return result;
                if (!Directory.Exists(source)) return result;

                var expression = matchExpressionFactory.ForTextValue(source)
                    .ToFindWhat(findWhat)
                    .AndReplaceItWith(replaceWith);
                if (expression == null) return result;

                destination = engine.Replace(expression);
                if (string.IsNullOrWhiteSpace(destination))
                    return result;
                if (destination.Equals(
                        source, StringComparison.OrdinalIgnoreCase
                    ))
                    return
                        result; // no change, so do not proceed with the Rename operation

                if (entry.ToDirectoryInfo()
                         .RenameTo(destination) && !Directory.Exists(source))
                {
                    result = true; /* success */
                    OnFolderRenamed(
                        new FolderRenamedEventArgs(source, destination)
                    );
                }
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFolderForEntry: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Attempts to reopen those Visual Studio Solution (<c>*.sln</c>) files that were
        /// loaded in various Visual Studio instance(s) before the operation(s) were
        /// performed.
        /// </summary>
        private void ReopenActiveSolutions()
        {
            try
            {
                // If Visual Studio is open, and it currently has the solution
                // open, then close the solution before we perform the rename operation.

                // Dump the value of the property, ShouldReOpenSolutions, to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.ReopenActiveSolutions: ShouldReOpenSolutions = {ShouldReOpenSolutions}"
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** FileRenamer.ReopenActiveSolutions: Checking whether the 'ShouldReOpenSolutions' Boolean expression evaluates to TRUE..."
                );

                // Check to see whether the Boolean expression, ShouldReOpenSolutions, evaluates to TRUE.  If it does not, log an error message to the log file and then terminate the execution of this method.
                if (!ShouldReOpenSolutions)
                {
                    // the Boolean expression, ShouldReOpenSolutions, evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR: The Boolean expression, 'ShouldReOpenSolutions', evaluated to FALSE.  Stopping."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ReopenActiveSolutions: *** SUCCESS *** The Boolean expression, 'ShouldReOpenSolutions', evaluated to TRUE.  Proceeding..."
                );

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "*** FileRenamer.ReopenActiveSolutions: Checking whether at least one of the previously-loaded Solutions should be reopened..."
                );

                // Check to see whether the Boolean expression,
                // Should.AnyPreviouslyLoadedSolutionsBeReopened(LoadedSolutions),
                // evaluates to TRUE.  If it does not, log an error message to the
                // log file and then terminate the execution of this method.
                if (!Should.AnyPreviouslyLoadedSolutionsBeReopened(
                        LoadedSolutions
                    ))
                {
                    // the Boolean expression, Should.AnyPreviouslyLoadedSolutionsBeReopened(LoadedSolutions), evaluated to FALSE.
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        "*** FYI: None of the previously-loaded Solutions are marked as needing to be reopened.  Stopping..."
                    );

                    // stop.
                    return;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ReopenActiveSolutions: *** FYI: At least one previously-loaded Solution has been marked for reopening."
                );

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.OpenActiveSolutions
                    )
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        "Instructing Visual Studio to reload the solution (maybe with its new path)...",
                        CurrentOperation
                    )
                );

                var numFailed = 0;
                foreach (var solution in LoadedSolutions)
                    try
                    {
                        if (solution == null) continue;
                        if (!solution.ShouldReopen) continue;
                        if (!Does.FileExist(solution.FullName))
                            continue;
                        if (Is.SolutionOpen(solution)) continue;

                        if (ReopenSolution(solution)) continue;

                        Interlocked.Increment(ref numFailed);
                        ReportSolutionOpenFailed(solution.FullName);
                    }
                    catch (Exception ex)
                    {
                        // dump all the exception info to the log
                        DebugUtils.LogException(ex);
                    }

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.OpenActiveSolutions
                    )
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        /// <summary>
        /// Tasks the associated instance of Visual Studio to load the specified
        /// <paramref name="solution" />.
        /// </summary>
        /// <param name="solution">
        /// (Required.) Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.VisualStudio.Solutions.Interfaces.IVisualStudioSolution" />
        /// interface that represents the Visual Studio Solution (<c>*.sln</c>) file that
        /// is to be loaded.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the operation completed successfully;
        /// <see langword="false" /> otherwise.
        /// </returns>
        private bool ReopenSolution(IVisualStudioSolution solution)
        {
            var result = false;

            try
            {
                if (solution == null) return result;
                if (solution.SolutionObject == null) return result;
                if (!solution.ShouldReopen) return result;
                if (Is.SolutionOpen(solution)) return true;

                var fileNameToUse = solution.SolutionObject.FullName;
                if (!Does.FileExist(fileNameToUse))
                    fileNameToUse = solution.FullName;

                if (!Does.FileExist(fileNameToUse)) return result;

                UpdateStatus(
                    $"Opening solution '{fileNameToUse}'...", CurrentOperation
                );

                result = solution.Load();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.ReopenSolution: Result = {result}"
            );

            return result;
        }

        [Log(AttributeExclude = true)]
        private bool ReplaceTextInFileForEntry(
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            try
            {
                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ReplaceTextInFileForEntry: Checking whether the 'entry' method parameter has a null reference for a value..."
                );

                // Check to see if the required parameter, entry, is null. If it is, send an
                // error to the log file and quit, returning the default return value of this
                // method.
                if (entry == null)
                {
                    // The parameter, 'entry', is required and is not supposed to have a NULL value.
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FileRenamer.ReplaceTextInFileForEntry: *** ERROR *** A null reference was passed for the 'entry' method parameter.  Stopping..."
                    );

                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"*** FileRenamer.ReplaceTextInFileForEntry: Result = {result}"
                    );

                    // stop.
                    return result;
                }

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.ReplaceTextInFileForEntry: *** SUCCESS *** We have been passed a valid object reference for the 'entry' method parameter.  Proceeding..."
                );

                if (string.IsNullOrWhiteSpace(findWhat))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because the 'Find What' value is blank."
                    );

                    return result;
                }

                if (string.IsNullOrWhiteSpace(replaceWith))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because the 'Replace With' value is blank."
                    );

                    return result;
                }

                if (string.IsNullOrWhiteSpace(entry.Path))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because the pathname is blank."
                    );

                    return result;
                }

                if (!Does.FileExist(entry.Path))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because it could not be found on the file system."
                    );

                    return result;
                }

                if (AbortRequested)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because an Abort has been requested."
                    );

                    return result;
                }

                var origFileInfo = new FileInfo(entry.Path);
                if (!origFileInfo.Exists)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because it could not be found on the file system."
                    );

                    return result;
                }

                var origLength = origFileInfo.Length;
                if (origLength <= 0)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because it has a zero length."
                    );

                    return result;
                }

                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.ReplaceTextInFiles
                    )
                );

                var newFileData = GetTextInFileReplacementData(
                    entry, findWhat, replaceWith
                );
                if (string.IsNullOrWhiteSpace(newFileData))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** Not replacing text in file '{entry.Path}' because the new file data is blank."
                    );

                    return result;
                }

                if (SpecializedFileData.BinaryFileSkipped.Equals(newFileData))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because it contains control characters that would suggest it's a binary file."
                    );

                    return true; // "succeed" but don't process any further
                }

                if (SpecializedFileData.NoChange.Equals(newFileData))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because there is nothing to be replaced."
                    );

                    return true; // "succeed" but don't process any further
                }

                /*
                 * OKAY, check whether the replacement file data has zero byte length.
                 * If so, then the file-deletion operation above suffices to remove the
                 * file whose data is being replaced.
                 *
                 * We only will carry out the writing of data to the file on the file system
                 * in the event that the dataContainingTextToBeReplaced variable has more than zero byte
                 * length.  We are willing to write whitespace to the file, in order to
                 * support the Whitespace programming language.
                 *
                 * If the replacementData is a zero-length string, then the deletion
                 * of the file (as performed by the code preceding this comment) will
                 * be how the replacement of text in a file with zero-byte content is
                 * carried out.  Meaning: if you ask us to replace a text file's
                 * entire contents with nothing, that is the same as deleting the file
                 * entirely.
                 */

                if (string.IsNullOrWhiteSpace(newFileData))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"*** ERROR *** '{entry.Path}' will not be getting any text replaced in it because the new file data is blank.  Deleting the file instead..."
                    );

                    return true; // "succeed" but don't process any further
                }

                // Calculate the length of the modified text
                long modifiedLength = Encoding.UTF8.GetByteCount(newFileData);

                using (var writer =
                       MakeNewFileStreamWriter.ForFilePath(entry.Path))
                {
                    writer.SetLength(modifiedLength);

                    writer.WriteAllText(newFileData);
                }

                result = true;
            }
            catch (OperationAbortedException)
            {
                AbortRequested = true;

                throw;
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));

                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    entry != null
                        ? $"*** ERROR *** Exception caught while attempting to replace text in the file, '{entry.Path}':  {ex.Message}"
                        : $"*** ERROR *** Exception caught while attempting to replace text in a file:  {ex.Message}"
                );

                result = false;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.ReplaceTextInFileForEntry: Result = {result}"
            );

            return result;
        }

        /// <summary>
        /// Reports that an attempt to close a Visual Studio Solution (<c>*.sln</c>) file
        /// having the specified <paramref name="pathname" /> that was loaded into a
        /// running instance of Visual Studio has failed.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> containing
        /// the fully-qualified pathname of the Visual Studio Solution (<c>*.sln</c>) that
        /// could not be closed.
        /// </param>
        private void ReportSolutionCloseFailed(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;

            OnSolutionCloseFailed(
                new SolutionCloseFailedEventArgs(
                    new Exception(
                        string.Format(
                            Resources.Error_AttemptToCloseSolutionFailed,
                            pathname
                        )
                    )
                )
            );
        }

        private void ReportSolutionOpenFailed(string pathname)
        {
            if (string.IsNullOrWhiteSpace(pathname)) return;

            OnSolutionOpenFailed(
                new SolutionOpenFailedEventArgs(
                    new Exception(
                        string.Format(
                            Resources.Error_AttemptToOpenSolutionFailed,
                            pathname
                        )
                    )
                )
            );
        }

        private bool SearchForLoadedSolutions()
        {
            OnOperationStarted(
                new OperationStartedEventArgs(OperationType.FindVisualStudio)
            );

            LoadedSolutions.Clear();

            // This tool can potentially be run from Visual Studio (e.g.,
            // configured via the Tools menu as an external tool, for instance).

            // If the tool has been launched from an open instance of Visual
            // Studio, and if there exists an open instance of Visual Studio
            // that currently has the solution containing the items to be
            // renamed open, then close the solution automatically for the user.

            // Scan the folder in which we are starting for files ending with the
            // .sln extension.  If any of them are open in Visual Studio, mark
            // them all for reloading, and then reload them.
            LoadedSolutions.AddRange(
                new List<IVisualStudioSolution>(
                    VisualStudioSolutionService.GetLoadedSolutionsInFolder(
                        RootDirectoryPath
                    )
                )
            );

            if (LoadedSolutions != null && LoadedSolutions.Any())
            {
                /*
                 * So, there are solution(s) in the root directory that are
                 * currently loaded in running instance(s) of Visual Studio.
                 * Determine whether they should be reopened by providing the
                 * value of the config's ReOpenSolution flag.
                 */

                foreach (var solution in LoadedSolutions)
                    solution.ShouldReopen = CurrentConfiguration.ReOpenSolution;

                ShouldReOpenSolutions = LoadedSolutions.Any(
                    solution => solution.ShouldReopen
                );
            }
            else if (!Get.SolutionPathsInFolder(RootDirectoryPath)
                         .Any())
            {
                DebugUtils.WriteLine(
                    DebugLevel.Error,
                    string.Format(
                        Resources.Error_NoSolutionsInRootDirectory,
                        RootDirectoryPath
                    )
                );

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.FindVisualStudio
                    )
                );

                return false;
            }
            else if (Process.GetProcessesByName("devenv")
                            .Any())
            {
                /*
                 * If we are here, then there are solutions in the root
                 * directory folder, but there may also be open instances of
                 * DevEnv.  In which case, we should detect if there are
                 * any instances of DevEnv open in any event, so we can prompt
                 * the user whether the user still wishes to proceed, so that
                 * we may not disrupt the user's work.
                 */

                ShouldReOpenSolutions = false;

                // One or more copies of VS are open, but it would seem unlikely
                // that any of them have the solution open (unless its name
                // differs from the convention). In this event, prompt the user
                // that if the file(s) they are renaming are part of a solution
                // that is currently open in Visual Studio, that the user will
                // need to re-load the solution by hand after the operation has
                // been completed.

                if (CurrentConfiguration.PromptUserToReloadOpenSolution &&
                    DialogResult.No == MessageBox.Show(
                        Resources.Confirm_PerformRename,
                        Application.ProductName, MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1
                    ))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "FileRenamer.DoProcessAll: The user cancelled the rename operation."
                    );

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.FindVisualStudio
                        )
                    );

                    return false;
                }
            }

            OnOperationFinished(
                new OperationFinishedEventArgs(OperationType.FindVisualStudio)
            );
            return true;
        }

        private void SearchForRenamedSolution(
            string oldFolderPath,
            string newFolderPath
        )
        {
            try
            {
                /*
                 * This method is supposed to be called as part of the Rename Folder(s)
                 * that Contain Solution(s) operation.
                 *
                 * We assume that this method has been called after the folder(s) that
                 * contain Solution(s) have been renamed.
                 *
                 * Now that the folder(s) that the Solution(s) themselves are contained
                 * in has been renamed, update the pathname of any of the Solution(s)
                 * in our list of loaded Solution(s) to have the new pathname.
                 *
                 * If the RootDirectoryPath is also formerly set to the oldFolderPath,
                 * update it as well.
                 */

                if (string.IsNullOrWhiteSpace(oldFolderPath))
                    return;
                if (!Does.FolderExist(newFolderPath)) return;
                if (!LoadedSolutions.Any()) return;

                if (oldFolderPath.Equals(RootDirectoryPath))
                    RootDirectoryPath = newFolderPath;

                foreach (var currentSolution in LoadedSolutions)
                {
                    var currentSolutionPath = currentSolution.FullName;
                    if (string.IsNullOrWhiteSpace(currentSolutionPath))
                        continue;

                    var currentSolutionFolder =
                        Path.GetDirectoryName(currentSolutionPath);
                    if (string.IsNullOrWhiteSpace(currentSolutionFolder))
                        continue;

                    if (!currentSolutionFolder.Equals(oldFolderPath)) continue;

                    var newSolutionPath = currentSolutionPath.Replace(
                        oldFolderPath, newFolderPath
                    );
                    if (!Does.FileExist(newSolutionPath)) continue;

                    currentSolution.FullName = newSolutionPath;

                    // Dump the variable currentSolution.FullName to the log
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.SearchForRenamedSolution: currentSolution.FullName = '{currentSolution.FullName}'"
                    );

                    // Dump the variable currentSolution.WasVisualStudioClosed to the log
                    DebugUtils.WriteLine(
                        DebugLevel.Debug,
                        $"FileRenamer.SearchForRenamedSolution: currentSolution.WasVisualStudioClosed = {currentSolution.WasVisualStudioClosed}"
                    );

                    if (currentSolution.WasVisualStudioClosed)
                        currentSolution.Launch(true);

                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private void UpdateLoadedSolutionPaths(FileRenamedEventArgs e)
        {
            if (!LoadedSolutions.Any(
                    solution => solution.FullName.ToLowerInvariant()
                                        .Equals(e.Source.ToLowerInvariant())
                )) return;

            if (string.IsNullOrWhiteSpace(e.Source)) return;
            if (string.IsNullOrWhiteSpace(e.Destination)) return;
            if (!Is.SolutionPathnameValid(e.Source)) return;
            if (!Is.SolutionPathnameValid(e.Destination)) return;

            foreach (var solution in LoadedSolutions)
                if (e.Source.EqualsNoCase(solution.FullName))
                    solution.FullName = e.Destination;
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.Renamers.Files.FileRenamer.StatusUpdate" /> event.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the status message text that is meant for display
        /// to the user.
        /// </param>
        /// <param name="operationType">
        /// (Required.) One of the <see cref="T:MFR.Operations.Constants.OperationType" />
        /// enumeration values that describes the operation that is currently being
        /// performed.
        /// </param>
        /// <param name="operationFinished">
        /// (Optional.) A <see cref="T:System.Boolean" /> value that indicates whether the
        /// operation is finished.
        /// <para />
        /// Default value is <see langword="false" />.
        /// </param>
        private void UpdateStatus(
            string text,
            OperationType operationType,
            bool operationFinished = false
        )
            => OnStatusUpdate(
                new StatusUpdateEventArgs(
                    text, operationType, operationFinished
                )
            );
    }
}