namespace MFR.Operations.Constants
{
    /// <summary>
    /// Specifies the type of operation now being performed.
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// Checking the starting folder that has been selected to ensure that it or one or
        /// more of its subfolders contain Visual Studio Solution (*.sln) files.
        /// </summary>
        CheckingWhetherChosenFolderContainsSolutions = 11,

        /// <summary>
        /// Gathering a list of the top-level subfolders of the current folder.
        /// </summary>
        GetTopLevelSubFolders = 10,

        /// <summary>
        /// Searches a specified folder for the paths of all the <c>*.sln</c> files within
        /// it.
        /// <para />
        /// For each <c>*.sln</c> file found, opens it in its own separate instance of
        /// Visual Studio.
        /// </summary>
        LoadAllSolutionsInFolder = 3,

        /// <summary>
        /// Unloads all <c>*.sln</c> files in a given folder, that are currently loaded
        /// in running instances of Visual Studio.
        /// </summary>
        UnloadAllSolutionsInFolder = 4,

        /// <summary>
        /// Closes the active solution in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        CloseActiveSolution = 5,

        /// <summary>
        /// Finds the instance of Visual Studio that has the solution open.
        /// </summary>
        /// <remarks>
        /// The particular solution is that which exists in the starting (root) folder.
        /// </remarks>
        FindVisualStudio = 6,

        /// <summary>
        /// The list of file system entries to be renamed is being retrieved.
        /// </summary>
        GettingListOfFilesToBeRenamed = 7,

        /// <summary>
        /// Open the solution back up in Visual Studio.
        /// </summary>
        /// <remarks>
        /// The "active" solution is defined as that which exists as a
        /// <c>.sln</c> file in the starting (root) folder.
        /// </remarks>
        OpenActiveSolution = 8,

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
        /// We are searching for ALL files with the extension *.sln in a specific directory
        /// tree.
        /// </summary>
        GetListOfAllSolutionFilesInDirectoryTree = 9,

        /// <summary>
        /// Unknown operation type.
        /// </summary>
        Unknown = -1
    }
}
