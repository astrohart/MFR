using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Registry.Helpers;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for storing the pathname of a <c>config.json</c> file to
    /// the system Registry.
    /// </summary>
    public static class Store
    {
        /// <summary>
        /// Saves the fully-qualified pathname of the application configuration file to the
        /// system Registry.
        /// </summary>
        /// <param name="companyName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the company name that is associated with the application.
        /// </param>
        /// <param name="productName">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the product name that is associated with the application.
        /// </param>
        /// <param name="pathname">
        /// (Required.) A <see cref="T:System.String" /> that
        /// contains the fully-qualified pathname of the application configuration file
        /// that is to be stored in the system Registry..
        /// </param>
        public static void ConfigFilePathToRegistry(
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
                if (!ConfigFile.DefaultFilename.Equals(
                        Path.GetFileName(pathname)
                    )) return;

                var regKeyPathname =
                    Formulate.ConfigFilePathRegistryKeyPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(regKeyPathname)) return;
                if (!regKeyPathname.StartsWithValidHiveName()) return;

                var saveConfigPathToRegistryMetadata =
                    Generate.RegOperationMetadataForSavingConfigPath(
                        regKeyPathname, pathname
                    );
                if (saveConfigPathToRegistryMetadata == null) return;

                var saveConfigPathToRegistryCommand =
                    Generate.SaveConfigPathToRegistryCommand(
                        saveConfigPathToRegistryMetadata
                    );
                if (saveConfigPathToRegistryCommand == null) return;

                Execute.OperationToSaveConfigFilePathToRegistry(
                    saveConfigPathToRegistryCommand
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