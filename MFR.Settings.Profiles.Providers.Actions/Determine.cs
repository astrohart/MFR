using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether facts are true or false about data.
    /// </summary>
    public static class Determine
    {
        /// <summary>
        /// Determines whether the specified <paramref name="pathname" /> of a
        /// <c>profiles.json</c> file is valid.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a file to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// meets the validation criteria; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// In order to be valid, the specified <paramref name="pathname" /> must
        /// not be blank, must contain the fully-qualified pathname of a file that exists
        /// on the disk; and the filename of the file must be <c>profiles.json</c>.
        /// </remarks>
        public static bool WhetherProfileListPathIsValid(string pathname)
        {
            var result = false;

            try
            {
                result = !string.IsNullOrWhiteSpace(pathname) &&
                         File.Exists(pathname) &&
                         ProfileFile.DefaultFilename.Equals(Path.GetFileName(pathname));
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = false;
            }

            return result;
        }

        public static bool WhetherProfileListPathIsValidForSaving(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                result =
                    ProfileFile.DefaultFilename.Equals(
                        Path.GetFileName(pathname)
                    );
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