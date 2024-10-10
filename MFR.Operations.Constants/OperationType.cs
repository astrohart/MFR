namespace MFR.Operations.Constants
{
    /// <summary>
    /// Specifies the type of operation now being performed.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// The list of file system entries to be renamed is being retrieved.
        /// </summary>
        CalculateListOfFilesToBeRenamed = 8,

        /// <summary>
        /// Checking the starting folder that has been selected to ensure that it or one or
        /// more of its subfolders contain Visual Studio Solution (*.sln) files.
        /// </summary>
        CheckingWhetherChosenFolderContainsSolutions = 12,

        /// <summary>
        /// Iterates over the root directory's files and removes <c>NUL</c> character(s)
        /// that may be present in any of the text file(s) touched by this application.
        /// </summary>
        CleanFiles = 16,

        /// <summary>
        /// Closes the active solution in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        CloseActiveSolutions = 5,

        /// <summary>
        /// Commits the user's existing pending changes to the user's local Git repository
        /// (if one is present in the starting folder) prior to the commencement of
        /// operation processing.
        /// </summary>
        CommitPendingChanges = 6,

        /// <summary>
        /// Commits the results of the processing of operations to the user's local Git
        /// repository (if one is present in the starting folder) prior to the commencement
        /// of operations.
        /// </summary>
        CommitResultsToGit = 15,

        /// <summary>
        /// Finds the instance of Visual Studio that has the solution open.
        /// </summary>
        /// <remarks>
        /// The particular solution is that which exists in the starting (root) folder.
        /// </remarks>
        FindVisualStudio = 7,

        /// <summary>
        /// The application is loading configuration and profiles and such.
        /// </summary>
        InitializeApplication = 13,

        /// <summary>
        /// Gathering a list of the top-level subfolders of the current folder.
        /// </summary>
        ListTopLevelSubFolders = 11,

        /// <summary>
        /// Searches a specified folder for the paths of all the <c>*.sln</c> files within
        /// it.
        /// <para />
        /// For each <c>*.sln</c> file found, opens it in its own separate instance of
        /// Visual Studio.
        /// </summary>
        LoadAllSolutionsInFolder = 14,

        /// <summary>
        /// Unloads all <c>*.sln</c> files in a given folder, that are currently loaded
        /// in running instances of Visual Studio.
        /// </summary>
        UnloadAllSolutionsInFolder = 4,

        /// <summary>
        /// Open the solution back up in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        OpenActiveSolutions = 9,

        /// <summary>
        /// We are replacing text values in the names of files.
        /// </summary>
        RenameFilesInFolder = 0,

        /// <summary>
        /// We are replacing text in the content of the files.
        /// </summary>
        ReplaceTextInFiles = 2,

        /// <summary>
        /// We are replacing text in the names of folders.
        /// </summary>
        RenameSubFolders = 1,

        /// <summary>
        /// The folder in which the containing Solution is itself being renamed.
        /// </summary>
        RenameSolutionFolders = 3,

        /// <summary>
        /// We are searching for ALL files with the extension *.sln in a specific directory
        /// tree.
        /// </summary>
        ScanDirectoryTreeForSolutionFiles = 10,

        /// <summary>
        /// Unknown operation type.
        /// </summary>
        Unknown = -1
    }
}