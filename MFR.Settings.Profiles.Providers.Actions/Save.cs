using Alphaleonis.Win32.Filesystem;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Registry.Helpers;
using MFR.Settings.Profiles.Providers.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xyLOGIX.Core.Debug;

namespace MFR.Settings.Profiles.Providers.Actions
{
    public static class Save
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

                saveProfilePathnameRegOperationMetadata = MakeNewRegOperationMetadata.FromScatch<string>()
                                           .ForKeyPath(regKeyPathname)
                                           .AndValueName(
                                               ProfilePathRegistry.ValueName
                                           )
                                           .WithValue(pathname);

                if (saveProfilePathnameRegOperationMetadata == null) return;


            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}
