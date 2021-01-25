namespace MassFileRenamer.Objects
{
   public interface IFileRenamer
   {
      string RootDirectoryPath { get; }

      void ProcessAll(string findWhat, string replaceWith);

      void RenameFilesInFolder(string path, string findWhat, string replaceWith);

      void RenameSubFoldersOf(string path, string findWhat, string replaceWith);

      void ReplaceTextInFiles(string rootFolderPath, string findWhat, string replaceWith);
   }
}