using MFR.Constants;
using MFR.Directories.Validators.Factories;
using MFR.Directories.Validators.Interfaces;
using MFR.Engines.Replacement.Factories;
using MFR.Engines.Replacement.Intefaces;
using MFR.Events;
using MFR.Events.Common;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Factories.Interfaces;
using MFR.Expressions.Matches.Interfaces;
using MFR.File.Stream.Providers.Factories;
using MFR.File.Stream.Providers.Interfaces;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Factories;
using MFR.FileSystem.Retrievers.Interfaces;
using MFR.Managers.RootFolders.Factories;
using MFR.Managers.RootFolders.Interfaces;
using MFR.Managers.Solutions.Actions;
using MFR.Managers.Solutions.Factories;
using MFR.Managers.Solutions.Interfaces;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Operations.Exceptions;
using MFR.Renamers.Files.Actions;
using MFR.Renamers.Files.Events;
using MFR.Renamers.Files.Interfaces;
using MFR.Renamers.Files.Properties;
using MFR.Settings.Configuration;
using MFR.Settings.Configuration.Interfaces;
using MFR.Settings.Configuration.Providers.Factories;
using MFR.Settings.Configuration.Providers.Interfaces;
using MFR.TextValues.Retrievers.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Directories.Monitors.Actions;
using xyLOGIX.Directories.Monitors.Events;
using xyLOGIX.Queues.Messages;
using xyLOGIX.VisualStudio.Solutions.Interfaces;
using Delete = MFR.Renamers.Files.Actions.Delete;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using Does = MFR.FileSystem.Factories.Actions.Does;
using Path = Alphaleonis.Win32.Filesystem.Path;

namespace MFR.Renamers.Files
{
    /// <summary>
    /// Provides file- and folder-rename services.
    /// </summary>
    /// <remarks>
    /// NOTE: Instances of this class must be composed with an instance of an
    /// object that implements the
    /// <see
    ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
    /// interface.
    /// <para />
    /// Such an object is necessary because it provides settings specified by
    /// the user that change the behavior of this object.
    /// </remarks>
    public class FileRenamer : ConfigurationComposedObjectBase, IFileRenamer
    {
        /// <summary>
        /// An <see cref="T:MFR.Operations.Constants.OperationType" /> enumeration value
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

            // Remove any extra list elements from memory
            ((List<IVisualStudioSolution>)LoadedSolutions).TrimExcess();
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
        ///     cref="T:MFR.Settings.Configuration.Providers.Interfaces.IProjectFileRenamerConfigurationProvider" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object allows access to the user configuration and the
        /// actions
        /// associated with it.
        /// </remarks>
        private static IProjectFileRenamerConfigurationProvider
            ConfigurationProvider
            => GetProjectFileRenamerConfigurationProvider.SoleInstance();

        /// <summary>
        /// Gets or sets a reference to an instance of an object that implements
        /// the
        /// <see
        ///     cref="T:MFR.Settings.Configuration.Interfaces.IProjectFileRenamerConfiguration" />
        /// interface.
        /// </summary>
        public override IProjectFileRenamerConfiguration CurrentConfiguration
        {
            get;
            set;
        } = ConfigurationProvider.CurrentConfiguration;

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
        /// Gets a reference to a collection of of the
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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.File.Stream.Providers.Interfaces.IFileStreamProvider" />
        /// interface.
        /// </summary>
        private static IFileStreamProvider FileStreamProvider
            => GetFileStreamProvider.SoleInstance();

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

        /// <summary>
        /// Gets a <see cref="T:System.String" /> containing the full pathname of the
        /// folder where all
        /// operations start.
        /// </summary>
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
            => GetRootDirectoryPathValidator.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:MFR.Managers.RootFolders.Interfaces.IRootFolderPathManager" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object manages a collection of strings.
        /// <para />
        /// Individually, the strings are all taken to be the root folder of where our
        /// search should start for the operation(s) that the user wants us to process.
        /// </remarks>
        private static IRootFolderPathManager RootFolderPathManager
            => GetRootFolderPathManager.SoleInstance();

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
        /// <see cref="T:MFR.Managers.Solutions.Interfaces.IVisualStudioSolutionService" />
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
        /// Occurs when an operation is about to be processed for a file or a folder.
        /// </summary>
        public event ProcessingOperationEventHandler ProcessingOperation;

