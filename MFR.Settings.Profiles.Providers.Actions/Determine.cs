using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to determine whether facts are true or false about data.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class Determine
    {
        /// <summary>
        /// Determines whether a user-submitted path, or the pathname stored in the system
        /// Registry, is the correct pathname to be utilized for saving out
        /// config-setting profiles to the file system with.
        /// </summary>
        /// <param name="pathnameFromRegistry">
        /// (Required.) A <see cref="T:System.String" />
        /// that represents the profile list file pathname that is currently stored in the
        /// system Registry.
        /// </param>
        /// <param name="submittedPathname">
        /// (Required.) A <see cref="T:System.String" />
        /// containing user-submitted pathname for saving the profiles.
        /// </param>
        /// <returns>
        /// A <see cref="T:System.String" /> containing the correct pathname to be
        /// utilized for the <c>Save</c> operation.
        /// </returns>
        /// <remarks>
        /// The <paramref name="pathnameFromRegistry" /> takes precedence.
        /// <para />
        /// Neither the <paramref name="submittedPathname" />  nor the
        /// <paramref name="pathnameFromRegistry" /> have to represent a file that exists
        /// on the file system, since, if this the case, the file will be created by the Save
        /// operation.
        /// </remarks>
        public static string CorrectProfileListPathForSaving(
            string pathnameFromRegistry,
            string submittedPathname = ""
        )
        {
            var result = pathnameFromRegistry;

            try
            {
                if (!IsProfileListPathValidForSaving(submittedPathname))
                    return result;

                result = submittedPathname;
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = pathnameFromRegistry;
            }

            return result;
        }

        /// <summary>
        /// Returns a value that indicates whether the specified
        /// <paramref name="pathname" /> is valid for use in saving the user's favorite
        /// config-setting profiles out to the file system.
        /// </summary>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname that is to be checked.
        /// </param>
        /// <returns>
        /// <see langword="true" /> if the specified <paramref name="pathname" />
        /// is valid for saving; <see langword="false" /> otherwise.
        /// </returns>
        /// <remarks>
        /// A particular value of the <paramref name="pathname" />  is valid for
        /// saving if the specified value is non-blank and has a filename of
        /// <c>profiles.json</c>.
        /// </remarks>
        public static bool IsProfileListPathValidForSaving(string pathname)
        {
            var result = false;

            try
            {
                if (string.IsNullOrWhiteSpace(pathname)) return result;

                result =
                    Path.IsPathRooted(pathname)
                    && ProfileFile.DefaultFilename.Equals(
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
        /// on the file system; and the filename of the file must be <c>profiles.json</c>.
        /// </remarks>
        public static bool WhetherProfileListPathIsValid(string pathname)
        {
            var result = false;

            try
            {
                result = !string.IsNullOrWhiteSpace(pathname) &&
                         File.Exists(pathname) &&
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