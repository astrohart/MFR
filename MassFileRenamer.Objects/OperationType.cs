namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Specifies the type of operation now being performed.
    /// </summary>
    public enum OperationType
    {
        FindVisualStudio,
        CloseActiveSolution,
        OpenActiveSolution,
        RenameFilesInFolder,
        ReplaceTextInFiles,
        RenameSubFolders
    }
}