using System;
using System.IO;
using xyLOGIX.Core.Debug;

namespace MassFileRenamer.Objects
{
    /// <summary>
    /// Static methods to assist in processing files.
    /// </summary>
    public static class FileHelpers
    {
        /// <summary>
        /// Reads all the data in from the file whose pathname is given by the '
        /// <paramref name="path" /> parameter, caches it, and then returns it.
        /// </summary>
        /// <param name="path">
        /// (Required.) String containing the fully-qualified pathname of the
        /// file to be read.
        /// </param>
        /// <param name="pathFilter">
        /// (Optional.) Reference to an instance of <see cref="T:System.Func" />
        /// that points to a delegate, accepting the current file or folder's
        /// path as an argument, that returns <see langword="true" /> if the file should be
        /// included in the operation or <see langword="false" /> otherwise.
        /// <para />
        /// This parameter is <see langword="null" /> by default. This method should return
        /// <see langword="true" /> to specify that a given file-system entry is to be
        /// included in the output collection -- barring other inclusion/exclusion criteria.
        /// <para />
        /// In the event that this parameter is <see langword="null" />, no path filtering
        /// is done.
        /// </param>
        /// <returns>
        /// String containing the file's contents; otherwise, the empty string
        /// if the file does not meet the criteria specified in the path filter.
        /// </returns>
        public static string GetContent(string path,
            Predicate<string> pathFilter = null)
        {
            var result = string.Empty;

            if (string.IsNullOrWhiteSpace(path)) return result;

            if (!File.Exists(path)) return result;

            if (!(pathFilter?.Invoke(path) ?? true)) return result;

            try
            {
                result = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Fills a file with random garbage data of varying size.
        /// </summary>
        /// <param name="path">(Required.) Fully-qualified pathname to the file to be filled with the data.<para/>This method throws <see cref="T:System.InvalidOperationException" /> if the pathname is not an absolute pathname to a file on the disk.</param>
        public static void FillWithJunk(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            var junk = string.Empty;

            var rng = new Random(
                Guid.NewGuid()
                    .GetHashCode()
            );
            for (var i = 0;
                i < rng.Next(0, 100);
                i++)
                junk += Guid.NewGuid()
                            .ToString("N");

            File.WriteAllText(path, junk);
        }
    }
}