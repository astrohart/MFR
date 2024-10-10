using Alphaleonis.Win32.Filesystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Exposes static methods to fill text files with data.
    /// </summary>
    public static class FillTextFile
    {
        /// <summary>
        /// Fills a file with random garbage data of varying size.
        /// </summary>
        /// <param name="path">
        /// (Required.) Fully-qualified pathname to the file to be
        /// filled with the data.
        /// <para />
        /// This method throws <see cref="T:System.InvalidOperationException" /> if the
        /// pathname is not an absolute pathname to a file on the file system.
        /// </param>
        public static void WithJunk(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            var junk = string.Empty;

            var rng = new Random(
                Guid.NewGuid()
                    .GetHashCode()
            );
            for (var i = 0; i < rng.Next(0, 100); i++)
                junk += Guid.NewGuid()
                            .ToString("N");

            MakeSure.ContainingFolderExists(path);

            File.WriteAllText(path, junk);
        }
    }
}