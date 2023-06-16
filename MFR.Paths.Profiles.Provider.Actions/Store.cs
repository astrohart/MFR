using Alphaleonis.Win32.Filesystem;
using MFR.Messages.Commands.Interfaces;
using MFR.Metadata.Registry.Factories;
using MFR.Metadata.Registry.Interfaces;
using MFR.Metadata.Registry.Validators.Factories;
using MFR.Metadata.Registry.Validators.Interfaces;
using MFR.Paths.Profiles.Provider.Constants;
using MFR.Registry.Helpers;
using MFR.Settings.Profiles.Commands.Constants;
using MFR.Settings.Profiles.Commands.Factories;
using System;
using xyLOGIX.Core.Debug;

namespace MFR.Paths.Profiles.Provider.Actions
{
    /// <summary>
    /// Exposes static methods for storing the pathname of a <c>profiles.json</c> file
    /// to the system Registry.
    /// </summary>
    public static class Store
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:MFR.Metadata.Registry.Validators.Interfaces.IRegOperationMetadataValidator
        /// 
        /// 
        /// 
        /// <T>" /> interface.
        /// </summary>
        private static IRegOperationMetadataValidator<string>
            AccessTheRegOperationMetadataValidator
        {
            get;
        } = GetRegOperationMetadataValidator<string>.SoleInstance();

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

                if (!AccessTheRegOperationMetadataValidator
                     .ForRegOperationMetadata(
                         saveProfilePathnameRegOperationMetadata
                     )
                     .Validate())
                    return;

                    ICommand<IRegOperationMetadata<string>>
                        saveProfilePathToRegistryCommand = default;

                saveProfilePathToRegistryCommand =
                    GetProfileCollectionCommand
                        .For<IRegOperationMetadata<string>>(
                            ProfileCollectionCommandType
                                .SaveProfileCollectionPathToRegistry
                        );
                if (saveProfilePathToRegistryCommand == null) return;

                saveProfilePathToRegistryCommand =
                    saveProfilePathToRegistryCommand.WithInput(
                        saveProfilePathnameRegOperationMetadata
                    );

                saveProfilePathToRegistryCommand.Execute();
            }
            catch (Exception ex)
            {
                // dump all the exception info to the log
                DebugUtils.LogException(ex);
            }
        }
    }
}