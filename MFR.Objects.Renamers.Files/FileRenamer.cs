using MFR.GUI.Events;
using MFR.Objects.Configuration;
using MFR.Objects.Constants;
using MFR.Objects.Events;
using MFR.Objects.Events.Common;
using MFR.Objects.Operations.Events;
using MFR.Objects.Renamers.Files.Interfaces;
using MFR.Objects.Renamers.Files.Properties;
using PostSharp.Patterns.Diagnostics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Mime;
using xyLOGIX.Core.Extensions;
using xyLOGIX.Queues.Messages;
using Process = System.Diagnostics.Process;
using Thread = System.Threading.Thread;

namespace MFR.Objects.Renamers.Files
{
    /// <summary>
    /// Provides file- and folder-rename services.
    /// </summary>
    /// <remarks>
    /// NOTE: Instances of this class must be composed with an instance of an
    /// object that implements the <see
    /// cref="T:MFR.Objects.IConfiguration"/> interface.
    /// <para/>
    /// Such an object is necessary because it provides settings specified by
    /// the user that change the behavior of this object.
    /// </remarks>
    public class FileRenamer : ConfigurationComposedObjectBase, IFileRenamer
    {
        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Objects.Renamers.Files.FileRenamer"/> and returns a
        /// reference to it.
        /// </summary>
        public FileRenamer()
        {
            RootDirectoryPath = string.Empty;
        }

        /// <summary>
        /// Constructs a new instance of <see
        /// cref="T:MFR.Objects.Renamers.Files.FileRenamer"/> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        public FileRenamer(string rootDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootDirectoryPath)
                );

