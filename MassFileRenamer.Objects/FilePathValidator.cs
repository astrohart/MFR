using System.IO;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Provides helper methods to validate file paths.
    /// </summary>
    public static class FilePathValidator
    {
        /// <summary>
        /// Determines whether the specified file-system
        /// <paramref
        ///     name="entry" />
        /// should be skipped during an operation.
        /// </summary>
        /// <param name="entry">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:MassFileRenamer.Objects.IFileSystemEntry" /> interface.
        /// </param>
        /// <returns>
        /// <c>true</c> is returned by this method if the file-system specified
        /// <paramref name="entry" /> is to be skipped by the operation;
        /// otherwise, <c>false</c> is returned.
        /// </returns>
        public static bool ShouldSkipFile(IFileSystemEntry entry)
            => entry == null || string.IsNullOrWhiteSpace(entry.Path) ||
               string.IsNullOrWhiteSpace(Path.GetExtension(entry.Path)) ||
               !File.Exists(entry.Path) || entry.Path.Contains("packages") ||
               entry.Path.Contains(".git") || entry.Path.Contains(".vs") ||
               entry.Path.Contains(@"\bin") || entry.Path.Contains(@"\obj") ||
               Path.GetFileName(entry.Path)
                   .StartsWith(".");
    }
}