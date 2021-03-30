namespace MFR.Objects
{
    /// <summary>
    /// Specifies the type of operation now being performed.
    /// </summary>
    public enum OperationType
    {
        CloseActiveSolution,
        FindVisualStudio,
        GettingListOfFilesToBeRenamed,
        OpenActiveSolution,
        RenameFilesInFolder,
        ReplaceTextInFiles,
        RenameSubFolders,
        Unknown = -1
    }
}