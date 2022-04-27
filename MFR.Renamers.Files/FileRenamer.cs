using EnvDTE;
using MFR.CommandLine.Validators.Factories;
using MFR.CommandLine.Validators.Interfaces;
using MFR.Constants;
using MFR.Engines.Replacement.Factories;
using MFR.Events;
using MFR.Events.Common;
using MFR.Expressions.Matches.Factories;
using MFR.Expressions.Matches.Interfaces;
using MFR.FileSystem.Enumerators;
using MFR.FileSystem.Helpers;
using MFR.FileSystem.Interfaces;
using MFR.FileSystem.Retrievers.Factories;
using MFR.Managers.RootFolders.Factories;
using MFR.Managers.RootFolders.Interfaces;
using MFR.Operations.Constants;
using MFR.Operations.Events;
using MFR.Operations.Exceptions;
using MFR.Renamers.Files.Interfaces;
using MFR.Renamers.Files.Properties;
using MFR.Settings.Configuration;
using MFR.TextValues.Retrievers.Factories;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using xyLOGIX.Core.Debug;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages;
using xyLOGIX.VisualStudio;
using Debugger = System.Diagnostics.Debugger;
using Directory = Alphaleonis.Win32.Filesystem.Directory;
using File = Alphaleonis.Win32.Filesystem.File;
using Path = Alphaleonis.Win32.Filesystem.Path;
using Process = System.Diagnostics.Process;

namespace MFR.Renamers.Files
{
    /// <summary>
    /// Provides file- and folder-rename services.
    /// </summary>
    /// <remarks>
    /// NOTE: Instances of this class must be composed with an instance of an
    /// object that implements the
    /// <see cref="T:MFR.Settings.Configuration.Interfaces.IConfiguration" />
    /// interface.
    /// <para />
    /// Such an object is necessary because it provides settings specified by
    /// the user that change the behavior of this object.
    /// </remarks>
    public class FileRenamer : ConfigurationComposedObjectBase, IFileRenamer
    {
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
            LastSolutionPath = RootDirectoryPath = string.Empty;
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:MFR.Renamers.Files.FileRenamer" />.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IFileRenamer Instance
        {
            get;
        } = new FileRenamer();

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
        /// Gets a reference to a collection of of the
        /// <see
        ///     cref="T:MFR.OperationType" />
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
        /// <see cref="T:MFR.CommandLine.Validators.Interfaces.IRootDirectoryValidator" />
        /// interface.
        /// </summary>
        /// <remarks>
        /// This object runs validation rules to ensure, among other things, that the
        /// pathname passed to it is that of a folder that exists on disk, and that
        /// contains a <c>.sln</c> file.
        /// </remarks>
        private IRootDirectoryValidator RootDirectoryValidator
            => GetRootDirectoryValidator.SoleInstance();

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
        private IRootFolderPathManager RootFolderPathManager
            => GetRootFolderPathManager.SoleInstance();

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
        /// Occurs when the processing has started.
        /// </summary>
        public event EventHandler Started;

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
        /// Gets or sets the path to the last Visual Studio Solution that we have worked
        /// with most recently.
        /// </summary>
        public string LastSolutionPath
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a string containing the full pathname of the folder where all
        /// operations start.
        /// </summary>
        public string RootDirectoryPath
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value determining whether the currently-open solution
        /// in Visual Studio should be closed and then re-opened at the
        /// completion of the operation.
        /// </summary>
        public bool ShouldReOpenSolution
        {
            get;
            private set;
        }

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
        public void ProcessAll(string findWhat, string replaceWith,
            Predicate<string> pathFilter = null)
        {
            if (string.IsNullOrWhiteSpace(RootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(RootDirectoryPath)
                );
            if (string.IsNullOrWhiteSpace(findWhat))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(findWhat)
                );
            if (string.IsNullOrWhiteSpace(replaceWith))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(replaceWith)
                );

            if (Configuration.RenameFiles)
            {
                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Attempting to rename subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
                    )
                );

