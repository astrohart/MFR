using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Files.Actions;

namespace MFR.Settings.Configuration.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to make determinations on data.
    /// </summary>
    [Log(AttributeExclude = true)]
    public static class Determine
    {
        /// <summary>
        /// Determines the correct pathname to use for loading the application
        /// config.
        /// </summary>
        /// <param name="submittedPathname">
        /// (Required.) A <see cref="T:System.String" /> containing the fully-qualified
        /// pathname submitted to the
        /// <see
        ///     cref="M:MFR.Settings.Configuration.Providers.ProjectFileRenamerConfigProvider.Load" />
        /// method.
        /// </param>
        /// <param name="currentPathnameInRegistry">
        /// (Required.) A
        /// <see cref="T:System.String" /> containing the fully-qualified pathname of the
        /// application config file as read from the system Registry.
        /// </param>
        /// <returns>
        /// If the <paramref name="submittedPathname" /> is not blank and is set
        /// to the pathname of a file that exists on the disk, then the method returns that
        /// pathname; otherwise, the <paramref name="currentPathnameInRegistry" /> is
        /// returned.
        /// </returns>
        public static string CorrectPathForLoadingConfiguration(
            string submittedPathname,
            string currentPathnameInRegistry
        )
        {
            var result = submittedPathname;

            try
            {
                if (IsConfigPathValid(submittedPathname)) return result;

                result = currentPathnameInRegistry;
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
        /// Determines whether the specified <paramref name="pathname" /> of a
        /// <c>config.json</c> file is valid.
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
        /// on the disk; and the filename of the file must be <c>config.json</c>.
        /// </remarks>
        public static bool IsConfigPathValid(string pathname)
        {
            var result = false;

            try
            {
                result = Does.FileExist(pathname) &&
                         ConfigFile.DefaultFilename.Equals(
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

        public static bool IsConfigFilenameValid(string fileName)
        {
            var result = false;

            try
            {
                result =
                    !string.IsNullOrWhiteSpace(fileName)
                    && ConfigFile.DefaultFilename.Equals(
                        Path.GetFileName(fileName)
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