        /// <summary>
        /// Occurs if the value of the
        /// <see cref="P:MFR.Renamers.Files.FileRenamer.RootDirectoryPath" /> property is
        /// changed.
        /// </summary>
        public event RootDirectoryPathChangedEventHandler
            RootDirectoryPathChanged;

        /// <summary>
        /// Occurs when a folder that contains a Visual Studio Solution (<c>*.sln</c>) file
        /// has been renamed.
        /// </summary>
        public event FolderRenamedEventHandler SolutionFolderRenamed;

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
        /// Occurs when subfolders to be renamed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            SubfoldersToBeRenamedCounted;

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
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
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

                var renameFilesInFolderResult = true;
                if (CurrentConfiguration.RenameFiles)
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

                // make sure there are no open file streams before
                // proceeding
                if (FileStreamProvider.Count > 0)
                    FileStreamProvider.DisposeAll();

                var renameSolutionFoldersResult = true;
                if (CurrentConfiguration.RenameSolutionFolders)
                    renameSolutionFoldersResult = RenameSolutionFolders(
                        RootDirectoryPath, findWhat, replaceWith, pathFilter
                    );

                result = renameFilesInFolderResult && renameSubFoldersResult &&
                         replaceTextInFilesResult &&
                         renameSolutionFoldersResult;
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
        /// (Required.) Path to the recursion root.
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
            string rootDirectoryPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
        )
        {
            if (CurrentConfiguration == null)
                throw new InvalidOperationException(
                    "The configuration has not been initialized."
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
                 * Starting DoesFolder text box.
                 *
                 * In prior versions of this app, that folder was where we would simply
                 * start our file and folder enumerations.  The primary use case of
                 * this software is to be installed into the 'Tools' menu of Visual
                 * Studio as an External Tool and to be configured to have the
                 * folder containing the currently-opened solution inside of its
                 * Starting DoesFolder text box.  The thinking is that the user wants
                 * to call up this tool from within Visual Studio in order to do
                 * project-renaming on the currently open solution.
                 *
                 * However, there is a secondary use case: that of launching the tool
                 * from the Start menu, with the option to specify whatever folder
                 * we like in the Starting DoesFolder text box.  Such a folder may, or
                 * may not, contain a single .sln file.  It may be the root of a
                 * whole directory TREE of solutions, that ALL need name changes.
                 * Say, for instance, we have a whole bunch of projects with the name
                 * of the company, XYZCorp, in them.  Say XYZCorp now goes through
                 * a re-brand and becomes ABCorp.  So, perhaps the user may want
                 * to launch this tool in their main dev folder, and specify that
                 * the rename XYZCorp -> ABCorp has to happen for ALL the solutions
                 * in ALL the subfolders of the folder specified.
                 */

                RootFolderPathManager.Clear();

                RootFolderPathManager.AddFolderIfItContainsASolution(
                    rootDirectoryPath
                );

                RootFolderPathManager.AddSolutionSubFoldersOf(
                    rootDirectoryPath
                );

                foreach (var folder in RootFolderPathManager.GetAll())
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
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
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
                    $"The specified folder, with pathname '{rootFolderPath}', could not be located on the disk."
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
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
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

                /*
                 * OKAY, this is the loop over the list of the folders that we've found
                 * underneath the Root Directory, that contain Visual Studio Solution (<c>*.sln</c>)
                 * files, and whose names match the search criteria that was specified
                 * by the user.  For each folder, rename it according to the settings
                 * specified by the user.  NOTE: The method called must return TRUE for ALL
                 * the folders, in order for this operation to be considered a success.
                 */

                result = fileSystemEntries.TakeWhile(entry => !AbortRequested)
                                          .All(
                                              entry
                                                  => RenameSolutionFolderForEntry(
                                                      findWhat, replaceWith,
                                                      entry
                                                  )
                                          );

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
            string rootFolderPath,
            string findWhat,
            string replaceWith,
            Predicate<string> pathFilter = null
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
                        $"Attempting to rename subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'...",
                        CurrentOperation
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
                 * OKAY, this is the loop over the list of the subfolders
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
                    $"The specified folder, with pathname '{rootFolderPath}', could not be located on the disk."
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

            var fileSystemEntries = retriever.UsingSearchPattern("*")
                                             .WithSearchOption(
                                                 SearchOption.AllDirectories
                                             )
                                             .ToFindWhat(findWhat)
                                             .AndReplaceItWith(replaceWith)
                                             .GetMatchingFileSystemPaths(
                                                 RootDirectoryPath, pathFilter
                                             )
                                             .ToList();

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.ReplaceTextInFiles: {fileSystemEntries.Count} file(s) found to move forward on."
            );

            if (!fileSystemEntries.Any() && !AbortRequested)
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
                    fileSystemEntries.Count, OperationType.ReplaceTextInFiles
                )
            );

            try
            {
                result = fileSystemEntries.TakeWhile(entry => !AbortRequested)
                                          .All(
                                              entry
                                                  => ReplaceTextInFileForEntry(
                                                      findWhat, replaceWith,
                                                      entry
                                                  )
                                          );

                result &= !AbortRequested;
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
            finally
            {
                // free memory resources from the Replace Text In Files operation
                FileStreamProvider.DisposeAll();
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
        /// exists on the disk; otherwise,
        /// <see cref="T:System.IO.DirectoryNotFoundException" /> is thrown.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="path" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder whose fully-qualified pathname is passed in the
        /// <paramref name="path" /> parameter cannot be located on the disk.
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
             * We do not perform any input validation here.  This is because
             * this value may be being initialized from a default (blank)
             * configuration.   the configuration may be blank for a number of
             * reasons, but one of these is the issue that the configuration
             * file on the disk may have gotten corrupted or erased.
             */

            RootDirectoryPath = path;

            return this;
        }

        /// <summary>
        /// Occurs when solution folders that are to be renamed have been counted.
        /// </summary>
        public event FilesOrFoldersCountedEventHandler
            SolutionFoldersToBeRenamedCounted;

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
             * We check if this is so.  If so, then we update the Path property of any of
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
            => RootDirectoryPathChanged?.Invoke(this, e);

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

            FolderRenamed?.Invoke(this, e);
            SendMessage<FileRenamedEventArgs>.Having.Args(this, e)
                                             .ForMessageId(
                                                 FileRenamerMessages
                                                     .FRM_SOLUTION_FOLDER_RENAMED
                                             );
        }

        public void SearchForRenamedSolution(string oldFolderPath, string newFolderPath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(oldFolderPath)) return;
                if (!Does.FolderExist(newFolderPath)) return;
                if (!LoadedSolutions.Any()) return;

                foreach (var currentSolution in LoadedSolutions)
                {
                    var currentSolutionPath = currentSolution.Path;
                    if (string.IsNullOrWhiteSpace(currentSolutionPath))
                        continue;

                    var currentSolutionFolder =
                        Path.GetDirectoryName(currentSolutionPath);
                    if (string.IsNullOrWhiteSpace(currentSolutionFolder))
                        continue;

                    if (!currentSolutionFolder.Equals(oldFolderPath)) continue;

                    var newSolutionPath = currentSolutionFolder.Replace(
                        oldFolderPath, newFolderPath
                    );
                    if (!Does.FileExist(newSolutionPath)) continue;

                    currentSolution.Path = newSolutionPath;
                    break;
                }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
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

                foreach (var solution in LoadedSolutions)
                    CloseSolution(solution);

                /* Wait for the solution to be closed.
                    while (dte.Solution.IsOpen) Thread.Sleep(50);*/

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
            }
        }

        private void CloseSolution(IVisualStudioSolution solution)
        {
            try
            {
                if (solution == null) return;
                if (!solution.IsLoaded) return;
                if (string.IsNullOrWhiteSpace(solution.Path)) return;
                if (!Does.FileExist(solution.Path)) return;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.DoProcessAll: An instance of Visual Studio currently has the solution '{solution.Path}' open."
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Closing solution '{solution.Path}'...",
                        CurrentOperation, true /* operation finished */
                    )
                );

                solution.Unload();
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
        /// (Required.) Path to the recursion root.
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

            var rootDirectoryPathMonitorTicket = Guid.Empty;

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

                rootDirectoryPathMonitorTicket = Monitor
                                                 .Folder(RootDirectoryPath)
                                                 .AndCallThisMethodWhenItsRenamed(
                                                     OnRootDirectoryRenamed
                                                 );
                if (rootDirectoryPathMonitorTicket.IsZero())
                    return; // failed to create directory monitor

                OnStarted();

                if (!SearchForLoadedSolutions())
                {
                    Dispose.DirectoryMonitor(rootDirectoryPathMonitorTicket);
                    rootDirectoryPathMonitorTicket = Guid.Empty;
                    return;
                }

                // If Visual Studio is open and it currently has the solution
                // open, then close the solution before we perform the rename operation.

                CloseActiveSolutions();

                if (!InvokeProcessing(findWhat, replaceWith, pathFilter))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        "*** ERROR *** The InvokeProcessing method returned FALSE."
                    );

                    ReopenActiveSolutions();

                    OnFinished();
                    Dispose.DirectoryMonitor(rootDirectoryPathMonitorTicket);
                    rootDirectoryPathMonitorTicket = Guid.Empty;
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

                Dispose.DirectoryMonitor(rootDirectoryPathMonitorTicket);
                rootDirectoryPathMonitorTicket = Guid.Empty;
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

        private string GetTextInFileReplacementData(
            IFileSystemEntry entry,
            string findWhat,
            string replaceWith
        )
        {
            var result = string.Empty;

            try
            {
                if (entry == null) return result;
                if (string.IsNullOrWhiteSpace(entry.Path)) return result;
                if (!Does.FileSystemEntryExist(entry.Path)) return result;
                if (string.IsNullOrWhiteSpace(findWhat)) return result;

                ITextReplacementEngine engine = GetTextReplacementEngine
                                                .For(
                                                    OperationType
                                                        .ReplaceTextInFiles
                                                )
                                                .AndAttachConfiguration(
                                                    CurrentConfiguration
                                                );
                if (engine == null) return result;

                IMatchExpressionFactory matchExpressionFactory =
                    GetMatchExpressionFactory
                        .For(OperationType.ReplaceTextInFiles)
                        .AndAttachConfiguration(CurrentConfiguration);
                if (matchExpressionFactory == null) return result;

                var textToBeSearched = GetTextValueRetriever.For(
                        OperationType.ReplaceTextInFiles
                    )
                    .GetTextValue(entry);
                if (string.IsNullOrWhiteSpace(textToBeSearched)) return result;

                // release the stream or the OS won't let us perform the
                // text replacement operation
                FileStreamProvider.DisposeStream(entry.UserState);

                IMatchExpression expression = matchExpressionFactory
                                              .ForTextValue(textToBeSearched)
                                              .AndAttachConfiguration(
                                                  CurrentConfiguration
                                              )
                                              .ToFindWhat(findWhat)
                                              .AndReplaceItWith(replaceWith);
                if (expression == null) return result;

                result = engine.Replace(expression);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }
            finally
            {
                // if an exception occurs, we need to dispose the most-recently-
                // opened/accessed file stream.  We need this block to be here
                // since there is a high risk of exceptions occurring whenever
                // files are opened/accessed.
                //
                // NOTE: I was tempted to invoke the IFileStreamProvider.DisposeAll()
                // method here; however, the thinking is that this exception has
                // triggered this finally clause just for the file system entry
                // that is currently being processed; therefore, we just try to
                // dispose the file system entry that is currently being worked on
                if (entry != null &&
                    !((Guid)entry.UserState).Equals(Guid.Empty))
                    FileStreamProvider.DisposeStream(entry.UserState);
            }

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
            lock (SyncRoot)
            {
                IsBusy = false;
                IsStarted = false;
            }

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

        private void OnRootDirectoryRenamed(
            object sender,
            DirectoryBeingMonitoredChangedEventArgs e
        )
        {
            if (!IsStarted) return;

            if (LoadedSolutions.Any())
                foreach (var solution in LoadedSolutions)
                {
                    if (solution == null) continue;
                    if (string.IsNullOrWhiteSpace(solution.Path)) continue;

                    var solutionFolder = Path.GetDirectoryName(solution.Path);
                    if (string.IsNullOrWhiteSpace(solutionFolder)) continue;

                    var solutionFileName = Path.GetFileName(solution.Path);
                    if (string.IsNullOrWhiteSpace(solutionFileName)) continue;

                    if (!solutionFolder.Contains(RootDirectoryPath) &&
                        !RootDirectoryPath.Contains(solutionFolder)) continue;

                    ProgramFlowHelper.StartDebugger();

                    /*
                     * If we are here, then one or more of the Visual Studio Solution (*.sln)
                     * files that had been already loaded in Visual Studio when we began the
                     * operations is now potentially in a different location.  Let's determine
                     * whether that is so, and if so, update its path to correspond to where
                     * on the disk it is sitting now.
                     */

                    var newSolutionPath = Path.Combine(
                        e.NewPath, solutionFileName
                    );
                    if (!Alphaleonis.Win32.Filesystem.File.Exists(
                            newSolutionPath
                        ))
                        continue; // give up because we don't know where the hell this Solution went to

                    solution.Path =
                        newSolutionPath; // update the path of the Solution to refer to where it is now
                }

            RootDirectoryPath =
                e.NewPath; // update the Root Directory to the new path it's been renamed to

            SendMessage<DirectoryBeingMonitoredChangedEventArgs>.Having.Args(
                    this,
                    new DirectoryBeingMonitoredChangedEventArgs(
                        e.OldPath, e.NewPath
                    )
                )
                .ForMessageId(
                    FileRenamerMessages.FRM_ROOT_DIRECTORY_PATH_CHANGED
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

            // Dump the variable entry.Path to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameFileInFolderForEntry: entry.Path = '{entry.Path}'"
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
                 * DoesFolder property is filled during its construction.)
                 *
                 * This is done because we are operating under the assumption
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
                                 * of the operation so we can process any other
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
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            // Dump the variable findWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameSolutionFolderForEntry: findWhat = '{findWhat}'"
            );

            // Dump the variable replaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameSolutionFolderForEntry: replaceWith = '{replaceWith}'"
            );

            if (string.IsNullOrWhiteSpace(findWhat)) return result;
            if (string.IsNullOrWhiteSpace(replaceWith))
                return result;
            if (entry == null || !Directory.Exists(entry.Path))
                return result;
            if (AbortRequested) return result;

            // Dump the variable entry.Path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameSolutionFolderForEntry: entry.Path = '{entry.Path}'"
            );

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.RenameSolutionFolders
                    )
                );

                var destination =
                    string
                        .Empty; // new name for the solution folder

                /*
                 * This is the thing that actually does the replacement.
                 */

                ITextReplacementEngine engine =
                    GetTextReplacementEngine.For(
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

                var expression = matchExpressionFactory
                                 .ForTextValue(source)
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
                 * Actually DO the rename operation.
                 */

                var entryDirectionInfo = entry.ToDirectoryInfo();
                if (entryDirectionInfo == null) return result;

                if (entryDirectionInfo
                        .RenameTo(destination) &&
                    !Directory.Exists(source)
                    && Directory.Exists(destination))
                {
                    result = true; /* success */
                    OnSolutionFolderRenamed(
                        new FolderRenamedEventArgs(
                            source, destination
                        )
                    );
                }
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

            // Dump the variable entry.Path to the log
            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.RenameSubFolderForEntry: entry.Path = '{entry.Path}'"
            );

            try
            {
                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.RenameSubFolders
                    )
                );

                var destination = string.Empty;

                ITextReplacementEngine engine =
                    GetTextReplacementEngine.For(
                                                OperationType.RenameSubFolders
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

                var expression = matchExpressionFactory
                                 .ForTextValue(source)
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
                         .RenameTo(destination) &&
                    !Directory.Exists(source))
                {
                    result = true; /* success */
                    OnFolderRenamed(
                        new FolderRenamedEventArgs(
                            source, destination
                        )
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

        private void ReopenActiveSolutions()
        {
            // If Visual Studio is open and it currently has the solution
            // open, then close the solution before we perform the rename operation.
            if (!ShouldReOpenSolutions ||
                !LoadedSolutions.Any(
                    solution => solution.ShouldReopen
                ))
                return;

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

            foreach (var solution in LoadedSolutions.Where(
                         solution => solution.ShouldReopen
                     ))
                ReopenSolution(solution);

            /* Wait for the solution to be opened/loaded.
                    while (!dte.Solution.IsOpen) Thread.Sleep(50); */

            OnOperationFinished(
                new OperationFinishedEventArgs(
                    OperationType.OpenActiveSolutions
                )
            );
        }

        private void ReopenSolution(IVisualStudioSolution solution)
        {
            var numTries =
                0; // number of times we've attempted to open the solution thus far
            const int
                MAX_RETRIES = 10; // we will only try 10 times.

            try
            {
                if (solution == null) return;
                if (solution.IsLoaded) return;
                if (string.IsNullOrWhiteSpace(solution.Path))
                    return;
                if (!Does.FileExist(solution.Path)) return;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.DoProcessAll: An instance of Visual Studio currently has the solution '{solution.Path}' open."
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Opening solution '{solution.Path}'...",
                        CurrentOperation
                    )
                );

                while (!solution.IsLoaded && numTries < MAX_RETRIES)
                    try
                    {
                        numTries++;

                        solution.Load();
                    }
                    catch (Exception ex)
                    {
                        // dump all the exception info to the log
                        DebugUtils.LogException(ex);

                        // otherwise, continue to try
                        continue;
                    }
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }

        private bool ReplaceTextInFileForEntry(
            string findWhat,
            string replaceWith,
            IFileSystemEntry entry
        )
        {
            var result = false;

            try
            {
                /* validate inputs */
                if (string.IsNullOrWhiteSpace(findWhat))
                    return result;
                if (string.IsNullOrWhiteSpace(replaceWith))
                    return result;
                if (entry == null ||
                    string.IsNullOrWhiteSpace(entry.Path) ||
                    Guid.Empty.Equals(entry.UserState) ||
                    !Does.FileExist(entry.Path))
                    return result;
                if (AbortRequested) return result;

                OnProcessingOperation(
                    new ProcessingOperationEventArgs(
                        entry, OperationType.ReplaceTextInFiles
                    )
                );

                var replacementData = GetTextInFileReplacementData(
                    entry, findWhat, replaceWith
                );
                if (string.IsNullOrWhiteSpace(replacementData))
                    return result;

                if (Does.FileExist(entry.Path))
                    Delete.File(entry.Path);

                /*
                 * OKAY, check whether the replacement file data has zero byte length.
                 * If so, then the file-deletion operation above suffices to remove the
                 * file whose data is being replaced.
                 *
                 * We only will carry out the writing of data to the file on the disk
                 * in the event that the replacementData variable has more than zero byte
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
                if (!string.IsNullOrEmpty(replacementData))
                    Write.FileContent(entry.Path, replacementData);

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
                return true;
            }

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"FileRenamer.ReplaceTextInFileForEntry: Result = {result}"
            );

            return result;
        }

        private bool SearchForLoadedSolutions()
        {
            OnOperationStarted(
                new OperationStartedEventArgs(
                    OperationType.FindVisualStudio
                )
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
            LoadedSolutions = new List<IVisualStudioSolution>(
                VisualStudioSolutionService
                    .GetLoadedSolutionsInFolder(RootDirectoryPath)
            );

            if (LoadedSolutions != null && LoadedSolutions.Any())
            {
                /*
                     * So, there are solution(s) in the root directory that are
                     * currently loaded in running instance(s) of Visual Studio.
                     * Determine whether they should be reopened by providing the
                     * value of the configuration's ReOpenSolution flag.
                     */

                foreach (var solution in LoadedSolutions)
                    solution.ShouldReopen = CurrentConfiguration
                        .ReOpenSolution;

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

                if (DialogResult.No == MessageBox.Show(
                        Resources.Confirm_PerformRename,
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
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
                new OperationFinishedEventArgs(
                    OperationType.FindVisualStudio
                )
            );
            return true;
        }

        private void UpdateLoadedSolutionPaths(
            FileRenamedEventArgs e
        )
        {
            if (!LoadedSolutions.Any(
                    solution => solution.Path.ToLowerInvariant()
                                        .Equals(
                                            e.Source
                                             .ToLowerInvariant()
                                        )
                )) return;

            if (string.IsNullOrWhiteSpace(e.Source)) return;
            if (string.IsNullOrWhiteSpace(e.Destination)) return;

            if (!".sln".Equals(
                    Path.GetExtension(e.Source)
                        .ToLowerInvariant()
                )) return;
            if (!".sln".Equals(
                    Path.GetExtension(e.Destination)
                        .ToLowerInvariant()
                )) return;

            foreach (var solution in LoadedSolutions)
                if (e.Source.Equals(solution.Path))
                    solution.Path = e.Destination;
        }
    }
}