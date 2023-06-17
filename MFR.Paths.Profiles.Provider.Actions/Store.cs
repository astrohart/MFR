using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Registry.Helpers;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for storing the pathnameToSave of a <c>profiles.json</c>
    /// file
    /// to the system Registry.
    /// </summary>
    public static class Store
    {
        /// <summary>
        /// Executes an operation to store the fully-qualified pathname of a
        /// <c>profiles.json</c> file into the system Registry.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name associated with the application.
        /// </param>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that contains the fully-qualified
        /// pathname of a <c>profiles.json</c> file that is to be stored in the system
        /// Registry.
        /// </param>
        /// <remarks>
        /// Configuration profiles let the user save a set of their previously-used
        /// settings to easily recall for later use.
        /// <para />
        /// If an error occurred during the operation, or the required information is
        /// missing, then this method does nothing.
        /// </remarks>
        public static void ProfileCollectionFilePathToRegistry(
            string companyName,
            string productName,
            string pathname
        )
        {
            try
            {
                if (string.IsNullOrWhiteSpace(companyName)) return;
                if (string.IsNullOrWhiteSpace(productName)) return;
                if (string.IsNullOrWhiteSpace(pathname)) return;
                if (!ProfileFile.DefaultFilename.Equals(
                        Path.GetFileName(pathname)
                    )) return;

                var regKeyPathname =
                    Formulate.ProfileFilePathRegistryKeyPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(regKeyPathname)) return;
                if (!regKeyPathname.StartsWithValidHiveName()) return;

                var saveProfilePathnameRegOperationMetadata =
                    Generate.RegOperationMetadataForSavingProfileCollectionPath(
                        regKeyPathname, pathname
                    );
                if (saveProfilePathnameRegOperationMetadata == null) return;

                var saveProfilePathnameToRegistryCommand =
                    Generate.SaveProfilePathToRegistryCommand(
                        saveProfilePathnameRegOperationMetadata
                    );
                if (saveProfilePathnameToRegistryCommand == null) return;

                Execute.OperationToSaveProfileCollectionFilePathToRegistry(
                    saveProfilePathnameToRegistryCommand
                );
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}