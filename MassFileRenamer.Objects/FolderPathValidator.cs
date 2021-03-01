using System.IO;

namespace MassFileRenamer.Objects
{
    public static class FolderPathValidator
    {
        public static bool PathContains(string folderPath, string findWhat)
            => folderPath.Contains(findWhat);

        public static bool ShouldSkipFolder(string folderPath)
            => string.IsNullOrWhiteSpace(folderPath) ||
               !Directory.Exists(folderPath) ||
               folderPath.Contains("packages") ||
               folderPath.Contains(".git") || folderPath.Contains(".vs") ||
               folderPath.Contains(@"\bin") || folderPath.Contains(@"\obj") ||
               Path.GetFileName(folderPath).StartsWith(".");
    }
}