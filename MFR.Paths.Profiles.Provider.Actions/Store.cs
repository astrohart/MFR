using Alphaleonis.Win32.Filesystem;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Paths.Profiles.Provider.Constants;
using MFR.Registry.Helpers;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for storing the pathname of a <c>profiles.json</c> file to the system Registry.
    /// </summary>
    public static class Store
    {
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
                if (!"profiles.json".Equals(Path.GetFileName(pathname))) return;

                var regKeyPathname =
                    Formulate.ProfileFilePathRegistryKeyPathname(
                        companyName, productName
                    );
                if (string.IsNullOrWhiteSpace(regKeyPathname)) return;
                if (!regKeyPathname.StartsWithValidHiveName()) return;

                IRegOperationMetadata<string>
                    saveProfilePathnameRegOperationMetadata = default;

                saveProfilePathnameRegOperationMetadata =
                    MakeNewRegOperationMetadata.FromScatch<string>()
                                               .ForKeyPath(regKeyPathname)
                                               .AndValueName(
                                                   ProfilePathRegistry.ValueName
                                               )
                                               .WithValue(pathname);

                if (saveProfilePathnameRegOperationMetadata == null) return;

                /*
GetSaveProfileCollectionPathCommand.ForPath(
                                       ProfileCollectionPathKeyName,
                                       ProfileCollectionPathValueName,
                                       _profileCollectionFilePath
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