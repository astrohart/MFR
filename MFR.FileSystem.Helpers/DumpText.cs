using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories;
using MFR.FileSystem.Helpers.Properties;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.FileSystem.Helpers
{
    /// <summary>
    /// Exposes static methods to dump text to various output sources.
    /// </summary>
    public static class DumpText
    {
        /// <summary>
        /// Dumps the specified <paramref name="text" /> to a file in the current user's
        /// temporary files directory, and then returns the path to the file thusly
        /// created.
        /// </summary>
        /// <param name="text">
        /// (Required.) String containing the text to be written to the file.
        /// </param>
        /// <returns>
        /// String containing the fully-qualified pathname to the file where the
        /// specified <paramref name="text" /> was written.  If an exception occurred, such
        /// as File I/O error, then the return value of this method is the empty string.
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// Thrown if the required parameter,
        /// <paramref name="text" />, is passed a blank or <see langword="null" /> string
        /// for a value.
        /// </exception>
        public static string ToTempFile(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentException(
                    Resources.Error_ValueCannotBeNullOrWhiteSpace, nameof(text)
                );

            string result;

            try
            {
                result = Path.GetTempFileName();
                File.WriteAllText(result, text);

                /*
                 * Run a check to ensure that the file actually got written
                 * and that the data provided was written to it.
                 *
                 * This check uses the trigraph operator to be the identity map
                 * if the new file is valid (i.e, exists, has nonzero length, and
                 * its length matches that of the text submitted for writing) or
                 * replaces the result with the empty string if the file written
                 * fails to meet the conditions above (the empty string is a signal
                 * to the caller that the write operation failed).
                 */

                var resultantFile = MakeNewFileInfo.ForPath(result);
                result =
                    resultantFile.Exists && resultantFile.Length > 0 &&
                    resultantFile.Length == text.Length
                        ? result
                        : string.Empty;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = string.Empty;
            }

            return result;
        }
    }
}