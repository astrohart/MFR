using EnvDTE;
using MassFileRenamer.Objects.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Process = System.Diagnostics.Process;
using Thread = System.Threading.Thread;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides file- an folder-rename services.
    /// </summary>
    public class FileRenamer : IFileRenamer
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileRenamer" />
        /// and returns a
        /// reference to it.
        /// </summary>
        public FileRenamer()
        {
            RootDirectoryPath = string.Empty;
        }

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileRenamer" />
        /// and returns a
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
        /// Gets a value that indicates whether an abort of the current
        /// operation has been requested.
        /// </summary>
        public bool AbortRequested
        {
            get;
            private set;
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
        /// Gets a string containing the full pathname of the folder where all
        /// operations start.
        /// </summary>
        public string RootDirectoryPath
        {
            get;
            private set;
        }

        /// <summary>
        /// Executes the Rename Subfolders, Rename Files, and Replace Text in
        /// Files operation on all the folders and files in the root folder with
        /// the pathname stored in the
        /// <see
        ///     cref="P:MassFileRenamer.Objects.FileRenamer.RootDirectoryPath" />
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
        /// (Optional.) If specified, a delegate that accepts as its sole
        /// parameter a string containing the pathname to the item currently
        /// being processed, and that returns a Boolean value. If the value
        /// returned is <c>true</c>, the item with the pathname matching that of
        /// the input is included in the operations; <c>false</c> means the item
        /// is excluded.
        /// </param>
        public void ProcessAll(string findWhat, string replaceWith,
            Func<string, bool> pathFilter = null)
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
        /// the pathname specified by the <paramref name="rootDirectoryPath" /> parameter.
        /// </summary>
        /// <param name="rootDirectoryPath">
        /// Path to the recursion root.
        /// </param>
        /// <param name="findWhat">
        /// (Required.) String containing the text to search for.
        /// </param>
        /// <param name="replaceWith">
        /// (Required.) String containing the text to replace the text specified
        /// by <paramref name="findWhat" /> with.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) If specified, a delegate that accepts as its sole
        /// parameter a string containing the pathname to the item currently
        /// being processed, and that returns a Boolean value. If the value
        /// returned is <c>true</c>, the item with the pathname matching that of
        /// the input is included in the operations; <c>false</c> means the item
        /// is excluded.
        /// </param>
        public void ProcessAll(string rootDirectoryPath, string findWhat,
            string replaceWith, Func<string, bool> pathFilter = null)
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
                    Path.Combine(
                        RootDirectoryPath,
                        Path.GetFileName(RootDirectoryPath) + ".sln"
                    )
                );
                ShouldReOpenSolution = dte != null;

                // Prior to beginning the operation(s) selected by the user,
                // we'll then tell the instance of Visual Studio that has the
                // solution containing the item(s) to be renamed open to close
                // the solution and then we will instruct VS to re-open the
                // solution once we're done processing the user's requested operation(s).
            }
            else if (Process.GetProcessesByName("devenv").Any())
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
                    Resources.Confirm_PerformRename, Application.ProductName,
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

                /*
                if (findWhat.Contains(replaceWith) ||
                    replaceWith.Contains(findWhat))
                {
                    /* If the findWhat and/or replaceWith contain substrings of each other,
                       then first replace findWhat -> some GUID and then that GUID -> replaceWith

                    var someGuid = Guid.NewGuid().ToString("N");

                    ProcessAll(findWhat, someGuid, pathFilter);

                    ProcessAll(someGuid, replaceWith, pathFilter);
                }
                else
                    */
                ProcessAll(findWhat, replaceWith, pathFilter);

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
        /// (Optional.) If specified, a delegate that accepts as its sole
        /// parameter a string containing the pathname to the item currently
        /// being processed, and that returns a Boolean value. If the value
        /// returned is <c>true</c>, the item with the pathname matching that of
        /// the input is included in the operations; <c>false</c> means the item
        /// is excluded.
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
            string replaceWith, Func<string, bool> pathFilter = null)
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
                        OperationType.RenameFilesInFolder
                    )
                );

                OnOperationStarted(
                    new OperationStartedEventArgs(
                        OperationType.GettingListOfFilesToBeRenamed
                    )
                );

                var filenames = Directory
                    .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
                    .Where(file => !ShouldSkipFile(file) &&
                                   (findWhat.Contains(replaceWith) ||
                                        OnTestExpressionMatchRequested(new
                                            TestExpressionMatchRequestedEventArgs(
                                           file, findWhat, OperationType.RenameFilesInFolder)
                                       ))).ToList();
                if (!filenames.Any())
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.RenameFilesInFolder
                            )
                        );
                        return;
                    }

                OnFilesToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        filenames.Count, OperationType.RenameFilesInFolder
                    )
                );

                foreach (var filename in filenames.Where(
                    filename => pathFilter == null || pathFilter(filename)
                ))
                {
                    try
                    {
                        if (AbortRequested) break;

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                filename, OperationType.RenameFilesInFolder
                            )
                        );

                        var directoryName = Path.GetDirectoryName(filename);
                        if (string.IsNullOrWhiteSpace(directoryName)) continue;

                        FileInfoFactory.Make(filename).RenameTo(
                            Path.Combine(
                                directoryName,
                                Path.GetFileName(filename).Replace(
                                    findWhat, replaceWith
                                )
                            )
                        );
                        ;
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
        /// (Optional.) If specified, a delegate that accepts as its sole
        /// parameter a string containing the pathname to the item currently
        /// being processed, and that returns a Boolean value. If the value
        /// returned is <c>true</c>, the item with the pathname matching that of
        /// the input is included in the operations; <c>false</c> means the item
        /// is excluded.
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
            string replaceWith, Func<string, bool> pathFilter = null)
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
                var subFolders = new List<string>();

                foreach (var folder in Directory.GetDirectories(
                    rootFolderPath, "*", SearchOption.AllDirectories
                ))
                {
                    if (ShouldSkipFolder(folder)) continue;

                    if (!folder.Contains(findWhat)) continue;
                    if (!findWhat.Contains(replaceWith) &&
                        folder.Contains(replaceWith)) continue;
                    if (pathFilter != null && !pathFilter(folder)) continue;

                    subFolders.Add(folder);
                }

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

                if (!subFolders.Any())
                    if (!AbortRequested)
                    {
                        OnOperationFinished(
                            new OperationFinishedEventArgs(
                                OperationType.RenameSubFolders
                            )
                        );
                        return;
                    }

                OnSubfoldersToBeRenamedCounted(
                    new FilesOrFoldersCountedEventArgs(
                        subFolders.Count, OperationType.RenameSubFolders
                    )
                );

                foreach (var folder in subFolders)
                    try
                    {
                        if (AbortRequested) break;

                        var dirInfo = new DirectoryInfo(folder);

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                dirInfo.FullName, OperationType.RenameSubFolders
                            )
                        );

                        dirInfo.RenameTo(
                            Path.Combine(
                                dirInfo.Parent.FullName,
                                dirInfo.Name.Replace(findWhat, replaceWith)
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
        /// parameter. A case-sensitive, not-in-whole-word
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
            string replaceWith = "", Func<string, bool> pathFilter = null)
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

            var filenames = Directory
                .GetFiles(rootFolderPath, "*", SearchOption.AllDirectories)
                .Where(
                    file => !ShouldSkipFile(file) &&
                            (pathFilter == null || pathFilter(file))
                ).ToList();

            if (!filenames.Any())
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
                    filenames.Count, OperationType.ReplaceTextInFiles
                )
            );

            try
            {
                foreach (var filename in filenames)
                    try
                    {
                        if (AbortRequested) break;

                        OnProcessingOperation(
                            new ProcessingOperationEventArgs(
                                filename, OperationType.ReplaceTextInFiles
                            )
                        );

                        var text = File.ReadAllText(filename);
                        if (!text.Contains(findWhat))
                            continue;

                        text = text.Replace(findWhat, replaceWith);

                        if (File.Exists(filename))
                            File.Delete(filename);

                        File.WriteAllText(filename, text);
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
                OnExceptionRaised(new ExceptionRaisedEventArgs(ex));
            }

            if (AbortRequested)
                throw new OperationAbortedException(
                    "The operation has been aborted."
                );
        }

        public void RequestAbort()
            => AbortRequested = true;

        /// <summary>
        /// Occurs when we need the client of this class to perform a match on a
        /// filename for us.
        /// </summary>
        public event TestExpressionMatchRequestedEventHandler TestExpressionMatchRequested;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.ExceptionRaised" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.ExceptionRaisedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnExceptionRaised(ExceptionRaisedEventArgs e)
            => ExceptionRaised?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.TestExpressionMatchRequested" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.TestExpressionMatchRequestedEventArgs" />
        /// that contains the event data.
        /// </param>
        /// <returns>
        /// <code>True</code>
        /// if the filename presented matches according to the textual criteria
        /// set by the client, or <c>false</c> otherwise.
        /// </returns>
        protected virtual bool OnTestExpressionMatchRequested(
            TestExpressionMatchRequestedEventArgs e)
        {
            if (TestExpressionMatchRequested == null)
                return false;

            TestExpressionMatchRequested?.Invoke(this, e);
            return e.DoesMatch;
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.FilesToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnFilesToBeRenamedCounted(FilesOrFoldersCountedEventArgs e)
            => FilesToBeRenamedCounted?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.FilesToHaveTextReplacedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnFilesToHaveTextReplacedCounted(
            FilesOrFoldersCountedEventArgs e)
            => FilesToHaveTextReplacedCounted?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileSystemEntrySkippedEventHandler.FileSystemEntrySkipped" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FileSystemEntrySkippedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnFileSystemEntrySkipped(FileSystemEntrySkippedEventArgs e)
            => FileSystemEntrySkipped?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.Finished" />
        /// event.
        /// </summary>
        private void OnFinished()
            => Finished?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.OperationFinished" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// An
        /// <see
        ///     cref="T:MassFileRenamer.Objects.OperationFinishedEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        private void OnOperationFinished(OperationFinishedEventArgs e)
            => OperationFinished?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.OperationStarted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.OperationStartedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnOperationStarted(OperationStartedEventArgs e)
            => OperationStarted?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.ProcessingOperation" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.ProcessingOperationEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        private void OnProcessingOperation(ProcessingOperationEventArgs e)
            => ProcessingOperation?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.Started" />
        /// event.
        /// </summary>
        private void OnStarted()
            => Started?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.StatusUpdate" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A <see cref="T:MassFileRenamer.Objects.StatusUpdateEventArgs" /> that
        /// contains the event data.
        /// </param>
        private void OnStatusUpdate(StatusUpdateEventArgs e)
            => StatusUpdate?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:MassFileRenamer.Objects.FileRenamer.SubfoldersToBeRenamedCounted" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:MassFileRenamer.Objects.FilesOrFoldersCountedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnSubfoldersToBeRenamedCounted(
            FilesOrFoldersCountedEventArgs e)
            => SubfoldersToBeRenamedCounted?.Invoke(this, e);

        private bool PathAlreadyContains(FileSystemInfo entry, string findWhat)
        {
            if (entry == null)
                return false;

            if (!entry.Exists)
                return false;

            if (string.IsNullOrWhiteSpace(findWhat))
                return false;

            var result = FolderPathValidator.PathContains(entry.Name, findWhat);
            if (!result)
                OnFileSystemEntrySkipped(
                    new FileSystemEntrySkippedEventArgs(entry.FullName)
                );
            return result;
        }

        /// <summary>
        /// Alias for the
        /// <see
        ///     cref="M:MassFileRenamer.Objects.FilePathValidator.ShouldSkipFile" />
        /// method.
        /// </summary>
        /// <param name="file">
        /// (Required.) String containing the path of the file whose path should
        /// checked against exclusion rules.
        /// </param>
        /// <returns>
        /// If the file should not be processed, then this method returns
        /// <c>true</c>. Otherwise, the value <c>false</c> is returned, which
        /// signifies that the file is to be included in the operation(s).
        /// </returns>
        private bool ShouldSkipFile(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
                return true;

            var result = FilePathValidator.ShouldSkipFile(file);
            if (result)
                OnFileSystemEntrySkipped(
                    new FileSystemEntrySkippedEventArgs(file)
                );
            return result;
        }

        private bool ShouldSkipFolder(string dir)
        {
            if (string.IsNullOrWhiteSpace(dir))
                return true;

            var result = FolderPathValidator.ShouldSkipFolder(dir);
            if (result)
                OnFileSystemEntrySkipped(
                    new FileSystemEntrySkippedEventArgs(dir)
                );
            return result;
        }
    }
}