                RenameSubFoldersOf(
                    RootDirectoryPath, findWhat, replaceWith, pathFilter
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"*** Finished processing subfolders of '{RootDirectoryPath}'."
                    )
                );
            }

            if (Configuration.RenameSubfolders)
            {
                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Renaming files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
                    )
                );

                RenameFilesInFolder(
                    RootDirectoryPath, findWhat, replaceWith, pathFilter
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"*** Finished renaming files in subfolders of '{RootDirectoryPath}'."
                    )
                );
            }

            if (Configuration.ReplaceInFiles)
            {
                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"Replacing text in files in subfolders of '{RootDirectoryPath}', replacing '{findWhat}' with '{replaceWith}'..."
                    )
                );

                ReplaceTextInFiles(
                    RootDirectoryPath, findWhat, replaceWith, pathFilter
                );

                OnStatusUpdate(
                    new StatusUpdateEventArgs(
                        $"*** Finished replacing text in files contained inside subfolders of '{RootDirectoryPath}'."
                    )
                );
            }
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
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref
        ///     name="rootDirectoryPath" />
        /// , is passed a blank or
        /// <see
        ///     langword="null" />
        /// string for a value.
        /// </exception>
        public void ProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null)
        {
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
        public void RenameFilesInFolder(string rootFolderPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null)
        {
            // write the name of the current class and method we are now
            // entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileRenamer.RenameFilesInFolder"
            );

            // Dump the parameter rootFolderPath to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameFilesInFolder: rootFolderPath = '{rootFolderPath}'"
            );

            // Dump the parameter findWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameFilesInFolder: findWhat = '{findWhat}'"
            );

            // Dump the parameter replaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.RenameFilesInFolder: replaceWith = '{replaceWith}'"
            );

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
                        OperationType.GettingListOfFilesToBeRenamed
                    )
                );

                /*
                 * First, we obtain the set of all files that need to be
                 * renamed.  Rules, that the user can define, are used to
                 * narrow the search.
                 */

                IEnumerable<IFileSystemEntry> entryCollection =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameFilesInFolder)
                        .AndAttachConfiguration(Configuration)
                        .UsingSearchPattern("*")
                        .WithSearchOption(SearchOption.AllDirectories)
                        .ToFindWhat(findWhat)
                        .AndReplaceItWith(replaceWith)
                        .GetMatchingFileSystemPaths(
                            RootDirectoryPath, pathFilter
                        );
                var entries = entryCollection.ToList();

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"*** INFO: {entries.Count} files found that might need to be renamed."
                );

                if (!entries.Any())
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.GettingListOfFilesToBeRenamed
                            )
                        );
                        return;
                    }

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.GettingListOfFilesToBeRenamed
                    )
                );

                OnFilesToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        entries.Count, OperationType.RenameFilesInFolder
                    )
                );

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.RenameFilesInFolder
                    )
                );

                foreach (var entry in entries)
                {
                    try
                    {
                        if (AbortRequested) break;

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                entry, OperationType.RenameFilesInFolder
                            )
                        );

                        var source = entry.Path;
                        if (string.IsNullOrWhiteSpace(source)) continue;
                        if (!File.Exists(source)) continue;

                        var destination = Path.Combine(
                            entry.ContainingFolder,
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
                             */
                            (string)GetTextReplacementEngine.For(
                                    OperationType.RenameFilesInFolder
                                )
                                .AndAttachConfiguration(Configuration)
                                .Replace(
                                    GetMatchExpressionFactory.For(
                                            OperationType.RenameFilesInFolder
                                        )
                                        .AndAttachConfiguration(Configuration)
                                        .ForTextValue(
                                            GetTextValueRetriever.For(
                                                    OperationType
                                                        .RenameFilesInFolder
                                                )
                                                .GetTextValue(entry)
                                        )
                                        .ToFindWhat(findWhat)
                                        .AndReplaceItWith(replaceWith)
                                )
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
                            OnFileRenamed(
                                new FileRenamedEventArgs(
                                    source, destination
                                )
                            );
                    }
                    catch (Exception ex)
                    {
                        OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
                        continue; /* explicit continue statement */
                    }

                    if (!AbortRequested)
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.RenameFilesInFolder
                            )
                        );
                }
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    "The operation has been aborted."
                );

            OnOperationFinished(
                new OperationFinishedEventArgs(
                    OperationType.RenameFilesInFolder
                )
            );
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
        public void RenameSubFoldersOf(string rootFolderPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null)
        {
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
                        OperationType.RenameSubFolders
                    )
                );

                // Build list of folders to be processed
                IEnumerable<IFileSystemEntry> entryCollection =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameSubFolders)
                        .AndAttachConfiguration(Configuration)
                        .UsingSearchPattern("*")
                        .WithSearchOption(SearchOption.AllDirectories)
                        .ToFindWhat(findWhat)
                        .AndReplaceItWith(replaceWith)
                        .GetMatchingFileSystemPaths(
                            RootDirectoryPath, pathFilter
                        );
                var entries = entryCollection.ToList();

                /*
                var subFolders = Directory
                    .GetDirectories(
                        rootFolderPath, "*", SearchOption.AllDirectories
                    ).Where(
                        dir => !ShouldSkipFolder(dir) &&
                               dir.Contains(findWhat) &&
                               !dir.Contains(replaceWith) &&
                               (pathFilter == null || pathFilter(dir))
                    ).ToList();
                */

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.RenameSubFoldersOf: {entries.Count} folders are to be renamed."
                );

                if (!entries.Any())
                    if (!AbortRequested)
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
                        return;
                    }

                OnSubfoldersToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        entries.Count, OperationType.RenameSubFolders
                    )
                );

                /*
                 * OKAY, this is the loop over the list of the subfolders
                 * whose pathnames match the search criteria specified by
                 * the user.  For each folder, rename it according to the
                 * settings specified by the user.
                 */

                foreach (var entry in entries)
                    try
                    {
                        if (AbortRequested) break;

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                entry, OperationType.RenameSubFolders
                            )
                        );

                        entry.ToDirectoryInfo()
                             .RenameTo(
                                 (string)GetTextReplacementEngine
                                         .For(OperationType.RenameSubFolders)
                                         .AndAttachConfiguration(Configuration)
                                         .Replace(
                                             (IMatchExpression)
                                             GetMatchExpressionFactory.For(
                                                     OperationType
                                                         .RenameSubFolders
                                                 )
                                                 .AndAttachConfiguration(
                                                     Configuration
                                                 )
                                                 .ForTextValue(
                                                     GetTextValueRetriever.For(
                                                             OperationType
                                                                 .RenameSubFolders
                                                         )
                                                         .GetTextValue(entry)
                                                 )
                                                 .ToFindWhat(findWhat)
                                                 .AndReplaceItWith(replaceWith)
                                         )
                             );
                    }
                    catch (Exception ex)
                    {
                        OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
                        continue; /* explicit continue statement */
                    }

                if (!AbortRequested)
                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.RenameSubFolders
                        )
                    );
            }
            catch (Exception ex)
            {
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    "The operation has been aborted."
                );
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
        public void ReplaceTextInFiles(string rootFolderPath, string findWhat,
            string replaceWith = "", Predicate<string> pathFilter = null)
        {
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

            IEnumerable<IFileSystemEntry> entryCollection =
                GetFileSystemEntryListRetriever
                    .For(OperationType.ReplaceTextInFiles)
                    .AndAttachConfiguration(Configuration)
                    .UsingSearchPattern("*")
                    .WithSearchOption(SearchOption.AllDirectories)
                    .ToFindWhat(findWhat)
                    .AndReplaceItWith(replaceWith)
                    .GetMatchingFileSystemPaths(RootDirectoryPath, pathFilter);
            var fileSystemEntries = entryCollection.ToList();

            DebugUtils.WriteLine(
                DebugLevel.Info,
                $"*** INFO: {fileSystemEntries.Count} files found that might have text in them that needs replacing."
            );

            if (!fileSystemEntries.Any())
                if (!AbortRequested)
                {
                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.ReplaceTextInFiles
                        )
                    );
                    return;
                }

            OnFilesToHaveTextReplacedCounted(
                new FilesOrFoldersCountedEventArgs(
                    fileSystemEntries.Count, OperationType.ReplaceTextInFiles
                )
            );

            try
            {
                foreach (var entry in fileSystemEntries)
                    try
                    {
                        if (AbortRequested) break;

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                entry, OperationType.ReplaceTextInFiles
                            )
                        );

                        string replacementData = GetTextReplacementEngine
                                                 .For(
                                                     OperationType
                                                         .ReplaceTextInFiles
                                                 )
                                                 .AndAttachConfiguration(
                                                     Configuration
                                                 )
                                                 .Replace(
                                                     (IMatchExpression)
                                                     GetMatchExpressionFactory
                                                         .For(
                                                             OperationType
                                                                 .ReplaceTextInFiles
                                                         )
                                                         .AndAttachConfiguration(
                                                             Configuration
                                                         )
                                                         .ForTextValue(
                                                             GetTextValueRetriever
                                                                 .For(
                                                                     OperationType
                                                                         .ReplaceTextInFiles
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

                        if (File.Exists(entry.Path))
                            File.Delete(entry.Path);

                        /*
                         * OKAY, check whether the replacement file data has zero byte length.
                         * If so, then the file-deletion operation above suffices to remove the
                         * file whose data is being replaced.
                         *
                         * We only will carry out the writing of data to the file on the disk
                         * in the event that the replacementData variable has more than zero byte
                         * length.  We are willing to write whitespace to the file, in order to
                         * support the Whitespace programming language.
                         */
                        if (!string.IsNullOrEmpty(replacementData))
                            File.WriteAllText(entry.Path, replacementData);
                    }
                    catch (Exception ex)
                    {
                        OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
                        continue; /* explicit continue statement */
                    }

                if (!AbortRequested)
                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.ReplaceTextInFiles
                        )
                    );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    "The operation has been aborted."
                );

            DebugUtils.WriteLine(
                DebugLevel.Info,
                "*** SUCCESS *** Text replacement in files operation completed successfully."
            );

            DebugUtils.WriteLine(
                DebugLevel.Debug, "FileRenamer.ReplaceTextInFiles: Done."
            );
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
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.", nameof(path)
                );
            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException(
                    $"The folder with path '{path}' could not be located.\n\nIt cannot be used as the new value of the FileRenamer.RootDirectoryPath property."
                );

            RootDirectoryPath = path;

            return this;
        }

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
        /// Raises the <see cref="E:MFR.FileRenamer.ExceptionRaised" /> event.
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
                                                     .FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED
                                             );

            /*
             * custom processing.
             *
             * Sometimes, .sln files (the ones we close and then open before and after the
             * operations) are renamed by the operations.
             *
             * We check if this is so.  If so, then we set the LastSolutionPath property
             * to the destination file name.
             */

            if (!".sln".Equals(Path.GetExtension(e.Source))) return;

            LastSolutionPath = e.Destination;
        }

        private static string GetFirstSolutionPathFoundInFolder(string folder)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                "In FileRenamer.GetFirstSolutionPathFoundInFolder"
            );

            // Dump the variable folder to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.GetFirstSolutionPathFoundInFolder: folder = '{folder}'"
            );

            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(folder)) return result;
            if (!Directory.Exists(folder)) return result;

            try
            {
                result = Enumerate.Files(
                                      folder, "*.sln",
                                      SearchOption.TopDirectoryOnly
                                  )
                                  .First();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.GetFirstSolutionPathFoundInFolder: Result = '{result}'"
            );

            return result;
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
        private void DoProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileRenamer.DoProcessAll"
            );

            // Dump the variable path to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.DoProcessAll: path = '{rootDirectoryPath}'"
            );

            // Dump the variable findWhat to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.DoProcessAll: findWhat = '{findWhat}'"
            );

            // Dump the variable replaceWith to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug,
                $"FileRenamer.DoProcessAll: replaceWith = '{replaceWith}'"
            );

            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootDirectoryPath)
                );

            try
            {
                /*
                 * Set the RootDirectoryPath property to the
                 * value that is passed in.
                 */

                RootDirectoryPath = rootDirectoryPath;

                if (!RootDirectoryValidator.IsValid(rootDirectoryPath))
                    return;

                OnStarted();

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.FindVisualStudio
                    )
                );

                DTE dte = null;

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.DoProcessAll: Checking whether there is an open Visual Studio Solution that should be closed..."
                );

                // This tool can potentially be run from Visual Studio (e.g.,
                // configured via the Tools menu as an external tool, for instance).

                // If the tool has been launched from an open instance of Visual
                // Studio, and if there exists an open instance of Visual Studio
                // that currently has the solution containing the items to be
                // renamed open, then close the solution automatically for the user.

                // Scan the folder in which we are starting for files ending with the
                // .sln extension.  If any of them are open in Visual Studio, mark
                // them all for reloading, and then reload them.

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.DoProcessAll: Searching for files ending in the *.sln file extension in the folder '{RootDirectoryPath}'..."
                );

                var solutionPath = GetFirstSolutionPathFoundInFolder(
                    RootDirectoryPath
                );

                if (string.IsNullOrWhiteSpace(solutionPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"FileRenamer.DoProcessAll: A Visual Studio Solution file could not be located in the folder '{RootDirectoryPath}'.  Stopping."
                    );
                    return;
                }

                if (!string.IsNullOrWhiteSpace(solutionPath) &&
                    File.Exists(solutionPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.DoProcessAll: Determining whether there is an active Visual Studio instance having the solution '{solutionPath}' open..."
                    );

                    // determine if the solution whose path has been determined
                    // above is currently open in an instance of Visual Studio. If
                    // it is, set the ShouldReOpenSolution property to TRUE and then
                    // attempt to form an automation connection to the instance of
                    // Visual Studio, if any, that is (a) currently open and (b)
                    // currently has the solution open
                    dte = VisualStudioManager.GetVsProcessHavingSolutionOpened(
                        solutionPath
                    );

                    ShouldReOpenSolution = dte != null;

                    // Dump the variable ShouldReOpenSolution to the log
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.DoProcessAll: ShouldReOpenSolution = {ShouldReOpenSolution}"
                    );

                    // Prior to beginning the operation(s) selected by the user,
                    // we'll then tell the instance of Visual Studio that has the
                    // solution containing the item(s) to be renamed open to close
                    // the solution and then we will instruct VS to re-open the
                    // solution once we're done processing the user's requested operation(s).
                }
                else if (Process.GetProcessesByName("devenv")
                                .Any())
                {
                    ShouldReOpenSolution = false;

                    // One or more copies of VS are open, but it would seem unlikely
                    // that any of them have the solution open (unless its name
                    // differs from the convention). In this event, prompt the user
                    // that if the file(s) they are renaming are part of a solution
                    // that is currently open in Visual Studio, that the user will
                    // need to re-load the solution by hand after the operation has
                    // been completed.

                    MessageBox.Show(
                        Resources.Confirm_PerformRename,
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                    );
                }

                OnOperationFinished(
                    new OperationFinishedEventArgs(
                        OperationType.FindVisualStudio
                    )
                );

                if (!string.IsNullOrWhiteSpace(solutionPath) &&
                    File.Exists(solutionPath))
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.DoProcessAll: Checking whether there is currently an instance of Visual Studio running that has the Solution file '{solutionPath}' open..."
                    );

                // If Visual Studio is open and it currently has the solution
                // open, then close the solution before we perform the rename operation.
                if (ShouldReOpenSolution && dte != null)
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Info,
                        $"FileRenamer.DoProcessAll: An instance of Visual Studio currently has the solution '{solutionPath}' open."
                    );

                    OnOperationStarted(
                        new OperationStartedEventArgs(
                            OperationType.CloseActiveSolution
                        )
                    );

                    OnStatusUpdate(
                        new StatusUpdateEventArgs(
                            "Closing solution containing item(s) to be processed..."
                        )
                    );

                    dte.Solution.Close();

                    /* Wait for the solution to be closed.
                    while (dte.Solution.IsOpen) Thread.Sleep(50);*/

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.CloseActiveSolution
                        )
                    );
                }

                InvokeProcessing(findWhat, replaceWith, pathFilter);

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    "FileRenamer.DoProcessAll: Checking whether we need to re-open the solution..."
                );

                // Since the pathname of the Solution file itself may have changed due to a file-rename
                // operation, re-scan the root directory for the solution path.

                DebugUtils.WriteLine(
                    DebugLevel.Info,
                    $"FileRenamer.DoProcessAll: Re-scanning the folder '{RootDirectoryPath}' for Solution files (in case a file's name was changed..."
                );

                solutionPath =
                    string.IsNullOrWhiteSpace(LastSolutionPath) ||
                    !File.Exists(LastSolutionPath)
                        ? GetFirstSolutionPathFoundInFolder(RootDirectoryPath)
                        : LastSolutionPath;

                if (string.IsNullOrWhiteSpace(solutionPath))
                {
                    DebugUtils.WriteLine(
                        DebugLevel.Error,
                        $"FileRenamer.DoProcessAll: A Visual Studio Solution file could not be located in the folder '{RootDirectoryPath}'.  Stopping."
                    );
                    return;
                }

                // Dump the variable solutionPath to the log
                DebugUtils.WriteLine(
                    DebugLevel.Debug,
                    $"FileRenamer.DoProcessAll: solutionPath = '{solutionPath}'"
                );

                // If Visual Studio is open and it currently has the solution
                // open, then close the solution before we perform the rename operation.
                if (ShouldReOpenSolution && dte != null)
                {
                    OnOperationStarted(
                        new OperationStartedEventArgs(
                            OperationType.OpenActiveSolution
                        )
                    );

                    OnStatusUpdate(
                        new StatusUpdateEventArgs(
                            "Instructing Visual Studio to reload the solution (maybe with its new path)..."
                        )
                    );

                    dte.Solution.Open(solutionPath);

                    /* Wait for the solution to be opened/loaded.
                    while (!dte.Solution.IsOpen) Thread.Sleep(50); */

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.OpenActiveSolution
                        )
                    );
                }
            }
            catch (OperationAbortedException)
            {
                AbortRequested = false;
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

            DebugUtils.WriteLine(
                DebugLevel.Debug, "FileRenamer.DoProcessAll: Done."
            );
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
        private void InvokeProcessing(string findWhat, string replaceWith,
            Predicate<string> pathFilter)
        {
            // write the name of the current class and method we are now entering, into the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, "In FileRenamer.InvokeProcessing"
            );

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
                ProcessAll(findWhat, replaceWith, pathFilter);
            else
            {
                var guid = Guid.NewGuid()
                               .ToString("N");

                ProcessAll(findWhat, guid, pathFilter);
                ProcessAll(guid, replaceWith, pathFilter);
            }

            DebugUtils.WriteLine(
                DebugLevel.Debug, "FileRenamer.InvokeProcessing: Done."
            );
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.FileRenamer.FilesToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
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
        ///     cref="E:MFR.FileRenamer.FilesToHaveTextReplacedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnFilesToHaveTextReplacedCounted(
            FilesOrFoldersCountedEventArgs e)
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
            Finished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.NoArgs()
                       .ForMessageId(FileRenamerMessages.FRM_FINISHED);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.FileRenamer.OperationFinished" /> event.
        /// </summary>
        /// <param name="e">
        /// An <see cref="T:MFR.OperationFinishedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnOperationFinished(OperationFinishedEventArgs e)
        {
            OperationFinished?.Invoke(this, e);
            SendMessage<OperationFinishedEventArgs>.Having.Args(this, e)
                                                   .ForMessageId(
                                                       FileRenamerMessages
                                                           .FRM_OPERATION_FINISHED
                                                   );
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.FileRenamer.OperationStarted" /> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.OperationStartedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnOperationStarted(OperationStartedEventArgs e)
        {
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

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MFR.Renamers.Files.FileRenamer.Started" />
        /// event.
        /// </summary>
        private void OnStarted()
        {
            Started?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(FileRenamerMessages.FRM_STARTED);
        }

        /// <summary>
        /// Raises the <see cref="E:MFR.FileRenamer.StatusUpdate" /> event.
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
        ///     cref="E:MFR.FileRenamer.SubfoldersToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.FilesOrFoldersCountedEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnSubfoldersToBeRenamedCounted(
            FilesOrFoldersCountedEventArgs e)
        {
            SubfoldersToBeRenamedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_SUBFOLDERS_TO_BE_RENAMED_COUNTED
                );
        }
    }
}