using Alphaleonis.Win32.Filesystem;
using MFR.Detectors.Constants;
using MFR.FileSystem.Factories.Actions;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Detectors.Actions
{
    /// <summary>
    /// Exposes static methods to determine things about files.
    /// </summary>
    public static class Determine
    {
        /// <summary>
        /// Determines the number of bytes in a file.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file for which we want to obtain the size.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.Int64" /> value that is set to <c>-1</c> if an
        /// error occurred, or the length of the file in bytes.
        /// </returns>
        public static long FileSize(string pathname)
        {
            var result = -1L;

            try
            {
                if (!Does.FileExist(pathname)) return result;

                /*
                 * In principle, I hate doing this since we assume
                 * that there is a significant memory cost.
                 */

                result = new FileInfo(pathname).Length;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = -1L;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified ASCII character code, <paramref name="ch" />,
        /// represents or encodes any of the special ASCII control characters that would
        /// signify that a file is binary.
        /// </summary>
        /// <param name="ch"></param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="ch" /> is a ASCII control
        /// character code; <see langword="false" /> otherwise.
        /// </returns>
        public static bool WhetherCharacterIsControlCharacter(int ch)
        {
            var result = false;

            try
            {
                result =
                    (ch >= SpecialASCIIChars.NUL &&
                     ch < SpecialASCIIChars.BS) || (ch > SpecialASCIIChars.CR &&
                                                    ch <= SpecialASCIIChars
                                                        .SUB);
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }
    }
}