using Alphaleonis.Win32.Filesystem;
using MFR.FileSystem.Factories.Actions;
using MFR.Settings.Profiles.Providers.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    /// <summary>
    /// Exposes static methods to obtain and formulate various values.
    /// </summary>
    public static class Obtain
    {
        /// <summary>
        /// Attempts to determine the fully-qualified pathname of the <c>profiles.json</c>
        /// file that stores the user's saved configuration profiles.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns></returns>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the <c>profiles.json</c> file that contains the
        /// user's previously-saved configuration profiles.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the value of the
        /// <paramref name="currentPathname" />
        /// parameter.
        /// <para />
        /// <b>NOTE:</b> The <paramref name="currentPathname" /> is allowed to be passed
        /// the <see cref="F:System.String.Empty" /> value as its argument, so be mindful.
        /// </remarks>
        public static string ProfileCollectionFilePath(string companyName,
            string productName, string currentPathname = "")
        {
            var result = currentPathname;

            /*
             * OKAY, the objective of this method is to give the caller a
             * fully-qualified pathname to a profiles.json file to be used
             * for storing the user's saved configuration setting profiles.
             *
             * We formulate this using the name of the company associated with
             * this application and the product name to string together the
             * default pathname and the name of the key in the system Registry
             * under which the pathname is stored.
             *
             * If either of these pieces of info are blank, then stop.  The
             * currentPathname parameter allows us to return it as a default
             * value in case we otherwise fail.
             *
             * If the path listed in the argument of the currentPathname
             * parameter refers to a file on the disk that exists, then simply
             * return that pathname.  Otherwise, try to load the profiles.json
             * file's pathname from the system Registry.
             */

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;
                if (Does.FileExist(currentPathname))
                    return result;

                result = GetProfileCollectionPathFromRegistry(
                    companyName, productName, currentPathname
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);

                result = currentPathname;
            }

            return result;
        }

        /// <summary>
        /// Attempts to formulate a default value for the <c>profiles.json</c> file that
        /// contains the user's previously-saved configuration profiles.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// default fully-qualified pathname of the <c>profiles.json</c> value that should
        /// be used as a fallback in the event that a <c>profiles.json</c> file cannot be
        /// located either on the disk or in the system Registry.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        private static string GetDefaultProfileCollectionPathname(
            string companyName, string productName, string currentPathname = "")
        {
            var result = currentPathname;

            try
            {
                // %LOCALAPPDATA%\xyLOGIX, LLC\Project File Renamer\Config\profiles.json

                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                var localAppDataFolderPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData
                );
                if (string.IsNullOrWhiteSpace(localAppDataFolderPath))
                    return result;

                var companyProgramDataFolderPath = Path.Combine(
                    localAppDataFolderPath, companyName
                );
                if (string.IsNullOrWhiteSpace(companyProgramDataFolderPath))
                    return result;

                var profileCollectionFileFolder = Path.Combine(
                    companyProgramDataFolderPath, $@"{productName}\Config"
                );
                if (string.IsNullOrWhiteSpace(profileCollectionFileFolder))
                    return result;

                result = Path.Combine(
                    profileCollectionFileFolder, ProfileFile.DefaultFilename
                );
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
        /// Attempts to obtain the pathname of the file that contains the list of saved
        /// configuration profiles from the system Registry.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="currentPathname">
        /// (Optional.) A <see cref="T:System.String" /> that
        /// serves as a default return value for this method in case a failure mode is
        /// otherwise hit (blank input, missing file, missing Registry value, etc.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> containing the
        /// fully-qualified pathname of the <c>profiles.json</c> file that contains the
        /// user's previously-saved configuration profiles.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        private static string GetProfileCollectionPathFromRegistry(
            string companyName, string productName, string currentPathname = "")
        {
            var result = currentPathname;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName))
                    return result;
                if (string.IsNullOrWhiteSpace(productName))
                    return result;

                /*
                 * Attempt to get a default value for the profiles.json file.
                 * We will have our Registry query use this value if the application
                 * cannot locate the pathname of the file it should use otherwise,
                 * in the system Registry.
                 */

                var defaultProfileCollectionPathname =
                    GetDefaultProfileCollectionPathname(
                        companyName, productName, currentPathname
                    );
                if (string.IsNullOrWhiteSpace(defaultProfileCollectionPathname))
                    return result;

                /*
                 * Formulate a Registry query expression that facilitates the application to look
                 * up the pathname of the profiles.json file in the system Registry.
                 */

                var profilePathRegQueryExpression =
                    Generate.ProfilePathRegQueryExpression(
                        companyName, productName,
                        defaultProfileCollectionPathname
                    );
                if (profilePathRegQueryExpression == null) return result;

                /*
                 * OKAY, now get a reference to an action object (from our event-aggregation
                 * architecture) that loads the pathname of the profiles.json file for us from
                 * the system Registry.
                 */
                var retrieveProfileCollectionPathnameFromRegistryAction =
                    Generate
                        .RetrieveProfileCollectionPathnameFromRegistryAction(
                            profilePathRegQueryExpression
                        );
                if (retrieveProfileCollectionPathnameFromRegistryAction == null)
                    return result;

                /*
                 * FINALLY, actually execute the operation of reading the pathname of the
                 * profiles.json file that is stored in the system Registry.  We've also
                 * configured a default value that is to be utilized, in case the operation
                 * fails, such as if there isn't such a value in the system Registry.
                 */

                var profileCollectionFileSystemEntry =
                    Execute
                        .OperationToLoadProfileCollectionFilePathFromRegistry(
                            retrieveProfileCollectionPathnameFromRegistryAction
                        );
                if (profileCollectionFileSystemEntry == null) return result;
                if (string.IsNullOrWhiteSpace(
                        profileCollectionFileSystemEntry.Path
                    ))
                    return result;

                /*
                 * If we've got a non-blank pathname, then that's good enough.
                 * Whether File.Exists(profileCollectionFileSystemEntry.Path)
                 * returns true or not, at this juncture, is irrelevant, we just
                 * need a fucking pathname here, and we can check whether it refers
                 * to a file that exists on the disk, some other time.
                 */

                result = profileCollectionFileSystemEntry.Path;
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