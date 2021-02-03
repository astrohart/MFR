using System.IO;

namespace MassFileRenamer.Objects
{
   public static class FolderPathValidator
   {
      public static bool PathContains(string folderPath, string findWhat)
      {
         return folderPath.Contains(findWhat);
      }

      public static bool ShouldSkipFolder(string folderPath)
      {
         return string.IsNullOrWhiteSpace(folderPath) ||
                !Directory.Exists(folderPath) ||
                folderPath.Contains("packages") ||
                folderPath.Contains(".git") || folderPath.Contains(".vs") ||
                folderPath.Contains(@"\bin") || folderPath.Contains(@"\obj") ||
                Path.GetFileName(folderPath).StartsWith(".");
      }
   }
}