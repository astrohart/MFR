using Alphaleonis.Win32.Filesystem;
using MFR.Expressions.Registry.Factories;
using MFR.Expressions.Registry.Interfaces;
using MFR.FileSystem.Factories.Actions;
using MFR.FileSystem.Interfaces;
using MFR.Messages.Actions.Interfaces;
using MFR.Settings.Profiles.Actions.Constants;
using MFR.Settings.Profiles.Actions.Factories;
using MFR.Settings.Profiles.Providers.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
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
        /// <param name="currentPathname"></param>
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

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;
                if (Does.FileExist(currentPathname))
                    return result;

                result = GetProfileCollectionPathFromRegistry(
                    companyName, productName
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
            string companyName, string productName)
        {
            var result = string.Empty;

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
            string companyName, string productName)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName))
                    return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                /*
                 * Attempt to get a default value for the profiles.json file.
                 * We will have our Registry query use this value if the application
                 * cannot locate the pathname of the file it should use otherwise,
                 * in the system Registry.
                 */

                var defaultProfileCollectionPathname =
                    GetDefaultProfileCollectionPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(defaultProfileCollectionPathname))
                    return result;

                /*
                 * Formulate a Registry query expression that facilitates the application to look
                 * up the pathname of the profiles.json file in the system Registry.
                 */

                IRegQueryExpression<string> profilePathRegQueryExpression =
                    default;

                profilePathRegQueryExpression = MakeNewRegQueryExpression
                                                .FromScatch<string>()
                                                .ForKeyPath(
                                                    ProfilePathRegistry.KeyName
                                                )
                                                .AndValueName(
                                                    ProfilePathRegistry
                                                        .ValueName
                                                )
                                                .WithDefaultValue(
                                                    /*
                                                    * This is the default fully-qualified pathname
                                                    * of the file that is to be utilized if the value
                                                    * that is supposed to be stored in the system
                                                    * Registry cannot be found.
                                                    */
                                                    defaultProfileCollectionPathname
                                                );
                if (profilePathRegQueryExpression == null) return result;

                IAction<IRegQueryExpression<string>, IFileSystemEntry>
                    retrieveProfileCollectionPathnameFromRegistryAction =
                        default;

                retrieveProfileCollectionPathnameFromRegistryAction =
                    GetProfileCollectionAction
                        .For<IRegQueryExpression<string>, IFileSystemEntry>(
                            ProfileCollectionActionType.LoadStringFromRegistry
                        )
                        .WithInput(profilePathRegQueryExpression);
                if (retrieveProfileCollectionPathnameFromRegistryAction == null)
                    return result;

                IFileSystemEntry profileCollectionFileSystemEntry = default;

                profileCollectionFileSystemEntry =
                    retrieveProfileCollectionPathnameFromRegistryAction
                        .Execute();
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

        /// <summary>
        /// Attempts to get the fully-qualified Registry key pathname of the key storing
        /// the pathnames of the profile list and configuration files.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <returns>
        /// If successful, a <see cref="T:System.String" /> that contains the
        /// fully-qualified Registry key pathname of the key storing the pathnames of the
        /// profile list and configuration files.
        /// </returns>
        /// <remarks>
        /// If either of the required parameters, <paramref name="companyName" /> and
        /// <paramref name="productName" /> are passed the blank or <see langword="null" />
        /// value as an argument, then this method returns the
        /// <see cref="F:System.String.Empty" /> value.
        /// <para />
        /// The <see cref="F:System.String.Empty" /> value is also returned if an error
        /// occurs during the processing of the operation.
        /// </remarks>
        private static string GetProfileFilePathRegistryKeyPathname(
            string companyName, string productName)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return result;
                if (string.IsNullOrWhiteSpace(productName)) return result;

                result =
                    $@"HKEY_CURRENT_USER\SOFTWARE\{companyName}\{productName}\Paths";
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