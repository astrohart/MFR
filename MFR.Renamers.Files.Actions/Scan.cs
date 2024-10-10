using PostSharp.Patterns.Diagnostics;
using System;
using System.Linq;
using xyLOGIX.Core.Debug;

namespace MFR.Renamers.Files.Actions
{
    /// <summary>
    /// Exposes static methods to scan file data for patterns.
    /// </summary>
    public static class Scan
    {
        /// <summary>
        /// Scans the <paramref name="textToBeSearched" />, one character at a time, for
        /// any non-text ASCII control character bytes.
        /// </summary>
        /// <param name="textToBeSearched">
        /// (Required.) A <see cref="T:System.String" />
        /// containing the character-string representation of the contents of a file that
        /// is to be scanned.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if any non-text ASCII control characters are
        /// present in the specified <paramref name="textToBeSearched" />, or
        /// <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// If this method returns <see langword="true" />, then it can be safely
        /// assumed that the file from which the specified
        /// <paramref name="textToBeSearched" /> came is not an ASCII text file.
        /// </remarks>
        public static bool FileDataForBinaryControlCharacters(
            [NotLogged] string textToBeSearched
        )
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(textToBeSearched))
                    return result;

                result = textToBeSearched.Any(
                    c => xyLOGIX.Text.Actions.Is.ControlCharacter(c)
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }

            return result;
        }
    }
}