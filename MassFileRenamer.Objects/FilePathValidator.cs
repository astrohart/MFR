using System.IO;

namespace MassFileRenamer.Objects
{
   public static class FilePathValidator
   {
      public static bool ShouldSkipFile(string filePath)
      {
         return string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath) ||
                filePath.Contains("packages") || filePath.Contains(".git") ||
                filePath.Contains(".vs") || filePath.Contains(@"\bin") ||
                filePath.Contains(@"\obj") ||
                Path.GetFileName(filePath).StartsWith(".");
      }
   }
}