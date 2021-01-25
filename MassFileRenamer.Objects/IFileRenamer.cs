namespace MassFileRenamer.Objects
{
   public interface IFileRenamer
   {
      string RootDirectoryPath { get; }

      void ProcessAll(string findWhat, string replaceWith);

      void RenameFilesInFolder(string rootFolderPath, string findWhat, string replaceWith);

      void RenameSubFoldersOf(string rootFolderPath, string findWhat, string replaceWith);

      void ReplaceTextInFiles(string rootFolderPath, string findWhat, string replaceWith);
   }
}