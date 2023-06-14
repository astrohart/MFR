using Alphaleonis.Win32.Filesystem;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Paths.Config.Provider.Constants;
using MFR.Registry.Helpers;
using MFR.Settings.Configuration.Constants;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Config.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for storing the pathname of a <c>config.json</c> file to the system Registry.
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
                if (!"config.json".Equals(Path.GetFileName(pathname))) return;

                var regKeyPathname =
                    Formulate.ConfigFilePathRegistryKeyPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(regKeyPathname)) return;
                if (!regKeyPathname.StartsWithValidHiveName()) return;

                IRegOperationMetadata<string>
                    saveConfigPathnameRegOperationMetadata = default;

                saveConfigPathnameRegOperationMetadata =
                    MakeNewRegOperationMetadata.FromScatch<string>()
                                               .ForKeyPath(regKeyPathname)
                                               .AndValueName(
                                                   ConfigPathRegistry.ValueName
                                               )
                                               .WithValue(pathname);

                if (saveConfigPathnameRegOperationMetadata == null) return;

                /*
GetSaveConfigPathCommand.ForPath(
                                       ConfigPathKeyName,
                                       ConfigPathValueName,
                                       _configFilePath
                                   )
                                   .Execute();
*/

            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}