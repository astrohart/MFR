using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods to formulate data values from other data values.
    /// </summary>
    public static class Formulate
    {
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
        public static string ProfileFilePathRegistryKeyPathname(
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
        /// located either on the file system or in the system Registry.
        /// </returns>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred, or if required information is missing, during the
        /// operation, then this method returns the <see cref="F:System.String.Empty" />
        /// value.
        /// </remarks>
        public static string DefaultProfileCollectionPathname(
            string companyName,
            string productName,
            string currentPathname = ""
        )
        {
            var result = currentPathname;

            try
            {
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
    }
}