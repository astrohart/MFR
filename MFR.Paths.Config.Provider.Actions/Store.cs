using Alphaleonis.Win32.Filesystem;
using MFR.Constants;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Paths.Config.Provider.Constants;
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
                

            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}