            RootDirectoryPath = rootDirectoryPath;
        }

        /// <summary>
        /// Occurs when an exception is thrown from an operation.
        /// </summary>
        public event ExceptionRaisedEventHandler ExceptionRaised;

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
        /// Occurs when a file system entry (e.g., a file or a folder) does not
        /// meet the criteria for being included in an operation.
        /// </summary>
        public event FileSystemEntrySkippedEventHandler FileSystemEntrySkipped;

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
        /// Gets a value that indicates whether an abort of the current
        /// operation has been requested.
        /// </summary>
        public bool AbortRequested
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
        /// Gets a reference to a collection of of the <see
        /// cref="T:MFR.Objects.OperationType"/> values.
        /// </summary>
        /// <remarks>
        /// All the values in this collection identify operations that the user
        /// wishes to perform.
        /// <para/>
        /// This list should be cleared after every run.
        /// <para/>
        /// If the list is empty when the <see
        /// cref="M:MFR.Objects.FileRenamer.ProcessAll"/> method is
        /// called, do nothing or throw an exception.
        /// </remarks>
        protected IList<OperationType> EnabledOperations
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value determining whether the currently-open solution
        /// in Visual Studio should be closed and then re-opened at the
        /// completion of the operation.
        /// </summary>
        private bool ShouldReOpenSolution
        {
            get;
            set;
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
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.ExceptionRaised"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Objects.ExceptionRaisedEventArgs"/>
        /// that contains the event data.
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
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname stored in the <see
        /// cref="P:MFR.Objects.FileRenamer.RootDirectoryPath"/> property.
        /// </summary>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
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
        
        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname specified by the <paramref name="rootDirectoryPath"/> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter, <paramref
        /// name="rootDirectoryPath"/>, is passed a blank or <see
        /// langword="null"/> string for a value.
        /// </exception>
        public void ProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Predicate<string> pathFilter = null)
        {
            if (string.IsNullOrWhiteSpace(rootDirectoryPath))
                throw new ArgumentException(
                    "Value cannot be null or whitespace.",
                    nameof(rootDirectoryPath)
                );

            MessageFilter.Register();

            RootDirectoryPath = rootDirectoryPath;

            OnStarted();

            OnOperationStarted(
                new OperationStartedEventArgs(OperationType.FindVisualStudio)
            );

            DTE dte = null;

            // This tool can potentially be run from Visual Studio (e.g.,
            // configured via the Tools menu as an external tool, for instance).

            // If the tool has been launched from an open instance of Visual
            // Studio, and if there exists an open instance of Visual Studio
            // that currently has the solution containing the items to be
            // renamed open, then close the solution automatically for the user.

            // Assume that, by convention, if the root directory path is
            // C:\temp, then the path to the solution is C:\temp\temp.sln. If
            // this is not the case, then the solution will have to be reloaded
            // manually by the user.

            var solutionPathByConvention = Path.Combine(
                RootDirectoryPath, Path.GetFileName(RootDirectoryPath) + ".sln"
            );
            if (File.Exists(solutionPathByConvention))
            {
                // determine if the solution whose path has been determined
                // above is currently open in an instance of Visual Studio. If
                // it is, set the ShouldReOpenSolution property to TRUE and then
                // attempt to form an automation connection to the instance of
                // Visual Studio, if any, that is (a) currently open and (b)
                // currently has the solution open
                dte = VisualStudioManager.GetVsProcessHavingSolutionOpened(
                    solutionPathByConvention
                );
                ShouldReOpenSolution = dte != null;

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
                    Resources.Confirm_PerformRename, MediaTypeNames.Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
            }

            OnOperationFinished(
                new OperationFinishedEventArgs(OperationType.FindVisualStudio)
            );

            try
            {
                // If Visual Studio is open and it currently has the solution
                // open, then close the solution before we perform the rename operation.
                if (ShouldReOpenSolution && dte != null)
                {
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

                    /* Wait for the solution to be closed. */
                    while (dte.Solution.IsOpen) Thread.Sleep(50);

                    OnOperationFinished(
                        new OperationFinishedEventArgs(
                            OperationType.CloseActiveSolution
                        )
                    );
                }

                InvokeProcessing(findWhat, replaceWith, pathFilter);

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
                            "Instructing Visual Studio to reload the solution..."
                        )
                    );

                    dte.Solution.Open(solutionPathByConvention);

                    /* Wait for the solution to be opened/loaded. */
                    while (!dte.Solution.IsOpen) Thread.Sleep(50);

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
            finally
            {
                OnFinished();
            }

            MessageFilter.Revoke();
        }

        /// <summary>
        /// Renames all the files in the all the subfolders etc., recursively,
        /// of the folder whose pathname is specified by the <paramref
        /// name="rootFolderPath"/> parameter.
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
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/>, <paramref
        /// name="findWhat"/> , or <paramref name="replaceWith"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
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

                IEnumerable<IFileSystemEntry> entryCollection =
                    GetFileSystemEntryListRetriever
                        .For(OperationType.RenameFilesInFolder)
                        .AndAttachConfiguration(Objects.Configuration)
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

                        entry.ToFileInfo()
                             .RenameTo(
                                 Path.Combine(
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
                                      * Folder property is filled during its construction.)
                                      */
                                     (string)GetTextReplacementEngine.For(
                                             OperationType.RenameFilesInFolder
                                         )
                                         .AndAttachConfiguration(Objects.Configuration)
                                         .Replace(
                                             GetMatchExpressionFactory.For(
                                                     OperationType
                                                         .RenameFilesInFolder
                                                 )
                                                 .AndAttachConfiguration(
                                                     Objects.Configuration
                                                 )
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
        /// pathname specified by <paramref name="rootFolderPath"/>, replacing
        /// any occurrences of the text in the <paramref name="findWhat"/>
        /// parameter with the values in the <paramref name="replaceWith"/> parameter.
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
        /// by <paramref name="findWhat"/> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/>, <paramref
        /// name="findWhat"/> , or <paramref name="replaceWith"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
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
                        .AndAttachConfiguration(Objects.Configuration)
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
                                         .AndAttachConfiguration(Objects.Configuration)
                                         .Replace(
                                             (IMatchExpression)
                                             GetMatchExpressionFactory.For(
                                                     OperationType
                                                         .RenameSubFolders
                                                 )
                                                 .AndAttachConfiguration(
                                                     Objects.Configuration
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
        /// folder with pathname <paramref name="rootFolderPath"/> and replacing
        /// every occurrence of the text specified by the <paramref
        /// name="findWhat"/> parameter with the text specified by the <paramref
        /// name="replaceWith"/> parameter. A case-sensitive, not-in-exact-word
        /// search is performed.
        /// </summary>
        /// <param name="rootFolderPath">
        /// (Required.) Pathname of the folder where the operation is to start.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) Text to be found in each file contained in the directory tree.
        /// </param>
        /// <param name="replaceWith">
        /// (Optional.) Text to replace all the instances of <paramref
        /// name="findWhat"/> with. If this parameter is blank (the default),
        /// then the text is deleted.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func"/>
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true"/> if the file
        /// should be included in the operation or <see langword="false"/> otherwise.
        /// <para/>
        /// This parameter is <see langword="null"/> by default. This method
        /// should return <see langword="true"/> to specify that a given
        /// file-system entry is to be included in the output collection --
        /// barring other inclusion/exclusion criteria.
        /// <para/>
        /// In the event that this parameter is <see langword="null"/>, no path
        /// filtering is done.
        /// </param>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if either the <paramref name="rootFolderPath"/> or the
        /// <paramref name="findWhat"/> parameters are blank.
        /// </exception>
        /// <exception cref="T:System.IO.DirectoryNotFoundException">
        /// Thrown if the folder with pathname specified by the <paramref
        /// name="rootFolderPath"/> does not exist.
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
                    .AndAttachConfiguration(Objects.Configuration)
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
                                                     Objects.Configuration
                                                 )
                                                 .Replace(
                                                     (IMatchExpression)
                                                     GetMatchExpressionFactory
                                                         .For(
                                                             OperationType
                                                                 .ReplaceTextInFiles
                                                         )
                                                         .AndAttachConfiguration(
                                                             Objects.Configuration
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

        public void RequestAbort()
                    => AbortRequested = true;

        /// <summary>
        /// Initializes the value of the <see
        /// cref="P:MFR.Objects.IFileRenamer.RootDirectoryPath"/>
        /// property to the value specified in the <paramref
        /// name="rootDirectoryPath"/> parameter.
        /// <para/>
        /// The value is the starting location of the search operations.
        /// </summary>
        /// <returns>
        /// Reference to the same instance of the object that called this
        /// method, for fluent use.
        /// </returns>
        [Log(AttributeExclude = true)]
        public IFileRenamer StartingFrom(string rootDirectoryPath)
        {
            RootDirectoryPath = rootDirectoryPath;

            return this;
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
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.FilesToBeRenamedCounted"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:MFR.Objects.FilesOrFoldersCountedEventArgs"/>
        /// that contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
        private void OnFilesToBeRenamedCounted(FilesOrFoldersCountedEventArgs e)
        {
            FilesToBeRenamedCounted?.Invoke(this, e);
            SendMessage<FilesOrFoldersCountedEventArgs>.Having.Args(this, e)
                .ForMessageId(
                    FileRenamerMessages.FRM_FILES_TO_BE_RENAMED_COUNTED
                );
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.FilesToHaveTextReplacedCounted"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:MFR.Objects.FilesOrFoldersCountedEventArgs"/>
        /// that contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
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
        /// Raises the <see
        /// cref="E:MFR.Objects.Renamers.Files.FileRenamer.Finished"/> event.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.NoArgs()
                       .ForMessageId(FileRenamerMessages.FRM_FINISHED);
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.OperationFinished"/> event.
        /// </summary>
        /// <param name="e">
        /// An <see
        /// cref="T:MFR.Objects.OperationFinishedEventArgs"/> that
        /// contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
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
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.OperationStarted"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Objects.OperationStartedEventArgs"/>
        /// that contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
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
        /// Raises the <see
        /// cref="E:MFR.Objects.ProcessingOperation"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:MFR.Objects.ProcessingOperationEventArgs"/> that
        /// contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
        private void OnProcessingOperation(ProcessingOperationEventArgs e)
        {
            ProcessingOperation?.Invoke(this, e);
            SendMessage<ProcessingOperationEventArgs>.Having.Args(this, e)
                .ForMessageId(FileRenamerMessages.FRM_PROCESSING_OPERATION);
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.Objects.Renamers.Files.FileRenamer.Started"/> event.
        /// </summary>
        [Log(AttributeExclude = true)]
        private void OnStarted()
        {
            Started?.Invoke(this, EventArgs.Empty);
            SendMessage.Having.Args(this, EventArgs.Empty)
                       .ForMessageId(FileRenamerMessages.FRM_STARTED);
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.StatusUpdate"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MFR.Objects.StatusUpdateEventArgs"/> that
        /// contains the event data.
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
        /// Raises the <see
        /// cref="E:MFR.Objects.FileRenamer.SubfoldersToBeRenamedCounted"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:MFR.Objects.FilesOrFoldersCountedEventArgs"/>
        /// that contains the event data.
        /// </param>
        [Log(AttributeExclude = true)]
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